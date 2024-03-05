Public Class frmGetConsent
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        If txtName.Text = "" Then
            txtName.BackColor = Color.LightSalmon
            Return
        End If
        DialogResult = DialogResult.No
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        If txtName.Text = "" Then
            txtName.BackColor = Color.LightSalmon
            Return
        End If
        DialogResult = DialogResult.Yes
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        txtName.BackColor = Color.White
    End Sub

    Private Sub frmGetConsent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GivenDate.Value = DateTime.Today
    End Sub
End Class