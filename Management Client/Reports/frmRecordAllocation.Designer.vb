<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordAllocation
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
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Me.fieldRecord = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldRealName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fieldRecord
        '
        Me.fieldRecord.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldRecord.AreaIndex = 0
        Me.fieldRecord.Caption = "Record"
        Me.fieldRecord.FieldName = "Record"
        Me.fieldRecord.Name = "fieldRecord"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRealName, Me.fieldMonth, Me.fieldYear, Me.fieldRecord})
        PivotGridGroup1.Fields.Add(Me.fieldRecord)
        PivotGridGroup1.Hierarchy = Nothing
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 24)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Lilian"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(856, 608)
        Me.PivotGridControl1.TabIndex = 1
        '
        'fieldRealName
        '
        Me.fieldRealName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRealName.AreaIndex = 0
        Me.fieldRealName.Caption = "Real Name"
        Me.fieldRealName.FieldName = "RealName"
        Me.fieldRealName.Name = "fieldRealName"
        '
        'fieldMonth
        '
        Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMonth.AreaIndex = 1
        Me.fieldMonth.Caption = "Month"
        Me.fieldMonth.FieldName = "Month"
        Me.fieldMonth.Name = "fieldMonth"
        Me.fieldMonth.Width = 77
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
        '
        'sfd
        '
        Me.sfd.FileName = "Future_Callbacks.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'frmRecordAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 632)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmRecordAllocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company Allocation Report"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldRealName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecord As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
