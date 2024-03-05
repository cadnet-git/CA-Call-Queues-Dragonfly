<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepToCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepToCompany))
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwAreas = New System.Windows.Forms.ListView
        Me.colUserName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Recs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Live = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.App = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cold = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NtH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dead = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Supervisor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NAN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OutOfArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TBLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Sale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'lvwAreas
        '
        Me.lvwAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.colUserName, Me.Recs, Me.Live, Me.App, Me.Sale, Me.CB, Me.Cold, Me.NtH, Me.Dead, Me.Supervisor, Me.NAN, Me.OutOfArea, Me.Gone})
        Me.lvwAreas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAreas.FullRowSelect = True
        Me.lvwAreas.GridLines = True
        Me.lvwAreas.Location = New System.Drawing.Point(0, 53)
        Me.lvwAreas.Name = "lvwAreas"
        Me.lvwAreas.Size = New System.Drawing.Size(1115, 561)
        Me.lvwAreas.TabIndex = 10
        Me.lvwAreas.UseCompatibleStateImageBehavior = False
        Me.lvwAreas.View = System.Windows.Forms.View.Details
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
        'Live
        '
        Me.Live.Text = "Live"
        Me.Live.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Live.Width = 75
        '
        'App
        '
        Me.App.Text = "Apps"
        Me.App.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.App.Width = 75
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
        'Dead
        '
        Me.Dead.Text = "Dead"
        Me.Dead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Dead.Width = 75
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
        'Gone
        '
        Me.Gone.Text = "Gone"
        Me.Gone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Gone.Width = 75
        '
        'OutOfArea
        '
        Me.OutOfArea.Text = "Out of Area"
        Me.OutOfArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OutOfArea.Width = 75
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(1115, 53)
        Me.pnlAreaHeader.TabIndex = 9
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
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Companies to Reps"
        '
        'PBar
        '
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(900, 16)
        Me.PBar.Step = 1
        Me.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBLabel, Me.PBar, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1115, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TBLabel
        '
        Me.TBLabel.Name = "TBLabel"
        Me.TBLabel.Size = New System.Drawing.Size(110, 17)
        Me.TBLabel.Text = "Analysing Database"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Sale
        '
        Me.Sale.Text = "Sale"
        Me.Sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Sale.Width = 75
        '
        'FrmRepToCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 636)
        Me.Controls.Add(Me.lvwAreas)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmRepToCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Companies To Reps"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwAreas As System.Windows.Forms.ListView
    Friend WithEvents colUserName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Recs As System.Windows.Forms.ColumnHeader
    Friend WithEvents App As System.Windows.Forms.ColumnHeader
    Friend WithEvents CB As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cold As System.Windows.Forms.ColumnHeader
    Friend WithEvents NtH As System.Windows.Forms.ColumnHeader
    Friend WithEvents Supervisor As System.Windows.Forms.ColumnHeader
    Friend WithEvents NAN As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gone As System.Windows.Forms.ColumnHeader
    Friend WithEvents OutOfArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TBLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Live As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dead As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sale As System.Windows.Forms.ColumnHeader
End Class
