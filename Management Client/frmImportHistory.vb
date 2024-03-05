Public Class frmImportHistory

    Private Sub frmImportHistory_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public WriteOnly Property ImportTable() As DataTable

        Set(ByVal value As DataTable)
            gcHistory.DataSource = value
            gcHistory.RefreshDataSource()
        End Set

    End Property


    Private Sub SimpleButton1_Click(sender As System.Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class