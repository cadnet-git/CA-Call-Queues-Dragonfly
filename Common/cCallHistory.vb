Public Class cCallHistory

    Public Enum CallbackNextStage
        ManagersPot
        ToColdCall
        StayWithAgent
    End Enum



    Private Enum eCallEndStatus
        Unknown
        CallBack
        TPS
        NumberNotRecognised
        NotInterested
        NotAvailable
        NotToHand
        Reschedule     'ie a reschedule without a failure (eg not convieient, detaisl not to hand)
        Appointment
        OutOfArea
        Supervisor
    End Enum

    Private iID As Integer = -1
    Private dCreated As Date
    Private iCompanyID As Integer = -1
    Private iUserID As Integer = -1
    Private sCallEndStatus As String
    Private dCallEndTime As Date
    Private sCallStartStatus As String
    Private dCallStartTime As Date

    Private iCallType As Common.eCallTypes = -1
    Private sCallFailureReason As String = ""
    Private SAgent As String = ""
    Private CallStatus As String = ""

    Private ThisCompany As Common.cCompany = Nothing

    Public Property CallbackStatus As CallbackNextStage
    Public Property CallbackReason As String = ""
    Public Sub New(ByVal Company As Common.cCompany, ByVal UserID As Integer)
        ThisCompany = Company
        iCompanyID = ThisCompany.ID
        iCallType = Company.CallType
        iUserID = UserID
    End Sub
    Public Sub New(ByVal aRow As DataRow, ByVal Company As Common.cCompany)
        ThisCompany = Company
        Load(aRow)
    End Sub



    Private Sub Load(ByVal aRow As DataRow)

        iID = aRow.Item("ID")
        dCreated = aRow.Item("DateCreated")
        iCompanyID = aRow.Item("CompanyID")

        iUserID = aRow.Item("UserID")
        sAgent = aRow.Item("Agent")
        sCallStartStatus = aRow.Item("CallStartStatus").ToString
        sCallEndStatus = aRow.Item("CallEndStatus").ToString

        dCallStartTime = aRow.Item("CallStartTime").ToString
        If aRow.IsNull("CallEndTime") Then
        Else
            dCallEndTime = aRow.Item("CallEndTime").ToString
        End If

        sCallFailureReason = aRow.Item("CallFailureReason").ToString
        iHide = aRow.Item("Hide")
    End Sub

    Private iHide As Integer
    Public Property Hide() As Integer
        Get
            Return iHide
        End Get
        Set(ByVal value As Integer)
            iHide = value
        End Set
    End Property

    Public ReadOnly Property ID() As Integer
        Get
            ID = iID
        End Get
    End Property
    Public ReadOnly Property Created() As Date
        Get
            Created = dCreated
        End Get
    End Property
    Public ReadOnly Property CompanyID() As Integer
        Get
            CompanyID = iCompanyID
        End Get
    End Property
    Public ReadOnly Property UserID() As Integer
        Get
            UserID = iUserID
        End Get
    End Property
    Public ReadOnly Property Agent() As String
        Get
            Agent = SAgent
        End Get
    End Property
    Public ReadOnly Property CallEndStatus() As String
        Get
            CallEndStatus = sCallEndStatus
        End Get
    End Property
    Public ReadOnly Property CallStartStatus() As String
        Get
            CallStartStatus = sCallStartStatus
        End Get
    End Property
    Public ReadOnly Property CallStarted() As Date
        Get
            CallStarted = dCallStartTime
        End Get
    End Property
    Public ReadOnly Property CallEnded() As Date
        Get
            CallEnded = dCallEndTime
        End Get
    End Property
    Public Property CallFailureReason() As String
        Get
            CallFailureReason = sCallFailureReason
        End Get
        Set(ByVal value As String)
            sCallFailureReason = value
        End Set
    End Property
    Public ReadOnly Property CallType() As Common.eCallTypes
        Get
            CallType = iCallType
        End Get
    End Property
    Private Sub Save()
        Dim Params As New Collection

        Dim parID As New SqlClient.SqlParameter("@ID", SqlDbType.Int)
        parID.Value = iID
        Params.Add(parID)

        Dim parCallEndStatus As New SqlClient.SqlParameter("@CallEndStatus", SqlDbType.NVarChar)
        parCallEndStatus.Value = sCallEndStatus
        Params.Add(parCallEndStatus)

        Dim parCallEndTime As New SqlClient.SqlParameter("@CallEndTime", SqlDbType.DateTime)
        parCallEndTime.Value = dCallEndTime
        Params.Add(parCallEndTime)

        Dim parCallFailureReason As New SqlClient.SqlParameter("@CallFailureReason", SqlDbType.NVarChar)
        parCallFailureReason.Value = sCallFailureReason
        Params.Add(parCallFailureReason)
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.ExecuteSP("spCallSave", Params)

    End Sub
    Public Sub StartCall()
        dCallStartTime = Now
    End Sub

    Public ReadOnly Property Company() As Common.cCompany
        Get
            Company = ThisCompany
        End Get
    End Property

    Public Sub EndCallReschedule(ByVal Callbackdate As Date, ByVal Reason As String)
        'used to reschedule a call  but without a failure state (ie still a hot call)

        EndCall()

        sCallEndStatus = eCallEndStatus.Reschedule.ToString
        sCallFailureReason = String.Format("{0} Callback on {1} {2}", Reason, Callbackdate.ToLongDateString, Callbackdate.ToShortTimeString)
        sCallFailureReason = sCallFailureReason.Trim
        Save()



        If ThisCompany.Status.ToUpper = "COLDCALL" And ThisCompany.Attemps > 19 Then
            With ThisCompany
                .Status = Common.eCompanyStatus.ColdCall.ToString
                .AgentID = 0
                .Notes = ""

                .CallBackOn(Now.AddMonths(6))
                .Save()
                .HideHistory()
            End With
        Else
            With ThisCompany
                .Status = .Status ' doing this to trigger the reseting of the allow calls flag
                .CallBackOn(Callbackdate)
                .Save()
            End With
        End If



    End Sub

    Public Sub EndCallOutofArea(ByVal reason As String)

        EndCall()

        sCallEndStatus = eCallEndStatus.OutOfArea.ToString
        sCallFailureReason = "Out of Area " & Reason
        Save()

        With ThisCompany
            '   .Status =  ' doing this to trigger the reseting of the allow calls flag
            .Status = "OutOfArea"
            .Save()
            .HideHistory()
        End With

    End Sub
    Public Sub EndCallBusy()
        'put on hold for 15 mins

        EndCall()

        sCallEndStatus = eCallEndStatus.Reschedule.ToString
        sCallFailureReason = "Line Busy. Callback on " & Now.AddMinutes(15).ToLongDateString & " " & Now.AddMinutes(15).ToShortTimeString
        'sCallFailureReason = sCallFailureReason.Trim
        Save()
        If ThisCompany.Status.ToUpper = "COLDCALL" And ThisCompany.Attemps > 19 Then
            With ThisCompany
                .Status = Common.eCompanyStatus.ColdCall.ToString
                .AgentID = 0
                .Notes = ""
                .CallBackOn(Now.AddMonths(6))
                .Save()

                .HideHistory()
            End With


        Else
            With ThisCompany
                .Status = .Status ' doing this to trigger the reseting of the allow calls flag
                .CallBackOn(Now.AddMinutes(15))
                .Save()
            End With
        End If

    End Sub

    Public Sub EndCallNotToHand(ByVal Callbackdate As Date, ByVal Reason As String)
        'used to reschedule a call  but without a failure state (ie still a hot call)

        EndCall()

        sCallEndStatus = eCallEndStatus.NotToHand.ToString
        sCallFailureReason = String.Format("{0} Callback on {1}", Reason, Callbackdate.ToLongDateString)
        sCallFailureReason = sCallFailureReason.Trim
        Save()

        With ThisCompany
            .Status = "NotToHand" ' doing this to trigger the reseting of the allow calls flag
            .CallBackOn(Callbackdate)
            .Save()
        End With

    End Sub
    Public Sub EndCallCreateCallBack(Training As Boolean)
        'used to reschedule a call  but without a failure state (ie still a hot call)
        Dim odate As DateTime = DateAdd(DateInterval.Month, -2, CDate(Company.PolicyExpires))
        ' odate = DateAdd(DateInterval.Day, 9, odate) ' adding 9 days to make it 10th
        If Training Then
            odate = Now
        End If
        EndCall()
        sCallEndStatus = eCallEndStatus.CallBack.ToString
        sCallFailureReason = String.Format("{0}  Callback on {1} reason - {2}", Company.PolicyExpires.ToLongDateString, odate.ToLongDateString, CallbackReason)
        sCallFailureReason = sCallFailureReason.Trim
        Save()
        Dim d As New Common.DataLayer
        d.ExecuteSQL(String.Format("UPDATE CompanyHistory SET CreateCallbackNextState = '{0}' WHERE ID= {1}", CallbackStatus, ID))
        Select Case CallbackStatus
            Case CallbackNextStage.ManagersPot
                With ThisCompany
                    .Status = Common.enums.eCompanyStatus.CallBack.ToString
                    .CallBackOn(odate)

                    If (.GroupCompanyID = 2) Then
                        .AgentID = 464 ' this is the callback pot user id
                    Else
                        .AgentID = 463
                    End If

                    .TPSUntil = ThisCompany.PolicyExpires.AddMonths(2)
                    .Save()
                    .HideHistory()
                End With
            Case CallbackNextStage.ToColdCall
                With ThisCompany
                    .Status = Common.enums.eCompanyStatus.ColdCall.ToString
                    .CallBackOn(Now.AddMonths(4))
                    .AgentID = 0 ' this is the callback pot user id
                    .PolicyExpires = "1 January 1900"
                    .PolicyProvider = ""
                    .TPSUntil = Now.AddDays(28)
                    .Save()
                    .HideHistory()
                End With


            Case Else
                ' stay with  agent 
                EndCall()
              
                With ThisCompany
                    .Status = enums.eCompanyStatus.CallBack.ToString
                    .CallBackOn(odate)
                    .TPSUntil = ThisCompany.PolicyExpires.AddMonths(2)
                    .Save()
                End With
        End Select






    End Sub


    Public Sub EndCallNotAvailable(ByVal CallbackDate As Date)
        EndCall()

        sCallEndStatus = eCallEndStatus.NotAvailable.ToString
        sCallFailureReason = "Callback on " & CallbackDate.ToLongDateString
        sCallFailureReason = sCallFailureReason.Trim
        Save()
        If ThisCompany.Status.ToUpper = "COLDCALL" And ThisCompany.Attemps > 19 Then
            With ThisCompany
                .Status = Common.eCompanyStatus.ColdCall.ToString
                .AgentID = 0
                .Notes = ""
                .CallBackOn(Now.AddMonths(6))
                .Save()
                .HideHistory()
            End With
        Else
            With ThisCompany
                .Status = Common.eCompanyStatus.ColdCall ' doing this to trigger the reseting of the allow calls flag
                .CallBackOn(CallbackDate)
                .Save()
            End With
        End If

      
    End Sub

    Public Sub EndCallSupervisor(ByVal Reason As String)

        EndCall()

        sCallEndStatus = eCallEndStatus.Supervisor.ToString
        sCallFailureReason = Reason

        Save()

        With ThisCompany
            .Status = Common.eCompanyStatus.Supervisor.ToString
            .AllowCalls = 1
            .Save()
            .HideHistory()
        End With
     
    End Sub
    Public Sub EndCallNotInterested(ByVal Reason As String, months As Integer) 'ByVal CallBackDate As Date)

        'this functino determines the callback date for a not interested (as opposed to a re-sched)


        EndCall()

        'for now its hardcoded to 6 months

        Dim CallBackDate As DateTime = DateAdd(DateInterval.Month, months, Now.Date)
        sCallEndStatus = eCallEndStatus.NotInterested.ToString
        sCallFailureReason = Reason & " - Callback on " & CallBackDate.ToLongDateString
        sCallFailureReason = sCallFailureReason.Trim

        Save()

        With ThisCompany
            .Status = Common.eCompanyStatus.ColdCall.ToString
            .AgentID = 0
            .Notes = ""
            .CallBackOn(CallBackDate)
            .Save()
            .HideHistory()
        End With


    End Sub
    Public Sub EndCallNotRecognised(Optional From As String = "")

        EndCall()

        sCallEndStatus = eCallEndStatus.NumberNotRecognised.ToString
        sCallFailureReason = From

        'mark the company as NNR too
        With ThisCompany
            .Status = Common.eCompanyStatus.InvalidNumber.ToString
            .Save()
            .HideHistory()
        End With

        Save()

    End Sub
    Public Sub EndCallAppointment(ByVal rep As String, ByVal appointmentTime As String)

        EndCall()

        sCallEndStatus = eCallEndStatus.Appointment.ToString
        sCallFailureReason = "Rep: " & rep & " Time: " & appointmentTime


        With ThisCompany
            .Status = Common.eCompanyStatus.Appointment.ToString
            .Save()
        End With

        Save()

    End Sub
    Public Sub EndCallTPS()

        EndCall()

        sCallEndStatus = eCallEndStatus.TPS.ToString
        sCallFailureReason = "TPS Resheduled until " & Now.AddMonths(6).ToLongDateString

        'mark the company as tps too
        With ThisCompany
            .HoldUntil = Now.AddMonths(6)
            .AgentID = 0
            .Notes = ""
            .HideHistory()
            .Status = "ColdCall"
            .AllowCalls = 1
            .Save()
        End With

        Save()

    End Sub
    Private Sub EndCall()
        dCallEndTime = Now
    End Sub
End Class
