<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentStatsTimeFrame
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
        Me.NewCalls = New System.Windows.Forms.ColumnHeader
        Me.App = New System.Windows.Forms.ColumnHeader
        Me.CallBacks = New System.Windows.Forms.ColumnHeader
        Me.Resheduled = New System.Windows.Forms.ColumnHeader
        Me.NTH = New System.Windows.Forms.ColumnHeader
        Me.NotInteresteed = New System.Windows.Forms.ColumnHeader
        Me.Sup = New System.Windows.Forms.ColumnHeader
        Me.OutOfArea = New System.Windows.Forms.ColumnHeader
        Me.TPS = New System.Windows.Forms.ColumnHeader
        Me.NNR = New System.Windows.Forms.ColumnHeader
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.ShowAsPercent = New System.Windows.Forms.CheckBox
        Me.EndDP = New System.Windows.Forms.DateTimePicker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.progress = New System.Windows.Forms.ToolStripProgressBar
        Me.AppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutOfAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotInterestedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotANumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Lists = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Lists.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVStats
        '
        Me.LVStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.AgentN, Me.Calls, Me.NewCalls, Me.App, Me.CallBacks, Me.Resheduled, Me.NTH, Me.NotInteresteed, Me.Sup, Me.OutOfArea, Me.TPS, Me.NNR})
        Me.LVStats.FullRowSelect = True
        Me.LVStats.GridLines = True
        Me.LVStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVStats.Location = New System.Drawing.Point(3, 87)
        Me.LVStats.Name = "LVStats"
        Me.LVStats.Size = New System.Drawing.Size(663, 556)
        Me.LVStats.Sorting = System.Windows.Forms.SortOrder.Ascending
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
        Me.AgentN.Width = 106
        '
        'Calls
        '
        Me.Calls.Text = "#"
        Me.Calls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Calls.Width = 50
        '
        'NewCalls
        '
        Me.NewCalls.Text = "NC"
        Me.NewCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NewCalls.Width = 50
        '
        'App
        '
        Me.App.Text = "App"
        Me.App.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.App.Width = 50
        '
        'CallBacks
        '
        Me.CallBacks.Text = "CB"
        Me.CallBacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CallBacks.Width = 50
        '
        'Resheduled
        '
        Me.Resheduled.Text = "RS"
        Me.Resheduled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Resheduled.Width = 50
        '
        'NTH
        '
        Me.NTH.Text = "NtH"
        Me.NTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NTH.Width = 50
        '
        'NotInteresteed
        '
        Me.NotInteresteed.Text = "NI"
        Me.NotInteresteed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NotInteresteed.Width = 50
        '
        'Sup
        '
        Me.Sup.Text = "SU"
        Me.Sup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Sup.Width = 50
        '
        'OutOfArea
        '
        Me.OutOfArea.Tag = "Out Of Area"
        Me.OutOfArea.Text = "OA"
        Me.OutOfArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OutOfArea.Width = 50
        '
        'TPS
        '
        Me.TPS.Text = "TPS"
        Me.TPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TPS.Width = 50
        '
        'NNR
        '
        Me.NNR.Text = "NR"
        Me.NNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NNR.Width = 50
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
        Me.pnlAreaHeader.Size = New System.Drawing.Size(669, 53)
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
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Daily Statistics"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(312, 6)
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
        'ShowAsPercent
        '
        Me.ShowAsPercent.AutoSize = True
        Me.ShowAsPercent.Location = New System.Drawing.Point(378, 64)
        Me.ShowAsPercent.Name = "ShowAsPercent"
        Me.ShowAsPercent.Size = New System.Drawing.Size(125, 17)
        Me.ShowAsPercent.TabIndex = 3
        Me.ShowAsPercent.Text = "Show as Percentage"
        Me.ShowAsPercent.UseVisualStyleBackColor = True
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
        Me.StatusStrip1.Size = New System.Drawing.Size(669, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(640, 16)
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
        'Lists
        '
        Me.Lists.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentsToolStripMenuItem})
        Me.Lists.Name = "Lists"
        Me.Lists.Size = New System.Drawing.Size(104, 26)
        '
        'frmAgentStatsTimeFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 645)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EndDP)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.ShowAsPercent)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.LVStats)
        Me.Name = "frmAgentStatsTimeFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAgentStatsTimeFrame"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Lists.ResumeLayout(False)
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
    Friend WithEvents CallBacks As System.Windows.Forms.ColumnHeader
    Friend WithEvents Resheduled As System.Windows.Forms.ColumnHeader
    Friend WithEvents TPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents NNR As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sup As System.Windows.Forms.ColumnHeader
    Friend WithEvents OutOfArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents NotInteresteed As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents App As System.Windows.Forms.ColumnHeader
    Friend WithEvents NTH As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShowAsPercent As System.Windows.Forms.CheckBox
    Friend WithEvents NewCalls As System.Windows.Forms.ColumnHeader
    Friend WithEvents EndDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents AppointmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutOfAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupervisorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotInterestedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotANumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lists As System.Windows.Forms.ContextMenuStrip
End Class
