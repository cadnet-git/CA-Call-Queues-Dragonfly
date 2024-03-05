<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStandardLife
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
        Me.LVApps = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Comp = New System.Windows.Forms.ColumnHeader
        Me.Telephone = New System.Windows.Forms.ColumnHeader
        Me.aDate = New System.Windows.Forms.ColumnHeader
        Me.EndDP = New System.Windows.Forms.DateTimePicker
        Me.StartDP = New System.Windows.Forms.DateTimePicker
        Me.BtnFind = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.label1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblRecs = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVApps
        '
        Me.LVApps.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.LVApps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVApps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Comp, Me.Telephone, Me.aDate})
        Me.LVApps.FullRowSelect = True
        Me.LVApps.GridLines = True
        Me.LVApps.Location = New System.Drawing.Point(3, 76)
        Me.LVApps.Name = "LVApps"
        Me.LVApps.Size = New System.Drawing.Size(478, 521)
        Me.LVApps.TabIndex = 4
        Me.LVApps.UseCompatibleStateImageBehavior = False
        Me.LVApps.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'Comp
        '
        Me.Comp.Text = "Company"
        Me.Comp.Width = 208
        '
        'Telephone
        '
        Me.Telephone.Text = "Telephone"
        Me.Telephone.Width = 110
        '
        'aDate
        '
        Me.aDate.Text = "Date"
        Me.aDate.Width = 153
        '
        'EndDP
        '
        Me.EndDP.CustomFormat = ""
        Me.EndDP.Location = New System.Drawing.Point(184, 40)
        Me.EndDP.Name = "EndDP"
        Me.EndDP.Size = New System.Drawing.Size(153, 20)
        Me.EndDP.TabIndex = 2
        '
        'StartDP
        '
        Me.StartDP.Location = New System.Drawing.Point(12, 40)
        Me.StartDP.Name = "StartDP"
        Me.StartDP.Size = New System.Drawing.Size(153, 20)
        Me.StartDP.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(342, 39)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(74, 22)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.label1, Me.lblRecs})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(485, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'label1
        '
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 17)
        Me.label1.Text = "Appointments :"
        '
        'lblRecs
        '
        Me.lblRecs.Name = "lblRecs"
        Me.lblRecs.Size = New System.Drawing.Size(13, 17)
        Me.lblRecs.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmReportStandardLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 622)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.EndDP)
        Me.Controls.Add(Me.StartDP)
        Me.Controls.Add(Me.LVApps)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReportStandardLife"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Standard Life"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVApps As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Comp As System.Windows.Forms.ColumnHeader
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents aDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents EndDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents label1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRecs As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
