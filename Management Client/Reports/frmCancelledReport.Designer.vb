<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelledReport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDateCreated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1010, 24)
        Me.MenuStrip1.TabIndex = 10
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
        'sfd
        '
        Me.sfd.FileName = "CancelledAppointments.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'colCompanyName
        '
        Me.colCompanyName.Caption = "Company"
        Me.colCompanyName.FieldName = "Company"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        Me.colCompanyName.Width = 518
        '
        'colRealName
        '
        Me.colRealName.Caption = "Changed By"
        Me.colRealName.FieldName = "ChangedBy"
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 0
        Me.colRealName.Width = 157
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRealName, Me.colCompanyName, Me.colDateCreated, Me.colTime, Me.colType, Me.colStartStatus, Me.colEndStatus, Me.colCurrentStatus})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colDateCreated
        '
        Me.colDateCreated.Caption = "Date"
        Me.colDateCreated.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateCreated.FieldName = "DateCreated"
        Me.colDateCreated.Name = "colDateCreated"
        Me.colDateCreated.Visible = True
        Me.colDateCreated.VisibleIndex = 2
        Me.colDateCreated.Width = 158
        '
        'colTime
        '
        Me.colTime.Caption = "Time"
        Me.colTime.DisplayFormat.FormatString = "hh:mm tt"
        Me.colTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTime.FieldName = "Time"
        Me.colTime.Name = "colTime"
        Me.colTime.Visible = True
        Me.colTime.VisibleIndex = 3
        Me.colTime.Width = 158
        '
        'colType
        '
        Me.colType.Caption = "Direction"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 4
        Me.colType.Width = 158
        '
        'colStartStatus
        '
        Me.colStartStatus.Caption = "Start Status"
        Me.colStartStatus.FieldName = "StartStatus"
        Me.colStartStatus.Name = "colStartStatus"
        Me.colStartStatus.Visible = True
        Me.colStartStatus.VisibleIndex = 5
        Me.colStartStatus.Width = 158
        '
        'colEndStatus
        '
        Me.colEndStatus.Caption = "End Status"
        Me.colEndStatus.FieldName = "EndStatus"
        Me.colEndStatus.Name = "colEndStatus"
        Me.colEndStatus.Visible = True
        Me.colEndStatus.VisibleIndex = 6
        Me.colEndStatus.Width = 158
        '
        'colCurrentStatus
        '
        Me.colCurrentStatus.Caption = "Current Status"
        Me.colCurrentStatus.FieldName = "CurrentStatus"
        Me.colCurrentStatus.Name = "colCurrentStatus"
        Me.colCurrentStatus.Visible = True
        Me.colCurrentStatus.VisibleIndex = 7
        Me.colCurrentStatus.Width = 167
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1010, 594)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'frmCancelledReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 618)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmCancelledReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancelled Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDateCreated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
End Class
