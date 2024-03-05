<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallTimeExceeded
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.LVStats = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.AgentN = New System.Windows.Forms.ColumnHeader
        Me.Calls = New System.Windows.Forms.ColumnHeader
        Me.Lists = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutOfAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotInterestedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotANumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.EndDP = New System.Windows.Forms.DateTimePicker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.progress = New System.Windows.Forms.ToolStripProgressBar
        Me.Lists.SuspendLayout()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVStats
        '
        Me.LVStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.AgentN, Me.Calls})
        Me.LVStats.ContextMenuStrip = Me.Lists
        Me.LVStats.FullRowSelect = True
        Me.LVStats.GridLines = True
        Me.LVStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVStats.Location = New System.Drawing.Point(3, 87)
        Me.LVStats.Name = "LVStats"
        Me.LVStats.Size = New System.Drawing.Size(346, 556)
        Me.LVStats.TabIndex = 0
        Me.LVStats.UseCompatibleStateImageBehavior = False
        Me.LVStats.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'AgentN
        '
        Me.AgentN.Text = "Agent"
        Me.AgentN.Width = 255
        '
        'Calls
        '
        Me.Calls.Text = "#"
        Me.Calls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Calls.Width = 85
        '
        'Lists
        '
        Me.Lists.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentsToolStripMenuItem})
        Me.Lists.Name = "Lists"
        Me.Lists.Size = New System.Drawing.Size(104, 26)
        '
        'AppointmentsToolStripMenuItem
        '
        Me.AppointmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TPSToolStripMenuItem, Me.OutOfAreaToolStripMenuItem, Me.SupervisorToolStripMenuItem, Me.NotInterestedToolStripMenuItem, Me.NotANumberToolStripMenuItem})
        Me.AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem"
        Me.AppointmentsToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AppointmentsToolStripMenuItem.Text = "Show"
        '
        'TPSToolStripMenuItem
        '
        Me.TPSToolStripMenuItem.Name = "TPSToolStripMenuItem"
        Me.TPSToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TPSToolStripMenuItem.Text = "TPS"
        '
        'OutOfAreaToolStripMenuItem
        '
        Me.OutOfAreaToolStripMenuItem.Name = "OutOfAreaToolStripMenuItem"
        Me.OutOfAreaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OutOfAreaToolStripMenuItem.Text = "Out Of Area"
        '
        'SupervisorToolStripMenuItem
        '
        Me.SupervisorToolStripMenuItem.Name = "SupervisorToolStripMenuItem"
        Me.SupervisorToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SupervisorToolStripMenuItem.Text = "Supervisor"
        '
        'NotInterestedToolStripMenuItem
        '
        Me.NotInterestedToolStripMenuItem.Name = "NotInterestedToolStripMenuItem"
        Me.NotInterestedToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NotInterestedToolStripMenuItem.Text = "Not Interested"
        '
        'NotANumberToolStripMenuItem
        '
        Me.NotANumberToolStripMenuItem.Name = "NotANumberToolStripMenuItem"
        Me.NotANumberToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NotANumberToolStripMenuItem.Text = "Not a Number"
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Controls.Add(Me.BtnRefresh)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(356, 53)
        Me.pnlAreaHeader.TabIndex = 1
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
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Time Eceeded Calls"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(259, 17)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 23)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(12, 61)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(153, 20)
        Me.DTP1.TabIndex = 2
        '
        'EndDP
        '
        Me.EndDP.Location = New System.Drawing.Point(196, 61)
        Me.EndDP.Name = "EndDP"
        Me.EndDP.Size = New System.Drawing.Size(153, 20)
        Me.EndDP.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(640, 16)
        '
        'frmCallTimeExceeded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 645)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EndDP)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.LVStats)
        Me.Name = "frmCallTimeExceeded"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCallTimeExceeded"
        Me.Lists.ResumeLayout(False)
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVStats As System.Windows.Forms.ListView
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents AgentN As System.Windows.Forms.ColumnHeader
    Friend WithEvents Calls As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lists As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AppointmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutOfAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupervisorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotInterestedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotANumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar

End Class
