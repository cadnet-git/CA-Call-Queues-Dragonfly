Public Class frmHolder

    Private CurrentUser = frmAgent.App.User.UserName



    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        logmeOn()
    End Sub
    Private Sub logmeOn()
        Dim bResult As Boolean = frmAgent.App.Login(CurrentUser, txtPassword.Text)
        If bResult Then
            frmAgent.App.WriteAgentEvent("Ending Appointment")
            Me.Close()
        Else
            Beep()
            txtPassword.Text = ""
        End If
    End Sub
    Public Sub New(ByVal state As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        PictureBox1.Image = images.Images(state)
        Dim App As Agent.cAgentApp = cAgentApp.GetInstance
        App.UpdateDeskStatus(state & " - Started " & Now.ToLongTimeString)
        App.UpdateDeskTelephone("")
        ''Bins()
        ''Break()
        ''Lunch()
        ''Water()
        ''With Manager
        ''    Group(Meeting)

    End Sub

    Private Sub frmHolder_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.txtPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            logmeOn()
            e.Handled = True
        End If

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class