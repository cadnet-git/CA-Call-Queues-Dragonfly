Public Class FrmUserStats


    Private Enum Cols
        AreaID
        Title
        Records
        OverDueCallbacks
        OverDueColdCalls
        Appointment
        Sale
        Callback
        ColdCall
        NotToHand
        Supervisor
        NotANumber
        OutOfArea
        Gone
    End Enum
    Private Sub FrmAreaStats_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load





    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Refreshform()
    End Sub
    Private Sub Refreshform()
        Me.Cursor = Cursors.WaitCursor
        Dim ado As New Common.DataLayer
        Dim DS As DataSet
        Dim LVitem As ListViewItem
        Dim sSQL As String = ""
        lvwAreas.SuspendLayout()

        DS = ado.ExecuteSQL("Select ID,RealName from Users Where UserLevelID =2 or userlevelID=3 order by UserlevelID, realname")
        lvwAreas.Items.Clear()
        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("ID")
            LVitem.SubItems.Add(Common.StringManipulation.TitleCase(DR("RealName")))
            For t As Integer = 1 To 12
                LVitem.SubItems.Add("0")
            Next
            lvwAreas.Items.Add(LVitem)
        Next
        PBar.Value = 0
        PBar.Maximum = lvwAreas.Items.Count
        PBar.Visible = True
        TBLabel.Visible = True
        For Each LVitem In lvwAreas.Items
            PBar.Value = PBar.Value + 1


            Dim params As New Collection
            ado.CreateParameter(params, "@AgentID", SqlDbType.Int, LVitem.Text)
            DS = ado.ExecuteSP("spGetCompaniesToAgent", params)
            Try
                For Each DR As DataRow In DS.Tables(0).Rows
                    Select Case DR("CompanyStatus")
                        Case "CallBack"
                            LVitem.SubItems(Cols.OverDueCallbacks).Text = LVitem.SubItems(Cols.OverDueCallbacks).Text + DR("Total")
                        Case Else
                            LVitem.SubItems(Cols.OverDueColdCalls).Text = LVitem.SubItems(Cols.OverDueColdCalls).Text + DR("Total")
                    End Select
                Next
            Catch ex As Exception

            End Try


            For Each DR As DataRow In DS.Tables(1).Rows
                Select Case DR("CompanyStatus")
                    Case "Appointment"
                        LVitem.SubItems(Cols.Appointment).Text = LVitem.SubItems(Cols.Appointment).Text + DR("Total")
                    Case "CallBack"
                        LVitem.SubItems(Cols.Callback).Text = LVitem.SubItems(Cols.Callback).Text + DR("Total")
                    Case "ColdCall"
                        LVitem.SubItems(Cols.ColdCall).Text = LVitem.SubItems(Cols.ColdCall).Text + DR("Total")
                    Case "Sale"
                        LVitem.SubItems(Cols.Sale).Text = LVitem.SubItems(Cols.Sale).Text + DR("Total")
                    Case "Supervisor"
                        LVitem.SubItems(Cols.Supervisor).Text = LVitem.SubItems(Cols.Supervisor).Text + DR("Total")
                    Case "OutOfArea"
                        LVitem.SubItems(Cols.OutOfArea).Text = LVitem.SubItems(Cols.OutOfArea).Text + DR("Total")
                    Case "NotToHand"
                        LVitem.SubItems(Cols.NotToHand).Text = LVitem.SubItems(Cols.NotToHand).Text + DR("Total")
                    Case "InvalidNumber"
                        LVitem.SubItems(Cols.NotANumber).Text = LVitem.SubItems(Cols.NotANumber).Text + DR("Total")

                End Select
                LVitem.SubItems(Cols.Records).Text = LVitem.SubItems(Cols.Records).Text + DR("Total")


            Next


            For t As Integer = 2 To 12
                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next

        Next
        For Each LVitem In lvwAreas.Items
            If LVitem.SubItems(Cols.Records).Text = "" Then
                LVitem.Remove()
            End If
        Next
        lvwAreas.ResumeLayout()
        PBar.Visible = False
        TBLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub ODCallBacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ODCallBacksToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim howmany As Integer = InputBox("Enter ammount you would like to allocate", "Ammount to Allocate", "500")

            Dim msg As String
            msg = String.Format("You are about to move {0} records  of {1}'s OD Callbacks to {2}", howmany, lvwAreas.SelectedItems(0).SubItems(1).Text, vbCrLf)
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 

                Dim DS As DataSet
                Dim Database As New Common.DataLayer

                Dim ssql As String
                '     ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") AND (HoldUntil < CONVERT(Datetime, '" & Now.ToLongDateString & " " & Now.ToLongTimeString & "')) and (CompanyStatus = 'CallBack')"
                ssql = String.Format("SELECT  top(" & howmany & ") c.Id  FROM  Companies c INNER JOIN PostCodePrefixes pc ON c.PostCodeID = pc.ID LEFT OUTER JOIN Areas a on a.ID = pc.AreaID  WHERE (c.AgentID = {0}) and (c.CompanyStatus = 'CallBack') AND (c.HoldUntil < CONVERT(Datetime, '" & Now.ToLongDateString & " " & Now.ToLongTimeString & "')) and a.repid is not null", lvwAreas.SelectedItems(0).Text)

                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If

        End If
    End Sub
    Private Sub AllocateRecords(ByVal DS As DataSet, ByVal agents As Collection)
        Dim agentsmax As Integer = agents.Count + 1
        Dim nextagent As Integer = 1
        Dim ado As New Common.DataLayer

        Try
            panelmoving.Visible = True
            lblCounter.Text = DS.Tables(0).Rows.Count
            Application.DoEvents()

            For Each DR As DataRow In DS.Tables(0).Rows

                Dim c As Common.cCompany = New Common.cCompany(DR("ID"))
                c.AgentID = agents(nextagent)
                c.Notes = ""
                Dim app As cManagerApp = cManagerApp.GetInstance
                app.AddManagerNote("Company Reallocated to Agent", c.ID, c.AgentID)
                c.Save()

                c.HideHistory()

                lblCounter.Text = lblCounter.Text - 1
                Application.DoEvents()
                nextagent += 1
                If nextagent = agentsmax Then
                    nextagent = 1
                End If
            Next

        Catch ex As Exception
            MsgBox("error in allocate Records" & vbCrLf & vbCrLf & ex.Message)
        End Try
        panelmoving.Visible = False
    End Sub

    Private Sub ODColdCallsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ODColdCallsToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim msg As String
            msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s OD Cold Calls to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") AND (HoldUntil < CONVERT(Datetime, '" & Now.ToLongDateString & " " & Now.ToLongTimeString & "')) and (CompanyStatus = 'ColdCall')"
                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If

        End If
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AppointmentsToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim msg As String
            msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Appointments to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'Appointment')"
                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If

        End If
    End Sub

    Private Sub CallbacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CallbacksToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim howmany As Integer = InputBox("Enter ammount you would like to allocate", "Ammount to Allocate", "500")

            Dim msg As String
            msg = "You are about to move " & howmany & " records  of " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Callbacks to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                '  ssql = "SELECT top(" & howmany & ") Id  FROM  Companies WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'CallBack')"

                ssql = String.Format("SELECT  top(" & howmany & ") c.Id  FROM  Companies c RIGHT OUTER JOIN PostCodePrefixes pc ON c.PostCodeID = pc.ID LEFT OUTER JOIN Areas a on a.ID = pc.AreaID  WHERE (c.AgentID = {0}) and (c.CompanyStatus = 'CallBack')  and a.repid is not null", lvwAreas.SelectedItems(0).Text)

                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If

        End If
    End Sub

    Private Sub ColdCallsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ColdCallsToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        afrm.btnColdPot.Visible = True

        Dim dr As DialogResult = afrm.ShowDialog
        If dr = DialogResult.Yes Then
            ' this returns records to cold pot

            Dim msg As String
            msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Cold Calls to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'ColdCall')"
                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If
        Else
            If dr = DialogResult.OK Then
                Dim msg As String
                msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Cold Calls to " & vbCrLf
                Dim agents As New Collection
                For Each lvitem As ListViewItem In afrm.lvSelected.Items
                    agents.Add(lvitem.Text)
                    msg = msg & vbCrLf & lvitem.SubItems(1).Text
                Next
                msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    ' do it 
                    Dim DS As DataSet
                    Dim Database As New Common.DataLayer
                    Dim ssql As String
                    ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'ColdCall')"
                    DS = Database.ExecuteSQL(ssql)
                    AllocateRecords(DS, agents)
                    Refreshform()
                End If
            End If
        End If
    End Sub

    Private Sub NotToHandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotToHandsToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim msg As String
            msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Not to Hands to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'NotToHand')"
                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)

                Refreshform()
            End If

        End If
    End Sub

    Private Sub ParkDeadCompaniesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ParkDeadCompaniesToolStripMenuItem.Click
        If MsgBox("You are about to park all dead records for " & lvwAreas.SelectedItems(0).SubItems(1).Text & vbCrLf & vbCrLf & "Press OK to confirm", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim ado As New Common.DataLayer
            Dim ssql As String = ""
            ssql = "Update companies set agentid=1000000 where ((companyStatus='TPS') or (companyStatus='Supervisor') or (companyStatus='OutOfArea')or (companyStatus='InvalidNumber')) and AgentID=" & lvwAreas.SelectedItems(0).Text
            ado.ExecuteSQL(ssql)
            Refreshform()
        End If

    End Sub

    Private Sub CheckCallBacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CheckCallBacksToolStripMenuItem.Click
        Dim afrm As New frmCheckCallbacks(lvwAreas.SelectedItems(0).Text)
        afrm.lbltitle.Text = "Callbacks for " & lvwAreas.SelectedItems(0).SubItems(1).Text
        afrm.ShowDialog()
    End Sub


    Private Sub RetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles RetToolStripMenuItem.Click
        If MsgBox(String.Format("You are about to Return all ColdCall records for {0} to the Cold Call pot{1}{1}Press OK to confirm", lvwAreas.SelectedItems(0).SubItems(1).Text, vbCrLf), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim ado As New Common.DataLayer
            Dim ssql As String = ""
            ssql = String.Format("UPDATE    CompanyHistory  SET  Hide = 1 WHERE (CompanyID IN  (SELECT     ID AS CompanyID  FROM  Companies  WHERE  companyStatus='ColdCall' and AgentID = {0}))", lvwAreas.SelectedItems(0).Text)
            ado.ExecuteSQL(ssql)
            ssql = "Update companies set agentid=0 where companyStatus='ColdCall' and AgentID=" & lvwAreas.SelectedItems(0).Text
            ado.ExecuteSQL(ssql)
            Refreshform()
        End If
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            Dim msg As String
            msg = "You are about to move " & lvwAreas.SelectedItems(0).SubItems(1).Text & "'s Sales to " & vbCrLf
            Dim agents As New Collection
            For Each lvitem As ListViewItem In afrm.lvSelected.Items
                agents.Add(lvitem.Text)
                msg = msg & vbCrLf & lvitem.SubItems(1).Text
            Next
            msg = msg & vbCrLf & vbCrLf & "Press OK to confirm"
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                ' do it 
                Dim DS As DataSet
                Dim Database As New Common.DataLayer
                Dim ssql As String
                ssql = "SELECT  Id  FROM   Companies  WHERE (Companies.AgentID = " & lvwAreas.SelectedItems(0).Text & ") and (CompanyStatus = 'Sale')"
                DS = Database.ExecuteSQL(ssql)
                AllocateRecords(DS, agents)
                Refreshform()
            End If

        End If
    End Sub
End Class