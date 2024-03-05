<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocuments
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
        Me.LVDocuments = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddedOn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Who = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Document = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVDocuments
        '
        Me.LVDocuments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.AddedOn, Me.Who, Me.Title, Me.Document})
        Me.LVDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVDocuments.FullRowSelect = True
        Me.LVDocuments.GridLines = True
        Me.LVDocuments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVDocuments.HideSelection = False
        Me.LVDocuments.Location = New System.Drawing.Point(0, 24)
        Me.LVDocuments.Name = "LVDocuments"
        Me.LVDocuments.Size = New System.Drawing.Size(808, 371)
        Me.LVDocuments.TabIndex = 50
        Me.LVDocuments.UseCompatibleStateImageBehavior = False
        Me.LVDocuments.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'AddedOn
        '
        Me.AddedOn.Text = "Date"
        Me.AddedOn.Width = 121
        '
        'Who
        '
        Me.Who.Text = "Added By"
        Me.Who.Width = 115
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 331
        '
        'Document
        '
        Me.Document.Text = "Document"
        Me.Document.Width = 217
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddFileToolStripMenuItem
        '
        Me.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem"
        Me.AddFileToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AddFileToolStripMenuItem.Text = "Add File"
        '
        'frmDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 395)
        Me.Controls.Add(Me.LVDocuments)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmDocuments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company Documents"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVDocuments As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddedOn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Who As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Document As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
