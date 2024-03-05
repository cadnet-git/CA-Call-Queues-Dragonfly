Public Class frmSelectAreasForRep

    Private dsAreas As DataSet

    Private Sub frmSelectAreasForRep_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.lvwAreas.HeaderStyle = ColumnHeaderStyle.None

        'get the unallocated areas
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        dsAreas = Database.ExecuteSP("spAreasGetUnallocated")

        'cant bind the listview, so need ot redraw it....
        RefreshView()

    End Sub

    Private Sub RefreshView()
        'clear and draw the list view
        Me.lvwAreas.Items.Clear()

        For Each aRow As DataRowView In dsAreas.Tables(0).DefaultView
            Dim anItem As ListViewItem = Me.lvwAreas.Items.Add(Common.TitleCase(aRow.Item("Title")))
            anItem.Tag = aRow.Item("ID")
        Next
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        dsAreas.Tables(0).DefaultView.RowFilter = "title like '%" & Me.TextBox1.Text & "%'"
        RefreshView()
    End Sub

    Private Sub lvwAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lvwAreas.SelectedIndexChanged
        If Me.lvwAreas.SelectedItems.Count > 0 Then
            Me.btnAdd.Enabled = True
        Else
            Me.btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdd.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class