<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiary
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.btnPrev = New System.Windows.Forms.Button
        Me.D1 = New System.Windows.Forms.Label
        Me.ColHeaderMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DailyGeneralAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D2 = New System.Windows.Forms.Label
        Me.D4 = New System.Windows.Forms.Label
        Me.D3 = New System.Windows.Forms.Label
        Me.D5 = New System.Windows.Forms.Label
        Me.BtnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanelGeneral = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnSaveGeneralAppointment = New System.Windows.Forms.Button
        Me.cmbDescription = New System.Windows.Forms.ComboBox()
        Me.PanelRepGenerated = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.BtnSaveRepGenerated = New System.Windows.Forms.Button
        Me.cmbSelectRep = New System.Windows.Forms.ComboBox()
        Me.D5P5 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D4P5 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D3P5 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D2P5 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D1P5 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D5P4 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D4P4 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D3P4 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D2P4 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D1P4 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D5P3 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D4P3 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D3P3 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D2P3 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D1P3 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D5P2 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D4P2 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D3P2 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D2P2 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D1P2 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D5P1 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D4P1 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D3P1 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D2P1 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.D1P1 = New CADNet.CallQueues.ManagerConsole.ctlManagerDiaryCell()
        Me.WeekStartPicker = New System.Windows.Forms.DateTimePicker()
        Me.ColHeaderMenu.SuspendLayout()
        Me.PanelGeneral.SuspendLayout()
        Me.PanelRepGenerated.SuspendLayout()
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
        Me.btnPrev.Location = New System.Drawing.Point(10, 79)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(25, 265)
        Me.btnPrev.TabIndex = 74
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'D1
        '
        Me.D1.BackColor = System.Drawing.Color.Gainsboro
        Me.D1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1.ContextMenuStrip = Me.ColHeaderMenu
        Me.D1.Location = New System.Drawing.Point(34, 101)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(70, 23)
        Me.D1.TabIndex = 76
        Me.D1.Text = "Label1"
        Me.D1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColHeaderMenu
        '
        Me.ColHeaderMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyGeneralAppointmentToolStripMenuItem})
        Me.ColHeaderMenu.Name = "ColHeaderMenu"
        Me.ColHeaderMenu.Size = New System.Drawing.Size(218, 26)
        '
        'DailyGeneralAppointmentToolStripMenuItem
        '
        Me.DailyGeneralAppointmentToolStripMenuItem.Name = "DailyGeneralAppointmentToolStripMenuItem"
        Me.DailyGeneralAppointmentToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DailyGeneralAppointmentToolStripMenuItem.Text = "Daily General Appointment"
        '
        'D2
        '
        Me.D2.BackColor = System.Drawing.Color.Gainsboro
        Me.D2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2.ContextMenuStrip = Me.ColHeaderMenu
        Me.D2.Location = New System.Drawing.Point(103, 101)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(70, 23)
        Me.D2.TabIndex = 77
        Me.D2.Text = "Label1"
        Me.D2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D4
        '
        Me.D4.BackColor = System.Drawing.Color.Gainsboro
        Me.D4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4.ContextMenuStrip = Me.ColHeaderMenu
        Me.D4.Location = New System.Drawing.Point(241, 101)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(70, 23)
        Me.D4.TabIndex = 79
        Me.D4.Text = "Label2"
        Me.D4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D3
        '
        Me.D3.BackColor = System.Drawing.Color.Gainsboro
        Me.D3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3.ContextMenuStrip = Me.ColHeaderMenu
        Me.D3.Location = New System.Drawing.Point(172, 101)
        Me.D3.Name = "D3"
        Me.D3.Size = New System.Drawing.Size(70, 23)
        Me.D3.TabIndex = 78
        Me.D3.Text = "Label1"
        Me.D3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D5
        '
        Me.D5.BackColor = System.Drawing.Color.Gainsboro
        Me.D5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5.ContextMenuStrip = Me.ColHeaderMenu
        Me.D5.Location = New System.Drawing.Point(310, 101)
        Me.D5.Name = "D5"
        Me.D5.Size = New System.Drawing.Size(70, 23)
        Me.D5.TabIndex = 80
        Me.D5.Text = "Label1"
        Me.D5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnNext.Location = New System.Drawing.Point(379, 79)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(25, 265)
        Me.BtnNext.TabIndex = 81
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(310, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Fri"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(241, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Thurs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(172, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Wed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(103, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Tues"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(34, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Mon"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelGeneral
        '
        Me.PanelGeneral.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelGeneral.Controls.Add(Me.Label6)
        Me.PanelGeneral.Controls.Add(Me.Button2)
        Me.PanelGeneral.Controls.Add(Me.btnSaveGeneralAppointment)
        Me.PanelGeneral.Controls.Add(Me.cmbDescription)
        Me.PanelGeneral.Location = New System.Drawing.Point(12, 350)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(392, 187)
        Me.PanelGeneral.TabIndex = 112
        Me.PanelGeneral.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Reason"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(80, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 34)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSaveGeneralAppointment
        '
        Me.btnSaveGeneralAppointment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveGeneralAppointment.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSaveGeneralAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSaveGeneralAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSaveGeneralAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveGeneralAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGeneralAppointment.Location = New System.Drawing.Point(221, 126)
        Me.btnSaveGeneralAppointment.Name = "btnSaveGeneralAppointment"
        Me.btnSaveGeneralAppointment.Size = New System.Drawing.Size(92, 34)
        Me.btnSaveGeneralAppointment.TabIndex = 100
        Me.btnSaveGeneralAppointment.Text = "Save"
        Me.btnSaveGeneralAppointment.UseVisualStyleBackColor = False
        '
        'cmbDescription
        '
        Me.cmbDescription.FormattingEnabled = True
        Me.cmbDescription.Items.AddRange(New Object() {"Holiday", "Meeting", "Not Available"})
        Me.cmbDescription.Location = New System.Drawing.Point(80, 26)
        Me.cmbDescription.Name = "cmbDescription"
        Me.cmbDescription.Size = New System.Drawing.Size(233, 21)
        Me.cmbDescription.TabIndex = 0
        '
        'PanelRepGenerated
        '
        Me.PanelRepGenerated.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelRepGenerated.Controls.Add(Me.Label8)
        Me.PanelRepGenerated.Controls.Add(Me.Label7)
        Me.PanelRepGenerated.Controls.Add(Me.txtPostcode)
        Me.PanelRepGenerated.Controls.Add(Me.txtCompany)
        Me.PanelRepGenerated.Controls.Add(Me.Button3)
        Me.PanelRepGenerated.Controls.Add(Me.BtnSaveRepGenerated)
        Me.PanelRepGenerated.Location = New System.Drawing.Point(12, 361)
        Me.PanelRepGenerated.Name = "PanelRepGenerated"
        Me.PanelRepGenerated.Size = New System.Drawing.Size(392, 187)
        Me.PanelRepGenerated.TabIndex = 113
        Me.PanelRepGenerated.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Full Postcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Company"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(91, 63)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 20)
        Me.txtPostcode.TabIndex = 103
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(91, 22)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(277, 20)
        Me.txtCompany.TabIndex = 102
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(80, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 34)
        Me.Button3.TabIndex = 101
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnSaveRepGenerated
        '
        Me.BtnSaveRepGenerated.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSaveRepGenerated.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSaveRepGenerated.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSaveRepGenerated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSaveRepGenerated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveRepGenerated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveRepGenerated.Location = New System.Drawing.Point(221, 126)
        Me.BtnSaveRepGenerated.Name = "BtnSaveRepGenerated"
        Me.BtnSaveRepGenerated.Size = New System.Drawing.Size(92, 34)
        Me.BtnSaveRepGenerated.TabIndex = 100
        Me.BtnSaveRepGenerated.Text = "Save"
        Me.BtnSaveRepGenerated.UseVisualStyleBackColor = False
        '
        'cmbSelectRep
        '
        Me.cmbSelectRep.FormattingEnabled = True
        Me.cmbSelectRep.Location = New System.Drawing.Point(120, 12)
        Me.cmbSelectRep.Name = "cmbSelectRep"
        Me.cmbSelectRep.Size = New System.Drawing.Size(191, 21)
        Me.cmbSelectRep.TabIndex = 114
        '
        'D5P5
        '
        Me.D5P5.AccessibleDescription = ""
        Me.D5P5.Appointment = Nothing
        Me.D5P5.AppointmentDate = Nothing
        Me.D5P5.AppointmentTime = Nothing
        Me.D5P5.BackColor = System.Drawing.Color.White
        Me.D5P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P5.HasAppointment = False
        Me.D5P5.Location = New System.Drawing.Point(310, 299)
        Me.D5P5.Name = "D5P5"
        Me.D5P5.Period = -1
        Me.D5P5.Selected = False
        Me.D5P5.Size = New System.Drawing.Size(70, 45)
        Me.D5P5.TabIndex = 111
        '
        'D4P5
        '
        Me.D4P5.AccessibleDescription = ""
        Me.D4P5.Appointment = Nothing
        Me.D4P5.AppointmentDate = Nothing
        Me.D4P5.AppointmentTime = Nothing
        Me.D4P5.BackColor = System.Drawing.Color.White
        Me.D4P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P5.HasAppointment = False
        Me.D4P5.Location = New System.Drawing.Point(241, 299)
        Me.D4P5.Name = "D4P5"
        Me.D4P5.Period = -1
        Me.D4P5.Selected = False
        Me.D4P5.Size = New System.Drawing.Size(70, 45)
        Me.D4P5.TabIndex = 110
        '
        'D3P5
        '
        Me.D3P5.AccessibleDescription = ""
        Me.D3P5.Appointment = Nothing
        Me.D3P5.AppointmentDate = Nothing
        Me.D3P5.AppointmentTime = Nothing
        Me.D3P5.BackColor = System.Drawing.Color.White
        Me.D3P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P5.HasAppointment = False
        Me.D3P5.Location = New System.Drawing.Point(172, 299)
        Me.D3P5.Name = "D3P5"
        Me.D3P5.Period = -1
        Me.D3P5.Selected = False
        Me.D3P5.Size = New System.Drawing.Size(70, 45)
        Me.D3P5.TabIndex = 109
        '
        'D2P5
        '
        Me.D2P5.AccessibleDescription = ""
        Me.D2P5.Appointment = Nothing
        Me.D2P5.AppointmentDate = Nothing
        Me.D2P5.AppointmentTime = Nothing
        Me.D2P5.BackColor = System.Drawing.Color.White
        Me.D2P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P5.HasAppointment = False
        Me.D2P5.Location = New System.Drawing.Point(103, 299)
        Me.D2P5.Name = "D2P5"
        Me.D2P5.Period = -1
        Me.D2P5.Selected = False
        Me.D2P5.Size = New System.Drawing.Size(70, 45)
        Me.D2P5.TabIndex = 108
        '
        'D1P5
        '
        Me.D1P5.AccessibleDescription = ""
        Me.D1P5.Appointment = Nothing
        Me.D1P5.AppointmentDate = Nothing
        Me.D1P5.AppointmentTime = Nothing
        Me.D1P5.BackColor = System.Drawing.Color.White
        Me.D1P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P5.HasAppointment = False
        Me.D1P5.Location = New System.Drawing.Point(34, 299)
        Me.D1P5.Name = "D1P5"
        Me.D1P5.Period = -1
        Me.D1P5.Selected = False
        Me.D1P5.Size = New System.Drawing.Size(70, 45)
        Me.D1P5.TabIndex = 107
        '
        'D5P4
        '
        Me.D5P4.AccessibleDescription = ""
        Me.D5P4.Appointment = Nothing
        Me.D5P4.AppointmentDate = Nothing
        Me.D5P4.AppointmentTime = Nothing
        Me.D5P4.BackColor = System.Drawing.Color.White
        Me.D5P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P4.HasAppointment = False
        Me.D5P4.Location = New System.Drawing.Point(310, 255)
        Me.D5P4.Name = "D5P4"
        Me.D5P4.Period = -1
        Me.D5P4.Selected = False
        Me.D5P4.Size = New System.Drawing.Size(70, 45)
        Me.D5P4.TabIndex = 106
        '
        'D4P4
        '
        Me.D4P4.AccessibleDescription = ""
        Me.D4P4.Appointment = Nothing
        Me.D4P4.AppointmentDate = Nothing
        Me.D4P4.AppointmentTime = Nothing
        Me.D4P4.BackColor = System.Drawing.Color.White
        Me.D4P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P4.HasAppointment = False
        Me.D4P4.Location = New System.Drawing.Point(241, 255)
        Me.D4P4.Name = "D4P4"
        Me.D4P4.Period = -1
        Me.D4P4.Selected = False
        Me.D4P4.Size = New System.Drawing.Size(70, 45)
        Me.D4P4.TabIndex = 105
        '
        'D3P4
        '
        Me.D3P4.AccessibleDescription = ""
        Me.D3P4.Appointment = Nothing
        Me.D3P4.AppointmentDate = Nothing
        Me.D3P4.AppointmentTime = Nothing
        Me.D3P4.BackColor = System.Drawing.Color.White
        Me.D3P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P4.HasAppointment = False
        Me.D3P4.Location = New System.Drawing.Point(172, 255)
        Me.D3P4.Name = "D3P4"
        Me.D3P4.Period = -1
        Me.D3P4.Selected = False
        Me.D3P4.Size = New System.Drawing.Size(70, 45)
        Me.D3P4.TabIndex = 104
        '
        'D2P4
        '
        Me.D2P4.AccessibleDescription = ""
        Me.D2P4.Appointment = Nothing
        Me.D2P4.AppointmentDate = Nothing
        Me.D2P4.AppointmentTime = Nothing
        Me.D2P4.BackColor = System.Drawing.Color.White
        Me.D2P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P4.HasAppointment = False
        Me.D2P4.Location = New System.Drawing.Point(103, 255)
        Me.D2P4.Name = "D2P4"
        Me.D2P4.Period = -1
        Me.D2P4.Selected = False
        Me.D2P4.Size = New System.Drawing.Size(70, 45)
        Me.D2P4.TabIndex = 103
        '
        'D1P4
        '
        Me.D1P4.AccessibleDescription = ""
        Me.D1P4.Appointment = Nothing
        Me.D1P4.AppointmentDate = Nothing
        Me.D1P4.AppointmentTime = Nothing
        Me.D1P4.BackColor = System.Drawing.Color.White
        Me.D1P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P4.HasAppointment = False
        Me.D1P4.Location = New System.Drawing.Point(34, 255)
        Me.D1P4.Name = "D1P4"
        Me.D1P4.Period = -1
        Me.D1P4.Selected = False
        Me.D1P4.Size = New System.Drawing.Size(70, 45)
        Me.D1P4.TabIndex = 102
        '
        'D5P3
        '
        Me.D5P3.AccessibleDescription = ""
        Me.D5P3.Appointment = Nothing
        Me.D5P3.AppointmentDate = Nothing
        Me.D5P3.AppointmentTime = Nothing
        Me.D5P3.BackColor = System.Drawing.Color.White
        Me.D5P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P3.HasAppointment = False
        Me.D5P3.Location = New System.Drawing.Point(310, 211)
        Me.D5P3.Name = "D5P3"
        Me.D5P3.Period = -1
        Me.D5P3.Selected = False
        Me.D5P3.Size = New System.Drawing.Size(70, 45)
        Me.D5P3.TabIndex = 101
        '
        'D4P3
        '
        Me.D4P3.AccessibleDescription = ""
        Me.D4P3.Appointment = Nothing
        Me.D4P3.AppointmentDate = Nothing
        Me.D4P3.AppointmentTime = Nothing
        Me.D4P3.BackColor = System.Drawing.Color.White
        Me.D4P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P3.HasAppointment = False
        Me.D4P3.Location = New System.Drawing.Point(241, 211)
        Me.D4P3.Name = "D4P3"
        Me.D4P3.Period = -1
        Me.D4P3.Selected = False
        Me.D4P3.Size = New System.Drawing.Size(70, 45)
        Me.D4P3.TabIndex = 100
        '
        'D3P3
        '
        Me.D3P3.AccessibleDescription = ""
        Me.D3P3.Appointment = Nothing
        Me.D3P3.AppointmentDate = Nothing
        Me.D3P3.AppointmentTime = Nothing
        Me.D3P3.BackColor = System.Drawing.Color.White
        Me.D3P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P3.HasAppointment = False
        Me.D3P3.Location = New System.Drawing.Point(172, 211)
        Me.D3P3.Name = "D3P3"
        Me.D3P3.Period = -1
        Me.D3P3.Selected = False
        Me.D3P3.Size = New System.Drawing.Size(70, 45)
        Me.D3P3.TabIndex = 99
        '
        'D2P3
        '
        Me.D2P3.AccessibleDescription = ""
        Me.D2P3.Appointment = Nothing
        Me.D2P3.AppointmentDate = Nothing
        Me.D2P3.AppointmentTime = Nothing
        Me.D2P3.BackColor = System.Drawing.Color.White
        Me.D2P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P3.HasAppointment = False
        Me.D2P3.Location = New System.Drawing.Point(103, 211)
        Me.D2P3.Name = "D2P3"
        Me.D2P3.Period = -1
        Me.D2P3.Selected = False
        Me.D2P3.Size = New System.Drawing.Size(70, 45)
        Me.D2P3.TabIndex = 98
        '
        'D1P3
        '
        Me.D1P3.AccessibleDescription = ""
        Me.D1P3.Appointment = Nothing
        Me.D1P3.AppointmentDate = Nothing
        Me.D1P3.AppointmentTime = Nothing
        Me.D1P3.BackColor = System.Drawing.Color.White
        Me.D1P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P3.HasAppointment = False
        Me.D1P3.Location = New System.Drawing.Point(34, 211)
        Me.D1P3.Name = "D1P3"
        Me.D1P3.Period = -1
        Me.D1P3.Selected = False
        Me.D1P3.Size = New System.Drawing.Size(70, 45)
        Me.D1P3.TabIndex = 97
        '
        'D5P2
        '
        Me.D5P2.AccessibleDescription = ""
        Me.D5P2.Appointment = Nothing
        Me.D5P2.AppointmentDate = Nothing
        Me.D5P2.AppointmentTime = Nothing
        Me.D5P2.BackColor = System.Drawing.Color.White
        Me.D5P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P2.HasAppointment = False
        Me.D5P2.Location = New System.Drawing.Point(310, 167)
        Me.D5P2.Name = "D5P2"
        Me.D5P2.Period = -1
        Me.D5P2.Selected = False
        Me.D5P2.Size = New System.Drawing.Size(70, 45)
        Me.D5P2.TabIndex = 96
        '
        'D4P2
        '
        Me.D4P2.AccessibleDescription = ""
        Me.D4P2.Appointment = Nothing
        Me.D4P2.AppointmentDate = Nothing
        Me.D4P2.AppointmentTime = Nothing
        Me.D4P2.BackColor = System.Drawing.Color.White
        Me.D4P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P2.HasAppointment = False
        Me.D4P2.Location = New System.Drawing.Point(241, 167)
        Me.D4P2.Name = "D4P2"
        Me.D4P2.Period = -1
        Me.D4P2.Selected = False
        Me.D4P2.Size = New System.Drawing.Size(70, 45)
        Me.D4P2.TabIndex = 95
        '
        'D3P2
        '
        Me.D3P2.AccessibleDescription = ""
        Me.D3P2.Appointment = Nothing
        Me.D3P2.AppointmentDate = Nothing
        Me.D3P2.AppointmentTime = Nothing
        Me.D3P2.BackColor = System.Drawing.Color.White
        Me.D3P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P2.HasAppointment = False
        Me.D3P2.Location = New System.Drawing.Point(172, 167)
        Me.D3P2.Name = "D3P2"
        Me.D3P2.Period = -1
        Me.D3P2.Selected = False
        Me.D3P2.Size = New System.Drawing.Size(70, 45)
        Me.D3P2.TabIndex = 94
        '
        'D2P2
        '
        Me.D2P2.AccessibleDescription = ""
        Me.D2P2.Appointment = Nothing
        Me.D2P2.AppointmentDate = Nothing
        Me.D2P2.AppointmentTime = Nothing
        Me.D2P2.BackColor = System.Drawing.Color.White
        Me.D2P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P2.HasAppointment = False
        Me.D2P2.Location = New System.Drawing.Point(103, 167)
        Me.D2P2.Name = "D2P2"
        Me.D2P2.Period = -1
        Me.D2P2.Selected = False
        Me.D2P2.Size = New System.Drawing.Size(70, 45)
        Me.D2P2.TabIndex = 93
        '
        'D1P2
        '
        Me.D1P2.AccessibleDescription = ""
        Me.D1P2.Appointment = Nothing
        Me.D1P2.AppointmentDate = Nothing
        Me.D1P2.AppointmentTime = Nothing
        Me.D1P2.BackColor = System.Drawing.Color.White
        Me.D1P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P2.HasAppointment = False
        Me.D1P2.Location = New System.Drawing.Point(34, 167)
        Me.D1P2.Name = "D1P2"
        Me.D1P2.Period = -1
        Me.D1P2.Selected = False
        Me.D1P2.Size = New System.Drawing.Size(70, 45)
        Me.D1P2.TabIndex = 92
        '
        'D5P1
        '
        Me.D5P1.AccessibleDescription = ""
        Me.D5P1.Appointment = Nothing
        Me.D5P1.AppointmentDate = Nothing
        Me.D5P1.AppointmentTime = Nothing
        Me.D5P1.BackColor = System.Drawing.Color.White
        Me.D5P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5P1.HasAppointment = False
        Me.D5P1.Location = New System.Drawing.Point(310, 123)
        Me.D5P1.Name = "D5P1"
        Me.D5P1.Period = -1
        Me.D5P1.Selected = False
        Me.D5P1.Size = New System.Drawing.Size(70, 45)
        Me.D5P1.TabIndex = 91
        '
        'D4P1
        '
        Me.D4P1.AccessibleDescription = ""
        Me.D4P1.Appointment = Nothing
        Me.D4P1.AppointmentDate = Nothing
        Me.D4P1.AppointmentTime = Nothing
        Me.D4P1.BackColor = System.Drawing.Color.White
        Me.D4P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4P1.HasAppointment = False
        Me.D4P1.Location = New System.Drawing.Point(241, 123)
        Me.D4P1.Name = "D4P1"
        Me.D4P1.Period = -1
        Me.D4P1.Selected = False
        Me.D4P1.Size = New System.Drawing.Size(70, 45)
        Me.D4P1.TabIndex = 90
        '
        'D3P1
        '
        Me.D3P1.AccessibleDescription = ""
        Me.D3P1.Appointment = Nothing
        Me.D3P1.AppointmentDate = Nothing
        Me.D3P1.AppointmentTime = Nothing
        Me.D3P1.BackColor = System.Drawing.Color.White
        Me.D3P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3P1.HasAppointment = False
        Me.D3P1.Location = New System.Drawing.Point(172, 123)
        Me.D3P1.Name = "D3P1"
        Me.D3P1.Period = -1
        Me.D3P1.Selected = False
        Me.D3P1.Size = New System.Drawing.Size(70, 45)
        Me.D3P1.TabIndex = 89
        '
        'D2P1
        '
        Me.D2P1.AccessibleDescription = ""
        Me.D2P1.Appointment = Nothing
        Me.D2P1.AppointmentDate = Nothing
        Me.D2P1.AppointmentTime = Nothing
        Me.D2P1.BackColor = System.Drawing.Color.White
        Me.D2P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2P1.HasAppointment = False
        Me.D2P1.Location = New System.Drawing.Point(103, 123)
        Me.D2P1.Name = "D2P1"
        Me.D2P1.Period = -1
        Me.D2P1.Selected = False
        Me.D2P1.Size = New System.Drawing.Size(70, 45)
        Me.D2P1.TabIndex = 88
        '
        'D1P1
        '
        Me.D1P1.AccessibleDescription = ""
        Me.D1P1.Appointment = Nothing
        Me.D1P1.AppointmentDate = Nothing
        Me.D1P1.AppointmentTime = Nothing
        Me.D1P1.BackColor = System.Drawing.Color.White
        Me.D1P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1P1.HasAppointment = False
        Me.D1P1.Location = New System.Drawing.Point(34, 123)
        Me.D1P1.Name = "D1P1"
        Me.D1P1.Period = -1
        Me.D1P1.Selected = False
        Me.D1P1.Size = New System.Drawing.Size(70, 45)
        Me.D1P1.TabIndex = 87
        '
        'WeekStartPicker
        '
        Me.WeekStartPicker.Location = New System.Drawing.Point(125, 39)
        Me.WeekStartPicker.Name = "WeekStartPicker"
        Me.WeekStartPicker.Size = New System.Drawing.Size(186, 20)
        Me.WeekStartPicker.TabIndex = 115
        Me.WeekStartPicker.Visible = False
        '
        'FrmDiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(495, 762)
        Me.Controls.Add(Me.WeekStartPicker)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.cmbSelectRep)
        Me.Controls.Add(Me.D3)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.D4)
        Me.Controls.Add(Me.D5P5)
        Me.Controls.Add(Me.D5P2)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.D5)
        Me.Controls.Add(Me.D1P3)
        Me.Controls.Add(Me.D4P2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.D2P3)
        Me.Controls.Add(Me.D4P5)
        Me.Controls.Add(Me.D3P2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.D3P3)
        Me.Controls.Add(Me.D3P5)
        Me.Controls.Add(Me.D2P2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.D4P3)
        Me.Controls.Add(Me.D2P5)
        Me.Controls.Add(Me.D1P2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.D5P3)
        Me.Controls.Add(Me.D1P5)
        Me.Controls.Add(Me.D5P1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.D1P4)
        Me.Controls.Add(Me.D5P4)
        Me.Controls.Add(Me.D4P1)
        Me.Controls.Add(Me.D1P1)
        Me.Controls.Add(Me.D2P4)
        Me.Controls.Add(Me.D4P4)
        Me.Controls.Add(Me.D3P1)
        Me.Controls.Add(Me.D2P1)
        Me.Controls.Add(Me.D3P4)
        Me.Controls.Add(Me.PanelRepGenerated)
        Me.Name = "FrmDiary"
        Me.Text = "FrmDiary"
        Me.ColHeaderMenu.ResumeLayout(False)
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelGeneral.PerformLayout()
        Me.PanelRepGenerated.ResumeLayout(False)
        Me.PanelRepGenerated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents D1 As System.Windows.Forms.Label
    Friend WithEvents D2 As System.Windows.Forms.Label
    Friend WithEvents D4 As System.Windows.Forms.Label
    Friend WithEvents D3 As System.Windows.Forms.Label
    Friend WithEvents D5 As System.Windows.Forms.Label
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents D1P1 As ctlManagerDiaryCell
    Friend WithEvents D2P1 As ctlManagerDiaryCell
    Friend WithEvents D3P1 As ctlManagerDiaryCell
    Friend WithEvents D4P1 As ctlManagerDiaryCell
    Friend WithEvents D5P1 As ctlManagerDiaryCell
    Friend WithEvents D5P2 As ctlManagerDiaryCell
    Friend WithEvents D4P2 As ctlManagerDiaryCell
    Friend WithEvents D3P2 As ctlManagerDiaryCell
    Friend WithEvents D2P2 As ctlManagerDiaryCell
    Friend WithEvents D1P2 As ctlManagerDiaryCell
    Friend WithEvents D5P3 As ctlManagerDiaryCell
    Friend WithEvents D4P3 As ctlManagerDiaryCell
    Friend WithEvents D3P3 As ctlManagerDiaryCell
    Friend WithEvents D2P3 As ctlManagerDiaryCell
    Friend WithEvents D1P3 As ctlManagerDiaryCell
    Friend WithEvents D5P4 As ctlManagerDiaryCell
    Friend WithEvents D4P4 As ctlManagerDiaryCell
    Friend WithEvents D3P4 As ctlManagerDiaryCell
    Friend WithEvents D2P4 As ctlManagerDiaryCell
    Friend WithEvents D1P4 As ctlManagerDiaryCell
    Friend WithEvents D5P5 As ctlManagerDiaryCell
    Friend WithEvents D4P5 As ctlManagerDiaryCell
    Friend WithEvents D3P5 As ctlManagerDiaryCell
    Friend WithEvents D2P5 As ctlManagerDiaryCell
    Friend WithEvents D1P5 As ctlManagerDiaryCell
    Friend WithEvents PanelGeneral As System.Windows.Forms.Panel
    Friend WithEvents cmbDescription As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSaveGeneralAppointment As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelRepGenerated As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveRepGenerated As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents cmbSelectRep As System.Windows.Forms.ComboBox
    Friend WithEvents ColHeaderMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DailyGeneralAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeekStartPicker As System.Windows.Forms.DateTimePicker
End Class
