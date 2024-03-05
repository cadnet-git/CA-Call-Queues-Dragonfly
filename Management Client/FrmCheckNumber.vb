Public Class FrmCheckNumber

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnOK.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        ' need to put back into Dialer
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub FrmCheckNumber_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class