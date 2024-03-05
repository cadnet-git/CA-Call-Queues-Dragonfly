<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserStats))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TBLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.lvwAreas = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUserName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Recs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ODCallBacks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ODColdCalls = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.App = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cold = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NtH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Supervisor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NAN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OutOfArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReallocateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODCallBacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODColdCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallbacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColdCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotToHandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkDeadCompaniesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckCallBacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelmoving = New System.Windows.Forms.Panel
        Me.lblCounter = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblmessage = New System.Windows.Forms.Label
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlAreaHeader.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.panelmoving.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Companies to Agents"
        '
        'PBar
        '
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(900, 16)
        Me.PBar.Step = 1
        Me.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'TBLabel
        '
        Me.TBLabel.Name = "TBLabel"
        Me.TBLabel.Size = New System.Drawing.Size(110, 17)
        Me.TBLabel.Text = "Analysing Database"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBLabel, Me.PBar, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 535)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1042, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(1042, 53)
        Me.pnlAreaHeader.TabIndex = 6
        '
        'lvwAreas
        '
        Me.lvwAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.colUserName, Me.Recs, Me.ODCallBacks, Me.ODColdCalls, Me.App, Me.Sale, Me.CB, Me.Cold, Me.NtH, Me.Supervisor, Me.NAN, Me.OutOfArea})
        Me.lvwAreas.ContextMenuStrip = Me.CMenu
        Me.lvwAreas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAreas.FullRowSelect = True
        Me.lvwAreas.GridLines = True
        Me.lvwAreas.Location = New System.Drawing.Point(0, 53)
        Me.lvwAreas.Name = "lvwAreas"
        Me.lvwAreas.Size = New System.Drawing.Size(1042, 482)
        Me.lvwAreas.TabIndex = 11
        Me.lvwAreas.UseCompatibleStateImageBehavior = False
        Me.lvwAreas.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'colUserName
        '
        Me.colUserName.Text = "User"
        Me.colUserName.Width = 183
        '
        'Recs
        '
        Me.Recs.Text = "Records"
        Me.Recs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Recs.Width = 75
        '
        'ODCallBacks
        '
        Me.ODCallBacks.Text = "OD CallBack"
        Me.ODCallBacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ODCallBacks.Width = 75
        '
        'ODColdCalls
        '
        Me.ODColdCalls.Text = "OD ColdCall"
        Me.ODColdCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ODColdCalls.Width = 75
        '
        'App
        '
        Me.App.Text = "Apps"
        Me.App.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.App.Width = 75
        '
        'Sale
        '
        Me.Sale.Text = "Sale"
        Me.Sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Sale.Width = 75
        '
        'CB
        '
        Me.CB.Text = "Call Back"
        Me.CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CB.Width = 75
        '
        'Cold
        '
        Me.Cold.Text = "Cold Call"
        Me.Cold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cold.Width = 75
        '
        'NtH
        '
        Me.NtH.Text = "Not to Hand"
        Me.NtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NtH.Width = 75
        '
        'Supervisor
        '
        Me.Supervisor.Text = "Supervisor"
        Me.Supervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Supervisor.Width = 75
        '
        'NAN
        '
        Me.NAN.Text = "Not Number"
        Me.NAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NAN.Width = 75
        '
        'OutOfArea
        '
        Me.OutOfArea.Text = "Out of Area"
        Me.OutOfArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OutOfArea.Width = 75
        '
        'CMenu
        '
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReallocateToolStripMenuItem, Me.ParkDeadCompaniesToolStripMenuItem, Me.CheckCallBacksToolStripMenuItem, Me.RetToolStripMenuItem})
        Me.CMenu.Name = "CMenu"
        Me.CMenu.Size = New System.Drawing.Size(232, 114)
        '
        'ReallocateToolStripMenuItem
        '
        Me.ReallocateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ODCallBacksToolStripMenuItem, Me.ODColdCallsToolStripMenuItem, Me.AppointmentsToolStripMenuItem, Me.CallbacksToolStripMenuItem, Me.ColdCallsToolStripMenuItem, Me.NotToHandsToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.ReallocateToolStripMenuItem.Name = "ReallocateToolStripMenuItem"
        Me.ReallocateToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReallocateToolStripMenuItem.Text = "Reallocate"
        '
        'ODCallBacksToolStripMenuItem
        '
        Me.ODCallBacksToolStripMenuItem.Name = "ODCallBacksToolStripMenuItem"
        Me.ODCallBacksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ODCallBacksToolStripMenuItem.Text = "OD Call Backs"
        '
        'ODColdCallsToolStripMenuItem
        '
        Me.ODColdCallsToolStripMenuItem.Name = "ODColdCallsToolStripMenuItem"
        Me.ODColdCallsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ODColdCallsToolStripMenuItem.Text = "OD Cold Calls"
        '
        'AppointmentsToolStripMenuItem
        '
        Me.AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem"
        Me.AppointmentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AppointmentsToolStripMenuItem.Text = "Appointments"
        '
        'CallbacksToolStripMenuItem
        '
        Me.CallbacksToolStripMenuItem.Name = "CallbacksToolStripMenuItem"
        Me.CallbacksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CallbacksToolStripMenuItem.Text = "Callbacks"
        '
        'ColdCallsToolStripMenuItem
        '
        Me.ColdCallsToolStripMenuItem.Name = "ColdCallsToolStripMenuItem"
        Me.ColdCallsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColdCallsToolStripMenuItem.Text = "Cold Calls"
        '
        'NotToHandsToolStripMenuItem
        '
        Me.NotToHandsToolStripMenuItem.Name = "NotToHandsToolStripMenuItem"
        Me.NotToHandsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotToHandsToolStripMenuItem.Text = "Not to Hands"
        '
        'ParkDeadCompaniesToolStripMenuItem
        '
        Me.ParkDeadCompaniesToolStripMenuItem.Name = "ParkDeadCompaniesToolStripMenuItem"
        Me.ParkDeadCompaniesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ParkDeadCompaniesToolStripMenuItem.Text = "Park Dead Companies"
        '
        'CheckCallBacksToolStripMenuItem
        '
        Me.CheckCallBacksToolStripMenuItem.Name = "CheckCallBacksToolStripMenuItem"
        Me.CheckCallBacksToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CheckCallBacksToolStripMenuItem.Text = "Check Call Backs"
        '
        'RetToolStripMenuItem
        '
        Me.RetToolStripMenuItem.Name = "RetToolStripMenuItem"
        Me.RetToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RetToolStripMenuItem.Text = "Return Cold Calls  to Cold Pot"
        '
        'panelmoving
        '
        Me.panelmoving.BackColor = System.Drawing.Color.White
        Me.panelmoving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmoving.Controls.Add(Me.lblCounter)
        Me.panelmoving.Controls.Add(Me.Label6)
        Me.panelmoving.Controls.Add(Me.lblmessage)
        Me.panelmoving.Location = New System.Drawing.Point(421, 228)
        Me.panelmoving.Name = "panelmoving"
        Me.panelmoving.Size = New System.Drawing.Size(200, 100)
        Me.panelmoving.TabIndex = 12
        Me.panelmoving.Visible = False
        '
        'lblCounter
        '
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCounter.Location = New System.Drawing.Point(42, 69)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(114, 17)
        Me.lblCounter.TabIndex = 2
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(44, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Please Wait...."
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmessage.Location = New System.Drawing.Point(44, 15)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(98, 17)
        Me.lblmessage.TabIndex = 0
        Me.lblmessage.Text = "Moving Data"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'FrmUserStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 557)
        Me.Controls.Add(Me.panelmoving)
        Me.Controls.Add(Me.lvwAreas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "FrmUserStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        Me.CMenu.ResumeLayout(False)
        Me.panelmoving.ResumeLayout(False)
        Me.panelmoving.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TBLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents lvwAreas As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUserName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Recs As System.Windows.Forms.ColumnHeader
    Friend WithEvents ODCallBacks As System.Windows.Forms.ColumnHeader
    Friend WithEvents ODColdCalls As System.Windows.Forms.ColumnHeader
    Friend WithEvents App As System.Windows.Forms.ColumnHeader
    Friend WithEvents CB As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cold As System.Windows.Forms.ColumnHeader
    Friend WithEvents NtH As System.Windows.Forms.ColumnHeader
    Friend WithEvents Supervisor As System.Windows.Forms.ColumnHeader
    Friend WithEvents NAN As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sale As System.Windows.Forms.ColumnHeader
    Friend WithEvents OutOfArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReallocateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODCallBacksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODColdCallsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CallbacksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColdCallsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotToHandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParkDeadCompaniesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckCallBacksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelmoving As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
