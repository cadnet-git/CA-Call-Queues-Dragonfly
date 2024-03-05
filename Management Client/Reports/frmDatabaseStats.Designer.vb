<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseStats
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblwastagePercent = New System.Windows.Forms.Label
        Me.lblprojected = New System.Windows.Forms.Label
        Me.lblCalled = New System.Windows.Forms.Label
        Me.lbldead = New System.Windows.Forms.Label
        Me.lblLive = New System.Windows.Forms.Label
        Me.lblRecords = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Records"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Live"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dead"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Called"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Projected Useable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Wastage"
        '
        'lblwastagePercent
        '
        Me.lblwastagePercent.Location = New System.Drawing.Point(164, 122)
        Me.lblwastagePercent.Name = "lblwastagePercent"
        Me.lblwastagePercent.Size = New System.Drawing.Size(50, 18)
        Me.lblwastagePercent.TabIndex = 11
        Me.lblwastagePercent.Text = "Wastage"
        Me.lblwastagePercent.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblprojected
        '
        Me.lblprojected.Location = New System.Drawing.Point(164, 146)
        Me.lblprojected.Name = "lblprojected"
        Me.lblprojected.Size = New System.Drawing.Size(50, 18)
        Me.lblprojected.TabIndex = 10
        Me.lblprojected.Text = "Projected"
        Me.lblprojected.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCalled
        '
        Me.lblCalled.Location = New System.Drawing.Point(164, 50)
        Me.lblCalled.Name = "lblCalled"
        Me.lblCalled.Size = New System.Drawing.Size(50, 18)
        Me.lblCalled.TabIndex = 9
        Me.lblCalled.Text = "Called"
        Me.lblCalled.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbldead
        '
        Me.lbldead.Location = New System.Drawing.Point(164, 98)
        Me.lbldead.Name = "lbldead"
        Me.lbldead.Size = New System.Drawing.Size(50, 18)
        Me.lbldead.TabIndex = 8
        Me.lbldead.Text = "Dead"
        Me.lbldead.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLive
        '
        Me.lblLive.Location = New System.Drawing.Point(164, 74)
        Me.lblLive.Name = "lblLive"
        Me.lblLive.Size = New System.Drawing.Size(50, 18)
        Me.lblLive.TabIndex = 7
        Me.lblLive.Text = "Live"
        Me.lblLive.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRecords
        '
        Me.lblRecords.Location = New System.Drawing.Point(164, 26)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(50, 18)
        Me.lblRecords.TabIndex = 6
        Me.lblRecords.Text = "Records"
        Me.lblRecords.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 31)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDatabaseStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 224)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblwastagePercent)
        Me.Controls.Add(Me.lblprojected)
        Me.Controls.Add(Me.lblCalled)
        Me.Controls.Add(Me.lbldead)
        Me.Controls.Add(Me.lblLive)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDatabaseStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDatabaseStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblwastagePercent As System.Windows.Forms.Label
    Friend WithEvents lblprojected As System.Windows.Forms.Label
    Friend WithEvents lblCalled As System.Windows.Forms.Label
    Friend WithEvents lbldead As System.Windows.Forms.Label
    Friend WithEvents lblLive As System.Windows.Forms.Label
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
