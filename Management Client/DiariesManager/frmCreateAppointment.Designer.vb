<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAppointment))
        Me.lblDiaryOwnerName = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.pnlAppointment = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAgent = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOwnerName = New System.Windows.Forms.Label
        Me.cmbDay = New System.Windows.Forms.ComboBox
        Me.radioApp5 = New System.Windows.Forms.RadioButton
        Me.radioApp4 = New System.Windows.Forms.RadioButton
        Me.radioApp3 = New System.Windows.Forms.RadioButton
        Me.radioApp2 = New System.Windows.Forms.RadioButton
        Me.radioApp1 = New System.Windows.Forms.RadioButton
        Me.DiaryListView1 = New CADNet.CallQueues.ManagerConsole.DiaryListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnFindCompany = New System.Windows.Forms.Button
        Me.pnlAppointment.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDiaryOwnerName
        '
        Me.lblDiaryOwnerName.AutoSize = True
        Me.lblDiaryOwnerName.Location = New System.Drawing.Point(12, 9)
        Me.lblDiaryOwnerName.Name = "lblDiaryOwnerName"
        Me.lblDiaryOwnerName.Size = New System.Drawing.Size(100, 13)
        Me.lblDiaryOwnerName.TabIndex = 0
        Me.lblDiaryOwnerName.Text = "lblDiaryOwnerName"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(527, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(608, 405)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(18, 25)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(89, 13)
        Me.lblCompanyName.TabIndex = 3
        Me.lblCompanyName.Text = "lblCompanyName"
        '
        'pnlAppointment
        '
        Me.pnlAppointment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAppointment.Controls.Add(Me.Label2)
        Me.pnlAppointment.Controls.Add(Me.cmbAgent)
        Me.pnlAppointment.Controls.Add(Me.Label1)
        Me.pnlAppointment.Controls.Add(Me.lblOwnerName)
        Me.pnlAppointment.Controls.Add(Me.cmbDay)
        Me.pnlAppointment.Controls.Add(Me.radioApp5)
        Me.pnlAppointment.Controls.Add(Me.radioApp4)
        Me.pnlAppointment.Controls.Add(Me.radioApp3)
        Me.pnlAppointment.Controls.Add(Me.radioApp2)
        Me.pnlAppointment.Controls.Add(Me.radioApp1)
        Me.pnlAppointment.Controls.Add(Me.DiaryListView1)
        Me.pnlAppointment.Enabled = False
        Me.pnlAppointment.Location = New System.Drawing.Point(12, 77)
        Me.pnlAppointment.Name = "pnlAppointment"
        Me.pnlAppointment.Size = New System.Drawing.Size(668, 322)
        Me.pnlAppointment.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Rep:"
        '
        'cmbAgent
        '
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(467, 49)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(165, 21)
        Me.cmbAgent.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Agent"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(464, 18)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(69, 13)
        Me.lblOwnerName.TabIndex = 7
        Me.lblOwnerName.Text = "Owner Name"
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(427, 76)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(205, 21)
        Me.cmbDay.TabIndex = 6
        '
        'radioApp5
        '
        Me.radioApp5.AutoSize = True
        Me.radioApp5.Location = New System.Drawing.Point(429, 209)
        Me.radioApp5.Name = "radioApp5"
        Me.radioApp5.Size = New System.Drawing.Size(93, 17)
        Me.radioApp5.TabIndex = 5
        Me.radioApp5.TabStop = True
        Me.radioApp5.Text = "Appointment 5"
        Me.radioApp5.UseVisualStyleBackColor = True
        '
        'radioApp4
        '
        Me.radioApp4.AutoSize = True
        Me.radioApp4.Location = New System.Drawing.Point(429, 186)
        Me.radioApp4.Name = "radioApp4"
        Me.radioApp4.Size = New System.Drawing.Size(93, 17)
        Me.radioApp4.TabIndex = 4
        Me.radioApp4.TabStop = True
        Me.radioApp4.Text = "Appointment 4"
        Me.radioApp4.UseVisualStyleBackColor = True
        '
        'radioApp3
        '
        Me.radioApp3.AutoSize = True
        Me.radioApp3.Location = New System.Drawing.Point(429, 163)
        Me.radioApp3.Name = "radioApp3"
        Me.radioApp3.Size = New System.Drawing.Size(93, 17)
        Me.radioApp3.TabIndex = 3
        Me.radioApp3.TabStop = True
        Me.radioApp3.Text = "Appointment 3"
        Me.radioApp3.UseVisualStyleBackColor = True
        '
        'radioApp2
        '
        Me.radioApp2.AutoSize = True
        Me.radioApp2.Location = New System.Drawing.Point(429, 140)
        Me.radioApp2.Name = "radioApp2"
        Me.radioApp2.Size = New System.Drawing.Size(93, 17)
        Me.radioApp2.TabIndex = 2
        Me.radioApp2.TabStop = True
        Me.radioApp2.Text = "Appointment 2"
        Me.radioApp2.UseVisualStyleBackColor = True
        '
        'radioApp1
        '
        Me.radioApp1.AutoSize = True
        Me.radioApp1.Location = New System.Drawing.Point(429, 117)
        Me.radioApp1.Name = "radioApp1"
        Me.radioApp1.Size = New System.Drawing.Size(93, 17)
        Me.radioApp1.TabIndex = 1
        Me.radioApp1.TabStop = True
        Me.radioApp1.Text = "Appointment 1"
        Me.radioApp1.UseVisualStyleBackColor = True
        '
        'DiaryListView1
        '
        Me.DiaryListView1.BackColor = System.Drawing.Color.White
        Me.DiaryListView1.DiaryID = 0
        Me.DiaryListView1.Location = New System.Drawing.Point(3, 3)
        Me.DiaryListView1.Name = "DiaryListView1"
        Me.DiaryListView1.Size = New System.Drawing.Size(394, 312)
        Me.DiaryListView1.StartDate = New Date(2008, 1, 7, 11, 9, 52, 654)
        Me.DiaryListView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnFindCompany)
        Me.GroupBox1.Controls.Add(Me.lblCompanyName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 46)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Company"
        '
        'btnFindCompany
        '
        Me.btnFindCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindCompany.Location = New System.Drawing.Point(590, 14)
        Me.btnFindCompany.Name = "btnFindCompany"
        Me.btnFindCompany.Size = New System.Drawing.Size(75, 23)
        Me.btnFindCompany.TabIndex = 5
        Me.btnFindCompany.Text = "Find"
        Me.btnFindCompany.UseVisualStyleBackColor = True
        '
        'frmCreateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 440)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlAppointment)
        Me.Controls.Add(Me.lblDiaryOwnerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreateAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create an Appointment"
        Me.pnlAppointment.ResumeLayout(False)
        Me.pnlAppointment.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDiaryOwnerName As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents pnlAppointment As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindCompany As System.Windows.Forms.Button
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents radioApp5 As System.Windows.Forms.RadioButton
    Friend WithEvents radioApp4 As System.Windows.Forms.RadioButton
    Friend WithEvents radioApp3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioApp2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioApp1 As System.Windows.Forms.RadioButton
    Friend WithEvents DiaryListView1 As CADNet.CallQueues.ManagerConsole.DiaryListView
    Friend WithEvents lblOwnerName As System.Windows.Forms.Label
    Friend WithEvents cmbAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
