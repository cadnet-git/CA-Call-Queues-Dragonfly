Public Class cAgentStats
    Public AgentID As Integer
    Public Agent As String
    Public Calls As Integer
    Public NewCalls As Integer
    Public Appointment As Integer
    Public Callback As Integer
    Public Reschedule As Integer
    Public NottoHand As Integer
    Public NotInterested As Integer
    Public Supervisor As Integer
    Public OutofArea As Integer
    Public TPS As Integer
    Public NumberNotRecognised As Integer

    Private ReadOnly Property GoodCalls() As Integer
        Get
            GoodCalls = Calls - TPS - OutofArea - NumberNotRecognised - Supervisor
        End Get
    End Property


    Public ReadOnly Property PercentNewCalls() As Double
        Get
            Try
                PercentNewCalls = Format(CInt(((NewCalls / GoodCalls)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentNewCalls = 0
            End Try
        End Get
    End Property

    Public ReadOnly Property PercentAppointments() As Double
        Get
            Try
                PercentAppointments = Format(CInt(((Appointment / GoodCalls)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentAppointments = 0
            End Try
        End Get
    End Property
    Public ReadOnly Property PercentCallbacks() As Double
        Get
            Try
                PercentCallbacks = Format(CInt(((Callback / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentCallbacks = 0
            End Try

        End Get
    End Property
    Public ReadOnly Property PercentRescheduled() As Double
        Get
            Try
                PercentRescheduled = Format(CInt(((Reschedule / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentRescheduled = 0
            End Try
        End Get
    End Property
    Public ReadOnly Property PercentNottoHand() As Double
        Get
            Try
                PercentNottoHand = Format(CInt(((NottoHand / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentNottoHand = 0
            End Try
        End Get
    End Property

    Public ReadOnly Property PercentNotInterested() As Double
        Get
            Try
                PercentNotInterested = Format(CInt(((NotInterested / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentNotInterested = 0
            End Try
        End Get
    End Property

    Public ReadOnly Property PercentSupervisor() As Double
        Get
            Try
                PercentSupervisor = Format(CInt(((Supervisor / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentSupervisor = 0
            End Try
        End Get
    End Property

    Public ReadOnly Property PercentOutofArea() As Double
        Get
            Try
                PercentOutofArea = Format(CInt(((OutofArea / GoodCalls)) * 1000) / 10, "##0.0")

            Catch ex As Exception
                PercentOutofArea = 0
            End Try
        End Get
    End Property

    Public ReadOnly Property PercentTPS() As Double
        Get
            Try
                PercentTPS = Format(CInt(((TPS / GoodCalls)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentTPS = 0
            End Try

        End Get
    End Property

    Public ReadOnly Property PercentNumberNotRecognised() As Double
        Get
            Try
                PercentNumberNotRecognised = Format(CInt(((NumberNotRecognised / GoodCalls)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentNumberNotRecognised = 0
            End Try
        End Get
    End Property

    Public Sub AddRec(ByVal Dr As DataRow)
        Calls += 1
        If Dr("NewCall") = 0 Then
            NewCalls += 1
        End If

        Select Case Dr("CallEndStatus")
            Case "Appointment"
                Appointment += 1
            Case "CallBack"
                Callback += 1
            Case "Reschedule"
                Reschedule += 1
            Case "NotToHand"
                NottoHand += 1
            Case "NotInterested"
                NotInterested += 1
            Case "Supervisor"
                Supervisor += 1
            Case "OutOfArea"
                OutofArea += 1
            Case "TPS"
                TPS += 1
            Case "NumberNotRecognised"
                NumberNotRecognised += 1
            Case Else
                MsgBox(Dr("CallEndStatus"))
        End Select
    End Sub
End Class
