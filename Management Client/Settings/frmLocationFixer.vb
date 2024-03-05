Public Class frmLocationFixer


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnSkip_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnSkip.Click
        Me.DialogResult = DialogResult.Ignore
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim obj As New Process
        obj.StartInfo.FileName = "http://www.streetmap.co.uk/idgc.srf?x=373515&y=405574&z=0&sv=bl4+4&st=2&pc=bl4&ar=N&mapp=idgc.srf&searchp=ids.srf&sq=1&ox=397977&oy=272432&ppm=bl4&ox=397977&oy=272432"
        obj.Start()

    End Sub
End Class