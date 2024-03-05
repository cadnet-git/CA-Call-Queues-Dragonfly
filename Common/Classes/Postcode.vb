Imports Newtonsoft
Imports System.Net
Imports System.Web
Imports Newtonsoft.Json
Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json.Linq

Public Class Postcode


    Public Shared Function GetAddresses(ByVal _PostCode As String)
        Dim Result As New PostcodeResult

        Dim sURL As String = "https://api.ideal-postcodes.co.uk/v1/postcodes/" & _PostCode & "?api_key=ak_il9fyti9WhKlVgcCG0RZQLswqf11k"
        Dim _WebRequest As WebRequest
        Try
            _WebRequest = WebRequest.Create(sURL)
        Catch ex As Exception
            Result.HasError = True
            Result.ErrorMessage = ex.Message
            Return Result
        End Try


        Dim objStream As Stream

        Try
            objStream = _WebRequest.GetResponse().GetResponseStream()
        Catch ex As Exception
            Result.HasError = True
            Result.ErrorMessage = ex.Message
            Return Result
        End Try

        Dim objReader As StreamReader = New StreamReader(objStream)
        Dim ser As JObject = JObject.Parse(objReader.ReadToEnd())
        Dim data As List(Of JToken) = ser.Children().ToList
        Dim data1 As List(Of JToken) = data(0).Children.ToList

        For Each r As Object In data1.Children
            Dim address As Address = New Address()

            address.id = r.Item("udprn")
            address.CompanyName = r.Item("organisation_name")
            If (address.CompanyName.Length > 0) Then
                address.Address1 = r.Item("line_2")
                address.Address2 = r.Item("line_3")
            Else
                address.Address1 = r.Item("line_1")
                address.Address2 = r.Item("line_2")
            End If
            address.Town = r.Item("post_town")
            address.County = r.Item("county")
            address.PostCode = r.Item("postcode")
            address.Latitude = r.Item("latitude")
            address.Longitude = r.Item("longitude")

            Result.Addresses.Add(address)
        Next
        Return Result
    End Function



















End Class



