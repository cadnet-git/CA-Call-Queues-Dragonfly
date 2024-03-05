Public Class frmDeskManager

#Region "Singleton"

    Private Shared oInstance As frmDeskManager

    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shared Function GetInstance()

        If oInstance Is Nothing Then
            oInstance = New frmDeskManager
        End If

        GetInstance = oInstance

    End Function
#End Region

    Private CurrentDesk As cDesk

    Private Sub RefreshDesks()

        Dim CurrentID As Integer = 0
        Try
            CurrentID = CurrentDesk.ID
        Catch ex As Exception

        End Try

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spDeskGetAll")

        Me.lvwDesks.SuspendLayout()

        Me.lvwDesks.Items.Clear()
        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim aDesk As New cDesk(aRow)

            Dim anItem As ListViewItem = Me.lvwDesks.Items.Add(aDesk.FriendlyName)
            anItem.Tag = aDesk

            anItem.SubItems.Add(aDesk.TerminalName)
            anItem.SubItems.Add(aDesk.Extension)

            If aDesk.ID = CurrentID Then
                CurrentDesk = aDesk
                Me.cmbExtensions.SelectedText = aDesk.FriendlyName
                ShowDesk()
            End If
        Next


        'set the col widths to autosize
        Me.colFriendlyName.Width = -1
        Me.colTerminalName.Width = -1
        Me.colExtension.Width = -2

        Me.lvwDesks.ResumeLayout()

    End Sub

    Private Sub frmDeskManager_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        ToggleEditForm(False)

        GetExtensions()
        GetTerminals()

        RefreshDesks()
    End Sub

    Private Sub ToggleEditForm(ByVal State As Boolean)
        Me.txtFriendlyName.Enabled = State
        Me.cmbTerminalName.Enabled = State
        Me.cmbExtensions.Enabled = State
        Me.btnSave.Enabled = State
        Me.Label1.Enabled = State
        Me.Label3.Enabled = State
        Me.Label4.Enabled = State
    End Sub

    Private Sub GetTerminals()

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("select * from terminals order by terminalname")
        Me.cmbTerminalName.Items.Clear()

        For Each aRow As DataRow In DS.Tables(0).Rows
            Me.cmbTerminalName.Items.Add(aRow.Item("TerminalName"))
        Next

    End Sub

    Private Sub GetExtensions()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("select * from extensions order by addressname")
        Me.cmbExtensions.Items.Clear()

        Me.cmbExtensions.Items.Add("None")

        For Each aRow As DataRow In DS.Tables(0).Rows
            Me.cmbExtensions.Items.Add(aRow.Item("AddressName"))
        Next

    End Sub
    Private Sub lvwDesks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lvwDesks.SelectedIndexChanged
        If Me.lvwDesks.SelectedItems.Count > 0 Then
            CurrentDesk = Me.lvwDesks.SelectedItems(0).Tag
        Else
            CurrentDesk = Nothing
        End If

        ShowDesk()
    End Sub
    Private Sub ShowDesk()

        If CurrentDesk Is Nothing Then
            ToggleEditForm(False)
            Me.lblCurrentDesk.Text = ""

            Me.txtFriendlyName.Text = ""
            Me.cmbTerminalName.SelectedIndex = -1
            Me.cmbExtensions.SelectedIndex = -1

        Else
            Me.lblCurrentDesk.Text = CurrentDesk.FriendlyName

            Me.txtFriendlyName.Text = CurrentDesk.FriendlyName
            Me.cmbTerminalName.SelectedItem = CurrentDesk.TerminalName

            If CurrentDesk.Extension = "" Then
                Me.cmbExtensions.SelectedItem = "None"
            Else
                Me.cmbExtensions.SelectedItem = CurrentDesk.Extension
            End If

            ToggleEditForm(True)
        End If


    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAddNew.Click
        CurrentDesk = New cDesk
        ShowDesk()


    End Sub
    Private Sub txtFriendlyName_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtFriendlyName.TextChanged
        If CurrentDesk Is Nothing Then

        Else
            CurrentDesk.FriendlyName = Me.txtFriendlyName.Text
        End If

    End Sub

    Private Sub cmbTerminalName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTerminalName.SelectedIndexChanged

        If CurrentDesk Is Nothing Then
        Else
            CurrentDesk.TerminalName = Me.cmbTerminalName.SelectedItem
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        CurrentDesk.Save()
        Me.RefreshDesks()
    End Sub

    Private Sub cmbExtensions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbExtensions.SelectedIndexChanged
        If CurrentDesk Is Nothing Then

        Else
            If Me.cmbExtensions.SelectedItem = "None" Then
                CurrentDesk.Extension = ""
            Else
                CurrentDesk.Extension = Me.cmbExtensions.SelectedItem
            End If

        End If

    End Sub


End Class