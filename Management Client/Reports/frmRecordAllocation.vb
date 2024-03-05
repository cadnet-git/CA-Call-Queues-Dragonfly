Public Class frmRecordAllocation
 
    Private Sub frmRecordAllocation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim DS As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        DS = Database.ExecuteSP("spCompanyAllocations")

        PivotGridControl1.DataSource = DS.Tables(0)
        PivotGridControl1.RefreshData()

    End Sub

    Private Sub ExportToXlsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportToXlsToolStripMenuItem.Click
        If sfd.ShowDialog = DialogResult.OK Then
            PivotGridControl1.ExportToXls(sfd.FileName)
        End If
    End Sub
End Class