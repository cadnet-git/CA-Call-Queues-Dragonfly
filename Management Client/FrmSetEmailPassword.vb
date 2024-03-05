Public Class FrmSetEmailPassword
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (txtPassword.Text.Length > 0) Then
            Dim database As New CADNet.CallQueues.Common.DataLayer
            database.ExecuteSQL(String.Format("UPDATE Settings Set EmailPassword='{0}'", txtPassword.Text))
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class