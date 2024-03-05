<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        Me.ColCounty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactSurname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPostcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelephone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColCounty
        '
        Me.ColCounty.Caption = "County"
        Me.ColCounty.FieldName = "County"
        Me.ColCounty.Name = "ColCounty"
        Me.ColCounty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColCounty.Visible = True
        Me.ColCounty.VisibleIndex = 9
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(979, 633)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRealName, Me.colCompanyName, Me.colContactTitle, Me.colContactSurname, Me.colContactPosition, Me.ColAddress1, Me.ColAddress2, Me.ColAddress3, Me.ColTown, Me.ColCounty, Me.ColPostcode, Me.ColTelephone})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRealName
        '
        Me.colRealName.FieldName = "Rep"
        Me.colRealName.Name = "colRealName"
        Me.colRealName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRealName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 0
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        '
        'colContactTitle
        '
        Me.colContactTitle.FieldName = "ContactTitle"
        Me.colContactTitle.Name = "colContactTitle"
        Me.colContactTitle.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colContactTitle.Visible = True
        Me.colContactTitle.VisibleIndex = 3
        '
        'colContactSurname
        '
        Me.colContactSurname.FieldName = "ContactSurname"
        Me.colContactSurname.Name = "colContactSurname"
        Me.colContactSurname.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colContactSurname.Visible = True
        Me.colContactSurname.VisibleIndex = 2
        '
        'colContactPosition
        '
        Me.colContactPosition.FieldName = "ContactPosition"
        Me.colContactPosition.Name = "colContactPosition"
        Me.colContactPosition.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colContactPosition.Visible = True
        Me.colContactPosition.VisibleIndex = 4
        '
        'ColAddress1
        '
        Me.ColAddress1.Caption = "Address 1"
        Me.ColAddress1.FieldName = "Address1"
        Me.ColAddress1.Name = "ColAddress1"
        Me.ColAddress1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColAddress1.Visible = True
        Me.ColAddress1.VisibleIndex = 5
        '
        'ColAddress2
        '
        Me.ColAddress2.Caption = "Address 2"
        Me.ColAddress2.FieldName = "Address2"
        Me.ColAddress2.Name = "ColAddress2"
        Me.ColAddress2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColAddress2.Visible = True
        Me.ColAddress2.VisibleIndex = 6
        '
        'ColAddress3
        '
        Me.ColAddress3.Caption = "Address 3"
        Me.ColAddress3.FieldName = "Address3"
        Me.ColAddress3.Name = "ColAddress3"
        Me.ColAddress3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColAddress3.Visible = True
        Me.ColAddress3.VisibleIndex = 7
        '
        'ColTown
        '
        Me.ColTown.Caption = "Town"
        Me.ColTown.FieldName = "Town"
        Me.ColTown.Name = "ColTown"
        Me.ColTown.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColTown.Visible = True
        Me.ColTown.VisibleIndex = 8
        '
        'ColPostcode
        '
        Me.ColPostcode.Caption = "Postcode"
        Me.ColPostcode.FieldName = "PostcodeRaw"
        Me.ColPostcode.Name = "ColPostcode"
        Me.ColPostcode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColPostcode.Visible = True
        Me.ColPostcode.VisibleIndex = 10
        '
        'ColTelephone
        '
        Me.ColTelephone.Caption = "Telephone"
        Me.ColTelephone.FieldName = "Telephone"
        Me.ColTelephone.Name = "ColTelephone"
        Me.ColTelephone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColTelephone.Visible = True
        Me.ColTelephone.VisibleIndex = 11
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
        Me.ExportToXlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(979, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 657)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSold"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColCounty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPostcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTelephone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
