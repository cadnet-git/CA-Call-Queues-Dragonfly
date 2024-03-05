Public Class frmAgentApps

    Dim WithEvents pd As Printing.PrintDocument

    Public PageCount As Integer
    Public Thispage As Integer

    Dim StartDate As DateTime
    Dim endDate As DateTime
    Dim Reps As Collection
    Dim Rep As ManagerConsole.AppointmentStats


    Dim printFont = New Font("Times New Roman", 10)
    Dim printFontB = New Font("Times New Roman", 11, FontStyle.Bold)
    Dim printFontBig = New Font("Times New Roman", 14, FontStyle.Bold)
    Dim printFontTitle = New Font("Times New Roman", 16, FontStyle.Bold)
    Dim printFontI = New Font("Times New Roman", 9, FontStyle.Italic)
    Dim printFontS = New Font("Times New Roman", 9)
    Dim printFontTotals = New Font("Times New Roman", 11)
    Dim printFontTotalsB = New Font("Times New Roman", 11, FontStyle.Bold)
    Dim printFontSm = New Font("Times New Roman", 8, FontStyle.Italic)

    Dim stringSize As New SizeF


    Private Sub frmDailyStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        StartDate = Now.ToLongDateString
        endDate = StartDate.AddDays(1)

        Dim DS As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        DS = Database.ExecuteSQL("Select * From Users where Status=2 and (userlevelId=2 or userlevelId=3)")

        Dim temp As New Common.cSimpleItem(-1, "All Agents")
        cbAgent.Items.Add(temp)
        cbAgent.SelectedItem = temp
        For Each row As DataRow In DS.Tables(0).Rows
            temp = New Common.cSimpleItem(row("ID"), row("RealName"))
            cbAgent.Items.Add(temp)
        Next
        cbAgent.DisplayMember = "Title"
        cbAgent.ValueMember = "Value"


        EndDP.Value = endDate
        DTP1.Value = Now
        Dtime1.Text = "9:00"
        Dtime2.Text = "9:00"
    End Sub
    Private Sub RefreshStats()
        Me.Cursor = Cursors.WaitCursor
        Dim DS As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection

        Dim temp As Common.cSimpleItem = cbAgent.SelectedItem
        Dim parAgentID As New SqlClient.SqlParameter("@AgentID", SqlDbType.Int)

        parAgentID.Value = temp.Value
        Params.Add(parAgentID)

        Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parDeskID.Value = StartDate.ToLongDateString & " " & Dtime1.Text
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parStatus.Value = endDate.ToLongDateString & " " & Dtime2.Text
        Params.Add(parStatus)

        DS = Database.ExecuteSP("getAgentApps", Params)

        progress.Value = 0
        progress.Maximum = DS.Tables(0).Rows.Count

        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        lblHold.Text = 0
        lblGood.Text = 0
        lblBad.Text = 0
        lblFuture.Text = 0
        Dim tempDate As DateTime
        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = New ListViewItem
            ' update screen

            LVitem.Text = DR("ID")
            tempDate = DR("Created")
            LVitem.SubItems.Add(tempDate.ToLongDateString & " " & tempDate.ToShortTimeString)
            LVitem.SubItems.Add(DR("Agent"))
            LVitem.SubItems.Add(DR("CompanyName"))
            LVitem.SubItems.Add(DR("Rep"))
            LVitem.SubItems.Add(DR("itemDate"))
            LVitem.SubItems.Add(DR("Title"))
            tempDate = DR("itemDate")

            Select Case DR("Status")
                Case 0
                    LVitem.BackColor = Color.NavajoWhite
                    lblHold.Text = lblHold.Text + 1
                Case -1, -2 ' dead agent and admin
                    LVitem.BackColor = Color.LightPink
                    lblBad.Text = lblBad.Text + 1
                Case Else
                    If tempDate < Now Then
                        lblGood.Text = lblGood.Text + 1
                        LVitem.BackColor = Color.LightGreen
                    Else
                        lblFuture.Text = lblFuture.Text + 1
                    End If
            End Select

            LVStats.Items.Add(LVitem)
        Next
        Me.Cursor = Cursors.Default
    End Sub





    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DTP1.ValueChanged
        StartDate = DTP1.Value.ToLongDateString
    End Sub



    Private Sub EndDP_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EndDP.ValueChanged
        endDate = EndDP.Value.ToLongDateString & " 23:59:59"
    End Sub





End Class