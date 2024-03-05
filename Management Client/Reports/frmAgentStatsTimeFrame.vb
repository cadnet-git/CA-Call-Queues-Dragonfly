Public Class frmAgentStatsTimeFrame
    Dim StartDate As DateTime
    Dim endDate As DateTime
    Dim Agents As Collection
    Dim Agent As cAgentStats
    Private Sub frmDailyStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        StartDate = Now.ToLongDateString & " 00:00:00"
        endDate = StartDate.AddDays(1)
        EndDP.Value = endDate
        DTP1.Value = Now

    End Sub
    Private Sub RefreshStats()
        Me.Cursor = Cursors.WaitCursor
        Dim DS As DataSet
        Agents = New Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parDeskID.Value = StartDate
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parStatus.Value = endDate
        Params.Add(parStatus)

        DS = Database.ExecuteSP("SpGetStats", Params)

        progress.Value = 0
        progress.Maximum = DS.Tables(0).Rows.Count


        For Each DR As DataRow In DS.Tables(0).Rows
            progress.Value += 1
            Try
                Agent = Agents(DR("UserID").ToString)
            Catch ex As Exception
                Agent = New cAgentStats
                Agent.AgentID = DR("userID")
                Agent.Agent = DR("RealName")
                Agents.Add(Agent, Agent.AgentID.ToString)
            End Try

            Agent.AddRec(DR)
        Next

        If ShowAsPercent.Checked Then
            Me.RefreshPercent()
        Else
            Me.RefreshNumbers()
        End If

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub RefreshNumbers()
        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        Dim lvTotal As ListViewItem = New ListViewItem
        lvTotal.BackColor = Color.AliceBlue
        lvTotal.Text = "aaa"
        lvTotal.SubItems.Add("Total")
        LVStats.Items.Add(lvTotal)
        For x As Integer = 2 To 12
            lvTotal.SubItems.Add("0")
        Next

        For Each Agent In Agents
            LVitem = New ListViewItem
            ' update screen
            LVitem.Text = Agent.Agent
            LVitem.SubItems.Add(Agent.Agent)
            LVitem.SubItems.Add(Format(Agent.Calls, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.NewCalls, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.Appointment, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.Callback, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.Reschedule, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.NottoHand, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.NotInterested, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.Supervisor, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.OutofArea, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.TPS, "#,###,##0"))
            LVitem.SubItems.Add(Format(Agent.NumberNotRecognised, "#,###,##0"))
            For t As Integer = 2 To 12

                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                Else
                    lvTotal.SubItems(t).Text = Format(CInt(lvTotal.SubItems(t).Text) + CInt(LVitem.SubItems(t).Text), "#,###,##0")
                End If
            Next
            LVStats.Items.Add(LVitem)
        Next

    End Sub
    Private Sub RefreshPercent()
        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        Dim aTotal As New cAgentStats

        Dim lvTotal As ListViewItem = New ListViewItem
        lvTotal.BackColor = Color.AliceBlue
        lvTotal.Text = "aaa"
        lvTotal.SubItems.Add("Total")
        LVStats.Items.Add(lvTotal)
        For x As Integer = 2 To 14
            lvTotal.SubItems.Add("0")
        Next

        For Each Agent In Agents
            LVitem = New ListViewItem
            ' update screen

            LVitem.Text = Agent.Agent
            LVitem.SubItems.Add(Agent.Agent)
            LVitem.SubItems.Add(Format(Agent.Calls, "#,###,##0"))
            aTotal.Calls = aTotal.Calls + Agent.Calls

            LVitem.SubItems.Add(Format(Agent.PercentNewCalls, "#0.0"))
            aTotal.NewCalls = aTotal.NewCalls + Agent.NewCalls

            LVitem.SubItems.Add(Format(Agent.PercentAppointments, "#0.0"))
            aTotal.Appointment = aTotal.Appointment + Agent.Appointment
            LVitem.SubItems.Add(Format(Agent.PercentCallbacks, "#0.0"))
            aTotal.Callback = aTotal.Callback + Agent.Callback
            LVitem.SubItems.Add(Format(Agent.PercentRescheduled, "#0.0"))
            aTotal.Reschedule = aTotal.Reschedule + Agent.Reschedule
            LVitem.SubItems.Add(Format(Agent.PercentNottoHand, "#0.0"))
            aTotal.NottoHand = aTotal.NottoHand + Agent.NottoHand
            LVitem.SubItems.Add(Format(Agent.PercentNotInterested, "#0.0"))
            aTotal.NotInterested = aTotal.NotInterested + Agent.NotInterested
            LVitem.SubItems.Add(Format(Agent.PercentSupervisor, "#0.0"))
            aTotal.Supervisor = aTotal.Supervisor + Agent.Supervisor
            LVitem.SubItems.Add(Format(Agent.PercentOutofArea, "#0.0"))
            aTotal.OutofArea = aTotal.OutofArea + Agent.OutofArea
            LVitem.SubItems.Add(Format(Agent.PercentTPS, "#0.0"))
            aTotal.TPS = aTotal.TPS + Agent.TPS
            LVitem.SubItems.Add(Format(Agent.PercentNumberNotRecognised, "#0.0"))
            aTotal.NumberNotRecognised = aTotal.NumberNotRecognised + Agent.NumberNotRecognised
            For t As Integer = 2 To 12
                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next

            LVStats.Items.Add(LVitem)
        Next
        lvTotal.SubItems(2).Text = Format(aTotal.Calls, "#,###,##0")
        lvTotal.SubItems(3).Text = Format(aTotal.PercentNewCalls, "#0.0")
        lvTotal.SubItems(4).Text = Format(aTotal.PercentAppointments, "#0.0")
        lvTotal.SubItems(5).Text = Format(aTotal.PercentCallbacks, "#0.0")
        lvTotal.SubItems(6).Text = Format(aTotal.PercentRescheduled, "#0.0")
        lvTotal.SubItems(7).Text = Format(aTotal.PercentNottoHand, "#0.0")
        lvTotal.SubItems(8).Text = Format(aTotal.PercentNotInterested, "#0.0")
        lvTotal.SubItems(9).Text = Format(aTotal.PercentSupervisor, "#0.0")
        lvTotal.SubItems(10).Text = Format(aTotal.PercentOutofArea, "#0.0")
        lvTotal.SubItems(11).Text = Format(aTotal.PercentTPS, "#0.0")
        lvTotal.SubItems(12).Text = Format(aTotal.PercentNumberNotRecognised, "#0.0")

        'Dim LVitem As ListViewItem
        'LVStats.Items.Clear()

        'Dim lvTotal As ListViewItem = New ListViewItem
        'lvTotal.BackColor = Color.AliceBlue
        'lvTotal.Text = "aaa"
        'lvTotal.SubItems.Add("Total")
        'LVStats.Items.Add(lvTotal)
        'For x As Integer = 2 To 12
        '    lvTotal.SubItems.Add("0")
        'Next

        'For Each Agent In Agents
        '    LVitem = New ListViewItem
        '    ' update screen

        '    LVitem.Text = Agent.Agent
        '    LVitem.SubItems.Add(Agent.Agent)
        '    LVitem.SubItems.Add(Format(Agent.Calls, "#,###,##0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentNewCalls, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentAppointments, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentCallbacks, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentRescheduled, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentNottoHand, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentNotInterested, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentSupervisor, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentOutofArea, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentTPS, "#0.0"))
        '    LVitem.SubItems.Add(Format(Agent.PercentNumberNotRecognised, "#0.0"))

        '    For t As Integer = 2 To 12

        '        If LVitem.SubItems(t).Text = 0 Then
        '            LVitem.SubItems(t).Text = ""
        '        Else
        '            lvTotal.SubItems(t).Text = Format(CInt(lvTotal.SubItems(t).Text) + CInt(LVitem.SubItems(t).Text), "#,###,##0")
        '        End If
        '    Next

        '    LVStats.Items.Add(LVitem)
        'Next

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DTP1.ValueChanged
        StartDate = DTP1.Value.ToLongDateString & " 00:00:00"
    End Sub

    Private Sub pnlAreaHeader_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAreaHeader.Paint

    End Sub

    Private Sub ShowAsPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ShowAsPercent.CheckedChanged
        Application.DoEvents()
        If ShowAsPercent.Checked Then
            Me.RefreshPercent()
        Else
            Me.RefreshNumbers()
        End If
    End Sub

    Private Sub TPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TPSToolStripMenuItem.Click

        ShowDetails("TPS", "TPS")
    End Sub

    Private Sub OutOfAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OutOfAreaToolStripMenuItem.Click
        ShowDetails("Out of Area", "OutOfArea")
    End Sub




    Private Sub ShowDetails(ByVal Title As String, ByVal type As String)
        Me.Cursor = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim dFrm As New frmStatsDrillDown
        dFrm.TopLevel = False

        dFrm.lblType.Text = Title ' what displays 
        dFrm.LBLuser.Text = Me.LVStats.SelectedItems(0).SubItems(1).Text
        dFrm.LoadData(type, Me.LVStats.SelectedItems(0).SubItems(0).Text, StartDate, endDate)

        Me.Parent.Controls.Add(dFrm)
        Me.Hide()
        With dFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With
        Me.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SupervisorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SupervisorToolStripMenuItem.Click
        ShowDetails("Supervisor Attention", "Supervisor")
    End Sub

    Private Sub NotInterestedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotInterestedToolStripMenuItem.Click
        ShowDetails("Not Interested", "NotInterested")
    End Sub

    Private Sub NotANumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotANumberToolStripMenuItem.Click

        ShowDetails("Not a Number", "NumberNotRecognised")
    End Sub

    Private Sub Lists_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lists.Opening
        If Me.LVStats.SelectedItems.Count > 0 Then

            If LVStats.SelectedItems(0).SubItems(2).Text = "" Then
                ' no agent
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AppointmentsToolStripMenuItem.Click

    End Sub

    Private Sub EndDP_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EndDP.ValueChanged
        endDate = EndDP.Value.ToLongDateString & " 23:59:59"
    End Sub


End Class



