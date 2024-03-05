Public Class frmChangePassword

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub


    Private Function AllowSave() As Boolean

        If Me.txtConfirm.Text = Me.txtPassword.Text Then
            If Me.txtPassword.Text.Trim.Length > 5 Then
                AllowSave = True
            Else
                'password too short
                AllowSave = False
            End If
        Else
            AllowSave = False
        End If

    End Function

    Private Sub TextboxChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPassword.TextChanged, txtConfirm.TextChanged
        Me.btnOK.Enabled = AllowSave()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class