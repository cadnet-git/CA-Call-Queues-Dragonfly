Public Class AppointmentStats

    Private iID As Integer
    Public Property ID() As Integer
        Get
            Return iID
        End Get
        Set(ByVal value As Integer)
            iID = value
        End Set
    End Property


    Private sRealName As String
    Public Property RealName() As String
        Get
            Return sRealName
        End Get
        Set(ByVal value As String)
            sRealName = value

        End Set
    End Property

    Private iAppointmentTotal As Integer
    Public Property AppointmentTotal() As Integer
        Get
            Return iAppointmentTotal
        End Get
        Set(ByVal value As Integer)
            iAppointmentTotal = value
        End Set
    End Property



    Public ReadOnly Property DeadTotal() As Integer
        Get
            Return Me.iDeadAdmin + Me.iDeadAgent + Me.iDeadCompany + Me.iDeadOther + Me.iDeadRep
        End Get
    End Property

    Private iDeadAdmin As Integer
    Public Property DeadAdmin() As Integer
        Get
            Return iDeadAdmin
        End Get
        Set(ByVal value As Integer)
            iDeadAdmin = value
        End Set
    End Property

    Private iDeadAgent As Integer
    Public Property DeadAgent() As Integer
        Get
            Return iDeadAgent
        End Get
        Set(ByVal value As Integer)
            iDeadAgent = value
        End Set
    End Property

    Private iDeadRep As Integer
    Public Property DeadRep() As Integer
        Get
            Return iDeadRep
        End Get
        Set(ByVal value As Integer)
            iDeadRep = value
        End Set
    End Property


    Private iDeadCompany As Integer
    Public Property DeadCompany() As Integer
        Get
            Return iDeadCompany
        End Get
        Set(ByVal value As Integer)
            iDeadCompany = value
        End Set
    End Property

    Private iDeadOther As Integer
    Public Property DeadOther() As Integer
        Get
            Return iDeadOther
        End Get
        Set(ByVal value As Integer)
            iDeadOther = value
        End Set
    End Property


    Private iNotSold As Integer
    Public Property NotSold() As Integer
        Get
            Return iNotSold
        End Get
        Set(ByVal value As Integer)
            iNotSold = value
        End Set
    End Property

    Private iSold As Integer
    Public Property Sold() As Integer
        Get
            Return iSold
        End Get
        Set(ByVal value As Integer)
            iSold = value
        End Set
    End Property

    Private iToExpencive As Integer
    Public Property ToExpencive() As Integer
        Get
            Return iToExpencive
        End Get
        Set(ByVal value As Integer)
            iToExpencive = value
        End Set
    End Property

    Private iExistingMedical As Integer
    Public Property ExistingMedical() As Integer
        Get
            Return iExistingMedical
        End Get
        Set(ByVal value As Integer)
            iExistingMedical = value
        End Set
    End Property

    

    Private iPending As Integer
    Public Property Pending() As Integer
        Get
            Return iPending
        End Get
        Set(ByVal value As Integer)
            iPending = value
        End Set
    End Property

    Private iUnapproved As Integer
    Public Property Unapproved() As Integer
        Get
            Return iUnapproved
        End Get
        Set(ByVal value As Integer)
            iUnapproved = value
        End Set
    End Property

    Private iNeedsAttention As Integer
    Public Property NeedsAttention() As Integer
        Get
            Return iNeedsAttention
        End Get
        Set(ByVal value As Integer)
            iNeedsAttention = value
        End Set
    End Property
    Public ReadOnly Property AppsSat() As Integer
        Get
            Return Me.AppointmentTotal - Me.DeadTotal - Me.iUnapproved - Me.iApproved - Me.NeedsAttention
        End Get
    End Property

    Private iApproved As Integer
    Public Property Approved() As Integer
        Get
            Return iApproved
        End Get
        Set(ByVal value As Integer)
            iApproved = value
        End Set
    End Property


    Private iNoFeedback As Integer
    Public Property NoFeedback() As Integer
        Get
            Return iNoFeedback
        End Get
        Set(ByVal value As Integer)
            iNoFeedback = value
        End Set
    End Property

    Public Sub AddRecord(ByVal aRow As DataRow)
        Me.iAppointmentTotal = Me.iAppointmentTotal + 1
        Select Case aRow("Status")
            Case 0                  'needs attention
                Me.iNeedsAttention = Me.iNeedsAttention + 1
            Case 1                  'Unapproved
                Me.iUnapproved = Me.iUnapproved + 1
            Case 2                  'Approved
                'this needs work
                Dim aDate As DateTime = aRow("itemdate")
                If aDate < Now Then
                    Me.iNoFeedback = Me.iNoFeedback + 1
                Else
                    Me.iApproved = Me.iApproved + 1
                End If


            Case 3                  'Pending
                Me.iPending = Me.iPending + 1
            Case 4                  'Sold
                Me.iSold = Me.iSold + 1
                Me.iValue = Me.iValue + aRow("PolicyValue")
            Case 5                  'Existing Medical
                Me.iExistingMedical = Me.iExistingMedical + 1
            Case 6                  'To Expensive
                Me.iToExpencive = Me.iToExpencive + 1
            Case 7                  ' NotSold
                Me.iNotSold = Me.iNotSold + 1
            Case -1                 'DeadAdmin
                Me.iDeadAdmin = Me.iDeadAdmin + 1
            Case -2                 'Dead Agent
                Me.iDeadAgent = Me.iDeadAgent + 1
            Case -3                 'Dead Rep
                Me.iDeadRep = Me.iDeadRep + 1
            Case -4                 'Dead Company
                Me.iDeadCompany = Me.iDeadCompany + 1
            Case -5                 'Dead Other 
                Me.iDeadOther = Me.iDeadOther + 1
        End Select

    End Sub

    Private iValue As Double
    Public Property Value() As Double
        Get
            Return iValue
        End Get
        Set(ByVal value As Double)
            iValue = value
        End Set
    End Property

    Public ReadOnly Property PercentUnApproved() As Double
        Get
            Try
                PercentUnApproved = Format(CInt(((Me.iUnapproved / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentUnApproved = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentApproved() As Double
        Get
            Try
                PercentApproved = Format(CInt(((Me.iApproved / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentApproved = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentDeadAdmin() As Double
        Get
            Try
                PercentDeadAdmin = Format(CInt(((Me.iDeadAdmin / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentDeadAdmin = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentDeadOthers() As Double
        Get
            Try
                PercentDeadOthers = Format(CInt((((Me.iDeadCompany + Me.iDeadOther + Me.iDeadRep) / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentDeadOthers = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentDead() As Double
        Get
            Try
                PercentDead = Format(CInt(((Me.DeadTotal / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentDead = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentDeadTotal() As Double
        Get
            Try
                PercentDeadTotal = Format(CInt(((Me.DeadTotal / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentDeadTotal = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentDeadAgent() As Double
        Get
            Try
                PercentDeadAgent = Format(CInt(((Me.iDeadAgent / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentDeadAgent = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentAppsSat() As Double
        Get
            Try
                PercentAppsSat = Format(CInt(((Me.AppsSat / Me.AppointmentTotal)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentAppsSat = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentSold() As Double
        Get
            Try
                PercentSold = Format(CInt(((Me.iSold / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentSold = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentPending() As Double
        Get
            Try
                PercentPending = Format(CInt(((Me.iPending / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentPending = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentNotSold() As Double
        Get
            Try
                PercentNotSold = Format(CInt(((Me.iNotSold / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentNotSold = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentToExpencive() As Double
        Get
            Try
                PercentToExpencive = Format(CInt(((Me.iToExpencive / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentToExpencive = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentExitingMedical() As Double
        Get
            Try
                PercentExitingMedical = Format(CInt(((Me.iExistingMedical / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentExitingMedical = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property PercentNoFeedback() As Double
        Get
            Try
                PercentNoFeedback = Format(CInt(((Me.iNoFeedback / Me.AppsSat)) * 1000) / 10, "##0.0")
            Catch ex As Exception
                PercentNoFeedback = 0
            End Try
        End Get

    End Property
    Public ReadOnly Property AverageAPi() As Double
        Get
            Try
                AverageAPi = (Me.iValue / Me.iSold)
                AverageAPi = Format(AverageAPi, "##,##0")
            Catch ex As Exception
                AverageAPi = 0
            End Try
        End Get

    End Property
End Class
