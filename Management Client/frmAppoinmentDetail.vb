
Public Class frmAppoinmentDetail

    Private iAppointmentID As Integer
    Dim Appointment As Common.cAppointment = New Common.cAppointment
    Dim DSStatus As DataSet
    Dim isLoading As Boolean = True


    Public Sub New(ByVal AppointmentID As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iAppointmentID = AppointmentID
        Appointment.load(AppointmentID)

        loadStatuscombo()
        loadCoverTypescombo()

    End Sub
    'Private Sub btnOK_Click(ByVal  As Object, ByVal e As EventArgs)
    '    DialogResult = DialogResult.OK
    'End Sub

    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs)
    '    DialogResult = DialogResult.Cancel
    'End Sub

    Private Sub loadCoverTypescombo()
        Dim l As New List(Of Common.cSimpleItem)
        l.Add(New Common.cSimpleItem(0, ""))
        l.Add(New Common.cSimpleItem(1, "PMI"))
        l.Add(New Common.cSimpleItem(2, "Life"))
        l.Add(New Common.cSimpleItem(3, "Both"))
        cboCoverRequired.DataSource = l
        cboCoverRequired.DisplayMember = "Title"
        cboCoverRequired.ValueMember = "Value"
    End Sub

    Private Sub frmAppoinmentDetail_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        panelEmail.Top = (ClientRectangle.Height - panelEmail.Height) / 2
        panelEmail.Left = (ClientRectangle.Width - panelEmail.Width) / 2

        RefreshForm()
        CheckOk()
        isLoading = False
    End Sub

    Private Sub RefreshForm()
        isLoading = True
        With Appointment.TheCompany

            txtCompanyName.Text = .CompanyName
            cmbTitle.Text = .ContactTitle
            txtContactForeName.Text = .ContactForename
            txtContactSurname.Text = .ContactSurname
            txtContactPosition.Text = .ContactPosition
            txtAddress1.Text = .Address1
            txtAddress2.Text = .Address2
            txtAddress3.Text = .Address3
            txtTown.Text = .Town
            txtCounty.Text = .County
            txtPostcode.Text = .Postcode
            txtFax.Text = .Fax
            txtTel.Text = .Telephone
            txtEmail.Text = .Email
            txtNotes.Text = .Notes
            TxtProvider.Text = .PolicyProvider
            txtRenewal.Text = .PolicyExpiresFormatted
            txtRep.Text = .Rep.RealName
            txtArea.Text = Common.StringManipulation.TitleCase(.Area)
            txtEmployees.Text = .Employees
        End With
        lblAppointmentTime.Text = Appointment.AppointmentDate & " " & Appointment.AppointmentTime & " in the diary of " & Appointment.Rep.RealName
        TxtAgent.Text = Appointment.theAgent.RealName
        cmbStatus.Text = Appointment.Status

        cboCoverRequired.SelectedValue = Appointment.CoverRequired

        txtFeedback.Text = Appointment.Feedback
        txtConclusion.Text = Appointment.Conclusion

        If Appointment.FBAppSat Then
            txtAppSat.Text = "Yes"
        Else
            txtAppSat.Text = "No"
        End If

        txtReason.Text = Appointment.FBReasonNotSat
        txtNote.Text = Appointment.FBNote
        If Appointment.FBAppSat Then
            If Appointment.FBInvolvedinPMI Then
                txtPMI.Text = "Yes"
            Else
                txtPMI.Text = "No"
            End If
        Else
            txtPMI.Text = ""
        End If
        Select Case Appointment.WasInsured
            Case 1
                cboWasInsured.Text = "Insured"
            Case 2
                cboWasInsured.Text = "No Cover"
            Case Else
                cboWasInsured.Text = ""
        End Select

        txtfbContact.Text = Appointment.FBContactName
        txtfbposition.Text = Appointment.FBContactPositon
        txtfbProvider.Text = Appointment.FBProvider
        txtfbRenewal.Text = Appointment.FBRenewal
        txtType.Text = Appointment.FBSaleType
        txtSold.Text = Appointment.FBSoldDate
        txtStartDate.Text = Appointment.FBStartDate
        txtValue.Text = Appointment.FBValue
        txtOutcome.Text = Appointment.FBOutCome

        txtPMINextContact.Text = Appointment.NextContact
        txtPreviousProvider.Text = Appointment.PreviousProvider
        txtReasonNotPresented.Text = Appointment.PMINotPresented


        txtLifeOutcome.Text = Appointment.LifeOutCome
        txtLifeNextContact.Text = Appointment.LifeNextContact
        txtLifeReasonNotPresented.Text = Appointment.LifeNotPresented
        txtLifeValue.Text = Appointment.LifeValue
        txtLifeSoldDate.Text = Appointment.LifeSoldDate
        txtLifeStartDate.Text = Appointment.LifeStartDate

        If Appointment.CSCompleted > 0 Then
            If Appointment.CSSent <> Nothing Then
                txtCSSent.Text = Appointment.CSSent.ToLongDateString
            End If
            txtPunctual.Text = Appointment.CSPunctual.ToString()
            txtProfessional.Text = Appointment.CSProfessional.ToString()
            txtCalledBefore.Text = Appointment.CSCalledBefore.ToString()
            txtQuotedInMeeting.Text = Appointment.CSQuotedInMeeting.ToString()
            txtQuoteMethod.Text = Appointment.CSQuoteMethod.ToString()
            txtQuoteInfo.Text = Appointment.CSQuoteInfo.ToString()
            txtComments.Text = Appointment.CSComments()
            If Appointment.CSCompleted <> Nothing Then
                txtCSCompleted.Text = Appointment.CSCompletedDate.ToLongDateString
            End If
            tabSurvey.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            tabSurvey.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        If Trim(Appointment.Confirmed) = "" Then
            btnConfirm.Visible = True
            txtConfirmed.Text = Appointment.Confirmed
        Else
            btnConfirm.Visible = False
            txtConfirmed.Text = Appointment.Confirmed
        End If

        If Appointment.Status = "Cancelled" Then
            BtnMakeLive.Visible = True
            lcbtnMakeLive.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            BtnMakeLive.Visible = False
            lcbtnMakeLive.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        RefreshHistory()
        CheckOk()
        isLoading = False
    End Sub
    Private Sub RefreshHistory()
        Dim AppHistDS As DataSet
        Dim dataobj As New Common.DataLayer
        AppHistDS = dataobj.ExecuteSQL("SELECT  Users.RealName, AppointmentHistory.Note, AppointmentHistory.Added, AppointmentHistory.ID FROM AppointmentHistory INNER JOIN  Users ON AppointmentHistory.UserID = Users.ID WHERE (AppointmentHistory.AppID = " & Appointment.ID & ") Order by Added Desc")
        LVHistory.Items.Clear()
        Dim LVitem As ListViewItem
        For Each DR As DataRow In AppHistDS.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("ID")
            LVitem.SubItems.Add(DR("Realname"))
            LVitem.SubItems.Add(DR("Note"))
            LVitem.SubItems.Add(DR("Added"))
            Me.LVHistory.Items.Add(LVitem)
        Next

        Dim cw As Integer = 0
        cw = CInt(LVHistory.ClientSize.Width / 5)
        LVHistory.Columns(0).Width = 0
        LVHistory.Columns(1).Width = cw
        LVHistory.Columns(2).Width = cw * 3
        LVHistory.Columns(3).Width = cw - 2
    End Sub

    Private Sub BtnRepFax_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRepFax.Click
        If Appointment.TheCompany.Rep.Fax.Trim <> "" Then
            lblmessage.Text = "Sending Fax"
            panelEmail.Visible = True
            Application.DoEvents()
            '  Appointment.Fax(Appointment.Rep.Fax)

            panelEmail.Visible = False
        Else
            MsgBox(Appointment.Rep.RealName & " does not not have a fax number")
        End If
        AddNote("Rep Faxed")

    End Sub

    Private Sub BtnRepEmail_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRepEmail.Click
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        lblmessage.Text = "Sending Email"
        panelEmail.Visible = True
        Appointment.EmailRep(Appointment.Rep.Email, oApp.CurrentUser.Email)
        panelEmail.Visible = False
        AddNote("Rep Emailed")

    End Sub



    Private Sub BtnCustomerPrint_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCustomerPrint.Click
        Appointment.Print(Common.cAppointment.Styles.PickPrinter)
    End Sub

    Private Sub BtnCustomerEmail_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCustomerEmail.Click
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        lblmessage.Text = "Sending Email"
        panelEmail.Visible = True
        Appointment.Email(Appointment.TheCompany.Email, oApp.CurrentUser.Email)
        panelEmail.Visible = False
        AddNote("Customer Emailed")

    End Sub

    Private Sub btnCustomerFax_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCustomerFax.Click
        If Appointment.TheCompany.Fax.Trim <> "" Then
            lblmessage.Text = "Sending Fax"
            panelEmail.Visible = True
            Application.DoEvents()
            '  Appointment.Fax(Appointment.TheCompany.Fax)
            panelEmail.Visible = False
        Else
            MsgBox(Appointment.TheCompany.CompanyName & " does not not have a fax number")
        End If
        AddNote("Customer Faxed")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub txtContactPosition_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactPosition.Leave
        With Appointment.TheCompany
            .ContactPosition = txtContactPosition.Text
            .Save()
            txtContactPosition.Text = .ContactPosition
        End With
        CheckOk()
    End Sub


    Private Sub txtContactForeName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactForeName.Leave
        With Appointment.TheCompany
            .ContactForename = txtContactForeName.Text
            .Save()
            txtContactForeName.Text = .ContactForename
        End With
        CheckOk()
    End Sub

    Private Sub txtContactSurname_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactSurname.Leave
        With Appointment.TheCompany
            .ContactSurname = Me.txtContactSurname.Text
            .Save()
            Me.txtContactSurname.Text = .ContactSurname
        End With
        CheckOk()
    End Sub

    Private Sub txtTel_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTel.Leave
        'With ThisCall.Company
        '    .Telephone = Me.txtTel.Text
        '    .Save()
        'End With
    End Sub

    Private Sub txtFax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFax.Leave
        With Appointment.TheCompany
            .Fax = Me.txtFax.Text
            .Save()
        End With
        CheckOk()
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmail.Leave
        With Appointment.TheCompany
            .Email = txtEmail.Text.ToLower
            .Save()
            txtEmail.Text = .Email
        End With
        CheckOk()
    End Sub

    Private Sub txtCompanyName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCompanyName.Leave
        With Appointment.TheCompany
            .CompanyName = txtCompanyName.Text
            .Save()
            txtCompanyName.Text = .CompanyName
        End With
        CheckOk()
    End Sub

    Private Sub txtAddress1_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress1.Leave
        With Appointment.TheCompany
            .Address1 = txtAddress1.Text
            .Save()
        End With
        CheckOk()
    End Sub
    Private Sub txtAddress2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress2.Leave
        With Appointment.TheCompany
            .Address2 = txtAddress2.Text
            .Save()
        End With
        CheckOk()
    End Sub

    Private Sub txtTown_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTown.Leave
        With Appointment.TheCompany
            .Town = txtTown.Text
            .Save()
        End With
        CheckOk()
    End Sub

    Private Sub txtCounty_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCounty.Leave
        With Appointment.TheCompany
            .County = txtCounty.Text
            .Save()
        End With
        CheckOk()
    End Sub

    Private Sub CheckOk()
        If isLoading Then
            Exit Sub
        End If
        Dim OKtoSave As Boolean = True
        OKtoSave = True
        If cmbTitle.Text = "" Then
            OKtoSave = False
            cmbTitle.BackColor = Color.LightCoral
            cmbTitle.Text = ""
        Else
            cmbTitle.BackColor = Color.White
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


        With Appointment.TheCompany
            If .Fax.Trim <> "" Then
                btnCustomerFax.Enabled = True
            Else
                btnCustomerFax.Enabled = False
            End If
            If .Email.Trim <> "" Then
                BtnCustomerEmail.Enabled = True
            Else
                BtnCustomerEmail.Enabled = False
            End If
            If .Telephone.Trim = "" Then
                BtnCallCust.Enabled = False
            Else
                BtnCallCust.Enabled = True
            End If
        End With
        With Appointment
            If .Rep.Fax.Trim <> "" Then
                BtnRepFax.Enabled = True
            Else
                BtnRepFax.Enabled = False
            End If
            If .Rep.Email.Trim <> "" Then
                BtnRepEmail.Enabled = True
            Else
                BtnRepEmail.Enabled = False
            End If

            If .Rep.Tel.Trim = "" Then
                BtnCallRep.Enabled = False
            Else
                BtnCallRep.Enabled = True
            End If

        End With



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
        With Appointment.TheCompany
            .ContactTitle = cmbTitle.Text
            .Save()
        End With
    End Sub

    Private Sub txtNotes_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtNotes.Leave
        With Appointment.TheCompany
            .Notes = txtNotes.Text
            .Save()
        End With
    End Sub


    Private Sub AddCancelledHistory(Type As String, Status As String)
        Dim params As New Collection
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@UserID", SqlDbType.Int, oApp.CurrentUser.ID)
            .CreateParameter(params, "@AppID", SqlDbType.Int, Appointment.ID)
            .CreateParameter(params, "@Type", SqlDbType.NVarChar, Type)
            If Type = "In" Then
                .CreateParameter(params, "@StartStatus", SqlDbType.NChar, Status)
                .CreateParameter(params, "@EndStatus", SqlDbType.NChar, "Cancelled")
            Else
                .CreateParameter(params, "@StartStatus", SqlDbType.NChar, "Cancelled")
                .CreateParameter(params, "@EndStatus", SqlDbType.NChar, Status)
            End If

            Try
                .ExecuteSPNoQuery("spCreateCancelledHistory", params)
            Catch ex As Exception
                MsgBox("spCreateCancelledHistory - " & ex.Message)
            End Try
        End With
        RefreshHistory()
    End Sub


    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If Not isLoading Then
            'Dim Database As New CADNet.CallQueues.Common.DataLayer
            'Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
            'AddUserNote("Status Changed to " & cmbStatus.SelectedItem("Title"), Now)
            If cmbStatus.SelectedItem("ID") < 0 Or cmbStatus.SelectedItem("ID") > 2 Then
                If cboWasInsured.Text = "" Then
                    MsgBox("Please fill in the was insured box before moving to this status")
                    isLoading = True
                    cmbStatus.Text = Appointment.Status
                    isLoading = False
                    Exit Sub
                End If
            End If

            Select Case cmbStatus.SelectedItem("ID")
                Case 0
                    ' cancelled
                    Dim Database As New CADNet.CallQueues.Common.DataLayer
                    Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
                    AddUserNote("Status Changed to " & cmbStatus.SelectedItem("Title"), Now)
                    AddCancelledHistory("In", Appointment.Status)

                Case 1
                    ' unapproved
                    Dim Database As New CADNet.CallQueues.Common.DataLayer

                    Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
                    AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))

                Case 2
                    Dim Database As New CADNet.CallQueues.Common.DataLayer
                    Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
                    AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))
                    'Approved
                Case 3
                    Dim Database As New CADNet.CallQueues.Common.DataLayer
                    Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
                    AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))
                    ' Pending
                Case 4
                    'Sale


                    'need to get policy start date and the create callback for 1 year 10 months into the future and store the sales details 

                    Dim afrm As New FrmAddSale
                    If afrm.ShowDialog() = DialogResult.OK Then
                        Dim Database As New CADNet.CallQueues.Common.DataLayer

                        Dim ssql As String = ""
                        ssql = String.Format("UPDATE  DiaryItems   SET Status = {0}, soldDate = '{1}', PolicyStarts = '{2}', PolicyType = '{3}', PolicyValue = {4} WHERE ID = {5}", cmbStatus.SelectedItem("ID"), afrm.DTSale.Value.ToLongDateString, afrm.DTPolicy.Value.ToLongDateString, afrm.cboType.Text, CDbl(afrm.txtValue.Text), Appointment.ID)
                        Database.ExecuteSQL(ssql)
                        AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))

                        Appointment.TheCompany.Status = "Sale"
                        Dim odate As DateTime = afrm.DTPolicy.Value.AddDays(0 - (afrm.DTPolicy.Value.Day - 1)).AddMonths(22)
                        Appointment.TheCompany.CallBackOn(odate)
                        Appointment.TheCompany.TPSUntil = odate.AddMonths(2)
                        Appointment.TheCompany.PolicyProvider = afrm.cboProvider.Text
                        Appointment.TheCompany.PolicyExpires = afrm.DTPolicy.Value.AddYears(1)
                        Appointment.TheCompany.Save()

                    Else
                        isLoading = True
                        cmbStatus.Text = Appointment.Status
                        isLoading = False
                    End If

                Case 8
                    'Agency transfer

                    Dim Database As New CADNet.CallQueues.Common.DataLayer
                    Dim ssql As String = String.Format("UPDATE  DiaryItems SET Status = 8 , soldDate = '{0}' WHERE ID = {1}", Now.ToLongDateString, Appointment.ID)
                    Database.ExecuteSQL(ssql)

                    AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))

                    Appointment.TheCompany.Status = "Transfer"
                    Appointment.TheCompany.PolicyProvider = "Vitality"
                    Appointment.TheCompany.Save()


                Case 5, 6, 7, -1, -2, -3, -4, -5
                    ' medical - inactive rep - toExpensive - staying put 
                    Dim afrm As New frmCheckProviderManager(Appointment.TheCompany)
                    If afrm.ShowDialog() = DialogResult.OK Then
                        Dim Database As New CADNet.CallQueues.Common.DataLayer
                        Database.ExecuteSQL("UPDATE  DiaryItems   SET  Status = " & cmbStatus.SelectedItem("ID") & " WHERE ID = " & Appointment.ID)
                        AddNote("Status Changed to " & cmbStatus.SelectedItem("Title"))


                        Appointment.TheCompany.PolicyProvider = afrm.cboProvider.Text
                        ' create callback as per renewal date rules
                        Dim oDate As Date
                        Select Case Appointment.TheCompany.PolicyProvider
                            Case "No Cover"
                                oDate = Now.AddMonths(8)
                                Appointment.TheCompany.Status = "ColdCall"
                                Appointment.TheCompany.Notes = ""
                                Appointment.TheCompany.AgentID = 0
                                afrm.cmbExpires.Text = "Jan 1900"
                            Case Else

                                'set up a reschedule for 2 months before the renewal date
                                oDate = DateAdd(DateInterval.Month, -2, CDate("10 " & afrm.cmbExpires.Text))
                                ' set tps  tp policy renewal date 
                                Appointment.TheCompany.TPSUntil = CDate("10 " & afrm.cmbExpires.Text).AddMonths(2)
                                Appointment.TheCompany.Status = "CallBack"

                        End Select
                        Appointment.TheCompany.PolicyExpires = afrm.cmbExpiresDay.Text & " " & afrm.cmbExpires.Text
                        Appointment.TheCompany.CallBackOn(oDate)
                        If afrm.cboProvider.Text = "Other" Then
                            Appointment.TheCompany.PolicyProvider = afrm.txtOther.Text
                        Else
                            Appointment.TheCompany.PolicyProvider = afrm.cboProvider.Text
                        End If
                        Appointment.TheCompany.Save()
                        If Appointment.Status = "Cancelled" And cmbStatus.SelectedItem("ID") <> 0 Then
                            AddCancelledHistory("Out", cmbStatus.SelectedItem("Title"))
                        End If
                    Else
                        isLoading = True
                        cmbStatus.Text = Appointment.Status
                        isLoading = False
                    End If

                Case Else
                    MsgBox("Opps whats going on here then  status set to - & " & cmbStatus.SelectedItem("Title"))
            End Select
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCallRep.Click

        Try
            Dim aDialer = New Common.cDialer

            Application.DoEvents()
            aDialer.NumberToDial = Appointment.TheCompany.Rep.Tel
            aDialer.Dial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCallCust.Click

        Try
            Dim aDialer As New Common.cDialer
            Application.DoEvents()
            aDialer.NumberToDial = Appointment.TheCompany.Telephone
            aDialer.Dial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frmAddnote As New FrmAddAppointmentNote(Appointment.Status)
        If frmAddnote.ShowDialog = DialogResult.OK Then
            ' save note 
            If Appointment.Status = "Cancelled" Then
                AddUserNote(frmAddnote.txtNote.Text, CDate(frmAddnote.DTP.Value.ToLongDateString & " " & frmAddnote.cboTime.Text))
            Else
                AddNote(frmAddnote.txtNote.Text)
            End If
        End If
    End Sub
    Private Sub AddUserNote(ByVal Note As String, ByVal nextcall As DateTime)
        Dim params As New Collection
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@UserID", SqlDbType.Int, oApp.CurrentUser.ID)
            .CreateParameter(params, "@AppID", SqlDbType.Int, Appointment.ID)
            .CreateParameter(params, "@Note", SqlDbType.NVarChar, Note & " - Call Back " & nextcall.ToLongDateString & " " & nextcall.ToShortTimeString)
            .CreateParameter(params, "@NextCall", SqlDbType.DateTime, nextcall)
            Try
                .ExecuteSPNoQuery("spCreateAppUserNote", params)
            Catch ex As Exception
                MsgBox("spCreateAppNote - " & ex.Message)
            End Try
        End With
        RefreshHistory()
    End Sub
    Private Sub AddNote(ByVal Note As String)
        Dim params As New Collection
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(params, "@UserID", SqlDbType.Int, oApp.CurrentUser.ID)
            .CreateParameter(params, "@AppID", SqlDbType.Int, Appointment.ID)
            .CreateParameter(params, "@Note", SqlDbType.NVarChar, Note)
            Try
                .ExecuteSPNoQuery("spCreateAppNote", params)
            Catch ex As Exception
                MsgBox("spCreateAppNote - " & ex.Message)
            End Try
        End With
        RefreshHistory()
    End Sub
    Private Sub TxtProvider_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtProvider.Leave
        If TxtProvider.Text <> Appointment.TheCompany.PolicyProvider Then
            Appointment.TheCompany.PolicyProvider = TxtProvider.Text
            Appointment.TheCompany.Save()
        End If
    End Sub

    Private Sub loadStatuscombo()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        If Appointment.Status = "Cancelled" Then
            DSStatus = Database.ExecuteSQL("SELECT ID, Title  FROM  DiaryItemStatus where ID<1 ORDER BY DisplayOrder")
        Else
            DSStatus = Database.ExecuteSQL("SELECT ID, Title  FROM DiaryItemStatus ORDER BY DisplayOrder")
        End If


        cmbStatus.DataSource = DSStatus.Tables(0)
        cmbStatus.DisplayMember = "Title"
        cmbStatus.ValueMember = "ID"
    End Sub

    Private Sub BtnMakeLive_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnMakeLive.Click
        Dim frmDiary As New frmDiaryDialog(Appointment.TheCompany.Rep)
        If frmDiary.ShowDialog() = DialogResult.OK Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL("UPDATE  DiaryItems   SET FeedbackStatus='', UserID=" & Appointment.TheCompany.Rep.ID & ", Status = 1, itemPeriod=" & frmDiary.Period & ", itemDate='" & frmDiary.AppointmentDateTime & "'  WHERE ID = " & Appointment.ID)
            AddNote("Revived from the Dead")


            Appointment.load(Appointment.ID)
            AddCancelledHistory("Out", Appointment.Status)

            loadStatuscombo()


            RefreshForm()
        End If
    End Sub

    Private Sub txtNotes_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub txtFeedback_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFeedback.Leave
        If txtFeedback.Text <> Appointment.Feedback Then
            ' need to save it 
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL("UPDATE  DiaryItems   SET FeedbackStatus='" & txtFeedback.Text & "'  WHERE ID = " & Appointment.ID)
            AddNote("Feedback added - " & txtFeedback.Text)
            Appointment.load(Appointment.ID)
            RefreshForm()

        End If
    End Sub

    Private Sub txtFeedback_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtFeedback.TextChanged

    End Sub

    Private Sub txtConclusion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtConclusion.Leave
        If txtConclusion.Text <> Appointment.Conclusion Then
            ' need to save it 
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL("UPDATE  DiaryItems   SET Conclusion='" & txtConclusion.Text & "'  WHERE ID = " & Appointment.ID)
            AddNote("Conclusion added - " & txtConclusion.Text)
            Appointment.load(Appointment.ID)
            RefreshForm()
        End If
    End Sub



    Private Sub MoveToToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles MoveToToolStripMenuItem.DropDownOpening
        Dim Ds As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Ds = Database.ExecuteSQL("Select * from Users where Status=2 and userLevelID = 4 order by realname")

        MoveToToolStripMenuItem.DropDownItems.Clear()
        For Each DR As DataRow In Ds.Tables(0).Rows
            Dim windowNewMenu As New ToolStripMenuItem(Common.TitleCase(DR("RealName")), Nothing, New EventHandler(AddressOf Repclick))
            windowNewMenu.Tag = DR("ID")
            MoveToToolStripMenuItem.DropDownItems.Add(windowNewMenu)
        Next
    End Sub
    Private Sub Repclick(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim s As ToolStripMenuItem = sender
        Dim Rep As New Common.cUser
        Rep.Load(s.Tag)
        Dim frmDiary As New frmDiaryDialog(Rep)
        If frmDiary.ShowDialog() = DialogResult.OK Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL("UPDATE  DiaryItems   SET UserID=" & Rep.ID & ", Status = 1, itemPeriod=" & frmDiary.Period & ", itemDate='" & frmDiary.AppointmentDateTime & "'  WHERE ID = " & Appointment.ID)
            AddNote($"Changed Rep to {Rep.RealName}")
            Appointment.load(Appointment.ID)
            AddCancelledHistory("Out", Appointment.Status)
            RefreshForm()
        End If

    End Sub

    Private Sub btnChangeAddress_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnChangeAddress.Click

        Dim iPrevArea As Integer = Appointment.TheCompany.AreaID

        Dim aFrm As New frmChangeAddress(Appointment.TheCompany)
        aFrm.txtPostcode.Text = Me.txtPostcode.Text
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR = DialogResult.Cancel Then
            Exit Sub
        End If

        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        'reload the company
        Appointment.TheCompany.Refresh()

        If aFrm.InArea = False Then
            'the postcode supplied by the user is Out of Area, move the script to that page

            MessageBox.Show("That postcode is out of area.")
            Exit Sub
            'Me.Enabled = False
            'oScript.EndState(ScriptEngine.States.MakeAppointment, ScriptEngine.States.OutofArea)
            'frmAgent.SplitContainer1.Panel2Collapsed = False
            'frmAgent.SplitContainer2.Panel2Collapsed = False
            'Me.Cursor = Cursors.Default
            'Exit Sub
        End If

        Dim frmPostcode As frmGetPostcode = New frmGetPostcode(Appointment.TheCompany.Postcode, Me)
        ' test post code  is wr2 6nj

        Select Case frmPostcode.ShowDialog()
            Case DialogResult.OK
                If frmPostcode.SelectedAddress.CompanyName <> "" Then
                    txtCompanyName.Text = frmPostcode.SelectedAddress.CompanyName
                End If

                txtAddress1.Text = frmPostcode.SelectedAddress.Address1
                txtAddress2.Text = frmPostcode.SelectedAddress.Address2
                ' txtAddress3.Text = frmPostcode.SelectedAddress.Address3
                txtTown.Text = frmPostcode.SelectedAddress.Town
                txtCounty.Text = frmPostcode.SelectedAddress.County

                ' update company class and save 
                With Appointment.TheCompany
                    .CompanyName = Me.txtCompanyName.Text
                    .Address1 = Me.txtAddress1.Text
                    .Address2 = Me.txtAddress2.Text
                    .Address3 = Me.txtAddress3.Text
                    .Town = Me.txtTown.Text
                    .County = Me.txtCounty.Text
                    .Save()
                End With
                AddNote("Address Changed by Manager")
        End Select



        If Appointment.TheCompany.AreaID <> iPrevArea Then
            'MessageBox.Show("Area changed")

            'find the correct rep for the new area
            Dim DB As New CallQueues.Common.DataLayer
            Dim DS As DataSet = DB.ExecuteSQL("SELECT RepID FROM Areas WHERE ID=" & Appointment.TheCompany.AreaID)
            Dim Rep As New Common.cUser
            Rep.Load(DS.Tables(0).Rows(0).Item("RepID"))
            Dim frmDiary As New frmDiaryDialog(Rep)
            frmDiary.ShowDialog()
            DB.ExecuteSQL("UPDATE  DiaryItems   SET UserID=" & Rep.ID & ", Status = 1, itemPeriod=" & frmDiary.Period & ", itemDate='" & frmDiary.AppointmentDateTime & "'  WHERE ID = " & Appointment.ID)
            AddNote("Address Changed caused Area change.")

        End If

        'reload the appointment
        Appointment.load(Appointment.ID)

        'refresh the view
        RefreshForm()

        Me.Cursor = Cursors.Default

    End Sub




    Private Sub ChangeProviderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ChangeProviderToolStripMenuItem.Click
        Dim afrm As New frmCheckProviderManager(Appointment.TheCompany)
        If afrm.ShowDialog() = DialogResult.OK Then

            Appointment.TheCompany.PolicyExpires = afrm.cmbExpiresDay.Text & " " & afrm.cmbExpires.Text
            If afrm.cboProvider.Text = "Other" Then
                Appointment.TheCompany.PolicyProvider = afrm.txtOther.Text
            Else
                Appointment.TheCompany.PolicyProvider = afrm.cboProvider.Text
            End If
            Appointment.TheCompany.Save()
        End If
        RefreshForm()
    End Sub



    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConfirm.Click
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        Appointment.SetConfirmed(oApp.CurrentUser.RealName)
        RefreshForm()

    End Sub

    Private Sub ShowCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ShowCompanyToolStripMenuItem.Click
        Using afrm As New frmShowCompany(Appointment.TheCompany.ID)
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub cboWasInsured_SelectedIndexChanged(sender As System.Object, e As EventArgs) Handles cboWasInsured.SelectedIndexChanged

        Dim val As Integer
        Select Case cboWasInsured.Text
            Case "Insured"
                val = 1
            Case "No Cover"
                val = 2
            Case Else
                val = 0
        End Select
        If val <> Appointment.WasInsured Then
            AddNote("Was Insured Changed to " & cboWasInsured.Text)
            Appointment.setWasInsured(val)
        End If

    End Sub


    Private Sub txtAddress3_Leave(sender As Object, e As EventArgs) Handles txtAddress3.Leave
        With Appointment.TheCompany
            .Address3 = txtAddress3.Text
            .Save()
        End With
    End Sub

    Private Sub cboCoverRequired_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCoverRequired.SelectedIndexChanged
        If isLoading = False Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Dim si As Common.cSimpleItem = cboCoverRequired.SelectedItem
            Database.ExecuteSQL("UPDATE  DiaryItems  SET CoverRequired=" & si.Value & "  WHERE ID = " & Appointment.ID)
            Appointment.CoverRequired = si.Value
            AddNote("Cover Required set to " & si.Title)
        End If

    End Sub

    Private Sub btnSurvey_Click(sender As Object, e As EventArgs) Handles btnSurvey.Click
        Dim oApp As cManagerApp = cManagerApp.GetInstance
        lblmessage.Text = "Sending Email"
        panelEmail.Visible = True
        Appointment.EmailSurvey(Appointment.TheCompany.Email, oApp.CurrentUser.Email)
        panelEmail.Visible = False

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.ExecuteSQL("UPDATE  DiaryItems  SET CSSent='" & Now.ToLongDateString & "'  WHERE ID = " & Appointment.ID)

        AddNote("Customer Survey Emailed")
    End Sub

    Private Sub ListenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenToolStripMenuItem.Click
        cManagerApp.GetInstance().ShowListenerForm(Appointment.TheCompany)


    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        Using afrm As New frmDocuments
            afrm.LoadDocs(Appointment.TheCompany.ID)
            afrm.ShowDialog()
        End Using
    End Sub


End Class