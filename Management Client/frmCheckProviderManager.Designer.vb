<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckProviderManager
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
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.cmbExpires = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnOK = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbExpiresDay = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(22, 126)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(65, 20)
        Me.txtOther.TabIndex = 39
        Me.txtOther.Visible = False
        '
        'cboProvider
        '
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Location = New System.Drawing.Point(64, 12)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(254, 21)
        Me.cboProvider.TabIndex = 38
        '
        'cmbExpires
        '
        Me.cmbExpires.FormattingEnabled = True
        Me.cmbExpires.Location = New System.Drawing.Point(64, 63)
        Me.cmbExpires.Name = "cmbExpires"
        Me.cmbExpires.Size = New System.Drawing.Size(138, 21)
        Me.cmbExpires.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Cover"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Expires"
        '
        'BtnOK
        '
        Me.BtnOK.Enabled = False
        Me.BtnOK.Location = New System.Drawing.Point(239, 110)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 36)
        Me.BtnOK.TabIndex = 42
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(158, 110)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 36)
        Me.BtnCancel.TabIndex = 43
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Day"
        '
        'cmbExpiresDay
        '
        Me.cmbExpiresDay.FormattingEnabled = True
        Me.cmbExpiresDay.Location = New System.Drawing.Point(208, 63)
        Me.cmbExpiresDay.Name = "cmbExpiresDay"
        Me.cmbExpiresDay.Size = New System.Drawing.Size(91, 21)
        Me.cmbExpiresDay.TabIndex = 45
        '
        'frmCheckProviderManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 171)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbExpiresDay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.cboProvider)
        Me.Controls.Add(Me.cmbExpires)
        Me.Name = "frmCheckProviderManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Cover and Renewal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents cboProvider As System.Windows.Forms.ComboBox
    Friend WithEvents cmbExpires As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbExpiresDay As System.Windows.Forms.ComboBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
