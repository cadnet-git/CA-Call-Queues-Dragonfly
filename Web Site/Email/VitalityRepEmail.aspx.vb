
Imports CADNet.CallQueues.Common

Partial Class Email_VitalityRepEmail
    Inherits System.Web.UI.Page

    Public Property _App As cAppointment

    Public BaseURL As String = "http://vitality.cahealthcare.co.uk"


    Public ReadOnly Property _WasInssured() As String
        Get
            If _App.WasInsured = 1 Then
                Return "Yes"
            End If

            If _App.WasInsured = 0 Then
                Return "No"
            End If
            Return ""

        End Get

    End Property


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


End Class
