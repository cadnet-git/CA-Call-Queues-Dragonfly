Public Class ctlDiaryCellv2

    Public Event CellClicked(ByVal cell As String)

    Private Unavailable As Color = New Color
    Private medDist As Color = New Color
    Private longDist As Color = New Color
    Private OKDist As Color = New Color
    Private Appointment As Color = New Color
    Private isSelected As Color = New Color

    Private iPeriod As Integer = 0
    Private Latitude As Double
    Private Longitude As Double
    Private sPreviousControl As String = ""
    Private sNextControl As String = ""
    Public hasAppointment As Boolean = False
    Dim iDistance As Integer = 1
    Private iSelected As Boolean = False
    Private sAppointmentTime As String
    Private sAppointmentDate As String
    Public Property Period() As Integer
        Get
            Period = iPeriod
        End Get
        Set(ByVal value As Integer)
            iPeriod = value
        End Set
    End Property

    Public Property Distance() As Integer
        Get
            Distance = iDistance
        End Get
        Set(ByVal value As Integer)
            If value > iDistance Then
                iDistance = value
                Select Case iDistance
                    Case 2
                        Me.BackColor = medDist
                    Case 3
                        Me.BackColor = longDist
                    Case 4
                        Me.BackColor = Unavailable
                        Me.hasAppointment = True
                End Select
            End If

        End Set
    End Property
    Public Property AppointmentTime() As String
        Get
            AppointmentTime = sAppointmentTime
        End Get
        Set(ByVal value As String)
            sAppointmentTime = value
        End Set
    End Property
    Public Property AppointmentDate() As String
        Get
            AppointmentDate = sAppointmentDate
        End Get
        Set(ByVal value As String)
            sAppointmentDate = value
        End Set
    End Property
    Public Property PreviousControl() As String
        Get
            PreviousControl = sPreviousControl
        End Get
        Set(ByVal value As String)
            sPreviousControl = value
        End Set
    End Property
    Public Property NextControl() As String
        Get
            NextControl = sNextControl
        End Get
        Set(ByVal value As String)
            sNextControl = value
        End Set
    End Property
    Private iOKMaxDist As Integer
    Public Property OkMaxDist() As Integer
        Get
            Return iOKMaxDist
        End Get
        Set(ByVal value As Integer)
            iOKMaxDist = value
        End Set
    End Property

    Private iMedMaxDist As Integer
    Public Property MedMaxDist() As Integer
        Get
            Return iMedMaxDist
        End Get
        Set(ByVal value As Integer)
            iMedMaxDist = value
        End Set
    End Property

    Private iLongMaxDist As Integer
    Public Property LongMaxDist() As Integer
        Get
            Return iLongMaxDist
        End Get
        Set(ByVal value As Integer)
            iLongMaxDist = value
        End Set
    End Property

    Public Sub loadData(ByVal arow As DataRow, ByVal CallLat As Double, ByVal CallLong As Double)
        ' process into holders here 
        Select Case arow("Type")
            Case "CA"
                hasAppointment = True
                Me.BackColor = Appointment
                Me.lblTown.Text = arow("CompanyName").ToString
                Me.lblArea.Text = arow("AreaTitle").ToString
                'Me.lblTime.Text = arow("Town").ToString

                If Not arow("Latitude") Is DBNull.Value Then
                    Latitude = arow("Latitude")
                Else
                    Latitude = 0
                End If

                If Not arow("Longitude") Is DBNull.Value Then
                    Longitude = arow("Longitude")
                Else
                    Longitude = 0
                End If

                If Longitude = 0 Or Latitude = 0 Then
                Else
                    Dim miles As Integer
                    miles = getMiles(Latitude, Longitude, CallLat, CallLong)
                    Me.lblTime.Text = miles.ToString & " Miles"
                    If PreviousControl <> "" Then

                        Dim aObj As ctlDiaryCellv2 = Parent.Controls(PreviousControl)
                        If aObj.lblArea.Text = "" Then
                            Select Case miles
                                Case Is > Me.iLongMaxDist
                                    aObj.Distance = 4
                                Case Is > Me.iMedMaxDist
                                    aObj.Distance = 3
                                Case Is > Me.iOKMaxDist
                                    aObj.Distance = 2
                                Case Else
                                    aObj.Distance = 1
                            End Select
                        End If

                    End If
                    If NextControl <> "" Then
                        Dim aObj As ctlDiaryCellv2 = Parent.Controls(NextControl)
                        If aObj.lblArea.Text = "" Then

                            Select Case miles
                                Case Is > Me.iLongMaxDist
                                    aObj.Distance = 4
                                Case Is > Me.iMedMaxDist
                                    aObj.Distance = 3
                                Case Is > Me.iOKMaxDist
                                    aObj.Distance = 2
                                Case Else
                                    aObj.Distance = 1
                            End Select
                        End If
                    End If
                End If
            Case "GEN"
                Me.BackColor = Unavailable
                Me.hasAppointment = True
                Me.lblTown.Text = arow("Description").ToString
            Case "REP"
                hasAppointment = True
                Me.BackColor = Appointment
                Me.lblTown.Text = arow("Description").ToString
                Me.lblArea.Text = "SELF GENERATED"
                Latitude = arow("DiaryLat")
                Longitude = arow("DiaryLong")
                Dim miles As Integer
                miles = getMiles(Latitude, Longitude, CallLat, CallLong)
                Me.lblTime.Text = miles.ToString & " Miles"

                If PreviousControl <> "" Then

                    Dim aObj As ctlDiaryCellv2 = Parent.Controls(PreviousControl)
                    If aObj.lblArea.Text = "" Then
                        Select Case miles
                            Case Is > 49
                                aObj.Distance = 4
                            Case Is > 29
                                aObj.Distance = 3
                            Case Is > 14
                                aObj.Distance = 2
                            Case Else
                                aObj.Distance = 1
                        End Select
                    End If

                End If
                If NextControl <> "" Then
                    Dim aObj As ctlDiaryCellv2 = Parent.Controls(NextControl)
                    If aObj.lblArea.Text = "" Then

                        Select Case miles
                            Case Is > 49
                                aObj.Distance = 4

                            Case Is > 29
                                aObj.Distance = 3

                            Case Is > 14
                                aObj.Distance = 2
                            Case Else
                                aObj.Distance = 1
                        End Select
                    End If
                End If
        End Select
    End Sub
    Public Function getMiles(ByVal Latitude1 As Double, ByVal Longitude1 As Double, ByVal Latitude2 As Double, ByVal Longitude2 As Double) As Integer
        Try
            Dim latlen As Double = (Latitude1 - Latitude2) * 69.1
            Dim longlen As Double = (Longitude1 - Longitude2) * 53
            getMiles = Int(Math.Sqrt((latlen * latlen) + (longlen * longlen)))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public WriteOnly Property Selected() As Boolean
        Set(ByVal value As Boolean)
            iSelected = value
            If iSelected Then
                Me.BackColor = isSelected
            Else

                Select Case iDistance
                    Case 2
                        Me.BackColor = medDist
                    Case 3
                        Me.BackColor = longDist
                    Case 4
                        Me.BackColor = Unavailable
                        Me.hasAppointment = True
                    Case Else
                        Me.BackColor = OKDist
                End Select
            End If
        End Set
    End Property

    Public Sub Clear(ByVal atime As String)
        hasAppointment = False
        Me.BackColor = OKDist
        Me.lblArea.Text = ""
        Me.lblTime.Text = atime
        Me.AppointmentTime = atime
        Me.lblTown.Text = ""
        Me.lblTown.Text = ""
        Latitude = 0
        Longitude = 0
        Selected = False
        iDistance = 1
        Me.BackColor = OKDist
    End Sub
    Private Sub ctlDiaryCellv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click, lblTown.Click, lblArea.Click, lblTime.Click
        If Not hasAppointment Then
            RaiseEvent CellClicked(Me.Name)
        End If
    End Sub

    Private Sub ctlDiaryCellv2_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Unavailable = Color.FromArgb(100, 224, 224, 224)
        medDist = Color.FromArgb(100, 255, 224, 192)
        longDist = Color.FromArgb(100, 255, 192, 192)
        OKDist = Color.FromArgb(100, 192, 255, 192)
        Appointment = Color.FromArgb(100, 192, 192, 255)
        isSelected = Color.FromArgb(100, 128, 128, 255)
    End Sub


End Class
