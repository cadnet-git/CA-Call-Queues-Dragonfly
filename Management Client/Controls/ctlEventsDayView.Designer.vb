<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlEventsDayView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LVEvents = New System.Windows.Forms.ListView
        Me.eEvents = New System.Windows.Forms.ColumnHeader
        Me.Time = New System.Windows.Forms.ColumnHeader
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblExceeded = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LVEvents
        '
        Me.LVEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.eEvents, Me.Time})
        Me.LVEvents.GridLines = True
        Me.LVEvents.Location = New System.Drawing.Point(2, 22)
        Me.LVEvents.Name = "LVEvents"
        Me.LVEvents.Size = New System.Drawing.Size(194, 545)
        Me.LVEvents.TabIndex = 1
        Me.LVEvents.UseCompatibleStateImageBehavior = False
        Me.LVEvents.View = System.Windows.Forms.View.Details
        '
        'eEvents
        '
        Me.eEvents.Text = "Event"
        Me.eEvents.Width = 125
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 64
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(2, 2)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(194, 22)
        Me.lblDate.TabIndex = 0
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 577)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time Exceeded"
        '
        'lblExceeded
        '
        Me.lblExceeded.Location = New System.Drawing.Point(111, 578)
        Me.lblExceeded.Name = "lblExceeded"
        Me.lblExceeded.Size = New System.Drawing.Size(49, 13)
        Me.lblExceeded.TabIndex = 3
        Me.lblExceeded.Text = "0"
        Me.lblExceeded.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctlEventsDayView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblExceeded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.LVEvents)
        Me.Name = "ctlEventsDayView"
        Me.Size = New System.Drawing.Size(198, 603)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVEvents As System.Windows.Forms.ListView
    Friend WithEvents eEvents As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblExceeded As System.Windows.Forms.Label

End Class
