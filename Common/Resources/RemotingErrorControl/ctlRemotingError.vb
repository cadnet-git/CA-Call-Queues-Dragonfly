Imports System.Windows.Forms

Public Class ctlRemotingError

    Private Sub llblRemotingErrorShowDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRemotingErrorShowDetails.LinkClicked
        MessageBox.Show(Me.lblDetails.Text)
    End Sub

    Public Property Title() As String
        Get
            Title = Me.lblTitle.Text
        End Get
        Set(ByVal value As String)
            Me.lblTitle.Text = value
        End Set
    End Property
    Public Property SubTitle() As String
        Get
            SubTitle = Me.lblSubTitle.Text
        End Get
        Set(ByVal value As String)
            Me.lblSubTitle.Text = value
        End Set
    End Property
    Public Property Details() As String
        Get
            Details = Me.lblDetails.Text
        End Get
        Set(ByVal value As String)
            Me.lblDetails.Text = value
        End Set
    End Property

End Class
