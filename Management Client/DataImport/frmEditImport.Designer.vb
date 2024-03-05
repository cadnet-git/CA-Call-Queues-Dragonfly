<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditImport))
        Me.btnStop = New System.Windows.Forms.Button
        Me.chkCreatePostcode = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTelephone = New System.Windows.Forms.Label
        Me.lblEditTitle = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.lblPostcode = New System.Windows.Forms.Label
        Me.lblTitle2 = New System.Windows.Forms.Label
        Me.lblTitle1 = New System.Windows.Forms.Label
        Me.btnRetry = New System.Windows.Forms.Button
        Me.btnSkip = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(8, 253)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 35
        Me.btnStop.Text = "Stop Import"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'chkCreatePostcode
        '
        Me.chkCreatePostcode.AutoSize = True
        Me.chkCreatePostcode.Enabled = False
        Me.chkCreatePostcode.Location = New System.Drawing.Point(94, 228)
        Me.chkCreatePostcode.Name = "chkCreatePostcode"
        Me.chkCreatePostcode.Size = New System.Drawing.Size(130, 17)
        Me.chkCreatePostcode.TabIndex = 34
        Me.chkCreatePostcode.Text = "Create New Postcode"
        Me.chkCreatePostcode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Telephone"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(94, 175)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(204, 20)
        Me.txtTelephone.TabIndex = 32
        Me.txtTelephone.Text = "Telephone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Company:"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(94, 149)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(204, 20)
        Me.txtCompany.TabIndex = 30
        Me.txtCompany.Text = "Company"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Company:"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(101, 68)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(90, 13)
        Me.lblCompany.TabIndex = 28
        Me.lblCompany.Text = "Original Postcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Telephone:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(101, 92)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(90, 13)
        Me.lblTelephone.TabIndex = 26
        Me.lblTelephone.Text = "Original Postcode"
        '
        'lblEditTitle
        '
        Me.lblEditTitle.AutoSize = True
        Me.lblEditTitle.Location = New System.Drawing.Point(8, 204)
        Me.lblEditTitle.Name = "lblEditTitle"
        Me.lblEditTitle.Size = New System.Drawing.Size(52, 13)
        Me.lblEditTitle.TabIndex = 25
        Me.lblEditTitle.Text = "Postcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Postcode:"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(94, 201)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(204, 20)
        Me.txtPostcode.TabIndex = 23
        Me.txtPostcode.Text = "Postcode"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(101, 118)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(90, 13)
        Me.lblPostcode.TabIndex = 22
        Me.lblPostcode.Text = "Original Postcode"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Location = New System.Drawing.Point(12, 35)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(219, 13)
        Me.lblTitle2.TabIndex = 21
        Me.lblTitle2.Text = "Please check and edit the information below:"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(222, 13)
        Me.lblTitle1.TabIndex = 20
        Me.lblTitle1.Text = "The data in the datafile cannot be processed."
        '
        'btnRetry
        '
        Me.btnRetry.Enabled = False
        Me.btnRetry.Location = New System.Drawing.Point(223, 253)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(75, 23)
        Me.btnRetry.TabIndex = 19
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.DialogResult = DialogResult.Cancel
        Me.btnSkip.Location = New System.Drawing.Point(132, 253)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 23)
        Me.btnSkip.TabIndex = 18
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'frmEditImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 286)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.chkCreatePostcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblEditTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.btnSkip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Import Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents chkCreatePostcode As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblEditTitle As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
End Class
