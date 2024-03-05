<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentActivity
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
        Me.btnPrev = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.Day4 = New CADNet.CallQueues.ManagerConsole.ctlEventsDayView
        Me.Day3 = New CADNet.CallQueues.ManagerConsole.ctlEventsDayView
        Me.Day2 = New CADNet.CallQueues.ManagerConsole.ctlEventsDayView
        Me.Day1 = New CADNet.CallQueues.ManagerConsole.ctlEventsDayView
        Me.Day0 = New CADNet.CallQueues.ManagerConsole.ctlEventsDayView
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbSelectRep = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrev.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.Location = New System.Drawing.Point(4, 30)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(25, 603)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(1019, 30)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(25, 603)
        Me.BtnNext.TabIndex = 8
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Day4
        '
        Me.Day4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Day4.Location = New System.Drawing.Point(821, 30)
        Me.Day4.Name = "Day4"
        Me.Day4.Size = New System.Drawing.Size(198, 603)
        Me.Day4.TabIndex = 7
        '
        'Day3
        '
        Me.Day3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Day3.Location = New System.Drawing.Point(623, 30)
        Me.Day3.Name = "Day3"
        Me.Day3.Size = New System.Drawing.Size(198, 603)
        Me.Day3.TabIndex = 6
        '
        'Day2
        '
        Me.Day2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Day2.Location = New System.Drawing.Point(425, 30)
        Me.Day2.Name = "Day2"
        Me.Day2.Size = New System.Drawing.Size(198, 603)
        Me.Day2.TabIndex = 5
        '
        'Day1
        '
        Me.Day1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Day1.Location = New System.Drawing.Point(227, 30)
        Me.Day1.Name = "Day1"
        Me.Day1.Size = New System.Drawing.Size(198, 603)
        Me.Day1.TabIndex = 4
        '
        'Day0
        '
        Me.Day0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Day0.Location = New System.Drawing.Point(29, 30)
        Me.Day0.Name = "Day0"
        Me.Day0.Size = New System.Drawing.Size(198, 603)
        Me.Day0.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Select Agent"
        '
        'cmbSelectRep
        '
        Me.cmbSelectRep.FormattingEnabled = True
        Me.cmbSelectRep.Location = New System.Drawing.Point(116, 3)
        Me.cmbSelectRep.Name = "cmbSelectRep"
        Me.cmbSelectRep.Size = New System.Drawing.Size(184, 21)
        Me.cmbSelectRep.TabIndex = 1
        '
        'frmAgnetActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 645)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSelectRep)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.Day4)
        Me.Controls.Add(Me.Day3)
        Me.Controls.Add(Me.Day2)
        Me.Controls.Add(Me.Day1)
        Me.Controls.Add(Me.Day0)
        Me.Name = "frmAgnetActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgnetActivity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Day0 As CADNet.CallQueues.ManagerConsole.ctlEventsDayView
    Friend WithEvents Day1 As CADNet.CallQueues.ManagerConsole.ctlEventsDayView
    Friend WithEvents Day3 As CADNet.CallQueues.ManagerConsole.ctlEventsDayView
    Friend WithEvents Day2 As CADNet.CallQueues.ManagerConsole.ctlEventsDayView
    Friend WithEvents Day4 As CADNet.CallQueues.ManagerConsole.ctlEventsDayView
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectRep As System.Windows.Forms.ComboBox
End Class
