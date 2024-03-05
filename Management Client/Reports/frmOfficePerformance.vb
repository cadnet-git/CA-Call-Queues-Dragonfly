Public Class frmOfficePerformance


    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        Dim DS As DataSet
        Me.Cursor = Cursors.WaitCursor

        Dim Database As CADNet.CallQueues.Common.DataLayer
        lvMonth.Items.Clear()
        Dim Params As Collection
        Dim startdate As DateTime = Now.AddDays(Now.Day - 1)
        For t As Integer = 1 To 6

            startdate = startdate.AddMonths(-1)

            Database = New CADNet.CallQueues.Common.DataLayer
            Params = New Collection
            Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
            parDeskID.Value = startdate.ToLongDateString
            Params.Add(parDeskID)

            Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
            parStatus.Value = startdate.AddMonths(1).ToLongDateString
            Params.Add(parStatus)

            'Dim oApp As cManagerApp = cManagerApp.GetInstance
            'Database.CreateParameter(Params, "@Office", SqlDbType.NVarChar, oApp.Office)


            DS = Database.ExecuteSP("spAgentsToOfficeDaily", Params)
            lv.Items.Clear()
            Dim lvitem As ListViewItem
            For Each arow As DataRow In DS.Tables(0).Rows
                lvitem = New ListViewItem
                Dim d As DateTime = arow("Expr1")
                lvitem.Text = d.ToLongDateString
                lvitem.SubItems.Add("Sutton")
                lvitem.SubItems.Add(arow("Agents"))
                lvitem.SubItems.Add("")

                Dim aDs As DataSet
                Dim sSQL As String = ""
                sSQL = sSQL & " SELECT COUNT(ID) AS Apps"
                sSQL = sSQL & " FROM DiaryItems"
                sSQL = sSQL & " WHERE (Type = 'ca') "
                sSQL = sSQL & " AND (created > '" & d.ToLongDateString & "')"
                sSQL = sSQL & " AND (created < '" & d.AddDays(1).ToLongDateString & "')"
                sSQL = sSQL & " AND (Status < 0)"

                aDs = Database.ExecuteSQL(sSQL)
                Dim Dead As Integer = 0

                If aDs.Tables(0).Rows.Count > 0 Then
                    Dead = aDs.Tables(0).Rows(0).Item("apps")
                End If
                lvitem.SubItems.Add(Dead)

                sSQL = ""
                sSQL = sSQL & " SELECT COUNT(ID) AS apps"
                sSQL = sSQL & " FROM DiaryItems"
                sSQL = sSQL & " WHERE (Type = 'ca') "
                sSQL = sSQL & " AND (created > '" & d.ToLongDateString & "')"
                sSQL = sSQL & " AND (created < '" & d.AddDays(1).ToLongDateString & "')"
                sSQL = sSQL & " AND (Status > - 1)"

                aDs = Database.ExecuteSQL(sSQL)
                Dim Live As Integer = 0

                If aDs.Tables(0).Rows.Count > 0 Then
                    Live = aDs.Tables(0).Rows(0).Item("apps")
                End If
                lvitem.SubItems.Add(Live)

                lvitem.SubItems(3).Text = Live + Dead
                lvitem.SubItems.Add(CInt((Live / lvitem.SubItems(2).Text) * 100) / 100)


                lv.Items.Add(lvitem)
            Next
            Dim agentsB As Integer = 0
            Dim agentsS As Integer = 0
            Dim liveB As Integer = 0
            Dim liveS As Integer = 0
            For Each lvi As ListViewItem In lv.Items
                If lvi.SubItems(1).Text = "Sutton" Then
                    agentsS = agentsS + lvi.SubItems(2).Text
                    liveS = liveS + lvi.SubItems(5).Text
                Else
                    agentsB = agentsB + lvi.SubItems(2).Text
                    liveB = liveB + lvi.SubItems(5).Text
                End If
            Next
            lvitem = New ListViewItem
            lvitem.Text = Format(startdate, "MMMM yyyy")
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(agentsS)
            lvitem.SubItems.Add(liveS)
            lvitem.SubItems.Add(CInt((liveS / agentsS) * 100) / 100)
            lvitem.UseItemStyleForSubItems = False
            If CDbl(lvitem.SubItems(3).Text) < CDbl(lvitem.SubItems(6).Text) Then
                lvitem.SubItems(6).BackColor = Color.Coral
            Else
                lvitem.SubItems(3).BackColor = Color.Coral
            End If

            Me.lvMonth.Items.Add(lvitem)
        Next
        Me.Cursor = Cursors.Default
    End Sub


End Class