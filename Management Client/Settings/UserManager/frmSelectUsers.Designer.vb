<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectUsers
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lvSelected = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnColdPot = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvAll
        '
        Me.lvAll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.User})
        Me.lvAll.FullRowSelect = True
        Me.lvAll.GridLines = True
        Me.lvAll.Location = New System.Drawing.Point(12, 23)
        Me.lvAll.Name = "lvAll"
        Me.lvAll.Size = New System.Drawing.Size(165, 198)
        Me.lvAll.TabIndex = 0
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lvSelected
        '
        Me.lvSelected.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvSelected.FullRowSelect = True
        Me.lvSelected.GridLines = True
        Me.lvSelected.Location = New System.Drawing.Point(233, 23)
        Me.lvSelected.Name = "lvSelected"
        Me.lvSelected.Size = New System.Drawing.Size(165, 198)
        Me.lvSelected.TabIndex = 4
        Me.lvSelected.UseCompatibleStateImageBehavior = False
        Me.lvSelected.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Selected"
        Me.ColumnHeader2.Width = 160
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 37)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(271, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 37)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "OK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnColdPot
        '
        Me.btnColdPot.Location = New System.Drawing.Point(152, 238)
        Me.btnColdPot.Name = "btnColdPot"
        Me.btnColdPot.Size = New System.Drawing.Size(102, 37)
        Me.btnColdPot.TabIndex = 7
        Me.btnColdPot.Text = "Cold Pot"
        Me.btnColdPot.UseVisualStyleBackColor = True
        Me.btnColdPot.Visible = False
        '
        'frmSelectUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 286)
        Me.Controls.Add(Me.btnColdPot)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lvSelected)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvAll)
        Me.Name = "frmSelectUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Agent"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvAll As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents User As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lvSelected As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnColdPot As System.Windows.Forms.Button
End Class
