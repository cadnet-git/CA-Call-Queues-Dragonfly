Public Class frmAreas

#Region "Singleton"

    Private Shared oInstance As frmAreas

    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shared Function GetInstance()

        If oInstance Is Nothing Then
            oInstance = New frmAreas
        End If

        GetInstance = oInstance

    End Function
#End Region

    Dim App As cManagerApp
    Dim bLoading As Boolean = False
    Dim dsPostcodes As DataSet

    Private RepMenus As New Collection

    Dim CurrentArea As cArea

    Private Sub frmAreas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        bLoading = True

        App = cManagerApp.GetInstance

        'BuildRepMenu()

        DatabindAreas()

        bLoading = False

    End Sub


    Private Sub BuildRepMenu()

        Static Built As Boolean

        If Built = False Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Dim DS As DataSet = Database.ExecuteSQL("Select * from Users where status=2 and  UserLevelID=4 order by realname")

            For Each aMenu As ToolStripMenuItem In RepMenus

                RemoveHandler aMenu.Click, AddressOf RepContextMenu_Click

                aMenu = Nothing
            Next

            Do Until RepMenus.Count = 0
                RepMenus.Remove(1)
            Loop


            For Each aRow As DataRow In DS.Tables(0).Rows
                Dim item As New ToolStripMenuItem(aRow.Item("RealName").ToString)
                item.Tag = aRow
                Me.mnuAssignRep.DropDownItems.Add(item)

                AddHandler item.Click, AddressOf RepContextMenu_Click

                RepMenus.Add(item)
            Next

            Built = True
        End If


    End Sub

    Private Sub RepContextMenu_Click(ByVal sender As System.Object, ByVal e As EventArgs)

        Dim aMenu As ToolStripMenuItem = sender
        Dim aRow As DataRow = aMenu.Tag

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        For Each anItem As ListViewItem In Me.lvwAreas.SelectedItems
            Dim AnArea As cArea = anItem.Tag
            Dim Params As New Collection
            With Database
                .CreateParameter(Params, "@UserID", SqlDbType.Int, aRow.Item("ID"))
                .CreateParameter(Params, "@AreaID", SqlDbType.Int, AnArea.ID)
                .ExecuteSPNoQuery("spRepAddArea", Params)
            End With

        Next

        DatabindAreas()

    End Sub
    Private Sub DatabindAreas()

        'we dont batabind cos its a pain
        'also, this way we can format the badly capitalised text

        Me.lvwAreas.Items.Clear()

        App.Areas.Refresh()
        Dim Areas As System.Collections.Generic.List(Of cArea) = App.Areas.Areas

        For Each anArea As cArea In Areas
            Dim anItem As ListViewItem = Me.lvwAreas.Items.Add(Common.TitleCase(anArea.Title))

            anItem.SubItems.Add(anArea.RepName)
            anItem.SubItems.Add(anArea.NoColdCalls)
            anItem.Tag = anArea
        Next


        'bind the dataset to the control
        'Me.lstAreas.DataSource = Nothing

        'Me.lstAreas.DataSource = App.Areas.Areas ' dsAreas.Tables(0).DefaultView
        'Me.lstAreas.DisplayMember = "Title"
    End Sub
    Private Sub lstAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)

        If Me.lvwAreas.SelectedItems.Count > 0 Then
            Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
            ShowArea(anArea)
        End If
        'If Me.lstAreas.SelectedItems.Count > 0 Then
        '    Dim anArea As cArea = Me.lstAreas.SelectedItem
        '    ShowArea(anArea)
        'End If

    End Sub

    Private Sub ShowArea(ByVal anArea As cArea)

        If bLoading Then
            Exit Sub
        End If

        CurrentArea = anArea

        Me.lblAreaName.Text = anArea.Title

        DataBindPostcodes()

        Me.btnNewPostcode.Enabled = True

    End Sub

    Private Sub DataBindPostcodes()
        'bind the postcodes to the control

        Me.lstPostcodes.DataSource = Nothing

        Me.lstPostcodes.Sorted = True

        Me.lstPostcodes.DataSource = CurrentArea.PostCodes.PostCodes
        Me.lstPostcodes.DisplayMember = "Prefix"

    End Sub
    Private Sub btnCreateArea_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCreateArea.Click

        Dim aFrm As New frmNewArea(frmNewArea.eDisplayMode.Create)

        Dim DR As DialogResult = aFrm.ShowDialog

        Select Case DR
            Case DialogResult.OK
                Dim sTitle As String = aFrm.txtTitle.Text
                CurrentArea = App.Areas.CreateArea(sTitle)
                DatabindAreas()
                ShowArea(CurrentArea)
            Case Else
                Exit Sub
        End Select

    End Sub

    Private Sub btnNewPostcode_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNewPostcode.Click

        'collect data
        Dim aFrm As New frmNewPostcode(frmNewPostcode.eDisplayMode.Create)

        Dim DR As DialogResult = aFrm.ShowDialog

        Select Case DR
            Case DialogResult.OK
            Case Else
                Exit Sub
        End Select

        Dim sPrefix As String = aFrm.txtTitle.Text

        'we need to see if the postcode already exisits under a different area


        Dim bAccepted As Boolean = ValidatePrefix(sPrefix)

        If bAccepted Then
            Dim aPostCode As New cPostCode(sPrefix)
            aPostCode.AreaID = CurrentArea.ID
            aPostCode.Save()

            'add the postcode to the areas collection
            CurrentArea.PostCodes.PostCodes.Add(aPostCode)
            DataBindPostcodes()
        End If

    End Sub


    Private Function ValidatePrefix(ByVal sPrefix As String) As Boolean

        Dim aPostCode As New cPostCode(sPrefix)

        If aPostCode.AreaID = CurrentArea.ID Then
            MessageBox.Show("Postcode " & aPostCode.Prefix & " is already in this Area!")
            Return False
        ElseIf aPostCode.AreaID > 0 Then
            'this post code is already assigned to a different area

            Dim sMsg = "That postcode is already allocated to " & aPostCode.Area.Title
            sMsg = sMsg & vbCrLf & vbCrLf & "Move this postcode to " & CurrentArea.Title & "?"
            Dim oDR As DialogResult = MessageBox.Show(sMsg, "Postcode already allocated", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            Select Case oDR
                Case DialogResult.Yes
                    'allow this
                    'carry on with other checks
                Case DialogResult.No
                    Return False
                Case Else
                    MessageBox.Show("Unknown dialog result: " & oDR.ToString)
                    Return False
            End Select
        End If

        Dim sTest As String = aPostCode.PrefixTest

        If sTest = "" Then
            Return True
        Else
            MessageBox.Show(sTest)
            Return False
        End If

    End Function

    Private Sub mnuEditArea_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuEditArea.Click

        Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
        Dim iAreaID As Integer = anArea.ID 'so we can re-select it later on

        'Dim iTopIndex As Integer = Me.lstAreas.TopIndex

        Dim aFrm As New frmNewArea(frmNewArea.eDisplayMode.Edit)
        aFrm.txtTitle.Text = anArea.Title

        Dim DR As DialogResult = aFrm.ShowDialog

        Select Case DR
            Case DialogResult.OK
                anArea.Title = aFrm.txtTitle.Text
                anArea.Save()

                'as this is a collection, it wont fire a ListChanged event, which wont update the binding
                'so reset the binding, then reselect the item
                DatabindAreas()

                ' Me.lstAreas.SelectedItem = anArea
                ' Me.lstAreas.TopIndex = iTopIndex
        End Select
    End Sub

    Private Sub RemoveAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles RemoveAreaToolStripMenuItem.Click
        'get the selected area:

        Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
        Dim sMsg As String = "Remove area '" & anArea.Title & "'?"
        Dim DR As DialogResult = MessageBox.Show(sMsg, "Remove Area confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        Select Case DR
            Case DialogResult.Yes
                anArea.Remove()
                App.Areas.Refresh()

                DatabindAreas()
        End Select

    End Sub


    Private Sub mnuPostcodeEdit_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuPostcodeEdit.Click

        Dim aPostcode As cPostCode = Me.lstPostcodes.SelectedItem
        ' Dim iTopIndex As Integer = Me.lstAreas.TopIndex

        Dim aFrm As New frmNewPostcode(frmNewPostcode.eDisplayMode.Edit)
        aFrm.txtTitle.Text = aPostcode.Prefix

        Dim DR As DialogResult = aFrm.ShowDialog
        Select Case DR
            Case DialogResult.OK

                'need to check that the postcode is acceptable

                Dim bAccepted As Boolean = ValidatePrefix(aFrm.txtTitle.Text)

                If bAccepted Then
                    aPostcode.Prefix = aFrm.txtTitle.Text
                    aPostcode.Save()

                    DataBindPostcodes()

                    Me.lstPostcodes.SelectedItem = aPostcode
                    ' Me.lstPostcodes.TopIndex = iTopIndex
                End If

        End Select
    End Sub

    Private Sub mnuPostcodeRemove_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mnuPostcodeRemove.Click
        'get the selected area:

        Dim aPostcode As cPostCode = Me.lstPostcodes.SelectedItem
        Dim sMsg As String = "Remove postcode '" & aPostcode.Prefix & "' from " & CurrentArea.Title & "?"
        Dim DR As DialogResult = MessageBox.Show(sMsg, "Remove Postcode confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        Select Case DR
            Case DialogResult.Yes
                CurrentArea.RemovePostcode(aPostcode.ID)
                App.Areas.Refresh()

                DatabindAreas()
        End Select

    End Sub

    Private Sub lvwAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lvwAreas.SelectedIndexChanged
        If Me.lvwAreas.SelectedItems.Count > 0 Then
            Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
            ShowArea(anArea)
        End If
    End Sub

    Private Sub NoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NoneToolStripMenuItem.Click
        Dim aMenu As ToolStripMenuItem = sender
        Dim aRow As DataRow = aMenu.Tag

        For Each anItem As ListViewItem In Me.lvwAreas.SelectedItems
            Dim AnArea As cArea = anItem.Tag

            Dim Params As New Collection
            'Common.DataLayer.CreateParameter(Params, "@UserID", SqlDbType.Int, 0)
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.CreateParameter(Params, "@AreaID", SqlDbType.Int, AnArea.ID)
            Database.ExecuteSPNoQuery("spRepAreaRemove", Params)
        Next

        DatabindAreas()
    End Sub

    Private Sub mnuAssignRep_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAssignRep.DropDownOpening
        BuildRepMenu()

    End Sub

    Private Sub NoColdCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoColdCallsToolStripMenuItem.Click
        Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
        anArea.ToggleNoColdCalls()
        anArea.Save()
        Dim index As Integer = lvwAreas.TopItem.Index
        DatabindAreas()
        lvwAreas.TopItem = lvwAreas.Items(index)
    End Sub

    Private Sub cmnuAreas_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmnuAreas.Opening
        Dim anArea As cArea = Me.lvwAreas.SelectedItems(0).Tag
        If anArea.NoColdCalls = "Y" Then
            NoColdCallsToolStripMenuItem.Checked = True
        Else
            NoColdCallsToolStripMenuItem.Checked = False
        End If

    End Sub
End Class