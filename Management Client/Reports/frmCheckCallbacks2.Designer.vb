<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckCallbacks2
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
        Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPolicyProvider = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPolicyExpires = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactSurname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoldUntil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYearMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastCalled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colContactTitle
        '
        Me.colContactTitle.FieldName = "ContactTitle"
        Me.colContactTitle.Name = "colContactTitle"
        Me.colContactTitle.Visible = True
        Me.colContactTitle.VisibleIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(982, 570)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRealName, Me.colCompanyStatus, Me.colCompanyName, Me.colPolicyProvider, Me.colPolicyExpires, Me.colContactSurname, Me.colContactTitle, Me.colContactPosition, Me.colHoldUntil, Me.colYearMonth, Me.colLastCalled})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLastCalled, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 0
        '
        'colCompanyStatus
        '
        Me.colCompanyStatus.FieldName = "CompanyStatus"
        Me.colCompanyStatus.Name = "colCompanyStatus"
        Me.colCompanyStatus.Visible = True
        Me.colCompanyStatus.VisibleIndex = 1
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 2
        '
        'colPolicyProvider
        '
        Me.colPolicyProvider.FieldName = "PolicyProvider"
        Me.colPolicyProvider.Name = "colPolicyProvider"
        Me.colPolicyProvider.Visible = True
        Me.colPolicyProvider.VisibleIndex = 3
        '
        'colPolicyExpires
        '
        Me.colPolicyExpires.FieldName = "PolicyExpires"
        Me.colPolicyExpires.Name = "colPolicyExpires"
        Me.colPolicyExpires.Visible = True
        Me.colPolicyExpires.VisibleIndex = 4
        '
        'colContactSurname
        '
        Me.colContactSurname.FieldName = "ContactSurname"
        Me.colContactSurname.Name = "colContactSurname"
        Me.colContactSurname.Visible = True
        Me.colContactSurname.VisibleIndex = 5
        '
        'colContactPosition
        '
        Me.colContactPosition.FieldName = "ContactPosition"
        Me.colContactPosition.Name = "colContactPosition"
        Me.colContactPosition.Visible = True
        Me.colContactPosition.VisibleIndex = 7
        '
        'colHoldUntil
        '
        Me.colHoldUntil.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colHoldUntil.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colHoldUntil.FieldName = "HoldUntil"
        Me.colHoldUntil.Name = "colHoldUntil"
        Me.colHoldUntil.Visible = True
        Me.colHoldUntil.VisibleIndex = 8
        '
        'colYearMonth
        '
        Me.colYearMonth.Caption = "Hold Month"
        Me.colYearMonth.DisplayFormat.FormatString = "MMM yyyy"
        Me.colYearMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colYearMonth.FieldName = "HoldUntil"
        Me.colYearMonth.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colYearMonth.GroupFormat.FormatString = "MMM yyyy"
        Me.colYearMonth.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colYearMonth.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.colYearMonth.Name = "colYearMonth"
        Me.colYearMonth.OptionsColumn.ReadOnly = True
        Me.colYearMonth.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colYearMonth.Visible = True
        Me.colYearMonth.VisibleIndex = 9
        '
        'colLastCalled
        '
        Me.colLastCalled.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colLastCalled.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastCalled.FieldName = "LastCalled"
        Me.colLastCalled.Name = "colLastCalled"
        Me.colLastCalled.OptionsColumn.ReadOnly = True
        Me.colLastCalled.Visible = True
        Me.colLastCalled.VisibleIndex = 10
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
        'sfd
        '
        Me.sfd.FileName = "CallbacksAndReshedules.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmCheckCallbacks2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 594)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmCheckCallbacks2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolicyProvider As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolicyExpires As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoldUntil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYearMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastCalled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
