<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSurveySummary
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalledBefore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProfessional = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPunctual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteInfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuotedInMeeting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCSComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(996, 664)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRealName, Me.colCompanyName, Me.colCalledBefore, Me.colProfessional, Me.colPunctual, Me.colQuoteInfo, Me.colQuoteMethod, Me.colQuotedInMeeting, Me.colCSComments, Me.colSent, Me.colCompleted})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colRealName
        '
        Me.colRealName.Caption = "Rep Name"
        Me.colRealName.FieldName = "Rep"
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 0
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        '
        'colCalledBefore
        '
        Me.colCalledBefore.Caption = "Called Before"
        Me.colCalledBefore.FieldName = "CSCalledBefore"
        Me.colCalledBefore.Name = "colCalledBefore"
        Me.colCalledBefore.Visible = True
        Me.colCalledBefore.VisibleIndex = 3
        '
        'colProfessional
        '
        Me.colProfessional.Caption = "Professional"
        Me.colProfessional.FieldName = "CSProfessional"
        Me.colProfessional.Name = "colProfessional"
        Me.colProfessional.Visible = True
        Me.colProfessional.VisibleIndex = 4
        '
        'colPunctual
        '
        Me.colPunctual.Caption = "Punctual"
        Me.colPunctual.FieldName = "CSPunctual"
        Me.colPunctual.Name = "colPunctual"
        Me.colPunctual.Visible = True
        Me.colPunctual.VisibleIndex = 5
        '
        'colQuoteInfo
        '
        Me.colQuoteInfo.Caption = "Quote Info"
        Me.colQuoteInfo.FieldName = "CSQuoteInfo"
        Me.colQuoteInfo.Name = "colQuoteInfo"
        Me.colQuoteInfo.Visible = True
        Me.colQuoteInfo.VisibleIndex = 7
        '
        'colQuoteMethod
        '
        Me.colQuoteMethod.Caption = "Quote Method"
        Me.colQuoteMethod.FieldName = "CSQuoteMethod"
        Me.colQuoteMethod.Name = "colQuoteMethod"
        Me.colQuoteMethod.Visible = True
        Me.colQuoteMethod.VisibleIndex = 8
        '
        'colQuotedInMeeting
        '
        Me.colQuotedInMeeting.Caption = "Quoted In Meeting"
        Me.colQuotedInMeeting.FieldName = "CSQuotedInMeeting"
        Me.colQuotedInMeeting.Name = "colQuotedInMeeting"
        Me.colQuotedInMeeting.Visible = True
        Me.colQuotedInMeeting.VisibleIndex = 6
        '
        'colCSComments
        '
        Me.colCSComments.Caption = "Comments"
        Me.colCSComments.FieldName = "CSComments"
        Me.colCSComments.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCSComments.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.colCSComments.Name = "colCSComments"
        Me.colCSComments.OptionsColumn.ReadOnly = True
        Me.colCSComments.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colCSComments.Visible = True
        Me.colCSComments.VisibleIndex = 9
        '
        'colSent
        '
        Me.colSent.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colSent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSent.FieldName = "CSSent"
        Me.colSent.GroupFormat.FormatString = "yyyy MMM"
        Me.colSent.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSent.Name = "colSent"
        Me.colSent.OptionsColumn.ReadOnly = True
        Me.colSent.Visible = True
        Me.colSent.VisibleIndex = 2
        '
        'colCompleted
        '
        Me.colCompleted.Caption = "Completed"
        Me.colCompleted.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colCompleted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCompleted.FieldName = "CSCompletedDate"
        Me.colCompleted.GroupFormat.FormatString = "yyyy MMM"
        Me.colCompleted.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCompleted.Name = "colCompleted"
        Me.colCompleted.Visible = True
        Me.colCompleted.VisibleIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
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
        Me.sfd.FileName = "Surveys.xls"
        Me.sfd.Filter = "xls|*.xls"
        '
        'frmSurveySummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 688)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSurveySummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Survey Summary"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalledBefore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProfessional As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPunctual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteInfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuotedInMeeting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
