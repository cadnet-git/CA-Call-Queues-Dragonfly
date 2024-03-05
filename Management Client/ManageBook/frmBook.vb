Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmBook
    Dim d As New Common.DataLayer
    Public Property Type As String = "Sale"
    Private Sub frmCheckCallbacks2_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load


        Cursor = Cursors.WaitCursor
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        RefreshgGrid()
        Cursor = Cursors.Default

    End Sub

    Private Sub RefreshgGrid()
        Dim params As New Collection
        d.CreateParameter(params, "@Type", SqlDbType.NVarChar, Type)
        Dim ds As DataSet = d.ExecuteSP("SpGetBookRecords", params)
        GridControl1.DataSource = ds.Tables(0)
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


    Private Sub ExportToXlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        If sfd.ShowDialog = DialogResult.OK Then
            GridView1.ExportToXls(sfd.FileName)
        End If
    End Sub



    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim drv As DataRowView = GridView1.GetFocusedRow
        Using afrm As New frmShowCompany(drv("ID"))
            afrm.BtnReturnToDB.Visible = True
            afrm.BtnChangeAgent.Visible = False
            afrm.ShowDialog()
            RefreshgGrid()
        End Using

    End Sub


End Class