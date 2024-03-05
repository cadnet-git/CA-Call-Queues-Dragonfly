<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoProvider
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
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnReschedule = New System.Windows.Forms.Button
        Me.lblWords = New System.Windows.Forms.Label
        Me.BtnAppointment = New System.Windows.Forms.Button
        Me.lblcoaching = New System.Windows.Forms.Label
        Me.lblcoaching2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 3)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(138, 38)
        Me.btnNotInterested.TabIndex = 13
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnReschedule)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Location = New System.Drawing.Point(579, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 251)
        Me.Panel1.TabIndex = 33
        '
        'btnReschedule
        '
        Me.btnReschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReschedule.Location = New System.Drawing.Point(3, 47)
        Me.btnReschedule.Name = "btnReschedule"
        Me.btnReschedule.Size = New System.Drawing.Size(141, 38)
        Me.btnReschedule.TabIndex = 15
        Me.btnReschedule.Text = "Reschedule"
        Me.btnReschedule.UseVisualStyleBackColor = True
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(14, 24)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(484, 17)
        Me.lblWords.TabIndex = 34
        Me.lblWords.Text = "Is there any particular reason why you don't have any Health Cover?"
        '
        'BtnAppointment
        '
        Me.BtnAppointment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAppointment.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnAppointment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAppointment.ForeColor = System.Drawing.Color.Black
        Me.BtnAppointment.Location = New System.Drawing.Point(363, 65)
        Me.BtnAppointment.Name = "BtnAppointment"
        Me.BtnAppointment.Size = New System.Drawing.Size(161, 27)
        Me.BtnAppointment.TabIndex = 40
        Me.BtnAppointment.Text = "Make Appointment"
        Me.BtnAppointment.UseVisualStyleBackColor = False
        '
        'lblcoaching
        '
        Me.lblcoaching.AutoSize = True
        Me.lblcoaching.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoaching.ForeColor = System.Drawing.Color.Crimson
        Me.lblcoaching.Location = New System.Drawing.Point(130, 151)
        Me.lblcoaching.Name = "lblcoaching"
        Me.lblcoaching.Size = New System.Drawing.Size(321, 19)
        Me.lblcoaching.TabIndex = 41
        Me.lblcoaching.Text = "This is where you make your money...."
        Me.lblcoaching.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblcoaching2
        '
        Me.lblcoaching2.AutoSize = True
        Me.lblcoaching2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoaching2.ForeColor = System.Drawing.Color.Crimson
        Me.lblcoaching2.Location = New System.Drawing.Point(146, 185)
        Me.lblcoaching2.Name = "lblcoaching2"
        Me.lblcoaching2.Size = New System.Drawing.Size(249, 19)
        Me.lblcoaching2.TabIndex = 42
        Me.lblcoaching2.Text = "....lets get that appointment!!"
        Me.lblcoaching2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.Agent.My.Resources.Resources.money
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(460, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CADNet.CallQueues.Agent.My.Resources.Resources.money
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(24, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'frmNoProvider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcoaching2)
        Me.Controls.Add(Me.lblcoaching)
        Me.Controls.Add(Me.BtnAppointment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblWords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoProvider"
        Me.Text = "frmProvider"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWords As System.Windows.Forms.Label
    Friend WithEvents BtnAppointment As System.Windows.Forms.Button
    Friend WithEvents lblcoaching As System.Windows.Forms.Label
    Friend WithEvents lblcoaching2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReschedule As System.Windows.Forms.Button
End Class
