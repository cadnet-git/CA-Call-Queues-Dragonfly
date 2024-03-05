<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatsDrillDown
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "01204846846", "This is the reason the call did not happen"}, -1)
        Me.LVDetails = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Tel = New System.Windows.Forms.ColumnHeader
        Me.Reason = New System.Windows.Forms.ColumnHeader
        Me.AppID = New System.Windows.Forms.ColumnHeader
        Me.LBLuser = New System.Windows.Forms.Label
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVDetails
        '
        Me.LVDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Tel, Me.Reason, Me.AppID})
        Me.LVDetails.ContextMenuStrip = Me.CM
        Me.LVDetails.FullRowSelect = True
        Me.LVDetails.GridLines = True
        Me.LVDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVDetails.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LVDetails.Location = New System.Drawing.Point(6, 56)
        Me.LVDetails.Name = "LVDetails"
        Me.LVDetails.Size = New System.Drawing.Size(370, 518)
        Me.LVDetails.TabIndex = 1
        Me.LVDetails.UseCompatibleStateImageBehavior = False
        Me.LVDetails.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'Tel
        '
        Me.Tel.Text = "Telephone"
        Me.Tel.Width = 107
        '
        'Reason
        '
        Me.Reason.Text = "Reason"
        Me.Reason.Width = 278
        '
        'AppID
        '
        Me.AppID.Text = "AppID"
        Me.AppID.Width = 0
        '
        'LBLuser
        '
        Me.LBLuser.AutoSize = True
        Me.LBLuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLuser.ForeColor = System.Drawing.Color.White
        Me.LBLuser.Location = New System.Drawing.Point(88, 3)
        Me.LBLuser.Name = "LBLuser"
        Me.LBLuser.Size = New System.Drawing.Size(128, 20)
        Me.LBLuser.TabIndex = 0
        Me.LBLuser.Text = "Daily Statistics"
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.Button1)
        Me.pnlAreaHeader.Controls.Add(Me.lblType)
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.LBLuser)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(380, 53)
        Me.pnlAreaHeader.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(88, 31)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(128, 20)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Daily Statistics"
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
        'CM
        '
        Me.CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.CM.Name = "CM"
        Me.CM.Size = New System.Drawing.Size(153, 48)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'frmStatsDrillDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 586)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Controls.Add(Me.LVDetails)
        Me.Name = "frmStatsDrillDown"
        Me.Text = "frmStatsDrillDown"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LVDetails As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Reason As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBLuser As System.Windows.Forms.Label
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AppID As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
