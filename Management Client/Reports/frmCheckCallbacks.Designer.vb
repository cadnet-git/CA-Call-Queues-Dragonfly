<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckCallbacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckCallbacks))
        Me.lbltitle = New System.Windows.Forms.Label
        Me.Company = New System.Windows.Forms.ColumnHeader
        Me.lvCallbacks = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Salutation = New System.Windows.Forms.ColumnHeader
        Me.surname = New System.Windows.Forms.ColumnHeader
        Me.title = New System.Windows.Forms.ColumnHeader
        Me.Provider = New System.Windows.Forms.ColumnHeader
        Me.Expires = New System.Windows.Forms.ColumnHeader
        Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestToColdCallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.position = New System.Windows.Forms.Label
        Me.BtnNext = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cMenu.SuspendLayout()
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(62, 20)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(211, 20)
        Me.lbltitle.TabIndex = 4
        Me.lbltitle.Text = "Call backs for Agent????"
        '
        'Company
        '
        Me.Company.Text = "Company"
        Me.Company.Width = 222
        '
        'lvCallbacks
        '
        Me.lvCallbacks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Company, Me.Salutation, Me.surname, Me.title, Me.Provider, Me.Expires})
        Me.lvCallbacks.ContextMenuStrip = Me.cMenu
        Me.lvCallbacks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvCallbacks.FullRowSelect = True
        Me.lvCallbacks.GridLines = True
        Me.lvCallbacks.Location = New System.Drawing.Point(0, 53)
        Me.lvCallbacks.Name = "lvCallbacks"
        Me.lvCallbacks.Size = New System.Drawing.Size(888, 476)
        Me.lvCallbacks.TabIndex = 13
        Me.lvCallbacks.UseCompatibleStateImageBehavior = False
        Me.lvCallbacks.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'Salutation
        '
        Me.Salutation.Text = "Salutation"
        Me.Salutation.Width = 62
        '
        'surname
        '
        Me.surname.Text = "Surname"
        Me.surname.Width = 136
        '
        'title
        '
        Me.title.Text = "Job Title"
        Me.title.Width = 122
        '
        'Provider
        '
        Me.Provider.Text = "Provider"
        Me.Provider.Width = 126
        '
        'Expires
        '
        Me.Expires.Text = "Expires"
        Me.Expires.Width = 124
        '
        'cMenu
        '
        Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHistoryToolStripMenuItem, Me.RestToColdCallToolStripMenuItem})
        Me.cMenu.Name = "cMenu"
        Me.cMenu.Size = New System.Drawing.Size(168, 48)
        '
        'ViewHistoryToolStripMenuItem
        '
        Me.ViewHistoryToolStripMenuItem.Name = "ViewHistoryToolStripMenuItem"
        Me.ViewHistoryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ViewHistoryToolStripMenuItem.Text = "View Company"
        '
        'RestToColdCallToolStripMenuItem
        '
        Me.RestToColdCallToolStripMenuItem.Name = "RestToColdCallToolStripMenuItem"
        Me.RestToColdCallToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RestToColdCallToolStripMenuItem.Text = "Reset to Cold Call"
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.position)
        Me.pnlAreaHeader.Controls.Add(Me.BtnNext)
        Me.pnlAreaHeader.Controls.Add(Me.btnBack)
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.lbltitle)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(888, 53)
        Me.pnlAreaHeader.TabIndex = 12
        '
        'position
        '
        Me.position.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position.ForeColor = System.Drawing.Color.White
        Me.position.Location = New System.Drawing.Point(600, 16)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(211, 20)
        Me.position.TabIndex = 10
        Me.position.Text = "2350-2380 of 10896"
        Me.position.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.White
        Me.BtnNext.Location = New System.Drawing.Point(815, 9)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(61, 36)
        Me.BtnNext.TabIndex = 9
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(535, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(61, 36)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'frmCheckCallbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 506)
        Me.Controls.Add(Me.lvCallbacks)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "frmCheckCallbacks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.cMenu.ResumeLayout(False)
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Company As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvCallbacks As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Salutation As System.Windows.Forms.ColumnHeader
    Friend WithEvents surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Provider As System.Windows.Forms.ColumnHeader
    Friend WithEvents Expires As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents cMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents RestToColdCallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
