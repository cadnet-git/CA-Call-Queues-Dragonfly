<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckNotinterested
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.cbCallBack = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Put back in Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(339, 64)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(176, 39)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'cbCallBack
        '
        Me.cbCallBack.FormattingEnabled = True
        Me.cbCallBack.Items.AddRange(New Object() {"4 Months", "8 Months", "12 Months", "18 Months", "24 Months"})
        Me.cbCallBack.Location = New System.Drawing.Point(94, 29)
        Me.cbCallBack.Name = "cbCallBack"
        Me.cbCallBack.Size = New System.Drawing.Size(421, 21)
        Me.cbCallBack.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Call Back in"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(94, 6)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(421, 20)
        Me.txtReason.TabIndex = 7
        '
        'frmCheckNotinterested
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 115)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCallBack)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "frmCheckNotinterested"
        Me.Text = "Check Not Interested"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents cbCallBack As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
End Class
