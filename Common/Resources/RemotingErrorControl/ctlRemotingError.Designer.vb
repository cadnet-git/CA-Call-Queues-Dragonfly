<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRemotingError
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.llblRemotingErrorShowDetails = New System.Windows.Forms.LinkLabel
        Me.lblDetails = New System.Windows.Forms.Label
        Me.lblSubTitle = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picRemotingError = New System.Windows.Forms.PictureBox
        CType(Me.picRemotingError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'llblRemotingErrorShowDetails
        '
        Me.llblRemotingErrorShowDetails.AutoSize = True
        Me.llblRemotingErrorShowDetails.Location = New System.Drawing.Point(54, 35)
        Me.llblRemotingErrorShowDetails.Name = "llblRemotingErrorShowDetails"
        Me.llblRemotingErrorShowDetails.Size = New System.Drawing.Size(39, 13)
        Me.llblRemotingErrorShowDetails.TabIndex = 4
        Me.llblRemotingErrorShowDetails.TabStop = True
        Me.llblRemotingErrorShowDetails.Text = "Details"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(113, 35)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(49, 13)
        Me.lblDetails.TabIndex = 3
        Me.lblDetails.Text = "lblDetails"
        Me.lblDetails.Visible = False
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Location = New System.Drawing.Point(54, 13)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(109, 13)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "lblRemotingErrorRetry"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(54, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(175, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Unable to communicate with Server"
        '
        'picRemotingError
        '
        Me.picRemotingError.Image = Global.CADNet.CallQueues.Common.My.Resources.Resources.icon_alert
        Me.picRemotingError.Location = New System.Drawing.Point(0, 0)
        Me.picRemotingError.Name = "picRemotingError"
        Me.picRemotingError.Size = New System.Drawing.Size(48, 48)
        Me.picRemotingError.TabIndex = 0
        Me.picRemotingError.TabStop = False
        '
        'ctlRemotingError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.llblRemotingErrorShowDetails)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.picRemotingError)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ctlRemotingError"
        Me.Size = New System.Drawing.Size(249, 49)
        CType(Me.picRemotingError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llblRemotingErrorShowDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picRemotingError As System.Windows.Forms.PictureBox

End Class
