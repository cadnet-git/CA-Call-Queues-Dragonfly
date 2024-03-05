Public Class frmNumberToDial

    Public Number As String = ""


#Region "Mobiles"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Number = "305"
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Number = "07725962351"
        Me.DialogResult = DialogResult.OK
    End Sub
#End Region







    Private Sub SelectButton(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click, Button4.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button5.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button6.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button7.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button8.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button10.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button11.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button12.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button13.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button14.Click
        Dim aBtn As Button = sender

        Number = aBtn.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button15.Click

        Number = "01204841441"
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button16.Click
        Number = "0800500005"
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button17.Click
        Number = "0800500005"
        Me.DialogResult = DialogResult.OK
    End Sub
End Class