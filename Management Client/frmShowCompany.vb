Imports CADNet.CallQueues.Common
Public Class frmShowCompany
    Dim Company As Common.cCompany
    Public Sub New(ByVal CompanyID)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Company = New Common.cCompany(CompanyID)

    End Sub
    Dim LegalEntities As List(Of cSimpleItem)
    Private Sub LoadLegalEntities()
        LegalEntities = New List(Of cSimpleItem)

        LegalEntities.Add(New cSimpleItem(0, ""))
        LegalEntities.Add(New cSimpleItem(1, "Limited"))
        LegalEntities.Add(New cSimpleItem(2, "Limited Partnership"))
        LegalEntities.Add(New cSimpleItem(3, "PLC"))
        LegalEntities.Add(New cSimpleItem(4, "Partnership"))
        LegalEntities.Add(New cSimpleItem(5, "Sole Trader"))

        cboLegalEntity.DataSource = LegalEntities
    End Sub


    Dim isloading As Boolean = False
    Private Sub frmShowCompany_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        isloading = True
        LoadLegalEntities()
        refreshForm()
        isloading = False
    End Sub
    Private Sub refreshForm()
        With Company
            Text = "Company Number - " & .ID
            cmbTitle.Text = .ContactTitle
            txtCompanyName.Text = .CompanyName
            txtContactForeName.Text = .ContactForename
            txtContactSurname.Text = .ContactSurname
            txtContactPosition.Text = .ContactPosition
            lblAddress1.Text = .Address1
            lblAddress2.Text = .Address2
            lblAddress3.Text = .Address3
            lblTown.Text = .Town
            lblCounty.Text = .County
            lblPostcode.Text = .Postcode
            lblSDM.Text = .SeniorDecisionMaker
            cmbEmployees.Text = .Employees
            lblGroupCompany.Text = Company.GroupCompany
            Dim oApp As cManagerApp = cManagerApp.GetInstance
            btnChangeGroupCompany.Visible = oApp.CurrentUser.ID < 10

            If .TPSUntil < Now Then
                BtnBypass.Visible = True
            Else
                BtnBypass.Visible = False
            End If
            lblTel.Text = .Telephone
            txtFax.Text = .Fax
            txtEmail.Text = .Email
            lblAgentName.Text = .Agent.RealName
            lblArea.Text = .Area
            lblRep.Text = .Rep.RealName
            If .PolicyExpires = #12:00:00 AM# Then
                lblPolicyExpiry.Text = ""
            Else
                lblPolicyExpiry.Text = .PolicyExpires.ToLongDateString
            End If
            lblPolicyProvider.Text = .PolicyProvider
            txtNotes.Text = .Notes

            If .LegalEntity Is Nothing Then
                cboLegalEntity.SelectedValue = 0
            Else
                cboLegalEntity.SelectedValue = .LegalEntity
            End If
            ShowHideConsent()
            lblConsentGivenBy.Text = .ConsentGivenBy

            If (.ConsentGivenByDate Is Nothing) Then
                lblConsentDate.Text = ""
            Else

                lblConsentDate.Text = .ConsentGivenByDate.Value.ToLongDateString
            End If

            If (.ConsentUntil Is Nothing) Then
                lblConsentUntil.Text = ""
            Else
                lblConsentUntil.Text = .ConsentUntil.Value.ToLongDateString
            End If

            lblConsentPosition.Text = .ConsentGivenByPosition

            ' add call history
            lvHistory.Items.Clear()
            Dim aItem As ListViewItem
            ' cope with seperation for first history record 
            Try
                aItem = New ListViewItem(Company.ThisCall.Agent)
                aItem.SubItems.Add(String.Format("{0} - {1}", Format(Company.ThisCall.CallStarted, "d MMM yy"), Company.ThisCall.CallStarted.ToShortTimeString))
                aItem.SubItems.Add(Company.ThisCall.CallStartStatus)
                aItem.SubItems.Add(Company.ThisCall.CallEndStatus)
                aItem.SubItems.Add(Company.ThisCall.CallFailureReason)
                lvHistory.Items.Add(aItem)
            Catch ex As Exception
            End Try

            ' add rest of history

            For Each ahistory As Common.cCallHistory In .History
                aItem = New ListViewItem(ahistory.Agent)
                aItem.SubItems.Add(String.Format("{0} - {1}", Format(ahistory.CallStarted, "d MMM yy"), ahistory.CallStarted.ToShortTimeString))
                aItem.SubItems.Add(ahistory.CallStartStatus)
                aItem.SubItems.Add(ahistory.CallEndStatus)
                aItem.SubItems.Add(ahistory.CallFailureReason)
                lvHistory.Items.Add(aItem)
            Next
        End With
        Dim database As New Common.DataLayer
        Dim DS As DataSet
        Dim ssql As String
        ssql = "SELECT DiaryItems.ID, DiaryItems.itemdate, Users.RealName AS Rep, AppointmentHistory.Note, AppointmentHistory.Added, Users_1.RealName AS Admin"
        ssql = ssql & " FROM            DiaryItems INNER JOIN"
        ssql = ssql & "   Users ON DiaryItems.UserID = Users.ID INNER JOIN"
        ssql = ssql & "   AppointmentHistory ON DiaryItems.ID = AppointmentHistory.AppID INNER JOIN"
        ssql = ssql & "   Users AS Users_1 ON AppointmentHistory.UserID = Users_1.ID"
        ssql = ssql & "  WHERE(DiaryItems.CompanyID = " & Company.ID & ")"
        ssql = ssql & " ORDER BY AppointmentHistory.Added DESC"
        DS = database.ExecuteSQL(ssql)
        Dim lvitem As ListViewItem
        For Each DR As DataRow In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Tag = DR("ID")
            lvitem.Text = DR("REP")
            lvitem.SubItems.Add(DR("itemdate"))
            lvitem.SubItems.Add(DR("Admin"))
            lvitem.SubItems.Add(DR("added"))
            lvitem.SubItems.Add(DR("Note"))
            LVAppNotes.Items.Add(lvitem)
        Next
        CheckOk()
    End Sub
    Private Sub cmbTitle_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTitle.Leave
        With Company
            .ContactTitle = Me.cmbTitle.Text
            .Save()
        End With
    End Sub

    Private Sub txtNotes_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtNotes.Leave
        With Company
            .Notes = Me.txtNotes.Text
            .Save()
        End With
    End Sub

    Private Sub txtContactPosition_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactPosition.Leave
        Company.ContactPosition = txtContactPosition.Text
        Company.Save()
        txtContactPosition.Text = Company.ContactPosition
    End Sub


    Private Sub txtContactForeName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactForeName.Leave
        With Company
            .ContactForename = txtContactForeName.Text
            .Save()
            txtContactForeName.Text = .ContactForename
        End With
    End Sub

    Private Sub txtContactSurname_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactSurname.Leave
        With Company
            .ContactSurname = Me.txtContactSurname.Text
            .Save()
            Me.txtContactSurname.Text = .ContactSurname
        End With
    End Sub


    Private Sub txtFax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFax.Leave
        With Company
            .Fax = Me.txtFax.Text
            .Save()
        End With
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmail.Leave
        With Company
            .Email = Me.txtEmail.Text.ToLower
            .Save()
            Me.txtEmail.Text = .Email
        End With
    End Sub

    Private Sub txtCompanyName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCompanyName.Leave
        With Company
            .CompanyName = Me.txtCompanyName.Text
            .Save()
            Me.txtCompanyName.Text = .CompanyName
        End With
    End Sub
    Private Sub CheckOk()
        Dim OKtoSave As Boolean = True
        OKtoSave = True
        If cmbTitle.Text = "" Then
            OKtoSave = False
            cmbTitle.BackColor = Color.LightCoral
            cmbTitle.Text = ""
        Else
            cmbTitle.BackColor = Color.White
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

    Private Sub BtnMakeLive_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnMakeLive.Click
        ' this button is wrongly named should be change provider

        Dim afrm As New frmCheckProviderManager(Company)
        If afrm.ShowDialog() = DialogResult.OK Then
            Company.PolicyProvider = afrm.cboProvider.Text
            ' create callback as per renewal date rules
            Dim oDate As Date
            If Company.Status = "Sale" Or Company.Status = "Transfer" Or Company.Status = "Appointment" Then
                Company.PolicyExpires = afrm.cmbExpiresDay.Text & " " & afrm.cmbExpires.Text
            Else
                Select Case Company.PolicyProvider
                    Case "No Cover"
                        oDate = Now.AddMonths(6)
                        Company.Status = "ColdCall"
                        Company.Notes = ""
                        Company.AgentID = 0
                        afrm.cmbExpires.Text = "Jan 1900"
                    Case Else
                        'set up a reschedule for 2 months before the renewal date
                        oDate = DateAdd(DateInterval.Month, -2, CDate("1 " & afrm.cmbExpires.Text))
                        Company.Status = "CallBack"
                End Select
                Company.PolicyExpires = afrm.cmbExpiresDay.Text & " " & afrm.cmbExpires.Text
                Company.CallBackOn(oDate)
                If afrm.cboProvider.Text = "Other" Then
                    Company.PolicyProvider = afrm.txtOther.Text
                Else
                    Company.PolicyProvider = afrm.cboProvider.Text
                End If
            End If

            Dim app As cManagerApp = cManagerApp.GetInstance
            app.AddManagerNote(String.Format("Company Changed, Provider set to : {0}  Renewal set to : {1}  Holduntil set to : {2}", Company.PolicyProvider, Company.PolicyExpires.ToLongDateString, Company.HoldUntil.ToLongDateString), Company.ID, 0)
            Company.Save()
        End If
        Me.Close()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub btnChangeTelephone_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnChangeTelephone.Click
        Using aFrm As New Common.frmChangeTelephone(Company)
            If aFrm.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            'update the company with the new telephone
            With Company
                'if you set the telephone number to a used telephone number it will throw an exception
                'if its ok, we need to drop the exisitng call and dial the new number (from a button)
                Dim sOldTelephone As String = .Telephone
                Try
                    .Telephone = aFrm.txtTelephone.Text
                    .Save()
                    lblTel.BackColor = Color.White
                Catch ex As Exception
                    Select Case ex.Message
                        Case "Telephone number is already in use"
                            Dim sMsg As String = "That telephone number is already allocated to a different company."
                            sMsg = sMsg & vbCrLf & "Please confirm that it is correct" '& vbCrLf
                            MessageBox.Show(sMsg)
                            Exit Sub
                        Case Else
                            MessageBox.Show("Cannot change telephone number: " & vbCrLf & ex.Message)
                            Exit Sub
                    End Select
                End Try
                lblTel.Text = Company.Telephone
            End With
        End Using
    End Sub

    Private Sub BtnKill_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnKill.Click
        If MsgBox("Are you sure you want to KILL this Company?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "*** WARNING ****") = MsgBoxResult.Yes Then
            Dim database As New Common.DataLayer
            Dim oApp As cManagerApp = cManagerApp.GetInstance
            Dim ssql As String = "INSERT INTO CompanyHistory "
            ssql = ssql & " (CompanyID, UserID, CallEndStatus, CallStartTime, CallEndTime, CallFailureReason, CallStartStatus, StatusChecked, NewCall, DateCreated) VALUES "
            ssql = ssql & " (" & Company.ID & "," & oApp.CurrentUser.ID & ",'Supervisor' ,'" & Now.ToLongDateString & " " & Now.ToLongTimeString & "','" & Now.ToLongDateString & " " & Now.ToLongTimeString & "','Killed By Supervisor','Supervisor',0,2,'" & Now.ToLongDateString & " " & Now.ToLongTimeString & "')"
            database.ExecuteSQL(ssql)
            Company.AllowCalls = False
            Company.Status = "Supervisor"
            Company.Save()
            Company.Refresh()
            Company = New Common.cCompany(Company.ID)
            refreshForm()
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to Ban this Company?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "*** WARNING ****") = MsgBoxResult.Yes Then
            Dim database As New Common.DataLayer
            Dim oApp As cManagerApp = cManagerApp.GetInstance
            Dim ssql As String = "INSERT INTO CompanyHistory "
            ssql = ssql & " (CompanyID, UserID, CallEndStatus, CallStartTime, CallEndTime, CallFailureReason, CallStartStatus, StatusChecked, NewCall, DateCreated) VALUES "
            ssql = ssql & " (" & Company.ID & "," & oApp.CurrentUser.ID & ",'Supervisor' ,'" & Now.ToLongDateString & " " & Now.ToLongTimeString & "','" & Now.ToLongDateString & " " & Now.ToLongTimeString & "','Banned By Supervisor','Supervisor',0,2,'" & Now.ToLongDateString & " " & Now.ToLongTimeString & "')"
            database.ExecuteSQL(ssql)
            Company.AllowCalls = False
            Company.Status = "Supervisor"
            Company.Save()
            Company = New Common.cCompany(Company.ID)
            refreshForm()
        End If
    End Sub

    Private Sub BtnChangeAgent_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnChangeAgent.Click
        Using afrm As New frmSelectUser
            If afrm.ShowDialog = DialogResult.OK Then
                Dim agentID As Integer = afrm.lvAll.SelectedItems(0).Text
                If MsgBox(String.Format("You are about to move this record to {0} and set its holduntil to today", afrm.lvAll.SelectedItems(0).SubItems(1).Text), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    With Company
                        .AgentID = agentID
                        .Agent.Load(agentID)
                        .HoldUntil = Now
                        Dim app As cManagerApp = cManagerApp.GetInstance
                        app.AddManagerNote(String.Format("Company  Agent Changed to :{0}", .Agent.RealName), .ID, .AgentID)
                        .Save()
                    End With


                    refreshForm()
                End If
            End If
        End Using
    End Sub

    Private Sub BtnBypass_Click(sender As System.Object, e As EventArgs) Handles BtnBypass.Click
        Dim database As New Common.DataLayer
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Dim ssql As String = "INSERT INTO CompanyHistory "
        ssql = ssql & " (CompanyID, UserID, CallEndStatus, CallStartTime, CallEndTime, CallFailureReason, CallStartStatus, StatusChecked, NewCall, DateCreated) VALUES "
        ssql = String.Format("{0} ({1},{2},'Reschedule' ,'{3} {4}','{3} {4}','TPS Bypassed for 3 months','TPS',0,2,'{3} {4}')", ssql, Company.ID, oApp.CurrentUser.ID, Now.ToLongDateString, Now.ToLongTimeString)
        database.ExecuteSQL(ssql)
        Company.TPSUntil = Now.AddMonths(3)
        Company.HoldUntil = Now
        Company.Save()
        Company.Refresh()
        refreshForm()
    End Sub




    Private Sub BtnReturnToDB_Click(sender As System.Object, e As EventArgs) Handles BtnReturnToDB.Click
        Dim afrm As New frmCheckProviderManager(Company)
        If afrm.ShowDialog() = DialogResult.OK Then
            Company.PolicyProvider = afrm.cboProvider.Text
            'create callback as per renewal date rules
            Dim oDate As Date
            Dim originalStatus As String = Company.Status
            Select Case Company.PolicyProvider
                Case "No Cover"
                    oDate = Now.AddMonths(6)
                    Company.Status = "ColdCall"
                    Company.Notes = ""
                    Company.AgentID = 0
                    afrm.cmbExpires.Text = "Jan 1900"
                Case Else
                    'set up a reschedule for 2 months before the renewal date
                    oDate = DateAdd(DateInterval.Month, -2, CDate("1 " & afrm.cmbExpires.Text))
                    Company.Status = "CallBack"
                    Company.TPSUntil = oDate.AddYears(3) ' add three years for existing relationship
                    Using ufrm As New frmSelectUser
                        If ufrm.ShowDialog = DialogResult.OK And ufrm.lvAll.SelectedItems.Count > 0 Then
                            Company.AgentID = ufrm.lvAll.SelectedItems(0).Text
                            Company.Agent.Load(Company.AgentID)
                        End If
                    End Using
            End Select
            Company.PolicyExpires = afrm.cmbExpiresDay.Text & " " & afrm.cmbExpires.Text
            Company.CallBackOn(oDate)
            If afrm.cboProvider.Text = "Other" Then
                Company.PolicyProvider = afrm.txtOther.Text
            Else
                Company.PolicyProvider = afrm.cboProvider.Text
            End If
            Dim App As cManagerApp = cManagerApp.GetInstance()
            App.AddManagerNote(String.Format("Company Returned from {4}, Provider set to : {0}  Renewal set to : {1}  Holduntil set to : {2} and allocated to user : {3}", Company.PolicyProvider, Company.PolicyExpires.ToLongDateString, Company.HoldUntil.ToLongDateString, Company.AgentID, originalStatus), Company.ID, 0)

            Company.Save()
            Company.HideHistory()
        End If
        Me.Close()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        Company.Status = "Sale"
        Company.Save()
        Dim App As cManagerApp = cManagerApp.GetInstance()
        App.AddManagerNote("Company set to Sale", Company.ID, 0)

        Close()
    End Sub

    Private Sub TransferToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles TransferToolStripMenuItem.Click
        Company.Status = "Transfer"
        Company.Save()
        Dim App As cManagerApp = cManagerApp.GetInstance()
        App.AddManagerNote("Company set to Transfer", Company.ID, 0)
        Close()
    End Sub

    Private Sub ImportHistoryToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ImportHistoryToolStripMenuItem.Click
        Using afrm As New frmImportHistory With {.ImportTable = Company.ImportHistory}
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub cmbEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployees.SelectedIndexChanged
        Company.Employees = cmbEmployees.Text
        Company.Save()
    End Sub

    Private Sub cboLegalEntity_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLegalEntity.SelectedValueChanged
        If Not isloading Then
            If Company Is Nothing = False Then
                Company.LegalEntity = cboLegalEntity.SelectedValue
                Company.Save()
                ShowHideConsent()
            End If
        End If
    End Sub
    Private Sub btnSetConsent_Click(sender As Object, e As EventArgs) Handles btnSetConsent.Click
        Using frm As New frmGetConsent()
            Select Case frm.ShowDialog()
                Case DialogResult.Yes
                    Company.ConsentGivenBy = frm.txtName.Text
                    Company.ConsentGivenByPosition = frm.txtContactPosition.Text
                    Company.ConsentGivenByDate = frm.GivenDate.Value
                    Company.ConsentUntil = frm.GivenDate.Value.AddYears(2)
                    Company.ConsentRefused = False
                    Company.ConsentCollectedBy = cManagerApp.GetInstance().CurrentUser.RealName
                    Company.Save()
                    refreshForm()
                Case DialogResult.No
                    Company.ConsentGivenBy = frm.txtName.Text
                    Company.ConsentGivenByPosition = frm.txtContactPosition.Text
                    Company.ConsentGivenByDate = frm.GivenDate.Value
                    Company.ConsentUntil = frm.GivenDate.Value
                    Company.ConsentRefused = True
                    Company.ConsentCollectedBy = cManagerApp.GetInstance().CurrentUser.RealName
                    Company.Save()
                    refreshForm()
                Case Else
            End Select

        End Using
    End Sub


    Private Sub ShowHideConsent()
        'If Company.LegalEntity > 0 And Company.LegalEntity < 4 Then
        '    ' hide 
        '    ShowConsent(False)
        'Else
        '    'show
        '    ShowConsent(True)
        'End If

    End Sub

    Public Sub ShowConsent(value As Boolean)
        lblConsentDate.Visible = value
        lblConsentGivenBy.Visible = value
        lblConsentPosition.Visible = value
        lblConsentUntil.Visible = value
        lblconsentt1.Visible = value
        lblconsentt2.Visible = value
        lblconsentt3.Visible = value
        lblconsentt4.Visible = value
        btnSetConsent.Visible = value
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        Using afrm As New frmDocuments
            afrm.LoadDocs(Company.ID)
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub btnChangeGroupCompany_Click(sender As Object, e As EventArgs) Handles btnChangeGroupCompany.Click
        Using afrm As New frmChangeGroupCompany(Company.GroupCompanyID)
            If afrm.ShowDialog() = DialogResult.OK Then
                Company.GroupCompanyID = DirectCast(afrm.cbGroupCompany.SelectedItem, Common.cSimpleItem).Value
                Company.Save()
                lblGroupCompany.Text = Company.GroupCompany
            End If
        End Using

    End Sub
End Class