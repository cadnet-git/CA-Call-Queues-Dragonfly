<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManager))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvwUsers = New System.Windows.Forms.ListView()
        Me.colRealName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUserType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAreaHeader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkIncludeInactive = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.TabControil1 = New System.Windows.Forms.TabControl()
        Me.tabDetails = New System.Windows.Forms.TabPage()
        Me.txtRealname = New System.Windows.Forms.TextBox()
        Me.cmbAccessLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.tabAddress = New System.Windows.Forms.TabPage()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress5 = New System.Windows.Forms.TextBox()
        Me.txtAddress4 = New System.Windows.Forms.TextBox()
        Me.txtAddress3 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabDiary = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboOverrideDiaryWeeks = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboMaxApps = New System.Windows.Forms.ComboBox()
        Me.lblAppWarn5 = New System.Windows.Forms.Label()
        Me.lblAppWarn4 = New System.Windows.Forms.Label()
        Me.lblAppWarn3 = New System.Windows.Forms.Label()
        Me.lblAppWarn2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkAppointment5 = New System.Windows.Forms.CheckBox()
        Me.chkAppointment4 = New System.Windows.Forms.CheckBox()
        Me.chkAppointment3 = New System.Windows.Forms.CheckBox()
        Me.chkAppointment2 = New System.Windows.Forms.CheckBox()
        Me.dtpAppointment5 = New System.Windows.Forms.DateTimePicker()
        Me.dtpAppointment4 = New System.Windows.Forms.DateTimePicker()
        Me.dtpAppointment3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpAppointment2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpAppointment1 = New System.Windows.Forms.DateTimePicker()
        Me.tabAreas = New System.Windows.Forms.TabPage()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.lvwAreas = New System.Windows.Forms.ListView()
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoColdCalls = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnuAreas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAreaRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoColdCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabAgent = New System.Windows.Forms.TabPage()
        Me.cbGroupCompany = New System.Windows.Forms.ComboBox()
        Me.cmbAgentArea = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabDistance = New System.Windows.Forms.TabPage()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtlongMax = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtMedMax = New System.Windows.Forms.TextBox()
        Me.txtMaxOK = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControil1.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        Me.tabAddress.SuspendLayout()
        Me.tabDiary.SuspendLayout()
        Me.tabAreas.SuspendLayout()
        Me.cmnuAreas.SuspendLayout()
        Me.tabAgent.SuspendLayout()
        Me.TabDistance.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwUsers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlAreaHeader)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControil1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(400, 566)
        Me.SplitContainer1.SplitterDistance = 256
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'lvwUsers
        '
        Me.lvwUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRealName, Me.colUserType})
        Me.lvwUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwUsers.HideSelection = False
        Me.lvwUsers.Location = New System.Drawing.Point(0, 48)
        Me.lvwUsers.Name = "lvwUsers"
        Me.lvwUsers.Size = New System.Drawing.Size(400, 208)
        Me.lvwUsers.TabIndex = 1
        Me.lvwUsers.UseCompatibleStateImageBehavior = False
        Me.lvwUsers.View = System.Windows.Forms.View.Details
        '
        'colRealName
        '
        Me.colRealName.Text = "Name"
        Me.colRealName.Width = 252
        '
        'colUserType
        '
        Me.colUserType.Text = "Type"
        Me.colUserType.Width = 137
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.chkIncludeInactive)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Controls.Add(Me.btnCreateUser)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(400, 48)
        Me.pnlAreaHeader.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.users
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'chkIncludeInactive
        '
        Me.chkIncludeInactive.AutoSize = True
        Me.chkIncludeInactive.Location = New System.Drawing.Point(303, 31)
        Me.chkIncludeInactive.Name = "chkIncludeInactive"
        Me.chkIncludeInactive.Size = New System.Drawing.Size(94, 17)
        Me.chkIncludeInactive.TabIndex = 2
        Me.chkIncludeInactive.Text = "Show Inactive"
        Me.chkIncludeInactive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Users"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateUser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCreateUser.Location = New System.Drawing.Point(303, 6)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(94, 23)
        Me.btnCreateUser.TabIndex = 1
        Me.btnCreateUser.Text = "New User"
        Me.btnCreateUser.UseVisualStyleBackColor = False
        '
        'TabControil1
        '
        Me.TabControil1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControil1.Controls.Add(Me.tabDetails)
        Me.TabControil1.Controls.Add(Me.tabAddress)
        Me.TabControil1.Controls.Add(Me.tabDiary)
        Me.TabControil1.Controls.Add(Me.tabAreas)
        Me.TabControil1.Controls.Add(Me.tabAgent)
        Me.TabControil1.Controls.Add(Me.TabDistance)
        Me.TabControil1.Location = New System.Drawing.Point(3, 41)
        Me.TabControil1.Name = "TabControil1"
        Me.TabControil1.SelectedIndex = 0
        Me.TabControil1.Size = New System.Drawing.Size(392, 233)
        Me.TabControil1.TabIndex = 1
        '
        'tabDetails
        '
        Me.tabDetails.Controls.Add(Me.txtRealname)
        Me.tabDetails.Controls.Add(Me.cmbAccessLevel)
        Me.tabDetails.Controls.Add(Me.Label1)
        Me.tabDetails.Controls.Add(Me.cmbStatus)
        Me.tabDetails.Controls.Add(Me.Label3)
        Me.tabDetails.Controls.Add(Me.txtUserName)
        Me.tabDetails.Controls.Add(Me.Label4)
        Me.tabDetails.Controls.Add(Me.Label5)
        Me.tabDetails.Controls.Add(Me.btnChangePassword)
        Me.tabDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetails.Size = New System.Drawing.Size(384, 207)
        Me.tabDetails.TabIndex = 0
        Me.tabDetails.Text = "Details"
        Me.tabDetails.UseVisualStyleBackColor = True
        '
        'txtRealname
        '
        Me.txtRealname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRealname.Enabled = False
        Me.txtRealname.Location = New System.Drawing.Point(75, 6)
        Me.txtRealname.MaxLength = 50
        Me.txtRealname.Name = "txtRealname"
        Me.txtRealname.Size = New System.Drawing.Size(187, 20)
        Me.txtRealname.TabIndex = 1
        '
        'cmbAccessLevel
        '
        Me.cmbAccessLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessLevel.Enabled = False
        Me.cmbAccessLevel.FormattingEnabled = True
        Me.cmbAccessLevel.Location = New System.Drawing.Point(75, 85)
        Me.cmbAccessLevel.Name = "cmbAccessLevel"
        Me.cmbAccessLevel.Size = New System.Drawing.Size(187, 21)
        Me.cmbAccessLevel.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(75, 58)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(187, 21)
        Me.cmbStatus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(14, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username"
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(75, 32)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(187, 20)
        Me.txtUserName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(32, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(0, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Access Level"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangePassword.Enabled = False
        Me.btnChangePassword.Location = New System.Drawing.Point(268, 4)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(106, 23)
        Me.btnChangePassword.TabIndex = 2
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'tabAddress
        '
        Me.tabAddress.Controls.Add(Me.txtPosition)
        Me.tabAddress.Controls.Add(Me.txtPostcode)
        Me.tabAddress.Controls.Add(Me.txtAddress5)
        Me.tabAddress.Controls.Add(Me.txtAddress4)
        Me.tabAddress.Controls.Add(Me.txtAddress3)
        Me.tabAddress.Controls.Add(Me.txtAddress2)
        Me.tabAddress.Controls.Add(Me.txtAddress1)
        Me.tabAddress.Controls.Add(Me.txtEmail)
        Me.tabAddress.Controls.Add(Me.txtFax)
        Me.tabAddress.Controls.Add(Me.txtTel)
        Me.tabAddress.Controls.Add(Me.Label17)
        Me.tabAddress.Controls.Add(Me.Label16)
        Me.tabAddress.Controls.Add(Me.Label11)
        Me.tabAddress.Controls.Add(Me.Label10)
        Me.tabAddress.Controls.Add(Me.Label9)
        Me.tabAddress.Controls.Add(Me.Label8)
        Me.tabAddress.Location = New System.Drawing.Point(4, 22)
        Me.tabAddress.Name = "tabAddress"
        Me.tabAddress.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddress.Size = New System.Drawing.Size(384, 207)
        Me.tabAddress.TabIndex = 1
        Me.tabAddress.Text = "Address"
        Me.tabAddress.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPosition.Enabled = False
        Me.txtPosition.Location = New System.Drawing.Point(68, 114)
        Me.txtPosition.MaxLength = 50
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(117, 20)
        Me.txtPosition.TabIndex = 12
        '
        'txtPostcode
        '
        Me.txtPostcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPostcode.Enabled = False
        Me.txtPostcode.Location = New System.Drawing.Point(259, 140)
        Me.txtPostcode.MaxLength = 50
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(117, 20)
        Me.txtPostcode.TabIndex = 15
        '
        'txtAddress5
        '
        Me.txtAddress5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress5.Enabled = False
        Me.txtAddress5.Location = New System.Drawing.Point(259, 114)
        Me.txtAddress5.MaxLength = 50
        Me.txtAddress5.Name = "txtAddress5"
        Me.txtAddress5.Size = New System.Drawing.Size(117, 20)
        Me.txtAddress5.TabIndex = 13
        '
        'txtAddress4
        '
        Me.txtAddress4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress4.Enabled = False
        Me.txtAddress4.Location = New System.Drawing.Point(259, 88)
        Me.txtAddress4.MaxLength = 50
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(117, 20)
        Me.txtAddress4.TabIndex = 10
        '
        'txtAddress3
        '
        Me.txtAddress3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress3.Enabled = False
        Me.txtAddress3.Location = New System.Drawing.Point(259, 62)
        Me.txtAddress3.MaxLength = 50
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(117, 20)
        Me.txtAddress3.TabIndex = 9
        '
        'txtAddress2
        '
        Me.txtAddress2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress2.Enabled = False
        Me.txtAddress2.Location = New System.Drawing.Point(259, 36)
        Me.txtAddress2.MaxLength = 50
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(115, 20)
        Me.txtAddress2.TabIndex = 6
        '
        'txtAddress1
        '
        Me.txtAddress1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Location = New System.Drawing.Point(259, 10)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(117, 20)
        Me.txtAddress1.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(68, 62)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(117, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(68, 36)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(117, 20)
        Me.txtFax.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(68, 10)
        Me.txtTel.MaxLength = 50
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(115, 20)
        Me.txtTel.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Position"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(201, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Postcode"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = " Fax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Telephone"
        '
        'tabDiary
        '
        Me.tabDiary.Controls.Add(Me.Label13)
        Me.tabDiary.Controls.Add(Me.cboOverrideDiaryWeeks)
        Me.tabDiary.Controls.Add(Me.Label12)
        Me.tabDiary.Controls.Add(Me.cboMaxApps)
        Me.tabDiary.Controls.Add(Me.lblAppWarn5)
        Me.tabDiary.Controls.Add(Me.lblAppWarn4)
        Me.tabDiary.Controls.Add(Me.lblAppWarn3)
        Me.tabDiary.Controls.Add(Me.lblAppWarn2)
        Me.tabDiary.Controls.Add(Me.Label6)
        Me.tabDiary.Controls.Add(Me.chkAppointment5)
        Me.tabDiary.Controls.Add(Me.chkAppointment4)
        Me.tabDiary.Controls.Add(Me.chkAppointment3)
        Me.tabDiary.Controls.Add(Me.chkAppointment2)
        Me.tabDiary.Controls.Add(Me.dtpAppointment5)
        Me.tabDiary.Controls.Add(Me.dtpAppointment4)
        Me.tabDiary.Controls.Add(Me.dtpAppointment3)
        Me.tabDiary.Controls.Add(Me.dtpAppointment2)
        Me.tabDiary.Controls.Add(Me.dtpAppointment1)
        Me.tabDiary.Location = New System.Drawing.Point(4, 22)
        Me.tabDiary.Name = "tabDiary"
        Me.tabDiary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiary.Size = New System.Drawing.Size(384, 207)
        Me.tabDiary.TabIndex = 2
        Me.tabDiary.Text = "Diary"
        Me.tabDiary.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Override Diary Weeks ( 0 = Not Overridden)"
        '
        'cboOverrideDiaryWeeks
        '
        Me.cboOverrideDiaryWeeks.FormattingEnabled = True
        Me.cboOverrideDiaryWeeks.Location = New System.Drawing.Point(259, 172)
        Me.cboOverrideDiaryWeeks.Name = "cboOverrideDiaryWeeks"
        Me.cboOverrideDiaryWeeks.Size = New System.Drawing.Size(87, 21)
        Me.cboOverrideDiaryWeeks.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Max Appointments Per Week"
        '
        'cboMaxApps
        '
        Me.cboMaxApps.FormattingEnabled = True
        Me.cboMaxApps.Location = New System.Drawing.Point(259, 146)
        Me.cboMaxApps.Name = "cboMaxApps"
        Me.cboMaxApps.Size = New System.Drawing.Size(87, 21)
        Me.cboMaxApps.TabIndex = 15
        '
        'lblAppWarn5
        '
        Me.lblAppWarn5.AutoSize = True
        Me.lblAppWarn5.ForeColor = System.Drawing.Color.Red
        Me.lblAppWarn5.Location = New System.Drawing.Point(208, 122)
        Me.lblAppWarn5.Name = "lblAppWarn5"
        Me.lblAppWarn5.Size = New System.Drawing.Size(173, 13)
        Me.lblAppWarn5.TabIndex = 13
        Me.lblAppWarn5.Text = "Must be after previous appointment"
        Me.lblAppWarn5.Visible = False
        '
        'lblAppWarn4
        '
        Me.lblAppWarn4.AutoSize = True
        Me.lblAppWarn4.ForeColor = System.Drawing.Color.Red
        Me.lblAppWarn4.Location = New System.Drawing.Point(208, 96)
        Me.lblAppWarn4.Name = "lblAppWarn4"
        Me.lblAppWarn4.Size = New System.Drawing.Size(173, 13)
        Me.lblAppWarn4.TabIndex = 10
        Me.lblAppWarn4.Text = "Must be after previous appointment"
        Me.lblAppWarn4.Visible = False
        '
        'lblAppWarn3
        '
        Me.lblAppWarn3.AutoSize = True
        Me.lblAppWarn3.ForeColor = System.Drawing.Color.Red
        Me.lblAppWarn3.Location = New System.Drawing.Point(208, 69)
        Me.lblAppWarn3.Name = "lblAppWarn3"
        Me.lblAppWarn3.Size = New System.Drawing.Size(173, 13)
        Me.lblAppWarn3.TabIndex = 7
        Me.lblAppWarn3.Text = "Must be after previous appointment"
        Me.lblAppWarn3.Visible = False
        '
        'lblAppWarn2
        '
        Me.lblAppWarn2.AutoSize = True
        Me.lblAppWarn2.ForeColor = System.Drawing.Color.Red
        Me.lblAppWarn2.Location = New System.Drawing.Point(208, 44)
        Me.lblAppWarn2.Name = "lblAppWarn2"
        Me.lblAppWarn2.Size = New System.Drawing.Size(173, 13)
        Me.lblAppWarn2.TabIndex = 4
        Me.lblAppWarn2.Text = "Must be after previous appointment"
        Me.lblAppWarn2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Appointment 1"
        '
        'chkAppointment5
        '
        Me.chkAppointment5.AutoSize = True
        Me.chkAppointment5.Location = New System.Drawing.Point(14, 121)
        Me.chkAppointment5.Name = "chkAppointment5"
        Me.chkAppointment5.Size = New System.Drawing.Size(94, 17)
        Me.chkAppointment5.TabIndex = 11
        Me.chkAppointment5.Text = "Appointment 5"
        Me.chkAppointment5.UseVisualStyleBackColor = True
        '
        'chkAppointment4
        '
        Me.chkAppointment4.AutoSize = True
        Me.chkAppointment4.Checked = True
        Me.chkAppointment4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAppointment4.Location = New System.Drawing.Point(14, 95)
        Me.chkAppointment4.Name = "chkAppointment4"
        Me.chkAppointment4.Size = New System.Drawing.Size(94, 17)
        Me.chkAppointment4.TabIndex = 8
        Me.chkAppointment4.Text = "Appointment 4"
        Me.chkAppointment4.UseVisualStyleBackColor = True
        '
        'chkAppointment3
        '
        Me.chkAppointment3.AutoSize = True
        Me.chkAppointment3.Checked = True
        Me.chkAppointment3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAppointment3.Location = New System.Drawing.Point(14, 69)
        Me.chkAppointment3.Name = "chkAppointment3"
        Me.chkAppointment3.Size = New System.Drawing.Size(94, 17)
        Me.chkAppointment3.TabIndex = 5
        Me.chkAppointment3.Text = "Appointment 3"
        Me.chkAppointment3.UseVisualStyleBackColor = True
        '
        'chkAppointment2
        '
        Me.chkAppointment2.AutoSize = True
        Me.chkAppointment2.Checked = True
        Me.chkAppointment2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAppointment2.Location = New System.Drawing.Point(14, 43)
        Me.chkAppointment2.Name = "chkAppointment2"
        Me.chkAppointment2.Size = New System.Drawing.Size(94, 17)
        Me.chkAppointment2.TabIndex = 2
        Me.chkAppointment2.Text = "Appointment 2"
        Me.chkAppointment2.UseVisualStyleBackColor = True
        '
        'dtpAppointment5
        '
        Me.dtpAppointment5.CustomFormat = "hh:mm tt"
        Me.dtpAppointment5.Enabled = False
        Me.dtpAppointment5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointment5.Location = New System.Drawing.Point(117, 118)
        Me.dtpAppointment5.Name = "dtpAppointment5"
        Me.dtpAppointment5.ShowUpDown = True
        Me.dtpAppointment5.Size = New System.Drawing.Size(87, 20)
        Me.dtpAppointment5.TabIndex = 12
        Me.dtpAppointment5.Value = New Date(2007, 11, 29, 17, 0, 0, 0)
        '
        'dtpAppointment4
        '
        Me.dtpAppointment4.CustomFormat = "hh:mm tt"
        Me.dtpAppointment4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointment4.Location = New System.Drawing.Point(117, 92)
        Me.dtpAppointment4.Name = "dtpAppointment4"
        Me.dtpAppointment4.ShowUpDown = True
        Me.dtpAppointment4.Size = New System.Drawing.Size(87, 20)
        Me.dtpAppointment4.TabIndex = 9
        Me.dtpAppointment4.Value = New Date(2007, 11, 29, 16, 0, 0, 0)
        '
        'dtpAppointment3
        '
        Me.dtpAppointment3.CustomFormat = "hh:mm tt"
        Me.dtpAppointment3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointment3.Location = New System.Drawing.Point(117, 66)
        Me.dtpAppointment3.Name = "dtpAppointment3"
        Me.dtpAppointment3.ShowUpDown = True
        Me.dtpAppointment3.Size = New System.Drawing.Size(87, 20)
        Me.dtpAppointment3.TabIndex = 6
        Me.dtpAppointment3.Value = New Date(2007, 11, 29, 14, 0, 0, 0)
        '
        'dtpAppointment2
        '
        Me.dtpAppointment2.CustomFormat = "hh:mm tt"
        Me.dtpAppointment2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointment2.Location = New System.Drawing.Point(117, 40)
        Me.dtpAppointment2.Name = "dtpAppointment2"
        Me.dtpAppointment2.ShowUpDown = True
        Me.dtpAppointment2.Size = New System.Drawing.Size(87, 20)
        Me.dtpAppointment2.TabIndex = 3
        Me.dtpAppointment2.Value = New Date(2007, 11, 29, 12, 0, 0, 0)
        '
        'dtpAppointment1
        '
        Me.dtpAppointment1.CustomFormat = "hh:mm tt"
        Me.dtpAppointment1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointment1.Location = New System.Drawing.Point(117, 14)
        Me.dtpAppointment1.Name = "dtpAppointment1"
        Me.dtpAppointment1.ShowUpDown = True
        Me.dtpAppointment1.Size = New System.Drawing.Size(87, 20)
        Me.dtpAppointment1.TabIndex = 1
        Me.dtpAppointment1.Value = New Date(2007, 11, 29, 10, 0, 0, 0)
        '
        'tabAreas
        '
        Me.tabAreas.Controls.Add(Me.btnAddArea)
        Me.tabAreas.Controls.Add(Me.lvwAreas)
        Me.tabAreas.Location = New System.Drawing.Point(4, 22)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAreas.Size = New System.Drawing.Size(384, 207)
        Me.tabAreas.TabIndex = 3
        Me.tabAreas.Text = "Areas"
        Me.tabAreas.UseVisualStyleBackColor = True
        '
        'btnAddArea
        '
        Me.btnAddArea.Location = New System.Drawing.Point(306, 172)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(75, 23)
        Me.btnAddArea.TabIndex = 1
        Me.btnAddArea.Text = "Add"
        Me.btnAddArea.UseVisualStyleBackColor = True
        '
        'lvwAreas
        '
        Me.lvwAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTitle, Me.colNoColdCalls})
        Me.lvwAreas.ContextMenuStrip = Me.cmnuAreas
        Me.lvwAreas.HideSelection = False
        Me.lvwAreas.Location = New System.Drawing.Point(0, 0)
        Me.lvwAreas.Name = "lvwAreas"
        Me.lvwAreas.Size = New System.Drawing.Size(384, 171)
        Me.lvwAreas.TabIndex = 0
        Me.lvwAreas.UseCompatibleStateImageBehavior = False
        Me.lvwAreas.View = System.Windows.Forms.View.Details
        '
        'colTitle
        '
        Me.colTitle.Text = "Area Name"
        Me.colTitle.Width = 305
        '
        'colNoColdCalls
        '
        Me.colNoColdCalls.Text = "No Cold"
        Me.colNoColdCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmnuAreas
        '
        Me.cmnuAreas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAreaRemove, Me.ToolStripMenuItem1, Me.CancelToolStripMenuItem, Me.NoColdCallsToolStripMenuItem})
        Me.cmnuAreas.Name = "cmnuAreas"
        Me.cmnuAreas.Size = New System.Drawing.Size(147, 76)
        '
        'mnuAreaRemove
        '
        Me.mnuAreaRemove.Name = "mnuAreaRemove"
        Me.mnuAreaRemove.Size = New System.Drawing.Size(146, 22)
        Me.mnuAreaRemove.Text = "Remove"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'NoColdCallsToolStripMenuItem
        '
        Me.NoColdCallsToolStripMenuItem.Name = "NoColdCallsToolStripMenuItem"
        Me.NoColdCallsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NoColdCallsToolStripMenuItem.Text = "No Cold Calls"
        '
        'tabAgent
        '
        Me.tabAgent.Controls.Add(Me.Label14)
        Me.tabAgent.Controls.Add(Me.cbGroupCompany)
        Me.tabAgent.Controls.Add(Me.cmbAgentArea)
        Me.tabAgent.Controls.Add(Me.Label7)
        Me.tabAgent.Location = New System.Drawing.Point(4, 22)
        Me.tabAgent.Name = "tabAgent"
        Me.tabAgent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAgent.Size = New System.Drawing.Size(384, 207)
        Me.tabAgent.TabIndex = 4
        Me.tabAgent.Text = "Agent"
        Me.tabAgent.UseVisualStyleBackColor = True
        '
        'cbGroupCompany
        '
        Me.cbGroupCompany.DisplayMember = "Title"
        Me.cbGroupCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroupCompany.FormattingEnabled = True
        Me.cbGroupCompany.Location = New System.Drawing.Point(44, 119)
        Me.cbGroupCompany.Name = "cbGroupCompany"
        Me.cbGroupCompany.Size = New System.Drawing.Size(242, 21)
        Me.cbGroupCompany.TabIndex = 2
        Me.cbGroupCompany.ValueMember = "Value"
        '
        'cmbAgentArea
        '
        Me.cmbAgentArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgentArea.FormattingEnabled = True
        Me.cmbAgentArea.Location = New System.Drawing.Point(44, 47)
        Me.cmbAgentArea.Name = "cmbAgentArea"
        Me.cmbAgentArea.Size = New System.Drawing.Size(242, 21)
        Me.cmbAgentArea.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Select the Area this agent is assigned to:"
        '
        'TabDistance
        '
        Me.TabDistance.Controls.Add(Me.Label49)
        Me.TabDistance.Controls.Add(Me.txtlongMax)
        Me.TabDistance.Controls.Add(Me.Label48)
        Me.TabDistance.Controls.Add(Me.Label47)
        Me.TabDistance.Controls.Add(Me.txtMedMax)
        Me.TabDistance.Controls.Add(Me.txtMaxOK)
        Me.TabDistance.Controls.Add(Me.Label43)
        Me.TabDistance.Controls.Add(Me.Label44)
        Me.TabDistance.Controls.Add(Me.Label45)
        Me.TabDistance.Location = New System.Drawing.Point(4, 22)
        Me.TabDistance.Name = "TabDistance"
        Me.TabDistance.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDistance.Size = New System.Drawing.Size(384, 207)
        Me.TabDistance.TabIndex = 5
        Me.TabDistance.Text = "Distances"
        Me.TabDistance.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(239, 86)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(16, 13)
        Me.Label49.TabIndex = 7
        Me.Label49.Text = "to"
        '
        'txtlongMax
        '
        Me.txtlongMax.Location = New System.Drawing.Point(265, 82)
        Me.txtlongMax.Name = "txtlongMax"
        Me.txtlongMax.Size = New System.Drawing.Size(52, 20)
        Me.txtlongMax.TabIndex = 8
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(151, 86)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(16, 13)
        Me.Label48.TabIndex = 5
        Me.Label48.Text = "to"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(48, 86)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(31, 13)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "0   to"
        '
        'txtMedMax
        '
        Me.txtMedMax.Location = New System.Drawing.Point(177, 82)
        Me.txtMedMax.Name = "txtMedMax"
        Me.txtMedMax.Size = New System.Drawing.Size(52, 20)
        Me.txtMedMax.TabIndex = 6
        '
        'txtMaxOK
        '
        Me.txtMaxOK.Location = New System.Drawing.Point(89, 82)
        Me.txtMaxOK.Name = "txtMaxOK"
        Me.txtMaxOK.Size = New System.Drawing.Size(52, 20)
        Me.txtMaxOK.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(270, 60)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(31, 13)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Long"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(179, 60)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 13)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Medium"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(100, 60)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(22, 13)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(313, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(232, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 35)
        Me.Panel1.TabIndex = 0
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.ForeColor = System.Drawing.Color.White
        Me.lblCurrentUser.Location = New System.Drawing.Point(13, 6)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(179, 17)
        Me.lblCurrentUser.TabIndex = 0
        Me.lblCurrentUser.Text = "Please select a user above"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Select Group Company"
        '
        'frmUserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserManager"
        Me.Text = "Users"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControil1.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        Me.tabDetails.PerformLayout()
        Me.tabAddress.ResumeLayout(False)
        Me.tabAddress.PerformLayout()
        Me.tabDiary.ResumeLayout(False)
        Me.tabDiary.PerformLayout()
        Me.tabAreas.ResumeLayout(False)
        Me.cmnuAreas.ResumeLayout(False)
        Me.tabAgent.ResumeLayout(False)
        Me.tabAgent.PerformLayout()
        Me.TabDistance.ResumeLayout(False)
        Me.TabDistance.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentUser As System.Windows.Forms.Label
    Friend WithEvents lvwUsers As System.Windows.Forms.ListView
    Friend WithEvents colRealName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAccessLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtRealname As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkIncludeInactive As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControil1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDetails As System.Windows.Forms.TabPage
    Friend WithEvents tabDiary As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkAppointment5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAppointment4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAppointment3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAppointment2 As System.Windows.Forms.CheckBox
    Friend WithEvents dtpAppointment5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAppointment4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAppointment3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAppointment2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAppointment1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAppWarn5 As System.Windows.Forms.Label
    Friend WithEvents lblAppWarn4 As System.Windows.Forms.Label
    Friend WithEvents lblAppWarn3 As System.Windows.Forms.Label
    Friend WithEvents lblAppWarn2 As System.Windows.Forms.Label
    Friend WithEvents colUserType As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabAreas As System.Windows.Forms.TabPage
    Friend WithEvents btnAddArea As System.Windows.Forms.Button
    Friend WithEvents lvwAreas As System.Windows.Forms.ListView
    Friend WithEvents colTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnuAreas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAreaRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabAgent As System.Windows.Forms.TabPage
    Friend WithEvents cmbAgentArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabAddress As System.Windows.Forms.TabPage
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress5 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cboMaxApps As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabDistance As System.Windows.Forms.TabPage
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtlongMax As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtMedMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxOK As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboOverrideDiaryWeeks As System.Windows.Forms.ComboBox
    Friend WithEvents colNoColdCalls As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoColdCallsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbGroupCompany As ComboBox
    Friend WithEvents Label14 As Label
End Class
