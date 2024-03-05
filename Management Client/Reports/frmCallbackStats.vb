Public Class frmCallbackStats
    Dim L As New List(Of cCallbackStats)
    Private Sub frmCallbackStats_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        deStart.EditValue = Now.AddDays(Now.Day * -1).AddDays(1)
        deEnd.EditValue = Now

    End Sub

    Private Sub RefreshForm()
        Me.Cursor = Cursors.WaitCursor
        L = New List(Of cCallbackStats)
        Dim database As New Common.DataLayer
        Dim ds As DataSet

        Dim startDate As String = CDate(deStart.EditValue).ToLongDateString & " 00:00:00"
        Dim EndDate As String = CDate(deEnd.EditValue).ToLongDateString & " 23:59:59"
        Dim ssql As String = "Select distinct UserID from companyhistory where callstartstatus='Callback' and callendstatus is not null and datecreated between '" & startDate & "' and '" & EndDate & "'"
        ds = database.ExecuteSQL(ssql)

        For Each dr As DataRow In ds.Tables(0).Rows
            L.Add(New cCallbackStats(CInt(dr("UserID")), startDate, EndDate))
        Next
        gv.DataSource = L
        Me.Cursor = Cursors.Default
        GridView1.BestFitColumns()
    End Sub

    Private Sub BtnRefresh_Click(sender As System.Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshForm()
    End Sub

    Private Sub ExportToXlsToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ExportToXlsToolStripMenuItem.Click
        If sfd.ShowDialog = DialogResult.OK Then
            GridView1.ExportToXls(sfd.FileName)
        End If
    End Sub
End Class