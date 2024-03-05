<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgent))
        Me.tmrStartup = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pnlScriptContainer = New System.Windows.Forms.Panel()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.pnlCompanyInfo = New System.Windows.Forms.Panel()
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
        Me.cmbEmployees = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMobile = New System.Windows.Forms.Button()
        Me.BtnDialDirect = New System.Windows.Forms.Button()
        Me.BtnDialMain = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDirectDial = New System.Windows.Forms.TextBox()
        Me.lblSDM = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactPosition = New System.Windows.Forms.ComboBox()
        Me.btnEmulatedisconnect = New System.Windows.Forms.Button()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.btnChangeTelephone = New System.Windows.Forms.Button()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblAddress3 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblRepName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtContactSurname = New System.Windows.Forms.TextBox()
        Me.lblMagicNumber = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblAreaLbl = New System.Windows.Forms.Label()
        Me.txtContactForeName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPolExp = New System.Windows.Forms.Label()
        Me.lblTelLabel = New System.Windows.Forms.Label()
        Me.lblPostcodelbl = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblPolProv = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPolicyExpiry = New System.Windows.Forms.Label()
        Me.lblPolicyProvider = New System.Windows.Forms.Label()
        Me.lblTownTitle = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblCountyTitle = New System.Windows.Forms.Label()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TVInfo = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rtfViewer = New DevExpress.XtraRichEdit.RichEditControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcViewer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcButton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcTree = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CmbNextAction = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStatus = New System.Windows.Forms.ToolStripLabel()
        Me.tslGroupCompany = New System.Windows.Forms.ToolStripLabel()
        Me.TimeTick = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pnlScriptContainer.SuspendLayout()
        Me.pnlCompanyInfo.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrStartup
        '
        Me.tmrStartup.Interval = 500
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1506, 673)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1506, 673)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.LayoutControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1506, 673)
        Me.SplitContainer1.SplitterDistance = 1078
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.pnlScriptContainer)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlCompanyInfo)
        Me.SplitContainer2.Size = New System.Drawing.Size(1078, 673)
        Me.SplitContainer2.SplitterDistance = 235
        Me.SplitContainer2.TabIndex = 0
        '
        'pnlScriptContainer
        '
        Me.pnlScriptContainer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlScriptContainer.Controls.Add(Me.lblPleaseWait)
        Me.pnlScriptContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlScriptContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlScriptContainer.Name = "pnlScriptContainer"
        Me.pnlScriptContainer.Size = New System.Drawing.Size(1078, 235)
        Me.pnlScriptContainer.TabIndex = 0
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Location = New System.Drawing.Point(258, 131)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(179, 13)
        Me.lblPleaseWait.TabIndex = 0
        Me.lblPleaseWait.Text = "Please Wait.... Connecting to Server"
        '
        'pnlCompanyInfo
        '
        Me.pnlCompanyInfo.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCompanyInfo.Controls.Add(Me.btnSetConsent)
        Me.pnlCompanyInfo.Controls.Add(Me.cboLegalEntity)
        Me.pnlCompanyInfo.Controls.Add(Me.Label14)
        Me.pnlCompanyInfo.Controls.Add(Me.lblconsentt4)
        Me.pnlCompanyInfo.Controls.Add(Me.lblConsentUntil)
        Me.pnlCompanyInfo.Controls.Add(Me.lblconsentt3)
        Me.pnlCompanyInfo.Controls.Add(Me.lblconsentt2)
        Me.pnlCompanyInfo.Controls.Add(Me.lblconsentt1)
        Me.pnlCompanyInfo.Controls.Add(Me.lblConsentDate)
        Me.pnlCompanyInfo.Controls.Add(Me.lblConsentPosition)
        Me.pnlCompanyInfo.Controls.Add(Me.lblConsentGivenBy)
        Me.pnlCompanyInfo.Controls.Add(Me.cmbEmployees)
        Me.pnlCompanyInfo.Controls.Add(Me.Label4)
        Me.pnlCompanyInfo.Controls.Add(Me.BtnMobile)
        Me.pnlCompanyInfo.Controls.Add(Me.BtnDialDirect)
        Me.pnlCompanyInfo.Controls.Add(Me.BtnDialMain)
        Me.pnlCompanyInfo.Controls.Add(Me.Label5)
        Me.pnlCompanyInfo.Controls.Add(Me.txtMobile)
        Me.pnlCompanyInfo.Controls.Add(Me.Label2)
        Me.pnlCompanyInfo.Controls.Add(Me.txtDirectDial)
        Me.pnlCompanyInfo.Controls.Add(Me.lblSDM)
        Me.pnlCompanyInfo.Controls.Add(Me.Label3)
        Me.pnlCompanyInfo.Controls.Add(Me.txtContactPosition)
        Me.pnlCompanyInfo.Controls.Add(Me.btnEmulatedisconnect)
        Me.pnlCompanyInfo.Controls.Add(Me.lblTel)
        Me.pnlCompanyInfo.Controls.Add(Me.btnChangeTelephone)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPostcode)
        Me.pnlCompanyInfo.Controls.Add(Me.cmbTitle)
        Me.pnlCompanyInfo.Controls.Add(Me.lblCounty)
        Me.pnlCompanyInfo.Controls.Add(Me.lblTown)
        Me.pnlCompanyInfo.Controls.Add(Me.lblAddress3)
        Me.pnlCompanyInfo.Controls.Add(Me.lblAddress2)
        Me.pnlCompanyInfo.Controls.Add(Me.lblAddress1)
        Me.pnlCompanyInfo.Controls.Add(Me.lblCounter)
        Me.pnlCompanyInfo.Controls.Add(Me.Label1)
        Me.pnlCompanyInfo.Controls.Add(Me.lbltitle)
        Me.pnlCompanyInfo.Controls.Add(Me.lvHistory)
        Me.pnlCompanyInfo.Controls.Add(Me.txtNotes)
        Me.pnlCompanyInfo.Controls.Add(Me.lblRep)
        Me.pnlCompanyInfo.Controls.Add(Me.txtCompanyName)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPosition)
        Me.pnlCompanyInfo.Controls.Add(Me.lblRepName)
        Me.pnlCompanyInfo.Controls.Add(Me.lblSurname)
        Me.pnlCompanyInfo.Controls.Add(Me.txtContactSurname)
        Me.pnlCompanyInfo.Controls.Add(Me.lblMagicNumber)
        Me.pnlCompanyInfo.Controls.Add(Me.lblForename)
        Me.pnlCompanyInfo.Controls.Add(Me.lblAreaLbl)
        Me.pnlCompanyInfo.Controls.Add(Me.txtContactForeName)
        Me.pnlCompanyInfo.Controls.Add(Me.txtEmail)
        Me.pnlCompanyInfo.Controls.Add(Me.lblEmail)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPolExp)
        Me.pnlCompanyInfo.Controls.Add(Me.lblTelLabel)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPostcodelbl)
        Me.pnlCompanyInfo.Controls.Add(Me.txtFax)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPolProv)
        Me.pnlCompanyInfo.Controls.Add(Me.lblFax)
        Me.pnlCompanyInfo.Controls.Add(Me.lblArea)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPolicyExpiry)
        Me.pnlCompanyInfo.Controls.Add(Me.lblPolicyProvider)
        Me.pnlCompanyInfo.Controls.Add(Me.lblTownTitle)
        Me.pnlCompanyInfo.Controls.Add(Me.lblAddress)
        Me.pnlCompanyInfo.Controls.Add(Me.lblCompany)
        Me.pnlCompanyInfo.Controls.Add(Me.lblCountyTitle)
        Me.pnlCompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCompanyInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlCompanyInfo.Name = "pnlCompanyInfo"
        Me.pnlCompanyInfo.Size = New System.Drawing.Size(1078, 434)
        Me.pnlCompanyInfo.TabIndex = 0
        '
        'btnSetConsent
        '
        Me.btnSetConsent.Location = New System.Drawing.Point(937, 187)
        Me.btnSetConsent.Name = "btnSetConsent"
        Me.btnSetConsent.Size = New System.Drawing.Size(129, 33)
        Me.btnSetConsent.TabIndex = 68
        Me.btnSetConsent.Text = "Set Consent"
        Me.btnSetConsent.UseVisualStyleBackColor = True
        '
        'cboLegalEntity
        '
        Me.cboLegalEntity.DisplayMember = "Title"
        Me.cboLegalEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLegalEntity.FormattingEnabled = True
        Me.cboLegalEntity.Location = New System.Drawing.Point(937, 37)
        Me.cboLegalEntity.Name = "cboLegalEntity"
        Me.cboLegalEntity.Size = New System.Drawing.Size(129, 21)
        Me.cboLegalEntity.TabIndex = 67
        Me.cboLegalEntity.ValueMember = "value"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(865, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Legal Entity:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt4
        '
        Me.lblconsentt4.AutoSize = True
        Me.lblconsentt4.Location = New System.Drawing.Point(860, 159)
        Me.lblconsentt4.Name = "lblconsentt4"
        Me.lblconsentt4.Size = New System.Drawing.Size(70, 13)
        Me.lblconsentt4.TabIndex = 65
        Me.lblconsentt4.Text = "Consent Until"
        Me.lblconsentt4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConsentUntil
        '
        Me.lblConsentUntil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentUntil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentUntil.Location = New System.Drawing.Point(936, 157)
        Me.lblConsentUntil.Name = "lblConsentUntil"
        Me.lblConsentUntil.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentUntil.TabIndex = 64
        Me.lblConsentUntil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblconsentt3
        '
        Me.lblconsentt3.AutoSize = True
        Me.lblconsentt3.Location = New System.Drawing.Point(858, 132)
        Me.lblconsentt3.Name = "lblconsentt3"
        Me.lblconsentt3.Size = New System.Drawing.Size(72, 13)
        Me.lblconsentt3.TabIndex = 63
        Me.lblconsentt3.Text = "Consent Date"
        Me.lblconsentt3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt2
        '
        Me.lblconsentt2.AutoSize = True
        Me.lblconsentt2.Location = New System.Drawing.Point(844, 105)
        Me.lblconsentt2.Name = "lblconsentt2"
        Me.lblconsentt2.Size = New System.Drawing.Size(86, 13)
        Me.lblconsentt2.TabIndex = 62
        Me.lblconsentt2.Text = "Consent Position"
        Me.lblconsentt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblconsentt1
        '
        Me.lblconsentt1.AutoSize = True
        Me.lblconsentt1.Location = New System.Drawing.Point(870, 80)
        Me.lblconsentt1.Name = "lblconsentt1"
        Me.lblconsentt1.Size = New System.Drawing.Size(60, 13)
        Me.lblconsentt1.TabIndex = 61
        Me.lblconsentt1.Text = "Consent by"
        Me.lblconsentt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConsentDate
        '
        Me.lblConsentDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentDate.Location = New System.Drawing.Point(936, 131)
        Me.lblConsentDate.Name = "lblConsentDate"
        Me.lblConsentDate.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentDate.TabIndex = 60
        Me.lblConsentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConsentPosition
        '
        Me.lblConsentPosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentPosition.Location = New System.Drawing.Point(936, 105)
        Me.lblConsentPosition.Name = "lblConsentPosition"
        Me.lblConsentPosition.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentPosition.TabIndex = 59
        Me.lblConsentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConsentGivenBy
        '
        Me.lblConsentGivenBy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConsentGivenBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsentGivenBy.Location = New System.Drawing.Point(936, 80)
        Me.lblConsentGivenBy.Name = "lblConsentGivenBy"
        Me.lblConsentGivenBy.Size = New System.Drawing.Size(130, 20)
        Me.lblConsentGivenBy.TabIndex = 58
        Me.lblConsentGivenBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEmployees
        '
        Me.cmbEmployees.FormattingEnabled = True
        Me.cmbEmployees.Items.AddRange(New Object() {"", "1-10", "11-25", "26-50", "50-99", "100-250", "250+"})
        Me.cmbEmployees.Location = New System.Drawing.Point(659, 92)
        Me.cmbEmployees.Name = "cmbEmployees"
        Me.cmbEmployees.Size = New System.Drawing.Size(132, 21)
        Me.cmbEmployees.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(590, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Employees:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnMobile
        '
        Me.BtnMobile.Location = New System.Drawing.Point(273, 207)
        Me.BtnMobile.Name = "BtnMobile"
        Me.BtnMobile.Size = New System.Drawing.Size(45, 23)
        Me.BtnMobile.TabIndex = 55
        Me.BtnMobile.Text = "Call"
        Me.BtnMobile.UseVisualStyleBackColor = True
        '
        'BtnDialDirect
        '
        Me.BtnDialDirect.Location = New System.Drawing.Point(273, 180)
        Me.BtnDialDirect.Name = "BtnDialDirect"
        Me.BtnDialDirect.Size = New System.Drawing.Size(45, 23)
        Me.BtnDialDirect.TabIndex = 54
        Me.BtnDialDirect.Text = "Call"
        Me.BtnDialDirect.UseVisualStyleBackColor = True
        '
        'BtnDialMain
        '
        Me.BtnDialMain.Location = New System.Drawing.Point(273, 153)
        Me.BtnDialMain.Name = "BtnDialMain"
        Me.BtnDialMain.Size = New System.Drawing.Size(45, 23)
        Me.BtnDialMain.TabIndex = 53
        Me.BtnDialMain.Text = "Call"
        Me.BtnDialMain.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Mobile Tel:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(71, 205)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(196, 20)
        Me.txtMobile.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Direct Tel :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDirectDial
        '
        Me.txtDirectDial.Location = New System.Drawing.Point(71, 179)
        Me.txtDirectDial.Name = "txtDirectDial"
        Me.txtDirectDial.Size = New System.Drawing.Size(196, 20)
        Me.txtDirectDial.TabIndex = 50
        '
        'lblSDM
        '
        Me.lblSDM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSDM.Location = New System.Drawing.Point(392, 210)
        Me.lblSDM.Name = "lblSDM"
        Me.lblSDM.Size = New System.Drawing.Size(399, 20)
        Me.lblSDM.TabIndex = 46
        Me.lblSDM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "SDM:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Items.AddRange(New Object() {"Accounts Manager", "Commercial Director", "Company Accountant", "Company Director", "Company Secretary ", "Director", "Finance Director", "Finance Manager", "Finance Officer", "Financial Controller", "HR Director", "HR Manager", "HR Officer", "Managing Director", "Office Manager", "Owner", "Partner", "Practice Manager", "Proprietor"})
        Me.txtContactPosition.Location = New System.Drawing.Point(68, 126)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(250, 21)
        Me.txtContactPosition.TabIndex = 44
        '
        'btnEmulatedisconnect
        '
        Me.btnEmulatedisconnect.BackColor = System.Drawing.SystemColors.Control
        Me.btnEmulatedisconnect.Location = New System.Drawing.Point(8, 252)
        Me.btnEmulatedisconnect.Name = "btnEmulatedisconnect"
        Me.btnEmulatedisconnect.Size = New System.Drawing.Size(54, 23)
        Me.btnEmulatedisconnect.TabIndex = 43
        Me.btnEmulatedisconnect.Text = "Disconnect Call"
        Me.btnEmulatedisconnect.UseVisualStyleBackColor = False
        Me.btnEmulatedisconnect.Visible = False
        '
        'lblTel
        '
        Me.lblTel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTel.Location = New System.Drawing.Point(136, 154)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(132, 20)
        Me.lblTel.TabIndex = 42
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChangeTelephone
        '
        Me.btnChangeTelephone.Location = New System.Drawing.Point(69, 153)
        Me.btnChangeTelephone.Name = "btnChangeTelephone"
        Me.btnChangeTelephone.Size = New System.Drawing.Size(61, 23)
        Me.btnChangeTelephone.TabIndex = 41
        Me.btnChangeTelephone.Text = "Change"
        Me.btnChangeTelephone.UseVisualStyleBackColor = True
        '
        'lblPostcode
        '
        Me.lblPostcode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostcode.Location = New System.Drawing.Point(393, 129)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(92, 20)
        Me.lblPostcode.TabIndex = 40
        Me.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Ms", "Dr", "Rev", ""})
        Me.cmbTitle.Location = New System.Drawing.Point(68, 50)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(250, 21)
        Me.cmbTitle.TabIndex = 2
        '
        'lblCounty
        '
        Me.lblCounty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounty.Location = New System.Drawing.Point(393, 105)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(180, 20)
        Me.lblCounty.TabIndex = 30
        Me.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTown
        '
        Me.lblTown.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTown.Location = New System.Drawing.Point(393, 80)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(180, 20)
        Me.lblTown.TabIndex = 24
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress3
        '
        Me.lblAddress3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress3.Location = New System.Drawing.Point(874, 366)
        Me.lblAddress3.Name = "lblAddress3"
        Me.lblAddress3.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress3.TabIndex = 18
        Me.lblAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddress3.Visible = False
        '
        'lblAddress2
        '
        Me.lblAddress2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress2.Location = New System.Drawing.Point(874, 341)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress2.TabIndex = 15
        Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddress2.Visible = False
        '
        'lblAddress1
        '
        Me.lblAddress1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress1.Location = New System.Drawing.Point(392, 55)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(180, 20)
        Me.lblAddress1.TabIndex = 10
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCounter
        '
        Me.lblCounter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCounter.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(0, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(1078, 24)
        Me.lblCounter.TabIndex = 0
        Me.lblCounter.Text = "Details"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Note:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(35, 54)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(30, 13)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "Title:"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lvHistory
        '
        Me.lvHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvHistory.GridLines = True
        Me.lvHistory.HideSelection = False
        Me.lvHistory.Location = New System.Drawing.Point(8, 281)
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(1058, 150)
        Me.lvHistory.TabIndex = 39
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Agent"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "When"
        Me.ColumnHeader2.Width = 108
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Original State"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ending State"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Additional Information"
        Me.ColumnHeader5.Width = 288
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(68, 233)
        Me.txtNotes.MaxLength = 400
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(998, 42)
        Me.txtNotes.TabIndex = 38
        '
        'lblRep
        '
        Me.lblRep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRep.Location = New System.Drawing.Point(661, 132)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(130, 20)
        Me.lblRep.TabIndex = 20
        Me.lblRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(69, 27)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(435, 20)
        Me.txtCompanyName.TabIndex = 4
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(18, 129)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 16
        Me.lblPosition.Text = "Position:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRepName
        '
        Me.lblRepName.AutoSize = True
        Me.lblRepName.Location = New System.Drawing.Point(598, 135)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(61, 13)
        Me.lblRepName.TabIndex = 19
        Me.lblRepName.Text = "Rep Name:"
        Me.lblRepName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(13, 104)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 13
        Me.lblSurname.Text = "Surname:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactSurname
        '
        Me.txtContactSurname.Location = New System.Drawing.Point(68, 102)
        Me.txtContactSurname.Name = "txtContactSurname"
        Me.txtContactSurname.Size = New System.Drawing.Size(250, 20)
        Me.txtContactSurname.TabIndex = 14
        '
        'lblMagicNumber
        '
        Me.lblMagicNumber.AutoSize = True
        Me.lblMagicNumber.Location = New System.Drawing.Point(658, 190)
        Me.lblMagicNumber.Name = "lblMagicNumber"
        Me.lblMagicNumber.Size = New System.Drawing.Size(76, 13)
        Me.lblMagicNumber.TabIndex = 31
        Me.lblMagicNumber.Text = "Magic Number"
        Me.lblMagicNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMagicNumber.Visible = False
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(8, 79)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(57, 13)
        Me.lblForename.TabIndex = 9
        Me.lblForename.Text = "Forename:"
        Me.lblForename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAreaLbl
        '
        Me.lblAreaLbl.AutoSize = True
        Me.lblAreaLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAreaLbl.Location = New System.Drawing.Point(627, 160)
        Me.lblAreaLbl.Name = "lblAreaLbl"
        Me.lblAreaLbl.Size = New System.Drawing.Size(32, 13)
        Me.lblAreaLbl.TabIndex = 25
        Me.lblAreaLbl.Text = "Area:"
        Me.lblAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactForeName
        '
        Me.txtContactForeName.Location = New System.Drawing.Point(68, 76)
        Me.txtContactForeName.Name = "txtContactForeName"
        Me.txtContactForeName.Size = New System.Drawing.Size(250, 20)
        Me.txtContactForeName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(393, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 33
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(355, 184)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPolExp
        '
        Me.lblPolExp.AutoSize = True
        Me.lblPolExp.Location = New System.Drawing.Point(590, 58)
        Me.lblPolExp.Name = "lblPolExp"
        Me.lblPolExp.Size = New System.Drawing.Size(69, 13)
        Me.lblPolExp.TabIndex = 11
        Me.lblPolExp.Text = "Policy Expiry:"
        Me.lblPolExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelLabel
        '
        Me.lblTelLabel.AutoSize = True
        Me.lblTelLabel.Location = New System.Drawing.Point(6, 158)
        Me.lblTelLabel.Name = "lblTelLabel"
        Me.lblTelLabel.Size = New System.Drawing.Size(51, 13)
        Me.lblTelLabel.TabIndex = 21
        Me.lblTelLabel.Text = "Main Tel:"
        Me.lblTelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPostcodelbl
        '
        Me.lblPostcodelbl.AutoSize = True
        Me.lblPostcodelbl.Location = New System.Drawing.Point(335, 132)
        Me.lblPostcodelbl.Name = "lblPostcodelbl"
        Me.lblPostcodelbl.Size = New System.Drawing.Size(55, 13)
        Me.lblPostcodelbl.TabIndex = 34
        Me.lblPostcodelbl.Text = "Postcode:"
        Me.lblPostcodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(393, 157)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(180, 20)
        Me.txtFax.TabIndex = 28
        '
        'lblPolProv
        '
        Me.lblPolProv.AutoSize = True
        Me.lblPolProv.Location = New System.Drawing.Point(610, 33)
        Me.lblPolProv.Name = "lblPolProv"
        Me.lblPolProv.Size = New System.Drawing.Size(49, 13)
        Me.lblPolProv.TabIndex = 5
        Me.lblPolProv.Text = "Provider:"
        Me.lblPolProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(363, 159)
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
        Me.lblArea.Location = New System.Drawing.Point(661, 157)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(130, 20)
        Me.lblArea.TabIndex = 26
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyExpiry
        '
        Me.lblPolicyExpiry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPolicyExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyExpiry.Location = New System.Drawing.Point(661, 55)
        Me.lblPolicyExpiry.Name = "lblPolicyExpiry"
        Me.lblPolicyExpiry.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyExpiry.TabIndex = 12
        Me.lblPolicyExpiry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolicyProvider
        '
        Me.lblPolicyProvider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPolicyProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPolicyProvider.Location = New System.Drawing.Point(661, 30)
        Me.lblPolicyProvider.Name = "lblPolicyProvider"
        Me.lblPolicyProvider.Size = New System.Drawing.Size(130, 20)
        Me.lblPolicyProvider.TabIndex = 6
        Me.lblPolicyProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTownTitle
        '
        Me.lblTownTitle.AutoSize = True
        Me.lblTownTitle.Location = New System.Drawing.Point(353, 83)
        Me.lblTownTitle.Name = "lblTownTitle"
        Me.lblTownTitle.Size = New System.Drawing.Size(37, 13)
        Me.lblTownTitle.TabIndex = 23
        Me.lblTownTitle.Text = "Town:"
        Me.lblTownTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(342, 58)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(11, 30)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(54, 13)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Company:"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountyTitle
        '
        Me.lblCountyTitle.AutoSize = True
        Me.lblCountyTitle.Location = New System.Drawing.Point(347, 108)
        Me.lblCountyTitle.Name = "lblCountyTitle"
        Me.lblCountyTitle.Size = New System.Drawing.Size(43, 13)
        Me.lblCountyTitle.TabIndex = 29
        Me.lblCountyTitle.Text = "County:"
        Me.lblCountyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TVInfo)
        Me.LayoutControl1.Controls.Add(Me.Button1)
        Me.LayoutControl1.Controls.Add(Me.rtfViewer)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1843, 93, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(424, 673)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TVInfo
        '
        Me.TVInfo.Location = New System.Drawing.Point(12, 12)
        Me.TVInfo.Name = "TVInfo"
        Me.TVInfo.Size = New System.Drawing.Size(124, 625)
        Me.TVInfo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rtfViewer
        '
        Me.rtfViewer.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
        Me.rtfViewer.Appearance.Text.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfViewer.Appearance.Text.Options.UseFont = True
        Me.rtfViewer.DragDropMode = DevExpress.XtraRichEdit.DragDropMode.Manual
        Me.rtfViewer.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
        Me.rtfViewer.Location = New System.Drawing.Point(140, 12)
        Me.rtfViewer.Name = "rtfViewer"
        Me.rtfViewer.Options.Behavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Disabled
        Me.rtfViewer.Options.FormattingMarkVisibility.HiddenText = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.Hidden
        Me.rtfViewer.Options.FormattingMarkVisibility.ParagraphMark = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.Hidden
        Me.rtfViewer.Options.FormattingMarkVisibility.Separator = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.Hidden
        Me.rtfViewer.Options.FormattingMarkVisibility.Space = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.Hidden
        Me.rtfViewer.Options.FormattingMarkVisibility.TabCharacter = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.Hidden
        Me.rtfViewer.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me.rtfViewer.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
        Me.rtfViewer.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me.rtfViewer.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
        Me.rtfViewer.ReadOnly = True
        Me.rtfViewer.Size = New System.Drawing.Size(272, 625)
        Me.rtfViewer.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcViewer, Me.lcButton, Me.lcTree})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(424, 673)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lcViewer
        '
        Me.lcViewer.Control = Me.rtfViewer
        Me.lcViewer.CustomizationFormText = "lcViewer"
        Me.lcViewer.Location = New System.Drawing.Point(128, 0)
        Me.lcViewer.Name = "lcViewer"
        Me.lcViewer.Size = New System.Drawing.Size(276, 629)
        Me.lcViewer.TextSize = New System.Drawing.Size(0, 0)
        Me.lcViewer.TextVisible = False
        Me.lcViewer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lcButton
        '
        Me.lcButton.Control = Me.Button1
        Me.lcButton.CustomizationFormText = "lcButton"
        Me.lcButton.Location = New System.Drawing.Point(0, 629)
        Me.lcButton.Name = "lcButton"
        Me.lcButton.Size = New System.Drawing.Size(404, 24)
        Me.lcButton.TextSize = New System.Drawing.Size(0, 0)
        Me.lcButton.TextVisible = False
        Me.lcButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lcTree
        '
        Me.lcTree.Control = Me.TVInfo
        Me.lcTree.CustomizationFormText = "lcTree"
        Me.lcTree.Location = New System.Drawing.Point(0, 0)
        Me.lcTree.Name = "lcTree"
        Me.lcTree.Size = New System.Drawing.Size(128, 629)
        Me.lcTree.TextSize = New System.Drawing.Size(0, 0)
        Me.lcTree.TextVisible = False
        '
        'CountDown
        '
        Me.CountDown.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.CmbNextAction, Me.ToolStripSeparator1, Me.ToolStatus, Me.tslGroupCompany})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 673)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1506, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 22)
        Me.lblTime.Text = "12:00"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "Next Action"
        '
        'CmbNextAction
        '
        Me.CmbNextAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNextAction.Items.AddRange(New Object() {"Bins", "Break", "Lunch", "Toilet Break", "Washing Up", "Water", "With Manager", "Group Meeting", "Logoff"})
        Me.CmbNextAction.MaxDropDownItems = 9
        Me.CmbNextAction.Name = "CmbNextAction"
        Me.CmbNextAction.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStatus
        '
        Me.ToolStatus.Name = "ToolStatus"
        Me.ToolStatus.Size = New System.Drawing.Size(59, 22)
        Me.ToolStatus.Text = "EndStatus"
        '
        'tslGroupCompany
        '
        Me.tslGroupCompany.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslGroupCompany.Name = "tslGroupCompany"
        Me.tslGroupCompany.Size = New System.Drawing.Size(39, 22)
        Me.tslGroupCompany.Text = "group"
        '
        'TimeTick
        '
        Me.TimeTick.Enabled = True
        Me.TimeTick.Interval = 1000
        '
        'frmAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1506, 698)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CQ Agent"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pnlScriptContainer.ResumeLayout(False)
        Me.pnlScriptContainer.PerformLayout()
        Me.pnlCompanyInfo.ResumeLayout(False)
        Me.pnlCompanyInfo.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrStartup As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlCompanyInfo As System.Windows.Forms.Panel
    Friend WithEvents pnlScriptContainer As System.Windows.Forms.Panel
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents lblAreaLbl As System.Windows.Forms.Label
    Friend WithEvents lblRep As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPolProv As System.Windows.Forms.Label
    Friend WithEvents lblPolExp As System.Windows.Forms.Label
    Friend WithEvents lblPolicyExpiry As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lvHistory As System.Windows.Forms.ListView
    Friend WithEvents lblPolicyProvider As System.Windows.Forms.Label
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents TVInfo As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMagicNumber As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblPostcodelbl As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblCountyTitle As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblTownTitle As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtContactForeName As System.Windows.Forms.TextBox
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtContactSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CountDown As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbNextAction As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress3 As System.Windows.Forms.Label
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents btnChangeTelephone As System.Windows.Forms.Button
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents btnEmulatedisconnect As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TimeTick As System.Windows.Forms.Timer
    Friend WithEvents txtContactPosition As System.Windows.Forms.ComboBox
    Friend WithEvents lblSDM As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnMobile As System.Windows.Forms.Button
    Friend WithEvents BtnDialDirect As System.Windows.Forms.Button
    Friend WithEvents BtnDialMain As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDirectDial As System.Windows.Forms.TextBox
    Friend WithEvents lblTelLabel As System.Windows.Forms.Label
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents rtfViewer As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcViewer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcButton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcTree As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents lblconsentt1 As Label
    Friend WithEvents lblConsentDate As Label
    Friend WithEvents lblConsentPosition As Label
    Friend WithEvents lblConsentGivenBy As Label
    Friend WithEvents lblconsentt3 As Label
    Friend WithEvents lblconsentt2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblconsentt4 As Label
    Friend WithEvents lblConsentUntil As Label
    Friend WithEvents cboLegalEntity As ComboBox
    Friend WithEvents btnSetConsent As Button
    Friend WithEvents tslGroupCompany As ToolStripLabel
End Class
