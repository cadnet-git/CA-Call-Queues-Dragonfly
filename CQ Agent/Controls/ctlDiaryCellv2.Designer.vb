<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDiaryCellv2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTown = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTown
        '
        Me.lblTown.BackColor = System.Drawing.Color.Transparent
        Me.lblTown.Location = New System.Drawing.Point(1, 3)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(190, 23)
        Me.lblTown.TabIndex = 0
        Me.lblTown.Text = "Town"
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Location = New System.Drawing.Point(1, 30)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(190, 23)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.Color.Transparent
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(1, 55)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(190, 23)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Area"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctlDiaryCellv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTown)
        Me.Name = "ctlDiaryCellv2"
        Me.Size = New System.Drawing.Size(193, 78)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label

End Class
