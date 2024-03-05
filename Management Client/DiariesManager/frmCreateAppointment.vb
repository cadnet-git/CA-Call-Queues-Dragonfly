Public Class frmCreateAppointment

    Private iDiaryID As Integer = 0
    Private oOwner As Common.cUser = Nothing
    Private oCompany As Common.cCompany = Nothing

    Public Sub New(ByVal DiaryID As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iDiaryID = DiaryID

        Me.lblCompanyName.Text = ""

        'DiaryListView1.StartDate = Common.DateManipulation.GetStartOfWeek(Date.Now)

        oOwner = New Common.cUser
        oOwner.Load(iDiaryID)

        showOwner()

        refreshAgents()

        ShowDiaryDetails()

    End Sub

    Private Sub RefreshAgents()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim sSQL As String = "SELECT ID, RealName FROM users WHERE UserLevelID=3 or UserLevelID=2 ORDER BY RealName"
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        Me.cmbAgent.Items.Clear()

        Me.cmbAgent.DisplayMember = "Title"
        Me.cmbAgent.ValueMember = "Value"

        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim Item As New Common.cSimpleItem(aRow.Item("ID"), aRow.Item("RealName"))
            Me.cmbAgent.Items.Add(Item)
        Next

    End Sub

    Private Sub ShowOwner()

        Me.DiaryListView1.DiaryID = iDiaryID

        Me.lblOwnerName.Text = oOwner.RealName

        Me.radioApp1.Text = oOwner.AppTime1.TimeOfDay.ToString
        Me.radioApp2.Text = oOwner.AppTime2.TimeOfDay.ToString
        Me.radioApp3.Text = oOwner.AppTime3.TimeOfDay.ToString
        Me.radioApp4.Text = oOwner.AppTime4.TimeOfDay.ToString

        If oOwner.HasApp5 Then
            Me.radioApp5.Text = oOwner.AppTime5.TimeOfDay.ToString
        Else
            Me.radioApp5.Visible = False
        End If

    End Sub

    Private Sub ShowDiaryDetails()
        lblDiaryOwnerName.Text = oOwner.RealName
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click


        Dim anItem As Common.cSimpleItem

        anItem = Me.cmbDay.SelectedItem
        Dim ItemDate As Date = anItem.Value

        anItem = Me.cmbAgent.SelectedItem
        Dim AgentID As Integer = anItem.Value

        Dim RepID As Integer = oOwner.ID
        Dim oRep As Common.cUser
        oRep = New Common.cUser
        oRep.Load(RepID)


        Dim ItemPeriod As Integer
        Dim CompanyID As Integer = oCompany.ID
        Dim sTime As String = ""

        If Me.radioApp5.Checked Then
            ItemPeriod = 5
            sTime = oRep.AppTime5.TimeOfDay.ToString
        ElseIf Me.radioApp4.Checked Then
            ItemPeriod = 4
            sTime = oRep.AppTime4.TimeOfDay.ToString
        ElseIf Me.radioApp3.Checked Then
            ItemPeriod = 3
            sTime = oRep.AppTime3.TimeOfDay.ToString
        ElseIf Me.radioApp2.Checked Then
            ItemPeriod = 2
            sTime = oRep.AppTime2.TimeOfDay.ToString
        ElseIf Me.radioApp1.Checked Then
            ItemPeriod = 1
            sTime = oRep.AppTime1.TimeOfDay.ToString
        End If



        Dim sSQL As String = "INSERT INTO diaryitems (UserID, ItemDate, ItemPeriod, CompanyID, Status, Type,AgentID) VALUES ("

        sSQL = sSQL & RepID
        sSQL = sSQL & ", '" & Common.DateManipulation.DateToString(ItemDate, Common.DateFormats.ForSQLInsertion) & " " & sTime & "'"
        sSQL = sSQL & ", " & ItemPeriod
        sSQL = sSQL & ", " & CompanyID
        sSQL = sSQL & ", 1"
        sSQL = sSQL & ",'CA'"
        sSQL = sSQL & ", " & AgentID
        sSQL = sSQL & ")"

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.ExecuteSQL(sSQL)

        'update the company record
        sSQL = "UPDATE Companies SET"
        sSQL = sSQL & " CompanyStatus='Appointment'"
        sSQL = sSQL & ", AgentID=" & AgentID
        sSQL = sSQL & ", AllowCall=0"
        sSQL = sSQL & " WHERE"
        sSQL = sSQL & " ID=" & CompanyID

        Database.ExecuteSQL(sSQL)


        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnFindCompany_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFindCompany.Click
        Dim aFrm As New frmCompanyFind
        Dim DR As DialogResult = aFrm.ShowDialog

        Select Case DR
            Case DialogResult.OK
                ShowCompany(aFrm.CompanyID)
        End Select
    End Sub

    Private Sub ShowCompany(ByVal CompanyID As Integer)

        If oCompany Is Nothing Then
            oCompany = New Common.cCompany(CompanyID)
        End If

        Me.lblCompanyName.Text = oCompany.CompanyName

        Me.pnlAppointment.Enabled = True

    End Sub

    Private Sub DiaryListView1_RangeChange(ByVal Startdate As Date) Handles DiaryListView1.RangeChange
        'redraw the combbox

        With Me.cmbDay
            .SuspendLayout()

            .Items.Clear()
            .DisplayMember = "Title"
            .ValueMember = "Value"

        End With

        'the startdate will always be a monday, and we are only concerned with weekdays
        For i As Integer = 0 To 4
            Dim aDate As Date = DateAdd(DateInterval.Day, i, Startdate)

            'If Then
            Dim sDate As String = Common.DateManipulation.DateToString(aDate, Common.DateFormats.ForDisplayWithFullDay)
            Dim anItem As New Common.cSimpleItem(aDate, sDate)
            Me.cmbDay.Items.Add(anItem)

        Next

        Me.cmbDay.ResumeLayout()

    End Sub

    Private Sub cmbDay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbDay.SelectedIndexChanged
        EnableOK()
    End Sub

    Private Sub EnableOK()
        'check to see if we can enable ok

        If Me.cmbAgent.SelectedIndex < 0 Then
            Me.btnOK.Enabled = False
            Exit Sub
        End If

        If Me.cmbDay.SelectedIndex < 0 Then
            Me.btnOK.Enabled = False
            Exit Sub
        End If

        If Me.radioApp5.Checked Or Me.radioApp4.Checked Or Me.radioApp3.Checked Or Me.radioApp2.Checked Or Me.radioApp1.Checked Then
        Else
            Me.btnOK.Enabled = False
            Exit Sub
        End If

        Me.btnOK.Enabled = True

    End Sub

    Private Sub radioAppN_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles radioApp1.CheckedChanged, radioApp2.CheckedChanged, radioApp3.CheckedChanged, radioApp4.CheckedChanged, radioApp5.CheckedChanged
        EnableOK()
    End Sub

    Private Sub cmbAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        EnableOK()

    End Sub

End Class
