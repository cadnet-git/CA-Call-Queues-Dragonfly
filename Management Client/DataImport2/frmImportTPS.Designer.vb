<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportTPS
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
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTPSExistingRelationship = New System.Windows.Forms.Label
        Me.lblTPS = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblrecs = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblOKExistingRelationship = New System.Windows.Forms.Label
        Me.lblOk = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ReportDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.ReportDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(202, 62)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 24
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(15, 35)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(262, 21)
        Me.txtFilename.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "TPS File To Import"
        '
        'lblTPSExistingRelationship
        '
        Me.lblTPSExistingRelationship.AutoSize = True
        Me.lblTPSExistingRelationship.Location = New System.Drawing.Point(212, 222)
        Me.lblTPSExistingRelationship.Name = "lblTPSExistingRelationship"
        Me.lblTPSExistingRelationship.Size = New System.Drawing.Size(13, 13)
        Me.lblTPSExistingRelationship.TabIndex = 21
        Me.lblTPSExistingRelationship.Text = "0"
        Me.lblTPSExistingRelationship.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTPS
        '
        Me.lblTPS.AutoSize = True
        Me.lblTPS.Location = New System.Drawing.Point(212, 189)
        Me.lblTPS.Name = "lblTPS"
        Me.lblTPS.Size = New System.Drawing.Size(13, 13)
        Me.lblTPS.TabIndex = 20
        Me.lblTPS.Text = "0"
        Me.lblTPS.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TPS Existing Relationship "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TPS"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(89, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Import TPS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblrecs
        '
        Me.lblrecs.AutoSize = True
        Me.lblrecs.Location = New System.Drawing.Point(213, 353)
        Me.lblrecs.Name = "lblrecs"
        Me.lblrecs.Size = New System.Drawing.Size(13, 13)
        Me.lblrecs.TabIndex = 30
        Me.lblrecs.Text = "0"
        Me.lblrecs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Records in File"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(213, 382)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(13, 13)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Time Left"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(213, 321)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 26
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Total"
        '
        'lblOKExistingRelationship
        '
        Me.lblOKExistingRelationship.AutoSize = True
        Me.lblOKExistingRelationship.Location = New System.Drawing.Point(212, 285)
        Me.lblOKExistingRelationship.Name = "lblOKExistingRelationship"
        Me.lblOKExistingRelationship.Size = New System.Drawing.Size(13, 13)
        Me.lblOKExistingRelationship.TabIndex = 34
        Me.lblOKExistingRelationship.Text = "0"
        Me.lblOKExistingRelationship.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.Location = New System.Drawing.Point(212, 252)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(13, 13)
        Me.lblOk.TabIndex = 33
        Me.lblOk.Text = "0"
        Me.lblOk.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Ok Existing Relationship "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(135, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Ok"
        '
        'ReportDate
        '
        Me.ReportDate.EditValue = Nothing
        Me.ReportDate.Location = New System.Drawing.Point(15, 107)
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportDate.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.ReportDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ReportDate.Properties.Mask.EditMask = "D"
        Me.ReportDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ReportDate.Size = New System.Drawing.Size(262, 20)
        Me.ReportDate.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Set TPS File Date"
        '
        'frmImportTPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 540)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReportDate)
        Me.Controls.Add(Me.lblOKExistingRelationship)
        Me.Controls.Add(Me.lblOk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblrecs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTPSExistingRelationship)
        Me.Controls.Add(Me.lblTPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmImportTPS"
        Me.Text = "frmImportTPS"
        CType(Me.ReportDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTPSExistingRelationship As System.Windows.Forms.Label
    Friend WithEvents lblTPS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblrecs As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOKExistingRelationship As System.Windows.Forms.Label
    Friend WithEvents lblOk As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ReportDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
