Public Class FrmAddAppointmentNote

    Public Sub New(ByVal Status As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Status = "Cancelled" Then
            DTP.Visible = True
            cboTime.Visible = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNote.TextChanged
        If txtNote.Text.Length > 5 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub FrmAddAppointmentNote_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        DTP.Value = Now
    End Sub
End Class