<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanyFind))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lvwCompanies = New System.Windows.Forms.ListView
        Me.colCompanyName = New System.Windows.Forms.ColumnHeader
        Me.colTelephone = New System.Windows.Forms.ColumnHeader
        Me.colPostcode = New System.Windows.Forms.ColumnHeader
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCreateNew = New System.Windows.Forms.Button
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(430, 369)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(511, 369)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lvwCompanies
        '
        Me.lvwCompanies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCompanies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCompanyName, Me.colTelephone, Me.colPostcode})
        Me.lvwCompanies.FullRowSelect = True
        Me.lvwCompanies.Location = New System.Drawing.Point(12, 51)
        Me.lvwCompanies.Name = "lvwCompanies"
        Me.lvwCompanies.Size = New System.Drawing.Size(574, 312)
        Me.lvwCompanies.TabIndex = 2
        Me.lvwCompanies.UseCompatibleStateImageBehavior = False
        Me.lvwCompanies.View = System.Windows.Forms.View.Details
        '
        'colCompanyName
        '
        Me.colCompanyName.Text = "Company Name"
        Me.colCompanyName.Width = 213
        '
        'colTelephone
        '
        Me.colTelephone.Text = "Telephone"
        Me.colTelephone.Width = 159
        '
        'colPostcode
        '
        Me.colPostcode.Text = "Postcode"
        Me.colPostcode.Width = 180
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(511, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telephone"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateNew.Location = New System.Drawing.Point(12, 369)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateNew.TabIndex = 7
        Me.btnCreateNew.Text = "New"
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(81, 9)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(190, 20)
        Me.txtTelephone.TabIndex = 1
        '
        'frmCompanyFind
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(598, 404)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.btnCreateNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwCompanies)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompanyFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lvwCompanies As System.Windows.Forms.ListView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCreateNew As System.Windows.Forms.Button
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents colCompanyName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTelephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPostcode As System.Windows.Forms.ColumnHeader
End Class
