<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRedirectedContactInfo
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnOutofArea = New System.Windows.Forms.Button
        Me.btnNotInterested = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnYes = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.txtPosition = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Surname"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Forename"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss"})
        Me.cmbTitle.Location = New System.Drawing.Point(335, 31)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(59, 21)
        Me.cmbTitle.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Who is it I need to speak too?"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(335, 84)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(180, 20)
        Me.txtSurname.TabIndex = 23
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(335, 58)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(180, 20)
        Me.txtForename.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "What is their position within the company?"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnOutofArea)
        Me.Panel1.Controls.Add(Me.btnNotInterested)
        Me.Panel1.Location = New System.Drawing.Point(576, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 251)
        Me.Panel1.TabIndex = 28
        '
        'btnOutofArea
        '
        Me.btnOutofArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutofArea.Location = New System.Drawing.Point(3, 54)
        Me.btnOutofArea.Name = "btnOutofArea"
        Me.btnOutofArea.Size = New System.Drawing.Size(141, 38)
        Me.btnOutofArea.TabIndex = 14
        Me.btnOutofArea.Text = "Out of Area"
        Me.btnOutofArea.UseVisualStyleBackColor = True
        '
        'btnNotInterested
        '
        Me.btnNotInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotInterested.Location = New System.Drawing.Point(3, 8)
        Me.btnNotInterested.Name = "btnNotInterested"
        Me.btnNotInterested.Size = New System.Drawing.Size(141, 38)
        Me.btnNotInterested.TabIndex = 0
        Me.btnNotInterested.Text = "Not Interested"
        Me.btnNotInterested.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Can you transfer me to them?"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Black
        Me.btnYes.Location = New System.Drawing.Point(335, 170)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(52, 27)
        Me.btnYes.TabIndex = 35
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
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
        Me.btnNo.Location = New System.Drawing.Point(393, 170)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(53, 27)
        Me.btnNo.TabIndex = 34
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'txtPosition
        '
        Me.txtPosition.Items.AddRange(New Object() {"Accounts Manager", "Commercial Director", "Company Accountant", "Company Director", "Company Secretary ", "Director", "Finance Director", "Finance Manager", "Finance Officer", "Financial Controller", "HR Director", "HR Manager", "HR Officer", "Managing Director", "Office Manager", "Owner", "Partner", "Practice Manager", "Proprietor"})
        Me.txtPosition.Location = New System.Drawing.Point(335, 127)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(180, 21)
        Me.txtPosition.TabIndex = 110
        '
        'frmRedirectedContactInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRedirectedContactInfo"
        Me.Text = "frmRedirectedContactInfo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNotInterested As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnOutofArea As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.ComboBox
End Class
