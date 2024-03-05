<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualDial
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
        Me.btnTPS = New System.Windows.Forms.Button
        Me.lblNumberToDial = New System.Windows.Forms.Label
        Me.btnNotRecognised = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblGreet = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnConnected = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTPS
        '
        Me.btnTPS.Location = New System.Drawing.Point(13, 14)
        Me.btnTPS.Name = "btnTPS"
        Me.btnTPS.Size = New System.Drawing.Size(119, 38)
        Me.btnTPS.TabIndex = 11
        Me.btnTPS.Text = "TPS"
        Me.btnTPS.UseVisualStyleBackColor = True
        Me.btnTPS.Visible = False
        '
        'lblNumberToDial
        '
        Me.lblNumberToDial.AutoSize = True
        Me.lblNumberToDial.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberToDial.Location = New System.Drawing.Point(198, 113)
        Me.lblNumberToDial.Name = "lblNumberToDial"
        Me.lblNumberToDial.Size = New System.Drawing.Size(169, 23)
        Me.lblNumberToDial.TabIndex = 35
        Me.lblNumberToDial.Text = "XX-XXXX-XXXXX"
        '
        'btnNotRecognised
        '
        Me.btnNotRecognised.Location = New System.Drawing.Point(13, 71)
        Me.btnNotRecognised.Name = "btnNotRecognised"
        Me.btnNotRecognised.Size = New System.Drawing.Size(119, 38)
        Me.btnNotRecognised.TabIndex = 12
        Me.btnNotRecognised.Text = "Not Recognized"
        Me.btnNotRecognised.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(27, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Please dial the following number:"
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreet.Location = New System.Drawing.Point(27, 26)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(199, 17)
        Me.lblGreet.TabIndex = 33
        Me.lblGreet.Text = "Sorry, but cannot auto-dial."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnTPS)
        Me.Panel1.Controls.Add(Me.btnNotRecognised)
        Me.Panel1.Location = New System.Drawing.Point(586, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 271)
        Me.Panel1.TabIndex = 32
        '
        'btnConnected
        '
        Me.btnConnected.Location = New System.Drawing.Point(227, 160)
        Me.btnConnected.Name = "btnConnected"
        Me.btnConnected.Size = New System.Drawing.Size(119, 38)
        Me.btnConnected.TabIndex = 31
        Me.btnConnected.Text = "Connected"
        Me.btnConnected.UseVisualStyleBackColor = True
        '
        'frmManualDial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 275)
        Me.Controls.Add(Me.lblNumberToDial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConnected)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManualDial"
        Me.Text = "frmManualDial"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTPS As System.Windows.Forms.Button
    Friend WithEvents lblNumberToDial As System.Windows.Forms.Label
    Friend WithEvents btnNotRecognised As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGreet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConnected As System.Windows.Forms.Button
End Class
