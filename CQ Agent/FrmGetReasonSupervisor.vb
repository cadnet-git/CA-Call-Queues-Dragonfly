Public Class FrmGetReasonSupervisor

    Private Sub frmGetReason_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtReason_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtReason.TextChanged
        If Me.txtReason.Text.Length > 0 Then
            Me.btnOK.Enabled = True
        End If
    End Sub

    Private Sub txtReason_SelectedIndexChanged(sender As System.Object, e As EventArgs) Handles txtReason.SelectedIndexChanged
        If Me.txtReason.Text.Length > 0 Then
            Me.btnOK.Enabled = True
        End If
    End Sub
End Class