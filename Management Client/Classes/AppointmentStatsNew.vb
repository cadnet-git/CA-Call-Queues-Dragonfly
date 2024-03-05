Public Class AppointmentStatsNew

    Public Property AppointmentTotal() As Integer
    Public Property Unapproved() As Integer
    Public Property Approved() As Integer
    Public Property NeedsAttention() As Integer
    Public Property DeadAdmin() As Integer
    Public Property DeadAgent() As Integer
    Public Property DeadRep() As Integer
    Public Property DeadCompany() As Integer
    Public Property DeadOther() As Integer
    Public Property NotSold() As Integer
    Public Property Sold() As Integer
    Public Property ToExpencive() As Integer
    Public Property ExistingMedical() As Integer
    Public Property Pending() As Integer

    Public Property NoFeedback() As Integer
    Public Property Value() As Double
    Public Property ComercialValue As Double
    Public Property PrivateValue As Double
    Public Property PrivateSold As Integer
    Public Property ComercialSold As Integer
    Public ReadOnly Property DeadTotal() As Integer
        Get
            Return DeadAdmin + DeadAgent + DeadCompany + DeadOther + DeadRep
        End Get
    End Property

    Public ReadOnly Property AppsSat() As Integer
        Get
            Return AppointmentTotal - DeadTotal - Unapproved - Approved - NeedsAttention
        End Get
    End Property


    'Public ReadOnly Property PercentUnApproved() As Double
    '    Get
    '        Try
    '            PercentUnApproved = Format(CInt(((Unapproved / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentUnApproved = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentApproved() As Double
    '    Get
    '        Try
    '            PercentApproved = Format(CInt(((Approved / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentApproved = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentDeadAdmin() As Double
    '    Get
    '        Try
    '            PercentDeadAdmin = Format(CInt(((DeadAdmin / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentDeadAdmin = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentDeadOthers() As Double
    '    Get
    '        Try
    '            PercentDeadOthers = Format(CInt((((DeadCompany + DeadOther + DeadRep) / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentDeadOthers = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentDead() As Double
    '    Get
    '        Try
    '            PercentDead = Format(CInt(((DeadTotal / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentDead = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentDeadTotal() As Double
    '    Get
    '        Try
    '            PercentDeadTotal = Format(CInt(((DeadTotal / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentDeadTotal = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentDeadAgent() As Double
    '    Get
    '        Try
    '            PercentDeadAgent = Format(CInt(((DeadAgent / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentDeadAgent = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentAppsSat() As Double
    '    Get
    '        Try
    '            PercentAppsSat = Format(CInt(((AppsSat / AppointmentTotal)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentAppsSat = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentSold() As Double
    '    Get
    '        Try
    '            PercentSold = Format(CInt(((Sold / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentSold = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentPending() As Double
    '    Get
    '        Try
    '            PercentPending = Format(CInt(((Pending / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentPending = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentNotSold() As Double
    '    Get
    '        Try
    '            PercentNotSold = Format(CInt(((NotSold / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentNotSold = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentToExpencive() As Double
    '    Get
    '        Try
    '            PercentToExpencive = Format(CInt(((ToExpencive / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentToExpencive = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentExitingMedical() As Double
    '    Get
    '        Try
    '            PercentExitingMedical = Format(CInt(((ExistingMedical / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentExitingMedical = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property PercentNoFeedback() As Double
    '    Get
    '        Try
    '            PercentNoFeedback = Format(CInt(((NoFeedback / AppsSat)) * 1000) / 10, "##0.0")
    '        Catch ex As Exception
    '            PercentNoFeedback = 0
    '        End Try
    '    End Get

    'End Property
    'Public ReadOnly Property AverageAPi() As Double
    '    Get
    '        Try
    '            AverageAPi = Format((Value / Sold), "##,##0")
    '        Catch ex As Exception
    '            AverageAPi = 0
    '        End Try
    '    End Get

    'End Property

    Public Sub AddRecord(ByVal aRow As DataRow)
        AppointmentTotal = AppointmentTotal + 1



        Select Case aRow("Status")
            Case 0                  'needs attention
                NeedsAttention = NeedsAttention + 1
            Case 1                  'Unapproved
                Unapproved = Unapproved + 1
            Case 2                  'Approved
                'this needs work
                Dim aDate As DateTime = aRow("itemdate")
                If aDate < Now Then
                    NoFeedback = NoFeedback + 1
                Else
                    Approved = Approved + 1
                End If
            Case 3                  'Pending
                Pending = Pending + 1
            Case 4                  'Sold
                Sold = Sold + 1
                Value = Value + aRow("PolicyValue")
                If aRow("PolicyType") = "Private" Then
                    PrivateValue = PrivateValue + aRow("PolicyValue")
                    PrivateSold = PrivateSold + 1
                Else
                    ComercialValue = ComercialValue + aRow("PolicyValue")
                    ComercialSold = ComercialSold + 1
                End If

            Case 5                  'Existing Medical
                ExistingMedical = ExistingMedical + 1
            Case 6                  'To Expensive
                ToExpencive = ToExpencive + 1
            Case 7                  ' NotSold
                NotSold = NotSold + 1
            Case -1                 'DeadAdmin
                DeadAdmin = DeadAdmin + 1
            Case -2                 'Dead Agent
                DeadAgent = DeadAgent + 1
            Case -3                 'Dead Rep
                DeadRep = DeadRep + 1
            Case -4                 'Dead Company
                DeadCompany = DeadCompany + 1
            Case -5                 'Dead Other 
                DeadOther = DeadOther + 1
            Case Else
                Console.WriteLine("")
        End Select






    End Sub


End Class

