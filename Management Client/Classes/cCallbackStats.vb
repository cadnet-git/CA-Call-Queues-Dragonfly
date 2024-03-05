Public Class cCallbackStats

    Public Property AgentID() As Integer
    Public Property AgentName() As String


    Public Property Companies() As Integer

    ' Call End Status
    Public Property Appointments() As Integer
    Public Property Callbacks As Integer
    Public Property NotInterested As Integer
    Public Property NumberNotRecognised As Integer
    Public Property OutOfArea As Integer
    Public Property Supervisor As Integer
    Public Property TPS As Integer

    Public ReadOnly Property Unconcluded() As Integer
        Get
            If Companies - concluded < 0 Then
                Return 0
            Else
                Return Companies - concluded
            End If
            Return Companies - concluded
        End Get
    End Property


    ' app status
    Public Property Future() As Integer
    Public Property NeedsAttention() As Integer

    Public Property DeadAgent() As Integer
    Public Property DeadRep() As Integer
    Public Property DeadCompany() As Integer
    Public Property DeadOther() As Integer
    Public Property NotSold() As Integer
    Public Property Sold() As Integer
    Public Property ToExpencive() As Integer
    Public Property ExistingMedical() As Integer
    Public Property Pending() As Integer
    Public Property SoldValue() As Double
    Public Property Sat() As Integer


    Dim concluded As Integer = 0

    Public Sub New(UserID As Integer, sdate As DateTime, edate As DateTime)
        AgentID = UserID
        Dim Database As New Common.DataLayer

        Dim ds As DataSet
        Dim params As New Collection
        Database.CreateParameter(params, "@UserID", SqlDbType.Int, AgentID)
        Database.CreateParameter(params, "@sDate", SqlDbType.DateTime, sdate)
        Database.CreateParameter(params, "@eDate", SqlDbType.DateTime, edate)

        ds = Database.ExecuteSP("spCallbackUseage", params)

        AgentName = ds.Tables(0).Rows(0).Item(0).ToString

        Companies = ds.Tables(1).Rows(0).Item(0)

        For Each dr As DataRow In ds.Tables(2).Rows
            Select Case dr("Status").ToString.ToLower
                Case "appointment"
                    Appointments = dr("Records")
                Case "callback"
                    Callbacks = dr("Records")
                Case "notinterested"
                    NotInterested = dr("Records")
                Case "numbernotrecognised"
                    NumberNotRecognised = dr("Records")
                Case "outofarea"
                    OutOfArea = dr("Records")
                Case "supervisor"
                    Supervisor = dr("Records")
                Case "tps"
                    TPS = dr("Records")
            End Select
            concluded = concluded + dr("Records")
        Next

        For Each dr As DataRow In ds.Tables(3).Rows
            Select Case dr("Status")
                Case "Approved", "Unapproved"
                    Future = dr("Records")
                Case "Cancelled"
                    NeedsAttention = dr("Records")
                Case "Dead - Agent", "Dead - Admin"
                    DeadAgent = dr("Records")
                Case "Dead - Company"
                    DeadCompany = dr("Records")
                Case "Dead - Other"
                    DeadOther = dr("Records")
                Case "Dead - Rep"
                    DeadRep = dr("Records")
                Case "Existing Medical"
                    ExistingMedical = dr("Records")
                    Sat = Sat + dr("Records")
                Case "Not Sold"
                    NotSold = dr("Records")
                    Sat = Sat + dr("Records")
                Case "Pending"
                    Pending = dr("Records")
                    Sat = Sat + dr("Records")
                Case "Sale"
                    Sold = dr("Records")
                    SoldValue = dr("Value")
                    Sat = Sat + dr("Records")
                Case "To Expensive"
                    ToExpencive = dr("Records")
                    Sat = Sat + dr("Records")
            End Select
        Next
    End Sub
End Class
