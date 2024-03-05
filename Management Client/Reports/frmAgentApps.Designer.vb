<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentApps
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
        Me.Company = New System.Windows.Forms.ColumnHeader
        Me.Agent = New System.Windows.Forms.ColumnHeader
        Me.EndDP = New System.Windows.Forms.DateTimePicker
        Me.Dtime1 = New System.Windows.Forms.ComboBox
        Me.Dtime2 = New System.Windows.Forms.ComboBox
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVStats = New System.Windows.Forms.ListView
        Me.Booked = New System.Windows.Forms.ColumnHeader
        Me.iRep = New System.Windows.Forms.ColumnHeader
        Me.ItmeDate = New System.Windows.Forms.ColumnHeader
        Me.cbAgent = New System.Windows.Forms.ComboBox
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBad = New System.Windows.Forms.Label
        Me.lblGood = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblHold = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblFuture = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAreaHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1050, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(740, 16)
        '
        'Company
        '
        Me.Company.Text = "Company"
        Me.Company.Width = 300
        '
        'Agent
        '
        Me.Agent.Text = "Agent"
        Me.Agent.Width = 150
        '
        'EndDP
        '
        Me.EndDP.CustomFormat = ""
        Me.EndDP.Location = New System.Drawing.Point(291, 61)
        Me.EndDP.Name = "EndDP"
        Me.EndDP.Size = New System.Drawing.Size(153, 20)
        Me.EndDP.TabIndex = 11
        '
        'Dtime1
        '
        Me.Dtime1.FormattingEnabled = True
        Me.Dtime1.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.Dtime1.Location = New System.Drawing.Point(171, 60)
        Me.Dtime1.Name = "Dtime1"
        Me.Dtime1.Size = New System.Drawing.Size(68, 21)
        Me.Dtime1.TabIndex = 10
        Me.Dtime1.Text = "9:00"
        '
        'Dtime2
        '
        Me.Dtime2.FormattingEnabled = True
        Me.Dtime2.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.Dtime2.Location = New System.Drawing.Point(450, 60)
        Me.Dtime2.Name = "Dtime2"
        Me.Dtime2.Size = New System.Drawing.Size(68, 21)
        Me.Dtime2.TabIndex = 12
        Me.Dtime2.Text = "9:00"
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(12, 61)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(153, 20)
        Me.DTP1.TabIndex = 9
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
        Me.BtnRefresh.Location = New System.Drawing.Point(343, 12)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 23)
        Me.BtnRefresh.TabIndex = 0
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.lblFuture)
        Me.pnlAreaHeader.Controls.Add(Me.Label8)
        Me.pnlAreaHeader.Controls.Add(Me.lblHold)
        Me.pnlAreaHeader.Controls.Add(Me.Label6)
        Me.pnlAreaHeader.Controls.Add(Me.lblGood)
        Me.pnlAreaHeader.Controls.Add(Me.Label4)
        Me.pnlAreaHeader.Controls.Add(Me.lblBad)
        Me.pnlAreaHeader.Controls.Add(Me.Label1)
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Controls.Add(Me.BtnRefresh)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(1050, 53)
        Me.pnlAreaHeader.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agent Appointment Status"
        '
        'LVStats
        '
        Me.LVStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Booked, Me.Agent, Me.Company, Me.iRep, Me.ItmeDate, Me.Status})
        Me.LVStats.FullRowSelect = True
        Me.LVStats.GridLines = True
        Me.LVStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVStats.Location = New System.Drawing.Point(0, 89)
        Me.LVStats.MultiSelect = False
        Me.LVStats.Name = "LVStats"
        Me.LVStats.Size = New System.Drawing.Size(1050, 538)
        Me.LVStats.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LVStats.TabIndex = 14
        Me.LVStats.UseCompatibleStateImageBehavior = False
        Me.LVStats.View = System.Windows.Forms.View.Details
        '
        'Booked
        '
        Me.Booked.Text = "Booked"
        Me.Booked.Width = 150
        '
        'iRep
        '
        Me.iRep.Text = "Rep"
        Me.iRep.Width = 150
        '
        'ItmeDate
        '
        Me.ItmeDate.Text = "Appointment Date"
        Me.ItmeDate.Width = 134
        '
        'cbAgent
        '
        Me.cbAgent.FormattingEnabled = True
        Me.cbAgent.Location = New System.Drawing.Point(572, 59)
        Me.cbAgent.Name = "cbAgent"
        Me.cbAgent.Size = New System.Drawing.Size(226, 21)
        Me.cbAgent.TabIndex = 8
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(601, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bad"
        '
        'lblBad
        '
        Me.lblBad.AutoSize = True
        Me.lblBad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBad.ForeColor = System.Drawing.Color.White
        Me.lblBad.Location = New System.Drawing.Point(610, 27)
        Me.lblBad.Name = "lblBad"
        Me.lblBad.Size = New System.Drawing.Size(16, 17)
        Me.lblBad.TabIndex = 9
        Me.lblBad.Text = "0"
        Me.lblBad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGood
        '
        Me.lblGood.AutoSize = True
        Me.lblGood.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGood.ForeColor = System.Drawing.Color.White
        Me.lblGood.Location = New System.Drawing.Point(533, 27)
        Me.lblGood.Name = "lblGood"
        Me.lblGood.Size = New System.Drawing.Size(16, 17)
        Me.lblGood.TabIndex = 11
        Me.lblGood.Text = "0"
        Me.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(520, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Good"
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.ForeColor = System.Drawing.Color.White
        Me.lblHold.Location = New System.Drawing.Point(687, 27)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(16, 17)
        Me.lblHold.TabIndex = 13
        Me.lblHold.Text = "0"
        Me.lblHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(672, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Hold"
        '
        'lblFuture
        '
        Me.lblFuture.AutoSize = True
        Me.lblFuture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuture.ForeColor = System.Drawing.Color.White
        Me.lblFuture.Location = New System.Drawing.Point(764, 27)
        Me.lblFuture.Name = "lblFuture"
        Me.lblFuture.Size = New System.Drawing.Size(16, 17)
        Me.lblFuture.TabIndex = 15
        Me.lblFuture.Text = "0"
        Me.lblFuture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(747, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Future"
        '
        'frmAgentApps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 652)
        Me.Controls.Add(Me.cbAgent)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EndDP)
        Me.Controls.Add(Me.Dtime1)
        Me.Controls.Add(Me.Dtime2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.LVStats)
        Me.Name = "frmAgentApps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgentApps"
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
    Friend WithEvents Company As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agent As System.Windows.Forms.ColumnHeader
    Friend WithEvents EndDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtime1 As System.Windows.Forms.ComboBox
    Friend WithEvents Dtime2 As System.Windows.Forms.ComboBox
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVStats As System.Windows.Forms.ListView
    Friend WithEvents Booked As System.Windows.Forms.ColumnHeader
    Friend WithEvents iRep As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItmeDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFuture As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblGood As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
