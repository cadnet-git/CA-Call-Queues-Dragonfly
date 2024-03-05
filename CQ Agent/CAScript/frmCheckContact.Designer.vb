<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckContact
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSupervisor = New System.Windows.Forms.Button
        Me.btnOutofArea = New System.Windows.Forms.Button
        Me.btnReschedule = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.btnYes = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUsernameGreet = New System.Windows.Forms.Label
        Me.lblGreet = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlQ1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.pnlQ1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnSupervisor)
        Me.Panel1.Controls.Add(Me.btnOutofArea)
        Me.Panel1.Controls.Add(Me.btnReschedule)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Location = New System.Drawing.Point(593, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 251)
        Me.Panel1.TabIndex = 27
        '
        'btnSupervisor
        '
        Me.btnSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupervisor.Location = New System.Drawing.Point(5, 139)
        Me.btnSupervisor.Name = "btnSupervisor"
        Me.btnSupervisor.Size = New System.Drawing.Size(119, 38)
        Me.btnSupervisor.TabIndex = 16
        Me.btnSupervisor.Text = "Supervisor"
        Me.btnSupervisor.UseVisualStyleBackColor = True
        '
        'btnOutofArea
        '
        Me.btnOutofArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutofArea.Location = New System.Drawing.Point(5, 95)
        Me.btnOutofArea.Name = "btnOutofArea"
        Me.btnOutofArea.Size = New System.Drawing.Size(119, 38)
        Me.btnOutofArea.TabIndex = 15
        Me.btnOutofArea.Text = "Out of Area"
        Me.btnOutofArea.UseVisualStyleBackColor = True
        '
        'btnReschedule
        '
        Me.btnReschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReschedule.Location = New System.Drawing.Point(5, 51)
        Me.btnReschedule.Name = "btnReschedule"
        Me.btnReschedule.Size = New System.Drawing.Size(119, 38)
        Me.btnReschedule.TabIndex = 14
        Me.btnReschedule.Text = "Reschedule"
        Me.btnReschedule.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(5, 7)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(119, 38)
        Me.btnNotInterested.TabIndex = 13
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(159, 107)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(52, 27)
        Me.btnYes.TabIndex = 36
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(219, 107)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(52, 27)
        Me.btnNo.TabIndex = 37
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "I understand that you make the decision regarding the company's"
        '
        'lblUsernameGreet
        '
        Me.lblUsernameGreet.AutoSize = True
        Me.lblUsernameGreet.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsernameGreet.Location = New System.Drawing.Point(12, 42)
        Me.lblUsernameGreet.Name = "lblUsernameGreet"
        Me.lblUsernameGreet.Size = New System.Drawing.Size(440, 17)
        Me.lblUsernameGreet.TabIndex = 45
        Me.lblUsernameGreet.Text = "My name is <username> calling from Dragonfly Crowd."
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreet.Location = New System.Drawing.Point(12, 7)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(110, 17)
        Me.lblGreet.TabIndex = 44
        Me.lblGreet.Text = "Good Morning,"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "medical insurance?"
        '
        'pnlQ1
        '
        Me.pnlQ1.Controls.Add(Me.btnYes)
        Me.pnlQ1.Controls.Add(Me.lblUsernameGreet)
        Me.pnlQ1.Controls.Add(Me.lblGreet)
        Me.pnlQ1.Controls.Add(Me.btnNo)
        Me.pnlQ1.Controls.Add(Me.Label1)
        Me.pnlQ1.Controls.Add(Me.Label2)
        Me.pnlQ1.Location = New System.Drawing.Point(12, 12)
        Me.pnlQ1.Name = "pnlQ1"
        Me.pnlQ1.Size = New System.Drawing.Size(575, 150)
        Me.pnlQ1.TabIndex = 49
        '
        'frmCheckContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.pnlQ1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCheckContact"
        Me.Text = "frmCheckContact"
        Me.Panel1.ResumeLayout(False)
        Me.pnlQ1.ResumeLayout(False)
        Me.pnlQ1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsernameGreet As System.Windows.Forms.Label
    Friend WithEvents lblGreet As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlQ1 As System.Windows.Forms.Panel
    Friend WithEvents btnReschedule As System.Windows.Forms.Button
    Friend WithEvents btnOutofArea As System.Windows.Forms.Button
    Friend WithEvents btnSupervisor As System.Windows.Forms.Button
End Class
