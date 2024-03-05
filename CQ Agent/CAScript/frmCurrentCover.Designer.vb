<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentCover
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
        Me.BtnBack = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.btnNotToHand = New System.Windows.Forms.Button
        Me.lblText1 = New System.Windows.Forms.Label
        Me.cmbExpires = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button
        Me.lbltext2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.lbltext3 = New System.Windows.Forms.Label
        Me.cmbExpiresDay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Controls.Add(Me.btnNotToHand)
        Me.Panel1.Location = New System.Drawing.Point(579, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 251)
        Me.Panel1.TabIndex = 17
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(3, 97)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(138, 38)
        Me.BtnBack.TabIndex = 29
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 10)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(138, 38)
        Me.btnNotInterested.TabIndex = 13
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'btnNotToHand
        '
        Me.btnNotToHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotToHand.Location = New System.Drawing.Point(3, 53)
        Me.btnNotToHand.Name = "btnNotToHand"
        Me.btnNotToHand.Size = New System.Drawing.Size(138, 38)
        Me.btnNotToHand.TabIndex = 28
        Me.btnNotToHand.Text = "Not to Hand"
        Me.btnNotToHand.UseVisualStyleBackColor = True
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText1.Location = New System.Drawing.Point(12, 12)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(511, 17)
        Me.lblText1.TabIndex = 18
        Me.lblText1.Text = "All I am looking for is a chance to put some quotes forward for you when"
        '
        'cmbExpires
        '
        Me.cmbExpires.FormattingEnabled = True
        Me.cmbExpires.Location = New System.Drawing.Point(234, 157)
        Me.cmbExpires.Name = "cmbExpires"
        Me.cmbExpires.Size = New System.Drawing.Size(158, 21)
        Me.cmbExpires.TabIndex = 22
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(429, 197)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(129, 45)
        Me.btnOK.TabIndex = 29
        Me.btnOK.Text = "Next"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lbltext2
        '
        Me.lbltext2.AutoSize = True
        Me.lbltext2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext2.Location = New System.Drawing.Point(12, 39)
        Me.lbltext2.Name = "lbltext2"
        Me.lbltext2.Size = New System.Drawing.Size(227, 17)
        Me.lbltext2.TabIndex = 30
        Me.lbltext2.Text = "your next renewal comes round"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Who are you covered with?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "When is your renewal?"
        '
        'cboProvider
        '
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Location = New System.Drawing.Point(234, 102)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(158, 21)
        Me.cboProvider.TabIndex = 35
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(414, 101)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(144, 20)
        Me.txtOther.TabIndex = 36
        Me.txtOther.Visible = False
        '
        'lbltext3
        '
        Me.lbltext3.AutoSize = True
        Me.lbltext3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext3.Location = New System.Drawing.Point(12, 59)
        Me.lbltext3.Name = "lbltext3"
        Me.lbltext3.Size = New System.Drawing.Size(227, 17)
        Me.lbltext3.TabIndex = 37
        Me.lbltext3.Text = "your next renewal comes round"
        '
        'cmbExpiresDay
        '
        Me.cmbExpiresDay.FormattingEnabled = True
        Me.cmbExpiresDay.Location = New System.Drawing.Point(414, 157)
        Me.cmbExpiresDay.Name = "cmbExpiresDay"
        Me.cmbExpiresDay.Size = New System.Drawing.Size(144, 21)
        Me.cmbExpiresDay.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(232, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(411, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 14)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Day"
        '
        'frmCurrentCover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbExpiresDay)
        Me.Controls.Add(Me.lbltext3)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.cboProvider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltext2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbExpires)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCurrentCover"
        Me.Text = "frmCurrentCover"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents cmbExpires As System.Windows.Forms.ComboBox
    Friend WithEvents btnNotToHand As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lbltext2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProvider As System.Windows.Forms.ComboBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents lbltext3 As System.Windows.Forms.Label
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents cmbExpiresDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
