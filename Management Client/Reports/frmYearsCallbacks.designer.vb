<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearsCallbacks
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
        Dim PivotGridGroup3 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup
        Me.fieldcallbacks = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRealName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fieldcallbacks
        '
        Me.fieldcallbacks.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldcallbacks.AreaIndex = 0
        Me.fieldcallbacks.Caption = "callbacks"
        Me.fieldcallbacks.FieldName = "callbacks"
        Me.fieldcallbacks.Name = "fieldcallbacks"
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
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
        'fieldRealName
        '
        Me.fieldRealName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRealName.AreaIndex = 0
        Me.fieldRealName.Caption = "Real Name"
        Me.fieldRealName.FieldName = "RealName"
        Me.fieldRealName.Name = "fieldRealName"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRealName, Me.fieldMonth, Me.fieldYear, Me.fieldcallbacks})
        PivotGridGroup3.Fields.Add(Me.fieldcallbacks)
        PivotGridGroup3.Hierarchy = Nothing
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup3})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 24)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Lilian"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(1020, 692)
        Me.PivotGridControl1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ExportToXlsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToXlsToolStripMenuItem.Text = "Export to Xls"
        '
        'sfd
        '
        Me.sfd.FileName = "Future_Callbacks.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'frmYearsCallbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 716)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmYearsCallbacks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fieldcallbacks As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRealName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
