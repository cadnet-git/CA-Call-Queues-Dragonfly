Public Class FrmCompaniesAgentsToReps

    Dim isloading As Boolean
    Dim SelectRepID As Integer = 0
    Dim OldAgentID As Integer = 0
    Dim NewAgentId As Integer = 0
    Dim OldAgentStr As String = ""
    Dim NewAgentStr As String = ""
    Private Sub FrmCompaniesAgentsToReps_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        isloading = False
    End Sub
    Private Sub FrmCompaniesAgentsToReps_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Application.DoEvents()
        isloading = True
        RefreshForm()
        Application.DoEvents()

    End Sub
    Private Sub RefreshForm()

        Me.lblSelectedRep.Text = ""
        Dim database As New Common.DataLayer
        Dim DS As DataSet
        Dim Anode As TreeNode
        DS = database.ExecuteSQL("Select ID,realname from users where userlevelid=4 and status=2 order by realname")
        For Each dr As DataRow In DS.Tables(0).Rows
            Anode = New TreeNode
            Anode.Tag = dr("ID")
            Anode.Text = dr("Realname")
            Tree.Nodes.Add(Anode)

        Next
        Tree.SelectedNode = Nothing
    End Sub


    Private Sub Tree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Tree.AfterSelect
        If Not isloading Then
            Dim aTree As TreeView = sender
            If aTree.SelectedNode.Tag <> -1 Then
                aTree.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                ' this is a rep
                Dim database As New Common.DataLayer
                Dim Ds As DataSet
                Dim params As New Collection
                SelectRepID = aTree.SelectedNode.Tag()
                database.CreateParameter(params, "@RepID", SqlDbType.Int, aTree.SelectedNode.Tag)
                Ds = database.ExecuteSP("spGetAgentToRep", params)
                Dim lvitem As ListViewItem
                Me.lblSelectedRep.Text = aTree.SelectedNode.Text
                Me.LVGrid.Items.Clear()
                For Each dr As DataRow In Ds.Tables(0).Rows
                    lvitem = New ListViewItem
                    lvitem.Text = dr("ID").ToString & " "
                    lvitem.SubItems.Add(dr("RealName").ToString)
                    lvitem.SubItems.Add(dr("Records").ToString)
                    lvitem.SubItems.Add("")
                    Me.LVGrid.Items.Add(lvitem)
                Next

                For Each dr As DataRow In Ds.Tables(1).Rows
                    lvitem = LVGrid.FindItemWithText(dr("ID") & " ")
                    lvitem.SubItems(3).Text = dr("Records").ToString
                Next
                aTree.Enabled = True
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ReallocateOverdueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ReallocateOverdueToolStripMenuItem.Click
        Dim afrm As New frmSelectUser

        If afrm.ShowDialog = DialogResult.OK Then
            NewAgentId = afrm.lvAll.SelectedItems(0).Text
            NewAgentStr = afrm.lvAll.SelectedItems(0).SubItems(1).Text
            If MsgBox("Transfer " & OldAgentStr & "'s Overdue to " & NewAgentStr, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim database As New Common.DataLayer
                Dim Ds As DataSet
                Dim ssql As String = ""
                ssql = "SELECT  Companies.ID, Areas.RepID, Companies.AgentID FROM  PostCodePrefixes"
                ssql = ssql & " INNER JOIN Areas ON PostCodePrefixes.AreaID = Areas.ID "
                ssql = ssql & " INNER JOIN Companies ON PostCodePrefixes.ID = Companies.PostCodeID"
                ssql = ssql & " WHERE  (Areas.RepID = " & SelectRepID & ") "
                ssql = ssql & " AND (Companies.AgentID = " & OldAgentID & ") "
                ssql = ssql & " AND (CAST(Companies.HoldUntil AS datetime) < GETDATE()) AND (Companies.AllowCall = 1)"
                Ds = database.ExecuteSQL(ssql)
                Dim rs As DataSet
                For Each arow As DataRow In Ds.Tables(0).Rows
                    ssql = "Update Companies SET AgentId=" & NewAgentId & " Where ID= " & arow("ID")
                    rs = database.ExecuteSQL(ssql)
                Next
                refreshList()
            End If
        End If
    End Sub

    Private Sub CM1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CM1.Opening
        If LVGrid.SelectedItems.Count = 1 Then
            ' ok 
            OldAgentID = LVGrid.SelectedItems(0).Text.Trim
            OldAgentStr = LVGrid.SelectedItems(0).SubItems(1).Text
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub refreshList()

        Me.Cursor = Cursors.WaitCursor
        ' this is a rep
        Dim database As New Common.DataLayer
        Dim Ds As DataSet
        Dim params As New Collection
        database.CreateParameter(params, "@RepID", SqlDbType.Int, SelectRepID)
        Ds = database.ExecuteSP("spGetAgentToRep", params)
        Dim lvitem As ListViewItem
        Me.LVGrid.Items.Clear()
        For Each dr As DataRow In Ds.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = dr("ID").ToString & " "
            lvitem.SubItems.Add(dr("RealName").ToString)
            lvitem.SubItems.Add(dr("Records").ToString)
            lvitem.SubItems.Add("")
            Me.LVGrid.Items.Add(lvitem)
        Next

        For Each dr As DataRow In Ds.Tables(1).Rows
            lvitem = LVGrid.FindItemWithText(dr("ID") & " ")
            lvitem.SubItems(3).Text = dr("Records").ToString
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ReallocateAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ReallocateAllToolStripMenuItem.Click
        Dim afrm As New frmSelectUser

        If afrm.ShowDialog = DialogResult.OK Then
            NewAgentId = afrm.lvAll.SelectedItems(0).Text
            ' MsgBox("Rep = " & Me.SelectRepID & " OldAgentID = " & OldAgentID & " NewAgentID = " & NewAgentId)
            If MsgBox("Transfer all" & OldAgentStr & "'s records to " & NewAgentStr, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then



                Dim database As New Common.DataLayer
                Dim Ds As DataSet
                Dim ssql As String = ""
                ssql = "SELECT  Companies.ID, Areas.RepID, Companies.AgentID FROM  PostCodePrefixes"
                ssql = ssql & " INNER JOIN Areas ON PostCodePrefixes.AreaID = Areas.ID "
                ssql = ssql & " INNER JOIN Companies ON PostCodePrefixes.ID = Companies.PostCodeID"
                ssql = ssql & " WHERE  (Areas.RepID = " & SelectRepID & ") "
                ssql = ssql & " AND (Companies.AgentID = " & OldAgentID & ") "
                ssql = ssql & " AND (Companies.AllowCall = 1)"
                Ds = database.ExecuteSQL(ssql)
                Dim rs As DataSet
                For Each arow As DataRow In Ds.Tables(0).Rows
                    ssql = "Update Companies SET AgentId=" & NewAgentId & " Where ID= " & arow("ID")
                    rs = database.ExecuteSQL(ssql)
                Next
                refreshList()
            End If
        End If
    End Sub
End Class