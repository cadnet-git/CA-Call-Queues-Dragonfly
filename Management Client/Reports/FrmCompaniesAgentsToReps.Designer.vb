<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompaniesAgentsToReps
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
        Me.components = New System.ComponentModel.Container
        Me.LVGrid = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Agent = New System.Windows.Forms.ColumnHeader
        Me.AllRecs = New System.Windows.Forms.ColumnHeader
        Me.OverdueRecs = New System.Windows.Forms.ColumnHeader
        Me.Tree = New System.Windows.Forms.TreeView
        Me.lblSelectedRep = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CM1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReallocateOverdueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReallocateAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CM1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVGrid
        '
        Me.LVGrid.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Agent, Me.AllRecs, Me.OverdueRecs})
        Me.LVGrid.ContextMenuStrip = Me.CM1
        Me.LVGrid.FullRowSelect = True
        Me.LVGrid.GridLines = True
        Me.LVGrid.Location = New System.Drawing.Point(245, 38)
        Me.LVGrid.MultiSelect = False
        Me.LVGrid.Name = "LVGrid"
        Me.LVGrid.Size = New System.Drawing.Size(365, 620)
        Me.LVGrid.TabIndex = 3
        Me.LVGrid.UseCompatibleStateImageBehavior = False
        Me.LVGrid.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "AgentID"
        Me.ID.Width = 0
        '
        'Agent
        '
        Me.Agent.Text = "Agent"
        Me.Agent.Width = 127
        '
        'AllRecs
        '
        Me.AllRecs.Text = "All Records"
        Me.AllRecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AllRecs.Width = 88
        '
        'OverdueRecs
        '
        Me.OverdueRecs.Text = "Overdue Records"
        Me.OverdueRecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OverdueRecs.Width = 110
        '
        'Tree
        '
        Me.Tree.Location = New System.Drawing.Point(12, 12)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(227, 646)
        Me.Tree.TabIndex = 1
        '
        'lblSelectedRep
        '
        Me.lblSelectedRep.AutoSize = True
        Me.lblSelectedRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedRep.Location = New System.Drawing.Point(245, 12)
        Me.lblSelectedRep.Name = "lblSelectedRep"
        Me.lblSelectedRep.Size = New System.Drawing.Size(38, 20)
        Me.lblSelectedRep.TabIndex = 2
        Me.lblSelectedRep.Text = "Ben"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 664)
        Me.Panel1.TabIndex = 0
        '
        'CM1
        '
        Me.CM1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReallocateOverdueToolStripMenuItem, Me.ReallocateAllToolStripMenuItem})
        Me.CM1.Name = "CM1"
        Me.CM1.Size = New System.Drawing.Size(177, 70)
        '
        'ReallocateOverdueToolStripMenuItem
        '
        Me.ReallocateOverdueToolStripMenuItem.Name = "ReallocateOverdueToolStripMenuItem"
        Me.ReallocateOverdueToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ReallocateOverdueToolStripMenuItem.Text = "Reallocate Overdue"
        '
        'ReallocateAllToolStripMenuItem
        '
        Me.ReallocateAllToolStripMenuItem.Name = "ReallocateAllToolStripMenuItem"
        Me.ReallocateAllToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ReallocateAllToolStripMenuItem.Text = "Reallocate All"
        '
        'FrmCompaniesAgentsToReps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 678)
        Me.Controls.Add(Me.lblSelectedRep)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.LVGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCompaniesAgentsToReps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Records Agents To Reps"
        Me.CM1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVGrid As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agent As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents AllRecs As System.Windows.Forms.ColumnHeader
    Friend WithEvents OverdueRecs As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSelectedRep As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CM1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReallocateOverdueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReallocateAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
