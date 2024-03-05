<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallbackStats
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.deEnd = New DevExpress.XtraEditors.DateEdit()
        Me.deStart = New DevExpress.XtraEditors.DateEdit()
        Me.gv = New DevExpress.XtraGrid.GridControl()
        Me.CCallbackStatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanies = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppointments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoldValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnconcluded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCallbacks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotInterested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumberNotRecognised = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutOfArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupervisor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFuture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeedsAttention = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadAgent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPending = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotSold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadRep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadOther = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToExpencive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistingMedical = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcStart = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcEnd = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.deEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCallbackStatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BtnRefresh)
        Me.LayoutControl1.Controls.Add(Me.deEnd)
        Me.LayoutControl1.Controls.Add(Me.deStart)
        Me.LayoutControl1.Controls.Add(Me.gv)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(362, 198, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1399, 655)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(704, 12)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(199, 22)
        Me.BtnRefresh.StyleController = Me.LayoutControl1
        Me.BtnRefresh.TabIndex = 7
        Me.BtnRefresh.Text = "Refresh"
        '
        'deEnd
        '
        Me.deEnd.EditValue = Nothing
        Me.deEnd.Location = New System.Drawing.Point(390, 12)
        Me.deEnd.Name = "deEnd"
        Me.deEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEnd.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.deEnd.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.deEnd.Size = New System.Drawing.Size(259, 20)
        Me.deEnd.StyleController = Me.LayoutControl1
        Me.deEnd.TabIndex = 6
        '
        'deStart
        '
        Me.deStart.EditValue = Nothing
        Me.deStart.Location = New System.Drawing.Point(39, 12)
        Me.deStart.Name = "deStart"
        Me.deStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStart.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.deStart.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.deStart.Size = New System.Drawing.Size(279, 20)
        Me.deStart.StyleController = Me.LayoutControl1
        Me.deStart.TabIndex = 5
        '
        'gv
        '
        Me.gv.DataSource = Me.CCallbackStatsBindingSource
        Me.gv.Location = New System.Drawing.Point(12, 48)
        Me.gv.MainView = Me.GridView1
        Me.gv.Name = "gv"
        Me.gv.Size = New System.Drawing.Size(1375, 595)
        Me.gv.TabIndex = 4
        Me.gv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CCallbackStatsBindingSource
        '
        Me.CCallbackStatsBindingSource.DataSource = GetType(CADNet.CallQueues.ManagerConsole.cCallbackStats)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAgentName, Me.colCompanies, Me.colAppointments, Me.colSat, Me.colSold, Me.colSoldValue, Me.colUnconcluded, Me.colCallbacks, Me.colNotInterested, Me.colNumberNotRecognised, Me.colOutOfArea, Me.colSupervisor, Me.colFuture, Me.colNeedsAttention, Me.colDeadAgent, Me.colPending, Me.colNotSold, Me.colDeadRep, Me.colDeadCompany, Me.colDeadOther, Me.colToExpencive, Me.colExistingMedical})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView1.GridControl = Me.gv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSoldValue, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colAgentName
        '
        Me.colAgentName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAgentName.AppearanceCell.Options.UseBackColor = True
        Me.colAgentName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAgentName.AppearanceHeader.Options.UseBackColor = True
        Me.colAgentName.Caption = "Agent"
        Me.colAgentName.FieldName = "AgentName"
        Me.colAgentName.Name = "colAgentName"
        Me.colAgentName.Visible = True
        Me.colAgentName.VisibleIndex = 0
        Me.colAgentName.Width = 76
        '
        'colCompanies
        '
        Me.colCompanies.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompanies.AppearanceCell.Options.UseBackColor = True
        Me.colCompanies.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompanies.AppearanceHeader.Options.UseBackColor = True
        Me.colCompanies.FieldName = "Companies"
        Me.colCompanies.Name = "colCompanies"
        Me.colCompanies.Visible = True
        Me.colCompanies.VisibleIndex = 1
        Me.colCompanies.Width = 56
        '
        'colAppointments
        '
        Me.colAppointments.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAppointments.AppearanceCell.Options.UseBackColor = True
        Me.colAppointments.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAppointments.AppearanceHeader.Options.UseBackColor = True
        Me.colAppointments.FieldName = "Appointments"
        Me.colAppointments.Name = "colAppointments"
        Me.colAppointments.Visible = True
        Me.colAppointments.VisibleIndex = 2
        Me.colAppointments.Width = 67
        '
        'colSat
        '
        Me.colSat.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSat.AppearanceCell.Options.UseBackColor = True
        Me.colSat.FieldName = "Sat"
        Me.colSat.Name = "colSat"
        Me.colSat.Visible = True
        Me.colSat.VisibleIndex = 3
        '
        'colSold
        '
        Me.colSold.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSold.AppearanceCell.Options.UseBackColor = True
        Me.colSold.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSold.AppearanceHeader.Options.UseBackColor = True
        Me.colSold.FieldName = "Sold"
        Me.colSold.Name = "colSold"
        Me.colSold.Visible = True
        Me.colSold.VisibleIndex = 4
        Me.colSold.Width = 43
        '
        'colSoldValue
        '
        Me.colSoldValue.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSoldValue.AppearanceCell.Options.UseBackColor = True
        Me.colSoldValue.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSoldValue.AppearanceHeader.Options.UseBackColor = True
        Me.colSoldValue.DisplayFormat.FormatString = "n2"
        Me.colSoldValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSoldValue.FieldName = "SoldValue"
        Me.colSoldValue.Name = "colSoldValue"
        Me.colSoldValue.Visible = True
        Me.colSoldValue.VisibleIndex = 5
        Me.colSoldValue.Width = 77
        '
        'colUnconcluded
        '
        Me.colUnconcluded.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUnconcluded.AppearanceCell.Options.UseBackColor = True
        Me.colUnconcluded.FieldName = "Unconcluded"
        Me.colUnconcluded.Name = "colUnconcluded"
        Me.colUnconcluded.Visible = True
        Me.colUnconcluded.VisibleIndex = 6
        '
        'colCallbacks
        '
        Me.colCallbacks.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCallbacks.AppearanceCell.Options.UseBackColor = True
        Me.colCallbacks.Caption = "Callback"
        Me.colCallbacks.FieldName = "Callbacks"
        Me.colCallbacks.Name = "colCallbacks"
        Me.colCallbacks.Visible = True
        Me.colCallbacks.VisibleIndex = 7
        Me.colCallbacks.Width = 85
        '
        'colNotInterested
        '
        Me.colNotInterested.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNotInterested.AppearanceCell.Options.UseBackColor = True
        Me.colNotInterested.FieldName = "NotInterested"
        Me.colNotInterested.Name = "colNotInterested"
        Me.colNotInterested.Visible = True
        Me.colNotInterested.VisibleIndex = 8
        Me.colNotInterested.Width = 69
        '
        'colNumberNotRecognised
        '
        Me.colNumberNotRecognised.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNumberNotRecognised.AppearanceCell.Options.UseBackColor = True
        Me.colNumberNotRecognised.Caption = "Not a Number"
        Me.colNumberNotRecognised.FieldName = "NumberNotRecognised"
        Me.colNumberNotRecognised.Name = "colNumberNotRecognised"
        Me.colNumberNotRecognised.Visible = True
        Me.colNumberNotRecognised.VisibleIndex = 9
        Me.colNumberNotRecognised.Width = 104
        '
        'colOutOfArea
        '
        Me.colOutOfArea.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOutOfArea.AppearanceCell.Options.UseBackColor = True
        Me.colOutOfArea.FieldName = "OutOfArea"
        Me.colOutOfArea.Name = "colOutOfArea"
        Me.colOutOfArea.Visible = True
        Me.colOutOfArea.VisibleIndex = 10
        Me.colOutOfArea.Width = 60
        '
        'colSupervisor
        '
        Me.colSupervisor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSupervisor.AppearanceCell.Options.UseBackColor = True
        Me.colSupervisor.FieldName = "Supervisor"
        Me.colSupervisor.Name = "colSupervisor"
        Me.colSupervisor.Visible = True
        Me.colSupervisor.VisibleIndex = 11
        Me.colSupervisor.Width = 53
        '
        'colFuture
        '
        Me.colFuture.FieldName = "Future"
        Me.colFuture.Name = "colFuture"
        Me.colFuture.Visible = True
        Me.colFuture.VisibleIndex = 12
        '
        'colNeedsAttention
        '
        Me.colNeedsAttention.Caption = "Cancelled"
        Me.colNeedsAttention.FieldName = "NeedsAttention"
        Me.colNeedsAttention.Name = "colNeedsAttention"
        Me.colNeedsAttention.Visible = True
        Me.colNeedsAttention.VisibleIndex = 13
        Me.colNeedsAttention.Width = 82
        '
        'colDeadAgent
        '
        Me.colDeadAgent.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeadAgent.AppearanceCell.Options.UseBackColor = True
        Me.colDeadAgent.FieldName = "DeadAgent"
        Me.colDeadAgent.Name = "colDeadAgent"
        Me.colDeadAgent.Visible = True
        Me.colDeadAgent.VisibleIndex = 14
        Me.colDeadAgent.Width = 84
        '
        'colPending
        '
        Me.colPending.FieldName = "Pending"
        Me.colPending.Name = "colPending"
        Me.colPending.Visible = True
        Me.colPending.VisibleIndex = 18
        Me.colPending.Width = 73
        '
        'colNotSold
        '
        Me.colNotSold.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNotSold.AppearanceCell.Options.UseBackColor = True
        Me.colNotSold.FieldName = "NotSold"
        Me.colNotSold.Name = "colNotSold"
        Me.colNotSold.Visible = True
        Me.colNotSold.VisibleIndex = 19
        Me.colNotSold.Width = 63
        '
        'colDeadRep
        '
        Me.colDeadRep.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeadRep.AppearanceCell.Options.UseBackColor = True
        Me.colDeadRep.FieldName = "DeadRep"
        Me.colDeadRep.Name = "colDeadRep"
        Me.colDeadRep.Visible = True
        Me.colDeadRep.VisibleIndex = 15
        Me.colDeadRep.Width = 84
        '
        'colDeadCompany
        '
        Me.colDeadCompany.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeadCompany.AppearanceCell.Options.UseBackColor = True
        Me.colDeadCompany.FieldName = "DeadCompany"
        Me.colDeadCompany.Name = "colDeadCompany"
        Me.colDeadCompany.Visible = True
        Me.colDeadCompany.VisibleIndex = 16
        Me.colDeadCompany.Width = 89
        '
        'colDeadOther
        '
        Me.colDeadOther.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeadOther.AppearanceCell.Options.UseBackColor = True
        Me.colDeadOther.FieldName = "DeadOther"
        Me.colDeadOther.Name = "colDeadOther"
        Me.colDeadOther.Visible = True
        Me.colDeadOther.VisibleIndex = 17
        Me.colDeadOther.Width = 68
        '
        'colToExpencive
        '
        Me.colToExpencive.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colToExpencive.AppearanceCell.Options.UseBackColor = True
        Me.colToExpencive.FieldName = "ToExpencive"
        Me.colToExpencive.Name = "colToExpencive"
        Me.colToExpencive.Visible = True
        Me.colToExpencive.VisibleIndex = 20
        Me.colToExpencive.Width = 67
        '
        'colExistingMedical
        '
        Me.colExistingMedical.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExistingMedical.AppearanceCell.Options.UseBackColor = True
        Me.colExistingMedical.FieldName = "ExistingMedical"
        Me.colExistingMedical.Name = "colExistingMedical"
        Me.colExistingMedical.Visible = True
        Me.colExistingMedical.VisibleIndex = 21
        Me.colExistingMedical.Width = 62
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lcStart, Me.lcEnd, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1399, 655)
        Me.LayoutControlGroup1.Text = "Root"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gv
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1379, 599)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'lcStart
        '
        Me.lcStart.Control = Me.deStart
        Me.lcStart.CustomizationFormText = "LayoutControlItem2"
        Me.lcStart.Location = New System.Drawing.Point(0, 0)
        Me.lcStart.Name = "lcStart"
        Me.lcStart.Size = New System.Drawing.Size(310, 26)
        Me.lcStart.Text = "Start"
        Me.lcStart.TextSize = New System.Drawing.Size(24, 13)
        '
        'lcEnd
        '
        Me.lcEnd.Control = Me.deEnd
        Me.lcEnd.CustomizationFormText = "LayoutControlItem3"
        Me.lcEnd.Location = New System.Drawing.Point(351, 0)
        Me.lcEnd.Name = "lcEnd"
        Me.lcEnd.Size = New System.Drawing.Size(290, 26)
        Me.lcEnd.Text = "End"
        Me.lcEnd.TextSize = New System.Drawing.Size(24, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.BtnRefresh
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(692, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(203, 26)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(310, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(41, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(641, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(51, 26)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(895, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(484, 26)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(0, 10)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1379, 10)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'sfd
        '
        Me.sfd.FileName = "CallbackStats.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1399, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToXlsToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'ExportToXlsToolStripMenuItem
        '
        Me.ExportToXlsToolStripMenuItem.Name = "ExportToXlsToolStripMenuItem"
        Me.ExportToXlsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExportToXlsToolStripMenuItem.Text = "Export to Xls"
        '
        'frmCallbackStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 679)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmCallbackStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Callback Stats"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.deEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCallbackStatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CCallbackStatsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colAgentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanies As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppointments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCallbacks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotInterested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumberNotRecognised As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutOfArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupervisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeedsAttention As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPending As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoldValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotSold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToExpencive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistingMedical As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadAgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadRep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadOther As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lcStart As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcEnd As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colFuture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnconcluded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colSat As DevExpress.XtraGrid.Columns.GridColumn
End Class
