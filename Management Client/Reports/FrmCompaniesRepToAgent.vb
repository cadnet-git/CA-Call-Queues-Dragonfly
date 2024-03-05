Public Class FrmCompaniesRepToAgent

    Dim isloading As Boolean

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
        DS = database.ExecuteSQL("Select ID,realname from users where (userlevelid=2 or userlevelid=3) and status=2 order by realname")
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
                database.CreateParameter(params, "@AgentID", SqlDbType.Int, aTree.SelectedNode.Tag)
                Ds = database.ExecuteSP("spGetReptoAgent", params)
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
End Class