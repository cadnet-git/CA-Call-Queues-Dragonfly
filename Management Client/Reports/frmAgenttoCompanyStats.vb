Public Class frmAgenttoCompanyStats

    Private Sub frmImportStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        PBar.Visible = False
        RefreshBatches()
    End Sub

    Private Sub RefreshBatches()

        Me.Cursor = Cursors.WaitCursor

        Dim sSQL As String = "Select * from Users where userlevelID = 3   and status=2 order by realname"
        Dim DB As New Common.DataLayer
        Dim DS As DataSet = DB.ExecuteSQL(sSQL)

        Me.ListBox1.Items.Clear()
        Application.DoEvents()

        Me.ListBox1.SuspendLayout()

        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anItem As New Common.cSimpleItem(aRow.Item("ID"), aRow.Item("RealName"))
            Me.ListBox1.Items.Add(anItem)
            Application.DoEvents()
        Next
        Me.ListBox1.DisplayMember = "Title"

        Me.ListBox1.ResumeLayout()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.lblRecs.Text = ""
        Me.LblCalled.Text = ""
        Me.lblNotCalled.Text = ""

        Me.lblApps.Text = ""
        Me.lblCB.Text = ""
        Me.lblCold.Text = ""
        Me.lblSup.Text = ""
        Me.lblTPS.Text = ""
        Me.lblOOA.Text = ""
        Me.lblNaN.Text = ""
        Me.lblNTH.Text = ""
        Me.lblPCalled.Text = ""
        Me.lblPNotCalled.Text = ""
        Me.lblPapps.Text = ""
        Me.lblPCB.Text = ""
        Me.lblPCC.Text = ""
        Me.lblPSup.Text = ""
        Me.lblPTPS.Text = ""
        Me.lblPooA.Text = ""
        Me.lblPNaN.Text = ""
        Me.lblPNTH.Text = ""

    End Sub

    Private Sub RefreshList(ByVal BatchID() As Integer)

        Me.Cursor = Cursors.WaitCursor
        Dim DB As New Common.DataLayer
        Dim Counter As aCounter = New aCounter

        PBar.Visible = True
        PBar.Value = 0
        PBar.Maximum = BatchID.Length
        For Each ID As Integer In BatchID
            If ID <> 0 Then


                Dim Params As New Collection
                Dim parID As New SqlClient.SqlParameter("@BatchID", SqlDbType.Int)
                parID.Value = ID
                Params.Add(parID)
                Dim DS As DataSet = DB.ExecuteSP("spGetAgenttoCompanyStats", Params)
                Counter.Records = Counter.Records + DS.Tables(0).Rows(0).Item("Total")
                Counter.Called = Counter.Called + DS.Tables(1).Rows(0).Item("Total")
                Counter.NotCalled = Counter.NotCalled + DS.Tables(2).Rows(0).Item("Total")
                Counter.Appointments = Counter.Appointments + DS.Tables(4).Rows(0).Item("Total")
                Counter.OKrecs = Counter.OKrecs + DS.Tables(4).Rows(0).Item("Total")
                For Each DR As DataRow In DS.Tables(3).Rows
                    Select Case DR("CompanyStatus")
                        Case "Supervisor"
                            Counter.Supervisor = Counter.Supervisor + DR("Total")
                        Case "InvalidNumber"
                            Counter.NotANumber = Counter.NotANumber + DR("Total")
                        Case "TPS"
                            Counter.TPS = Counter.TPS + DR("Total")
                        Case "OutOfArea"
                            Counter.OutofArea = Counter.OutofArea + DR("Total")
                        Case "ColdCall"
                            Counter.ColdCall = Counter.ColdCall + DR("Total")
                            Counter.OKrecs = Counter.OKrecs + DR("Total")
                        Case "CallBack"
                            Counter.CallBack = Counter.CallBack + DR("Total")
                            Counter.OKrecs = Counter.OKrecs + DR("Total")
                        Case "NotToHand"
                            Counter.NotToHand = Counter.NotToHand + DR("Total")
                            Counter.OKrecs = Counter.OKrecs + DR("Total")
                        Case Else
                            MsgBox("Found another Status - " & DR("CompanyStatus"))
                    End Select
                Next
                PBar.Value = PBar.Value + 1
            End If
        Next

        ' Time to display results
        Me.lblRecs.Text = Format(Counter.Records, "#,##0")
        Me.LblCalled.Text = Format(Counter.Called, "#,##0")
        Me.lblNotCalled.Text = Format(Counter.NotCalled, "#,##0")

        Me.lblApps.Text = Format(Counter.Appointments, "#,##0")
        Me.lblCB.Text = Format(Counter.CallBack, "#,##0")
        Me.lblCold.Text = Format(Counter.ColdCall, "#,##0")
        Me.lblSup.Text = Format(Counter.Supervisor, "#,##0")
        Me.lblTPS.Text = Format(Counter.TPS, "#,##0")
        Me.lblOOA.Text = Format(Counter.OutofArea, "#,##0")
        Me.lblNaN.Text = Format(Counter.NotANumber, "#,##0")
        Me.lblNTH.Text = Format(Counter.NotToHand, "#,##0")

        If Counter.Called > 0 And Counter.Records > 0 Then
            Me.lblPCalled.Text = Format(Counter.Called / Counter.Records * 100, "##0.00")
        Else
            Me.lblPCalled.Text = 0
        End If

        If Counter.NotCalled > 0 And Counter.Records > 0 Then
            Me.lblPNotCalled.Text = Format(Counter.NotCalled / Counter.Records * 100, "##0.00")
        Else
            Me.lblPNotCalled.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.Appointments > 0 Then
            Me.lblPapps.Text = Format(Counter.Appointments / Counter.OKrecs * 100, "##0.00")
        Else
            Me.lblPapps.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.CallBack > 0 Then
            Me.lblPCB.Text = Format(Counter.CallBack / Counter.OKrecs * 100, "##0.00")
        Else
            Me.lblPCB.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.ColdCall > 0 Then
            Me.lblPCC.Text = Format(Counter.ColdCall / Counter.OKrecs * 100, "##0.00")
        Else
            Me.lblPCC.Text = 0
        End If
        If Counter.Called > 0 And Counter.Supervisor > 0 Then
            Me.lblPSup.Text = Format(Counter.Supervisor / Counter.Called * 100, "##0.00")
        Else
            Me.lblPSup.Text = 0
        End If
        If Counter.Called > 0 And Counter.TPS > 0 Then
            Me.lblPTPS.Text = Format(Counter.TPS / Counter.Called * 100, "##0.00")
        Else
            Me.lblPTPS.Text = 0
        End If
        If Counter.Called > 0 And Counter.OutofArea > 0 Then
            Me.lblPooA.Text = Format(Counter.OutofArea / Counter.Called * 100, "##0.00")
        Else
            Me.lblPooA.Text = 0
        End If
        If Counter.Called > 0 And Counter.NotANumber > 0 Then
            Me.lblPNaN.Text = Format(Counter.NotANumber / Counter.Called * 100, "##0.00")
        Else
            Me.lblPNaN.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.NotToHand > 0 Then
            Me.lblPNTH.Text = Format(Counter.NotToHand / Counter.OKrecs * 100, "##0.00")
        Else
            Me.lblPNTH.Text = 0
        End If
        PBar.Visible = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Class aCounter
        Public Records As Integer = 0

        Public Called As Integer = 0
        Public NotCalled As Integer = 0

        Public Appointments As Integer = 0
        Public CallBack As Integer = 0
        Public ColdCall As Integer = 0
        Public TPS As Integer = 0
        Public NotANumber As Integer = 0
        Public Supervisor As Integer = 0
        Public OutofArea As Integer = 0
        Public NotToHand As Integer = 0
        Public OKrecs As Integer = 0
    End Class


    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub BtnRefesh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefesh.Click
        Dim anItem As Common.cSimpleItem = Me.ListBox1.SelectedItem

        Dim ID(ListBox1.SelectedItems.Count) As Integer
        Dim iCount As Integer = 0
        For Each Obj As Common.cSimpleItem In ListBox1.SelectedItems

            If Obj.Value <> 0 Then
                ID(iCount) = Obj.Value
            End If
            iCount += 1
        Next
        RefreshList(ID)
    End Sub

    Private Sub pnlAreaHeader_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAreaHeader.Paint

    End Sub
End Class