<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppoinmentDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppoinmentDetail))
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.txtAddress3 = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtContactPosition = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtContactForeName = New System.Windows.Forms.TextBox()
        Me.txtContactSurname = New System.Windows.Forms.TextBox()
        Me.TxtAgent = New System.Windows.Forms.TextBox()
        Me.txtRenewal = New System.Windows.Forms.TextBox()
        Me.TxtProvider = New System.Windows.Forms.TextBox()
        Me.txtRep = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.panelEmail = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAppointmentTime = New System.Windows.Forms.Label()
        Me.BtnMakeLive = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnChangeAddress = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConfirmed = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtAppSat = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtfbContact = New System.Windows.Forms.TextBox()
        Me.txtfbposition = New System.Windows.Forms.TextBox()
        Me.txtfbRenewal = New System.Windows.Forms.TextBox()
        Me.txtfbProvider = New System.Windows.Forms.TextBox()
        Me.txtSold = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtOutcome = New System.Windows.Forms.TextBox()
        Me.txtPMI = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.cboWasInsured = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCSCompleted = New System.Windows.Forms.TextBox()
        Me.txtCSSent = New System.Windows.Forms.TextBox()
        Me.txtLifeReasonNotPresented = New System.Windows.Forms.TextBox()
        Me.txtLifeSoldDate = New System.Windows.Forms.TextBox()
        Me.txtLifeStartDate = New System.Windows.Forms.TextBox()
        Me.txtReasonNotPresented = New System.Windows.Forms.TextBox()
        Me.txtPreviousProvider = New System.Windows.Forms.TextBox()
        Me.txtPMINextContact = New System.Windows.Forms.TextBox()
        Me.txtLifeNextContact = New System.Windows.Forms.TextBox()
        Me.txtLifeOutcome = New System.Windows.Forms.TextBox()
        Me.txtLifeValue = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtQuoteInfo = New System.Windows.Forms.TextBox()
        Me.txtQuoteMethod = New System.Windows.Forms.TextBox()
        Me.txtQuotedInMeeting = New System.Windows.Forms.TextBox()
        Me.txtProfessional = New System.Windows.Forms.TextBox()
        Me.txtPunctual = New System.Windows.Forms.TextBox()
        Me.btnSurvey = New System.Windows.Forms.Button()
        Me.txtEmployees = New System.Windows.Forms.TextBox()
        Me.LVHistory = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Who = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppointmentNote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddedOn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnCustomerPrint = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCallRep = New System.Windows.Forms.Button()
        Me.BtnCallCust = New System.Windows.Forms.Button()
        Me.BtnRepEmail = New System.Windows.Forms.Button()
        Me.cboCoverRequired = New System.Windows.Forms.ComboBox()
        Me.BtnRepFax = New System.Windows.Forms.Button()
        Me.BtnCustomerEmail = New System.Windows.Forms.Button()
        Me.btnCustomerFax = New System.Windows.Forms.Button()
        Me.txtCalledBefore = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcConfirm = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcWasInsured = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcStatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcbtnMakeLive = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCoverRequired = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcTitle = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcForename = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcSurname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcPosition = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcTelephone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFax = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCompany = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcAddress1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcAddress2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcRep = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcAgent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcArea = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcNotes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcPostcode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcRenewal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcAddress3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcNumberOfEmployees = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcProvider = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCounty = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcTown = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.tabControl = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.tabSurvey = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcCSPunctual = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSProfessional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSCalledBefore = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSQuotedInMeeting = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSQuoteMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSQuoteInfo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSComments = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSSent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcCSCompleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcAppSat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcInvolvedPMI = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFBNotes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcOutCome = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcNextContact = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcContact = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFBPosition = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFBProvider = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFBRenewal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcSoldDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcStartdate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcValue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcPreviousProvider = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lcReasonNotPresented = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcLifeValue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcLifeOutcome = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcLifeNextContact = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcLifeStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcLifeReasonNotPresented = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcLifeSoldDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcConclusion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.panelEmail.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcWasInsured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcbtnMakeLive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCoverRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcForename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcSurname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAddress1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAddress2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcRenewal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAddress3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcNumberOfEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabSurvey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSPunctual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSProfessional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSCalledBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSQuotedInMeeting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSQuoteMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSQuoteInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSSent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcCSCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAppSat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcInvolvedPMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFBNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcOutCome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcNextContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFBPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFBProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFBRenewal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcSoldDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcStartdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcPreviousProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcReasonNotPresented, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeOutcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeNextContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeReasonNotPresented, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLifeSoldDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.Color.Red
        Me.lblCounter.Location = New System.Drawing.Point(937, 286)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(0, 16)
        Me.lblCounter.TabIndex = 5
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(269, 105)
        Me.txtAddress3.MaxLength = 50
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(340, 20)
        Me.txtAddress3.TabIndex = 10
        Me.txtAddress3.Text = "x"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(69, 202)
        Me.txtNotes.MaximumSize = New System.Drawing.Size(4, 40)
        Me.txtNotes.MaxLength = 0
        Me.txtNotes.MinimumSize = New System.Drawing.Size(740, 0)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(740, 28)
        Me.txtNotes.TabIndex = 48
        '
        'cmbTitle
        '
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Ms", "Dr", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(69, 33)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(142, 21)
        Me.cmbTitle.TabIndex = 0
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Location = New System.Drawing.Point(69, 106)
        Me.txtContactPosition.MaxLength = 50
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(142, 20)
        Me.txtContactPosition.TabIndex = 12
        Me.txtContactPosition.Text = "x"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(269, 177)
        Me.txtPostcode.MaxLength = 10
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(140, 20)
        Me.txtPostcode.TabIndex = 18
        Me.txtPostcode.Text = "x"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 178)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 20
        Me.txtEmail.Text = "x"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(269, 33)
        Me.txtCompanyName.MaxLength = 100
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(340, 20)
        Me.txtCompanyName.TabIndex = 2
        Me.txtCompanyName.Text = "x"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(269, 153)
        Me.txtCounty.MaxLength = 50
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(340, 20)
        Me.txtCounty.TabIndex = 16
        Me.txtCounty.Text = "x"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(69, 154)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(142, 20)
        Me.txtFax.TabIndex = 17
        Me.txtFax.Text = "x"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(69, 130)
        Me.txtTel.MaxLength = 20
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(142, 20)
        Me.txtTel.TabIndex = 15
        Me.txtTel.Text = "x"
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(269, 129)
        Me.txtTown.MaxLength = 50
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(340, 20)
        Me.txtTown.TabIndex = 13
        Me.txtTown.Text = "x"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(269, 57)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(340, 20)
        Me.txtAddress1.TabIndex = 4
        Me.txtAddress1.Text = "x"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(269, 81)
        Me.txtAddress2.MaxLength = 50
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(340, 20)
        Me.txtAddress2.TabIndex = 7
        Me.txtAddress2.Text = "x"
        '
        'txtContactForeName
        '
        Me.txtContactForeName.BackColor = System.Drawing.Color.White
        Me.txtContactForeName.Location = New System.Drawing.Point(69, 58)
        Me.txtContactForeName.MaxLength = 50
        Me.txtContactForeName.Name = "txtContactForeName"
        Me.txtContactForeName.Size = New System.Drawing.Size(142, 20)
        Me.txtContactForeName.TabIndex = 6
        Me.txtContactForeName.Text = "x"
        '
        'txtContactSurname
        '
        Me.txtContactSurname.Location = New System.Drawing.Point(69, 82)
        Me.txtContactSurname.MaxLength = 50
        Me.txtContactSurname.Name = "txtContactSurname"
        Me.txtContactSurname.Size = New System.Drawing.Size(142, 20)
        Me.txtContactSurname.TabIndex = 9
        Me.txtContactSurname.Text = "x"
        '
        'TxtAgent
        '
        Me.TxtAgent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtAgent.Location = New System.Drawing.Point(667, 57)
        Me.TxtAgent.MaxLength = 50
        Me.TxtAgent.Name = "TxtAgent"
        Me.TxtAgent.Size = New System.Drawing.Size(142, 20)
        Me.TxtAgent.TabIndex = 5
        Me.TxtAgent.Text = "x"
        '
        'txtRenewal
        '
        Me.txtRenewal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRenewal.Location = New System.Drawing.Point(667, 129)
        Me.txtRenewal.MaxLength = 50
        Me.txtRenewal.Name = "txtRenewal"
        Me.txtRenewal.Size = New System.Drawing.Size(142, 20)
        Me.txtRenewal.TabIndex = 11
        Me.txtRenewal.Text = "x"
        '
        'TxtProvider
        '
        Me.TxtProvider.BackColor = System.Drawing.Color.White
        Me.TxtProvider.Location = New System.Drawing.Point(667, 105)
        Me.TxtProvider.MaxLength = 50
        Me.TxtProvider.Name = "TxtProvider"
        Me.TxtProvider.Size = New System.Drawing.Size(142, 20)
        Me.TxtProvider.TabIndex = 14
        Me.TxtProvider.Text = "x"
        '
        'txtRep
        '
        Me.txtRep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRep.Location = New System.Drawing.Point(667, 33)
        Me.txtRep.MaxLength = 50
        Me.txtRep.Name = "txtRep"
        Me.txtRep.Size = New System.Drawing.Size(142, 20)
        Me.txtRep.TabIndex = 3
        Me.txtRep.Text = "x"
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArea.Location = New System.Drawing.Point(667, 81)
        Me.txtArea.MaxLength = 50
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(142, 20)
        Me.txtArea.TabIndex = 8
        Me.txtArea.Text = "x"
        '
        'panelEmail
        '
        Me.panelEmail.BackColor = System.Drawing.Color.White
        Me.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmail.Controls.Add(Me.Label6)
        Me.panelEmail.Controls.Add(Me.lblmessage)
        Me.panelEmail.Location = New System.Drawing.Point(766, 90)
        Me.panelEmail.Name = "panelEmail"
        Me.panelEmail.Size = New System.Drawing.Size(200, 100)
        Me.panelEmail.TabIndex = 10
        Me.panelEmail.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(44, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Please Wait...."
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmessage.Location = New System.Drawing.Point(39, 21)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(111, 17)
        Me.lblmessage.TabIndex = 0
        Me.lblmessage.Text = "Sending Email"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(659, 284)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(150, 21)
        Me.cmbStatus.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Status:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAppointmentTime
        '
        Me.lblAppointmentTime.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAppointmentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentTime.Location = New System.Drawing.Point(92, 0)
        Me.lblAppointmentTime.Name = "lblAppointmentTime"
        Me.lblAppointmentTime.Size = New System.Drawing.Size(567, 22)
        Me.lblAppointmentTime.TabIndex = 1
        Me.lblAppointmentTime.Text = "Title"
        Me.lblAppointmentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMakeLive
        '
        Me.BtnMakeLive.BackColor = System.Drawing.Color.White
        Me.BtnMakeLive.Location = New System.Drawing.Point(659, 309)
        Me.BtnMakeLive.MaximumSize = New System.Drawing.Size(150, 24)
        Me.BtnMakeLive.MinimumSize = New System.Drawing.Size(150, 24)
        Me.BtnMakeLive.Name = "BtnMakeLive"
        Me.BtnMakeLive.Size = New System.Drawing.Size(150, 24)
        Me.BtnMakeLive.TabIndex = 25
        Me.BtnMakeLive.Text = "Make Live"
        Me.BtnMakeLive.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(801, 672)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "old Feedback:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(804, 688)
        Me.txtFeedback.MaxLength = 400
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(612, 20)
        Me.txtFeedback.TabIndex = 51
        '
        'txtConclusion
        '
        Me.txtConclusion.Location = New System.Drawing.Point(126, 375)
        Me.txtConclusion.MaxLength = 400
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.Size = New System.Drawing.Size(683, 20)
        Me.txtConclusion.TabIndex = 53
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToToolStripMenuItem, Me.ChangeProviderToolStripMenuItem, Me.ShowCompanyToolStripMenuItem, Me.ListenToolStripMenuItem, Me.DocumentsToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'MoveToToolStripMenuItem
        '
        Me.MoveToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArepToolStripMenuItem})
        Me.MoveToToolStripMenuItem.Name = "MoveToToolStripMenuItem"
        Me.MoveToToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MoveToToolStripMenuItem.Text = "Change Rep"
        '
        'ArepToolStripMenuItem
        '
        Me.ArepToolStripMenuItem.Name = "ArepToolStripMenuItem"
        Me.ArepToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArepToolStripMenuItem.Text = "Arep"
        '
        'ChangeProviderToolStripMenuItem
        '
        Me.ChangeProviderToolStripMenuItem.Name = "ChangeProviderToolStripMenuItem"
        Me.ChangeProviderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangeProviderToolStripMenuItem.Text = "Change Provider"
        '
        'ShowCompanyToolStripMenuItem
        '
        Me.ShowCompanyToolStripMenuItem.Name = "ShowCompanyToolStripMenuItem"
        Me.ShowCompanyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowCompanyToolStripMenuItem.Text = "Show Company"
        '
        'ListenToolStripMenuItem
        '
        Me.ListenToolStripMenuItem.Name = "ListenToolStripMenuItem"
        Me.ListenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListenToolStripMenuItem.Text = "Listen"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'btnChangeAddress
        '
        Me.btnChangeAddress.Location = New System.Drawing.Point(413, 177)
        Me.btnChangeAddress.Name = "btnChangeAddress"
        Me.btnChangeAddress.Size = New System.Drawing.Size(196, 21)
        Me.btnChangeAddress.TabIndex = 19
        Me.btnChangeAddress.Text = "Change"
        Me.btnChangeAddress.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Confimed:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConfirmed
        '
        Me.txtConfirmed.BackColor = System.Drawing.Color.White
        Me.txtConfirmed.Location = New System.Drawing.Point(15, 284)
        Me.txtConfirmed.MaxLength = 50
        Me.txtConfirmed.Name = "txtConfirmed"
        Me.txtConfirmed.Size = New System.Drawing.Size(150, 20)
        Me.txtConfirmed.TabIndex = 21
        Me.txtConfirmed.Text = "x"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(15, 308)
        Me.btnConfirm.MaximumSize = New System.Drawing.Size(150, 24)
        Me.btnConfirm.MinimumSize = New System.Drawing.Size(150, 24)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(150, 24)
        Me.btnConfirm.TabIndex = 24
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtAppSat
        '
        Me.txtAppSat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAppSat.Location = New System.Drawing.Point(134, 405)
        Me.txtAppSat.MaxLength = 50
        Me.txtAppSat.Name = "txtAppSat"
        Me.txtAppSat.Size = New System.Drawing.Size(277, 20)
        Me.txtAppSat.TabIndex = 27
        Me.txtAppSat.Text = "x"
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtReason.Location = New System.Drawing.Point(134, 429)
        Me.txtReason.MaxLength = 50
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(277, 20)
        Me.txtReason.TabIndex = 29
        Me.txtReason.Text = "x"
        '
        'txtfbContact
        '
        Me.txtfbContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfbContact.Location = New System.Drawing.Point(134, 453)
        Me.txtfbContact.MaxLength = 50
        Me.txtfbContact.Name = "txtfbContact"
        Me.txtfbContact.Size = New System.Drawing.Size(277, 20)
        Me.txtfbContact.TabIndex = 28
        Me.txtfbContact.Text = "x"
        '
        'txtfbposition
        '
        Me.txtfbposition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfbposition.Location = New System.Drawing.Point(134, 477)
        Me.txtfbposition.MaxLength = 50
        Me.txtfbposition.Name = "txtfbposition"
        Me.txtfbposition.Size = New System.Drawing.Size(277, 20)
        Me.txtfbposition.TabIndex = 30
        Me.txtfbposition.Text = "x"
        '
        'txtfbRenewal
        '
        Me.txtfbRenewal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfbRenewal.Location = New System.Drawing.Point(134, 525)
        Me.txtfbRenewal.MaxLength = 50
        Me.txtfbRenewal.Name = "txtfbRenewal"
        Me.txtfbRenewal.Size = New System.Drawing.Size(277, 20)
        Me.txtfbRenewal.TabIndex = 68
        Me.txtfbRenewal.Text = "x"
        '
        'txtfbProvider
        '
        Me.txtfbProvider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfbProvider.Location = New System.Drawing.Point(134, 501)
        Me.txtfbProvider.MaxLength = 50
        Me.txtfbProvider.Name = "txtfbProvider"
        Me.txtfbProvider.Size = New System.Drawing.Size(277, 20)
        Me.txtfbProvider.TabIndex = 32
        Me.txtfbProvider.Text = "x"
        '
        'txtSold
        '
        Me.txtSold.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSold.Location = New System.Drawing.Point(526, 429)
        Me.txtSold.MaxLength = 50
        Me.txtSold.Name = "txtSold"
        Me.txtSold.Size = New System.Drawing.Size(275, 20)
        Me.txtSold.TabIndex = 72
        Me.txtSold.Text = "x"
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtType.Location = New System.Drawing.Point(526, 405)
        Me.txtType.MaxLength = 50
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(275, 20)
        Me.txtType.TabIndex = 70
        Me.txtType.Text = "x"
        '
        'txtStartDate
        '
        Me.txtStartDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStartDate.Location = New System.Drawing.Point(526, 453)
        Me.txtStartDate.MaxLength = 50
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(275, 20)
        Me.txtStartDate.TabIndex = 76
        Me.txtStartDate.Text = "x"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValue.Location = New System.Drawing.Point(526, 477)
        Me.txtValue.MaxLength = 50
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(275, 20)
        Me.txtValue.TabIndex = 74
        Me.txtValue.Text = "x"
        '
        'txtOutcome
        '
        Me.txtOutcome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOutcome.Location = New System.Drawing.Point(134, 405)
        Me.txtOutcome.MaxLength = 50
        Me.txtOutcome.Name = "txtOutcome"
        Me.txtOutcome.Size = New System.Drawing.Size(277, 20)
        Me.txtOutcome.TabIndex = 33
        Me.txtOutcome.Text = "x"
        '
        'txtPMI
        '
        Me.txtPMI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPMI.Location = New System.Drawing.Point(134, 453)
        Me.txtPMI.MaxLength = 50
        Me.txtPMI.Name = "txtPMI"
        Me.txtPMI.Size = New System.Drawing.Size(277, 20)
        Me.txtPMI.TabIndex = 31
        Me.txtPMI.Text = "x"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNote.Location = New System.Drawing.Point(134, 477)
        Me.txtNote.MaxLength = 400
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(667, 92)
        Me.txtNote.TabIndex = 81
        '
        'cboWasInsured
        '
        Me.cboWasInsured.FormattingEnabled = True
        Me.cboWasInsured.Items.AddRange(New Object() {"", "Insured", "No Cover"})
        Me.cboWasInsured.Location = New System.Drawing.Point(184, 284)
        Me.cboWasInsured.Name = "cboWasInsured"
        Me.cboWasInsured.Size = New System.Drawing.Size(122, 21)
        Me.cboWasInsured.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(229, 267)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 84
        Me.Label26.Text = "Was Insured:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtCSCompleted)
        Me.LayoutControl1.Controls.Add(Me.txtCSSent)
        Me.LayoutControl1.Controls.Add(Me.txtLifeReasonNotPresented)
        Me.LayoutControl1.Controls.Add(Me.txtLifeSoldDate)
        Me.LayoutControl1.Controls.Add(Me.txtLifeStartDate)
        Me.LayoutControl1.Controls.Add(Me.txtReasonNotPresented)
        Me.LayoutControl1.Controls.Add(Me.txtPreviousProvider)
        Me.LayoutControl1.Controls.Add(Me.txtPMINextContact)
        Me.LayoutControl1.Controls.Add(Me.txtLifeNextContact)
        Me.LayoutControl1.Controls.Add(Me.txtLifeOutcome)
        Me.LayoutControl1.Controls.Add(Me.txtLifeValue)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtQuoteInfo)
        Me.LayoutControl1.Controls.Add(Me.txtQuoteMethod)
        Me.LayoutControl1.Controls.Add(Me.txtQuotedInMeeting)
        Me.LayoutControl1.Controls.Add(Me.txtProfessional)
        Me.LayoutControl1.Controls.Add(Me.txtPunctual)
        Me.LayoutControl1.Controls.Add(Me.btnSurvey)
        Me.LayoutControl1.Controls.Add(Me.txtEmployees)
        Me.LayoutControl1.Controls.Add(Me.LVHistory)
        Me.LayoutControl1.Controls.Add(Me.BtnCustomerPrint)
        Me.LayoutControl1.Controls.Add(Me.Button7)
        Me.LayoutControl1.Controls.Add(Me.Button1)
        Me.LayoutControl1.Controls.Add(Me.BtnCallRep)
        Me.LayoutControl1.Controls.Add(Me.BtnCallCust)
        Me.LayoutControl1.Controls.Add(Me.BtnRepEmail)
        Me.LayoutControl1.Controls.Add(Me.txtConclusion)
        Me.LayoutControl1.Controls.Add(Me.cboCoverRequired)
        Me.LayoutControl1.Controls.Add(Me.BtnRepFax)
        Me.LayoutControl1.Controls.Add(Me.BtnCustomerEmail)
        Me.LayoutControl1.Controls.Add(Me.txtSold)
        Me.LayoutControl1.Controls.Add(Me.btnCustomerFax)
        Me.LayoutControl1.Controls.Add(Me.txtType)
        Me.LayoutControl1.Controls.Add(Me.txtValue)
        Me.LayoutControl1.Controls.Add(Me.txtfbRenewal)
        Me.LayoutControl1.Controls.Add(Me.txtStartDate)
        Me.LayoutControl1.Controls.Add(Me.txtAppSat)
        Me.LayoutControl1.Controls.Add(Me.cmbTitle)
        Me.LayoutControl1.Controls.Add(Me.cboWasInsured)
        Me.LayoutControl1.Controls.Add(Me.txtContactSurname)
        Me.LayoutControl1.Controls.Add(Me.txtNote)
        Me.LayoutControl1.Controls.Add(Me.btnConfirm)
        Me.LayoutControl1.Controls.Add(Me.txtfbProvider)
        Me.LayoutControl1.Controls.Add(Me.BtnMakeLive)
        Me.LayoutControl1.Controls.Add(Me.txtContactForeName)
        Me.LayoutControl1.Controls.Add(Me.txtContactPosition)
        Me.LayoutControl1.Controls.Add(Me.txtConfirmed)
        Me.LayoutControl1.Controls.Add(Me.txtfbposition)
        Me.LayoutControl1.Controls.Add(Me.txtNotes)
        Me.LayoutControl1.Controls.Add(Me.cmbStatus)
        Me.LayoutControl1.Controls.Add(Me.txtReason)
        Me.LayoutControl1.Controls.Add(Me.txtfbContact)
        Me.LayoutControl1.Controls.Add(Me.txtTel)
        Me.LayoutControl1.Controls.Add(Me.txtFax)
        Me.LayoutControl1.Controls.Add(Me.txtOutcome)
        Me.LayoutControl1.Controls.Add(Me.btnChangeAddress)
        Me.LayoutControl1.Controls.Add(Me.txtEmail)
        Me.LayoutControl1.Controls.Add(Me.txtCompanyName)
        Me.LayoutControl1.Controls.Add(Me.txtAddress1)
        Me.LayoutControl1.Controls.Add(Me.txtPMI)
        Me.LayoutControl1.Controls.Add(Me.txtAddress2)
        Me.LayoutControl1.Controls.Add(Me.txtAddress3)
        Me.LayoutControl1.Controls.Add(Me.txtTown)
        Me.LayoutControl1.Controls.Add(Me.txtRenewal)
        Me.LayoutControl1.Controls.Add(Me.txtCounty)
        Me.LayoutControl1.Controls.Add(Me.txtPostcode)
        Me.LayoutControl1.Controls.Add(Me.TxtProvider)
        Me.LayoutControl1.Controls.Add(Me.TxtAgent)
        Me.LayoutControl1.Controls.Add(Me.txtRep)
        Me.LayoutControl1.Controls.Add(Me.txtArea)
        Me.LayoutControl1.Controls.Add(Me.txtCalledBefore)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(472, 5, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(821, 723)
        Me.LayoutControl1.TabIndex = 86
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtCSCompleted
        '
        Me.txtCSCompleted.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCSCompleted.Location = New System.Drawing.Point(658, 399)
        Me.txtCSCompleted.MaxLength = 50
        Me.txtCSCompleted.Name = "txtCSCompleted"
        Me.txtCSCompleted.Size = New System.Drawing.Size(151, 20)
        Me.txtCSCompleted.TabIndex = 95
        Me.txtCSCompleted.Text = "x"
        '
        'txtCSSent
        '
        Me.txtCSSent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCSSent.Location = New System.Drawing.Point(658, 375)
        Me.txtCSSent.MaxLength = 50
        Me.txtCSSent.Name = "txtCSSent"
        Me.txtCSSent.Size = New System.Drawing.Size(151, 20)
        Me.txtCSSent.TabIndex = 94
        Me.txtCSSent.Text = "x"
        '
        'txtLifeReasonNotPresented
        '
        Me.txtLifeReasonNotPresented.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeReasonNotPresented.Location = New System.Drawing.Point(134, 477)
        Me.txtLifeReasonNotPresented.MaxLength = 50
        Me.txtLifeReasonNotPresented.Name = "txtLifeReasonNotPresented"
        Me.txtLifeReasonNotPresented.Size = New System.Drawing.Size(667, 20)
        Me.txtLifeReasonNotPresented.TabIndex = 88
        Me.txtLifeReasonNotPresented.Text = "x"
        '
        'txtLifeSoldDate
        '
        Me.txtLifeSoldDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeSoldDate.Location = New System.Drawing.Point(526, 453)
        Me.txtLifeSoldDate.MaxLength = 50
        Me.txtLifeSoldDate.Name = "txtLifeSoldDate"
        Me.txtLifeSoldDate.Size = New System.Drawing.Size(275, 20)
        Me.txtLifeSoldDate.TabIndex = 88
        Me.txtLifeSoldDate.Text = "x"
        '
        'txtLifeStartDate
        '
        Me.txtLifeStartDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeStartDate.Location = New System.Drawing.Point(526, 429)
        Me.txtLifeStartDate.MaxLength = 50
        Me.txtLifeStartDate.Name = "txtLifeStartDate"
        Me.txtLifeStartDate.Size = New System.Drawing.Size(275, 20)
        Me.txtLifeStartDate.TabIndex = 88
        Me.txtLifeStartDate.Text = "x"
        '
        'txtReasonNotPresented
        '
        Me.txtReasonNotPresented.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtReasonNotPresented.Location = New System.Drawing.Point(134, 549)
        Me.txtReasonNotPresented.MaxLength = 50
        Me.txtReasonNotPresented.Name = "txtReasonNotPresented"
        Me.txtReasonNotPresented.Size = New System.Drawing.Size(667, 20)
        Me.txtReasonNotPresented.TabIndex = 87
        Me.txtReasonNotPresented.Text = "x"
        '
        'txtPreviousProvider
        '
        Me.txtPreviousProvider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreviousProvider.Location = New System.Drawing.Point(526, 525)
        Me.txtPreviousProvider.MaxLength = 50
        Me.txtPreviousProvider.Name = "txtPreviousProvider"
        Me.txtPreviousProvider.Size = New System.Drawing.Size(275, 20)
        Me.txtPreviousProvider.TabIndex = 88
        Me.txtPreviousProvider.Text = "x"
        '
        'txtPMINextContact
        '
        Me.txtPMINextContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPMINextContact.Location = New System.Drawing.Point(134, 429)
        Me.txtPMINextContact.MaxLength = 50
        Me.txtPMINextContact.Name = "txtPMINextContact"
        Me.txtPMINextContact.Size = New System.Drawing.Size(277, 20)
        Me.txtPMINextContact.TabIndex = 87
        Me.txtPMINextContact.Text = "x"
        '
        'txtLifeNextContact
        '
        Me.txtLifeNextContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeNextContact.Location = New System.Drawing.Point(134, 429)
        Me.txtLifeNextContact.MaxLength = 50
        Me.txtLifeNextContact.Name = "txtLifeNextContact"
        Me.txtLifeNextContact.Size = New System.Drawing.Size(277, 20)
        Me.txtLifeNextContact.TabIndex = 87
        Me.txtLifeNextContact.Text = "x"
        '
        'txtLifeOutcome
        '
        Me.txtLifeOutcome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeOutcome.Location = New System.Drawing.Point(134, 405)
        Me.txtLifeOutcome.MaxLength = 50
        Me.txtLifeOutcome.Name = "txtLifeOutcome"
        Me.txtLifeOutcome.Size = New System.Drawing.Size(277, 20)
        Me.txtLifeOutcome.TabIndex = 87
        Me.txtLifeOutcome.Text = "x"
        '
        'txtLifeValue
        '
        Me.txtLifeValue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLifeValue.Location = New System.Drawing.Point(526, 405)
        Me.txtLifeValue.MaxLength = 50
        Me.txtLifeValue.Name = "txtLifeValue"
        Me.txtLifeValue.Size = New System.Drawing.Size(275, 20)
        Me.txtLifeValue.TabIndex = 87
        Me.txtLifeValue.Text = "x"
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtComments.Location = New System.Drawing.Point(15, 463)
        Me.txtComments.MaxLength = 50
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(794, 114)
        Me.txtComments.TabIndex = 96
        Me.txtComments.Text = "x"
        '
        'txtQuoteInfo
        '
        Me.txtQuoteInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuoteInfo.Location = New System.Drawing.Point(392, 423)
        Me.txtQuoteInfo.MaxLength = 50
        Me.txtQuoteInfo.Name = "txtQuoteInfo"
        Me.txtQuoteInfo.Size = New System.Drawing.Size(151, 20)
        Me.txtQuoteInfo.TabIndex = 95
        Me.txtQuoteInfo.Text = "x"
        '
        'txtQuoteMethod
        '
        Me.txtQuoteMethod.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuoteMethod.Location = New System.Drawing.Point(392, 399)
        Me.txtQuoteMethod.MaxLength = 50
        Me.txtQuoteMethod.Name = "txtQuoteMethod"
        Me.txtQuoteMethod.Size = New System.Drawing.Size(151, 20)
        Me.txtQuoteMethod.TabIndex = 94
        Me.txtQuoteMethod.Text = "x"
        '
        'txtQuotedInMeeting
        '
        Me.txtQuotedInMeeting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuotedInMeeting.Location = New System.Drawing.Point(392, 375)
        Me.txtQuotedInMeeting.MaxLength = 50
        Me.txtQuotedInMeeting.Name = "txtQuotedInMeeting"
        Me.txtQuotedInMeeting.Size = New System.Drawing.Size(151, 20)
        Me.txtQuotedInMeeting.TabIndex = 93
        Me.txtQuotedInMeeting.Text = "x"
        '
        'txtProfessional
        '
        Me.txtProfessional.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProfessional.Location = New System.Drawing.Point(126, 399)
        Me.txtProfessional.MaxLength = 50
        Me.txtProfessional.Name = "txtProfessional"
        Me.txtProfessional.Size = New System.Drawing.Size(151, 20)
        Me.txtProfessional.TabIndex = 92
        Me.txtProfessional.Text = "x"
        '
        'txtPunctual
        '
        Me.txtPunctual.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPunctual.Location = New System.Drawing.Point(126, 375)
        Me.txtPunctual.MaxLength = 50
        Me.txtPunctual.Name = "txtPunctual"
        Me.txtPunctual.Size = New System.Drawing.Size(151, 20)
        Me.txtPunctual.TabIndex = 91
        Me.txtPunctual.Text = "x"
        '
        'btnSurvey
        '
        Me.btnSurvey.BackColor = System.Drawing.Color.White
        Me.btnSurvey.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.surveys_icon
        Me.btnSurvey.Location = New System.Drawing.Point(228, 615)
        Me.btnSurvey.MaximumSize = New System.Drawing.Size(67, 76)
        Me.btnSurvey.MinimumSize = New System.Drawing.Size(67, 76)
        Me.btnSurvey.Name = "btnSurvey"
        Me.btnSurvey.Size = New System.Drawing.Size(67, 76)
        Me.btnSurvey.TabIndex = 90
        Me.btnSurvey.Text = "Survey"
        Me.btnSurvey.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSurvey.UseVisualStyleBackColor = False
        '
        'txtEmployees
        '
        Me.txtEmployees.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmployees.Location = New System.Drawing.Point(667, 153)
        Me.txtEmployees.MaxLength = 50
        Me.txtEmployees.Name = "txtEmployees"
        Me.txtEmployees.Size = New System.Drawing.Size(142, 20)
        Me.txtEmployees.TabIndex = 89
        Me.txtEmployees.Text = "x"
        '
        'LVHistory
        '
        Me.LVHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Who, Me.AppointmentNote, Me.AddedOn})
        Me.LVHistory.FullRowSelect = True
        Me.LVHistory.GridLines = True
        Me.LVHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVHistory.HideSelection = False
        Me.LVHistory.Location = New System.Drawing.Point(15, 375)
        Me.LVHistory.MultiSelect = False
        Me.LVHistory.Name = "LVHistory"
        Me.LVHistory.Size = New System.Drawing.Size(794, 202)
        Me.LVHistory.TabIndex = 88
        Me.LVHistory.UseCompatibleStateImageBehavior = False
        Me.LVHistory.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 5
        '
        'Who
        '
        Me.Who.Text = "Added By"
        Me.Who.Width = 110
        '
        'AppointmentNote
        '
        Me.AppointmentNote.Text = "Appointment Note"
        Me.AppointmentNote.Width = 418
        '
        'AddedOn
        '
        Me.AddedOn.Text = "Date"
        Me.AddedOn.Width = 169
        '
        'BtnCustomerPrint
        '
        Me.BtnCustomerPrint.BackColor = System.Drawing.Color.White
        Me.BtnCustomerPrint.Image = CType(resources.GetObject("BtnCustomerPrint.Image"), System.Drawing.Image)
        Me.BtnCustomerPrint.Location = New System.Drawing.Point(671, 615)
        Me.BtnCustomerPrint.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnCustomerPrint.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnCustomerPrint.Name = "BtnCustomerPrint"
        Me.BtnCustomerPrint.Size = New System.Drawing.Size(67, 76)
        Me.BtnCustomerPrint.TabIndex = 0
        Me.BtnCustomerPrint.Text = "Print"
        Me.BtnCustomerPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCustomerPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCustomerPrint.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.close
        Me.Button7.Location = New System.Drawing.Point(742, 615)
        Me.Button7.MaximumSize = New System.Drawing.Size(67, 76)
        Me.Button7.MinimumSize = New System.Drawing.Size(67, 76)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 76)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Close"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.note
        Me.Button1.Location = New System.Drawing.Point(600, 615)
        Me.Button1.MaximumSize = New System.Drawing.Size(67, 76)
        Me.Button1.MinimumSize = New System.Drawing.Size(67, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 76)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Note"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnCallRep
        '
        Me.BtnCallRep.BackColor = System.Drawing.Color.White
        Me.BtnCallRep.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources._Call
        Me.BtnCallRep.Location = New System.Drawing.Point(386, 615)
        Me.BtnCallRep.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnCallRep.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnCallRep.Name = "BtnCallRep"
        Me.BtnCallRep.Size = New System.Drawing.Size(67, 76)
        Me.BtnCallRep.TabIndex = 2
        Me.BtnCallRep.Text = "Call"
        Me.BtnCallRep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCallRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCallRep.UseVisualStyleBackColor = False
        '
        'BtnCallCust
        '
        Me.BtnCallCust.BackColor = System.Drawing.Color.White
        Me.BtnCallCust.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources._Call
        Me.BtnCallCust.Location = New System.Drawing.Point(157, 615)
        Me.BtnCallCust.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnCallCust.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnCallCust.Name = "BtnCallCust"
        Me.BtnCallCust.Size = New System.Drawing.Size(67, 76)
        Me.BtnCallCust.TabIndex = 2
        Me.BtnCallCust.Text = "Call"
        Me.BtnCallCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCallCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCallCust.UseVisualStyleBackColor = False
        '
        'BtnRepEmail
        '
        Me.BtnRepEmail.BackColor = System.Drawing.Color.White
        Me.BtnRepEmail.Image = CType(resources.GetObject("BtnRepEmail.Image"), System.Drawing.Image)
        Me.BtnRepEmail.Location = New System.Drawing.Point(315, 615)
        Me.BtnRepEmail.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnRepEmail.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnRepEmail.Name = "BtnRepEmail"
        Me.BtnRepEmail.Size = New System.Drawing.Size(67, 76)
        Me.BtnRepEmail.TabIndex = 1
        Me.BtnRepEmail.Text = "Email"
        Me.BtnRepEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRepEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRepEmail.UseVisualStyleBackColor = False
        '
        'cboCoverRequired
        '
        Me.cboCoverRequired.DisplayMember = "Text"
        Me.cboCoverRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoverRequired.FormattingEnabled = True
        Me.cboCoverRequired.Items.AddRange(New Object() {"", "Insured", "No Cover"})
        Me.cboCoverRequired.Location = New System.Drawing.Point(325, 284)
        Me.cboCoverRequired.Name = "cboCoverRequired"
        Me.cboCoverRequired.Size = New System.Drawing.Size(313, 21)
        Me.cboCoverRequired.TabIndex = 87
        Me.cboCoverRequired.ValueMember = "value"
        '
        'BtnRepFax
        '
        Me.BtnRepFax.BackColor = System.Drawing.Color.White
        Me.BtnRepFax.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.Fax
        Me.BtnRepFax.Location = New System.Drawing.Point(457, 615)
        Me.BtnRepFax.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnRepFax.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnRepFax.Name = "BtnRepFax"
        Me.BtnRepFax.Size = New System.Drawing.Size(67, 76)
        Me.BtnRepFax.TabIndex = 0
        Me.BtnRepFax.Text = "Fax"
        Me.BtnRepFax.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRepFax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRepFax.UseVisualStyleBackColor = False
        Me.BtnRepFax.Visible = False
        '
        'BtnCustomerEmail
        '
        Me.BtnCustomerEmail.BackColor = System.Drawing.Color.White
        Me.BtnCustomerEmail.Image = CType(resources.GetObject("BtnCustomerEmail.Image"), System.Drawing.Image)
        Me.BtnCustomerEmail.Location = New System.Drawing.Point(86, 615)
        Me.BtnCustomerEmail.MaximumSize = New System.Drawing.Size(67, 76)
        Me.BtnCustomerEmail.MinimumSize = New System.Drawing.Size(67, 76)
        Me.BtnCustomerEmail.Name = "BtnCustomerEmail"
        Me.BtnCustomerEmail.Size = New System.Drawing.Size(67, 76)
        Me.BtnCustomerEmail.TabIndex = 1
        Me.BtnCustomerEmail.Text = "Email"
        Me.BtnCustomerEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCustomerEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCustomerEmail.UseVisualStyleBackColor = False
        '
        'btnCustomerFax
        '
        Me.btnCustomerFax.BackColor = System.Drawing.Color.White
        Me.btnCustomerFax.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.Fax
        Me.btnCustomerFax.Location = New System.Drawing.Point(15, 615)
        Me.btnCustomerFax.MaximumSize = New System.Drawing.Size(67, 76)
        Me.btnCustomerFax.MinimumSize = New System.Drawing.Size(67, 76)
        Me.btnCustomerFax.Name = "btnCustomerFax"
        Me.btnCustomerFax.Size = New System.Drawing.Size(67, 76)
        Me.btnCustomerFax.TabIndex = 0
        Me.btnCustomerFax.Text = "Fax"
        Me.btnCustomerFax.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomerFax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCustomerFax.UseVisualStyleBackColor = False
        Me.btnCustomerFax.Visible = False
        '
        'txtCalledBefore
        '
        Me.txtCalledBefore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCalledBefore.Location = New System.Drawing.Point(126, 423)
        Me.txtCalledBefore.MaxLength = 50
        Me.txtCalledBefore.Name = "txtCalledBefore"
        Me.txtCalledBefore.Size = New System.Drawing.Size(151, 20)
        Me.txtCalledBefore.TabIndex = 92
        Me.txtCalledBefore.Text = "x"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlGroup8, Me.tabControl})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(824, 706)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcConfirm, Me.lcWasInsured, Me.LayoutControlItem4, Me.lcStatus, Me.lcbtnMakeLive, Me.lcCoverRequired, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 235)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(814, 103)
        Me.LayoutControlGroup2.Text = "Appointment Management"
        '
        'lcConfirm
        '
        Me.lcConfirm.Control = Me.txtConfirmed
        Me.lcConfirm.Location = New System.Drawing.Point(0, 0)
        Me.lcConfirm.Name = "lcConfirm"
        Me.lcConfirm.Size = New System.Drawing.Size(154, 40)
        Me.lcConfirm.Text = "Confirm"
        Me.lcConfirm.TextLocation = DevExpress.Utils.Locations.Top
        Me.lcConfirm.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcWasInsured
        '
        Me.lcWasInsured.Control = Me.cboWasInsured
        Me.lcWasInsured.Location = New System.Drawing.Point(169, 0)
        Me.lcWasInsured.Name = "lcWasInsured"
        Me.lcWasInsured.Size = New System.Drawing.Size(126, 69)
        Me.lcWasInsured.Text = "Was Insured"
        Me.lcWasInsured.TextLocation = DevExpress.Utils.Locations.Top
        Me.lcWasInsured.TextSize = New System.Drawing.Size(108, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnConfirm
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(154, 29)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'lcStatus
        '
        Me.lcStatus.Control = Me.cmbStatus
        Me.lcStatus.Location = New System.Drawing.Point(644, 0)
        Me.lcStatus.Name = "lcStatus"
        Me.lcStatus.Size = New System.Drawing.Size(154, 41)
        Me.lcStatus.Text = "Status"
        Me.lcStatus.TextLocation = DevExpress.Utils.Locations.Top
        Me.lcStatus.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcbtnMakeLive
        '
        Me.lcbtnMakeLive.Control = Me.BtnMakeLive
        Me.lcbtnMakeLive.Location = New System.Drawing.Point(644, 41)
        Me.lcbtnMakeLive.Name = "lcbtnMakeLive"
        Me.lcbtnMakeLive.Size = New System.Drawing.Size(154, 28)
        Me.lcbtnMakeLive.TextSize = New System.Drawing.Size(0, 0)
        Me.lcbtnMakeLive.TextVisible = False
        '
        'lcCoverRequired
        '
        Me.lcCoverRequired.Control = Me.cboCoverRequired
        Me.lcCoverRequired.Location = New System.Drawing.Point(310, 0)
        Me.lcCoverRequired.Name = "lcCoverRequired"
        Me.lcCoverRequired.Size = New System.Drawing.Size(317, 69)
        Me.lcCoverRequired.Text = "Cover Required"
        Me.lcCoverRequired.TextLocation = DevExpress.Utils.Locations.Top
        Me.lcCoverRequired.TextSize = New System.Drawing.Size(108, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(154, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(295, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(15, 69)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(627, 0)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(17, 69)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(17, 69)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(17, 69)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcTitle, Me.lcForename, Me.lcSurname, Me.lcPosition, Me.lcTelephone, Me.lcFax, Me.lcEmail, Me.lcCompany, Me.lcAddress1, Me.lcAddress2, Me.lcRep, Me.lcAgent, Me.lcArea, Me.lcNotes, Me.lcPostcode, Me.LayoutControlItem2, Me.lcRenewal, Me.lcAddress3, Me.lcNumberOfEmployees, Me.lcProvider, Me.lcCounty, Me.lcTown, Me.EmptySpaceItem4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignWithChildren
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(814, 235)
        Me.LayoutControlGroup3.Text = "Appointment Details"
        '
        'lcTitle
        '
        Me.lcTitle.Control = Me.cmbTitle
        Me.lcTitle.Location = New System.Drawing.Point(0, 0)
        Me.lcTitle.MaxSize = New System.Drawing.Size(0, 25)
        Me.lcTitle.MinSize = New System.Drawing.Size(124, 25)
        Me.lcTitle.Name = "lcTitle"
        Me.lcTitle.Size = New System.Drawing.Size(200, 25)
        Me.lcTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcTitle.Text = "Title"
        Me.lcTitle.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcForename
        '
        Me.lcForename.Control = Me.txtContactForeName
        Me.lcForename.Location = New System.Drawing.Point(0, 25)
        Me.lcForename.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcForename.MinSize = New System.Drawing.Size(124, 24)
        Me.lcForename.Name = "lcForename"
        Me.lcForename.Size = New System.Drawing.Size(200, 24)
        Me.lcForename.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcForename.Text = "Forename"
        Me.lcForename.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcSurname
        '
        Me.lcSurname.Control = Me.txtContactSurname
        Me.lcSurname.Location = New System.Drawing.Point(0, 49)
        Me.lcSurname.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcSurname.MinSize = New System.Drawing.Size(124, 24)
        Me.lcSurname.Name = "lcSurname"
        Me.lcSurname.Size = New System.Drawing.Size(200, 24)
        Me.lcSurname.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcSurname.Text = "Surname"
        Me.lcSurname.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcPosition
        '
        Me.lcPosition.Control = Me.txtContactPosition
        Me.lcPosition.Location = New System.Drawing.Point(0, 73)
        Me.lcPosition.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcPosition.MinSize = New System.Drawing.Size(124, 24)
        Me.lcPosition.Name = "lcPosition"
        Me.lcPosition.Size = New System.Drawing.Size(200, 24)
        Me.lcPosition.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcPosition.Text = "Position"
        Me.lcPosition.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcTelephone
        '
        Me.lcTelephone.Control = Me.txtTel
        Me.lcTelephone.Location = New System.Drawing.Point(0, 97)
        Me.lcTelephone.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcTelephone.MinSize = New System.Drawing.Size(124, 24)
        Me.lcTelephone.Name = "lcTelephone"
        Me.lcTelephone.Size = New System.Drawing.Size(200, 24)
        Me.lcTelephone.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcTelephone.Text = "Telephone"
        Me.lcTelephone.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcFax
        '
        Me.lcFax.Control = Me.txtFax
        Me.lcFax.Location = New System.Drawing.Point(0, 121)
        Me.lcFax.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcFax.MinSize = New System.Drawing.Size(124, 24)
        Me.lcFax.Name = "lcFax"
        Me.lcFax.Size = New System.Drawing.Size(200, 24)
        Me.lcFax.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcFax.Text = "Fax"
        Me.lcFax.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcEmail
        '
        Me.lcEmail.Control = Me.txtEmail
        Me.lcEmail.Location = New System.Drawing.Point(0, 145)
        Me.lcEmail.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcEmail.MinSize = New System.Drawing.Size(124, 24)
        Me.lcEmail.Name = "lcEmail"
        Me.lcEmail.Size = New System.Drawing.Size(200, 24)
        Me.lcEmail.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcEmail.Text = "Email"
        Me.lcEmail.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcCompany
        '
        Me.lcCompany.Control = Me.txtCompanyName
        Me.lcCompany.Location = New System.Drawing.Point(200, 0)
        Me.lcCompany.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcCompany.MinSize = New System.Drawing.Size(136, 24)
        Me.lcCompany.Name = "lcCompany"
        Me.lcCompany.Size = New System.Drawing.Size(398, 24)
        Me.lcCompany.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcCompany.Text = "Company"
        Me.lcCompany.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcAddress1
        '
        Me.lcAddress1.Control = Me.txtAddress1
        Me.lcAddress1.Location = New System.Drawing.Point(200, 24)
        Me.lcAddress1.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcAddress1.MinSize = New System.Drawing.Size(136, 24)
        Me.lcAddress1.Name = "lcAddress1"
        Me.lcAddress1.Size = New System.Drawing.Size(398, 24)
        Me.lcAddress1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcAddress1.Text = "Address"
        Me.lcAddress1.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcAddress2
        '
        Me.lcAddress2.Control = Me.txtAddress2
        Me.lcAddress2.Location = New System.Drawing.Point(200, 48)
        Me.lcAddress2.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcAddress2.MinSize = New System.Drawing.Size(136, 24)
        Me.lcAddress2.Name = "lcAddress2"
        Me.lcAddress2.Size = New System.Drawing.Size(398, 24)
        Me.lcAddress2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcAddress2.Text = " "
        Me.lcAddress2.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcRep
        '
        Me.lcRep.Control = Me.txtRep
        Me.lcRep.Location = New System.Drawing.Point(598, 0)
        Me.lcRep.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcRep.MinSize = New System.Drawing.Size(78, 24)
        Me.lcRep.Name = "lcRep"
        Me.lcRep.Size = New System.Drawing.Size(200, 24)
        Me.lcRep.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcRep.Text = "Rep"
        Me.lcRep.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcAgent
        '
        Me.lcAgent.Control = Me.TxtAgent
        Me.lcAgent.Location = New System.Drawing.Point(598, 24)
        Me.lcAgent.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcAgent.MinSize = New System.Drawing.Size(78, 24)
        Me.lcAgent.Name = "lcAgent"
        Me.lcAgent.Size = New System.Drawing.Size(200, 24)
        Me.lcAgent.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcAgent.Text = "Agent"
        Me.lcAgent.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcArea
        '
        Me.lcArea.Control = Me.txtArea
        Me.lcArea.Location = New System.Drawing.Point(598, 48)
        Me.lcArea.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcArea.MinSize = New System.Drawing.Size(78, 24)
        Me.lcArea.Name = "lcArea"
        Me.lcArea.Size = New System.Drawing.Size(200, 24)
        Me.lcArea.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcArea.Text = "Area"
        Me.lcArea.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcNotes
        '
        Me.lcNotes.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lcNotes.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lcNotes.Control = Me.txtNotes
        Me.lcNotes.Location = New System.Drawing.Point(0, 169)
        Me.lcNotes.Name = "lcNotes"
        Me.lcNotes.Size = New System.Drawing.Size(798, 32)
        Me.lcNotes.Text = "Notes"
        Me.lcNotes.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcPostcode
        '
        Me.lcPostcode.Control = Me.txtPostcode
        Me.lcPostcode.Location = New System.Drawing.Point(200, 144)
        Me.lcPostcode.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcPostcode.MinSize = New System.Drawing.Size(136, 24)
        Me.lcPostcode.Name = "lcPostcode"
        Me.lcPostcode.Size = New System.Drawing.Size(198, 25)
        Me.lcPostcode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcPostcode.Text = "Postcode"
        Me.lcPostcode.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnChangeAddress
        Me.LayoutControlItem2.Location = New System.Drawing.Point(398, 144)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(200, 25)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lcRenewal
        '
        Me.lcRenewal.Control = Me.txtRenewal
        Me.lcRenewal.Location = New System.Drawing.Point(598, 96)
        Me.lcRenewal.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcRenewal.MinSize = New System.Drawing.Size(78, 24)
        Me.lcRenewal.Name = "lcRenewal"
        Me.lcRenewal.Size = New System.Drawing.Size(200, 24)
        Me.lcRenewal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcRenewal.Text = "Renewal"
        Me.lcRenewal.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcAddress3
        '
        Me.lcAddress3.Control = Me.txtAddress3
        Me.lcAddress3.Location = New System.Drawing.Point(200, 72)
        Me.lcAddress3.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcAddress3.MinSize = New System.Drawing.Size(136, 24)
        Me.lcAddress3.Name = "lcAddress3"
        Me.lcAddress3.Size = New System.Drawing.Size(398, 24)
        Me.lcAddress3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcAddress3.Text = " "
        Me.lcAddress3.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcNumberOfEmployees
        '
        Me.lcNumberOfEmployees.Control = Me.txtEmployees
        Me.lcNumberOfEmployees.Location = New System.Drawing.Point(598, 120)
        Me.lcNumberOfEmployees.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcNumberOfEmployees.MinSize = New System.Drawing.Size(78, 24)
        Me.lcNumberOfEmployees.Name = "lcNumberOfEmployees"
        Me.lcNumberOfEmployees.Size = New System.Drawing.Size(200, 24)
        Me.lcNumberOfEmployees.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcNumberOfEmployees.Text = "Employees"
        Me.lcNumberOfEmployees.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcProvider
        '
        Me.lcProvider.Control = Me.TxtProvider
        Me.lcProvider.Location = New System.Drawing.Point(598, 72)
        Me.lcProvider.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcProvider.MinSize = New System.Drawing.Size(78, 24)
        Me.lcProvider.Name = "lcProvider"
        Me.lcProvider.Size = New System.Drawing.Size(200, 24)
        Me.lcProvider.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcProvider.Text = "Provider"
        Me.lcProvider.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcCounty
        '
        Me.lcCounty.Control = Me.txtCounty
        Me.lcCounty.Location = New System.Drawing.Point(200, 120)
        Me.lcCounty.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcCounty.MinSize = New System.Drawing.Size(136, 24)
        Me.lcCounty.Name = "lcCounty"
        Me.lcCounty.Size = New System.Drawing.Size(398, 24)
        Me.lcCounty.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcCounty.Text = "County"
        Me.lcCounty.TextSize = New System.Drawing.Size(51, 13)
        '
        'lcTown
        '
        Me.lcTown.Control = Me.txtTown
        Me.lcTown.Location = New System.Drawing.Point(200, 96)
        Me.lcTown.MaxSize = New System.Drawing.Size(0, 24)
        Me.lcTown.MinSize = New System.Drawing.Size(136, 24)
        Me.lcTown.Name = "lcTown"
        Me.lcTown.Size = New System.Drawing.Size(398, 24)
        Me.lcTown.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcTown.Text = "Town"
        Me.lcTown.TextSize = New System.Drawing.Size(51, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(598, 144)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(200, 25)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem1})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 582)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(300, 114)
        Me.LayoutControlGroup6.Text = "Customer"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnCustomerFax
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.BtnCustomerEmail
        Me.LayoutControlItem8.Location = New System.Drawing.Point(71, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.BtnCallCust
        Me.LayoutControlItem9.Location = New System.Drawing.Point(142, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnSurvey
        Me.LayoutControlItem1.Location = New System.Drawing.Point(213, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(300, 582)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(229, 114)
        Me.LayoutControlGroup7.Text = "Rep"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.BtnRepFax
        Me.LayoutControlItem10.Location = New System.Drawing.Point(142, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.BtnRepEmail
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.BtnCallRep
        Me.LayoutControlItem12.Location = New System.Drawing.Point(71, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem10})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(529, 582)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(285, 114)
        Me.LayoutControlGroup8.Text = "General"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.Button1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(56, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Button7
        Me.LayoutControlItem14.Location = New System.Drawing.Point(198, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.BtnCustomerPrint
        Me.LayoutControlItem15.Location = New System.Drawing.Point(127, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(71, 80)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        Me.LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(56, 80)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'tabControl
        '
        Me.tabControl.Location = New System.Drawing.Point(0, 338)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.tabControl.SelectedTabPage = Me.tabSurvey
        Me.tabControl.Size = New System.Drawing.Size(814, 244)
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup9, Me.tabSurvey})
        '
        'tabSurvey
        '
        Me.tabSurvey.CustomizationFormText = "Survey"
        Me.tabSurvey.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcCSPunctual, Me.lcCSProfessional, Me.lcCSCalledBefore, Me.lcCSQuotedInMeeting, Me.lcCSQuoteMethod, Me.lcCSQuoteInfo, Me.lcCSComments, Me.lcCSSent, Me.lcCSCompleted})
        Me.tabSurvey.Location = New System.Drawing.Point(0, 0)
        Me.tabSurvey.Name = "tabSurvey"
        Me.tabSurvey.Size = New System.Drawing.Size(798, 206)
        Me.tabSurvey.Text = "Customer Survey"
        '
        'lcCSPunctual
        '
        Me.lcCSPunctual.Control = Me.txtPunctual
        Me.lcCSPunctual.Location = New System.Drawing.Point(0, 0)
        Me.lcCSPunctual.Name = "lcCSPunctual"
        Me.lcCSPunctual.Size = New System.Drawing.Size(266, 24)
        Me.lcCSPunctual.Text = "Punctual"
        Me.lcCSPunctual.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSProfessional
        '
        Me.lcCSProfessional.Control = Me.txtProfessional
        Me.lcCSProfessional.Location = New System.Drawing.Point(0, 24)
        Me.lcCSProfessional.Name = "lcCSProfessional"
        Me.lcCSProfessional.Size = New System.Drawing.Size(266, 24)
        Me.lcCSProfessional.Text = "Professional"
        Me.lcCSProfessional.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSCalledBefore
        '
        Me.lcCSCalledBefore.Control = Me.txtCalledBefore
        Me.lcCSCalledBefore.CustomizationFormText = "LayoutControlItem16"
        Me.lcCSCalledBefore.Location = New System.Drawing.Point(0, 48)
        Me.lcCSCalledBefore.Name = "lcCSCalledBefore"
        Me.lcCSCalledBefore.Size = New System.Drawing.Size(266, 24)
        Me.lcCSCalledBefore.Text = "Called Before"
        Me.lcCSCalledBefore.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSQuotedInMeeting
        '
        Me.lcCSQuotedInMeeting.Control = Me.txtQuotedInMeeting
        Me.lcCSQuotedInMeeting.Location = New System.Drawing.Point(266, 0)
        Me.lcCSQuotedInMeeting.Name = "lcCSQuotedInMeeting"
        Me.lcCSQuotedInMeeting.Size = New System.Drawing.Size(266, 24)
        Me.lcCSQuotedInMeeting.Text = "Quoted In Meeting"
        Me.lcCSQuotedInMeeting.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSQuoteMethod
        '
        Me.lcCSQuoteMethod.Control = Me.txtQuoteMethod
        Me.lcCSQuoteMethod.Location = New System.Drawing.Point(266, 24)
        Me.lcCSQuoteMethod.Name = "lcCSQuoteMethod"
        Me.lcCSQuoteMethod.Size = New System.Drawing.Size(266, 24)
        Me.lcCSQuoteMethod.Text = "Quote Method"
        Me.lcCSQuoteMethod.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSQuoteInfo
        '
        Me.lcCSQuoteInfo.Control = Me.txtQuoteInfo
        Me.lcCSQuoteInfo.Location = New System.Drawing.Point(266, 48)
        Me.lcCSQuoteInfo.Name = "lcCSQuoteInfo"
        Me.lcCSQuoteInfo.Size = New System.Drawing.Size(266, 24)
        Me.lcCSQuoteInfo.Text = "Info to Quote"
        Me.lcCSQuoteInfo.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSComments
        '
        Me.lcCSComments.Control = Me.txtComments
        Me.lcCSComments.Location = New System.Drawing.Point(0, 72)
        Me.lcCSComments.Name = "lcCSComments"
        Me.lcCSComments.Size = New System.Drawing.Size(798, 134)
        Me.lcCSComments.Text = "Note"
        Me.lcCSComments.TextLocation = DevExpress.Utils.Locations.Top
        Me.lcCSComments.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSSent
        '
        Me.lcCSSent.Control = Me.txtCSSent
        Me.lcCSSent.Location = New System.Drawing.Point(532, 0)
        Me.lcCSSent.Name = "lcCSSent"
        Me.lcCSSent.Size = New System.Drawing.Size(266, 24)
        Me.lcCSSent.Text = "Sent"
        Me.lcCSSent.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcCSCompleted
        '
        Me.lcCSCompleted.Control = Me.txtCSCompleted
        Me.lcCSCompleted.Location = New System.Drawing.Point(532, 24)
        Me.lcCSCompleted.Name = "lcCSCompleted"
        Me.lcCSCompleted.Size = New System.Drawing.Size(266, 48)
        Me.lcCSCompleted.Text = "Completed"
        Me.lcCSCompleted.TextSize = New System.Drawing.Size(108, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(798, 206)
        Me.LayoutControlGroup4.Text = "History"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LVHistory
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(798, 206)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(798, 206)
        Me.LayoutControlGroup5.Text = "Feedback"
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup10
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(798, 206)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup10, Me.LayoutControlGroup11, Me.LayoutControlGroup12})
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcAppSat, Me.lcInvolvedPMI, Me.lcReason, Me.lcFBNotes, Me.EmptySpaceItem8})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(782, 168)
        Me.LayoutControlGroup10.Text = "General"
        '
        'lcAppSat
        '
        Me.lcAppSat.Control = Me.txtAppSat
        Me.lcAppSat.Location = New System.Drawing.Point(0, 0)
        Me.lcAppSat.Name = "lcAppSat"
        Me.lcAppSat.Size = New System.Drawing.Size(392, 24)
        Me.lcAppSat.Text = "Sat"
        Me.lcAppSat.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcInvolvedPMI
        '
        Me.lcInvolvedPMI.Control = Me.txtPMI
        Me.lcInvolvedPMI.Location = New System.Drawing.Point(0, 48)
        Me.lcInvolvedPMI.Name = "lcInvolvedPMI"
        Me.lcInvolvedPMI.Size = New System.Drawing.Size(392, 24)
        Me.lcInvolvedPMI.Text = "Involved"
        Me.lcInvolvedPMI.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcReason
        '
        Me.lcReason.Control = Me.txtReason
        Me.lcReason.Location = New System.Drawing.Point(0, 24)
        Me.lcReason.Name = "lcReason"
        Me.lcReason.Size = New System.Drawing.Size(392, 24)
        Me.lcReason.Text = "Reason"
        Me.lcReason.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcFBNotes
        '
        Me.lcFBNotes.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lcFBNotes.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lcFBNotes.Control = Me.txtNote
        Me.lcFBNotes.Location = New System.Drawing.Point(0, 72)
        Me.lcFBNotes.Name = "lcFBNotes"
        Me.lcFBNotes.Size = New System.Drawing.Size(782, 96)
        Me.lcFBNotes.Text = "Notes"
        Me.lcFBNotes.TextSize = New System.Drawing.Size(108, 13)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(392, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(390, 72)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcOutCome, Me.lcNextContact, Me.lcContact, Me.lcFBPosition, Me.lcFBProvider, Me.lcFBRenewal, Me.lcType, Me.lcSoldDate, Me.lcStartdate, Me.lcValue, Me.lcPreviousProvider, Me.EmptySpaceItem9, Me.lcReasonNotPresented})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(782, 168)
        Me.LayoutControlGroup11.Text = "Private Medical"
        '
        'lcOutCome
        '
        Me.lcOutCome.Control = Me.txtOutcome
        Me.lcOutCome.Location = New System.Drawing.Point(0, 0)
        Me.lcOutCome.Name = "lcOutCome"
        Me.lcOutCome.Size = New System.Drawing.Size(392, 24)
        Me.lcOutCome.Text = "Out Come"
        Me.lcOutCome.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcNextContact
        '
        Me.lcNextContact.Control = Me.txtPMINextContact
        Me.lcNextContact.Location = New System.Drawing.Point(0, 24)
        Me.lcNextContact.Name = "lcNextContact"
        Me.lcNextContact.Size = New System.Drawing.Size(392, 24)
        Me.lcNextContact.Text = "Next Contact"
        Me.lcNextContact.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcContact
        '
        Me.lcContact.Control = Me.txtfbContact
        Me.lcContact.Location = New System.Drawing.Point(0, 48)
        Me.lcContact.Name = "lcContact"
        Me.lcContact.Size = New System.Drawing.Size(392, 24)
        Me.lcContact.Text = "Contact"
        Me.lcContact.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcFBPosition
        '
        Me.lcFBPosition.Control = Me.txtfbposition
        Me.lcFBPosition.Location = New System.Drawing.Point(0, 72)
        Me.lcFBPosition.Name = "lcFBPosition"
        Me.lcFBPosition.Size = New System.Drawing.Size(392, 24)
        Me.lcFBPosition.Text = "Position"
        Me.lcFBPosition.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcFBProvider
        '
        Me.lcFBProvider.Control = Me.txtfbProvider
        Me.lcFBProvider.Location = New System.Drawing.Point(0, 96)
        Me.lcFBProvider.Name = "lcFBProvider"
        Me.lcFBProvider.Size = New System.Drawing.Size(392, 24)
        Me.lcFBProvider.Text = "Provider"
        Me.lcFBProvider.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcFBRenewal
        '
        Me.lcFBRenewal.Control = Me.txtfbRenewal
        Me.lcFBRenewal.Location = New System.Drawing.Point(0, 120)
        Me.lcFBRenewal.Name = "lcFBRenewal"
        Me.lcFBRenewal.Size = New System.Drawing.Size(392, 24)
        Me.lcFBRenewal.Text = "Renewal"
        Me.lcFBRenewal.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcType
        '
        Me.lcType.Control = Me.txtType
        Me.lcType.Location = New System.Drawing.Point(392, 0)
        Me.lcType.Name = "lcType"
        Me.lcType.Size = New System.Drawing.Size(390, 24)
        Me.lcType.Text = "Type"
        Me.lcType.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcSoldDate
        '
        Me.lcSoldDate.Control = Me.txtSold
        Me.lcSoldDate.Location = New System.Drawing.Point(392, 24)
        Me.lcSoldDate.Name = "lcSoldDate"
        Me.lcSoldDate.Size = New System.Drawing.Size(390, 24)
        Me.lcSoldDate.Text = "Sold Date"
        Me.lcSoldDate.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcStartdate
        '
        Me.lcStartdate.Control = Me.txtStartDate
        Me.lcStartdate.Location = New System.Drawing.Point(392, 48)
        Me.lcStartdate.Name = "lcStartdate"
        Me.lcStartdate.Size = New System.Drawing.Size(390, 24)
        Me.lcStartdate.Text = "Start Date"
        Me.lcStartdate.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcValue
        '
        Me.lcValue.Control = Me.txtValue
        Me.lcValue.Location = New System.Drawing.Point(392, 72)
        Me.lcValue.Name = "lcValue"
        Me.lcValue.Size = New System.Drawing.Size(390, 24)
        Me.lcValue.Text = "Value"
        Me.lcValue.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcPreviousProvider
        '
        Me.lcPreviousProvider.Control = Me.txtPreviousProvider
        Me.lcPreviousProvider.Location = New System.Drawing.Point(392, 120)
        Me.lcPreviousProvider.Name = "lcPreviousProvider"
        Me.lcPreviousProvider.Size = New System.Drawing.Size(390, 24)
        Me.lcPreviousProvider.Text = "Previous Provider"
        Me.lcPreviousProvider.TextSize = New System.Drawing.Size(108, 13)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(392, 96)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(390, 24)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'lcReasonNotPresented
        '
        Me.lcReasonNotPresented.Control = Me.txtReasonNotPresented
        Me.lcReasonNotPresented.Location = New System.Drawing.Point(0, 144)
        Me.lcReasonNotPresented.Name = "lcReasonNotPresented"
        Me.lcReasonNotPresented.Size = New System.Drawing.Size(782, 24)
        Me.lcReasonNotPresented.Text = "Reason not presented"
        Me.lcReasonNotPresented.TextSize = New System.Drawing.Size(108, 13)
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcLifeValue, Me.lcLifeOutcome, Me.lcLifeNextContact, Me.lcLifeStartDate, Me.lcLifeReasonNotPresented, Me.lcLifeSoldDate})
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup12.Name = "LayoutControlGroup12"
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(782, 168)
        Me.LayoutControlGroup12.Text = "Life"
        '
        'lcLifeValue
        '
        Me.lcLifeValue.Control = Me.txtLifeValue
        Me.lcLifeValue.Location = New System.Drawing.Point(392, 0)
        Me.lcLifeValue.Name = "lcLifeValue"
        Me.lcLifeValue.Size = New System.Drawing.Size(390, 24)
        Me.lcLifeValue.Text = "Value"
        Me.lcLifeValue.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcLifeOutcome
        '
        Me.lcLifeOutcome.Control = Me.txtLifeOutcome
        Me.lcLifeOutcome.Location = New System.Drawing.Point(0, 0)
        Me.lcLifeOutcome.Name = "lcLifeOutcome"
        Me.lcLifeOutcome.Size = New System.Drawing.Size(392, 24)
        Me.lcLifeOutcome.Text = "Outcome"
        Me.lcLifeOutcome.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcLifeNextContact
        '
        Me.lcLifeNextContact.Control = Me.txtLifeNextContact
        Me.lcLifeNextContact.Location = New System.Drawing.Point(0, 24)
        Me.lcLifeNextContact.Name = "lcLifeNextContact"
        Me.lcLifeNextContact.Size = New System.Drawing.Size(392, 48)
        Me.lcLifeNextContact.Text = "Next Contact"
        Me.lcLifeNextContact.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcLifeStartDate
        '
        Me.lcLifeStartDate.Control = Me.txtLifeStartDate
        Me.lcLifeStartDate.Location = New System.Drawing.Point(392, 24)
        Me.lcLifeStartDate.Name = "lcLifeStartDate"
        Me.lcLifeStartDate.Size = New System.Drawing.Size(390, 24)
        Me.lcLifeStartDate.Text = "Start Date"
        Me.lcLifeStartDate.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcLifeReasonNotPresented
        '
        Me.lcLifeReasonNotPresented.Control = Me.txtLifeReasonNotPresented
        Me.lcLifeReasonNotPresented.Location = New System.Drawing.Point(0, 72)
        Me.lcLifeReasonNotPresented.Name = "lcLifeReasonNotPresented"
        Me.lcLifeReasonNotPresented.Size = New System.Drawing.Size(782, 96)
        Me.lcLifeReasonNotPresented.Text = "Reason Not Presented"
        Me.lcLifeReasonNotPresented.TextSize = New System.Drawing.Size(108, 13)
        '
        'lcLifeSoldDate
        '
        Me.lcLifeSoldDate.Control = Me.txtLifeSoldDate
        Me.lcLifeSoldDate.Location = New System.Drawing.Point(392, 48)
        Me.lcLifeSoldDate.Name = "lcLifeSoldDate"
        Me.lcLifeSoldDate.Size = New System.Drawing.Size(390, 24)
        Me.lcLifeSoldDate.Text = "Sold Date"
        Me.lcLifeSoldDate.TextSize = New System.Drawing.Size(108, 13)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcConclusion, Me.EmptySpaceItem5})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(798, 206)
        Me.LayoutControlGroup9.Text = "Conclusion"
        '
        'lcConclusion
        '
        Me.lcConclusion.Control = Me.txtConclusion
        Me.lcConclusion.Location = New System.Drawing.Point(0, 0)
        Me.lcConclusion.Name = "lcConclusion"
        Me.lcConclusion.Size = New System.Drawing.Size(798, 24)
        Me.lcConclusion.Text = "Conclusion"
        Me.lcConclusion.TextSize = New System.Drawing.Size(108, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(798, 182)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAppoinmentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(821, 747)
        Me.Controls.Add(Me.lblAppointmentTime)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.panelEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAppoinmentDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Appointment"
        Me.panelEmail.ResumeLayout(False)
        Me.panelEmail.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcWasInsured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcbtnMakeLive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCoverRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcForename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcSurname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAddress1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAddress2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcRenewal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAddress3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcNumberOfEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabSurvey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSPunctual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSProfessional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSCalledBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSQuotedInMeeting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSQuoteMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSQuoteInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSSent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcCSCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAppSat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcInvolvedPMI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFBNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcOutCome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcNextContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFBPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFBProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFBRenewal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcSoldDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcStartdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcPreviousProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcReasonNotPresented, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeOutcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeNextContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeReasonNotPresented, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLifeSoldDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtContactPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContactForeName As System.Windows.Forms.TextBox
    Friend WithEvents txtContactSurname As System.Windows.Forms.TextBox
    Friend WithEvents BtnRepEmail As System.Windows.Forms.Button
    Friend WithEvents BtnRepFax As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TxtAgent As System.Windows.Forms.TextBox
    Friend WithEvents txtRenewal As System.Windows.Forms.TextBox
    Friend WithEvents TxtProvider As System.Windows.Forms.TextBox
    Friend WithEvents txtRep As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents BtnCustomerPrint As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerEmail As System.Windows.Forms.Button
    Friend WithEvents btnCustomerFax As System.Windows.Forms.Button
    Friend WithEvents panelEmail As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCallRep As System.Windows.Forms.Button
    Friend WithEvents BtnCallCust As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblAppointmentTime As System.Windows.Forms.Label
    Friend WithEvents BtnMakeLive As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnChangeAddress As System.Windows.Forms.Button
    Friend WithEvents ChangeProviderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmed As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtAppSat As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents txtfbContact As System.Windows.Forms.TextBox
    Friend WithEvents txtfbposition As System.Windows.Forms.TextBox
    Friend WithEvents txtfbRenewal As System.Windows.Forms.TextBox
    Friend WithEvents txtfbProvider As System.Windows.Forms.TextBox
    Friend WithEvents txtSold As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtOutcome As System.Windows.Forms.TextBox
    Friend WithEvents txtPMI As System.Windows.Forms.TextBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents ShowCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboWasInsured As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcSurname As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcTitle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcForename As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcPosition As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcTelephone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcFax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcEmail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCompany As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcAddress1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcAddress2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcAddress3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcTown As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCounty As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcPostcode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcRep As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcConfirm As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcWasInsured As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcStatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcbtnMakeLive As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcAgent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcArea As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcRenewal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcProvider As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboCoverRequired As System.Windows.Forms.ComboBox
    Friend WithEvents lcCoverRequired As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcNotes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LVHistory As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Who As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppointmentNote As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddedOn As System.Windows.Forms.ColumnHeader
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tabControl As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcConclusion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcFBNotes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtEmployees As System.Windows.Forms.TextBox
    Friend WithEvents lcNumberOfEmployees As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tabSurvey As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnSurvey As System.Windows.Forms.Button
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtProfessional As System.Windows.Forms.TextBox
    Friend WithEvents txtPunctual As System.Windows.Forms.TextBox
    Friend WithEvents lcCSPunctual As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCSProfessional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCalledBefore As System.Windows.Forms.TextBox
    Friend WithEvents lcCSCalledBefore As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtQuotedInMeeting As System.Windows.Forms.TextBox
    Friend WithEvents lcCSQuotedInMeeting As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteMethod As System.Windows.Forms.TextBox
    Friend WithEvents lcCSQuoteMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCSQuoteInfo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCSComments As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPMINextContact As System.Windows.Forms.TextBox
    Friend WithEvents txtLifeNextContact As System.Windows.Forms.TextBox
    Friend WithEvents txtLifeOutcome As System.Windows.Forms.TextBox
    Friend WithEvents txtLifeValue As System.Windows.Forms.TextBox
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcAppSat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcInvolvedPMI As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcOutCome As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcNextContact As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcContact As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcFBPosition As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcFBProvider As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcFBRenewal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcSoldDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcStartdate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcValue As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcLifeValue As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcLifeOutcome As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcLifeNextContact As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReasonNotPresented As System.Windows.Forms.TextBox
    Friend WithEvents txtPreviousProvider As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcPreviousProvider As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lcReasonNotPresented As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtLifeReasonNotPresented As System.Windows.Forms.TextBox
    Friend WithEvents txtLifeSoldDate As System.Windows.Forms.TextBox
    Friend WithEvents txtLifeStartDate As System.Windows.Forms.TextBox
    Friend WithEvents lcLifeStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcLifeSoldDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcLifeReasonNotPresented As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCSCompleted As System.Windows.Forms.TextBox
    Friend WithEvents txtCSSent As System.Windows.Forms.TextBox
    Friend WithEvents lcCSSent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcCSCompleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ListenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
End Class
