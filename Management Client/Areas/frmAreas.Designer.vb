<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvwAreas = New System.Windows.Forms.ListView()
        Me.colAreaName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnuAreas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEditArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAssignRep = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCreateArea = New System.Windows.Forms.Button
        Me.lstPostcodes = New System.Windows.Forms.ListBox()
        Me.cmnuPostcodes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPostcodeEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPostcodeRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdeToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnNewPostcode = New System.Windows.Forms.Button
        Me.lblAreaName = New System.Windows.Forms.Label
        Me.ColNoColdCalls = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoColdCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cmnuAreas.SuspendLayout()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuPostcodes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwAreas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlAreaHeader)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstPostcodes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(405, 566)
        Me.SplitContainer1.SplitterDistance = 295
        Me.SplitContainer1.TabIndex = 0
        '
        'lvwAreas
        '
        Me.lvwAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colAreaName, Me.colRep, Me.ColNoColdCalls})
        Me.lvwAreas.ContextMenuStrip = Me.cmnuAreas
        Me.lvwAreas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAreas.FullRowSelect = True
        Me.lvwAreas.Location = New System.Drawing.Point(0, 53)
        Me.lvwAreas.MultiSelect = False
        Me.lvwAreas.Name = "lvwAreas"
        Me.lvwAreas.Size = New System.Drawing.Size(405, 242)
        Me.lvwAreas.TabIndex = 2
        Me.lvwAreas.UseCompatibleStateImageBehavior = False
        Me.lvwAreas.View = System.Windows.Forms.View.Details
        '
        'colAreaName
        '
        Me.colAreaName.Text = "Area"
        Me.colAreaName.Width = 171
        '
        'colRep
        '
        Me.colRep.Text = "Rep"
        Me.colRep.Width = 157
        '
        'cmnuAreas
        '
        Me.cmnuAreas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditArea, Me.mnuAssignRep, Me.NoColdCallsToolStripMenuItem, Me.ToolStripMenuItem2, Me.RemoveAreaToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancelToolStripMenuItem})
        Me.cmnuAreas.Name = "cmnuAreas"
        Me.cmnuAreas.Size = New System.Drawing.Size(153, 148)
        '
        'mnuEditArea
        '
        Me.mnuEditArea.Name = "mnuEditArea"
        Me.mnuEditArea.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditArea.Text = "Edit"
        '
        'mnuAssignRep
        '
        Me.mnuAssignRep.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.mnuAssignRep.Name = "mnuAssignRep"
        Me.mnuAssignRep.Size = New System.Drawing.Size(152, 22)
        Me.mnuAssignRep.Text = "Assign Rep"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(100, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'RemoveAreaToolStripMenuItem
        '
        Me.RemoveAreaToolStripMenuItem.Name = "RemoveAreaToolStripMenuItem"
        Me.RemoveAreaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveAreaToolStripMenuItem.Text = "Remove Area"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Controls.Add(Me.btnCreateArea)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(405, 53)
        Me.pnlAreaHeader.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Areas && Postcodes"
        '
        'btnCreateArea
        '
        Me.btnCreateArea.Location = New System.Drawing.Point(312, 6)
        Me.btnCreateArea.Name = "btnCreateArea"
        Me.btnCreateArea.Size = New System.Drawing.Size(90, 23)
        Me.btnCreateArea.TabIndex = 3
        Me.btnCreateArea.Text = "New Area"
        Me.btnCreateArea.UseVisualStyleBackColor = True
        '
        'lstPostcodes
        '
        Me.lstPostcodes.ContextMenuStrip = Me.cmnuPostcodes
        Me.lstPostcodes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPostcodes.FormattingEnabled = True
        Me.lstPostcodes.Location = New System.Drawing.Point(0, 35)
        Me.lstPostcodes.Name = "lstPostcodes"
        Me.lstPostcodes.Size = New System.Drawing.Size(405, 232)
        Me.lstPostcodes.TabIndex = 2
        '
        'cmnuPostcodes
        '
        Me.cmnuPostcodes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPostcodeEdit, Me.mnuPostcodeRemove, Me.OdeToolStripMenuItem, Me.CancelToolStripMenuItem1})
        Me.cmnuPostcodes.Name = "cmnuPostcodes"
        Me.cmnuPostcodes.Size = New System.Drawing.Size(170, 76)
        '
        'mnuPostcodeEdit
        '
        Me.mnuPostcodeEdit.Name = "mnuPostcodeEdit"
        Me.mnuPostcodeEdit.Size = New System.Drawing.Size(169, 22)
        Me.mnuPostcodeEdit.Text = "Edit"
        '
        'mnuPostcodeRemove
        '
        Me.mnuPostcodeRemove.Name = "mnuPostcodeRemove"
        Me.mnuPostcodeRemove.Size = New System.Drawing.Size(169, 22)
        Me.mnuPostcodeRemove.Text = "Remove Postcode"
        '
        'OdeToolStripMenuItem
        '
        Me.OdeToolStripMenuItem.Name = "OdeToolStripMenuItem"
        Me.OdeToolStripMenuItem.Size = New System.Drawing.Size(166, 6)
        '
        'CancelToolStripMenuItem1
        '
        Me.CancelToolStripMenuItem1.Name = "CancelToolStripMenuItem1"
        Me.CancelToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.CancelToolStripMenuItem1.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnNewPostcode)
        Me.Panel1.Controls.Add(Me.lblAreaName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 35)
        Me.Panel1.TabIndex = 1
        '
        'btnNewPostcode
        '
        Me.btnNewPostcode.Enabled = False
        Me.btnNewPostcode.Location = New System.Drawing.Point(312, 5)
        Me.btnNewPostcode.Name = "btnNewPostcode"
        Me.btnNewPostcode.Size = New System.Drawing.Size(90, 23)
        Me.btnNewPostcode.TabIndex = 4
        Me.btnNewPostcode.Text = "New Postcode"
        Me.btnNewPostcode.UseVisualStyleBackColor = True
        '
        'lblAreaName
        '
        Me.lblAreaName.AutoSize = True
        Me.lblAreaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAreaName.Location = New System.Drawing.Point(3, 10)
        Me.lblAreaName.Name = "lblAreaName"
        Me.lblAreaName.Size = New System.Drawing.Size(143, 13)
        Me.lblAreaName.TabIndex = 0
        Me.lblAreaName.Text = "Please select an Area above"
        '
        'ColNoColdCalls
        '
        Me.ColNoColdCalls.Text = "No Cold"
        Me.ColNoColdCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColNoColdCalls.Width = 54
        '
        'NoColdCallsToolStripMenuItem
        '
        Me.NoColdCallsToolStripMenuItem.Name = "NoColdCallsToolStripMenuItem"
        Me.NoColdCallsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NoColdCallsToolStripMenuItem.Text = "No Cold Calls"
        '
        'frmAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Areas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cmnuAreas.ResumeLayout(False)
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuPostcodes.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAreaName As System.Windows.Forms.Label
    Friend WithEvents btnCreateArea As System.Windows.Forms.Button
    Friend WithEvents lstPostcodes As System.Windows.Forms.ListBox
    Friend WithEvents btnNewPostcode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmnuAreas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEditArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuPostcodes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPostcodeEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPostcodeRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OdeToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwAreas As System.Windows.Forms.ListView
    Friend WithEvents colAreaName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRep As System.Windows.Forms.ColumnHeader
    Friend WithEvents mnuAssignRep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColNoColdCalls As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoColdCallsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
