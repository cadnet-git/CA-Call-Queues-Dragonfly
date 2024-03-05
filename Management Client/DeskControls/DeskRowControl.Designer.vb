<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeskRowControl
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
        Me.lblAgentName = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.lblCallingNumber = New System.Windows.Forms.Label
        Me.lblCallStatus = New System.Windows.Forms.Label
        Me.lblDeskName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblAgentName
        '
        Me.lblAgentName.AutoSize = True
        Me.lblAgentName.Location = New System.Drawing.Point(122, 5)
        Me.lblAgentName.Name = "lblAgentName"
        Me.lblAgentName.Size = New System.Drawing.Size(73, 13)
        Me.lblAgentName.TabIndex = 12
        Me.lblAgentName.Text = "lblAgentName"
        Me.lblAgentName.Visible = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(217, 5)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(39, 13)
        Me.lblArea.TabIndex = 11
        Me.lblArea.Text = "lblArea"
        Me.lblArea.Visible = False
        '
        'lblCallingNumber
        '
        Me.lblCallingNumber.AutoSize = True
        Me.lblCallingNumber.Location = New System.Drawing.Point(416, 5)
        Me.lblCallingNumber.Name = "lblCallingNumber"
        Me.lblCallingNumber.Size = New System.Drawing.Size(85, 13)
        Me.lblCallingNumber.TabIndex = 10
        Me.lblCallingNumber.Text = "lblCallingNumber"
        Me.lblCallingNumber.Visible = False
        '
        'lblCallStatus
        '
        Me.lblCallStatus.AutoSize = True
        Me.lblCallStatus.Location = New System.Drawing.Point(345, 5)
        Me.lblCallStatus.Name = "lblCallStatus"
        Me.lblCallStatus.Size = New System.Drawing.Size(64, 13)
        Me.lblCallStatus.TabIndex = 9
        Me.lblCallStatus.Text = "lblCallStatus"
        Me.lblCallStatus.Visible = False
        '
        'lblDeskName
        '
        Me.lblDeskName.AutoSize = True
        Me.lblDeskName.Location = New System.Drawing.Point(8, 5)
        Me.lblDeskName.Name = "lblDeskName"
        Me.lblDeskName.Size = New System.Drawing.Size(70, 13)
        Me.lblDeskName.TabIndex = 8
        Me.lblDeskName.Text = "lblDeskName"
        '
        'DeskRowControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAgentName)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblCallingNumber)
        Me.Controls.Add(Me.lblCallStatus)
        Me.Controls.Add(Me.lblDeskName)
        Me.Name = "DeskRowControl"
        Me.Size = New System.Drawing.Size(622, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAgentName As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblCallingNumber As System.Windows.Forms.Label
    Friend WithEvents lblCallStatus As System.Windows.Forms.Label
    Friend WithEvents lblDeskName As System.Windows.Forms.Label

End Class
