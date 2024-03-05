Public Class ctlManagerDiaryCell
    Public Event CellClicked(ByVal cell As String)
    Public Event Moving(ByVal mAppointment As ctlManagerDiaryCell)
    Public Event Paste(ByVal mAppointment As ctlManagerDiaryCell)
    Public Event NewAppointment(ByVal mAppointment As ctlManagerDiaryCell, ByVal Type As String)
    Public Event Edit(ByVal mAppointment As ctlManagerDiaryCell)
    Public Event CancelAppointment(ByVal mAppointment As ctlManagerDiaryCell)

    Private Unavailable As Color = New Color
    Private medDist As Color = New Color
    Private longDist As Color = New Color
    Private OKDist As Color = New Color
    Private ColourAppointment As Color = New Color
    Private isSelected As Color = New Color

    Private sPreviousControl As String = ""
    Private sNextControl As String = ""

    Dim iDistance As Integer = 1
    Private iSelected As Boolean = False
    Dim iPeriod As Integer = -1
    Private sAppointmentTime As String
    Private sAppointmentDate As String
    Private bHasAppointment As Boolean = False
    Dim astr As String = ""
    Private cAppointment As CADNet.CallQueues.Common.cAppointment
    Dim atooltip As ToolTip
    Dim TooltipOffsetWidth As Double = 0
    Dim toolFont As Font

    Private Sub ctlManagerDiaryCell_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Unavailable = Color.FromArgb(100, 224, 224, 224)
        medDist = Color.FromArgb(100, 255, 224, 192)
        longDist = Color.FromArgb(100, 255, 192, 192)
        OKDist = Color.FromArgb(100, 192, 255, 192)
        ColourAppointment = Color.FromArgb(100, 192, 192, 255)
        isSelected = Color.FromArgb(100, 128, 128, 255)
        atooltip.SetToolTip(lblTime, "")
    End Sub
    Public Property Period() As Integer
        Get
            Period = iPeriod
        End Get
        Set(ByVal value As Integer)
            iPeriod = value
        End Set
    End Property
    Private Function getPreviousCtl()
        Dim ReturnStr As String = Me.Name
        Dim period As Integer = Int(Me.Name.Substring(3, 1))
        If period <> 1 Then
            ReturnStr = Me.Name.Substring(0, 3) & period - 1
        Else
            ReturnStr = ""
        End If
        Return ReturnStr
    End Function
    Private Function getNextCtl()
        Dim ReturnStr As String = Me.Name
        Dim period As Integer = Int(Me.Name.Substring(3, 1))
        If period <> 5 Then
            ReturnStr = Me.Name.Substring(0, 3) & period + 1
        Else
            ReturnStr = ""
        End If
        Return ReturnStr
    End Function
    Public Sub loadAppointment(ByVal ID As Integer)
        Appointment = New CADNet.CallQueues.Common.cAppointment
        If ID = 4499 Then
            Debug.Assert(True)
        End If
        Appointment.load(ID)
        Try


            Select Case Appointment.Type
                Case "CA"
                    Dim tmpString As String = "PMI"
                    Select Case Appointment.CoverRequired
                        Case 2
                            tmpString = "Life"
                        Case 3
                            tmpString = "Both"
                    End Select

                    lblTime.Text = Appointment.TheCompany.Postcode.ToUpper & vbCrLf & tmpString
                Case "REP"
                    If Appointment.RepPostcode <> "" Then
                        lblTime.Text = Appointment.RepPostcode.ToUpper
                    Else
                        lblTime.Text = "Rep PC Missing"
                    End If


                Case Else

            End Select



        Catch ex As Exception

        End Try


        If toolFont Is Nothing Then
            ToolTip1.Show(" ", Me)
            Application.DoEvents()
            ToolTip1.Hide(Me)
        End If
    End Sub
    Public Property HasAppointment() As Boolean
        Get
            HasAppointment = bHasAppointment
        End Get
        Set(ByVal value As Boolean)
            bHasAppointment = value
            atooltip = New ToolTip
            If bHasAppointment = True Then
                Select Case Appointment.Type
                    Case "CA"
                        Dim tmpColour As Color = ColourAppointment
                        Select Case Appointment.CoverRequired
                            Case 2
                                tmpColour = OKDist
                            Case 3
                                tmpColour = medDist
                        End Select

                        Me.BackColor = tmpColour
                        astr = "Contact" & vbTab & vbTab & Appointment.TheCompany.ContactTitle & " " & Appointment.TheCompany.ContactForename & " " & Appointment.TheCompany.ContactSurname & vbCrLf
                        astr = astr & "Position" & vbTab & vbTab & Appointment.TheCompany.ContactPosition & vbCrLf
                        astr = astr & "Company" & vbTab & Appointment.TheCompany.CompanyName & vbCrLf & vbCrLf
                        astr = astr & "Telephone" & vbTab & Appointment.TheCompany.Telephone & vbCrLf
                        astr = astr & "Fax" & vbTab & vbTab & Appointment.TheCompany.Fax & vbCrLf
                        astr = astr & "Email" & vbTab & vbTab & Appointment.TheCompany.Email & vbCrLf
                        Select Case Appointment.WasInsured
                            Case 1
                                astr = astr & "Was Insured:" & vbTab & "Insured" & vbCrLf & vbCrLf
                            Case 2
                                astr = astr & "Was Insured:" & vbTab & "No Cover" & vbCrLf & vbCrLf
                            Case Else
                                astr = astr & "Was Insured:" & vbTab & "Unknown" & vbCrLf & vbCrLf
                        End Select

                        astr = astr & "Date Created:" & vbTab & Appointment.DateCreated & vbCrLf & vbCrLf



                        atooltip.ToolTipTitle = "Appointment"
                    Case "REP"
                        Me.BackColor = Unavailable
                        astr = "Company" & vbTab & Appointment.Description & vbCrLf
                        astr = astr & "Date Created:" & vbTab & Appointment.DateCreated & vbCrLf & vbCrLf
                        atooltip.ToolTipTitle = "Self Generated"
                    Case "GEN"
                        Me.BackColor = Unavailable
                        astr = "Description" & vbTab & Appointment.Description & vbCrLf
                        astr = astr & "Date Created:" & vbTab & Appointment.DateCreated & vbCrLf & vbCrLf
                        atooltip.ToolTipTitle = "General"
                End Select
            Else
                Me.BackColor = Color.White
            End If
        End Set
    End Property

    Public Property Appointment() As CADNet.CallQueues.Common.cAppointment
        Get
            Appointment = cAppointment
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cAppointment)
            cAppointment = value

        End Set
    End Property
    Public Sub setnearCtls()
        sPreviousControl = getPreviousCtl()
        sNextControl = getNextCtl()
    End Sub

    Public Property AppointmentTime() As String
        Get
            AppointmentTime = sAppointmentTime
        End Get
        Set(ByVal value As String)
            sAppointmentTime = value
            lblTime.Text = sAppointmentTime
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
    Public Property Selected() As Boolean
        Get
            Selected = iSelected
        End Get
        Set(ByVal value As Boolean)
            iSelected = value
            If iSelected Then
                Me.BackColor = Color.LightBlue
            Else
                Me.BackColor = Color.White
            End If
        End Set
    End Property

    Private Sub AddShadow(ByVal e As PaintEventArgs)

        Dim SizeText As New SizeF(10.5F, 20.8F)
        Dim biggest As Double = 0
        Dim measured As Double = 0

        Dim afont As Font = toolFont 'New Font("segoe UI", 9, System.Drawing.FontStyle.Regular)
        Try
            Select Case Appointment.Type
                Case "CA"
                    SizeText = e.Graphics.MeasureString(Me.Appointment.TheCompany.CompanyName, afont)
                    biggest = SizeText.Width

                    SizeText = e.Graphics.MeasureString(Me.Appointment.TheCompany.Email, afont)

                    If SizeText.Width > biggest Then
                        biggest = SizeText.Width
                    End If

                    SizeText = e.Graphics.MeasureString(Appointment.TheCompany.ContactTitle & " " & Appointment.TheCompany.ContactForename & " " & Appointment.TheCompany.ContactSurname, afont)

                    If SizeText.Width > biggest Then
                        biggest = SizeText.Width
                    End If

                    SizeText = e.Graphics.MeasureString(Appointment.TheCompany.ContactPosition, afont)

                    If SizeText.Width > biggest Then
                        biggest = SizeText.Width
                    End If
                    TooltipOffsetWidth = 0 - (Me.Width * 1.5) - 5 - biggest

                Case Else
                    SizeText = e.Graphics.MeasureString("Date Created " & Me.Appointment.DateCreated, afont)
                    TooltipOffsetWidth = -20 - SizeText.Width



            End Select
        Catch ex As Exception
        End Try

    End Sub


    Private Sub lblTime_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.MouseEnter
        If bHasAppointment Then
            ' atooltip.Show(astr, Me.lblTime, TooltipOffsetWidth, 40)
            atooltip.Show(astr, Me.lblTime, TooltipOffsetWidth, 45)
        End If
    End Sub

    Private Sub lblTime_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.MouseLeave
        'If bHasAppointment Then
        atooltip.Hide(Me.lblTime)
        'End If
    End Sub

    Private Sub MoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MoveToolStripMenuItem.Click
        RaiseEvent Moving(Me)
        Me.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        RaiseEvent Paste(Me)
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim aCmb As ComboBox = Me.Parent.Controls("cmbSelectRep")
        If aCmb.SelectedIndex <> -1 Then
            If bHasAppointment Then
                If Appointment.Type = "CA" Then
                    EditToolStripMenuItem.Visible = True
                    MoveToolStripMenuItem.Visible = True
                    PasteToolStripMenuItem.Visible = False
                    NewToolStripMenuItem.Visible = False

                Else
                    EditToolStripMenuItem.Visible = False
                    MoveToolStripMenuItem.Visible = True
                    PasteToolStripMenuItem.Visible = False
                    NewToolStripMenuItem.Visible = False
                End If
                CancelToolStripMenuItem.Visible = True
            Else
                EditToolStripMenuItem.Visible = False
                MoveToolStripMenuItem.Visible = False
                PasteToolStripMenuItem.Visible = True
                NewToolStripMenuItem.Visible = True
                CancelToolStripMenuItem.Visible = False
            End If
        Else
            e.Cancel = True

        End If
    End Sub
    Private Sub toolTip1_Draw(ByVal sender As System.Object, ByVal e As DrawToolTipEventArgs) Handles ToolTip1.Draw
        toolFont = e.Font
    End Sub

    Private Sub ctlManagerDiaryCell_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.MouseLeave

    End Sub

    Private Sub ctlManagerDiaryCell_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' AddShadow(e)
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles GeneralToolStripMenuItem.Click
        RaiseEvent NewAppointment(Me, "GEN")
        Me.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        RaiseEvent Edit(Me)
    End Sub

    Private Sub SelfGeneratedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SelfGeneratedToolStripMenuItem.Click
        RaiseEvent NewAppointment(Me, "REP")
        Me.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CancelToolStripMenuItem.Click
        RaiseEvent CancelAppointment(Me)
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblTime.Click
        If Not Me.HasAppointment Then
            RaiseEvent CellClicked(Me.Name)
        End If
    End Sub



End Class
