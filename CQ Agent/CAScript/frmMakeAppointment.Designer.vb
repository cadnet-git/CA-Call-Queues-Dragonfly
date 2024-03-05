<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeAppointment
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnBack = New System.Windows.Forms.Button
        Me.btnReschedule = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.lblDay1 = New System.Windows.Forms.Label
        Me.lblDay2 = New System.Windows.Forms.Label
        Me.lblDay4 = New System.Windows.Forms.Label
        Me.lblDay3 = New System.Windows.Forms.Label
        Me.lblDay5 = New System.Windows.Forms.Label
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblPosition = New System.Windows.Forms.Label
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.lblPostcode = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblCounty = New System.Windows.Forms.Label
        Me.txtCompanyName = New System.Windows.Forms.TextBox
        Me.txtCounty = New System.Windows.Forms.TextBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblTown = New System.Windows.Forms.Label
        Me.lblAddress1 = New System.Windows.Forms.Label
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.lblTel = New System.Windows.Forms.Label
        Me.txtTown = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtContactForeName = New System.Windows.Forms.TextBox
        Me.lblForename = New System.Windows.Forms.Label
        Me.txtContactSurname = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.btnGetAddress = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtAddress3 = New System.Windows.Forms.TextBox
        Me.lblCounter = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.D1P3 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D5P5 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D4P5 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D3P5 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D2P5 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D1P5 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D5P3 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D4P3 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D3P3 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D2P3 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D5P2 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D4P2 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D3P2 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D2P2 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D1P2 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D5P1 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D4P1 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D3P1 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D2P1 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D1P1 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D5P4 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D4P4 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D3P4 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D2P4 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.D1P4 = New CADNet.CallQueues.Agent.ctlDiaryCellv2()
        Me.lblRepName = New System.Windows.Forms.Label
        Me.txtContactPosition = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCoverRequired = New System.Windows.Forms.ComboBox()
        Me.CSimpleItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.CSimpleItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.btnReschedule)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Location = New System.Drawing.Point(798, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 143)
        Me.Panel1.TabIndex = 35
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(3, 94)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(208, 38)
        Me.BtnBack.TabIndex = 15
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'btnReschedule
        '
        Me.btnReschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReschedule.Location = New System.Drawing.Point(3, 52)
        Me.btnReschedule.Name = "btnReschedule"
        Me.btnReschedule.Size = New System.Drawing.Size(208, 38)
        Me.btnReschedule.TabIndex = 14
        Me.btnReschedule.Text = "Reschedule"
        Me.btnReschedule.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 9)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(208, 38)
        Me.btnNotInterested.TabIndex = 13
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'lblDay1
        '
        Me.lblDay1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay1.Location = New System.Drawing.Point(34, 244)
        Me.lblDay1.Name = "lblDay1"
        Me.lblDay1.Size = New System.Drawing.Size(192, 23)
        Me.lblDay1.TabIndex = 67
        Me.lblDay1.Text = "day1"
        Me.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay2
        '
        Me.lblDay2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay2.Location = New System.Drawing.Point(225, 244)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(192, 23)
        Me.lblDay2.TabIndex = 68
        Me.lblDay2.Text = "day2"
        Me.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay4
        '
        Me.lblDay4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay4.Location = New System.Drawing.Point(607, 244)
        Me.lblDay4.Name = "lblDay4"
        Me.lblDay4.Size = New System.Drawing.Size(192, 23)
        Me.lblDay4.TabIndex = 70
        Me.lblDay4.Text = "day4"
        Me.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay3
        '
        Me.lblDay3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay3.Location = New System.Drawing.Point(416, 244)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(192, 23)
        Me.lblDay3.TabIndex = 69
        Me.lblDay3.Text = "day3"
        Me.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay5
        '
        Me.lblDay5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay5.Location = New System.Drawing.Point(798, 244)
        Me.lblDay5.Name = "lblDay5"
        Me.lblDay5.Size = New System.Drawing.Size(192, 23)
        Me.lblDay5.TabIndex = 71
        Me.lblDay5.Text = "day5"
        Me.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrev.Enabled = False
        Me.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrev.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.Location = New System.Drawing.Point(11, 244)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(25, 427)
        Me.btnPrev.TabIndex = 73
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(989, 244)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(25, 427)
        Me.btnNext.TabIndex = 74
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(49, 85)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 98
        Me.lblPosition.Text = "Position:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(521, 157)
        Me.txtPostcode.MaxLength = 10
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(118, 20)
        Me.txtPostcode.TabIndex = 86
        Me.txtPostcode.Text = "x"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(460, 161)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(55, 13)
        Me.lblPostcode.TabIndex = 97
        Me.lblPostcode.Text = "Postcode:"
        Me.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(99, 157)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(260, 20)
        Me.txtEmail.TabIndex = 80
        Me.txtEmail.Text = "x"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(61, 161)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 90
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(461, 12)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(54, 13)
        Me.lblCompany.TabIndex = 87
        Me.lblCompany.Text = "Company:"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(472, 137)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(43, 13)
        Me.lblCounty.TabIndex = 96
        Me.lblCounty.Text = "County:"
        Me.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(521, 8)
        Me.txtCompanyName.MaxLength = 100
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(260, 20)
        Me.txtCompanyName.TabIndex = 81
        Me.txtCompanyName.Text = "x"
        '
        'txtCounty
        '
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(521, 132)
        Me.txtCounty.MaxLength = 50
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(260, 20)
        Me.txtCounty.TabIndex = 85
        Me.txtCounty.Text = "x"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(69, 135)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 89
        Me.lblFax.Text = "Fax:"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(99, 132)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(260, 20)
        Me.txtFax.TabIndex = 79
        Me.txtFax.Text = "x"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(478, 112)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(37, 13)
        Me.lblTown.TabIndex = 95
        Me.lblTown.Text = "Town:"
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(467, 38)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress1.TabIndex = 93
        Me.lblAddress1.Text = "Address:"
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(99, 107)
        Me.txtTel.MaxLength = 20
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(260, 20)
        Me.txtTel.TabIndex = 78
        Me.txtTel.Text = "x"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(71, 110)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(25, 13)
        Me.lblTel.TabIndex = 88
        Me.lblTel.Text = "Tel:"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTown
        '
        Me.txtTown.Enabled = False
        Me.txtTown.Location = New System.Drawing.Point(521, 107)
        Me.txtTown.MaxLength = 50
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(260, 20)
        Me.txtTown.TabIndex = 84
        Me.txtTown.Text = "x"
        '
        'txtAddress1
        '
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Location = New System.Drawing.Point(521, 32)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(260, 20)
        Me.txtAddress1.TabIndex = 82
        Me.txtAddress1.Text = "x"
        '
        'txtAddress2
        '
        Me.txtAddress2.Enabled = False
        Me.txtAddress2.Location = New System.Drawing.Point(521, 57)
        Me.txtAddress2.MaxLength = 50
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(260, 20)
        Me.txtAddress2.TabIndex = 83
        Me.txtAddress2.Text = "x"
        '
        'txtContactForeName
        '
        Me.txtContactForeName.BackColor = System.Drawing.Color.White
        Me.txtContactForeName.Location = New System.Drawing.Point(99, 32)
        Me.txtContactForeName.MaxLength = 50
        Me.txtContactForeName.Name = "txtContactForeName"
        Me.txtContactForeName.Size = New System.Drawing.Size(260, 20)
        Me.txtContactForeName.TabIndex = 75
        Me.txtContactForeName.Text = "x"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(40, 35)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(57, 13)
        Me.lblForename.TabIndex = 91
        Me.lblForename.Text = "Forename:"
        Me.lblForename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactSurname
        '
        Me.txtContactSurname.Location = New System.Drawing.Point(99, 57)
        Me.txtContactSurname.MaxLength = 50
        Me.txtContactSurname.Name = "txtContactSurname"
        Me.txtContactSurname.Size = New System.Drawing.Size(260, 20)
        Me.txtContactSurname.TabIndex = 76
        Me.txtContactSurname.Text = "x"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(44, 59)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 92
        Me.lblSurname.Text = "Surname:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGetAddress
        '
        Me.btnGetAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGetAddress.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnGetAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGetAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGetAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetAddress.Location = New System.Drawing.Point(662, 156)
        Me.btnGetAddress.Name = "btnGetAddress"
        Me.btnGetAddress.Size = New System.Drawing.Size(119, 22)
        Me.btnGetAddress.TabIndex = 99
        Me.btnGetAddress.Text = "Change Address"
        Me.btnGetAddress.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbTitle
        '
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Ms", "Dr", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(99, 7)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(59, 21)
        Me.cmbTitle.TabIndex = 101
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(99, 211)
        Me.txtNotes.MaxLength = 400
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(682, 20)
        Me.txtNotes.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Notes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(796, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(216, 77)
        Me.btnSave.TabIndex = 105
        Me.btnSave.Text = "Save  Appointment"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtAddress3
        '
        Me.txtAddress3.Enabled = False
        Me.txtAddress3.Location = New System.Drawing.Point(521, 82)
        Me.txtAddress3.MaxLength = 50
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(260, 20)
        Me.txtAddress3.TabIndex = 106
        Me.txtAddress3.Text = "x"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.Color.Red
        Me.lblCounter.Location = New System.Drawing.Point(174, 4)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(0, 16)
        Me.lblCounter.TabIndex = 107
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'D1P3
        '
        Me.D1P3.AppointmentDate = Nothing
        Me.D1P3.AppointmentTime = Nothing
        Me.D1P3.BackColor = System.Drawing.Color.White
        Me.D1P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P3.Distance = 1
        Me.D1P3.Location = New System.Drawing.Point(34, 428)
        Me.D1P3.LongMaxDist = 0
        Me.D1P3.MedMaxDist = 0
        Me.D1P3.Name = "D1P3"
        Me.D1P3.NextControl = "D1P4"
        Me.D1P3.OkMaxDist = 0
        Me.D1P3.Period = 0
        Me.D1P3.PreviousControl = "D1P2"
        Me.D1P3.Size = New System.Drawing.Size(192, 82)
        Me.D1P3.TabIndex = 65
        '
        'D5P5
        '
        Me.D5P5.AppointmentDate = Nothing
        Me.D5P5.AppointmentTime = Nothing
        Me.D5P5.BackColor = System.Drawing.Color.White
        Me.D5P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P5.Distance = 1
        Me.D5P5.Location = New System.Drawing.Point(798, 589)
        Me.D5P5.LongMaxDist = 0
        Me.D5P5.MedMaxDist = 0
        Me.D5P5.Name = "D5P5"
        Me.D5P5.NextControl = ""
        Me.D5P5.OkMaxDist = 0
        Me.D5P5.Period = 0
        Me.D5P5.PreviousControl = "D5P1"
        Me.D5P5.Size = New System.Drawing.Size(192, 82)
        Me.D5P5.TabIndex = 63
        '
        'D4P5
        '
        Me.D4P5.AppointmentDate = Nothing
        Me.D4P5.AppointmentTime = Nothing
        Me.D4P5.BackColor = System.Drawing.Color.White
        Me.D4P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P5.Distance = 1
        Me.D4P5.Location = New System.Drawing.Point(607, 589)
        Me.D4P5.LongMaxDist = 0
        Me.D4P5.MedMaxDist = 0
        Me.D4P5.Name = "D4P5"
        Me.D4P5.NextControl = ""
        Me.D4P5.OkMaxDist = 0
        Me.D4P5.Period = 0
        Me.D4P5.PreviousControl = "D4P4"
        Me.D4P5.Size = New System.Drawing.Size(192, 82)
        Me.D4P5.TabIndex = 62
        '
        'D3P5
        '
        Me.D3P5.AppointmentDate = Nothing
        Me.D3P5.AppointmentTime = Nothing
        Me.D3P5.BackColor = System.Drawing.Color.White
        Me.D3P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P5.Distance = 1
        Me.D3P5.Location = New System.Drawing.Point(416, 589)
        Me.D3P5.LongMaxDist = 0
        Me.D3P5.MedMaxDist = 0
        Me.D3P5.Name = "D3P5"
        Me.D3P5.NextControl = ""
        Me.D3P5.OkMaxDist = 0
        Me.D3P5.Period = 0
        Me.D3P5.PreviousControl = "D3P4"
        Me.D3P5.Size = New System.Drawing.Size(192, 82)
        Me.D3P5.TabIndex = 61
        '
        'D2P5
        '
        Me.D2P5.AppointmentDate = Nothing
        Me.D2P5.AppointmentTime = Nothing
        Me.D2P5.BackColor = System.Drawing.Color.White
        Me.D2P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P5.Distance = 1
        Me.D2P5.Location = New System.Drawing.Point(225, 589)
        Me.D2P5.LongMaxDist = 0
        Me.D2P5.MedMaxDist = 0
        Me.D2P5.Name = "D2P5"
        Me.D2P5.NextControl = ""
        Me.D2P5.OkMaxDist = 0
        Me.D2P5.Period = 0
        Me.D2P5.PreviousControl = "D2P4"
        Me.D2P5.Size = New System.Drawing.Size(192, 82)
        Me.D2P5.TabIndex = 60
        '
        'D1P5
        '
        Me.D1P5.AppointmentDate = Nothing
        Me.D1P5.AppointmentTime = Nothing
        Me.D1P5.BackColor = System.Drawing.Color.White
        Me.D1P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P5.Distance = 1
        Me.D1P5.Location = New System.Drawing.Point(34, 589)
        Me.D1P5.LongMaxDist = 0
        Me.D1P5.MedMaxDist = 0
        Me.D1P5.Name = "D1P5"
        Me.D1P5.NextControl = ""
        Me.D1P5.OkMaxDist = 0
        Me.D1P5.Period = 0
        Me.D1P5.PreviousControl = "D1P4"
        Me.D1P5.Size = New System.Drawing.Size(192, 82)
        Me.D1P5.TabIndex = 59
        '
        'D5P3
        '
        Me.D5P3.AppointmentDate = Nothing
        Me.D5P3.AppointmentTime = Nothing
        Me.D5P3.BackColor = System.Drawing.Color.White
        Me.D5P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P3.Distance = 1
        Me.D5P3.Location = New System.Drawing.Point(798, 428)
        Me.D5P3.LongMaxDist = 0
        Me.D5P3.MedMaxDist = 0
        Me.D5P3.Name = "D5P3"
        Me.D5P3.NextControl = "D5P4"
        Me.D5P3.OkMaxDist = 0
        Me.D5P3.Period = 0
        Me.D5P3.PreviousControl = "D5P2"
        Me.D5P3.Size = New System.Drawing.Size(192, 82)
        Me.D5P3.TabIndex = 58
        '
        'D4P3
        '
        Me.D4P3.AppointmentDate = Nothing
        Me.D4P3.AppointmentTime = Nothing
        Me.D4P3.BackColor = System.Drawing.Color.White
        Me.D4P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P3.Distance = 1
        Me.D4P3.Location = New System.Drawing.Point(607, 428)
        Me.D4P3.LongMaxDist = 0
        Me.D4P3.MedMaxDist = 0
        Me.D4P3.Name = "D4P3"
        Me.D4P3.NextControl = "D4P4"
        Me.D4P3.OkMaxDist = 0
        Me.D4P3.Period = 0
        Me.D4P3.PreviousControl = "D4P2"
        Me.D4P3.Size = New System.Drawing.Size(192, 82)
        Me.D4P3.TabIndex = 57
        '
        'D3P3
        '
        Me.D3P3.AppointmentDate = Nothing
        Me.D3P3.AppointmentTime = Nothing
        Me.D3P3.BackColor = System.Drawing.Color.White
        Me.D3P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P3.Distance = 1
        Me.D3P3.Location = New System.Drawing.Point(416, 428)
        Me.D3P3.LongMaxDist = 0
        Me.D3P3.MedMaxDist = 0
        Me.D3P3.Name = "D3P3"
        Me.D3P3.NextControl = "D3P4"
        Me.D3P3.OkMaxDist = 0
        Me.D3P3.Period = 0
        Me.D3P3.PreviousControl = "D3P2"
        Me.D3P3.Size = New System.Drawing.Size(192, 82)
        Me.D3P3.TabIndex = 56
        '
        'D2P3
        '
        Me.D2P3.AppointmentDate = Nothing
        Me.D2P3.AppointmentTime = Nothing
        Me.D2P3.BackColor = System.Drawing.Color.White
        Me.D2P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P3.Distance = 1
        Me.D2P3.Location = New System.Drawing.Point(225, 428)
        Me.D2P3.LongMaxDist = 0
        Me.D2P3.MedMaxDist = 0
        Me.D2P3.Name = "D2P3"
        Me.D2P3.NextControl = "D2P4"
        Me.D2P3.OkMaxDist = 0
        Me.D2P3.Period = 0
        Me.D2P3.PreviousControl = "D2P2"
        Me.D2P3.Size = New System.Drawing.Size(192, 82)
        Me.D2P3.TabIndex = 55
        '
        'D5P2
        '
        Me.D5P2.AppointmentDate = Nothing
        Me.D5P2.AppointmentTime = Nothing
        Me.D5P2.BackColor = System.Drawing.Color.White
        Me.D5P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P2.Distance = 1
        Me.D5P2.Location = New System.Drawing.Point(798, 347)
        Me.D5P2.LongMaxDist = 0
        Me.D5P2.MedMaxDist = 0
        Me.D5P2.Name = "D5P2"
        Me.D5P2.NextControl = "D5P3"
        Me.D5P2.OkMaxDist = 0
        Me.D5P2.Period = 0
        Me.D5P2.PreviousControl = "D5P1"
        Me.D5P2.Size = New System.Drawing.Size(192, 82)
        Me.D5P2.TabIndex = 53
        '
        'D4P2
        '
        Me.D4P2.AppointmentDate = Nothing
        Me.D4P2.AppointmentTime = Nothing
        Me.D4P2.BackColor = System.Drawing.Color.White
        Me.D4P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P2.Distance = 1
        Me.D4P2.Location = New System.Drawing.Point(607, 347)
        Me.D4P2.LongMaxDist = 0
        Me.D4P2.MedMaxDist = 0
        Me.D4P2.Name = "D4P2"
        Me.D4P2.NextControl = "D4P3"
        Me.D4P2.OkMaxDist = 0
        Me.D4P2.Period = 0
        Me.D4P2.PreviousControl = "D4P1"
        Me.D4P2.Size = New System.Drawing.Size(192, 82)
        Me.D4P2.TabIndex = 52
        '
        'D3P2
        '
        Me.D3P2.AppointmentDate = Nothing
        Me.D3P2.AppointmentTime = Nothing
        Me.D3P2.BackColor = System.Drawing.Color.White
        Me.D3P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P2.Distance = 1
        Me.D3P2.Location = New System.Drawing.Point(416, 347)
        Me.D3P2.LongMaxDist = 0
        Me.D3P2.MedMaxDist = 0
        Me.D3P2.Name = "D3P2"
        Me.D3P2.NextControl = "D3P3"
        Me.D3P2.OkMaxDist = 0
        Me.D3P2.Period = 0
        Me.D3P2.PreviousControl = "D3P1"
        Me.D3P2.Size = New System.Drawing.Size(192, 82)
        Me.D3P2.TabIndex = 51
        '
        'D2P2
        '
        Me.D2P2.AppointmentDate = Nothing
        Me.D2P2.AppointmentTime = Nothing
        Me.D2P2.BackColor = System.Drawing.Color.White
        Me.D2P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P2.Distance = 1
        Me.D2P2.Location = New System.Drawing.Point(225, 347)
        Me.D2P2.LongMaxDist = 0
        Me.D2P2.MedMaxDist = 0
        Me.D2P2.Name = "D2P2"
        Me.D2P2.NextControl = "D2P3"
        Me.D2P2.OkMaxDist = 0
        Me.D2P2.Period = 0
        Me.D2P2.PreviousControl = "D2P1"
        Me.D2P2.Size = New System.Drawing.Size(192, 82)
        Me.D2P2.TabIndex = 50
        '
        'D1P2
        '
        Me.D1P2.AppointmentDate = Nothing
        Me.D1P2.AppointmentTime = Nothing
        Me.D1P2.BackColor = System.Drawing.Color.White
        Me.D1P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P2.Distance = 1
        Me.D1P2.Location = New System.Drawing.Point(34, 347)
        Me.D1P2.LongMaxDist = 0
        Me.D1P2.MedMaxDist = 0
        Me.D1P2.Name = "D1P2"
        Me.D1P2.NextControl = "D1P3"
        Me.D1P2.OkMaxDist = 0
        Me.D1P2.Period = 0
        Me.D1P2.PreviousControl = "D1P1"
        Me.D1P2.Size = New System.Drawing.Size(192, 82)
        Me.D1P2.TabIndex = 49
        '
        'D5P1
        '
        Me.D5P1.AppointmentDate = Nothing
        Me.D5P1.AppointmentTime = Nothing
        Me.D5P1.BackColor = System.Drawing.Color.White
        Me.D5P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P1.Distance = 1
        Me.D5P1.Location = New System.Drawing.Point(798, 266)
        Me.D5P1.LongMaxDist = 0
        Me.D5P1.MedMaxDist = 0
        Me.D5P1.Name = "D5P1"
        Me.D5P1.NextControl = "D5P2"
        Me.D5P1.OkMaxDist = 0
        Me.D5P1.Period = 0
        Me.D5P1.PreviousControl = ""
        Me.D5P1.Size = New System.Drawing.Size(192, 82)
        Me.D5P1.TabIndex = 48
        '
        'D4P1
        '
        Me.D4P1.AppointmentDate = Nothing
        Me.D4P1.AppointmentTime = Nothing
        Me.D4P1.BackColor = System.Drawing.Color.White
        Me.D4P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P1.Distance = 1
        Me.D4P1.Location = New System.Drawing.Point(607, 266)
        Me.D4P1.LongMaxDist = 0
        Me.D4P1.MedMaxDist = 0
        Me.D4P1.Name = "D4P1"
        Me.D4P1.NextControl = "D4P2"
        Me.D4P1.OkMaxDist = 0
        Me.D4P1.Period = 0
        Me.D4P1.PreviousControl = ""
        Me.D4P1.Size = New System.Drawing.Size(192, 82)
        Me.D4P1.TabIndex = 47
        '
        'D3P1
        '
        Me.D3P1.AppointmentDate = Nothing
        Me.D3P1.AppointmentTime = Nothing
        Me.D3P1.BackColor = System.Drawing.Color.White
        Me.D3P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P1.Distance = 1
        Me.D3P1.Location = New System.Drawing.Point(416, 266)
        Me.D3P1.LongMaxDist = 0
        Me.D3P1.MedMaxDist = 0
        Me.D3P1.Name = "D3P1"
        Me.D3P1.NextControl = "D3P2"
        Me.D3P1.OkMaxDist = 0
        Me.D3P1.Period = 0
        Me.D3P1.PreviousControl = ""
        Me.D3P1.Size = New System.Drawing.Size(192, 82)
        Me.D3P1.TabIndex = 46
        '
        'D2P1
        '
        Me.D2P1.AppointmentDate = Nothing
        Me.D2P1.AppointmentTime = Nothing
        Me.D2P1.BackColor = System.Drawing.Color.White
        Me.D2P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P1.Distance = 1
        Me.D2P1.Location = New System.Drawing.Point(225, 266)
        Me.D2P1.LongMaxDist = 0
        Me.D2P1.MedMaxDist = 0
        Me.D2P1.Name = "D2P1"
        Me.D2P1.NextControl = "D2P2"
        Me.D2P1.OkMaxDist = 0
        Me.D2P1.Period = 0
        Me.D2P1.PreviousControl = ""
        Me.D2P1.Size = New System.Drawing.Size(192, 82)
        Me.D2P1.TabIndex = 45
        '
        'D1P1
        '
        Me.D1P1.AppointmentDate = Nothing
        Me.D1P1.AppointmentTime = Nothing
        Me.D1P1.BackColor = System.Drawing.Color.White
        Me.D1P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P1.Distance = 1
        Me.D1P1.Location = New System.Drawing.Point(34, 266)
        Me.D1P1.LongMaxDist = 0
        Me.D1P1.MedMaxDist = 0
        Me.D1P1.Name = "D1P1"
        Me.D1P1.NextControl = "D1P2"
        Me.D1P1.OkMaxDist = 0
        Me.D1P1.Period = 0
        Me.D1P1.PreviousControl = ""
        Me.D1P1.Size = New System.Drawing.Size(192, 82)
        Me.D1P1.TabIndex = 44
        '
        'D5P4
        '
        Me.D5P4.AppointmentDate = Nothing
        Me.D5P4.AppointmentTime = Nothing
        Me.D5P4.BackColor = System.Drawing.Color.White
        Me.D5P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P4.Distance = 1
        Me.D5P4.Location = New System.Drawing.Point(798, 509)
        Me.D5P4.LongMaxDist = 0
        Me.D5P4.MedMaxDist = 0
        Me.D5P4.Name = "D5P4"
        Me.D5P4.NextControl = "D5P5"
        Me.D5P4.OkMaxDist = 0
        Me.D5P4.Period = 0
        Me.D5P4.PreviousControl = "D5P1"
        Me.D5P4.Size = New System.Drawing.Size(192, 82)
        Me.D5P4.TabIndex = 43
        '
        'D4P4
        '
        Me.D4P4.AppointmentDate = Nothing
        Me.D4P4.AppointmentTime = Nothing
        Me.D4P4.BackColor = System.Drawing.Color.White
        Me.D4P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P4.Distance = 1
        Me.D4P4.Location = New System.Drawing.Point(607, 509)
        Me.D4P4.LongMaxDist = 0
        Me.D4P4.MedMaxDist = 0
        Me.D4P4.Name = "D4P4"
        Me.D4P4.NextControl = "D4P5"
        Me.D4P4.OkMaxDist = 0
        Me.D4P4.Period = 0
        Me.D4P4.PreviousControl = "D4P3"
        Me.D4P4.Size = New System.Drawing.Size(192, 82)
        Me.D4P4.TabIndex = 42
        '
        'D3P4
        '
        Me.D3P4.AppointmentDate = Nothing
        Me.D3P4.AppointmentTime = Nothing
        Me.D3P4.BackColor = System.Drawing.Color.White
        Me.D3P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P4.Distance = 1
        Me.D3P4.Location = New System.Drawing.Point(416, 509)
        Me.D3P4.LongMaxDist = 0
        Me.D3P4.MedMaxDist = 0
        Me.D3P4.Name = "D3P4"
        Me.D3P4.NextControl = "D3P5"
        Me.D3P4.OkMaxDist = 0
        Me.D3P4.Period = 0
        Me.D3P4.PreviousControl = "D3P3"
        Me.D3P4.Size = New System.Drawing.Size(192, 82)
        Me.D3P4.TabIndex = 41
        '
        'D2P4
        '
        Me.D2P4.AppointmentDate = Nothing
        Me.D2P4.AppointmentTime = Nothing
        Me.D2P4.BackColor = System.Drawing.Color.White
        Me.D2P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P4.Distance = 1
        Me.D2P4.Location = New System.Drawing.Point(225, 509)
        Me.D2P4.LongMaxDist = 0
        Me.D2P4.MedMaxDist = 0
        Me.D2P4.Name = "D2P4"
        Me.D2P4.NextControl = "D2P5"
        Me.D2P4.OkMaxDist = 0
        Me.D2P4.Period = 0
        Me.D2P4.PreviousControl = "D2P3"
        Me.D2P4.Size = New System.Drawing.Size(192, 82)
        Me.D2P4.TabIndex = 40
        '
        'D1P4
        '
        Me.D1P4.AppointmentDate = Nothing
        Me.D1P4.AppointmentTime = Nothing
        Me.D1P4.BackColor = System.Drawing.Color.White
        Me.D1P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P4.Distance = 1
        Me.D1P4.Location = New System.Drawing.Point(34, 509)
        Me.D1P4.LongMaxDist = 0
        Me.D1P4.MedMaxDist = 0
        Me.D1P4.Name = "D1P4"
        Me.D1P4.NextControl = "D1P5"
        Me.D1P4.OkMaxDist = 0
        Me.D1P4.Period = 0
        Me.D1P4.PreviousControl = "D1P3"
        Me.D1P4.Size = New System.Drawing.Size(192, 82)
        Me.D1P4.TabIndex = 39
        '
        'lblRepName
        '
        Me.lblRepName.AutoSize = True
        Me.lblRepName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepName.Location = New System.Drawing.Point(180, 10)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(75, 13)
        Me.lblRepName.TabIndex = 108
        Me.lblRepName.Text = "lblRepName"
        Me.lblRepName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Items.AddRange(New Object() {"Accounts Manager", "Commercial Director", "Company Accountant", "Company Director", "Company Secretary ", "Director", "Finance Director", "Finance Manager", "Finance Officer", "Financial Controller", "HR Director", "HR Manager", "HR Officer", "Managing Director", "Office Manager", "Owner", "Partner", "Practice Manager", "Proprietor"})
        Me.txtContactPosition.Location = New System.Drawing.Point(99, 80)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(260, 21)
        Me.txtContactPosition.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Cover Required:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCoverRequired
        '
        Me.cboCoverRequired.DataSource = Me.CSimpleItemBindingSource
        Me.cboCoverRequired.DisplayMember = "Title"
        Me.cboCoverRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoverRequired.FormattingEnabled = True
        Me.cboCoverRequired.Location = New System.Drawing.Point(99, 183)
        Me.cboCoverRequired.Name = "cboCoverRequired"
        Me.cboCoverRequired.Size = New System.Drawing.Size(260, 21)
        Me.cboCoverRequired.TabIndex = 110
        Me.cboCoverRequired.ValueMember = "Value"
        '
        'CSimpleItemBindingSource
        '
        Me.CSimpleItemBindingSource.DataSource = GetType(CADNet.CallQueues.Common.cSimpleItem)
        '
        'frmMakeAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1029, 685)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCoverRequired)
        Me.Controls.Add(Me.txtContactPosition)
        Me.Controls.Add(Me.lblRepName)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTitle)
        Me.Controls.Add(Me.btnGetAddress)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtContactForeName)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtContactSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblDay5)
        Me.Controls.Add(Me.lblDay4)
        Me.Controls.Add(Me.lblDay3)
        Me.Controls.Add(Me.lblDay2)
        Me.Controls.Add(Me.lblDay1)
        Me.Controls.Add(Me.D1P3)
        Me.Controls.Add(Me.D5P5)
        Me.Controls.Add(Me.D4P5)
        Me.Controls.Add(Me.D3P5)
        Me.Controls.Add(Me.D2P5)
        Me.Controls.Add(Me.D1P5)
        Me.Controls.Add(Me.D5P3)
        Me.Controls.Add(Me.D4P3)
        Me.Controls.Add(Me.D3P3)
        Me.Controls.Add(Me.D2P3)
        Me.Controls.Add(Me.D5P2)
        Me.Controls.Add(Me.D4P2)
        Me.Controls.Add(Me.D3P2)
        Me.Controls.Add(Me.D2P2)
        Me.Controls.Add(Me.D1P2)
        Me.Controls.Add(Me.D5P1)
        Me.Controls.Add(Me.D4P1)
        Me.Controls.Add(Me.D3P1)
        Me.Controls.Add(Me.D2P1)
        Me.Controls.Add(Me.D1P1)
        Me.Controls.Add(Me.D5P4)
        Me.Controls.Add(Me.D4P4)
        Me.Controls.Add(Me.D3P4)
        Me.Controls.Add(Me.D2P4)
        Me.Controls.Add(Me.D1P4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMakeAppointment"
        Me.Text = "frmMakeAppointment"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CSimpleItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReschedule As System.Windows.Forms.Button
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents D1P4 As ctlDiaryCellv2
    Friend WithEvents D2P4 As ctlDiaryCellv2
    Friend WithEvents D3P4 As ctlDiaryCellv2
    Friend WithEvents D4P4 As ctlDiaryCellv2
    Friend WithEvents D5P4 As ctlDiaryCellv2
    Friend WithEvents D5P1 As ctlDiaryCellv2
    Friend WithEvents D4P1 As ctlDiaryCellv2
    Friend WithEvents D3P1 As ctlDiaryCellv2
    Friend WithEvents D2P1 As ctlDiaryCellv2
    Friend WithEvents D1P1 As ctlDiaryCellv2
    Friend WithEvents D5P2 As ctlDiaryCellv2
    Friend WithEvents D4P2 As ctlDiaryCellv2
    Friend WithEvents D3P2 As ctlDiaryCellv2
    Friend WithEvents D2P2 As ctlDiaryCellv2
    Friend WithEvents D1P2 As ctlDiaryCellv2
    Friend WithEvents D5P3 As ctlDiaryCellv2
    Friend WithEvents D4P3 As ctlDiaryCellv2
    Friend WithEvents D3P3 As ctlDiaryCellv2
    Friend WithEvents D2P3 As ctlDiaryCellv2
    Friend WithEvents CtlDiaryCellv220 As ctlDiaryCellv2
    Friend WithEvents D5P5 As ctlDiaryCellv2
    Friend WithEvents D4P5 As ctlDiaryCellv2
    Friend WithEvents D3P5 As ctlDiaryCellv2
    Friend WithEvents D2P5 As ctlDiaryCellv2
    Friend WithEvents D1P5 As ctlDiaryCellv2
    Friend WithEvents D1P3 As ctlDiaryCellv2
    Friend WithEvents lblDay1 As System.Windows.Forms.Label
    Friend WithEvents lblDay2 As System.Windows.Forms.Label
    Friend WithEvents lblDay4 As System.Windows.Forms.Label
    Friend WithEvents lblDay3 As System.Windows.Forms.Label
    Friend WithEvents lblDay5 As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContactForeName As System.Windows.Forms.TextBox
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtContactSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents btnGetAddress As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents txtContactPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCoverRequired As System.Windows.Forms.ComboBox
    Friend WithEvents CSimpleItemBindingSource As System.Windows.Forms.BindingSource
End Class
