<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallBackTryForApointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblcoaching2 = New System.Windows.Forms.Label
        Me.lblcoaching = New System.Windows.Forms.Label
        Me.BtnAppointment = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCreateCallback = New System.Windows.Forms.Button
        Me.BtnReshedule = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcoaching2
        '
        Me.lblcoaching2.AutoSize = True
        Me.lblcoaching2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoaching2.ForeColor = System.Drawing.Color.Crimson
        Me.lblcoaching2.Location = New System.Drawing.Point(151, 230)
        Me.lblcoaching2.Name = "lblcoaching2"
        Me.lblcoaching2.Size = New System.Drawing.Size(249, 19)
        Me.lblcoaching2.TabIndex = 55
        Me.lblcoaching2.Text = "....lets get that appointment!!"
        Me.lblcoaching2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblcoaching
        '
        Me.lblcoaching.AutoSize = True
        Me.lblcoaching.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoaching.ForeColor = System.Drawing.Color.Crimson
        Me.lblcoaching.Location = New System.Drawing.Point(135, 196)
        Me.lblcoaching.Name = "lblcoaching"
        Me.lblcoaching.Size = New System.Drawing.Size(321, 19)
        Me.lblcoaching.TabIndex = 54
        Me.lblcoaching.Text = "This is where you make your money...."
        Me.lblcoaching.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.BtnAppointment.Location = New System.Drawing.Point(212, 151)
        Me.BtnAppointment.Name = "BtnAppointment"
        Me.BtnAppointment.Size = New System.Drawing.Size(161, 27)
        Me.BtnAppointment.TabIndex = 53
        Me.BtnAppointment.Text = "Make Appointment"
        Me.BtnAppointment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 14)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "We have spoken before about your Private Medical Insurance."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnCreateCallback)
        Me.Panel1.Controls.Add(Me.BtnReshedule)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Location = New System.Drawing.Point(579, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 256)
        Me.Panel1.TabIndex = 50
        '
        'btnCreateCallback
        '
        Me.btnCreateCallback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCallback.Location = New System.Drawing.Point(3, 94)
        Me.btnCreateCallback.Name = "btnCreateCallback"
        Me.btnCreateCallback.Size = New System.Drawing.Size(138, 43)
        Me.btnCreateCallback.TabIndex = 15
        Me.btnCreateCallback.Text = "Callback Next Year"
        Me.btnCreateCallback.UseVisualStyleBackColor = True
        '
        'BtnReshedule
        '
        Me.BtnReshedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReshedule.Location = New System.Drawing.Point(3, 50)
        Me.BtnReshedule.Name = "BtnReshedule"
        Me.BtnReshedule.Size = New System.Drawing.Size(138, 38)
        Me.BtnReshedule.TabIndex = 14
        Me.BtnReshedule.Text = "Reshedule"
        Me.BtnReshedule.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 7)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(138, 38)
        Me.btnNotInterested.TabIndex = 13
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 14)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "call Back try for apointment"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CADNet.CallQueues.Agent.My.Resources.Resources.money
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(29, 171)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.Agent.My.Resources.Resources.money
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(465, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(479, 14)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "You told me that you are covered by Bupa and your renewal is comming up. "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(478, 14)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "We discussed providing you with some alternative quotes, with that in mind"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(488, 14)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "I would like to arrange an appointment with you in the next couple of weeks "
        '
        'CallBackTryForApointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcoaching2)
        Me.Controls.Add(Me.lblcoaching)
        Me.Controls.Add(Me.BtnAppointment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CallBackTryForApointment"
        Me.Text = "CallBackTryForApointment. You told me that"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcoaching2 As System.Windows.Forms.Label
    Friend WithEvents lblcoaching As System.Windows.Forms.Label
    Friend WithEvents BtnAppointment As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnReshedule As System.Windows.Forms.Button
    Friend WithEvents btnCreateCallback As System.Windows.Forms.Button
End Class
