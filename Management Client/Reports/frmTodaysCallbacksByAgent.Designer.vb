<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodaysCallbacksByAgent
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
        Me.lvCallbacks = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Company = New System.Windows.Forms.ColumnHeader
        Me.Salutation = New System.Windows.Forms.ColumnHeader
        Me.surname = New System.Windows.Forms.ColumnHeader
        Me.title = New System.Windows.Forms.ColumnHeader
        Me.Provider = New System.Windows.Forms.ColumnHeader
        Me.Expires = New System.Windows.Forms.ColumnHeader
        Me.lblAgent = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lvCallbacks
        '
        Me.lvCallbacks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Company, Me.Salutation, Me.surname, Me.title, Me.Provider, Me.Expires})
        Me.lvCallbacks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvCallbacks.FullRowSelect = True
        Me.lvCallbacks.GridLines = True
        Me.lvCallbacks.Location = New System.Drawing.Point(0, 42)
        Me.lvCallbacks.Name = "lvCallbacks"
        Me.lvCallbacks.Size = New System.Drawing.Size(819, 462)
        Me.lvCallbacks.TabIndex = 14
        Me.lvCallbacks.UseCompatibleStateImageBehavior = False
        Me.lvCallbacks.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'Company
        '
        Me.Company.Text = "Company"
        Me.Company.Width = 222
        '
        'Salutation
        '
        Me.Salutation.Text = "Salutation"
        Me.Salutation.Width = 62
        '
        'surname
        '
        Me.surname.Text = "Surname"
        Me.surname.Width = 136
        '
        'title
        '
        Me.title.Text = "Job Title"
        Me.title.Width = 122
        '
        'Provider
        '
        Me.Provider.Text = "Provider"
        Me.Provider.Width = 126
        '
        'Expires
        '
        Me.Expires.Text = "Expires"
        Me.Expires.Width = 124
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgent.Location = New System.Drawing.Point(12, 9)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(124, 24)
        Me.lblAgent.TabIndex = 15
        Me.lblAgent.Text = "Fred Bloggs"
        '
        'frmTodaysCallbacksByAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 504)
        Me.Controls.Add(Me.lblAgent)
        Me.Controls.Add(Me.lvCallbacks)
        Me.Name = "frmTodaysCallbacksByAgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Callbacks By Agent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvCallbacks As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Company As System.Windows.Forms.ColumnHeader
    Friend WithEvents Salutation As System.Windows.Forms.ColumnHeader
    Friend WithEvents surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Provider As System.Windows.Forms.ColumnHeader
    Friend WithEvents Expires As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAgent As System.Windows.Forms.Label
End Class
