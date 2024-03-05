<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewData
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.lblcold = New System.Windows.Forms.Label
        Me.lblcallbacks = New System.Windows.Forms.Label
        Me.lblnew = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblrecs = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnBrowse = New System.Windows.Forms.Button
        Me.lblFiles = New System.Windows.Forms.Label
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "import data"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apps and Callbacks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ColdCalls"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(201, 140)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblcold
        '
        Me.lblcold.AutoSize = True
        Me.lblcold.Location = New System.Drawing.Point(201, 118)
        Me.lblcold.Name = "lblcold"
        Me.lblcold.Size = New System.Drawing.Size(13, 13)
        Me.lblcold.TabIndex = 7
        Me.lblcold.Text = "0"
        Me.lblcold.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblcallbacks
        '
        Me.lblcallbacks.AutoSize = True
        Me.lblcallbacks.Location = New System.Drawing.Point(201, 97)
        Me.lblcallbacks.Name = "lblcallbacks"
        Me.lblcallbacks.Size = New System.Drawing.Size(13, 13)
        Me.lblcallbacks.TabIndex = 6
        Me.lblcallbacks.Text = "0"
        Me.lblcallbacks.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.Location = New System.Drawing.Point(201, 74)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(13, 13)
        Me.lblnew.TabIndex = 5
        Me.lblnew.Text = "0"
        Me.lblnew.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(201, 181)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(13, 13)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Time Left"
        '
        'lblrecs
        '
        Me.lblrecs.AutoSize = True
        Me.lblrecs.Location = New System.Drawing.Point(201, 162)
        Me.lblrecs.Name = "lblrecs"
        Me.lblrecs.Size = New System.Drawing.Size(13, 13)
        Me.lblrecs.TabIndex = 13
        Me.lblrecs.Text = "0"
        Me.lblrecs.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblrecs.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Records in File"
        Me.Label7.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(257, 39)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 14
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'lblFiles
        '
        Me.lblFiles.BackColor = System.Drawing.Color.White
        Me.lblFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiles.Location = New System.Drawing.Point(10, 13)
        Me.lblFiles.Name = "lblFiles"
        Me.lblFiles.Size = New System.Drawing.Size(322, 22)
        Me.lblFiles.TabIndex = 15
        Me.lblFiles.Text = "Pick File"
        Me.lblFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv.Location = New System.Drawing.Point(10, 266)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(322, 384)
        Me.lv.TabIndex = 16
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "118ID"
        Me.ColumnHeader1.Width = 159
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Postcode"
        Me.ColumnHeader2.Width = 133
        '
        'frmNewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 662)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.lblFiles)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.lblrecs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblcold)
        Me.Controls.Add(Me.lblcallbacks)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmNewData"
        Me.Text = "frmNewData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblcold As System.Windows.Forms.Label
    Friend WithEvents lblcallbacks As System.Windows.Forms.Label
    Friend WithEvents lblnew As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblrecs As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFiles As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
