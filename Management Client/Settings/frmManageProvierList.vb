Public Class frmManageProvierList
    Dim d As New Common.DataLayer
    Private Sub frmManageProvierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        BtnSave.Text = "Create"
    End Sub
    Private Sub RefreshGrid()
        Dim ds As DataSet = d.ExecuteSQL("SELECT ID, Description FROM Insurers order by description")
        Grid.DataSource = ds.Tables(0)
        Grid.RefreshDataSource()
        txtProvider.Text = ""
        dvr = Nothing

    End Sub



    Private _dvr As DataRowView
    Public Property dvr() As DataRowView
        Get
            Return _dvr
        End Get
        Set(ByVal value As DataRowView)
            _dvr = value
            If dvr Is Nothing Then
                BtnSave.Text = "Create"
            Else
                BtnSave.Text = "Save"
            End If
        End Set
    End Property



    Private Sub Grid_Click(sender As Object, e As EventArgs) Handles Grid.Click
        dvr = GridView1.GetFocusedRow()
        txtProvider.Text = dvr("Description").ToString
    End Sub


    Private Sub BtnDelete_Click(sender As System.Object, e As EventArgs) Handles BtnDelete.Click
        If dvr Is Nothing = False Then
            If MsgBox(String.Format("Area you sure you want to delete{0}{0}{1}", vbCrLf, dvr("Description")), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                d.ExecuteSQL("DELETE from Insurers where ID= " & dvr("ID"))
                RefreshGrid()
            End If
        End If

    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As EventArgs) Handles BtnSave.Click
        If dvr Is Nothing = False Then
            d.ExecuteSQL(String.Format("UPDATE  Insurers SET Description = '{0}' where ID= {1}", txtProvider.Text, dvr("ID")))
            RefreshGrid()
        Else
            d.ExecuteSQL(String.Format("INsert into Insurers (Description) values ('{0}')", txtProvider.Text))
            RefreshGrid()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class