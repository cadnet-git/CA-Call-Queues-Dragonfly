Imports System.Net
Imports System.IO

Public Class frmMakeAppointment

    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory

    Private notdone = Color.FromArgb(255, 192, 192)
    Private iDisplayWeek As Integer = 1

    Private dsDiary As DataSet

    Dim iCurrentWeek As Integer = 0
    Private dStartDate As Date
    Private dEndDate As Date
    Private AppointmentDateTime As String
    Private sSelectedCell As String = ""

    Private dLatitude As Double
    Private dLongitude As Double

    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall
        Dim ListOfCoverRequired As New List(Of Common.cSimpleItem)
        ListOfCoverRequired.Add(New Common.cSimpleItem(-1, ""))
        ListOfCoverRequired.Add(New Common.cSimpleItem(1, "PMI"))
        ListOfCoverRequired.Add(New Common.cSimpleItem(2, "Life"))
        ListOfCoverRequired.Add(New Common.cSimpleItem(3, "Both"))

        cboCoverRequired.DataSource = ListOfCoverRequired
        cboCoverRequired.DisplayMember = "Title"
        cboCoverRequired.ValueMember = "Value"
    End Sub

    Private Sub btnNotInterested_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotInterested.Click
        Dim sReason As String = ""

        Dim aFrm As New frmGetReasonNotInterested
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        ThisCall.EndCallNotInterested(sReason, aFrm.Months)
        oScript.EndState(iState, ScriptEngine.States.Finished)
        frmAgent.SplitContainer1.Panel2Collapsed = False
        frmAgent.SplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub btnReschedule_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReschedule.Click
        Dim aFrm As New frmScriptReschedule
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If



        Dim oDate As Date
        If frmAgent.IsInTrainingMode Then
            oDate = Now
        Else
            oDate = aFrm.SelectedDate
        End If

        ThisCall.EndCallReschedule(oDate, "Rescheduled")

        oScript.EndState(iState, ScriptEngine.States.Finished)
        frmAgent.SplitContainer1.Panel2Collapsed = False
        frmAgent.SplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub frmMakeAppointment_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        frmAgent.SplitContainer1.Panel2Collapsed = False
        frmAgent.SplitContainer2.Panel2Collapsed = False
    End Sub



    Private Sub frmMakeAppointment_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        ' Me.lblForename.Text = Me.Name

        frmAgent.App.UpdateDeskStatus("Making Appointment")
        frmAgent.SplitContainer1.Panel2Collapsed = True
        frmAgent.SplitContainer2.Panel2Collapsed = True
        dStartDate = CADNet.CallQueues.Common.GetStartOfWeek(Date.Now)
        ' ThisCall.Company.Rep.HasApp5 = True
        lblCounter.Visible = False
        ' set handlers 
        For d As Integer = 1 To 5
            For p As Integer = 1 To 5
                Dim aitem As ctlDiaryCellv2
                aitem = Me.Controls("D" & d & "P" & p)
                Try
                    AddHandler aitem.CellClicked, AddressOf Me.CellClicked
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

            Next
        Next


        If ThisCall.Company.Rep.HasApp5 Then
            setRow5(True)
        Else
            setRow5(False)
        End If

        If ThisCall.Company.Rep.OverrideDiaryWeeks > 0 Then
            diaryweeks = ThisCall.Company.Rep.OverrideDiaryWeeks
        Else
            diaryweeks = frmAgent.App.Settings.DiaryShowWeeks
        End If


        ShowCompany()
        updateCalender()
    End Sub
    Private Sub HandleCallFinished()
        Timer1.Enabled = True
        lblCounter.Visible = True
    End Sub
    Private Sub clearCalender()
        For d As Integer = 1 To 5
            For p As Integer = 1 To 5
                Dim aitem As ctlDiaryCellv2
                aitem = Me.Controls("D" & d & "P" & p)
                Dim atime As String = ""
                Select Case p
                    Case 1
                        atime = ThisCall.Company.Rep.AppTime1.ToShortTimeString
                    Case 2
                        atime = ThisCall.Company.Rep.AppTime2.ToShortTimeString
                    Case 3
                        atime = ThisCall.Company.Rep.AppTime3.ToShortTimeString
                    Case 4
                        atime = ThisCall.Company.Rep.AppTime4.ToShortTimeString
                    Case 5
                        atime = ThisCall.Company.Rep.AppTime5.ToShortTimeString
                End Select
                aitem.hasAppointment = False
                aitem.Distance = 1
                aitem.Period = p
                aitem.Clear(atime)
                aitem.OkMaxDist = ThisCall.Company.Rep.OKMaxDist
                aitem.MedMaxDist = ThisCall.Company.Rep.MedMaxDist
                aitem.LongMaxDist = ThisCall.Company.Rep.LongMaxDist
            Next
        Next
        sSelectedCell = ""
        Me.AppointmentDateTime = ""
        CheckOk()
    End Sub

    Private Sub updateCalender()
        ' get start of week based to show based on start dstartdate plus weeks stepped forward 
        Dim StartDate As Date = DateAdd(DateInterval.Day, 7 * iCurrentWeek, dStartDate)
        StartDate = StartDate.ToLongDateString & " 00:00:01"
        Me.clearCalender()

        lblRepName.Text = ThisCall.Company.Rep.RealName

        ' get appointments 
        Dim DS As DataSet = GetWeek(StartDate)
        ' fill in column titles 
        For t As Integer = 0 To 4
            Me.Controls("lblDay" & (t + 1)).Text = Format(DateAdd(DateInterval.Day, t, StartDate), "ddd - d MMMM yy")
            For x As Integer = 1 To 5
                'tell the controls what day it is ....
                Dim obj As ctlDiaryCellv2 = Me.Controls("D" & (t + 1) & "P" & x)
                obj.AppointmentDate = DateAdd(DateInterval.Day, t, StartDate).ToLongDateString
            Next
        Next

        ' do something with them 
        Me.clearCalender()
        Dim aRow As DataRow
        Dim AppCount As Integer = 0
        For Each aRow In DS.Tables(0).Rows
            Dim thedate As Date = aRow("ItemDate")
            Dim iday As TimeSpan
            iday = thedate.Subtract(StartDate)
            If iday.Days > 4 Then
                Console.WriteLine("Period = " & aRow("ItemPeriod") & " Date = " & aRow("ItemDate") & " day = " & iday.Days + 1)
            Else
                Dim aitem As ctlDiaryCellv2 = Me.Controls("D" & iday.Days + 1 & "P" & aRow("ItemPeriod"))
                aitem.loadData(aRow, ThisCall.Company.Latitude, ThisCall.Company.Longitude)
                If aRow("Type") = "CA" Then
                    AppCount = AppCount + 1
                End If
            End If
        Next

        If AppCount > ThisCall.Company.Rep.AppsPerWeek - 1 Then
            ' need to make everything as unavaiable 
            For t As Integer = 0 To 4
                For x As Integer = 1 To 5
                    'tell the controls what day it is ....
                    Dim obj As ctlDiaryCellv2 = Me.Controls("D" & (t + 1) & "P" & x)
                    If obj.hasAppointment = False Then
                        obj.hasAppointment = True
                        obj.Distance = 4
                    End If
                Next
            Next

        End If

        ' if this week we need to blank out all appointments upto today 
        If iCurrentWeek = 0 Then

            For t As Integer = 0 To 4
                Dim aDay As Date = StartDate.AddDays(t)
                If aDay < Today.AddDays(1) Then
                    For x As Integer = 1 To 5
                        'tell the controls what day it is ....
                        Dim obj As ctlDiaryCellv2 = Controls("D" & (t + 1) & "P" & x)
                        If obj.hasAppointment = False Then
                            obj.hasAppointment = True
                            obj.Distance = 4
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub setRow5(ByVal show As Boolean)
        D1P5.Visible = show
        D2P5.Visible = show
        D3P5.Visible = show
        D4P5.Visible = show
        D5P5.Visible = show
        If show = False Then
            btnPrev.Height = btnPrev.Height - 80
            btnNext.Height = btnNext.Height - 80
        End If
    End Sub


    Private Function GetWeek(ByVal StartDate As Date) As DataSet
        Dim EndDate As Date = DateAdd(DateInterval.Day, 6, StartDate)

        Dim Params As New Collection
        Dim parCompanyID = New SqlClient.SqlParameter("@RepID", SqlDbType.Int)
        parCompanyID.value = ThisCall.Company.Rep.ID
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

    Private Sub CellClicked(ByVal cell As String)
        Dim aitem As ctlDiaryCellv2
        If cell <> sSelectedCell Then
            If sSelectedCell <> "" Then
                '
                aitem = Me.Controls(sSelectedCell)
                aitem.Selected = False
            End If
            aitem = Me.Controls(cell)
            aitem.Selected = True
            sSelectedCell = cell
            Me.AppointmentDateTime = aitem.AppointmentDate & " " & aitem.AppointmentTime
        Else
            'clicked selected cell to deselect it therefore no slot picked 
            aitem = Me.Controls(sSelectedCell)
            aitem.Selected = False
            sSelectedCell = ""
            AppointmentDateTime = ""
        End If
        CheckOk()
    End Sub
    Dim diaryweeks As Integer
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNext.Click
        iCurrentWeek = iCurrentWeek + 1
        updateCalender()



        If iCurrentWeek > diaryweeks - 2 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        If iCurrentWeek < 1 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If

    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrev.Click
        iCurrentWeek = iCurrentWeek - 1
        updateCalender()

        If iCurrentWeek > diaryweeks - 2 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        If iCurrentWeek < 1 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If
    End Sub

    Public Sub ShowCompany()

        With ThisCall.Company
            cmbTitle.Text = .ContactTitle
            txtCompanyName.Text = .CompanyName
            txtContactForeName.Text = .ContactForename
            txtContactSurname.Text = .ContactSurname
            txtContactPosition.Text = .ContactPosition

            txtAddress1.Text = .Address1
            txtAddress2.Text = .Address2
            txtAddress3.Text = .Address3
            txtTown.Text = .Town
            txtCounty.Text = .County
            txtPostcode.Text = .Postcode

            txtTel.Text = .Telephone
            txtFax.Text = .Fax
            txtEmail.Text = .Email

            txtNotes.Text = .Notes
            'frmAgent.Text = ThisCall.Company.Rep.RealName

        End With


    End Sub
    Private Sub txtContactPosition_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactPosition.Leave
        With ThisCall.Company
            .ContactPosition = txtContactPosition.Text
            .Save()
            txtContactPosition.Text = .ContactPosition
        End With
    End Sub


    Private Sub txtContactForeName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactForeName.Leave
        With ThisCall.Company
            .ContactForename = txtContactForeName.Text
            .Save()
            txtContactForeName.Text = .ContactForename
        End With
    End Sub

    Private Sub txtContactSurname_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactSurname.Leave
        With ThisCall.Company
            .ContactSurname = txtContactSurname.Text
            .Save()
            txtContactSurname.Text = .ContactSurname
        End With
    End Sub

    Private Sub txtTel_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTel.Leave
        'With ThisCall.Company
        '    .Telephone = Me.txtTel.Text
        '    .Save()
        'End With
    End Sub

    Private Sub txtFax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFax.Leave
        With ThisCall.Company
            .Fax = txtFax.Text
            .Save()
        End With
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmail.Leave
        With ThisCall.Company
            .Email = txtEmail.Text.ToLower
            .Save()
            Me.txtEmail.Text = .Email
        End With
    End Sub

    Private Sub txtCompanyName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCompanyName.Leave
        With ThisCall.Company
            .CompanyName = txtCompanyName.Text
            .Save()
            txtCompanyName.Text = .CompanyName
        End With
    End Sub

    Private Sub txtAddress1_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress1.Leave
        With ThisCall.Company
            .Address1 = txtAddress1.Text
            .Save()
        End With
    End Sub
    Private Sub txtAddress2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress2.Leave
        With ThisCall.Company
            .Address2 = txtAddress2.Text
            .Save()
        End With
    End Sub
    Private Sub txtAddress3_Leave(sender As Object, e As EventArgs) Handles txtAddress3.Leave
        With ThisCall.Company
            .Address3 = txtAddress3.Text
            .Save()
        End With
    End Sub

    Private Sub txtTown_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTown.Leave
        With ThisCall.Company
            .Town = txtTown.Text
            .Save()
        End With
    End Sub

    Private Sub txtCounty_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCounty.Leave
        With ThisCall.Company
            .County = txtCounty.Text
            .Save()
        End With
    End Sub

    Private Sub CheckOk()
        Dim OKtoSave As Boolean = True
        OKtoSave = True
        If cmbTitle.Text = "" Then
            OKtoSave = False
            cmbTitle.BackColor = Color.LightCoral
        Else
            cmbTitle.BackColor = Color.White
        End If

        If cboCoverRequired.Text = "" Then
            OKtoSave = False
            cboCoverRequired.BackColor = Color.LightCoral
        Else
            cboCoverRequired.BackColor = Color.White
        End If

        If txtContactForeName.Text.Trim = "" Then
            OKtoSave = False
            txtContactForeName.BackColor = Color.LightCoral
            txtContactForeName.Text = ""
        Else
            txtContactForeName.BackColor = Color.White
        End If


        If txtContactSurname.Text.Trim = "" Then
            txtContactSurname.BackColor = Color.LightCoral
            txtContactSurname.Text = ""
            OKtoSave = False
        Else
            txtContactSurname.BackColor = Color.White
        End If

        If txtContactPosition.Text.Trim = "" Then
            txtContactPosition.BackColor = Color.LightCoral
            txtContactPosition.Text = ""
            OKtoSave = False
        Else
            txtContactPosition.BackColor = Color.White
        End If

        If txtTel.Text.Trim = "" Then
            OKtoSave = False
        End If

        If txtAddress1.Text.Trim = "" Then
            Me.btnGetAddress.BackColor = Color.LightCoral
            OKtoSave = False
        Else
            Me.btnGetAddress.BackColor = Color.WhiteSmoke
        End If

        If Me.AppointmentDateTime = "" Then
            OKtoSave = False
        End If

        ' need to be inteligent about fax or email 
        If txtFax.Text = "" And txtEmail.Text = "" Then
            OKtoSave = False
        End If

        If txtFax.Text.Trim = "" Then
            txtFax.BackColor = Color.LightCoral
            txtFax.Text = ""
        Else
            txtFax.BackColor = Color.White
        End If

        If txtEmail.Text.Trim = "" Then
            txtEmail.BackColor = Color.LightCoral
            txtEmail.Text = ""
        Else
            txtEmail.BackColor = Color.White
        End If
        btnSave.Enabled = OKtoSave
    End Sub

    Private Sub cmbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTitle.SelectedIndexChanged
        CheckOk()
    End Sub

    Private Sub txtContactForeName_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactForeName.TextChanged
        CheckOk()
    End Sub


    Private Sub txtContactSurname_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactSurname.TextChanged
        CheckOk()
    End Sub

    Private Sub txtContactPosition_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactPosition.TextChanged
        CheckOk()
    End Sub
    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtFax.TextChanged
        If txtFax.Text.Trim = "" Then
            txtFax.BackColor = Color.LightCoral
            txtFax.Text = ""
        Else
            txtFax.BackColor = Color.White
        End If
        CheckOk()
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text.Trim = "" Then
            txtEmail.BackColor = Color.LightCoral
            txtEmail.Text = ""
        Else
            txtEmail.BackColor = Color.White
        End If
        CheckOk()
    End Sub

    Private Sub cmbTitle_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTitle.Leave
        With ThisCall.Company
            .ContactTitle = Me.cmbTitle.Text
            .Save()
        End With
    End Sub

    Private Sub txtNotes_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtNotes.Leave
        With ThisCall.Company
            .Notes = Me.txtNotes.Text
            .Save()
        End With
    End Sub

    Private Sub btnGetAddress_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGetAddress.Click

        Dim OldRepID As Integer = ThisCall.Company.Rep.ID



        Dim aFrm As New frmChangeAddress(ThisCall.Company)

        aFrm.txtPostcode.Text = Me.txtPostcode.Text


        Dim DR As DialogResult = aFrm.ShowDialog

        If DR = DialogResult.Cancel Then
            Exit Sub
        End If

        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        'reload the company
        ThisCall.Company.Refresh()

        If aFrm.InArea = False Then
            'the postcode supplied by the user is Out of Area, move the script to that page
            Me.Enabled = False
            oScript.EndState(ScriptEngine.States.MakeAppointment, ScriptEngine.States.OutofArea)
            frmAgent.SplitContainer1.Panel2Collapsed = False
            frmAgent.SplitContainer2.Panel2Collapsed = False
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        Dim frmPostcode As frmGetPostcode
        If frmAgent.IsInTrainingMode Then
            'use the free test post code
            frmPostcode = New frmGetPostcode("BL1 3AS", Me)
        Else
            frmPostcode = New frmGetPostcode(ThisCall.Company.Postcode, Me)
        End If


        'Dim frmPostcode As New frmGetPostcode("WR2 6NJ", Me)
        ' test post code wr2 6nj
        If frmPostcode.ShowDialog() = DialogResult.OK Then
            ' update company class and save 
            With ThisCall.Company
                .CompanyName = Me.txtCompanyName.Text
                .Address1 = Me.txtAddress1.Text
                .Address2 = Me.txtAddress2.Text
                .Address3 = Me.txtAddress3.Text
                .Town = Me.txtTown.Text
                .County = Me.txtCounty.Text
                .Save()
            End With
        End If

        Me.ShowCompany()

        CheckOk()

        If OldRepID <> ThisCall.Company.Rep.ID Then
            Me.setRow5(ThisCall.Company.Rep.HasApp5)
            Me.clearCalender()
            Me.updateCalender()
        End If



        Me.Cursor = Cursors.Default



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim params As New Collection

        Dim aitem As ctlDiaryCellv2
        aitem = Me.Controls(sSelectedCell)

        Dim adate As New DateTime
        Dim temp As String = aitem.AppointmentDate & " " & aitem.AppointmentTime
        adate = temp

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@AppointmentDate", SqlDbType.DateTime, adate)
            .CreateParameter(params, "@Period", SqlDbType.Int, aitem.Period)
            .CreateParameter(params, "@UserID", SqlDbType.Int, ThisCall.Company.Rep.ID)
            .CreateParameter(params, "@CompanyID", SqlDbType.Int, ThisCall.Company.ID)
            .CreateParameter(params, "@Status", SqlDbType.Int, 1)
            .CreateParameter(params, "@AgentID", SqlDbType.Int, ThisCall.Company.AgentID)
            .CreateParameter(params, "@CoverRequired", SqlDbType.Int, cboCoverRequired.SelectedValue)
            Try
                .ExecuteSPNoQuery("spAppointmentCreateCA", params)
            Catch ex As Exception
                MsgBox("spAppointmentCreateCA - " & ex.Message)
            End Try
        End With

        Me.Enabled = False
        ThisCall.EndCallAppointment(ThisCall.Company.Rep.RealName, aitem.AppointmentDate & " " & aitem.AppointmentTime)
        frmAgent.nextAction = "Appointment"
        oScript.EndState(iState, ScriptEngine.States.Finished)
        frmAgent.SplitContainer1.Panel2Collapsed = False
        frmAgent.SplitContainer2.Panel2Collapsed = False

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        lblCounter.Text = frmAgent.lblCounter.Text
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnBack.Click

        Me.Enabled = False

        oScript.EndState(iState, oScript.previousState)
        frmAgent.SplitContainer1.Panel2Collapsed = False
        frmAgent.SplitContainer2.Panel2Collapsed = False
    End Sub








    Private Sub cboCoverRequired_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCoverRequired.SelectedIndexChanged
        CheckOk()
    End Sub
End Class