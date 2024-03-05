<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiaryListView
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
        Me.components = New System.ComponentModel.Container
        Me.lblThisWeek = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnWeekForward = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNoDiaryID = New System.Windows.Forms.Label
        Me.lblUpdating = New System.Windows.Forms.Label
        Me.lblNoAppointments = New System.Windows.Forms.Label
        Me.btnAddAppointment = New System.Windows.Forms.Button
        Me.pnlAppointments = New System.Windows.Forms.Panel
        Me.pnlControls = New System.Windows.Forms.Panel
        Me.btnThisWeek = New System.Windows.Forms.Button
        Me.pnlAppointments.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblThisWeek
        '
        Me.lblThisWeek.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThisWeek.BackColor = System.Drawing.Color.Teal
        Me.lblThisWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThisWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThisWeek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblThisWeek.Location = New System.Drawing.Point(22, 0)
        Me.lblThisWeek.Name = "lblThisWeek"
        Me.lblThisWeek.Size = New System.Drawing.Size(350, 18)
        Me.lblThisWeek.TabIndex = 0
        Me.lblThisWeek.Text = "This Week"
        Me.lblThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.LeftArrow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 18)
        Me.Button2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button2, "Show one week earlier")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnWeekForward
        '
        Me.btnWeekForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWeekForward.BackgroundImage = Global.CADNet.CallQueues.ManagerConsole.My.Resources.Resources.RightArrow
        Me.btnWeekForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeekForward.Location = New System.Drawing.Point(373, 0)
        Me.btnWeekForward.Name = "btnWeekForward"
        Me.btnWeekForward.Size = New System.Drawing.Size(20, 18)
        Me.btnWeekForward.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnWeekForward, "Show one week later")
        Me.btnWeekForward.UseVisualStyleBackColor = True
        '
        'lblNoDiaryID
        '
        Me.lblNoDiaryID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoDiaryID.Location = New System.Drawing.Point(138, 135)
        Me.lblNoDiaryID.Name = "lblNoDiaryID"
        Me.lblNoDiaryID.Size = New System.Drawing.Size(108, 13)
        Me.lblNoDiaryID.TabIndex = 3
        Me.lblNoDiaryID.Text = "Please Select a Diary"
        Me.lblNoDiaryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUpdating
        '
        Me.lblUpdating.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpdating.Location = New System.Drawing.Point(120, 53)
        Me.lblUpdating.Name = "lblUpdating"
        Me.lblUpdating.Size = New System.Drawing.Size(116, 13)
        Me.lblUpdating.TabIndex = 4
        Me.lblUpdating.Text = "Updating... Please wait"
        Me.lblUpdating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUpdating.Visible = False
        '
        'lblNoAppointments
        '
        Me.lblNoAppointments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoAppointments.Location = New System.Drawing.Point(80, 91)
        Me.lblNoAppointments.Name = "lblNoAppointments"
        Me.lblNoAppointments.Size = New System.Drawing.Size(197, 13)
        Me.lblNoAppointments.TabIndex = 5
        Me.lblNoAppointments.Text = "There are no appointments for this week"
        Me.lblNoAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoAppointments.Visible = False
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAppointment.Location = New System.Drawing.Point(313, 0)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAppointment.TabIndex = 6
        Me.btnAddAppointment.Text = "Add"
        Me.btnAddAppointment.UseVisualStyleBackColor = True
        '
        'pnlAppointments
        '
        Me.pnlAppointments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAppointments.AutoScroll = True
        Me.pnlAppointments.Controls.Add(Me.lblNoAppointments)
        Me.pnlAppointments.Controls.Add(Me.lblUpdating)
        Me.pnlAppointments.Controls.Add(Me.lblNoDiaryID)
        Me.pnlAppointments.Location = New System.Drawing.Point(1, 21)
        Me.pnlAppointments.Name = "pnlAppointments"
        Me.pnlAppointments.Size = New System.Drawing.Size(390, 263)
        Me.pnlAppointments.TabIndex = 7
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnThisWeek)
        Me.pnlControls.Controls.Add(Me.btnAddAppointment)
        Me.pnlControls.Location = New System.Drawing.Point(0, 285)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(394, 27)
        Me.pnlControls.TabIndex = 6
        '
        'btnThisWeek
        '
        Me.btnThisWeek.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThisWeek.Location = New System.Drawing.Point(4, -1)
        Me.btnThisWeek.Name = "btnThisWeek"
        Me.btnThisWeek.Size = New System.Drawing.Size(75, 23)
        Me.btnThisWeek.TabIndex = 7
        Me.btnThisWeek.Text = "This Week"
        Me.btnThisWeek.UseVisualStyleBackColor = True
        '
        'DiaryListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlAppointments)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnWeekForward)
        Me.Controls.Add(Me.lblThisWeek)
        Me.Name = "DiaryListView"
        Me.Size = New System.Drawing.Size(394, 312)
        Me.pnlAppointments.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblThisWeek As System.Windows.Forms.Label
    Friend WithEvents btnWeekForward As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblNoDiaryID As System.Windows.Forms.Label
    Friend WithEvents lblUpdating As System.Windows.Forms.Label
    Friend WithEvents lblNoAppointments As System.Windows.Forms.Label
    Friend WithEvents btnAddAppointment As System.Windows.Forms.Button
    Friend WithEvents pnlAppointments As System.Windows.Forms.Panel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnThisWeek As System.Windows.Forms.Button

End Class
