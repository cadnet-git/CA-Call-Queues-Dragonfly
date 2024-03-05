Public Class frmSelectUsers
    Private Sub frmSelectUsers_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim DS As DataSet
        Dim lvitem As ListViewItem
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSQL("Select ID,RealName from Users Where (UserLevelID =2 or UserLevelID =3) and status >1 order by UserlevelID")
        For Each DR As DataRow In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID") & " "
            lvitem.SubItems.Add(DR("RealName"))
            lvAll.Items.Add(lvitem)
        Next
        resizelists()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        For Each lvitem As ListViewItem In lvAll.SelectedItems
            lvitem.Remove()
            lvitem.Selected = False
            lvSelected.Items.Add(lvitem)
        Next
        resizelists()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        For Each lvitem As ListViewItem In lvSelected.SelectedItems
            lvitem.Remove()
            lvitem.Selected = False
            lvAll.Items.Add(lvitem)
        Next

        resizelists()

    End Sub

    Private Sub resizelists()
        Application.DoEvents()
        lvAll.Columns(1).Width = lvAll.ClientSize.Width
        lvSelected.Columns(1).Width = lvSelected.ClientSize.Width
        Button4.Enabled = lvSelected.Items.Count > 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button4.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnColdPot_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnColdPot.Click
        DialogResult = DialogResult.Yes
    End Sub
End Class