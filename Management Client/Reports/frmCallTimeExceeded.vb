Public Class frmCallTimeExceeded

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


        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parDeskID.Value = StartDate
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parStatus.Value = endDate
        Params.Add(parStatus)

        DS = Database.ExecuteSP("spGetExceededCallTimes", Params)

        progress.Value = 0
        progress.Maximum = DS.Tables(0).Rows.Count
        LVStats.Items.Clear()
        For Each DR As DataRow In DS.Tables(0).Rows
            LVStats.Items.Add(New ListViewItem(New String() {DR("AgentID").ToString, DR("Realname").ToString, DR("Qty").ToString}))
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DTP1.ValueChanged
        StartDate = DTP1.Value.ToLongDateString & " 00:00:00"
    End Sub

    Private Sub EndDP_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EndDP.ValueChanged
        endDate = EndDP.Value.ToLongDateString & " 23:59:59"
    End Sub

End Class