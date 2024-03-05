Imports CADNet.CallQueues.Common

Partial Class Email_VitalityEmail
    Inherits System.Web.UI.Page

    Public Property _App As cAppointment

    Public BaseURL As String = "https://vitality.cahealthcare.co.uk"



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("ID") Is Nothing Then

        Else
            Try
                _App = New cAppointment()
                _App.load(Request.QueryString("ID"))
            Catch ex As Exception

            End Try
        End If
    End Sub

    'TODO need to impliment unsubscribe

End Class
