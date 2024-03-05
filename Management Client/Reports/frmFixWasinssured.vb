Public Class frmFixWasinssured
    Dim d As New Common.DataLayer
    Private Sub frmFixWasinssured_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        refreshgrid()
    End Sub

    Private Sub refreshgrid()
        Dim ds As DataSet = d.ExecuteSQL("Select d.ID,c.CompanyName,d.WasInsured from DiaryItems d inner join companies c on c.id= d.companyID where itemdate> '1 January 2013 00:00:01' and type='CA' order by WasInsured")
        Grid.DataSource = ds.Tables(0)
        Grid.RefreshDataSource()
    End Sub




    Private Sub GridView1_DoubleClick(sender As System.Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim dvr As DataRowView = GridView1.GetFocusedRow()
        Using a As New frmAppoinmentDetail(dvr("ID"))
            a.ShowDialog()
        End Using
        refreshgrid()
    End Sub
End Class