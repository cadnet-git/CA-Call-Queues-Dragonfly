Public Class PCLookup
    Public Property status As Integer
    Public Property result As Result
End Class

Public Class Result
    Public Property postcode As String
    Public Property quality As Integer
    Public Property eastings As Integer
    Public Property northings As Integer
    Public Property country As String
    Public Property nhs_ha As String
    Public Property longitude As Single
    Public Property latitude As Single
    Public Property parliamentary_constituency As String
    Public Property european_electoral_region As String
    Public Property primary_care_trust As String
    Public Property region As String
    Public Property lsoa As String
    Public Property msoa As String
    Public Property incode As String
    Public Property outcode As String
    Public Property admin_district As String
    Public Property parish As String
    Public Property admin_county As Object
    Public Property admin_ward As String
    Public Property ccg As String
    Public Property nuts As String
    Public Property codes As Codes
End Class

Public Class Codes
    Public Property admin_district As String
    Public Property admin_county As String
    Public Property admin_ward As String
    Public Property parish As String
    Public Property ccg As String
    Public Property nuts As String
End Class


Public Class LatLong
    Public Property Latitude As String
    Public Property Longitude As String
End Class

