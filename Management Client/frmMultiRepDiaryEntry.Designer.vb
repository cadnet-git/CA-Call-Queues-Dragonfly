<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiRepDiaryEntry
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
        Me.BtnCreate = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvReps = New System.Windows.Forms.ListView()
        Me.Rep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbDescription = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(355, 343)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(86, 36)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(31, 343)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(86, 36)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(31, 30)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(182, 20)
        Me.dtp.TabIndex = 3
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(31, 111)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(94, 17)
        Me.cb1.TabIndex = 4
        Me.cb1.Text = "Appointment 1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(31, 135)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(94, 17)
        Me.cb2.TabIndex = 5
        Me.cb2.Text = "Appointment 2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(31, 159)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(94, 17)
        Me.cb3.TabIndex = 6
        Me.cb3.Text = "Appointment 3"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(31, 183)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(94, 17)
        Me.cb4.TabIndex = 7
        Me.cb4.Text = "Appointment 4"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Location = New System.Drawing.Point(31, 207)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(94, 17)
        Me.cb5.TabIndex = 8
        Me.cb5.Text = "Appointment 5"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Appointments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Select Reps"
        '
        'lvReps
        '
        Me.lvReps.CheckBoxes = True
        Me.lvReps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rep})
        Me.lvReps.FullRowSelect = True
        Me.lvReps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvReps.Location = New System.Drawing.Point(251, 30)
        Me.lvReps.Name = "lvReps"
        Me.lvReps.Size = New System.Drawing.Size(184, 307)
        Me.lvReps.TabIndex = 12
        Me.lvReps.UseCompatibleStateImageBehavior = False
        Me.lvReps.View = System.Windows.Forms.View.Details
        '
        'Rep
        '
        Me.Rep.Text = "Reps"
        Me.Rep.Width = 180
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Reason"
        '
        'cmbDescription
        '
        Me.cmbDescription.FormattingEnabled = True
        Me.cmbDescription.Items.AddRange(New Object() {"Holiday", "Meeting", "Not Available"})
        Me.cmbDescription.Location = New System.Drawing.Point(31, 283)
        Me.cmbDescription.Name = "cmbDescription"
        Me.cmbDescription.Size = New System.Drawing.Size(195, 21)
        Me.cmbDescription.TabIndex = 103
        '
        'frmMultiRepDiaryEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 391)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbDescription)
        Me.Controls.Add(Me.lvReps)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb5)
        Me.Controls.Add(Me.cb4)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnCreate)
        Me.Name = "frmMultiRepDiaryEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Multi Rep Diary Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvReps As System.Windows.Forms.ListView
    Friend WithEvents Rep As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDescription As System.Windows.Forms.ComboBox
End Class
