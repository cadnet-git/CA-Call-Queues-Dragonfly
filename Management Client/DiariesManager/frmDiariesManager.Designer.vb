<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiariesManager
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvwDiaries = New System.Windows.Forms.ListView()
        Me.colDiaryName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiaryListView1 = New CADNet.CallQueues.ManagerConsole.DiaryListView()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.btnAddAppointment = New System.Windows.Forms.Button
        Me.lblCurrentUser = New System.Windows.Forms.Label
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(400, 48)
        Me.pnlAreaHeader.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.Diaries
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
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Diaries"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 48)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwDiaries)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.DiaryListView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(400, 518)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 5
        '
        'lvwDiaries
        '
        Me.lvwDiaries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDiaryName})
        Me.lvwDiaries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDiaries.HideSelection = False
        Me.lvwDiaries.Location = New System.Drawing.Point(0, 0)
        Me.lvwDiaries.Name = "lvwDiaries"
        Me.lvwDiaries.Size = New System.Drawing.Size(400, 160)
        Me.lvwDiaries.TabIndex = 0
        Me.lvwDiaries.UseCompatibleStateImageBehavior = False
        Me.lvwDiaries.View = System.Windows.Forms.View.Details
        '
        'colDiaryName
        '
        Me.colDiaryName.Width = 374
        '
        'DiaryListView1
        '
        Me.DiaryListView1.BackColor = System.Drawing.Color.White
        Me.DiaryListView1.DiaryID = 0
        Me.DiaryListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiaryListView1.Location = New System.Drawing.Point(0, 35)
        Me.DiaryListView1.Name = "DiaryListView1"
        Me.DiaryListView1.Size = New System.Drawing.Size(400, 319)
        Me.DiaryListView1.StartDate = New Date(2020, 6, 1, 10, 47, 11, 72)
        Me.DiaryListView1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.pnlOptions)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 35)
        Me.Panel1.TabIndex = 5
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnAddAppointment)
        Me.pnlOptions.Location = New System.Drawing.Point(241, 3)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(156, 26)
        Me.pnlOptions.TabIndex = 5
        Me.pnlOptions.Visible = False
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Location = New System.Drawing.Point(78, 3)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAppointment.TabIndex = 0
        Me.btnAddAppointment.Text = "Add"
        Me.btnAddAppointment.UseVisualStyleBackColor = True
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.ForeColor = System.Drawing.Color.White
        Me.lblCurrentUser.Location = New System.Drawing.Point(13, 6)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(182, 17)
        Me.lblCurrentUser.TabIndex = 4
        Me.lblCurrentUser.Text = "Please select a diary above"
        '
        'frmDiariesManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "frmDiariesManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Diaries Manager"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvwDiaries As System.Windows.Forms.ListView
    Friend WithEvents colDiaryName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentUser As System.Windows.Forms.Label
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents btnAddAppointment As System.Windows.Forms.Button
    Friend WithEvents DiaryListView1 As CADNet.CallQueues.ManagerConsole.DiaryListView
End Class
