Public Class frmGetReasonNotInterested

    Public Property Months As Integer = 4

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Select Case Me.txtReason.Text
            Case "Works from Home"
                Months = 6
            Case "Wont deal with Us/AXA"
                Months = 8
            Case Else
                Months = 4
        End Select
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtReason_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtReason.TextChanged
        If txtReason.Text.Length > 0 Then
            btnOK.Enabled = True
        End If
    End Sub

    Private Sub txtReason_SelectedIndexChanged(sender As System.Object, e As EventArgs) Handles txtReason.SelectedIndexChanged
        If txtReason.Text.Length > 0 Then
            btnOK.Enabled = True
        End If
    End Sub


End Class