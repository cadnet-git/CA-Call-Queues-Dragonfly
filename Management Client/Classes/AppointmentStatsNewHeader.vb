Public Class AppointmentStatsNewHeader
    Public Property ID() As Integer
    Public Property RealName() As String

    Public Property Total As New AppointmentStatsNew

    Public Property Insured As New AppointmentStatsNew
    Public Property Nocover As New AppointmentStatsNew
    Public Property NoIdea As New AppointmentStatsNew

    Public Sub AddRecord(ByVal aRow As DataRow)
        Total.AddRecord(aRow)
        Dim WasInsured As Integer = aRow("wasinsured")
        Select Case WasInsured
            Case 1
                Insured.AddRecord(aRow)
            Case 2
                Nocover.AddRecord(aRow)
            Case Else
                NoIdea.AddRecord(aRow)
        End Select
    End Sub

End Class
