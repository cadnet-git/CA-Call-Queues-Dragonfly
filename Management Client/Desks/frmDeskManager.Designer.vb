<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeskManager
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
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lvwDesks = New System.Windows.Forms.ListView
        Me.colFriendlyName = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New System.Windows.Forms.Button
        Me.cmbExtensions = New System.Windows.Forms.ComboBox
        Me.txtFriendlyName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCurrentDesk = New System.Windows.Forms.Label
        Me.colTerminalName = New System.Windows.Forms.ColumnHeader
        Me.colExtension = New System.Windows.Forms.ColumnHeader
        Me.cmbTerminalName = New System.Windows.Forms.ComboBox
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.btnAddNew)
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(400, 48)
        Me.pnlAreaHeader.TabIndex = 4
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(322, 3)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.balls
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desks"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 48)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwDesks)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbTerminalName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbExtensions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFriendlyName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(400, 518)
        Me.SplitContainer1.SplitterDistance = 260
        Me.SplitContainer1.TabIndex = 5
        '
        'lvwDesks
        '
        Me.lvwDesks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFriendlyName, Me.colTerminalName, Me.colExtension})
        Me.lvwDesks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDesks.FullRowSelect = True
        Me.lvwDesks.Location = New System.Drawing.Point(0, 0)
        Me.lvwDesks.Name = "lvwDesks"
        Me.lvwDesks.Size = New System.Drawing.Size(400, 260)
        Me.lvwDesks.TabIndex = 0
        Me.lvwDesks.UseCompatibleStateImageBehavior = False
        Me.lvwDesks.View = System.Windows.Forms.View.Details
        '
        'colFriendlyName
        '
        Me.colFriendlyName.Text = "Name"
        Me.colFriendlyName.Width = 43
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(243, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbExtensions
        '
        Me.cmbExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExtensions.FormattingEnabled = True
        Me.cmbExtensions.Location = New System.Drawing.Point(150, 122)
        Me.cmbExtensions.Name = "cmbExtensions"
        Me.cmbExtensions.Size = New System.Drawing.Size(168, 21)
        Me.cmbExtensions.TabIndex = 11
        '
        'txtFriendlyName
        '
        Me.txtFriendlyName.Location = New System.Drawing.Point(150, 50)
        Me.txtFriendlyName.Name = "txtFriendlyName"
        Me.txtFriendlyName.Size = New System.Drawing.Size(168, 20)
        Me.txtFriendlyName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Extension"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Computer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Friendly Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.lblCurrentDesk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 35)
        Me.Panel1.TabIndex = 5
        '
        'lblCurrentDesk
        '
        Me.lblCurrentDesk.AutoSize = True
        Me.lblCurrentDesk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDesk.ForeColor = System.Drawing.Color.White
        Me.lblCurrentDesk.Location = New System.Drawing.Point(13, 6)
        Me.lblCurrentDesk.Name = "lblCurrentDesk"
        Me.lblCurrentDesk.Size = New System.Drawing.Size(181, 17)
        Me.lblCurrentDesk.TabIndex = 4
        Me.lblCurrentDesk.Text = "Please select a desk above"
        '
        'colTerminalName
        '
        Me.colTerminalName.Text = "Computer"
        '
        'colExtension
        '
        Me.colExtension.Text = "Extension"
        Me.colExtension.Width = 293
        '
        'cmbTerminalName
        '
        Me.cmbTerminalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerminalName.FormattingEnabled = True
        Me.cmbTerminalName.Location = New System.Drawing.Point(150, 85)
        Me.cmbTerminalName.Name = "cmbTerminalName"
        Me.cmbTerminalName.Size = New System.Drawing.Size(168, 21)
        Me.cmbTerminalName.TabIndex = 13
        '
        'frmDeskManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "frmDeskManager"
        Me.Text = "frmDeskManager"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvwDesks As System.Windows.Forms.ListView
    Friend WithEvents colFriendlyName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentDesk As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbExtensions As System.Windows.Forms.ComboBox
    Friend WithEvents txtFriendlyName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colTerminalName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colExtension As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbTerminalName As System.Windows.Forms.ComboBox
End Class
