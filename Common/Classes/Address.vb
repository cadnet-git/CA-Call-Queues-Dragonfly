Public Class Address
    Public id As Integer
    Public CompanyName As String
    Public Address1 As String
    Public Address2 As String
    Public Town As String
    Public County As String
    Public PostCode As String

    Public Longitude As String
    Public Latitude As String


    Public ReadOnly Property AddressSummary() As String
        Get

            If CompanyName.Length > 0 Then
                Return $"{CompanyName}, {Address1}, {Town}, {County}, {PostCode}"
            Else

                If (Address2.Length > 0) Then

                    Return Address1 + ", " + Address2 + ", " + Town + ", " + County + ", " + PostCode

                Else

                    Return Address1 + ", " + Town + ", " + County + ", " + PostCode


                End If

            End If


        End Get

    End Property
End Class
