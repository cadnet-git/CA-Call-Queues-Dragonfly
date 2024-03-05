Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmCheckCallbacks2

    Private Sub frmCheckCallbacks2_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim d As New Common.DataLayer
        Cursor = Cursors.WaitCursor
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim ds As DataSet
        ds = d.ExecuteSP("SpGetCallbacks2")
        GridControl1.DataSource = ds.Tables(0)
        Cursor = Cursors.Default

    End Sub



    Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)

        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRow OrElse info.InRowCell Then
            Dim dr As DataRow = GridView1.GetDataRow(info.RowHandle)
            Using cfrm As New frmShowCompany(dr("ID"))
                cfrm.ShowDialog()
            End Using

        End If
    End Sub



    Private Sub ExportToXlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ExportToXlsToolStripMenuItem.Click
        If sfd.ShowDialog = DialogResult.OK Then
            GridView1.ExportToXls(sfd.FileName)
        End If
    End Sub


End Class