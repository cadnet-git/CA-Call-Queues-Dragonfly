<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowCompany
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblAddress3 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.txtContactPosition = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtContactSurname = New System.Windows.Forms.TextBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.txtContactForeName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelLabel = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPolicyExpiry = New System.Windows.Forms.Label()
        Me.lblPolicyProvider = New System.Windows.Forms.Label()
        Me.lblRepName = New System.Windows.Forms.Label()
        Me.lblAreaLbl = New System.Windows.Forms.Label()
        Me.lblPolExp = New System.Windows.Forms.Label()
        Me.lblPostcodelbl = New System.Windows.Forms.Label()
        Me.lblPolProv = New System.Windows.Forms.Label()
        Me.lblTownTitle = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblCountyTitle = New System.Windows.Forms.Label()
        Me.BtnMakeLive = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnChangeTelephone = New System.Windows.Forms.Button()
        Me.LVAppNotes = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Who = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppointmentNote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddedOn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnKill = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAgentName = New System.Windows.Forms.Label()
        Me.BtnChangeAgent = New System.Windows.Forms.Button()
        Me.BtnBypass = New System.Windows.Forms.Button()
        Me.BtnReturnToDB = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSDM = New System.Windows.Forms.Label()
        Me.cmbEmployees = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSetConsent = New System.Windows.Forms.Button()
        Me.cboLegalEntity = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblconsentt4 = New System.Windows.Forms.Label()
        Me.lblConsentUntil = New System.Windows.Forms.Label()
        Me.lblconsentt3 = New System.Windows.Forms.Label()
        Me.lblconsentt2 = New System.Windows.Forms.Label()
        Me.lblconsentt1 = New System.Windows.Forms.Label()
        Me.lblConsentDate = New System.Windows.Forms.Label()
        Me.lblConsentPosition = New System.Windows.Forms.Label()
        Me.lblConsentGivenBy = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGroupCompany = New System.Windows.Forms.Label()
        Me.btnChangeGroupCompany = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvHistory.GridLines = True
        Me.lvHistory.HideSelection = False
        Me.lvHistory.Location = New System.Drawing.Point(23, 323)
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(900, 164)
        Me.lvHistory.TabIndex = 40
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Agent"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "When"
        Me.ColumnHeader2.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Original State"
        Me.ColumnHeader3.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ending State"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Additional Information"
        Me.ColumnHeader5.Width = 307
        '
        'lblTel
        '
        Me.lblTel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTel.Location = New System.Drawing.Point(71, 135)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(117, 20)
        Me.lblTel.TabIndex = 23
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPostcode
        '
        Me.lblPostcode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostcode.Location = New System.Drawing.Point(315, 184)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(92, 20)
        Me.lblPostcode.TabIndex = 35
        Me.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTitle
        '
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Ms", "Dr", "Rev", "Lord"})
        Me.cmbTitle.Location = New System.Drawing.Point(71, 33)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(59, 21)
        Me.cmbTitle.TabIndex = 1
        '
        'lblCounty
        '
        Me.lblCounty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounty.Location = New System.Drawing.Point(315, 160)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(180, 20)
        Me.lblCounty.TabIndex = 31
        Me.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTown
        '
        Me.lblTown.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTown.Location = New System.Drawing.Point(315, 135)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(180, 20)
        Me.lblTown.TabIndex = 25
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress3
        '
        Me.lblAddress3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress3.Location = New System.Drawing.Point(315, 110)
        Me.lblAddress3.Name = "lblAddress3"
        Me.lblAddress3.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress3.TabIndex = 18
        Me.lblAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress2
        '
        Me.lblAddress2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress2.Location = New System.Drawing.Point(315, 85)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress2.TabIndex = 14
        Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress1
        '
        Me.lblAddress1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress1.Location = New System.Drawing.Point(315, 60)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress1.TabIndex = 9
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Note:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(37, 37)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(30, 13)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Title:"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(70, 234)
        Me.txtNotes.MaxLength = 400
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(853, 42)
        Me.txtNotes.TabIndex = 38
        '
        'lblRep
        '
        Me.lblRep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRep.Location = New System.Drawing.Point(577, 187)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(130, 20)
        Me.lblRep.TabIndex = 22
        Me.lblRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Location = New System.Drawing.Point(70, 109)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(180, 20)
        Me.txtContactPosition.TabIndex = 17
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(315, 34)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(180, 20)
        Me.txtCompanyName.TabIndex = 3
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(20, 112)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 16
        Me.lblPosition.Text = "Position:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(15, 87)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 12
        Me.lblSurname.Text = "Surname:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactSurname
        '
        Me.txtContactSurname.Location = New System.Drawing.Point(70, 85)
        Me.txtContactSurname.Name = "txtContactSurname"
        Me.txtContactSurname.Size = New System.Drawing.Size(180, 20)
        Me.txtContactSurname.TabIndex = 13
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(10, 62)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(57, 13)
        Me.lblForename.TabIndex = 6
        Me.lblForename.Text = "Forename:"
        Me.lblForename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactForeName
        '
        Me.txtContactForeName.Location = New System.Drawing.Point(70, 59)
        Me.txtContactForeName.Name = "txtContactForeName"
        Me.txtContactForeName.Size = New System.Drawing.Size(180, 20)
        Me.txtContactForeName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(70, 185)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 33
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(32, 187)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelLabel
        '
        Me.lblTelLabel.AutoSize = True
        Me.lblTelLabel.Location = New System.Drawing.Point(42, 137)
        Me.lblTelLabel.Name = "lblTelLabel"
        Me.lblTelLabel.Size = New System.Drawing.Size(25, 13)
        Me.lblTelLabel.TabIndex = 20
        Me.lblTelLabel.Text = "Tel:"
        Me.lblTelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(70, 160)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(180, 20)
        Me.txtFax.TabIndex = 29
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(40, 162)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 27
        Me.lblFax.Text = "Fax:"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(577, 210)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(130, 20)
        Me.lblArea.TabIndex = 28
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyExpiry
        '
        Me.lblPolicyExpiry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPolicyExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyExpiry.Location = New System.Drawing.Point(577, 58)
        Me.lblPolicyExpiry.Name = "lblPolicyExpiry"
        Me.lblPolicyExpiry.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyExpiry.TabIndex = 11
        Me.lblPolicyExpiry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyProvider
        '
        Me.lblPolicyProvider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPolicyProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyProvider.Location = New System.Drawing.Point(577, 34)
        Me.lblPolicyProvider.Name = "lblPolicyProvider"
        Me.lblPolicyProvider.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyProvider.TabIndex = 5
        Me.lblPolicyProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRepName
        '
        Me.lblRepName.AutoSize = True
        Me.lblRepName.Location = New System.Drawing.Point(510, 190)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(61, 13)
        Me.lblRepName.TabIndex = 19
        Me.lblRepName.Text = "Rep Name:"
        Me.lblRepName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAreaLbl
        '
        Me.lblAreaLbl.AutoSize = True
        Me.lblAreaLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAreaLbl.Location = New System.Drawing.Point(539, 213)
        Me.lblAreaLbl.Name = "lblAreaLbl"
        Me.lblAreaLbl.Size = New System.Drawing.Size(32, 13)
        Me.lblAreaLbl.TabIndex = 26
        Me.lblAreaLbl.Text = "Area:"
        Me.lblAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPolExp
        '
        Me.lblPolExp.AutoSize = True
        Me.lblPolExp.Location = New System.Drawing.Point(502, 62)
        Me.lblPolExp.Name = "lblPolExp"
        Me.lblPolExp.Size = New System.Drawing.Size(69, 13)
        Me.lblPolExp.TabIndex = 10
        Me.lblPolExp.Text = "Policy Expiry:"
        Me.lblPolExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPostcodelbl
        '
        Me.lblPostcodelbl.AutoSize = True
        Me.lblPostcodelbl.Location = New System.Drawing.Point(259, 187)
        Me.lblPostcodelbl.Name = "lblPostcodelbl"
        Me.lblPostcodelbl.Size = New System.Drawing.Size(55, 13)
        Me.lblPostcodelbl.TabIndex = 34
        Me.lblPostcodelbl.Text = "Postcode:"
        Me.lblPostcodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPolProv
        '
        Me.lblPolProv.AutoSize = True
        Me.lblPolProv.Location = New System.Drawing.Point(522, 37)
        Me.lblPolProv.Name = "lblPolProv"
        Me.lblPolProv.Size = New System.Drawing.Size(49, 13)
        Me.lblPolProv.TabIndex = 4
        Me.lblPolProv.Text = "Provider:"
        Me.lblPolProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTownTitle
        '
        Me.lblTownTitle.AutoSize = True
        Me.lblTownTitle.Location = New System.Drawing.Point(277, 138)
        Me.lblTownTitle.Name = "lblTownTitle"
        Me.lblTownTitle.Size = New System.Drawing.Size(37, 13)
        Me.lblTownTitle.TabIndex = 21
        Me.lblTownTitle.Text = "Town:"
        Me.lblTownTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(266, 60)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(260, 37)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(54, 13)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "Company:"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountyTitle
        '
        Me.lblCountyTitle.AutoSize = True
        Me.lblCountyTitle.Location = New System.Drawing.Point(271, 163)
        Me.lblCountyTitle.Name = "lblCountyTitle"
        Me.lblCountyTitle.Size = New System.Drawing.Size(43, 13)
        Me.lblCountyTitle.TabIndex = 30
        Me.lblCountyTitle.Text = "County:"
        Me.lblCountyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnMakeLive
        '
        Me.BtnMakeLive.BackColor = System.Drawing.Color.White
        Me.BtnMakeLive.Location = New System.Drawing.Point(577, 84)
        Me.BtnMakeLive.Name = "BtnMakeLive"
        Me.BtnMakeLive.Size = New System.Drawing.Size(130, 24)
        Me.BtnMakeLive.TabIndex = 15
        Me.BtnMakeLive.Text = "Change Policy "
        Me.BtnMakeLive.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.close
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(846, 637)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(77, 76)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Close"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnChangeTelephone
        '
        Me.btnChangeTelephone.Location = New System.Drawing.Point(194, 133)
        Me.btnChangeTelephone.Name = "btnChangeTelephone"
        Me.btnChangeTelephone.Size = New System.Drawing.Size(56, 23)
        Me.btnChangeTelephone.TabIndex = 24
        Me.btnChangeTelephone.Text = "Change"
        Me.btnChangeTelephone.UseVisualStyleBackColor = True
        '
        'LVAppNotes
        '
        Me.LVAppNotes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Who, Me.AppointmentNote, Me.AddedOn, Me.Note})
        Me.LVAppNotes.FullRowSelect = True
        Me.LVAppNotes.GridLines = True
        Me.LVAppNotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVAppNotes.HideSelection = False
        Me.LVAppNotes.Location = New System.Drawing.Point(23, 507)
        Me.LVAppNotes.Name = "LVAppNotes"
        Me.LVAppNotes.Size = New System.Drawing.Size(900, 124)
        Me.LVAppNotes.TabIndex = 42
        Me.LVAppNotes.UseCompatibleStateImageBehavior = False
        Me.LVAppNotes.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "Rep"
        Me.ID.Width = 114
        '
        'Who
        '
        Me.Who.Text = "App Date"
        Me.Who.Width = 99
        '
        'AppointmentNote
        '
        Me.AppointmentNote.Text = "Noted By"
        Me.AppointmentNote.Width = 118
        '
        'AddedOn
        '
        Me.AddedOn.Text = "Date"
        Me.AddedOn.Width = 132
        '
        'Note
        '
        Me.Note.Text = "Note"
        Me.Note.Width = 236
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Company History"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Appointment History"
        '
        'BtnKill
        '
        Me.BtnKill.Location = New System.Drawing.Point(23, 665)
        Me.BtnKill.Name = "BtnKill"
        Me.BtnKill.Size = New System.Drawing.Size(75, 23)
        Me.BtnKill.TabIndex = 43
        Me.BtnKill.Text = "Kill Company "
        Me.BtnKill.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 665)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Ban Company "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(533, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Agent:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAgentName
        '
        Me.lblAgentName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAgentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAgentName.Location = New System.Drawing.Point(577, 120)
        Me.lblAgentName.Name = "lblAgentName"
        Me.lblAgentName.Size = New System.Drawing.Size(130, 20)
        Me.lblAgentName.TabIndex = 47
        Me.lblAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnChangeAgent
        '
        Me.BtnChangeAgent.BackColor = System.Drawing.Color.White
        Me.BtnChangeAgent.Location = New System.Drawing.Point(583, 142)
        Me.BtnChangeAgent.Name = "BtnChangeAgent"
        Me.BtnChangeAgent.Size = New System.Drawing.Size(118, 24)
        Me.BtnChangeAgent.TabIndex = 48
        Me.BtnChangeAgent.Text = "Change Agent"
        Me.BtnChangeAgent.UseVisualStyleBackColor = False
        '
        'BtnBypass
        '
        Me.BtnBypass.Location = New System.Drawing.Point(250, 665)
        Me.BtnBypass.Name = "BtnBypass"
        Me.BtnBypass.Size = New System.Drawing.Size(140, 23)
        Me.BtnBypass.TabIndex = 49
        Me.BtnBypass.Text = "Bypass  TPS for 3 Months"
        Me.BtnBypass.UseVisualStyleBackColor = True
        '
        'BtnReturnToDB
        '
        Me.BtnReturnToDB.BackColor = System.Drawing.Color.White
        Me.BtnReturnToDB.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources._Call
        Me.BtnReturnToDB.Location = New System.Drawing.Point(721, 637)
        Me.BtnReturnToDB.Name = "BtnReturnToDB"
        Me.BtnReturnToDB.Size = New System.Drawing.Size(105, 76)
        Me.BtnReturnToDB.TabIndex = 50
        Me.BtnReturnToDB.Text = "Return to Callback"
        Me.BtnReturnToDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReturnToDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReturnToDB.UseVisualStyleBackColor = False
        Me.BtnReturnToDB.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetStatusToolStripMenuItem, Me.ImportHistoryToolStripMenuItem, Me.DocumentsToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'SetStatusToolStripMenuItem
        '
        Me.SetStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.TransferToolStripMenuItem})
        Me.SetStatusToolStripMenuItem.Name = "SetStatusToolStripMenuItem"
        Me.SetStatusToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SetStatusToolStripMenuItem.Text = "Set Status"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'TransferToolStripMenuItem
        '
        Me.TransferToolStripMenuItem.Name = "TransferToolStripMenuItem"
        Me.TransferToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TransferToolStripMenuItem.Text = "Transfer"
        '
        'ImportHistoryToolStripMenuItem
        '
        Me.ImportHistoryToolStripMenuItem.Name = "ImportHistoryToolStripMenuItem"
        Me.ImportHistoryToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ImportHistoryToolStripMenuItem.Text = "Import History"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "SDM:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSDM
        '
        Me.lblSDM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSDM.Location = New System.Drawing.Point(70, 284)
        Me.lblSDM.Name = "lblSDM"
        Me.lblSDM.Size = New System.Drawing.Size(853, 20)
        Me.lblSDM.TabIndex = 53
        Me.lblSDM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEmployees
        '
        Me.cmbEmployees.FormattingEnabled = True
        Me.cmbEmployees.Items.AddRange(New Object() {"", "1-10", "11-25", "26-50", "50-99", "100-250", "250+"})
        Me.cmbEmployees.Location = New System.Drawing.Point(71, 209)
        Me.cmbEmployees.Name = "cmbEmployees"
        Me.cmbEmployees.Size = New System.Drawing.Size(179, 21)
        Me.cmbEmployees.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Employees:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSetConsent
        '
        Me.btnSetConsent.Location = New System.Drawing.Point(799, 185)
        Me.btnSetConsent.Name = "btnSetConsent"
        Me.btnSetConsent.Size = New System.Drawing.Size(129, 33)
        Me.btnSetConsent.TabIndex = 79
        Me.btnSetConsent.Text = "Set Consent"
        Me.btnSetConsent.UseVisualStyleBackColor = True
        '
        'cboLegalEntity
        '
        Me.cboLegalEntity.DisplayMember = "Title"
        Me.cboLegalEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLegalEntity.FormattingEnabled = True
        Me.cboLegalEntity.Location = New System.Drawing.Point(799, 35)
        Me.cboLegalEntity.Name = "cboLegalEntity"
        Me.cboLegalEntity.Size = New System.Drawing.Size(129, 21)
        Me.cboLegalEntity.TabIndex = 78
        Me.cboLegalEntity.ValueMember = "value"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(727, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Legal Entity:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt4
        '
        Me.lblconsentt4.AutoSize = True
        Me.lblconsentt4.Location = New System.Drawing.Point(722, 157)
        Me.lblconsentt4.Name = "lblconsentt4"
        Me.lblconsentt4.Size = New System.Drawing.Size(70, 13)
        Me.lblconsentt4.TabIndex = 76
        Me.lblconsentt4.Text = "Consent Until"
        Me.lblconsentt4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConsentUntil
        '
        Me.lblConsentUntil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentUntil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentUntil.Location = New System.Drawing.Point(798, 155)
        Me.lblConsentUntil.Name = "lblConsentUntil"
        Me.lblConsentUntil.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentUntil.TabIndex = 75
        Me.lblConsentUntil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblconsentt3
        '
        Me.lblconsentt3.AutoSize = True
        Me.lblconsentt3.Location = New System.Drawing.Point(720, 130)
        Me.lblconsentt3.Name = "lblconsentt3"
        Me.lblconsentt3.Size = New System.Drawing.Size(72, 13)
        Me.lblconsentt3.TabIndex = 74
        Me.lblconsentt3.Text = "Consent Date"
        Me.lblconsentt3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt2
        '
        Me.lblconsentt2.AutoSize = True
        Me.lblconsentt2.Location = New System.Drawing.Point(706, 103)
        Me.lblconsentt2.Name = "lblconsentt2"
        Me.lblconsentt2.Size = New System.Drawing.Size(86, 13)
        Me.lblconsentt2.TabIndex = 73
        Me.lblconsentt2.Text = "Consent Position"
        Me.lblconsentt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt1
        '
        Me.lblconsentt1.AutoSize = True
        Me.lblconsentt1.Location = New System.Drawing.Point(732, 78)
        Me.lblconsentt1.Name = "lblconsentt1"
        Me.lblconsentt1.Size = New System.Drawing.Size(60, 13)
        Me.lblconsentt1.TabIndex = 72
        Me.lblconsentt1.Text = "Consent by"
        Me.lblconsentt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConsentDate
        '
        Me.lblConsentDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentDate.Location = New System.Drawing.Point(798, 129)
        Me.lblConsentDate.Name = "lblConsentDate"
        Me.lblConsentDate.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentDate.TabIndex = 71
        Me.lblConsentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConsentPosition
        '
        Me.lblConsentPosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentPosition.Location = New System.Drawing.Point(798, 103)
        Me.lblConsentPosition.Name = "lblConsentPosition"
        Me.lblConsentPosition.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentPosition.TabIndex = 70
        Me.lblConsentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConsentGivenBy
        '
        Me.lblConsentGivenBy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentGivenBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentGivenBy.Location = New System.Drawing.Point(798, 78)
        Me.lblConsentGivenBy.Name = "lblConsentGivenBy"
        Me.lblConsentGivenBy.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentGivenBy.TabIndex = 69
        Me.lblConsentGivenBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(461, 670)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Group Company:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGroupCompany
        '
        Me.lblGroupCompany.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGroupCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGroupCompany.Location = New System.Drawing.Point(553, 667)
        Me.lblGroupCompany.Name = "lblGroupCompany"
        Me.lblGroupCompany.Size = New System.Drawing.Size(92, 20)
        Me.lblGroupCompany.TabIndex = 81
        Me.lblGroupCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChangeGroupCompany
        '
        Me.btnChangeGroupCompany.Location = New System.Drawing.Point(651, 666)
        Me.btnChangeGroupCompany.Name = "btnChangeGroupCompany"
        Me.btnChangeGroupCompany.Size = New System.Drawing.Size(56, 23)
        Me.btnChangeGroupCompany.TabIndex = 82
        Me.btnChangeGroupCompany.Text = "Change"
        Me.btnChangeGroupCompany.UseVisualStyleBackColor = True
        '
        'frmShowCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 725)
        Me.Controls.Add(Me.btnChangeGroupCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGroupCompany)
        Me.Controls.Add(Me.btnSetConsent)
        Me.Controls.Add(Me.cboLegalEntity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblconsentt4)
        Me.Controls.Add(Me.lblConsentUntil)
        Me.Controls.Add(Me.lblconsentt3)
        Me.Controls.Add(Me.lblconsentt2)
        Me.Controls.Add(Me.lblconsentt1)
        Me.Controls.Add(Me.lblConsentDate)
        Me.Controls.Add(Me.lblConsentPosition)
        Me.Controls.Add(Me.lblConsentGivenBy)
        Me.Controls.Add(Me.cmbEmployees)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSDM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnReturnToDB)
        Me.Controls.Add(Me.BtnBypass)
        Me.Controls.Add(Me.BtnChangeAgent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAgentName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnKill)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVAppNotes)
        Me.Controls.Add(Me.btnChangeTelephone)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnMakeLive)
        Me.Controls.Add(Me.lblRepName)
        Me.Controls.Add(Me.lblAreaLbl)
        Me.Controls.Add(Me.lblPolExp)
        Me.Controls.Add(Me.lblPostcodelbl)
        Me.Controls.Add(Me.lblPolProv)
        Me.Controls.Add(Me.lblTownTitle)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblCountyTitle)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.cmbTitle)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblAddress3)
        Me.Controls.Add(Me.lblAddress2)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblRep)
        Me.Controls.Add(Me.txtContactPosition)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtContactSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtContactForeName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelLabel)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPolicyExpiry)
        Me.Controls.Add(Me.lblPolicyProvider)
        Me.Controls.Add(Me.lvHistory)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmShowCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvHistory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress3 As System.Windows.Forms.Label
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblRep As System.Windows.Forms.Label
    Friend WithEvents txtContactPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtContactSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtContactForeName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelLabel As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPolicyExpiry As System.Windows.Forms.Label
    Friend WithEvents lblPolicyProvider As System.Windows.Forms.Label
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents lblAreaLbl As System.Windows.Forms.Label
    Friend WithEvents lblPolExp As System.Windows.Forms.Label
    Friend WithEvents lblPostcodelbl As System.Windows.Forms.Label
    Friend WithEvents lblPolProv As System.Windows.Forms.Label
    Friend WithEvents lblTownTitle As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblCountyTitle As System.Windows.Forms.Label
    Friend WithEvents BtnMakeLive As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnChangeTelephone As System.Windows.Forms.Button
    Friend WithEvents LVAppNotes As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Who As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppointmentNote As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddedOn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Note As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnKill As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAgentName As System.Windows.Forms.Label
    Friend WithEvents BtnChangeAgent As System.Windows.Forms.Button
    Friend WithEvents BtnBypass As System.Windows.Forms.Button
    Friend WithEvents BtnReturnToDB As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSDM As System.Windows.Forms.Label
    Friend WithEvents ImportHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSetConsent As Button
    Friend WithEvents cboLegalEntity As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblconsentt4 As Label
    Friend WithEvents lblConsentUntil As Label
    Friend WithEvents lblconsentt3 As Label
    Friend WithEvents lblconsentt2 As Label
    Friend WithEvents lblconsentt1 As Label
    Friend WithEvents lblConsentDate As Label
    Friend WithEvents lblConsentPosition As Label
    Friend WithEvents lblConsentGivenBy As Label
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGroupCompany As Label
    Friend WithEvents btnChangeGroupCompany As Button
End Class
