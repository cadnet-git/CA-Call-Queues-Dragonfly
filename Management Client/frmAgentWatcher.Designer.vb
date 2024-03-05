<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentWatcher
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtEmail = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.Label
        Me.txtContactPosition = New System.Windows.Forms.Label
        Me.txtContactSurname = New System.Windows.Forms.Label
        Me.txtContactForeName = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.lblPostcode = New System.Windows.Forms.Label
        Me.lblCounty = New System.Windows.Forms.Label
        Me.lblTown = New System.Windows.Forms.Label
        Me.lblAddress3 = New System.Windows.Forms.Label
        Me.lblAddress2 = New System.Windows.Forms.Label
        Me.lblAddress1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltitle = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.lblRep = New System.Windows.Forms.Label
        Me.lblPosition = New System.Windows.Forms.Label
        Me.lblRepName = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblMagicNumber = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.lblAreaLbl = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPolExp = New System.Windows.Forms.Label
        Me.lblTelLabel = New System.Windows.Forms.Label
        Me.lblPostcodelbl = New System.Windows.Forms.Label
        Me.lblPolProv = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.lblPolicyExpiry = New System.Windows.Forms.Label
        Me.lblPolicyProvider = New System.Windows.Forms.Label
        Me.lblTownTitle = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCompanya = New System.Windows.Forms.Label
        Me.lblCountyTitle = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblDialTime = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCalltime = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lvResults = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Company = New System.Windows.Forms.ColumnHeader
        Me.Salutation = New System.Windows.Forms.ColumnHeader
        Me.surname = New System.Windows.Forms.ColumnHeader
        Me.Position = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtStartedCallAt = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(68, 200)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 117
        Me.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.White
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.Location = New System.Drawing.Point(68, 175)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(180, 20)
        Me.txtFax.TabIndex = 118
        Me.txtFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactPosition
        '
        Me.txtContactPosition.BackColor = System.Drawing.Color.White
        Me.txtContactPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactPosition.Location = New System.Drawing.Point(68, 125)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(180, 20)
        Me.txtContactPosition.TabIndex = 119
        Me.txtContactPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactSurname
        '
        Me.txtContactSurname.BackColor = System.Drawing.Color.White
        Me.txtContactSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactSurname.Location = New System.Drawing.Point(68, 100)
        Me.txtContactSurname.Name = "txtContactSurname"
        Me.txtContactSurname.Size = New System.Drawing.Size(180, 20)
        Me.txtContactSurname.TabIndex = 122
        Me.txtContactSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactForeName
        '
        Me.txtContactForeName.BackColor = System.Drawing.Color.White
        Me.txtContactForeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactForeName.Location = New System.Drawing.Point(68, 75)
        Me.txtContactForeName.Name = "txtContactForeName"
        Me.txtContactForeName.Size = New System.Drawing.Size(180, 20)
        Me.txtContactForeName.TabIndex = 120
        Me.txtContactForeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Location = New System.Drawing.Point(68, 50)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(180, 20)
        Me.txtTitle.TabIndex = 121
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.Color.White
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Location = New System.Drawing.Point(328, 50)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(180, 20)
        Me.lblCompany.TabIndex = 116
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTel
        '
        Me.lblTel.BackColor = System.Drawing.Color.White
        Me.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTel.Location = New System.Drawing.Point(69, 150)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(179, 20)
        Me.lblTel.TabIndex = 115
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPostcode
        '
        Me.lblPostcode.BackColor = System.Drawing.Color.White
        Me.lblPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostcode.Location = New System.Drawing.Point(328, 194)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(92, 20)
        Me.lblPostcode.TabIndex = 114
        Me.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCounty
        '
        Me.lblCounty.BackColor = System.Drawing.Color.White
        Me.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounty.Location = New System.Drawing.Point(328, 170)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(180, 20)
        Me.lblCounty.TabIndex = 108
        Me.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTown
        '
        Me.lblTown.BackColor = System.Drawing.Color.White
        Me.lblTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTown.Location = New System.Drawing.Point(328, 146)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(180, 20)
        Me.lblTown.TabIndex = 103
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress3
        '
        Me.lblAddress3.BackColor = System.Drawing.Color.White
        Me.lblAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress3.Location = New System.Drawing.Point(328, 122)
        Me.lblAddress3.Name = "lblAddress3"
        Me.lblAddress3.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress3.TabIndex = 98
        Me.lblAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress2
        '
        Me.lblAddress2.BackColor = System.Drawing.Color.White
        Me.lblAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress2.Location = New System.Drawing.Point(328, 98)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress2.TabIndex = 96
        Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress1
        '
        Me.lblAddress1.BackColor = System.Drawing.Color.White
        Me.lblAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress1.Location = New System.Drawing.Point(328, 74)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress1.TabIndex = 92
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Note:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(33, 54)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(30, 13)
        Me.lbltitle.TabIndex = 86
        Me.lbltitle.Text = "Title:"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotes.Location = New System.Drawing.Point(68, 236)
        Me.txtNotes.MaxLength = 400
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(660, 42)
        Me.txtNotes.TabIndex = 113
        '
        'lblRep
        '
        Me.lblRep.BackColor = System.Drawing.Color.White
        Me.lblRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRep.Location = New System.Drawing.Point(595, 130)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(130, 20)
        Me.lblRep.TabIndex = 100
        Me.lblRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(16, 129)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 97
        Me.lblPosition.Text = "Position:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRepName
        '
        Me.lblRepName.AutoSize = True
        Me.lblRepName.Location = New System.Drawing.Point(532, 133)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(61, 13)
        Me.lblRepName.TabIndex = 99
        Me.lblRepName.Text = "Rep Name:"
        Me.lblRepName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(11, 104)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 95
        Me.lblSurname.Text = "Surname:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMagicNumber
        '
        Me.lblMagicNumber.AutoSize = True
        Me.lblMagicNumber.Location = New System.Drawing.Point(592, 183)
        Me.lblMagicNumber.Name = "lblMagicNumber"
        Me.lblMagicNumber.Size = New System.Drawing.Size(76, 13)
        Me.lblMagicNumber.TabIndex = 109
        Me.lblMagicNumber.Text = "Magic Number"
        Me.lblMagicNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMagicNumber.Visible = False
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(6, 79)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(57, 13)
        Me.lblForename.TabIndex = 91
        Me.lblForename.Text = "Forename:"
        Me.lblForename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAreaLbl
        '
        Me.lblAreaLbl.AutoSize = True
        Me.lblAreaLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAreaLbl.Location = New System.Drawing.Point(561, 158)
        Me.lblAreaLbl.Name = "lblAreaLbl"
        Me.lblAreaLbl.Size = New System.Drawing.Size(32, 13)
        Me.lblAreaLbl.TabIndex = 104
        Me.lblAreaLbl.Text = "Area:"
        Me.lblAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(28, 205)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 110
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPolExp
        '
        Me.lblPolExp.AutoSize = True
        Me.lblPolExp.Location = New System.Drawing.Point(524, 104)
        Me.lblPolExp.Name = "lblPolExp"
        Me.lblPolExp.Size = New System.Drawing.Size(69, 13)
        Me.lblPolExp.TabIndex = 93
        Me.lblPolExp.Text = "Policy Expiry:"
        Me.lblPolExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelLabel
        '
        Me.lblTelLabel.AutoSize = True
        Me.lblTelLabel.Location = New System.Drawing.Point(38, 154)
        Me.lblTelLabel.Name = "lblTelLabel"
        Me.lblTelLabel.Size = New System.Drawing.Size(25, 13)
        Me.lblTelLabel.TabIndex = 101
        Me.lblTelLabel.Text = "Tel:"
        Me.lblTelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPostcodelbl
        '
        Me.lblPostcodelbl.AutoSize = True
        Me.lblPostcodelbl.Location = New System.Drawing.Point(266, 201)
        Me.lblPostcodelbl.Name = "lblPostcodelbl"
        Me.lblPostcodelbl.Size = New System.Drawing.Size(55, 13)
        Me.lblPostcodelbl.TabIndex = 111
        Me.lblPostcodelbl.Text = "Postcode:"
        Me.lblPostcodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPolProv
        '
        Me.lblPolProv.AutoSize = True
        Me.lblPolProv.Location = New System.Drawing.Point(544, 79)
        Me.lblPolProv.Name = "lblPolProv"
        Me.lblPolProv.Size = New System.Drawing.Size(49, 13)
        Me.lblPolProv.TabIndex = 88
        Me.lblPolProv.Text = "Provider:"
        Me.lblPolProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(36, 179)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 106
        Me.lblFax.Text = "Fax:"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.Color.White
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(595, 155)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(130, 20)
        Me.lblArea.TabIndex = 105
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyExpiry
        '
        Me.lblPolicyExpiry.BackColor = System.Drawing.Color.White
        Me.lblPolicyExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyExpiry.Location = New System.Drawing.Point(595, 101)
        Me.lblPolicyExpiry.Name = "lblPolicyExpiry"
        Me.lblPolicyExpiry.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyExpiry.TabIndex = 94
        Me.lblPolicyExpiry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyProvider
        '
        Me.lblPolicyProvider.BackColor = System.Drawing.Color.White
        Me.lblPolicyProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyProvider.Location = New System.Drawing.Point(595, 76)
        Me.lblPolicyProvider.Name = "lblPolicyProvider"
        Me.lblPolicyProvider.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyProvider.TabIndex = 89
        Me.lblPolicyProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTownTitle
        '
        Me.lblTownTitle.AutoSize = True
        Me.lblTownTitle.Location = New System.Drawing.Point(284, 151)
        Me.lblTownTitle.Name = "lblTownTitle"
        Me.lblTownTitle.Size = New System.Drawing.Size(37, 13)
        Me.lblTownTitle.TabIndex = 102
        Me.lblTownTitle.Text = "Town:"
        Me.lblTownTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(273, 73)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 90
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompanya
        '
        Me.lblCompanya.AutoSize = True
        Me.lblCompanya.Location = New System.Drawing.Point(267, 50)
        Me.lblCompanya.Name = "lblCompanya"
        Me.lblCompanya.Size = New System.Drawing.Size(54, 13)
        Me.lblCompanya.TabIndex = 87
        Me.lblCompanya.Text = "Company:"
        Me.lblCompanya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountyTitle
        '
        Me.lblCountyTitle.AutoSize = True
        Me.lblCountyTitle.Location = New System.Drawing.Point(278, 176)
        Me.lblCountyTitle.Name = "lblCountyTitle"
        Me.lblCountyTitle.Size = New System.Drawing.Size(43, 13)
        Me.lblCountyTitle.TabIndex = 107
        Me.lblCountyTitle.Text = "County:"
        Me.lblCountyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Location = New System.Drawing.Point(71, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(179, 20)
        Me.lblStatus.TabIndex = 85
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Call Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Call Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDialTime
        '
        Me.lblDialTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblDialTime.Location = New System.Drawing.Point(574, 8)
        Me.lblDialTime.Name = "lblDialTime"
        Me.lblDialTime.Size = New System.Drawing.Size(85, 20)
        Me.lblDialTime.TabIndex = 126
        Me.lblDialTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "DialTime"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalltime
        '
        Me.lblCalltime.BackColor = System.Drawing.SystemColors.Control
        Me.lblCalltime.Location = New System.Drawing.Point(379, 8)
        Me.lblCalltime.Name = "lblCalltime"
        Me.lblCalltime.Size = New System.Drawing.Size(80, 20)
        Me.lblCalltime.TabIndex = 126
        Me.lblCalltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "Listen in"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lvResults
        '
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Company, Me.Salutation, Me.surname, Me.Position, Me.ColumnHeader1, Me.Status})
        Me.lvResults.FullRowSelect = True
        Me.lvResults.GridLines = True
        Me.lvResults.Location = New System.Drawing.Point(21, 286)
        Me.lvResults.MultiSelect = False
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(738, 165)
        Me.lvResults.TabIndex = 128
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'Company
        '
        Me.Company.Text = "Company"
        Me.Company.Width = 222
        '
        'Salutation
        '
        Me.Salutation.Text = "Title"
        Me.Salutation.Width = 42
        '
        'surname
        '
        Me.surname.Text = "Surname"
        Me.surname.Width = 136
        '
        'Position
        '
        Me.Position.Text = "Position"
        Me.Position.Width = 134
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Original Status:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStartedCallAt
        '
        Me.txtStartedCallAt.BackColor = System.Drawing.Color.White
        Me.txtStartedCallAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStartedCallAt.Location = New System.Drawing.Point(595, 50)
        Me.txtStartedCallAt.Name = "txtStartedCallAt"
        Me.txtStartedCallAt.Size = New System.Drawing.Size(130, 20)
        Me.txtStartedCallAt.TabIndex = 130
        Me.txtStartedCallAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "End Status"
        Me.ColumnHeader1.Width = 67
        '
        'frmAgentWatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 458)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStartedCallAt)
        Me.Controls.Add(Me.lvResults)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCalltime)
        Me.Controls.Add(Me.lblDialTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtContactPosition)
        Me.Controls.Add(Me.txtContactSurname)
        Me.Controls.Add(Me.txtContactForeName)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblAddress3)
        Me.Controls.Add(Me.lblAddress2)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblRep)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblRepName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblMagicNumber)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.lblAreaLbl)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPolExp)
        Me.Controls.Add(Me.lblTelLabel)
        Me.Controls.Add(Me.lblPostcodelbl)
        Me.Controls.Add(Me.lblPolProv)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPolicyExpiry)
        Me.Controls.Add(Me.lblPolicyProvider)
        Me.Controls.Add(Me.lblTownTitle)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCompanya)
        Me.Controls.Add(Me.lblCountyTitle)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgentWatcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAgentWatcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtEmail As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.Label
    Friend WithEvents txtContactPosition As System.Windows.Forms.Label
    Friend WithEvents txtContactSurname As System.Windows.Forms.Label
    Friend WithEvents txtContactForeName As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress3 As System.Windows.Forms.Label
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblRep As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblMagicNumber As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents lblAreaLbl As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPolExp As System.Windows.Forms.Label
    Friend WithEvents lblTelLabel As System.Windows.Forms.Label
    Friend WithEvents lblPostcodelbl As System.Windows.Forms.Label
    Friend WithEvents lblPolProv As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPolicyExpiry As System.Windows.Forms.Label
    Friend WithEvents lblPolicyProvider As System.Windows.Forms.Label
    Friend WithEvents lblTownTitle As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCompanya As System.Windows.Forms.Label
    Friend WithEvents lblCountyTitle As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDialTime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCalltime As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Company As System.Windows.Forms.ColumnHeader
    Friend WithEvents Salutation As System.Windows.Forms.ColumnHeader
    Friend WithEvents surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStartedCallAt As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
