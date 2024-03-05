<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepPerformanceStats
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.progress = New System.Windows.Forms.ToolStripProgressBar
        Me.EndDP = New System.Windows.Forms.DateTimePicker
        Me.Dtime2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Dtime1 = New System.Windows.Forms.ComboBox
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.ShowAsPercent = New System.Windows.Forms.CheckBox
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.ExMed = New System.Windows.Forms.ColumnHeader
        Me.LVStats = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.AgentN = New System.Windows.Forms.ColumnHeader
        Me.Apps = New System.Windows.Forms.ColumnHeader
        Me.unapproved = New System.Windows.Forms.ColumnHeader
        Me.Approved = New System.Windows.Forms.ColumnHeader
        Me.DeadTotal = New System.Windows.Forms.ColumnHeader
        Me.DAgent = New System.Windows.Forms.ColumnHeader
        Me.SAT = New System.Windows.Forms.ColumnHeader
        Me.Sold = New System.Windows.Forms.ColumnHeader
        Me.APi = New System.Windows.Forms.ColumnHeader
        Me.Pending = New System.Windows.Forms.ColumnHeader
        Me.NotSold = New System.Windows.Forms.ColumnHeader
        Me.ToExpensive = New System.Windows.Forms.ColumnHeader
        Me.NoFeedback = New System.Windows.Forms.ColumnHeader
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAreaHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(1000, 16)
        '
        'EndDP
        '
        Me.EndDP.CustomFormat = ""
        Me.EndDP.Location = New System.Drawing.Point(291, 61)
        Me.EndDP.Name = "EndDP"
        Me.EndDP.Size = New System.Drawing.Size(153, 20)
        Me.EndDP.TabIndex = 3
        '
        'Dtime2
        '
        Me.Dtime2.FormattingEnabled = True
        Me.Dtime2.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.Dtime2.Location = New System.Drawing.Point(450, 60)
        Me.Dtime2.Name = "Dtime2"
        Me.Dtime2.Size = New System.Drawing.Size(68, 21)
        Me.Dtime2.TabIndex = 4
        Me.Dtime2.Text = "9:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rep Appointment Statistics"
        '
        'Dtime1
        '
        Me.Dtime1.FormattingEnabled = True
        Me.Dtime1.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.Dtime1.Location = New System.Drawing.Point(171, 60)
        Me.Dtime1.Name = "Dtime1"
        Me.Dtime1.Size = New System.Drawing.Size(68, 21)
        Me.Dtime1.TabIndex = 2
        Me.Dtime1.Text = "9:00"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(12, 61)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(153, 20)
        Me.DTP1.TabIndex = 1
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
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(354, 3)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 23)
        Me.BtnRefresh.TabIndex = 0
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'ShowAsPercent
        '
        Me.ShowAsPercent.AutoSize = True
        Me.ShowAsPercent.Location = New System.Drawing.Point(574, 61)
        Me.ShowAsPercent.Name = "ShowAsPercent"
        Me.ShowAsPercent.Size = New System.Drawing.Size(125, 17)
        Me.ShowAsPercent.TabIndex = 5
        Me.ShowAsPercent.Text = "Show as Percentage"
        Me.ShowAsPercent.UseVisualStyleBackColor = True
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
        Me.pnlAreaHeader.Size = New System.Drawing.Size(1048, 53)
        Me.pnlAreaHeader.TabIndex = 0
        '
        'ExMed
        '
        Me.ExMed.Text = "EX Med"
        Me.ExMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ExMed.Width = 70
        '
        'LVStats
        '
        Me.LVStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.AgentN, Me.Apps, Me.unapproved, Me.Approved, Me.DeadTotal, Me.DAgent, Me.SAT, Me.Sold, Me.APi, Me.Pending, Me.NotSold, Me.ToExpensive, Me.ExMed, Me.NoFeedback})
        Me.LVStats.FullRowSelect = True
        Me.LVStats.GridLines = True
        Me.LVStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVStats.Location = New System.Drawing.Point(0, 89)
        Me.LVStats.MultiSelect = False
        Me.LVStats.Name = "LVStats"
        Me.LVStats.Size = New System.Drawing.Size(1042, 556)
        Me.LVStats.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LVStats.TabIndex = 6
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
        'Apps
        '
        Me.Apps.Text = "Apps"
        Me.Apps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Apps.Width = 70
        '
        'unapproved
        '
        Me.unapproved.Text = "Unapproved"
        Me.unapproved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.unapproved.Width = 70
        '
        'Approved
        '
        Me.Approved.Text = "Aproved"
        Me.Approved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Approved.Width = 70
        '
        'DeadTotal
        '
        Me.DeadTotal.Text = "Dead Total"
        Me.DeadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DeadTotal.Width = 70
        '
        'DAgent
        '
        Me.DAgent.Text = "Dead Agent"
        Me.DAgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DAgent.Width = 70
        '
        'SAT
        '
        Me.SAT.Text = "Apps Sat"
        Me.SAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SAT.Width = 70
        '
        'Sold
        '
        Me.Sold.Text = "Sold"
        Me.Sold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Sold.Width = 70
        '
        'APi
        '
        Me.APi.Text = "API"
        Me.APi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.APi.Width = 70
        '
        'Pending
        '
        Me.Pending.Text = "Pending"
        Me.Pending.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Pending.Width = 70
        '
        'NotSold
        '
        Me.NotSold.Tag = ""
        Me.NotSold.Text = "Not Sold"
        Me.NotSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NotSold.Width = 70
        '
        'ToExpensive
        '
        Me.ToExpensive.Text = "To Exp"
        Me.ToExpensive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToExpensive.Width = 70
        '
        'NoFeedback
        '
        Me.NoFeedback.Text = "No Feedback"
        Me.NoFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NoFeedback.Width = 70
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmRepPerformanceStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 645)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EndDP)
        Me.Controls.Add(Me.Dtime2)
        Me.Controls.Add(Me.Dtime1)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.ShowAsPercent)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.LVStats)
        Me.Name = "frmRepPerformanceStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRepPerformanceStats"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents EndDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtime2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtime1 As System.Windows.Forms.ComboBox
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents ShowAsPercent As System.Windows.Forms.CheckBox
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents ExMed As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVStats As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents AgentN As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apps As System.Windows.Forms.ColumnHeader
    Friend WithEvents DAgent As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeadTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents SAT As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sold As System.Windows.Forms.ColumnHeader
    Friend WithEvents Pending As System.Windows.Forms.ColumnHeader
    Friend WithEvents NotSold As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToExpensive As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents unapproved As System.Windows.Forms.ColumnHeader
    Friend WithEvents Approved As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoFeedback As System.Windows.Forms.ColumnHeader
    Friend WithEvents APi As System.Windows.Forms.ColumnHeader
End Class
