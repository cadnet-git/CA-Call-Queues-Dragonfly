<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFixPostcodes
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
        Me.BtnFix = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblFeedback = New System.Windows.Forms.Label
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.PostcodeFixBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanies = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Panel1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostcodeFixBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFix
        '
        Me.BtnFix.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFix.Location = New System.Drawing.Point(392, 8)
        Me.BtnFix.Name = "BtnFix"
        Me.BtnFix.Size = New System.Drawing.Size(112, 22)
        Me.BtnFix.TabIndex = 5
        Me.BtnFix.Text = "Fix Postcodes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFeedback)
        Me.Panel1.Controls.Add(Me.BtnFix)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 38)
        Me.Panel1.TabIndex = 2
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Location = New System.Drawing.Point(25, 12)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(39, 13)
        Me.lblFeedback.TabIndex = 6
        Me.lblFeedback.Text = "Label1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Grid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 38)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(516, 342)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Grid
        '
        Me.Grid.DataSource = Me.PostcodeFixBindingSource
        Me.Grid.Location = New System.Drawing.Point(12, 12)
        Me.Grid.MainView = Me.View
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(492, 318)
        Me.Grid.TabIndex = 4
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.View})
        '
        'PostcodeFixBindingSource
        '
        Me.PostcodeFixBindingSource.DataSource = GetType(CADNet.CallQueues.ManagerConsole.PostcodeFix)
        '
        'View
        '
        Me.View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLocation, Me.colResult, Me.colCompanies})
        Me.View.GridControl = Me.Grid
        Me.View.Name = "View"
        Me.View.OptionsView.ShowGroupPanel = False
        '
        'colLocation
        '
        Me.colLocation.Caption = "Location"
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 0
        '
        'colResult
        '
        Me.colResult.Caption = "Result"
        Me.colResult.FieldName = "Result"
        Me.colResult.Name = "colResult"
        Me.colResult.Visible = True
        Me.colResult.VisibleIndex = 1
        '
        'colCompanies
        '
        Me.colCompanies.Caption = "Companies"
        Me.colCompanies.FieldName = "Companies"
        Me.colCompanies.Name = "colCompanies"
        Me.colCompanies.Visible = True
        Me.colCompanies.VisibleIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(516, 342)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Grid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(496, 322)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmFixPostcodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 380)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFixPostcodes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fix Postcodes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostcodeFixBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFix As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFeedback As Label
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PostcodeFixBindingSource As BindingSource
    Friend WithEvents View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanies As DevExpress.XtraGrid.Columns.GridColumn
End Class
