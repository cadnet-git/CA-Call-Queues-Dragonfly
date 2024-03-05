Public Class frmDiaryDialog

    Dim startDate As DateTime
    Dim Rep As Common.cUser
    Dim movingCtl As ctlManagerDiaryCell
    Dim movingApp As Common.cAppointment
    Dim Appointment As Common.cAppointment
    Dim newApointmentDateTime As DateTime
    Dim NewAppointmentPeriod As Integer
    Dim Loading As Boolean = True
    Dim isDayTask As Boolean = False
    Dim sSelectedCell As String = ""
    Public AppointmentDateTime As String = ""
    Public Period As Integer = 0
    Public Sub New(ByVal arep As Common.cUser)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Rep = arep
    End Sub
    Private Sub CellClicked(ByVal cell As String)
        Dim aitem As ctlManagerDiaryCell
        If cell <> sSelectedCell Then
            If sSelectedCell <> "" Then
                '
                aitem = Me.Controls(sSelectedCell)
                aitem.Selected = False
            End If
            aitem = Me.Controls(cell)
            aitem.Selected = True
            sSelectedCell = cell
            Me.Period = aitem.Period
            Me.AppointmentDateTime = aitem.AppointmentDate & " " & aitem.AppointmentTime
        Else
            'clicked selected cell to deselect it therefore no slot picked 
            aitem = Me.Controls(sSelectedCell)
            aitem.Selected = False
            sSelectedCell = ""
            Me.AppointmentDateTime = ""
            Me.Period = 0
        End If

    End Sub




    Private Sub FrmDiaryDialog_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        startDate = DateAdd(DateInterval.Day, 7, CADNet.CallQueues.Common.GetStartOfWeek(Date.Now))
        startDate = startDate.ToLongDateString & " 00:00:01"

        ' set handlers 
        For d As Integer = 1 To 5
            For p As Integer = 1 To 5
                Dim aitem As ctlManagerDiaryCell
                aitem = Me.Controls("D" & d & "P" & p)
                Try
                    AddHandler aitem.CellClicked, AddressOf Me.CellClicked
                    ' AddHandler aitem.Moving, AddressOf Me.HandleMoving
                    ' AddHandler aitem.Paste, AddressOf Me.HandlePaste
                    '  AddHandler aitem.NewAppointment, AddressOf Me.HandleNewAppointment
                    ' AddHandler aitem.Edit, AddressOf Me.handleEdit
                    '  AddHandler aitem.CancelAppointment, AddressOf Me.HandleCancelAppointment
                    aitem.setnearCtls()
                    aitem.Parent = Me
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

            Next
        Next
        setRow5(Rep.HasApp5)
        Application.DoEvents()
        updateDiary()
        Loading = False
        ' PanelDiary.Enabled = False
    End Sub


    Private Sub setRow5(ByVal show As Boolean)
        Me.D1P5.Visible = show
        Me.D2P5.Visible = show
        Me.D3P5.Visible = show
        Me.D4P5.Visible = show
        Me.D5P5.Visible = show
        If show = False Then
            btnPrev.Height = 220
            BtnNext.Height = 220
        Else
            btnPrev.Height = 265
            BtnNext.Height = 265
        End If
    End Sub
    Private Sub clearCalender()
        For d As Integer = 1 To 5
            For p As Integer = 1 To 5
                Dim aitem As ctlManagerDiaryCell
                aitem = Me.Controls("D" & d & "P" & p)
                aitem.HasAppointment = False
                aitem.BackColor = Color.White
                Dim atime As String = ""
                aitem.Appointment = Nothing
                Select Case p
                    Case 1
                        atime = Rep.AppTime1.ToShortTimeString
                    Case 2
                        atime = Rep.AppTime2.ToShortTimeString
                    Case 3
                        atime = Rep.AppTime3.ToShortTimeString
                    Case 4
                        atime = Rep.AppTime4.ToShortTimeString
                    Case 5
                        atime = Rep.AppTime5.ToShortTimeString
                End Select
                aitem.Period = p
                aitem.AppointmentTime = atime
            Next
        Next

    End Sub
    Private Sub updateDiary()
        For t As Integer = 1 To 5
            Me.Controls("D" & t).Text = Format(startDate.AddDays(t - 1), "d MMM yy")
        Next
        Me.lblRepName.Text = Rep.RealName
        ' get appointments 
        Dim DS As DataSet = GetWeek(startDate)
        ' fill in colomn titles 
        For t As Integer = 0 To 4
            For x As Integer = 1 To 5
                'tell the controls what day it is ....
                Dim obj As ctlManagerDiaryCell = Me.Controls("D" & (t + 1) & "P" & x)
                obj.AppointmentDate = DateAdd(DateInterval.Day, t, startDate).ToLongDateString
            Next
        Next

        ' do something with them 
        Me.clearCalender()

        Dim DayStr As String = ""
        Dim aRow As DataRow
        For Each aRow In DS.Tables(0).Rows
            Dim thedate As Date = aRow("ItemDate")
            Dim iday As TimeSpan
            iday = thedate.Subtract(startDate)
            DayStr = "D" & iday.Days + 1 & "P" & aRow("ItemPeriod")
            Dim aitem As ctlManagerDiaryCell = Me.Controls(DayStr)
            aitem.loadAppointment(aRow("ID"))
            aitem.HasAppointment = True
        Next




    End Sub

    Private Function GetWeek(ByVal StartDate As Date) As DataSet
        Dim EndDate As Date = DateAdd(DateInterval.Day, 7, StartDate)

        Dim Params As New Collection
        Dim parCompanyID = New SqlClient.SqlParameter("@RepID", SqlDbType.Int)
        parCompanyID.value = Rep.ID
        Params.Add(parCompanyID)

        Dim parStartDate As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parStartDate.Value = StartDate
        Params.Add(parStartDate)

        Dim parEndDate As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parEndDate.Value = EndDate
        Params.Add(parEndDate)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spGetDiaryForCompany", Params)
        Return DS
    End Function
    Private Sub HandleCancelAppointment(ByVal ctl As ctlManagerDiaryCell)
        Dim tempstr As String = ""
        If ctl.Appointment.Type = "CA" Then
            tempstr = ctl.Appointment.TheCompany.CompanyName
        Else
            tempstr = ctl.Appointment.Description
        End If
        If MsgBox("Are you sure you want to cancel this appointment" & vbCrLf & vbCrLf & tempstr, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Canceling Appointment") = MsgBoxResult.Yes Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = 0  WHERE ID = " & ctl.Appointment.ID)
            ctl.HasAppointment = False
            AddNote("Cancelled", ctl.Appointment)
            Me.clearCalender()
            updateDiary()
        Else
            ctl.HasAppointment = True
        End If

    End Sub


    Private Sub AddNote(ByVal Note As String, ByVal app As Common.cAppointment)
        Dim params As New Collection
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@UserID", SqlDbType.Int, oApp.CurrentUser.ID)
            .CreateParameter(params, "@AppID", SqlDbType.Int, app.ID)
            .CreateParameter(params, "@Note", SqlDbType.NVarChar, Note)
            Try
                .ExecuteSPNoQuery("spCreateAppNote", params)
            Catch ex As Exception
                MsgBox("spCreateAppNote - " & ex.Message)
            End Try
        End With
    End Sub




    Private Sub HandleMoving(ByVal ctl As ctlManagerDiaryCell)
        movingApp = New Common.cAppointment
        movingApp.load(ctl.Appointment.ID)
    End Sub
    Private Sub HandlePaste(ByVal ctl As ctlManagerDiaryCell)
        ' save change 
        movingApp.ChangeSlot(ctl.AppointmentDate & " " & ctl.AppointmentTime, ctl.Period)
        Me.clearCalender()
        Me.updateDiary()
    End Sub
    Private Sub HandleNewAppointment(ByVal ctl As ctlManagerDiaryCell, ByVal Type As String)
        Select Case Type
            Case "GEN"
                Appointment = ctl.Appointment
                Me.newApointmentDateTime = ctl.AppointmentDate & " " & ctl.AppointmentTime
                NewAppointmentPeriod = ctl.Period
                Me.PanelGeneral.Visible = True
            Case "REP"
                Appointment = ctl.Appointment
                Me.newApointmentDateTime = ctl.AppointmentDate & " " & ctl.AppointmentTime
                NewAppointmentPeriod = ctl.Period
                Me.PanelRepGenerated.Visible = True
        End Select
    End Sub
    Private Sub handleEdit(ByVal ctl As ctlManagerDiaryCell)
        Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(ctl.Appointment.ID)
        Afrm.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnNext.Click
        startDate = startDate.AddDays(7)
        updateDiary()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrev.Click
        startDate = startDate.AddDays(-7)
        updateDiary()
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Me.PanelGeneral.Visible = False
    End Sub


    Private Sub btnSaveGeneralAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSaveGeneralAppointment.Click
        Dim params As Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        If Me.cmbDescription.Text <> "" Then
            If isDayTask Then
                Dim adate As New DateTime
                Dim x As Integer = 4
                Dim Atime As String = ""
                If Rep.HasApp5 Then
                    x = 5
                End If

                For t As Integer = 1 To x

                    Select Case t
                        Case 1
                            Atime = Rep.AppTime1.ToShortTimeString
                        Case 2
                            Atime = Rep.AppTime2.ToShortTimeString
                        Case 3
                            Atime = Rep.AppTime3.ToShortTimeString
                        Case 4
                            Atime = Rep.AppTime4.ToShortTimeString
                        Case 5
                            Atime = Rep.AppTime5.ToShortTimeString
                    End Select
                    adate = Me.newApointmentDateTime.ToLongDateString & " " & Atime
                    params = New Collection
                    With Database
                        .CreateParameter(params, "@AppointmentDate", SqlDbType.DateTime, adate)
                        .CreateParameter(params, "@Period", SqlDbType.Int, t)
                        .CreateParameter(params, "@UserID", SqlDbType.Int, Rep.ID)
                        .CreateParameter(params, "@Description", SqlDbType.NVarChar, Me.cmbDescription.Text)
                        .CreateParameter(params, "@Status", SqlDbType.Int, 1)
                        Try
                            .ExecuteSPNoQuery("spAppointmentCreateGen", params)
                        Catch ex As Exception
                            MsgBox("spAppointmentCreate - " & ex.Message)
                        End Try
                    End With

                Next t
                Me.updateDiary()

            Else
                ' single Task
                params = New Collection
                Dim adate As New DateTime
                adate = Me.newApointmentDateTime
                With Database
                    .CreateParameter(params, "@AppointmentDate", SqlDbType.DateTime, adate)
                    .CreateParameter(params, "@Period", SqlDbType.Int, Me.NewAppointmentPeriod)
                    .CreateParameter(params, "@UserID", SqlDbType.Int, Rep.ID)
                    .CreateParameter(params, "@Description", SqlDbType.NVarChar, Me.cmbDescription.Text)
                    .CreateParameter(params, "@Status", SqlDbType.Int, 1)
                    Try
                        .ExecuteSPNoQuery("spAppointmentCreateGen", params)
                    Catch ex As Exception
                        MsgBox("spAppointmentCreate - " & ex.Message)
                    End Try
                End With

                Me.updateDiary()
            End If
        Else
            MsgBox("You must Enter a Description")
        End If
        Me.PanelGeneral.Visible = False
        isDayTask = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
        PanelRepGenerated.Visible = False
    End Sub

    Private Sub BtnSaveRepGenerated_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnSaveRepGenerated.Click

        If Me.txtCompany.Text.Length < 5 Then
            MsgBox("You must enter a company Name ")
            Exit Sub
        End If
        'testPostcode()

        Dim latLong As New Common.LatLong
        Dim sResult As String = Common.cPostcode.ValidatePostcode(txtPostcode.Text)
        If sResult.Length > 0 Then
            MsgBox(sResult)
        Else
            ' ok sofar 
            latLong = Common.cPostcode.getLatLongObject(txtPostcode.Text)
        End If


        Dim params As New Collection
        Dim adate As New DateTime
        adate = Me.newApointmentDateTime
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@AppointmentDate", SqlDbType.DateTime, adate)
            .CreateParameter(params, "@Period", SqlDbType.Int, Me.NewAppointmentPeriod)
            .CreateParameter(params, "@UserID", SqlDbType.Int, Rep.ID)
            .CreateParameter(params, "@Description", SqlDbType.NVarChar, Me.txtCompany.Text)
            .CreateParameter(params, "@Latitude", SqlDbType.Float, latLong.Latitude)
            .CreateParameter(params, "@Longitude", SqlDbType.Float, latLong.Longitude)
            .CreateParameter(params, "@Status", SqlDbType.Int, 1)
            .CreateParameter(params, "@Postcode", SqlDbType.NVarChar, txtPostcode.Text)
            Try
                .ExecuteSPNoQuery("spAppointmentCreateRep", params)
            Catch ex As Exception
                MsgBox("spAppointmentCreate - " & ex.Message)
            End Try
        End With


        Me.updateDiary()
        PanelRepGenerated.Visible = False
    End Sub



    Private Sub ColHeaderMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ColHeaderMenu.Opening
        Dim s As ContextMenuStrip = sender

    End Sub

    Private Sub DailyGeneralAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DailyGeneralAppointmentToolStripMenuItem.Click
        Dim s As ToolStripMenuItem = sender
        Dim a As ContextMenuStrip = s.GetCurrentParent
        Dim aCell As ctlManagerDiaryCell
        For t As Integer = 1 To 5

            aCell = Me.Controls(a.SourceControl.Name & "P" & t)
            If aCell.HasAppointment = True Then
                MsgBox("Cannot add All Day event already has Appointment")
                Exit Sub
            End If
        Next

        isDayTask = True
        Me.newApointmentDateTime = a.SourceControl.Text
        Me.PanelGeneral.Visible = True


    End Sub

    Private Sub D5P5_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles D5P5.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnSave.Click
        If AppointmentDateTime = "" Then
            MsgBox("You need to select a Appointment Slot")
        Else
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class