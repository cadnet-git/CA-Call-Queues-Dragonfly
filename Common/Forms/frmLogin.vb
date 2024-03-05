Public Class frmLogin

    Public Sub New(ByVal FormIcon As System.Drawing.Icon)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '  Me.picIcon.Image = FormIcon.ToBitmap

    End Sub
    Public ReadOnly Property Username() As String
        Get
            Username = txtUsername.Text
        End Get
    End Property
    Public ReadOnly Property Password() As String
        Get
            Password = txtPassword.Text
        End Get
    End Property

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' lblApplicationTitle.Text = My.Application.Info.Title
        lblCopyright.Text = My.Application.Info.Copyright
    End Sub

    Public Sub ClearPassword()
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.SelectAll()
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub


End Class