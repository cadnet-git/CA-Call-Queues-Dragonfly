Public Class frmSelectUser

    Private Sub frmSelectUser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim DS As DataSet
        Dim lvitem As ListViewItem
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSQL("Select ID,RealName from Users Where (UserLevelID =2 or UserLevelID =3) and status >1 order by RealName ")

        For Each DR As DataRow In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID") & " "
            lvitem.SubItems.Add(DR("RealName").ToString)
            lvAll.Items.Add(lvitem)
        Next
    End Sub

    Private Sub btncancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        If lvAll.SelectedItems.Count > 0 Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub lvAll_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvAll.SelectedIndexChanged

    End Sub
End Class