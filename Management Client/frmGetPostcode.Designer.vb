<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetPostcode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblError = New System.Windows.Forms.Label
        Me.ResultsList = New System.Windows.Forms.ListBox
        Me.BtnEditAddress = New System.Windows.Forms.Button
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(12, 301)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(654, 21)
        Me.lblError.TabIndex = 1
        Me.lblError.Text = "Label1"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResultsList
        '
        Me.ResultsList.FormattingEnabled = True
        Me.ResultsList.Location = New System.Drawing.Point(12, 10)
        Me.ResultsList.Name = "ResultsList"
        Me.ResultsList.Size = New System.Drawing.Size(654, 290)
        Me.ResultsList.TabIndex = 2
        '
        'BtnEditAddress
        '
        Me.BtnEditAddress.Location = New System.Drawing.Point(15, 325)
        Me.BtnEditAddress.Name = "BtnEditAddress"
        Me.BtnEditAddress.Size = New System.Drawing.Size(127, 33)
        Me.BtnEditAddress.TabIndex = 3
        Me.BtnEditAddress.Text = "Edit Address"
        Me.BtnEditAddress.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(539, 325)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(127, 33)
        Me.BtnSelect.TabIndex = 4
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(406, 325)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 33)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'frmGetPostcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 370)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnEditAddress)
        Me.Controls.Add(Me.ResultsList)
        Me.Controls.Add(Me.lblError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGetPostcode"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Address"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents ResultsList As System.Windows.Forms.ListBox
    Friend WithEvents BtnEditAddress As System.Windows.Forms.Button
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
