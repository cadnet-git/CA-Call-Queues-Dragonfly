<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLegacyImport
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
        Me.pnlAreaHeader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblHave = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabSet = New System.Windows.Forms.TabControl()
        Me.TabStats = New System.Windows.Forms.TabPage()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblApps = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LVApps = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LVDups = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LVCB = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbHoldUntil = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboRenewal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbshortBusiness = New System.Windows.Forms.ComboBox()
        Me.cbProvider = New System.Windows.Forms.ComboBox()
        Me.lvSelected = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnChangeAgents = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.FirstRow = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSurname = New System.Windows.Forms.ComboBox()
        Me.cbFirstName = New System.Windows.Forms.ComboBox()
        Me.cbSalutation = New System.Windows.Forms.ComboBox()
        Me.cbtelephone = New System.Windows.Forms.ComboBox()
        Me.cbPostcode = New System.Windows.Forms.ComboBox()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.cboDataProvider = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbGroupCompany = New System.Windows.Forms.ComboBox()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSet.SuspendLayout()
        Me.TabStats.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(770, 48)
        Me.pnlAreaHeader.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.import
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Alternative Data Import"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File to Import"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(85, 58)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(551, 20)
        Me.txtFilename.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(655, 56)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(244, 55)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(13, 13)
        Me.lblNew.TabIndex = 3
        Me.lblNew.Text = "0"
        '
        'lblHave
        '
        Me.lblHave.AutoSize = True
        Me.lblHave.Location = New System.Drawing.Point(244, 76)
        Me.lblHave.Name = "lblHave"
        Me.lblHave.Size = New System.Drawing.Size(13, 13)
        Me.lblHave.TabIndex = 5
        Me.lblHave.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Companies"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Existing Companies"
        '
        'TabSet
        '
        Me.TabSet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSet.Controls.Add(Me.TabStats)
        Me.TabSet.Controls.Add(Me.TabPage2)
        Me.TabSet.Controls.Add(Me.TabPage1)
        Me.TabSet.Controls.Add(Me.TabPage3)
        Me.TabSet.Location = New System.Drawing.Point(10, 549)
        Me.TabSet.Name = "TabSet"
        Me.TabSet.SelectedIndex = 0
        Me.TabSet.Size = New System.Drawing.Size(760, 227)
        Me.TabSet.TabIndex = 11
        '
        'TabStats
        '
        Me.TabStats.Controls.Add(Me.lblAction)
        Me.TabStats.Controls.Add(Me.Label10)
        Me.TabStats.Controls.Add(Me.lblNumbers)
        Me.TabStats.Controls.Add(Me.Label6)
        Me.TabStats.Controls.Add(Me.lblCB)
        Me.TabStats.Controls.Add(Me.Label5)
        Me.TabStats.Controls.Add(Me.lblApps)
        Me.TabStats.Controls.Add(Me.Label3)
        Me.TabStats.Controls.Add(Me.lblNew)
        Me.TabStats.Controls.Add(Me.Label4)
        Me.TabStats.Controls.Add(Me.lblHave)
        Me.TabStats.Location = New System.Drawing.Point(4, 22)
        Me.TabStats.Name = "TabStats"
        Me.TabStats.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStats.Size = New System.Drawing.Size(752, 201)
        Me.TabStats.TabIndex = 0
        Me.TabStats.Text = "Stats"
        Me.TabStats.UseVisualStyleBackColor = True
        '
        'lblAction
        '
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.Red
        Me.lblAction.Location = New System.Drawing.Point(9, 4)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(364, 18)
        Me.lblAction.TabIndex = 12
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(94, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Numbers"
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(244, 28)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(13, 13)
        Me.lblNumbers.TabIndex = 1
        Me.lblNumbers.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Existing Callback"
        '
        'lblCB
        '
        Me.lblCB.AutoSize = True
        Me.lblCB.Location = New System.Drawing.Point(244, 123)
        Me.lblCB.Name = "lblCB"
        Me.lblCB.Size = New System.Drawing.Size(13, 13)
        Me.lblCB.TabIndex = 9
        Me.lblCB.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Existing Appointment"
        '
        'lblApps
        '
        Me.lblApps.AutoSize = True
        Me.lblApps.Location = New System.Drawing.Point(244, 97)
        Me.lblApps.Name = "lblApps"
        Me.lblApps.Size = New System.Drawing.Size(13, 13)
        Me.lblApps.TabIndex = 7
        Me.lblApps.Text = "0"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LVApps)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 201)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appointed"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LVApps
        '
        Me.LVApps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVApps.FullRowSelect = True
        Me.LVApps.GridLines = True
        Me.LVApps.HideSelection = False
        Me.LVApps.Location = New System.Drawing.Point(6, 4)
        Me.LVApps.Name = "LVApps"
        Me.LVApps.Size = New System.Drawing.Size(370, 178)
        Me.LVApps.TabIndex = 0
        Me.LVApps.UseCompatibleStateImageBehavior = False
        Me.LVApps.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Row"
        Me.ColumnHeader3.Width = 38
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Company"
        Me.ColumnHeader4.Width = 328
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LVDups)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 201)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Duplicated"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LVDups
        '
        Me.LVDups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LVDups.FullRowSelect = True
        Me.LVDups.GridLines = True
        Me.LVDups.HideSelection = False
        Me.LVDups.Location = New System.Drawing.Point(6, 4)
        Me.LVDups.Name = "LVDups"
        Me.LVDups.Size = New System.Drawing.Size(370, 178)
        Me.LVDups.TabIndex = 0
        Me.LVDups.UseCompatibleStateImageBehavior = False
        Me.LVDups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Row"
        Me.ColumnHeader6.Width = 38
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Company"
        Me.ColumnHeader7.Width = 328
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LVCB)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(752, 201)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "CallBacks"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LVCB
        '
        Me.LVCB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LVCB.FullRowSelect = True
        Me.LVCB.GridLines = True
        Me.LVCB.HideSelection = False
        Me.LVCB.Location = New System.Drawing.Point(6, 4)
        Me.LVCB.Name = "LVCB"
        Me.LVCB.Size = New System.Drawing.Size(370, 178)
        Me.LVCB.TabIndex = 0
        Me.LVCB.UseCompatibleStateImageBehavior = False
        Me.LVCB.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Row"
        Me.ColumnHeader9.Width = 38
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Company"
        Me.ColumnHeader10.Width = 328
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(370, 178)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Row"
        Me.ColumnHeader5.Width = 38
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Company"
        Me.ColumnHeader8.Width = 328
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.cbHoldUntil)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.cbID)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cboRenewal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cboEmployees)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cbshortBusiness)
        Me.Panel1.Controls.Add(Me.cbProvider)
        Me.Panel1.Controls.Add(Me.lvSelected)
        Me.Panel1.Controls.Add(Me.btnChangeAgents)
        Me.Panel1.Controls.Add(Me.BtnStart)
        Me.Panel1.Controls.Add(Me.FirstRow)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cbPosition)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbSurname)
        Me.Panel1.Controls.Add(Me.cbFirstName)
        Me.Panel1.Controls.Add(Me.cbSalutation)
        Me.Panel1.Controls.Add(Me.cbtelephone)
        Me.Panel1.Controls.Add(Me.cbPostcode)
        Me.Panel1.Controls.Add(Me.cbCompany)
        Me.Panel1.Location = New System.Drawing.Point(15, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 420)
        Me.Panel1.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(36, 381)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Hold Until Date"
        '
        'cbHoldUntil
        '
        Me.cbHoldUntil.DisplayMember = "Title"
        Me.cbHoldUntil.FormattingEnabled = True
        Me.cbHoldUntil.Location = New System.Drawing.Point(124, 378)
        Me.cbHoldUntil.Name = "cbHoldUntil"
        Me.cbHoldUntil.Size = New System.Drawing.Size(222, 21)
        Me.cbHoldUntil.TabIndex = 58
        Me.cbHoldUntil.ValueMember = "Value"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Unique ID"
        '
        'cbID
        '
        Me.cbID.DisplayMember = "Title"
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(124, 5)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(222, 21)
        Me.cbID.TabIndex = 56
        Me.cbID.ValueMember = "Value"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Renewal Date"
        '
        'cboRenewal
        '
        Me.cboRenewal.DisplayMember = "Title"
        Me.cboRenewal.FormattingEnabled = True
        Me.cboRenewal.Location = New System.Drawing.Point(124, 279)
        Me.cboRenewal.Name = "cboRenewal"
        Me.cboRenewal.Size = New System.Drawing.Size(222, 21)
        Me.cboRenewal.TabIndex = 54
        Me.cboRenewal.ValueMember = "Value"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Employees"
        '
        'cboEmployees
        '
        Me.cboEmployees.DisplayMember = "Title"
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Location = New System.Drawing.Point(124, 351)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(222, 21)
        Me.cboEmployees.TabIndex = 52
        Me.cboEmployees.ValueMember = "Value"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 326)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Business Type (Short)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(72, 259)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Provider"
        '
        'cbshortBusiness
        '
        Me.cbshortBusiness.DisplayMember = "Title"
        Me.cbshortBusiness.FormattingEnabled = True
        Me.cbshortBusiness.Location = New System.Drawing.Point(124, 322)
        Me.cbshortBusiness.Name = "cbshortBusiness"
        Me.cbshortBusiness.Size = New System.Drawing.Size(222, 21)
        Me.cbshortBusiness.TabIndex = 47
        Me.cbshortBusiness.ValueMember = "Value"
        '
        'cbProvider
        '
        Me.cbProvider.DisplayMember = "Title"
        Me.cbProvider.FormattingEnabled = True
        Me.cbProvider.Location = New System.Drawing.Point(124, 255)
        Me.cbProvider.Name = "cbProvider"
        Me.cbProvider.Size = New System.Drawing.Size(222, 21)
        Me.cbProvider.TabIndex = 44
        Me.cbProvider.ValueMember = "Value"
        '
        'lvSelected
        '
        Me.lvSelected.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvSelected.FullRowSelect = True
        Me.lvSelected.GridLines = True
        Me.lvSelected.HideSelection = False
        Me.lvSelected.Location = New System.Drawing.Point(433, 210)
        Me.lvSelected.Name = "lvSelected"
        Me.lvSelected.Size = New System.Drawing.Size(165, 104)
        Me.lvSelected.TabIndex = 42
        Me.lvSelected.UseCompatibleStateImageBehavior = False
        Me.lvSelected.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Selected Agents"
        Me.ColumnHeader2.Width = 160
        '
        'btnChangeAgents
        '
        Me.btnChangeAgents.Location = New System.Drawing.Point(604, 210)
        Me.btnChangeAgents.Name = "btnChangeAgents"
        Me.btnChangeAgents.Size = New System.Drawing.Size(103, 25)
        Me.btnChangeAgents.TabIndex = 43
        Me.btnChangeAgents.Text = "Change Agents"
        Me.btnChangeAgents.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(422, 330)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(222, 43)
        Me.BtnStart.TabIndex = 41
        Me.BtnStart.Text = "Start Import"
        Me.BtnStart.UseVisualStyleBackColor = True
        Me.BtnStart.Visible = False
        '
        'FirstRow
        '
        Me.FirstRow.AutoSize = True
        Me.FirstRow.Location = New System.Drawing.Point(433, 187)
        Me.FirstRow.Name = "FirstRow"
        Me.FirstRow.Size = New System.Drawing.Size(116, 17)
        Me.FirstRow.TabIndex = 40
        Me.FirstRow.Text = "First Row are Titles"
        Me.FirstRow.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(72, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Position"
        '
        'cbPosition
        '
        Me.cbPosition.DisplayMember = "Title"
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Location = New System.Drawing.Point(124, 209)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(222, 21)
        Me.cbPosition.TabIndex = 38
        Me.cbPosition.ValueMember = "Value"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(67, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Surname"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(59, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "First Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(62, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Salutation"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Postcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Company"
        '
        'cbSurname
        '
        Me.cbSurname.DisplayMember = "Title"
        Me.cbSurname.FormattingEnabled = True
        Me.cbSurname.Location = New System.Drawing.Point(124, 181)
        Me.cbSurname.Name = "cbSurname"
        Me.cbSurname.Size = New System.Drawing.Size(222, 21)
        Me.cbSurname.TabIndex = 31
        Me.cbSurname.ValueMember = "Value"
        '
        'cbFirstName
        '
        Me.cbFirstName.DisplayMember = "Title"
        Me.cbFirstName.FormattingEnabled = True
        Me.cbFirstName.Location = New System.Drawing.Point(124, 155)
        Me.cbFirstName.Name = "cbFirstName"
        Me.cbFirstName.Size = New System.Drawing.Size(222, 21)
        Me.cbFirstName.TabIndex = 30
        Me.cbFirstName.ValueMember = "Value"
        '
        'cbSalutation
        '
        Me.cbSalutation.DisplayMember = "Title"
        Me.cbSalutation.FormattingEnabled = True
        Me.cbSalutation.Location = New System.Drawing.Point(124, 129)
        Me.cbSalutation.Name = "cbSalutation"
        Me.cbSalutation.Size = New System.Drawing.Size(222, 21)
        Me.cbSalutation.TabIndex = 29
        Me.cbSalutation.ValueMember = "Value"
        '
        'cbtelephone
        '
        Me.cbtelephone.DisplayMember = "Title"
        Me.cbtelephone.FormattingEnabled = True
        Me.cbtelephone.Location = New System.Drawing.Point(124, 84)
        Me.cbtelephone.Name = "cbtelephone"
        Me.cbtelephone.Size = New System.Drawing.Size(222, 21)
        Me.cbtelephone.TabIndex = 28
        Me.cbtelephone.ValueMember = "Value"
        '
        'cbPostcode
        '
        Me.cbPostcode.DisplayMember = "Title"
        Me.cbPostcode.FormattingEnabled = True
        Me.cbPostcode.Location = New System.Drawing.Point(124, 58)
        Me.cbPostcode.Name = "cbPostcode"
        Me.cbPostcode.Size = New System.Drawing.Size(222, 21)
        Me.cbPostcode.TabIndex = 27
        Me.cbPostcode.ValueMember = "Value"
        '
        'cbCompany
        '
        Me.cbCompany.DisplayMember = "Title"
        Me.cbCompany.FormattingEnabled = True
        Me.cbCompany.Location = New System.Drawing.Point(124, 32)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(222, 21)
        Me.cbCompany.TabIndex = 26
        Me.cbCompany.ValueMember = "Value"
        '
        'cboDataProvider
        '
        Me.cboDataProvider.DisplayMember = "Title"
        Me.cboDataProvider.FormattingEnabled = True
        Me.cboDataProvider.Items.AddRange(New Object() {"", "ML", "Other"})
        Me.cboDataProvider.Location = New System.Drawing.Point(85, 84)
        Me.cboDataProvider.Name = "cboDataProvider"
        Me.cboDataProvider.Size = New System.Drawing.Size(222, 21)
        Me.cboDataProvider.TabIndex = 57
        Me.cboDataProvider.ValueMember = "Value"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Data Provider"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(327, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Group Company"
        '
        'cbGroupCompany
        '
        Me.cbGroupCompany.DisplayMember = "Title"
        Me.cbGroupCompany.FormattingEnabled = True
        Me.cbGroupCompany.Items.AddRange(New Object() {"", "ML", "Other"})
        Me.cbGroupCompany.Location = New System.Drawing.Point(414, 84)
        Me.cbGroupCompany.Name = "cbGroupCompany"
        Me.cbGroupCompany.Size = New System.Drawing.Size(222, 21)
        Me.cbGroupCompany.TabIndex = 59
        Me.cbGroupCompany.ValueMember = "Value"
        '
        'frmLegacyImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 796)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbGroupCompany)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboDataProvider)
        Me.Controls.Add(Me.TabSet)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLegacyImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLegacyImport"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSet.ResumeLayout(False)
        Me.TabStats.ResumeLayout(False)
        Me.TabStats.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblHave As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabSet As System.Windows.Forms.TabControl
    Friend WithEvents TabStats As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblApps As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LVDups As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVApps As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LVCB As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCB As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSurname As System.Windows.Forms.ComboBox
    Friend WithEvents cbFirstName As System.Windows.Forms.ComboBox
    Friend WithEvents cbSalutation As System.Windows.Forms.ComboBox
    Friend WithEvents cbtelephone As System.Windows.Forms.ComboBox
    Friend WithEvents cbPostcode As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents FirstRow As System.Windows.Forms.CheckBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents lvSelected As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChangeAgents As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbshortBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvider As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboEmployees As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboRenewal As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cbID As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbHoldUntil As ComboBox
    Friend WithEvents cboDataProvider As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbGroupCompany As ComboBox
End Class
