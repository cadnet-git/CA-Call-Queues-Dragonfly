<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerformanceNew
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
        Me.DTPEnd = New System.Windows.Forms.DateTimePicker()
        Me.DTPStart = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.BtnExport = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.AppointmentStatsNewHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbReportType = New System.Windows.Forms.ComboBox()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRealName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTotalApps = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColAppointmentsInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColAppointmentsNoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAppointmentNotSure = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridDeadTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColDeadInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDeadNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAppsSat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAppsSatInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAppsSatNoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPending = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPendingInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colpendingNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColSold = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colsoldinsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColSoldNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColAPI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColApiinsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApiNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPrivateSold = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPrivateInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrivateNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPrivateAPI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrivatAPIInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrivateAPINoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colComercialsold = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colComercialSoldInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColComercialSoldNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colComercialAPI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCoemrcialInsuredAPI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colcomercialNocoverAPI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colNotSold = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNotSoldInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNotSoldNoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand13 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColToExpencive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColToExpenciveInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColToExpenciveNocover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand14 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colExistingMedical = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExistingMedicalInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExistingMedicalNoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand15 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colNoFeedback = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNoFeedbackInsured = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNoFeedbackNoCover = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.AppointmentStatsNewHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPEnd
        '
        Me.DTPEnd.CustomFormat = ""
        Me.DTPEnd.Location = New System.Drawing.Point(214, 11)
        Me.DTPEnd.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DTPEnd.Name = "DTPEnd"
        Me.DTPEnd.Size = New System.Drawing.Size(153, 20)
        Me.DTPEnd.TabIndex = 9
        '
        'DTPStart
        '
        Me.DTPStart.Location = New System.Drawing.Point(37, 11)
        Me.DTPStart.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.Size = New System.Drawing.Size(153, 20)
        Me.DTPStart.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.boxes
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(531, 9)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 23)
        Me.BtnRefresh.TabIndex = 0
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.BtnExport)
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(1006, 53)
        Me.pnlAreaHeader.TabIndex = 6
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(905, 13)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(75, 23)
        Me.BtnExport.TabIndex = 8
        Me.BtnExport.Text = "Excel"
        Me.BtnExport.UseVisualStyleBackColor = True
        Me.BtnExport.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Performance New"
        '
        'AppointmentStatsNewHeaderBindingSource
        '
        Me.AppointmentStatsNewHeaderBindingSource.DataSource = GetType(CADNet.CallQueues.ManagerConsole.AppointmentStatsNewHeader)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbReportType)
        Me.Panel1.Controls.Add(Me.DTPStart)
        Me.Panel1.Controls.Add(Me.DTPEnd)
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 40)
        Me.Panel1.TabIndex = 13
        '
        'cbReportType
        '
        Me.cbReportType.FormattingEnabled = True
        Me.cbReportType.Items.AddRange(New Object() {"Rep", "Agent"})
        Me.cbReportType.Location = New System.Drawing.Point(374, 11)
        Me.cbReportType.Name = "cbReportType"
        Me.cbReportType.Size = New System.Drawing.Size(121, 21)
        Me.cbReportType.TabIndex = 10
        Me.cbReportType.Text = "Rep"
        '
        'Grid
        '
        Me.Grid.DataSource = Me.AppointmentStatsNewHeaderBindingSource
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 93)
        Me.Grid.MainView = Me.AdvBandedGridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1006, 570)
        Me.Grid.TabIndex = 14
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray
        Me.AdvBandedGridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4, Me.GridBand5, Me.GridBand6, Me.GridBand7, Me.GridBand8, Me.GridBand9, Me.GridBand10, Me.GridBand11, Me.GridBand12, Me.GridBand13, Me.GridBand14, Me.GridBand15})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colRealName, Me.GridDeadTotal, Me.ColDeadInsured, Me.colDeadNocover, Me.colTotalApps, Me.ColAppointmentsInsured, Me.ColAppointmentsNoCover, Me.colAppointmentNotSure, Me.colAppsSat, Me.colAppsSatInsured, Me.colAppsSatNoCover, Me.ColSold, Me.colsoldinsured, Me.ColSoldNocover, Me.ColAPI, Me.ColApiinsured, Me.colApiNocover, Me.colPrivateSold, Me.ColPrivateInsured, Me.colPrivateNocover, Me.colPrivateAPI, Me.colPrivatAPIInsured, Me.colPrivateAPINoCover, Me.colComercialsold, Me.colComercialSoldInsured, Me.ColComercialSoldNocover, Me.colComercialAPI, Me.colCoemrcialInsuredAPI, Me.colcomercialNocoverAPI, Me.colPending, Me.colPendingInsured, Me.colpendingNocover, Me.colNotSold, Me.colNotSoldInsured, Me.colNotSoldNoCover, Me.ColToExpencive, Me.ColToExpenciveInsured, Me.ColToExpenciveNocover, Me.colExistingMedical, Me.colExistingMedicalInsured, Me.colExistingMedicalNoCover, Me.colNoFeedback, Me.colNoFeedbackInsured, Me.colNoFeedbackNoCover})
        Me.AdvBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.AdvBandedGridView1.GridControl = Me.Grid
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsCustomization.AllowGroup = False
        Me.AdvBandedGridView1.OptionsMenu.EnableColumnMenu = False
        Me.AdvBandedGridView1.OptionsMenu.EnableFooterMenu = False
        Me.AdvBandedGridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.AdvBandedGridView1.OptionsPrint.AutoWidth = False
        Me.AdvBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.AdvBandedGridView1.OptionsPrint.PrintBandHeader = False
        Me.AdvBandedGridView1.OptionsPrint.UsePrintStyles = True
        Me.AdvBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AdvBandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.AdvBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.AdvBandedGridView1.OptionsView.ShowBands = False
        Me.AdvBandedGridView1.OptionsView.ShowFooter = True
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        Me.AdvBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRealName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.colRealName)
        Me.GridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 108
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.Name = "colRealName"
        Me.colRealName.RowCount = 2
        Me.colRealName.Visible = True
        Me.colRealName.Width = 108
        '
        'GridBand2
        '
        Me.GridBand2.Columns.Add(Me.colTotalApps)
        Me.GridBand2.Columns.Add(Me.ColAppointmentsInsured)
        Me.GridBand2.Columns.Add(Me.ColAppointmentsNoCover)
        Me.GridBand2.Columns.Add(Me.colAppointmentNotSure)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 225
        '
        'colTotalApps
        '
        Me.colTotalApps.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalApps.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalApps.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalApps.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalApps.Caption = "Appointments"
        Me.colTotalApps.FieldName = "Total.AppointmentTotal"
        Me.colTotalApps.Name = "colTotalApps"
        Me.colTotalApps.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.AppointmentTotal", "{0:n0}")})
        Me.colTotalApps.Visible = True
        Me.colTotalApps.Width = 225
        '
        'ColAppointmentsInsured
        '
        Me.ColAppointmentsInsured.AppearanceCell.Options.UseTextOptions = True
        Me.ColAppointmentsInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAppointmentsInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAppointmentsInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAppointmentsInsured.Caption = "Insured"
        Me.ColAppointmentsInsured.FieldName = "Insured.AppointmentTotal"
        Me.ColAppointmentsInsured.Name = "ColAppointmentsInsured"
        Me.ColAppointmentsInsured.RowIndex = 1
        Me.ColAppointmentsInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.AppointmentTotal", "{0:n0}")})
        Me.ColAppointmentsInsured.Visible = True
        '
        'ColAppointmentsNoCover
        '
        Me.ColAppointmentsNoCover.AppearanceCell.Options.UseTextOptions = True
        Me.ColAppointmentsNoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAppointmentsNoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAppointmentsNoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAppointmentsNoCover.Caption = "No Cover"
        Me.ColAppointmentsNoCover.FieldName = "Nocover.AppointmentTotal"
        Me.ColAppointmentsNoCover.Name = "ColAppointmentsNoCover"
        Me.ColAppointmentsNoCover.RowIndex = 1
        Me.ColAppointmentsNoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.AppointmentTotal", "{0:n0}")})
        Me.ColAppointmentsNoCover.Visible = True
        '
        'colAppointmentNotSure
        '
        Me.colAppointmentNotSure.AppearanceCell.Options.UseTextOptions = True
        Me.colAppointmentNotSure.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppointmentNotSure.AppearanceHeader.Options.UseTextOptions = True
        Me.colAppointmentNotSure.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppointmentNotSure.Caption = "Unclasified"
        Me.colAppointmentNotSure.FieldName = "NoIdea.AppointmentTotal"
        Me.colAppointmentNotSure.Name = "colAppointmentNotSure"
        Me.colAppointmentNotSure.RowIndex = 1
        Me.colAppointmentNotSure.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NoIdea.AppointmentTotal", "{0:n0}")})
        Me.colAppointmentNotSure.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.Columns.Add(Me.GridDeadTotal)
        Me.GridBand3.Columns.Add(Me.ColDeadInsured)
        Me.GridBand3.Columns.Add(Me.colDeadNocover)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.OptionsBand.ShowInCustomizationForm = False
        Me.GridBand3.Width = 150
        '
        'GridDeadTotal
        '
        Me.GridDeadTotal.AppearanceCell.Options.UseTextOptions = True
        Me.GridDeadTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridDeadTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.GridDeadTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridDeadTotal.Caption = "Dead"
        Me.GridDeadTotal.FieldName = "Total.DeadTotal"
        Me.GridDeadTotal.Name = "GridDeadTotal"
        Me.GridDeadTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.DeadTotal", "{0:n0}")})
        Me.GridDeadTotal.Visible = True
        Me.GridDeadTotal.Width = 150
        '
        'ColDeadInsured
        '
        Me.ColDeadInsured.AppearanceCell.Options.UseTextOptions = True
        Me.ColDeadInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDeadInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDeadInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDeadInsured.Caption = "Insured"
        Me.ColDeadInsured.FieldName = "Insured.DeadTotal"
        Me.ColDeadInsured.Name = "ColDeadInsured"
        Me.ColDeadInsured.RowIndex = 1
        Me.ColDeadInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.DeadTotal", "{0:n0}")})
        Me.ColDeadInsured.Visible = True
        '
        'colDeadNocover
        '
        Me.colDeadNocover.AppearanceCell.Options.UseTextOptions = True
        Me.colDeadNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeadNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeadNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeadNocover.Caption = "No Cover"
        Me.colDeadNocover.FieldName = "Nocover.DeadTotal"
        Me.colDeadNocover.Name = "colDeadNocover"
        Me.colDeadNocover.RowIndex = 1
        Me.colDeadNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.DeadTotal", "{0:n0}")})
        Me.colDeadNocover.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Columns.Add(Me.colAppsSat)
        Me.GridBand4.Columns.Add(Me.colAppsSatInsured)
        Me.GridBand4.Columns.Add(Me.colAppsSatNoCover)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 150
        '
        'colAppsSat
        '
        Me.colAppsSat.AppearanceCell.Options.UseTextOptions = True
        Me.colAppsSat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSat.AppearanceHeader.Options.UseTextOptions = True
        Me.colAppsSat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSat.Caption = "Appointments Sat"
        Me.colAppsSat.FieldName = "Total.AppsSat"
        Me.colAppsSat.Name = "colAppsSat"
        Me.colAppsSat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.AppsSat", "{0:n0}")})
        Me.colAppsSat.Visible = True
        Me.colAppsSat.Width = 150
        '
        'colAppsSatInsured
        '
        Me.colAppsSatInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colAppsSatInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSatInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colAppsSatInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSatInsured.Caption = "Insured"
        Me.colAppsSatInsured.FieldName = "Insured.AppsSat"
        Me.colAppsSatInsured.Name = "colAppsSatInsured"
        Me.colAppsSatInsured.RowIndex = 1
        Me.colAppsSatInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.AppsSat", "{0:n0}")})
        Me.colAppsSatInsured.Visible = True
        '
        'colAppsSatNoCover
        '
        Me.colAppsSatNoCover.AppearanceCell.Options.UseTextOptions = True
        Me.colAppsSatNoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSatNoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.colAppsSatNoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAppsSatNoCover.Caption = "No Cover"
        Me.colAppsSatNoCover.FieldName = "Nocover.AppsSat"
        Me.colAppsSatNoCover.Name = "colAppsSatNoCover"
        Me.colAppsSatNoCover.RowIndex = 1
        Me.colAppsSatNoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.AppsSat", "{0:n0}")})
        Me.colAppsSatNoCover.Visible = True
        '
        'GridBand5
        '
        Me.GridBand5.Columns.Add(Me.colPending)
        Me.GridBand5.Columns.Add(Me.colPendingInsured)
        Me.GridBand5.Columns.Add(Me.colpendingNocover)
        Me.GridBand5.MinWidth = 20
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 150
        '
        'colPending
        '
        Me.colPending.AppearanceCell.Options.UseTextOptions = True
        Me.colPending.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPending.AppearanceHeader.Options.UseTextOptions = True
        Me.colPending.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPending.Caption = "Pending"
        Me.colPending.FieldName = "Total.Pending"
        Me.colPending.Name = "colPending"
        Me.colPending.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.Pending", "{0:n0}")})
        Me.colPending.Visible = True
        Me.colPending.Width = 150
        '
        'colPendingInsured
        '
        Me.colPendingInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colPendingInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendingInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colPendingInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPendingInsured.Caption = "Insured"
        Me.colPendingInsured.FieldName = "Insured.Pending"
        Me.colPendingInsured.Name = "colPendingInsured"
        Me.colPendingInsured.RowIndex = 1
        Me.colPendingInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.Pending", "{0:n0}")})
        Me.colPendingInsured.Visible = True
        '
        'colpendingNocover
        '
        Me.colpendingNocover.AppearanceCell.Options.UseTextOptions = True
        Me.colpendingNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpendingNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.colpendingNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpendingNocover.Caption = "No Cover"
        Me.colpendingNocover.FieldName = "Nocover.Pending"
        Me.colpendingNocover.Name = "colpendingNocover"
        Me.colpendingNocover.RowIndex = 1
        Me.colpendingNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.Pending", "{0:n0}")})
        Me.colpendingNocover.Visible = True
        '
        'GridBand6
        '
        Me.GridBand6.Columns.Add(Me.ColSold)
        Me.GridBand6.Columns.Add(Me.colsoldinsured)
        Me.GridBand6.Columns.Add(Me.ColSoldNocover)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 150
        '
        'ColSold
        '
        Me.ColSold.AppearanceCell.Options.UseTextOptions = True
        Me.ColSold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSold.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSold.Caption = "Sold"
        Me.ColSold.FieldName = "Total.Sold"
        Me.ColSold.Name = "ColSold"
        Me.ColSold.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.Sold", "{0:n0}")})
        Me.ColSold.Visible = True
        Me.ColSold.Width = 150
        '
        'colsoldinsured
        '
        Me.colsoldinsured.AppearanceCell.Options.UseTextOptions = True
        Me.colsoldinsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsoldinsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colsoldinsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsoldinsured.Caption = "Insured"
        Me.colsoldinsured.FieldName = "Insured.Sold"
        Me.colsoldinsured.Name = "colsoldinsured"
        Me.colsoldinsured.RowIndex = 1
        Me.colsoldinsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.Sold", "{0:n0}")})
        Me.colsoldinsured.Visible = True
        '
        'ColSoldNocover
        '
        Me.ColSoldNocover.AppearanceCell.Options.UseTextOptions = True
        Me.ColSoldNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSoldNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSoldNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSoldNocover.Caption = "No Cover"
        Me.ColSoldNocover.FieldName = "Nocover.Sold"
        Me.ColSoldNocover.Name = "ColSoldNocover"
        Me.ColSoldNocover.RowIndex = 1
        Me.ColSoldNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.Sold", "{0:n0}")})
        Me.ColSoldNocover.Visible = True
        '
        'GridBand7
        '
        Me.GridBand7.Columns.Add(Me.ColAPI)
        Me.GridBand7.Columns.Add(Me.ColApiinsured)
        Me.GridBand7.Columns.Add(Me.colApiNocover)
        Me.GridBand7.MinWidth = 20
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 150
        '
        'ColAPI
        '
        Me.ColAPI.AppearanceCell.Options.UseTextOptions = True
        Me.ColAPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAPI.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAPI.Caption = "API"
        Me.ColAPI.DisplayFormat.FormatString = "n0"
        Me.ColAPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAPI.FieldName = "Total.Value"
        Me.ColAPI.Name = "ColAPI"
        Me.ColAPI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.Value", "{0:n0}")})
        Me.ColAPI.Visible = True
        Me.ColAPI.Width = 150
        '
        'ColApiinsured
        '
        Me.ColApiinsured.AppearanceCell.Options.UseTextOptions = True
        Me.ColApiinsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApiinsured.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApiinsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApiinsured.Caption = "Insured"
        Me.ColApiinsured.DisplayFormat.FormatString = "n0"
        Me.ColApiinsured.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColApiinsured.FieldName = "Insured.Value"
        Me.ColApiinsured.Name = "ColApiinsured"
        Me.ColApiinsured.RowIndex = 1
        Me.ColApiinsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.Value", "{0:n0}")})
        Me.ColApiinsured.Visible = True
        '
        'colApiNocover
        '
        Me.colApiNocover.AppearanceCell.Options.UseTextOptions = True
        Me.colApiNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApiNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.colApiNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApiNocover.Caption = "No Cover"
        Me.colApiNocover.DisplayFormat.FormatString = "n0"
        Me.colApiNocover.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colApiNocover.FieldName = "Nocover.Value"
        Me.colApiNocover.Name = "colApiNocover"
        Me.colApiNocover.RowIndex = 1
        Me.colApiNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.Value", "{0:n0}")})
        Me.colApiNocover.Visible = True
        '
        'GridBand8
        '
        Me.GridBand8.Columns.Add(Me.colPrivateSold)
        Me.GridBand8.Columns.Add(Me.ColPrivateInsured)
        Me.GridBand8.Columns.Add(Me.colPrivateNocover)
        Me.GridBand8.MinWidth = 20
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 150
        '
        'colPrivateSold
        '
        Me.colPrivateSold.AppearanceCell.Options.UseTextOptions = True
        Me.colPrivateSold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateSold.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrivateSold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateSold.Caption = "Private"
        Me.colPrivateSold.FieldName = "Total.PrivateSold"
        Me.colPrivateSold.Name = "colPrivateSold"
        Me.colPrivateSold.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.PrivateSold", "{0:n0}")})
        Me.colPrivateSold.Visible = True
        Me.colPrivateSold.Width = 150
        '
        'ColPrivateInsured
        '
        Me.ColPrivateInsured.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrivateInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrivateInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrivateInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrivateInsured.Caption = "Insured"
        Me.ColPrivateInsured.FieldName = "Insured.PrivateSold"
        Me.ColPrivateInsured.Name = "ColPrivateInsured"
        Me.ColPrivateInsured.RowIndex = 1
        Me.ColPrivateInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.PrivateSold", "{0:n0}")})
        Me.ColPrivateInsured.Visible = True
        '
        'colPrivateNocover
        '
        Me.colPrivateNocover.AppearanceCell.Options.UseTextOptions = True
        Me.colPrivateNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrivateNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateNocover.Caption = "No Cover"
        Me.colPrivateNocover.FieldName = "Nocover.PrivateSold"
        Me.colPrivateNocover.Name = "colPrivateNocover"
        Me.colPrivateNocover.RowIndex = 1
        Me.colPrivateNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.PrivateSold", "{0:n0}")})
        Me.colPrivateNocover.Visible = True
        '
        'GridBand9
        '
        Me.GridBand9.Columns.Add(Me.colPrivateAPI)
        Me.GridBand9.Columns.Add(Me.colPrivatAPIInsured)
        Me.GridBand9.Columns.Add(Me.colPrivateAPINoCover)
        Me.GridBand9.MinWidth = 20
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 150
        '
        'colPrivateAPI
        '
        Me.colPrivateAPI.AppearanceCell.Options.UseTextOptions = True
        Me.colPrivateAPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateAPI.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrivateAPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateAPI.Caption = "Private API"
        Me.colPrivateAPI.DisplayFormat.FormatString = "n0"
        Me.colPrivateAPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrivateAPI.FieldName = "Total.PrivateValue"
        Me.colPrivateAPI.Name = "colPrivateAPI"
        Me.colPrivateAPI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.PrivateValue", "{0:n0}")})
        Me.colPrivateAPI.Visible = True
        Me.colPrivateAPI.Width = 150
        '
        'colPrivatAPIInsured
        '
        Me.colPrivatAPIInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colPrivatAPIInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivatAPIInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrivatAPIInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivatAPIInsured.Caption = "Insured"
        Me.colPrivatAPIInsured.DisplayFormat.FormatString = "n0"
        Me.colPrivatAPIInsured.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrivatAPIInsured.FieldName = "Insured.PrivateValue"
        Me.colPrivatAPIInsured.Name = "colPrivatAPIInsured"
        Me.colPrivatAPIInsured.RowIndex = 1
        Me.colPrivatAPIInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.PrivateValue", "{0:n0}")})
        Me.colPrivatAPIInsured.Visible = True
        '
        'colPrivateAPINoCover
        '
        Me.colPrivateAPINoCover.AppearanceCell.Options.UseTextOptions = True
        Me.colPrivateAPINoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateAPINoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrivateAPINoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrivateAPINoCover.Caption = "No Cover"
        Me.colPrivateAPINoCover.DisplayFormat.FormatString = "n0"
        Me.colPrivateAPINoCover.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrivateAPINoCover.FieldName = "Nocover.PrivateValue"
        Me.colPrivateAPINoCover.Name = "colPrivateAPINoCover"
        Me.colPrivateAPINoCover.RowIndex = 1
        Me.colPrivateAPINoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.PrivateValue", "{0:n0}")})
        Me.colPrivateAPINoCover.Visible = True
        '
        'GridBand10
        '
        Me.GridBand10.Columns.Add(Me.colComercialsold)
        Me.GridBand10.Columns.Add(Me.colComercialSoldInsured)
        Me.GridBand10.Columns.Add(Me.ColComercialSoldNocover)
        Me.GridBand10.MinWidth = 20
        Me.GridBand10.Name = "GridBand10"
        Me.GridBand10.Width = 150
        '
        'colComercialsold
        '
        Me.colComercialsold.AppearanceCell.Options.UseTextOptions = True
        Me.colComercialsold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialsold.AppearanceHeader.Options.UseTextOptions = True
        Me.colComercialsold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialsold.Caption = "Comercial"
        Me.colComercialsold.FieldName = "Total.ComercialSold"
        Me.colComercialsold.Name = "colComercialsold"
        Me.colComercialsold.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.ComercialSold", "{0:n0}")})
        Me.colComercialsold.Visible = True
        Me.colComercialsold.Width = 150
        '
        'colComercialSoldInsured
        '
        Me.colComercialSoldInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colComercialSoldInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialSoldInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colComercialSoldInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialSoldInsured.Caption = "Insured"
        Me.colComercialSoldInsured.FieldName = "Insured.ComercialSold"
        Me.colComercialSoldInsured.Name = "colComercialSoldInsured"
        Me.colComercialSoldInsured.RowIndex = 1
        Me.colComercialSoldInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.ComercialSold", "{0:n0}")})
        Me.colComercialSoldInsured.Visible = True
        '
        'ColComercialSoldNocover
        '
        Me.ColComercialSoldNocover.AppearanceCell.Options.UseTextOptions = True
        Me.ColComercialSoldNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColComercialSoldNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.ColComercialSoldNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColComercialSoldNocover.Caption = "No Cover"
        Me.ColComercialSoldNocover.FieldName = "Nocover.ComercialSold"
        Me.ColComercialSoldNocover.Name = "ColComercialSoldNocover"
        Me.ColComercialSoldNocover.RowIndex = 1
        Me.ColComercialSoldNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.ComercialSold", "{0:n0}")})
        Me.ColComercialSoldNocover.Visible = True
        '
        'GridBand11
        '
        Me.GridBand11.Columns.Add(Me.colComercialAPI)
        Me.GridBand11.Columns.Add(Me.colCoemrcialInsuredAPI)
        Me.GridBand11.Columns.Add(Me.colcomercialNocoverAPI)
        Me.GridBand11.MinWidth = 20
        Me.GridBand11.Name = "GridBand11"
        Me.GridBand11.Width = 150
        '
        'colComercialAPI
        '
        Me.colComercialAPI.AppearanceCell.Options.UseTextOptions = True
        Me.colComercialAPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialAPI.AppearanceHeader.Options.UseTextOptions = True
        Me.colComercialAPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComercialAPI.Caption = "Comercial API"
        Me.colComercialAPI.DisplayFormat.FormatString = "n0"
        Me.colComercialAPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComercialAPI.FieldName = "Total.ComercialValue"
        Me.colComercialAPI.Name = "colComercialAPI"
        Me.colComercialAPI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.ComercialValue", "{0:n0}")})
        Me.colComercialAPI.Visible = True
        Me.colComercialAPI.Width = 150
        '
        'colCoemrcialInsuredAPI
        '
        Me.colCoemrcialInsuredAPI.AppearanceCell.Options.UseTextOptions = True
        Me.colCoemrcialInsuredAPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCoemrcialInsuredAPI.AppearanceHeader.Options.UseTextOptions = True
        Me.colCoemrcialInsuredAPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCoemrcialInsuredAPI.Caption = "Insured"
        Me.colCoemrcialInsuredAPI.DisplayFormat.FormatString = "n0"
        Me.colCoemrcialInsuredAPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCoemrcialInsuredAPI.FieldName = "Insured.ComercialValue"
        Me.colCoemrcialInsuredAPI.Name = "colCoemrcialInsuredAPI"
        Me.colCoemrcialInsuredAPI.RowIndex = 1
        Me.colCoemrcialInsuredAPI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.ComercialValue", "{0:n0}")})
        Me.colCoemrcialInsuredAPI.Visible = True
        '
        'colcomercialNocoverAPI
        '
        Me.colcomercialNocoverAPI.AppearanceCell.Options.UseTextOptions = True
        Me.colcomercialNocoverAPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcomercialNocoverAPI.AppearanceHeader.Options.UseTextOptions = True
        Me.colcomercialNocoverAPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcomercialNocoverAPI.Caption = "No Cover"
        Me.colcomercialNocoverAPI.DisplayFormat.FormatString = "n0"
        Me.colcomercialNocoverAPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcomercialNocoverAPI.FieldName = "Nocover.ComercialValue"
        Me.colcomercialNocoverAPI.Name = "colcomercialNocoverAPI"
        Me.colcomercialNocoverAPI.RowIndex = 1
        Me.colcomercialNocoverAPI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.ComercialValue", "{0:n0}")})
        Me.colcomercialNocoverAPI.Visible = True
        '
        'GridBand12
        '
        Me.GridBand12.Columns.Add(Me.colNotSold)
        Me.GridBand12.Columns.Add(Me.colNotSoldInsured)
        Me.GridBand12.Columns.Add(Me.colNotSoldNoCover)
        Me.GridBand12.MinWidth = 20
        Me.GridBand12.Name = "GridBand12"
        Me.GridBand12.Width = 150
        '
        'colNotSold
        '
        Me.colNotSold.AppearanceCell.Options.UseTextOptions = True
        Me.colNotSold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSold.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotSold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSold.Caption = "Not Sold"
        Me.colNotSold.FieldName = "Total.NotSold"
        Me.colNotSold.Name = "colNotSold"
        Me.colNotSold.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.NotSold", "{0:n0}")})
        Me.colNotSold.Visible = True
        Me.colNotSold.Width = 150
        '
        'colNotSoldInsured
        '
        Me.colNotSoldInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colNotSoldInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSoldInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotSoldInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSoldInsured.Caption = "Insured"
        Me.colNotSoldInsured.FieldName = "Insured.NotSold"
        Me.colNotSoldInsured.Name = "colNotSoldInsured"
        Me.colNotSoldInsured.RowIndex = 1
        Me.colNotSoldInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.NotSold", "{0:n0}")})
        Me.colNotSoldInsured.Visible = True
        '
        'colNotSoldNoCover
        '
        Me.colNotSoldNoCover.AppearanceCell.Options.UseTextOptions = True
        Me.colNotSoldNoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSoldNoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotSoldNoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNotSoldNoCover.Caption = "No Cover"
        Me.colNotSoldNoCover.FieldName = "Nocover.NotSold"
        Me.colNotSoldNoCover.Name = "colNotSoldNoCover"
        Me.colNotSoldNoCover.RowIndex = 1
        Me.colNotSoldNoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.NotSold", "{0:n0}")})
        Me.colNotSoldNoCover.Visible = True
        '
        'GridBand13
        '
        Me.GridBand13.Columns.Add(Me.ColToExpencive)
        Me.GridBand13.Columns.Add(Me.ColToExpenciveInsured)
        Me.GridBand13.Columns.Add(Me.ColToExpenciveNocover)
        Me.GridBand13.MinWidth = 20
        Me.GridBand13.Name = "GridBand13"
        Me.GridBand13.Width = 150
        '
        'ColToExpencive
        '
        Me.ColToExpencive.AppearanceCell.Options.UseTextOptions = True
        Me.ColToExpencive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpencive.AppearanceHeader.Options.UseTextOptions = True
        Me.ColToExpencive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpencive.Caption = "To Expencive"
        Me.ColToExpencive.FieldName = "Total.ToExpencive"
        Me.ColToExpencive.Name = "ColToExpencive"
        Me.ColToExpencive.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.ToExpencive", "{0:n0}")})
        Me.ColToExpencive.Visible = True
        Me.ColToExpencive.Width = 150
        '
        'ColToExpenciveInsured
        '
        Me.ColToExpenciveInsured.AppearanceCell.Options.UseTextOptions = True
        Me.ColToExpenciveInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpenciveInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.ColToExpenciveInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpenciveInsured.Caption = "Insured"
        Me.ColToExpenciveInsured.FieldName = "Insured.ToExpencive"
        Me.ColToExpenciveInsured.Name = "ColToExpenciveInsured"
        Me.ColToExpenciveInsured.RowIndex = 1
        Me.ColToExpenciveInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.ToExpencive", "{0:n0}")})
        Me.ColToExpenciveInsured.Visible = True
        '
        'ColToExpenciveNocover
        '
        Me.ColToExpenciveNocover.AppearanceCell.Options.UseTextOptions = True
        Me.ColToExpenciveNocover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpenciveNocover.AppearanceHeader.Options.UseTextOptions = True
        Me.ColToExpenciveNocover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToExpenciveNocover.Caption = "No Cover"
        Me.ColToExpenciveNocover.FieldName = "Nocover.ToExpencive"
        Me.ColToExpenciveNocover.Name = "ColToExpenciveNocover"
        Me.ColToExpenciveNocover.RowIndex = 1
        Me.ColToExpenciveNocover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.ToExpencive", "{0:n0}")})
        Me.ColToExpenciveNocover.Visible = True
        '
        'GridBand14
        '
        Me.GridBand14.Columns.Add(Me.colExistingMedical)
        Me.GridBand14.Columns.Add(Me.colExistingMedicalInsured)
        Me.GridBand14.Columns.Add(Me.colExistingMedicalNoCover)
        Me.GridBand14.MinWidth = 20
        Me.GridBand14.Name = "GridBand14"
        Me.GridBand14.Width = 150
        '
        'colExistingMedical
        '
        Me.colExistingMedical.AppearanceCell.Options.UseTextOptions = True
        Me.colExistingMedical.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedical.AppearanceHeader.Options.UseTextOptions = True
        Me.colExistingMedical.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedical.Caption = "Existing Medical"
        Me.colExistingMedical.FieldName = "Total.ExistingMedical"
        Me.colExistingMedical.Name = "colExistingMedical"
        Me.colExistingMedical.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.ExistingMedical", "{0:n0}")})
        Me.colExistingMedical.Visible = True
        Me.colExistingMedical.Width = 150
        '
        'colExistingMedicalInsured
        '
        Me.colExistingMedicalInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colExistingMedicalInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedicalInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colExistingMedicalInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedicalInsured.Caption = "Insured"
        Me.colExistingMedicalInsured.FieldName = "Insured.ExistingMedical"
        Me.colExistingMedicalInsured.Name = "colExistingMedicalInsured"
        Me.colExistingMedicalInsured.RowIndex = 1
        Me.colExistingMedicalInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.ExistingMedical", "{0:n0}")})
        Me.colExistingMedicalInsured.Visible = True
        '
        'colExistingMedicalNoCover
        '
        Me.colExistingMedicalNoCover.AppearanceCell.Options.UseTextOptions = True
        Me.colExistingMedicalNoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedicalNoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.colExistingMedicalNoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistingMedicalNoCover.Caption = "No Cover"
        Me.colExistingMedicalNoCover.FieldName = "Nocover.ExistingMedical"
        Me.colExistingMedicalNoCover.Name = "colExistingMedicalNoCover"
        Me.colExistingMedicalNoCover.RowIndex = 1
        Me.colExistingMedicalNoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.ExistingMedical", "{0:n0}")})
        Me.colExistingMedicalNoCover.Visible = True
        '
        'GridBand15
        '
        Me.GridBand15.Columns.Add(Me.colNoFeedback)
        Me.GridBand15.Columns.Add(Me.colNoFeedbackInsured)
        Me.GridBand15.Columns.Add(Me.colNoFeedbackNoCover)
        Me.GridBand15.MinWidth = 20
        Me.GridBand15.Name = "GridBand15"
        Me.GridBand15.Width = 150
        '
        'colNoFeedback
        '
        Me.colNoFeedback.AppearanceCell.Options.UseTextOptions = True
        Me.colNoFeedback.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedback.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoFeedback.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedback.Caption = "No Feedback"
        Me.colNoFeedback.FieldName = "Total.NoFeedback"
        Me.colNoFeedback.Name = "colNoFeedback"
        Me.colNoFeedback.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total.NoFeedback", "{0:n0}")})
        Me.colNoFeedback.Visible = True
        Me.colNoFeedback.Width = 150
        '
        'colNoFeedbackInsured
        '
        Me.colNoFeedbackInsured.AppearanceCell.Options.UseTextOptions = True
        Me.colNoFeedbackInsured.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedbackInsured.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoFeedbackInsured.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedbackInsured.Caption = "Insured"
        Me.colNoFeedbackInsured.FieldName = "Insured.NoFeedback"
        Me.colNoFeedbackInsured.Name = "colNoFeedbackInsured"
        Me.colNoFeedbackInsured.RowIndex = 1
        Me.colNoFeedbackInsured.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Insured.NoFeedback", "{0:n0}")})
        Me.colNoFeedbackInsured.Visible = True
        '
        'colNoFeedbackNoCover
        '
        Me.colNoFeedbackNoCover.AppearanceCell.Options.UseTextOptions = True
        Me.colNoFeedbackNoCover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedbackNoCover.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoFeedbackNoCover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoFeedbackNoCover.Caption = "No Cover"
        Me.colNoFeedbackNoCover.FieldName = "Nocover.NoFeedback"
        Me.colNoFeedbackNoCover.Name = "colNoFeedbackNoCover"
        Me.colNoFeedbackNoCover.RowIndex = 1
        Me.colNoFeedbackNoCover.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nocover.NoFeedback", "{0:n0}")})
        Me.colNoFeedbackNoCover.Visible = True
        '
        'sfd
        '
        Me.sfd.FileName = "Rep Performance New.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'frmPerformanceNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 663)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "frmPerformanceNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepPerformanceNew"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.AppointmentStatsNewHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AppointmentStatsNewHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colRealName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridDeadTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColDeadInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeadNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalApps As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColAppointmentsInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColAppointmentsNoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAppointmentNotSure As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAppsSat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAppsSatInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAppsSatNoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColSold As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsoldinsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColSoldNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColAPI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColApiinsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApiNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrivateSold As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPrivateInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrivateNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrivateAPI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrivatAPIInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrivateAPINoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComercialsold As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComercialSoldInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColComercialSoldNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComercialAPI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCoemrcialInsuredAPI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcomercialNocoverAPI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPending As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPendingInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpendingNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotSold As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotSoldInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotSoldNoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColToExpencive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColToExpenciveInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColToExpenciveNocover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistingMedical As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistingMedicalInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistingMedicalNoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNoFeedback As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNoFeedbackInsured As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNoFeedbackNoCover As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand13 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand14 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand15 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cbReportType As System.Windows.Forms.ComboBox
End Class
