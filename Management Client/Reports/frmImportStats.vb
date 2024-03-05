Public Class frmImportStats



    Private Sub frmImportStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        PBar.Visible = False
        RefreshBatches()

    End Sub

    Private Sub RefreshBatches()

        Cursor = Cursors.WaitCursor

        Dim DB As New Common.DataLayer
        Dim DS As DataSet = DB.ExecuteSQL("Select * from ImportBatches where Filename <>'Agent edited company' and Filename<>'User Created Company' order by ImportDate desc")

        ListBox1.Items.Clear()
        Application.DoEvents()

        ListBox1.SuspendLayout()

        For Each aRow As DataRow In DS.Tables(0).Rows

            Dim sTitle As String = ""
            sTitle = CDate(aRow.Item("ImportDate")).ToShortDateString
            sTitle = String.Format("{0} - {1}", sTitle, System.IO.Path.GetFileName(aRow.Item("Filename")))

            Dim anItem As New Common.cSimpleItem(aRow.Item("ID"), sTitle)

            ListBox1.Items.Add(anItem)

            Application.DoEvents()
        Next

        ListBox1.DisplayMember = "Title"

        ListBox1.ResumeLayout()
        Cursor = Cursors.Default

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        lblRecs.Text = ""
        LblCalled.Text = ""
        lblNotCalled.Text = ""

        lblApps.Text = ""
        lblCB.Text = ""
        lblCold.Text = ""
        lblSup.Text = ""
        lblTPS.Text = ""
        lblOOA.Text = ""
        lblNaN.Text = ""
        lblNTH.Text = ""
        lblPCalled.Text = ""
        lblPNotCalled.Text = ""
        lblPapps.Text = ""
        lblPCB.Text = ""
        lblPCC.Text = ""
        lblPSup.Text = ""
        lblPTPS.Text = ""
        lblPooA.Text = ""
        lblPNaN.Text = ""
        lblPNTH.Text = ""
        lblSales.Text = ""
        lblSalesPercent.Text = ""
    End Sub

    Private Sub RefreshList(ByVal BatchID() As Integer)

        Cursor = Cursors.WaitCursor
        Dim DB As New Common.DataLayer
        Dim Counter As aCounter = New aCounter

        PBar.Visible = True
        PBar.Value = 0
        PBar.Maximum = BatchID.Length
        For Each ID As Integer In BatchID
            Dim Params As New Collection
            Dim parID As New SqlClient.SqlParameter("@BatchID", SqlDbType.Int) With {.Value = ID}
            Params.Add(parID)
            Dim DS As DataSet = DB.ExecuteSP("spGetImportBatchStats", Params)
            Counter.Records = Counter.Records + DS.Tables(0).Rows(0).Item("Total")
            Counter.Called = Counter.Called + DS.Tables(1).Rows(0).Item("Total")
            Counter.NotCalled = Counter.NotCalled + DS.Tables(2).Rows(0).Item("Total")
            Counter.Appointments = Counter.Appointments + DS.Tables(4).Rows(0).Item("Total")
            Counter.OKrecs = Counter.OKrecs + DS.Tables(4).Rows(0).Item("Total")
            Counter.Sales = Counter.Sales + DS.Tables(5).Rows(0).Item("Total")
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
        Next

        ' Time to display results
        lblRecs.Text = Format(Counter.Records, "#,##0")
        LblCalled.Text = Format(Counter.Called, "#,##0")
        lblNotCalled.Text = Format(Counter.NotCalled, "#,##0")

        lblApps.Text = Format(Counter.Appointments, "#,##0")
        lblSales.Text = Format(Counter.Sales, "#,##0")
        lblCB.Text = Format(Counter.CallBack, "#,##0")
        lblCold.Text = Format(Counter.ColdCall, "#,##0")
        lblSup.Text = Format(Counter.Supervisor, "#,##0")
        lblTPS.Text = Format(Counter.TPS, "#,##0")
        lblOOA.Text = Format(Counter.OutofArea, "#,##0")
        lblNaN.Text = Format(Counter.NotANumber, "#,##0")
        lblNTH.Text = Format(Counter.NotToHand, "#,##0")

        If Counter.Called > 0 And Counter.Records > 0 Then
            lblPCalled.Text = Format(Counter.Called / Counter.Records * 100, "##0.00")
        Else
            lblPCalled.Text = 0
        End If

        If Counter.NotCalled > 0 And Counter.Records > 0 Then
            lblPNotCalled.Text = Format(Counter.NotCalled / Counter.Records * 100, "##0.00")
        Else
            lblPNotCalled.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.Appointments > 0 Then
            lblPapps.Text = Format(Counter.Appointments / Counter.OKrecs * 100, "##0.00")
        Else
            lblPapps.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.Sales > 0 Then
            lblSalesPercent.Text = Format(Counter.Sales / Counter.OKrecs * 100, "##0.00")
        Else
            lblSalesPercent.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.CallBack > 0 Then
            lblPCB.Text = Format(Counter.CallBack / Counter.OKrecs * 100, "##0.00")
        Else
            lblPCB.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.ColdCall > 0 Then
            lblPCC.Text = Format(Counter.ColdCall / Counter.OKrecs * 100, "##0.00")
        Else
            lblPCC.Text = 0
        End If
        If Counter.Called > 0 And Counter.Supervisor > 0 Then
            lblPSup.Text = Format(Counter.Supervisor / Counter.Called * 100, "##0.00")
        Else
            lblPSup.Text = 0
        End If
        If Counter.Called > 0 And Counter.TPS > 0 Then
            lblPTPS.Text = Format(Counter.TPS / Counter.Called * 100, "##0.00")
        Else
            lblPTPS.Text = 0
        End If
        If Counter.Called > 0 And Counter.OutofArea > 0 Then
            lblPooA.Text = Format(Counter.OutofArea / Counter.Called * 100, "##0.00")
        Else
            lblPooA.Text = 0
        End If
        If Counter.Called > 0 And Counter.NotANumber > 0 Then
            lblPNaN.Text = Format(Counter.NotANumber / Counter.Called * 100, "##0.00")
        Else
            lblPNaN.Text = 0
        End If

        If Counter.OKrecs > 0 And Counter.NotToHand > 0 Then
            lblPNTH.Text = Format(Counter.NotToHand / Counter.OKrecs * 100, "##0.00")
        Else
            lblPNTH.Text = 0
        End If
        PBar.Visible = False
        Cursor = Cursors.Default
    End Sub
    Private Class aCounter
        Public Records As Integer

        Public Called As Integer
        Public NotCalled As Integer

        Public Appointments As Integer
        Public CallBack As Integer
        Public ColdCall As Integer
        Public TPS As Integer
        Public NotANumber As Integer
        Public Supervisor As Integer
        Public OutofArea As Integer
        Public NotToHand As Integer
        Public OKrecs As Integer
        Public Sales As Integer
    End Class



    Private Sub BtnRefesh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefesh.Click
        Dim ID(ListBox1.SelectedItems.Count) As Integer
        Dim iCount As Integer = 0
        For Each Obj As Common.cSimpleItem In ListBox1.SelectedItems
            iCount += 1
            ID(iCount) = Obj.Value
        Next
        RefreshList(ID)
    End Sub


End Class