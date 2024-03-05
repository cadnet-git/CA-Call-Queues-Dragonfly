
Partial Class Email_SurveyEmail
    Inherits System.Web.UI.Page
    Public _DirectLinkUrl As String = "https://ue.enablermail.com/vitality/clickthru.cfm?private=1&chid=Oi0jQlcnVkA_NUNPUypQQVstVVAgIAo"
    Private cApp As CADNet.CallQueues.Common.cAppointment
    Public BaseURL As String = "http://vitality.cahealthcare.co.uk"
    Public Property _App() As CADNet.CallQueues.Common.cAppointment
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
End Class

