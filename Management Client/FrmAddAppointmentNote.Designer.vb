<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddAppointmentNote
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
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.cboTime = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(21, 12)
        Me.txtNote.MaxLength = 100
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(410, 20)
        Me.txtNote.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(102, 47)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(167, 20)
        Me.DTP.TabIndex = 5
        Me.DTP.Visible = False
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00"})
        Me.cboTime.Location = New System.Drawing.Point(290, 46)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(140, 21)
        Me.cboTime.TabIndex = 6
        Me.cboTime.Text = "9:00"
        Me.cboTime.Visible = False
        '
        'FrmAddAppointmentNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 127)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtNote)
        Me.Name = "FrmAddAppointmentNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Appointment Note"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTime As System.Windows.Forms.ComboBox
End Class
