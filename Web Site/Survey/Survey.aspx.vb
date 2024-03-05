
Partial Class Survey_Survey
    Inherits System.Web.UI.Page

    Private cApp As CADNet.CallQueues.Common.cAppointment

    Public Property App() As CADNet.CallQueues.Common.cAppointment
        Get
            Return cApp
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cAppointment)
            cApp = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("ID") Is Nothing Then

        Else
            Try
                cApp = New CADNet.CallQueues.Common.cAppointment
                cApp.load(Request.QueryString("ID"))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        App.SaveSurvey(ddPunctual.Text, ddProfessional.Text, ddCalledBefore.Text, ddQuotedInMeeting.Text, ddQuoteMethod.Text, ddQuoteInfo.Text, txtComments.Text)
        Response.Redirect("ThankYou.aspx")
    End Sub

End Class

