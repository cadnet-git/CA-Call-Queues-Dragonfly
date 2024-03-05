<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectUser
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
        Me.lvAll = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.User = New System.Windows.Forms.ColumnHeader
        Me.btnOK = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvAll
        '
        Me.lvAll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.User})
        Me.lvAll.FullRowSelect = True
        Me.lvAll.GridLines = True
        Me.lvAll.Location = New System.Drawing.Point(12, 12)
        Me.lvAll.MultiSelect = False
        Me.lvAll.Name = "lvAll"
        Me.lvAll.Size = New System.Drawing.Size(219, 320)
        Me.lvAll.TabIndex = 1
        Me.lvAll.UseCompatibleStateImageBehavior = False
        Me.lvAll.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'User
        '
        Me.User.Text = "Available"
        Me.User.Width = 160
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 339)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 37)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(12, 338)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(70, 37)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmSelectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 387)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lvAll)
        Me.Name = "frmSelectUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select User"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvAll As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents User As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
