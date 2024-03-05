Public Class FrmAddSale

    Private Sub FrmAddSale_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        DTSale.Value = Now
        DTPolicy.Value = Now
        checkOK()
    End Sub

    Private Sub checkOK()
        Dim result As Boolean = False
        If Me.cboType.Text <> "" Then
            If txtValue.Text.Trim <> "" Then
                Try
                    Dim anum As Double
                    anum = CDbl(Me.txtValue.Text)
                    If cboProvider.Text <> "" Then
                        result = True
                    End If
                Catch ex As Exception

                End Try
            End If
        End If

        BtnOK.Enabled = result



    End Sub

    Private Sub txtValue_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtValue.KeyPress


        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", ChrW(Keys.Delete), ChrW(Keys.Back)

            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub txtValue_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtValue.TextChanged
        checkOK()
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cboType.SelectedIndexChanged
        checkOK()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class