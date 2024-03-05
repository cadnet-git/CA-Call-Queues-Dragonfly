Public Class frmDailyStats
    Dim StartDate As DateTime
    Dim endDate As DateTime
    Private Sub frmDailyStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        StartDate = Now.ToLongDateString & " 00:00:00"
        endDate = StartDate.AddDays(1)

        DTP1.Value = Now
        RefreshStats()

    End Sub
    Private Sub RefreshStats()
        Me.Cursor = Cursors.WaitCursor
        Dim DS As DataSet
        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSQL("Select ID,RealName from Users Where (UserLevelID =2 or UserLevelID =3) and status >1 order by UserlevelID")
        LVitem = New ListViewItem
        LVitem.Text = "-2 "
        LVitem.SubItems.Add("Office")
        For t As Integer = 1 To 12
            LVitem.SubItems.Add("0")
        Next
        LVStats.Items.Add(LVitem)

        LVitem = New ListViewItem
        LVitem.Text = "-1 "
        LVitem.SubItems.Add("")
        For t As Integer = 1 To 12
            LVitem.SubItems.Add("0")
        Next
        LVStats.Items.Add(LVitem)
        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("ID") & " "
            LVitem.SubItems.Add(DR("RealName"))
            For t As Integer = 1 To 11
                LVitem.SubItems.Add("0")
            Next
            LVStats.Items.Add(LVitem)
        Next

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parDeskID.Value = StartDate
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parStatus.Value = endDate
        Params.Add(parStatus)

        DS = Database.ExecuteSP("SpGetStats", Params)

        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = LVStats.FindItemWithText(DR("UserID") & " ")

            If Not LVitem Is Nothing Then
                LVitem.SubItems(2).Text = LVitem.SubItems(2).Text + 1
                If DR("NewCall") = 0 Then
                    LVitem.SubItems(3).Text = LVitem.SubItems(3).Text + 1
                End If
                Dim Col As Integer = 0
                Select Case DR("CallEndStatus")
                    Case "Appointment"
                        Col = 4
                    Case "CallBack"
                        Col = 5
                    Case "Reschedule"
                        Col = 6
                    Case "NotToHand"
                        Col = 7
                    Case "NotInterested"
                        Col = 8
                    Case "Supervisor"
                        Col = 9
                    Case "OutOfArea"
                        Col = 10
                    Case "TPS"
                        Col = 11
                    Case "NumberNotRecognised"
                        Col = 12
                    Case Else
                        MsgBox(DR("CallEndStatus"))
                End Select
                If Col > 0 Then
                    LVitem.SubItems(Col).Text = LVitem.SubItems(Col).Text + 1
                End If

            End If
        Next

        For Each LVitem In LVStats.Items
            If LVitem.SubItems(2).Text <> "" And LVitem.SubItems(2).Text <> "Office" Then
                For t As Integer = 2 To 12
                    If LVitem.SubItems(t).Text <> "" Then
                        LVStats.Items(0).SubItems(t).Text = CInt(LVStats.Items(0).SubItems(t).Text) + CInt(LVitem.SubItems(t).Text)
                    End If
                Next
            End If
        Next

        ' tidy up remove subitems still at 0

        For Each LVitem In LVStats.Items
            For t As Integer = 2 To 12
                If LVitem.SubItems(t).Text = "0" Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next
        Next


        If ShowAsPercent.Checked Then
            For Each LVitem In LVStats.Items
                If LVitem.SubItems(2).Text <> "" Then
                    For t As Integer = 3 To 12
                        If LVitem.SubItems(t).Text <> "" Then
                            LVitem.SubItems(t).Text = Format(CInt(((LVitem.SubItems(t).Text / LVitem.SubItems(2).Text)) * 1000) / 10, "##0.0")
                        End If
                    Next
                End If

            Next
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DTP1.ValueChanged
        StartDate = DTP1.Value.ToLongDateString & " 00:00:00"
        endDate = StartDate.AddDays(1)
        RefreshStats()
    End Sub

    Private Sub ShowAsPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ShowAsPercent.CheckedChanged
        Application.DoEvents()
        RefreshStats()
    End Sub

    Private Sub TPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TPSToolStripMenuItem.Click
        ShowDetails("TPS", "TPS")
    End Sub

    Private Sub OutOfAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OutOfAreaToolStripMenuItem.Click
        ShowDetails("Out of Area", "OutOfArea")
    End Sub
    Private Sub ShowDetails(ByVal Title As String, ByVal type As String)
        Me.Cursor = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim dFrm As New frmStatsDrillDown
        dFrm.TopLevel = False

        dFrm.lblType.Text = Title ' what displays 
        dFrm.LBLuser.Text = Me.LVStats.SelectedItems(0).SubItems(1).Text
        dFrm.LoadData(type, Me.LVStats.SelectedItems(0).SubItems(0).Text, StartDate, endDate)

        Me.Parent.Controls.Add(dFrm)
        Me.Hide()
        With dFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With
        Me.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SupervisorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SupervisorToolStripMenuItem.Click
        ShowDetails("Supervisor Attention", "Supervisor")
    End Sub

    Private Sub NotInterestedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotInterestedToolStripMenuItem.Click
        ShowDetails("Not Interested", "NotInterested")
    End Sub

    Private Sub NotANumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotANumberToolStripMenuItem.Click

        ShowDetails("Not a Number", "NumberNotRecognised")
    End Sub

    Private Sub Lists_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lists.Opening
        If Me.LVStats.SelectedItems.Count > 0 Then

            If LVStats.SelectedItems(0).SubItems(2).Text = "" Then
                ' no agent
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CallBacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CallBacksToolStripMenuItem.Click

        Using Afrm As New frmTodaysCallbacksByAgent(Me.LVStats.SelectedItems(0).SubItems(0).Text, Me.LVStats.SelectedItems(0).SubItems(1).Text, Me.DTP1.Value)
            Afrm.ShowDialog()
        End Using


    End Sub
End Class