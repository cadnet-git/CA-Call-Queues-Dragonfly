<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficePerformance
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
        Me.lv = New System.Windows.Forms.ListView
        Me.mDate = New System.Windows.Forms.ColumnHeader
        Me.Office = New System.Windows.Forms.ColumnHeader
        Me.Agents = New System.Windows.Forms.ColumnHeader
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.Apps = New System.Windows.Forms.ColumnHeader
        Me.Dead = New System.Windows.Forms.ColumnHeader
        Me.Live = New System.Windows.Forms.ColumnHeader
        Me.Ratio = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAgentsB = New System.Windows.Forms.Label
        Me.lblAgentsS = New System.Windows.Forms.Label
        Me.lblLiveB = New System.Windows.Forms.Label
        Me.lblLiveS = New System.Windows.Forms.Label
        Me.lblRatioB = New System.Windows.Forms.Label
        Me.lblRatioS = New System.Windows.Forms.Label
        Me.lvMonth = New System.Windows.Forms.ListView
        Me.Month = New System.Windows.Forms.ColumnHeader
        Me.AgentsB = New System.Windows.Forms.ColumnHeader
        Me.LiveAppsBattesea = New System.Windows.Forms.ColumnHeader
        Me.RatioB = New System.Windows.Forms.ColumnHeader
        Me.AgentsS = New System.Windows.Forms.ColumnHeader
        Me.LiveS = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mDate, Me.Office, Me.Agents, Me.Apps, Me.Dead, Me.Live, Me.Ratio})
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(34, 67)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(808, 228)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'mDate
        '
        Me.mDate.Text = "Date"
        Me.mDate.Width = 112
        '
        'Office
        '
        Me.Office.Text = "Office"
        Me.Office.Width = 125
        '
        'Agents
        '
        Me.Agents.Text = "Agents"
        Me.Agents.Width = 82
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(603, 19)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(108, 35)
        Me.BtnRefresh.TabIndex = 1
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Apps
        '
        Me.Apps.Text = "Apps"
        '
        'Dead
        '
        Me.Dead.Text = "Dead"
        '
        'Live
        '
        Me.Live.Text = "Live"
        '
        'Ratio
        '
        Me.Ratio.Text = "Ratio"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sutton"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Battersea"
        '
        'lblAgentsB
        '
        Me.lblAgentsB.Location = New System.Drawing.Point(265, 9)
        Me.lblAgentsB.Name = "lblAgentsB"
        Me.lblAgentsB.Size = New System.Drawing.Size(80, 13)
        Me.lblAgentsB.TabIndex = 6
        Me.lblAgentsB.Text = " "
        '
        'lblAgentsS
        '
        Me.lblAgentsS.Location = New System.Drawing.Point(265, 30)
        Me.lblAgentsS.Name = "lblAgentsS"
        Me.lblAgentsS.Size = New System.Drawing.Size(80, 13)
        Me.lblAgentsS.TabIndex = 5
        Me.lblAgentsS.Text = " "
        '
        'lblLiveB
        '
        Me.lblLiveB.Location = New System.Drawing.Point(365, 12)
        Me.lblLiveB.Name = "lblLiveB"
        Me.lblLiveB.Size = New System.Drawing.Size(80, 13)
        Me.lblLiveB.TabIndex = 8
        Me.lblLiveB.Text = " "
        '
        'lblLiveS
        '
        Me.lblLiveS.Location = New System.Drawing.Point(365, 33)
        Me.lblLiveS.Name = "lblLiveS"
        Me.lblLiveS.Size = New System.Drawing.Size(80, 13)
        Me.lblLiveS.TabIndex = 7
        Me.lblLiveS.Text = " "
        '
        'lblRatioB
        '
        Me.lblRatioB.Location = New System.Drawing.Point(476, 12)
        Me.lblRatioB.Name = "lblRatioB"
        Me.lblRatioB.Size = New System.Drawing.Size(80, 13)
        Me.lblRatioB.TabIndex = 10
        Me.lblRatioB.Text = " "
        '
        'lblRatioS
        '
        Me.lblRatioS.Location = New System.Drawing.Point(476, 33)
        Me.lblRatioS.Name = "lblRatioS"
        Me.lblRatioS.Size = New System.Drawing.Size(80, 13)
        Me.lblRatioS.TabIndex = 9
        Me.lblRatioS.Text = " "
        '
        'lvMonth
        '
        Me.lvMonth.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Month, Me.AgentsB, Me.LiveAppsBattesea, Me.RatioB, Me.AgentsS, Me.LiveS, Me.ColumnHeader7})
        Me.lvMonth.FullRowSelect = True
        Me.lvMonth.GridLines = True
        Me.lvMonth.Location = New System.Drawing.Point(34, 324)
        Me.lvMonth.MultiSelect = False
        Me.lvMonth.Name = "lvMonth"
        Me.lvMonth.Size = New System.Drawing.Size(808, 228)
        Me.lvMonth.TabIndex = 11
        Me.lvMonth.UseCompatibleStateImageBehavior = False
        Me.lvMonth.View = System.Windows.Forms.View.Details
        '
        'Month
        '
        Me.Month.Text = "Month"
        Me.Month.Width = 112
        '
        'AgentsB
        '
        Me.AgentsB.Text = "Agents Days Battersea"
        Me.AgentsB.Width = 125
        '
        'LiveAppsBattesea
        '
        Me.LiveAppsBattesea.Text = "Sat Apps "
        Me.LiveAppsBattesea.Width = 82
        '
        'RatioB
        '
        Me.RatioB.Text = "Ratio"
        '
        'AgentsS
        '
        Me.AgentsS.Text = "Agent Days Sutton"
        Me.AgentsS.Width = 118
        '
        'LiveS
        '
        Me.LiveS.Text = "Live"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Ratio"
        '
        'frmOfficePerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 643)
        Me.Controls.Add(Me.lvMonth)
        Me.Controls.Add(Me.lblRatioB)
        Me.Controls.Add(Me.lblRatioS)
        Me.Controls.Add(Me.lblLiveB)
        Me.Controls.Add(Me.lblLiveS)
        Me.Controls.Add(Me.lblAgentsB)
        Me.Controls.Add(Me.lblAgentsS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.lv)
        Me.Name = "frmOfficePerformance"
        Me.Text = "frmOfficePerformance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents mDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Office As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agents As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Apps As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dead As System.Windows.Forms.ColumnHeader
    Friend WithEvents Live As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ratio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAgentsB As System.Windows.Forms.Label
    Friend WithEvents lblAgentsS As System.Windows.Forms.Label
    Friend WithEvents lblLiveB As System.Windows.Forms.Label
    Friend WithEvents lblLiveS As System.Windows.Forms.Label
    Friend WithEvents lblRatioB As System.Windows.Forms.Label
    Friend WithEvents lblRatioS As System.Windows.Forms.Label
    Friend WithEvents lvMonth As System.Windows.Forms.ListView
    Friend WithEvents Month As System.Windows.Forms.ColumnHeader
    Friend WithEvents AgentsB As System.Windows.Forms.ColumnHeader
    Friend WithEvents LiveAppsBattesea As System.Windows.Forms.ColumnHeader
    Friend WithEvents RatioB As System.Windows.Forms.ColumnHeader
    Friend WithEvents AgentsS As System.Windows.Forms.ColumnHeader
    Friend WithEvents LiveS As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
