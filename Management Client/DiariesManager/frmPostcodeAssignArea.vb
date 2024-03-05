Public Class frmPostcodeAssignArea

    Private Sub frmPostcodeAssignArea_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadAreas()
    End Sub

    Public ReadOnly Property AreaID() As Integer
        Get
            AreaID = Me.ListView1.SelectedItems(0).Tag
        End Get
    End Property

    Private Sub LoadAreas()
        Dim sSQL As String = "Select * from Areas order by title"
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        Me.ListView1.Items.Clear()
        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anItem As ListViewItem = Me.ListView1.Items.Add(Common.TitleCase(aRow.Item("Title")))
            anItem.Tag = aRow.Item("ID")
        Next

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.btnOK.Enabled = True
        Else
            Me.btnOK.Enabled = False
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub
End Class