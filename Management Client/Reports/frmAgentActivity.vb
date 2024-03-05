Public Class frmAgentActivity
    Dim StartDate As DateTime
    Dim Loading As Boolean = True
    Dim AgentID As Integer = 0
    Private Sub RefreshForm()

        For t As Integer = 0 To 4
            Dim aCtl As ctlEventsDayView
            aCtl = Me.Controls("Day" & t)
            aCtl.SetAgentAndDay(AgentID, StartDate.AddDays(t))
        Next
    End Sub


    Private Sub frmAgnetActivity_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        StartDate = CADNet.CallQueues.Common.GetStartOfWeek(Date.Now)
        Dim RepDS As New DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        RepDS = Database.ExecuteSQL("Select * from Users where (status=2 and userlevelId=" & Common.eUserLevel.Agent & ") or (status=2 and userlevelId=" & Common.eUserLevel.Manager & ")")
        cmbSelectRep.DataSource = RepDS.Tables(0)
        cmbSelectRep.DisplayMember = "RealName"
        cmbSelectRep.ValueMember = "ID"
        cmbSelectRep.SelectedIndex = -1
        Application.DoEvents()
        Loading = False
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnNext.Click
        StartDate = StartDate.AddDays(7)
        RefreshForm()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrev.Click
        StartDate = StartDate.AddDays(-7)
        RefreshForm()
    End Sub


    Private Sub cmbSelectRep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbSelectRep.SelectedIndexChanged
        If Loading Then
        Else
            AgentID = cmbSelectRep.SelectedItem(0)
            RefreshForm()
        End If

    End Sub
End Class