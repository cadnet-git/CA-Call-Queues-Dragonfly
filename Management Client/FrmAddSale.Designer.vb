<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddSale
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTSale = New System.Windows.Forms.DateTimePicker()
        Me.DTPolicy = New System.Windows.Forms.DateTimePicker()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(176, 210)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 36)
        Me.BtnCancel.TabIndex = 45
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(257, 210)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 36)
        Me.BtnOK.TabIndex = 44
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Policy Starts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Sales Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Value"
        '
        'DTSale
        '
        Me.DTSale.Location = New System.Drawing.Point(106, 64)
        Me.DTSale.Name = "DTSale"
        Me.DTSale.Size = New System.Drawing.Size(200, 20)
        Me.DTSale.TabIndex = 50
        '
        'DTPolicy
        '
        Me.DTPolicy.Location = New System.Drawing.Point(106, 94)
        Me.DTPolicy.Name = "DTPolicy"
        Me.DTPolicy.Size = New System.Drawing.Size(200, 20)
        Me.DTPolicy.TabIndex = 51
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Commercial", "Private"})
        Me.cboType.Location = New System.Drawing.Point(106, 154)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(200, 21)
        Me.cboType.TabIndex = 52
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(106, 124)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(200, 20)
        Me.txtValue.TabIndex = 53
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboProvider
        '
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Items.AddRange(New Object() {"Aviva", "AXA Health", "BUPA", "Cigna", "Freedom", "Vitality ", "Individual & SME – BUPA Cash Plan", "Birmingham Hospital Saturday Fund (BHSF)", "HealthShield"})
        Me.cboProvider.Location = New System.Drawing.Point(106, 32)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(200, 21)
        Me.cboProvider.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Provider"
        '
        'FrmAddSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 258)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboProvider)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.DTPolicy)
        Me.Controls.Add(Me.DTSale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "FrmAddSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPolicy As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents cboProvider As ComboBox
    Friend WithEvents Label5 As Label
End Class
