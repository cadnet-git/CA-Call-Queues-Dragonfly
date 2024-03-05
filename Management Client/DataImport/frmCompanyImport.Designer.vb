<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyImport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlAreaHeader = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.radioFirstRowIsData = New System.Windows.Forms.RadioButton
        Me.radioFirstRowIsTitle = New System.Windows.Forms.RadioButton
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnImportFile = New System.Windows.Forms.Button
        Me.pnlSettings = New System.Windows.Forms.Panel
        Me.pnlImportProgress = New System.Windows.Forms.Panel
        Me.lblSkipped = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lblDuplicatedTelephones = New System.Windows.Forms.Label
        Me.lblNewPostcodes = New System.Windows.Forms.Label
        Me.lblNewCompanies = New System.Windows.Forms.Label
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlAreaHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        Me.pnlImportProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAreaHeader
        '
        Me.pnlAreaHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlAreaHeader.Controls.Add(Me.PictureBox1)
        Me.pnlAreaHeader.Controls.Add(Me.Label2)
        Me.pnlAreaHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAreaHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlAreaHeader.Name = "pnlAreaHeader"
        Me.pnlAreaHeader.Size = New System.Drawing.Size(400, 48)
        Me.pnlAreaHeader.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.import
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Import Companies"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Preview"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(7, 99)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(384, 160)
        Me.DataGridView1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First row of file contains"
        '
        'radioFirstRowIsData
        '
        Me.radioFirstRowIsData.AutoSize = True
        Me.radioFirstRowIsData.Checked = True
        Me.radioFirstRowIsData.Location = New System.Drawing.Point(138, 41)
        Me.radioFirstRowIsData.Name = "radioFirstRowIsData"
        Me.radioFirstRowIsData.Size = New System.Drawing.Size(138, 17)
        Me.radioFirstRowIsData.TabIndex = 4
        Me.radioFirstRowIsData.TabStop = True
        Me.radioFirstRowIsData.Text = "the first company record"
        Me.radioFirstRowIsData.UseVisualStyleBackColor = True
        '
        'radioFirstRowIsTitle
        '
        Me.radioFirstRowIsTitle.AutoSize = True
        Me.radioFirstRowIsTitle.Location = New System.Drawing.Point(138, 64)
        Me.radioFirstRowIsTitle.Name = "radioFirstRowIsTitle"
        Me.radioFirstRowIsTitle.Size = New System.Drawing.Size(136, 17)
        Me.radioFirstRowIsTitle.TabIndex = 5
        Me.radioFirstRowIsTitle.Text = "the titles of the columns"
        Me.radioFirstRowIsTitle.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.Location = New System.Drawing.Point(35, 6)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(275, 20)
        Me.txtFilename.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(316, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnImportFile
        '
        Me.btnImportFile.Enabled = False
        Me.btnImportFile.Location = New System.Drawing.Point(316, 265)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(75, 23)
        Me.btnImportFile.TabIndex = 8
        Me.btnImportFile.Text = "Import File"
        Me.btnImportFile.UseVisualStyleBackColor = True
        '
        'pnlSettings
        '
        Me.pnlSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSettings.Controls.Add(Me.Label1)
        Me.pnlSettings.Controls.Add(Me.btnImportFile)
        Me.pnlSettings.Controls.Add(Me.btnBrowse)
        Me.pnlSettings.Controls.Add(Me.Label4)
        Me.pnlSettings.Controls.Add(Me.txtFilename)
        Me.pnlSettings.Controls.Add(Me.DataGridView1)
        Me.pnlSettings.Controls.Add(Me.radioFirstRowIsTitle)
        Me.pnlSettings.Controls.Add(Me.radioFirstRowIsData)
        Me.pnlSettings.Controls.Add(Me.Label3)
        Me.pnlSettings.Location = New System.Drawing.Point(5, 57)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(395, 294)
        Me.pnlSettings.TabIndex = 1
        '
        'pnlImportProgress
        '
        Me.pnlImportProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlImportProgress.Controls.Add(Me.lblSkipped)
        Me.pnlImportProgress.Controls.Add(Me.Label6)
        Me.pnlImportProgress.Controls.Add(Me.ProgressBar1)
        Me.pnlImportProgress.Controls.Add(Me.lblDuplicatedTelephones)
        Me.pnlImportProgress.Controls.Add(Me.lblNewPostcodes)
        Me.pnlImportProgress.Controls.Add(Me.lblNewCompanies)
        Me.pnlImportProgress.Controls.Add(Me.lblRemaining)
        Me.pnlImportProgress.Controls.Add(Me.Label8)
        Me.pnlImportProgress.Controls.Add(Me.Label7)
        Me.pnlImportProgress.Controls.Add(Me.Label9)
        Me.pnlImportProgress.Controls.Add(Me.Label10)
        Me.pnlImportProgress.Controls.Add(Me.Label5)
        Me.pnlImportProgress.Location = New System.Drawing.Point(3, 360)
        Me.pnlImportProgress.Name = "pnlImportProgress"
        Me.pnlImportProgress.Size = New System.Drawing.Size(393, 197)
        Me.pnlImportProgress.TabIndex = 2
        Me.pnlImportProgress.Visible = False
        '
        'lblSkipped
        '
        Me.lblSkipped.AutoSize = True
        Me.lblSkipped.Location = New System.Drawing.Point(187, 129)
        Me.lblSkipped.Name = "lblSkipped"
        Me.lblSkipped.Size = New System.Drawing.Size(10, 13)
        Me.lblSkipped.TabIndex = 9
        Me.lblSkipped.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Skipped"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 21)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(377, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'lblDuplicatedTelephones
        '
        Me.lblDuplicatedTelephones.AutoSize = True
        Me.lblDuplicatedTelephones.Location = New System.Drawing.Point(187, 104)
        Me.lblDuplicatedTelephones.Name = "lblDuplicatedTelephones"
        Me.lblDuplicatedTelephones.Size = New System.Drawing.Size(10, 13)
        Me.lblDuplicatedTelephones.TabIndex = 7
        Me.lblDuplicatedTelephones.Text = "-"
        '
        'lblNewPostcodes
        '
        Me.lblNewPostcodes.AutoSize = True
        Me.lblNewPostcodes.Location = New System.Drawing.Point(185, 167)
        Me.lblNewPostcodes.Name = "lblNewPostcodes"
        Me.lblNewPostcodes.Size = New System.Drawing.Size(10, 13)
        Me.lblNewPostcodes.TabIndex = 11
        Me.lblNewPostcodes.Text = "-"
        '
        'lblNewCompanies
        '
        Me.lblNewCompanies.AutoSize = True
        Me.lblNewCompanies.Location = New System.Drawing.Point(187, 81)
        Me.lblNewCompanies.Name = "lblNewCompanies"
        Me.lblNewCompanies.Size = New System.Drawing.Size(10, 13)
        Me.lblNewCompanies.TabIndex = 5
        Me.lblNewCompanies.Text = "-"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Location = New System.Drawing.Point(187, 56)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(10, 13)
        Me.lblRemaining.TabIndex = 3
        Me.lblRemaining.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Duplicated Telephones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "New Postcodes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "New Companies"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(119, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Remaining"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(380, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Please wait... Importing File"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCompanyImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 569)
        Me.Controls.Add(Me.pnlImportProgress)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.pnlAreaHeader)
        Me.Name = "frmCompanyImport"
        Me.Text = "frmCompanyImport"
        Me.pnlAreaHeader.ResumeLayout(False)
        Me.pnlAreaHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlImportProgress.ResumeLayout(False)
        Me.pnlImportProgress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAreaHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radioFirstRowIsData As System.Windows.Forms.RadioButton
    Friend WithEvents radioFirstRowIsTitle As System.Windows.Forms.RadioButton
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnImportFile As System.Windows.Forms.Button
    Friend WithEvents pnlSettings As System.Windows.Forms.Panel
    Friend WithEvents pnlImportProgress As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSkipped As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDuplicatedTelephones As System.Windows.Forms.Label
    Friend WithEvents lblNewPostcodes As System.Windows.Forms.Label
    Friend WithEvents lblNewCompanies As System.Windows.Forms.Label
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
