Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Utils
Imports DevExpress.XtraBars.Controls

Public Class frmInformationPoints

    Dim mySelectedNode As TreeNode

#Region "Methods"

    Public Sub RefreshForm()

        tvInfo.Nodes.Clear()

        Dim headerNode As TreeNode
        Dim itemNode As TreeNode
        Dim nodeText As String

        Dim db As New Common.DataLayer
        Dim ds As DataSet = db.ExecuteSQL("Select * from InfoCategories order by sortorder")

        For Each arow As DataRow In ds.Tables(0).Rows
            Dim aCat As New InfoCategory(arow)
            headerNode = tvInfo.Nodes.Add(aCat.Title)
            headerNode.Tag = aCat

            nodeText = If(String.IsNullOrWhiteSpace(arow("Title").ToString), "<no title>", aCat.Title)
            headerNode.Text = nodeText

            '  Dim listItems As List(Of InfoItem) = db.InfoItems.Where(Function(c) c.CategoryID = InfoCategory.ID).OrderBy(Function(c) c.SortOrder).ToList
            Dim rs As DataSet = db.ExecuteSQL("Select * from InfoItems where CategoryID = " & aCat.ID)

            For Each srow As DataRow In rs.Tables(0).Rows
                Dim aitem As New InfoPoint(srow)
                nodeText = If(String.IsNullOrWhiteSpace(srow("Title")), "<no title>", srow("Title"))
                itemNode = headerNode.Nodes.Add(nodeText)
                itemNode.NodeFont = New Font(tvInfo.Font, FontStyle.Regular)
                itemNode.Tag = aitem
            Next
        Next

        tvInfo.ExpandAll()

    End Sub
#End Region

#Region "Events"

    Private Sub tvInfo_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvInfo.AfterSelect
        Dim node As TreeNode = tvInfo.SelectedNode

        If isHeader(node) Then
            lcEditor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            txtEditor.Enabled = False
            txtEditor.Text = ""
            lcCancel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lcSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            Return
        Else
            lcEditor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            txtEditor.Enabled = True
            lcCancel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lcSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        End If


        txtEditor.RtfText = node.Tag.Data

    End Sub

    Private Sub DisableBars()
        For Each b As Bar In BarManager1.Bars
            DirectCast(DirectCast(b, IDockableObject).BarControl, DockedBarControl).Enabled = False 'Not DirectCast(DirectCast(b, IDockableObject).BarControl, DockedBarControl).Enabled
        Next
    End Sub

    Private Sub EnableBars()
        For Each b As Bar In BarManager1.Bars

            DirectCast(DirectCast(b, IDockableObject).BarControl, DockedBarControl).Enabled = True 'Not DirectCast(DirectCast(b, IDockableObject).BarControl, DockedBarControl).Enabled
        Next
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        If ItemChanged() AndAlso MessageBox.Show("Discard Changes", "Are you sure you want to discard your changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtEditor.RtfText = tvInfo.SelectedNode.Tag.Data
        End If

    End Sub




    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim ip As InfoPoint = tvInfo.SelectedNode.Tag
        ip.Data = txtEditor.RtfText
        ip.Save()
        txtEditor.Focus()
    End Sub

    Private Function ItemChanged() As Boolean
        If txtEditor.RtfText <> tvInfo.SelectedNode.Tag.Data Then
            Return True
        End If
        Return False
    End Function

    Private Function isHeader(ByVal node As TreeNode) As Boolean
        If TypeOf node.Tag Is InfoPoint Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub barDockControlTop_Enter(sender As System.Object, e As EventArgs) Handles barDockControlTop.Enter
        EnableBars()
    End Sub

    Private Sub barDockControlTop_Leave(sender As Object, e As EventArgs) Handles barDockControlTop.Leave
        DisableBars()
    End Sub
    Private Sub txtEditor_Leave(sender As Object, e As EventArgs) Handles txtEditor.Leave
        DisableBars()
    End Sub

    Private Sub txtEditor_Enter(sender As System.Object, e As EventArgs) Handles txtEditor.Enter
        EnableBars()
    End Sub


    Private Sub txtEditor_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtEditor.ModifiedChanged
        If ItemChanged() Then
            btnCancel.Enabled = True
            btnSave.Enabled = True
        Else
            btnCancel.Enabled = False
            btnSave.Enabled = False
        End If
    End Sub

    ' Get the tree node under the mouse pointer and
    ' save it in the mySelectedNode variable. 

    Private Sub treeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvInfo.MouseDown

        mySelectedNode = tvInfo.GetNodeAt(e.X, e.Y)

        If e.Button = MouseButtons.Right Then
            ctmTreeView.Show(tvInfo.MousePosition)
        End If
    End Sub

    Dim editingNode As Boolean = False
    Private Sub treeView1_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles tvInfo.AfterLabelEdit

        If editingNode Then

            If Not (e.Label Is Nothing) Then
                If e.Label.Length > 0 Then
                    If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
                        ' Stop editing without canceling the label change.
                        e.Node.EndEdit(False)

                        If isHeader(mySelectedNode) Then
                            Dim aitem As InfoCategory = mySelectedNode.Tag
                            aitem.Title = e.Label
                            aitem.Save()
                        Else
                            Dim aitem As InfoPoint = mySelectedNode.Tag
                            aitem.Title = e.Label
                            aitem.Save()
                        End If
                    Else
                        ' Cancel the label edit action, inform the user, and
                        ' place the node in edit mode again. 
                        e.CancelEdit = True
                        MessageBox.Show("Invalid tree node label." &
                          Microsoft.VisualBasic.ControlChars.Cr &
                          "The invalid characters are: '@','.', ',', '!'",
                          "Node Label Edit")
                        e.Node.BeginEdit()
                    End If
                Else
                    ' Cancel the label edit action, inform the user, and
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." &
                      Microsoft.VisualBasic.ControlChars.Cr &
                      "The label cannot be blank", "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            End If

            editingNode = False
            ' RefreshForm()
        End If
    End Sub

#End Region

#Region "Context Menu"

    Private Sub ctmTreeView_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctmTreeView.Opening
        If tvInfo.Nodes.Count = 0 Or mySelectedNode Is Nothing Then
            mnuDelete.Visible = False
            mnuMoveUp.Visible = False
            mnuMoveDown.Visible = False
            mnuAddItem.Visible = False
            mnuEditTitle.Visible = False

        Else
            mnuEditTitle.Visible = True
            mnuAddItem.Visible = True
            mnuDelete.Visible = mySelectedNode.Nodes.Count = 0
            mnuMoveUp.Visible = mySelectedNode.Index > 0
            If isHeader(mySelectedNode) Then
                mnuMoveDown.Visible = (Not mySelectedNode.Index = tvInfo.Nodes.Count - 1)
            Else
                mnuMoveDown.Visible = (Not mySelectedNode.Index = mySelectedNode.Parent.Nodes.Count - 1)
            End If
        End If


    End Sub

    Private Sub mnuEditTitle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuEditTitle.Click
        If Not (mySelectedNode Is Nothing) Then 'And Not (mySelectedNode.Parent Is Nothing) Then
            tvInfo.SelectedNode = mySelectedNode
            tvInfo.LabelEdit = True

            If Not mySelectedNode.IsEditing Then
                editingNode = True
                If isHeader(mySelectedNode) = False Then
                    mySelectedNode.NodeFont = New Font(tvInfo.Font, FontStyle.Regular)
                End If
                mySelectedNode.BeginEdit()
            End If
        Else
            MessageBox.Show("No tree node selected or selected node is a root node." &
              Microsoft.VisualBasic.ControlChars.Cr &
              "Editing of root nodes is not allowed.", "Invalid selection")
        End If
    End Sub

    Private Sub mnuAddCategory_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuAddCategory.Click

        ' Create the new category
        Dim NewCategory As New InfoCategory With {.Title = "New Category"}

        NewCategory.Save()

        ' Add a node for the new category and allow user to edit the title
        Dim node As New TreeNode With {.Text = NewCategory.Title, .Tag = NewCategory}
        node.NodeFont = New Font(tvInfo.Font, FontStyle.Bold)
        tvInfo.Nodes.Add(node)
        tvInfo.SelectedNode = node
        tvInfo.LabelEdit = True
        mySelectedNode = node
        editingNode = True
        node.BeginEdit()
    End Sub

    Private Sub mnuAddItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuAddItem.Click

        Dim parentNode As TreeNode

        If isHeader(mySelectedNode) Then
            parentNode = mySelectedNode
        Else
            parentNode = mySelectedNode.Parent
        End If

        Dim parentCategory As InfoCategory = parentNode.Tag

        Dim item As New InfoPoint With {.Data = "", .CategoryID = parentCategory.ID, .Title = "New Item"}
        item.Save()


        ' Add a node for the new item and allow user to edit the title
        Dim node As New TreeNode With {.Text = item.Title, .Tag = item}

        node.NodeFont = New Font(tvInfo.Font, FontStyle.Bold) ' set it bold so it is big enough
        parentNode.Nodes.Add(node)
        node.NodeFont = New Font(tvInfo.Font, FontStyle.Regular)
        tvInfo.SelectedNode = node
        tvInfo.LabelEdit = True
        mySelectedNode = node
        editingNode = True
        node.BeginEdit()
    End Sub

    Private Sub mnuMoveUp_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuMoveUp.Click
        If isHeader(mySelectedNode) Then
            Dim header As InfoCategory = mySelectedNode.Tag
            header.MoveUP()
        Else
            Dim item As InfoPoint = mySelectedNode.Tag
            item.MoveUP()
        End If
        RefreshForm()
    End Sub

    Private Sub mnuMoveDown_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuMoveDown.Click
        If isHeader(mySelectedNode) Then
            Dim header As InfoCategory = mySelectedNode.Tag
            header.MoveDown()
        Else
            Dim item As InfoPoint = mySelectedNode.Tag
            item.MoveDown()
        End If
        RefreshForm()
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuDelete.Click
        If isHeader(mySelectedNode) Then
            If mySelectedNode.Nodes.Count > 0 Then
                MsgBox("Please remove all items before you delete a section")
                Exit Sub
            End If
            Dim header As InfoCategory = mySelectedNode.Tag
            Dim db As New Common.DataLayer
            db.ExecuteSQL("Delete from InfoCategories where ID =" & header.ID)
            db.ExecuteSQL("update InfoCategories set SortOrder= Sortorder -1 where sortorder >  =" & header.SortOrder)

        Else
            Dim item As InfoPoint = mySelectedNode.Tag
            Dim db As New Common.DataLayer
            db.ExecuteSQL("Delete from InfoItems where ID =" & item.ID)
            db.ExecuteSQL("update InfoItems set SortOrder= Sortorder -1 where sortorder >  =" & item.SortOrder)
        End If


        RefreshForm()
    End Sub
#End Region








End Class

Public Class InfoPoint
    Public Property ID As Integer = -1
    Public Property CategoryID As Integer
    Public Property Title As String
    Public Property Data As String
    Public Property SortOrder As Integer

    Public Sub New(row As DataRow)
        ID = row("ID")
        CategoryID = row("CategoryID")
        Title = row("Title").ToString
        Data = row("Data").ToString
        SortOrder = row("SortOrder")
    End Sub

    Public Sub New()
        SortOrder = 100
    End Sub
    Public Sub Save()
        Dim db As New Common.DataLayer
        Dim params As New Collection
        db.CreateParameter(params, "@ID", SqlDbType.Int, ID)
        db.CreateParameter(params, "@CategoryID", SqlDbType.Int, CategoryID)
        db.CreateParameter(params, "@Title", SqlDbType.NVarChar, Title)
        db.CreateParameter(params, "@Data", SqlDbType.NVarChar, Data)
        db.CreateParameter(params, "@SortOrder", SqlDbType.Int, SortOrder)
        Dim ds As DataSet = db.ExecuteSP("spInfoSave", params)

        If ID < 1 Then
            ID = ds.Tables(0).Rows(0).Item("ID")
            SortOrder = ds.Tables(0).Rows(0).Item("SortOrder")
        End If
    End Sub
    Sub MoveUP()
        Dim db As New Common.DataLayer
        Dim ds As DataSet = db.ExecuteSQL("Select top 1  * from InfoItems where sortorder < " & SortOrder)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim nextItem As New InfoPoint(ds.Tables(0).Rows(0))
            SortOrder -= 1
            nextItem.SortOrder += 1
            Save()
            nextItem.Save()
        End If

    End Sub
    Sub MoveDown()
        Dim db As New Common.DataLayer
        Dim ds As DataSet = db.ExecuteSQL("Select top 1  * from InfoItems where sortorder > " & SortOrder)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim nextItem As New InfoPoint(ds.Tables(0).Rows(0))
            SortOrder += 1
            nextItem.SortOrder -= 1
            Save()
            nextItem.Save()
        End If

    End Sub
End Class

Public Class InfoCategory
    Public Property ID As Integer = -1
    Public Property Title As String
    Public Property SortOrder As Integer

    Public Sub New(row As DataRow)
        ID = row("ID")
        Title = row("Title").ToString
        SortOrder = row("SortOrder")
    End Sub

    Public Sub New()
    End Sub


    Public Sub Save()
        Dim db As New Common.DataLayer
        Dim params As New Collection
        db.CreateParameter(params, "@ID", SqlDbType.Int, ID)
        db.CreateParameter(params, "@Title", SqlDbType.NVarChar, Title)
        db.CreateParameter(params, "@SortOrder", SqlDbType.Int, SortOrder)
        Dim ds As DataSet = db.ExecuteSP("spInfoCatSave", params)
        If ID < 1 Then
            ID = ds.Tables(0).Rows(0).Item("ID")
            SortOrder = ds.Tables(0).Rows(0).Item("SortOrder")
        End If
    End Sub

    Sub MoveUP()
        Dim db As New Common.DataLayer
        Dim ds As DataSet = db.ExecuteSQL("Select top 1  * from InfoCategories where sortorder < " & SortOrder)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim nextHeader As New InfoCategory(ds.Tables(0).Rows(0))
            SortOrder -= 1
            nextHeader.SortOrder += 1
            Save()
            nextHeader.Save()
        End If

    End Sub
    Sub MoveDown()
        Dim db As New Common.DataLayer
        Dim ds As DataSet = db.ExecuteSQL("Select top 1  * from InfoCategories where sortorder > " & SortOrder)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim nextHeader As New InfoCategory(ds.Tables(0).Rows(0))
            SortOrder += 1
            nextHeader.SortOrder -= 1
            Save()
            nextHeader.Save()
        End If

    End Sub
End Class