<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Me.lblGreet = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSupervisor = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.btnReschedule = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnTPS = New System.Windows.Forms.Button
        Me.btnNotRecognised = New System.Windows.Forms.Button
        Me.lblContactName = New System.Windows.Forms.Label
        Me.BtnYes = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.lblStdLife = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreet.Location = New System.Drawing.Point(27, 26)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(67, 17)
        Me.lblGreet.TabIndex = 0
        Me.lblGreet.Text = "Greeting"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnSupervisor)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Controls.Add(Me.btnReschedule)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnNotRecognised)
        Me.Panel1.Location = New System.Drawing.Point(585, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 270)
        Me.Panel1.TabIndex = 5
        '
        'btnSupervisor
        '
        Me.btnSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupervisor.Location = New System.Drawing.Point(3, 132)
        Me.btnSupervisor.Name = "btnSupervisor"
        Me.btnSupervisor.Size = New System.Drawing.Size(141, 38)
        Me.btnSupervisor.TabIndex = 4
        Me.btnSupervisor.Text = "Supervisor"
        Me.btnSupervisor.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 174)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(141, 38)
        Me.btnNotInterested.TabIndex = 5
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'btnReschedule
        '
        Me.btnReschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReschedule.Location = New System.Drawing.Point(3, 90)
        Me.btnReschedule.Name = "btnReschedule"
        Me.btnReschedule.Size = New System.Drawing.Size(141, 38)
        Me.btnReschedule.TabIndex = 3
        Me.btnReschedule.Text = "Reschedule"
        Me.btnReschedule.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Out of Area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTPS
        '
        Me.btnTPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTPS.Location = New System.Drawing.Point(411, 182)
        Me.btnTPS.Name = "btnTPS"
        Me.btnTPS.Size = New System.Drawing.Size(141, 38)
        Me.btnTPS.TabIndex = 0
        Me.btnTPS.Text = "TPS"
        Me.btnTPS.UseVisualStyleBackColor = True
        Me.btnTPS.Visible = False
        '
        'btnNotRecognised
        '
        Me.btnNotRecognised.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotRecognised.Location = New System.Drawing.Point(3, 6)
        Me.btnNotRecognised.Name = "btnNotRecognised"
        Me.btnNotRecognised.Size = New System.Drawing.Size(141, 38)
        Me.btnNotRecognised.TabIndex = 1
        Me.btnNotRecognised.Text = "Not Recognized"
        Me.btnNotRecognised.UseVisualStyleBackColor = True
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblContactName.Location = New System.Drawing.Point(27, 60)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(70, 17)
        Me.lblContactName.TabIndex = 1
        Me.lblContactName.Text = "Question"
        '
        'BtnYes
        '
        Me.BtnYes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes.ForeColor = System.Drawing.Color.Black
        Me.BtnYes.Location = New System.Drawing.Point(352, 55)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(52, 27)
        Me.BtnYes.TabIndex = 2
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.Black
        Me.btnNo.Location = New System.Drawing.Point(411, 55)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(53, 27)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblStdLife
        '
        Me.lblStdLife.AutoSize = True
        Me.lblStdLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdLife.ForeColor = System.Drawing.Color.Red
        Me.lblStdLife.Location = New System.Drawing.Point(48, 207)
        Me.lblStdLife.Name = "lblStdLife"
        Me.lblStdLife.Size = New System.Drawing.Size(0, 25)
        Me.lblStdLife.TabIndex = 4
        Me.lblStdLife.Visible = False
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.lblStdLife)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblContactName)
        Me.Controls.Add(Me.btnTPS)
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents btnTPS As System.Windows.Forms.Button
    Friend WithEvents btnNotRecognised As System.Windows.Forms.Button
    Friend WithEvents BtnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnReschedule As System.Windows.Forms.Button
    Friend WithEvents btnSupervisor As System.Windows.Forms.Button
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents lblStdLife As System.Windows.Forms.Label
End Class
