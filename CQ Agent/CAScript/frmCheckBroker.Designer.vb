<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckBroker
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
        Me.lblWords = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnDirect = New System.Windows.Forms.Button
        Me.btnBroker = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnBack = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(21, 36)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(401, 17)
        Me.lblWords.TabIndex = 35
        Me.lblWords.Text = "Can you tell me if you arranged your cover with a broker "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "or with an agent direct?"
        '
        'BtnDirect
        '
        Me.BtnDirect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDirect.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDirect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDirect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDirect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDirect.ForeColor = System.Drawing.Color.Black
        Me.BtnDirect.Location = New System.Drawing.Point(197, 120)
        Me.BtnDirect.Name = "BtnDirect"
        Me.BtnDirect.Size = New System.Drawing.Size(161, 27)
        Me.BtnDirect.TabIndex = 41
        Me.BtnDirect.Text = "Agent Direct"
        Me.BtnDirect.UseVisualStyleBackColor = False
        '
        'btnBroker
        '
        Me.btnBroker.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBroker.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBroker.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBroker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBroker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBroker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBroker.ForeColor = System.Drawing.Color.Black
        Me.btnBroker.Location = New System.Drawing.Point(378, 120)
        Me.btnBroker.Name = "btnBroker"
        Me.btnBroker.Size = New System.Drawing.Size(161, 27)
        Me.btnBroker.TabIndex = 42
        Me.btnBroker.Text = "Broker"
        Me.btnBroker.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Location = New System.Drawing.Point(563, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 221)
        Me.Panel1.TabIndex = 43
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(3, 7)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(138, 38)
        Me.BtnBack.TabIndex = 29
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'frmCheckBroker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 296)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBroker)
        Me.Controls.Add(Me.BtnDirect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCheckBroker"
        Me.ShowInTaskbar = False
        Me.Text = "frmCheckBroker"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWords As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDirect As System.Windows.Forms.Button
    Friend WithEvents btnBroker As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBack As System.Windows.Forms.Button
End Class
