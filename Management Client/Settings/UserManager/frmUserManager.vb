
Imports System.Linq

Public Class frmUserManager

#Region "Singleton"

    Private Shared oInstance As frmUserManager

    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shared Function GetInstance()

        If oInstance Is Nothing Then
            oInstance = New frmUserManager
        End If

        GetInstance = oInstance

    End Function
#End Region

    Private dsUsers As DataSet

    Private bActiveOnly As Boolean = True

    Private CurrentUser As Common.cUser

    Private TabPages As New Collection

    Private Sub frmUserManager_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        GetUsers()
        ShowUsers()

    End Sub

    Private Sub frmUserManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim CompanyGroups As New List(Of Common.cSimpleItem)
        CompanyGroups.Add(New Common.cSimpleItem(0, ""))
        CompanyGroups.Add(New Common.cSimpleItem(1, "CA"))
        CompanyGroups.Add(New Common.cSimpleItem(2, "DF"))
        CompanyGroups.Add(New Common.cSimpleItem(3, "PI"))

        cbGroupCompany.DataSource = CompanyGroups
        'stash the tabpages:
        For Each aTab As TabPage In TabControil1.TabPages
            TabPages.Add(aTab, aTab.Name)
        Next

        GetStatusLevels()
        GetAccessLevels()

        GetUsers()
        ShowUsers()

        ClearForm(True)
        For t As Integer = 0 To 25
            cboMaxApps.Items.Add(t)
        Next
        cboOverrideDiaryWeeks.Items.Add(0)
        For t As Integer = 2 To 6
            cboOverrideDiaryWeeks.Items.Add(t)
        Next
        cboOverrideDiaryWeeks.Text = 0
    End Sub

    Private Sub GetAccessLevels()

        Dim sSQL As String = "select * from UserLevels where ID>= " & cManagerApp.GetInstance.CurrentUser.UserLevelID & " order by Title"

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        With cmbAccessLevel
            .DataSource = DS.Tables(0)
            .DisplayMember = "Title"
            .ValueMember = "ID"

            .SelectedIndex = -1
        End With

    End Sub
    Private Sub GetStatusLevels()

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("select * from UserStatusTitles order by SortOrder")

        With cmbStatus

            .DataSource = DS.Tables(0)
            .DisplayMember = "Title"
            .ValueMember = "ID"

            .SelectedIndex = -1
        End With

    End Sub
    Private Sub GetUsers()

        Dim Params As New Collection

        Dim Value As Integer
        If bActiveOnly Then
            Value = 1
        Else
            Value = 0
        End If

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(Params, "@ActiveOnly", SqlDbType.Int, Value)
            .CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)

            dsUsers = .ExecuteSP("spUsersGet", Params)
        End With


    End Sub

    Private Sub ShowUsers()

        'databind to the user list

        lvwUsers.Items.Clear()

        For Each aRow As DataRowView In dsUsers.Tables(0).DefaultView
            Dim anItem As New ListViewItem() With {.Text = aRow.Item("RealName")}

            If aRow.Item("StatusID") = Common.eUserStatus.Inactive Then
                anItem.ForeColor = Color.Silver
            End If

            anItem.SubItems.Add(aRow.Item("UserLevelTitle").ToString)

            anItem.Tag = aRow

            lvwUsers.Items.Add(anItem)

        Next

    End Sub

    Private Sub ToggleEnabled(ByVal State As Boolean)

        For Each aTab As TabPage In TabPages
            For Each aCtrl As Control In aTab.Controls
                aCtrl.Enabled = State
            Next
        Next

        btnSave.Enabled = State
        btnCancel.Enabled = State

    End Sub

    Private Sub ShowUser()

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        ClearForm(True)

        ' SuspendLayout()

        lblCurrentUser.Text = CurrentUser.RealName
        txtUserName.Text = CurrentUser.UserName
        txtRealname.Text = CurrentUser.RealName
        cmbStatus.SelectedValue = CurrentUser.StatusID
        cmbAccessLevel.SelectedValue = CurrentUser.UserLevelID

        'show the appropiate tabpages:
        ShowAddressTab()
        Select Case CurrentUser.UserLevelID
            Case Common.eUserLevel.Manager
                ShowAgentTab()
                ShowDiaryTab()
            Case Common.eUserLevel.Rep
                ShowDiaryTab()
                ShowAreasTab()
                ShowDistanceTab()
            Case Common.eUserLevel.Agent
                ShowAgentTab()
        End Select


        ToggleEnabled(True)
        ResumeLayout()


        cbGroupCompany.SelectedValue = CurrentUser.GroupCompanyID

        Cursor = Cursors.Default

    End Sub



    Private Sub ShowDistanceTab()
        If TabControil1.TabPages.Contains(TabPages(TabDistance.Name)) = False Then
            TabControil1.TabPages.Add(TabPages("TabDistance"))
        End If
        txtMaxOK.Text = CurrentUser.OKMaxDist
        txtMedMax.Text = CurrentUser.MedMaxDist
        txtlongMax.Text = CurrentUser.LongMaxDist
    End Sub
    Private Sub ShowAddressTab()

        If TabControil1.TabPages.Contains(TabPages(tabAddress.Name)) = False Then
            TabControil1.TabPages.Add(TabPages("tabAddress"))
        End If

        lvwAreas.SuspendLayout()
        lvwAreas.Items.Clear()

        txtTel.Text = CurrentUser.Tel
        txtFax.Text = CurrentUser.Fax
        txtEmail.Text = CurrentUser.Email

        txtAddress1.Text = CurrentUser.Address1
        txtAddress2.Text = CurrentUser.Address2
        txtAddress3.Text = CurrentUser.Address3
        txtAddress4.Text = CurrentUser.Address4
        txtAddress5.Text = CurrentUser.Address5
        txtPostcode.Text = CurrentUser.Postcode
        txtPosition.Text = CurrentUser.Position

        lvwAreas.ResumeLayout()

    End Sub
    Private Sub ShowAreasTab()

        If TabControil1.TabPages.Contains(TabPages(tabAreas.Name)) = False Then
            TabControil1.TabPages.Add(TabPages("tabAreas"))
        End If

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Using DS As DataSet = Database.ExecuteSQL(String.Format("SELECT * FROM Areas where RepID={0} ORDER BY Title", CurrentUser.ID))
            lvwAreas.SuspendLayout()
            lvwAreas.Items.Clear()
            For Each aRow As DataRow In DS.Tables(0).Rows
                Dim anItem As ListViewItem = lvwAreas.Items.Add(Common.TitleCase(aRow.Item("Title")))
                If aRow("NoColdCalls") Then
                    anItem.SubItems.Add("Y")
                Else
                    anItem.SubItems.Add("")
                End If
                anItem.Tag = aRow.Item("ID")
            Next
        End Using
        lvwAreas.ResumeLayout()

    End Sub

    Private Sub ShowAgentTab()

        If TabControil1.TabPages.Contains(TabPages(tabAgent.Name)) = False Then
            TabControil1.TabPages.Add(TabPages(tabAgent.Name))
        End If

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("Select * from Users where Status = 2 and userlevelId=" & Common.eUserLevel.Rep)

        cmbAgentArea.SuspendLayout()
        cmbAgentArea.Items.Clear()


        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim Index As Integer = cmbAgentArea.Items.Add(Common.StringManipulation.TitleCase(aRow.Item("RealName")))

            If aRow.Item("ID") = CurrentUser.AreaID Then
                cmbAgentArea.SelectedIndex = Index
            End If
        Next

        cmbAgentArea.Tag = DS

        cmbAgentArea.ResumeLayout()



    End Sub

    Private Sub ShowDiaryTab()

        If TabControil1.TabPages.Contains(TabPages(tabDiary.Name)) = False Then
            TabControil1.TabPages.Add(TabPages(tabDiary.Name))
        End If


        dtpAppointment1.Value = Date.Today + CurrentUser.AppTime1.TimeOfDay

        If CurrentUser.HasApp2 Then
            chkAppointment2.Checked = True

        Else
            chkAppointment2.Checked = False
        End If
        dtpAppointment2.Value = Date.Today + CurrentUser.AppTime2.TimeOfDay


        If CurrentUser.HasApp3 Then
            chkAppointment3.Checked = True

        Else
            chkAppointment3.Checked = False
        End If
        dtpAppointment3.Value = Date.Today + CurrentUser.AppTime3.TimeOfDay

        If CurrentUser.HasApp4 Then
            chkAppointment4.Checked = True

        Else
            chkAppointment4.Checked = False
        End If
        dtpAppointment4.Value = Date.Today + CurrentUser.AppTime4.TimeOfDay

        If CurrentUser.HasApp5 Then
            chkAppointment5.Checked = True

        Else
            chkAppointment5.Checked = False
        End If
        dtpAppointment5.Value = Date.Today + CurrentUser.AppTime5.TimeOfDay


        cboMaxApps.Text = CurrentUser.AppsPerWeek
        cboOverrideDiaryWeeks.Text = CurrentUser.OverrideDiaryWeeks
    End Sub
    Private Sub ShowUser(ByVal aRow As DataRowView)

        CurrentUser = New Common.cUser()
        CurrentUser.Load(CInt(aRow.Item("ID")))
        ShowUser()

    End Sub

    Private Sub lvwUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvwUsers.SelectedIndexChanged

        For Each anItem As ListViewItem In lvwUsers.SelectedItems
            ShowUser(anItem.Tag)
        Next

    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateUser.Click
        CurrentUser = New Common.cUser
        ShowUser()
        btnChangePassword.Enabled = False
        txtRealname.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        If CurrentUser.TestUserName(txtUserName.Text) = False Then
            MessageBox.Show("Username is not acceptable - please try again.")
            Exit Sub
        End If

        If CurrentUser.ID < 1 Then

            Using aFrm As New frmChangePassword
                If aFrm.ShowDialog = DialogResult.OK Then
                    CurrentUser.Password = aFrm.txtPassword.Text
                End If
            End Using
        End If

        With CurrentUser

            .RealName = txtRealname.Text
            .UserName = txtUserName.Text
            .StatusID = cmbStatus.SelectedValue
            .UserLevelID = cmbAccessLevel.SelectedValue

            .HasApp1 = True
            .HasApp2 = chkAppointment2.Checked
            .HasApp3 = chkAppointment3.Checked
            .HasApp4 = chkAppointment4.Checked
            .HasApp5 = chkAppointment5.Checked

            .AppTime1 = dtpAppointment1.Value
            .AppTime2 = dtpAppointment2.Value
            .AppTime3 = dtpAppointment3.Value
            .AppTime4 = dtpAppointment4.Value
            .AppTime5 = dtpAppointment5.Value

            .Tel = txtTel.Text
            .Fax = txtFax.Text
            .Email = txtEmail.Text
            .Address1 = txtAddress1.Text
            .Address2 = txtAddress2.Text
            .Address3 = txtAddress3.Text
            .Address4 = txtAddress4.Text
            .Address5 = txtAddress5.Text
            .Position = txtPosition.Text
            .Postcode = txtPostcode.Text
            If cboMaxApps.Text <> "" Then
                .AppsPerWeek = cboMaxApps.Text
            Else
                .AppsPerWeek = 0
            End If

            If cboOverrideDiaryWeeks.Text = "" Then
                .OverrideDiaryWeeks = 0
            Else

                .OverrideDiaryWeeks = cboOverrideDiaryWeeks.Text
            End If
            .GroupCompanyID = cbGroupCompany.SelectedItem.Value
            .Save()

        End With

        GetUsers()
        ShowUsers()
        btnChangePassword.Enabled = True
    End Sub

    Private Sub txtRealname_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRealname.TextChanged
        CheckAllowSubmit()
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtUserName.TextChanged
        CheckAllowSubmit()
    End Sub

    Private Sub cmbAccessLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccessLevel.SelectedIndexChanged
        CheckAllowSubmit()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        CheckAllowSubmit()
    End Sub

    Private Sub CheckAllowSubmit()

        Dim bAllow As Boolean

        If txtRealname.Text.Trim.Length < 1 Then
            bAllow = False
        Else
            bAllow = True
        End If

        If txtUserName.Text.Trim.Length < 2 Then
            bAllow = False
        End If

        Dim sTemp As String = txtUserName.Text & txtRealname.Text
        If sTemp <> Common.RemoveNonAlphaNumerics(sTemp, True) Then
            bAllow = False
        End If

        If cmbStatus.SelectedIndex < 0 Then
            bAllow = False
        End If

        If cmbAccessLevel.SelectedIndex < 0 Then
            bAllow = False
        End If

        btnSave.Enabled = bAllow

    End Sub

    Private Sub chkIncludeInactive_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkIncludeInactive.CheckedChanged
        bActiveOnly = Not chkIncludeInactive.Checked
        GetUsers()
        ShowUsers()
    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChangePassword.Click
        Using aFrm As New frmChangePassword
            If aFrm.ShowDialog = DialogResult.OK Then
                CurrentUser.Password = aFrm.txtPassword.Text
                CurrentUser.Save()
            End If
        End Using
    End Sub

    Private Sub ClearForm(Optional ByVal LeaveDisabled As Boolean = False)

        ToggleEnabled(False)
        Application.DoEvents()

        SuspendLayout()

        For Each aTab As TabPage In TabPages
            For Each aCtrl As Control In aTab.Controls
                Select Case aCtrl.Name
                    Case lblCurrentUser.Name
                        aCtrl.Text = "Please select a user above"
                    Case txtUserName.Name, txtRealname.Name
                        aCtrl.Text = ""
                    Case cmbStatus.Name, cmbAccessLevel.Name, cboMaxApps.Name, cboOverrideDiaryWeeks.Name
                        Dim aCombobox As ComboBox = aCtrl
                        aCombobox.SelectedIndex = -1
                    Case txtTel.Name, txtFax.Name, txtEmail.Name, txtAddress1.Name, txtAddress2.Name, txtAddress3.Name, txtAddress4.Name, txtAddress5.Name, txtPostcode.Name, txtPosition.Name, txtMaxOK.Name, txtMedMax.Name, txtlongMax.Name, Label48.Name, Label47.Name, Label43.Name, Label44.Name, Label45.Name, Label49.Name
                        aCtrl.Text = ""
                    Case Label8.Name, Label9.Name, Label10.Name, Label11.Name, Label16.Name, Label17.Name
                    Case btnAddArea.Name, cbGroupCompany.Name

                    Case lvwAreas.Name
                        lvwAreas.Items.Clear()
                    Case cmbAgentArea.Name
                        cmbAgentArea.Items.Clear()
                    Case chkAppointment2.Name, chkAppointment3.Name, chkAppointment4.Name, chkAppointment5.Name
                    Case dtpAppointment1.Name, dtpAppointment2.Name, dtpAppointment3.Name, dtpAppointment4.Name, dtpAppointment5.Name
                    Case btnChangePassword.Name
                    Case Label12.Name, Label7.Name, Label1.Name, Label2.Name, Label3.Name, Label4.Name, Label5.Name, Label6.Name, Label13.Name, Label14.Name
                    Case lblAppWarn2.Name, lblAppWarn3.Name, lblAppWarn4.Name, lblAppWarn5.Name
                    Case Else
                        MessageBox.Show("Unexpected Control: " & aCtrl.Name, "ClearForm")
                End Select
            Next
        Next

        With TabControil1
            .TabPages.Clear()
            .TabPages.Add(TabPages("tabDetails"))
        End With

        If LeaveDisabled = False Then
            ToggleEnabled(True)
        End If

        ResumeLayout()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        CurrentUser = Nothing
        ClearForm(True)
    End Sub

    Private Sub chkAppointment2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment2.CheckedChanged

        dtpAppointment2.Enabled = chkAppointment2.Checked
        If chkAppointment2.Checked = False Then
            'disable this and all appointments below it
            chkAppointment3.Checked = False
        End If

    End Sub

    Private Sub chkAppointment3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment3.CheckedChanged

        dtpAppointment3.Enabled = chkAppointment3.Checked
        If chkAppointment3.Checked = False Then
            'disable this and all appointments below it
            chkAppointment4.Checked = False
        End If
    End Sub

    Private Sub chkAppointment4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment4.CheckedChanged
        dtpAppointment4.Enabled = chkAppointment4.Checked
        If chkAppointment4.Checked = False Then
            'disable this and all appointments below it
            chkAppointment5.Checked = False
        End If
    End Sub

    Private Sub chkAppointment5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment5.CheckedChanged
        dtpAppointment5.Enabled = chkAppointment5.Checked
    End Sub

    Private Sub dtpAppointment1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpAppointment1.ValueChanged, dtpAppointment2.ValueChanged, dtpAppointment3.ValueChanged, dtpAppointment4.ValueChanged, dtpAppointment5.ValueChanged
        'check the time for the next appointment - it should be after this one!

        If chkAppointment2.Checked Then
            lblAppWarn2.Visible = (dtpAppointment2.Value.TimeOfDay <= dtpAppointment1.Value.TimeOfDay)
        End If

        If chkAppointment3.Checked Then
            lblAppWarn3.Visible = (dtpAppointment3.Value.TimeOfDay <= dtpAppointment2.Value.TimeOfDay)
        End If

        If chkAppointment4.Checked Then
            lblAppWarn4.Visible = (dtpAppointment4.Value.TimeOfDay <= dtpAppointment3.Value.TimeOfDay)
        End If

        If chkAppointment5.Checked Then
            lblAppWarn5.Visible = (dtpAppointment5.Value.TimeOfDay <= dtpAppointment4.Value.TimeOfDay)
        End If

    End Sub


    Private Sub btnAddArea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddArea.Click

        Using aFrm As New frmSelectAreasForRep()
            If aFrm.ShowDialog() = DialogResult.OK Then
                'go through the selected areas and add allocations to them in the database
                For Each anItem As ListViewItem In aFrm.lvwAreas.SelectedItems
                    Dim Params As New Collection()
                    Dim parUserID As New SqlClient.SqlParameter("@UserID", SqlDbType.Int) With {.Value = CurrentUser.ID}
                    Params.Add(parUserID)

                    Dim parAreaID As New SqlClient.SqlParameter("@AreaID", SqlDbType.Int) With {.Value = anItem.Tag}
                    Params.Add(parAreaID)

                    Dim Database As New CADNet.CallQueues.Common.DataLayer()
                    Try
                        Database.ExecuteSPNoQuery("spRepAddArea", Params)
                    Catch ex As Exception
                        Dim sMsg As String = ""
                        sMsg = String.Format("Cannot add Area to User: {0}{1}", vbCrLf, ex.Message)
                        sMsg = sMsg & vbCrLf
                        sMsg = String.Format("{0}{1}UserID = {2}", sMsg, vbCrLf, CurrentUser.ID)
                        sMsg = String.Format("{0}{1}AreaID = {2}", sMsg, vbCrLf, anItem.Tag)
                        MessageBox.Show(sMsg)
                    End Try
                Next
                'refresh the list
                ShowAreasTab()
            End If
        End Using
    End Sub

    Private Sub mnuAreaRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAreaRemove.Click
        'remove the selected area from the currently display user

        If lvwAreas.SelectedItems.Count < 1 Then
            Exit Sub
        End If

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        For Each anItem As ListViewItem In lvwAreas.SelectedItems
            Dim Params As New Collection


            With Database
                .CreateParameter(Params, "@UserID", SqlDbType.Int, CurrentUser.ID)
                .CreateParameter(Params, "@AreaID", SqlDbType.Int, anItem.Tag)

                Try
                    .ExecuteSPNoQuery("spUserAreaRemove", Params)
                Catch ex As Exception
                    Dim sMsg As String = "Unable to remove Area from User:"

                    sMsg = sMsg & vbCrLf & ex.Message
                    sMsg = sMsg & vbCrLf
                    sMsg = String.Format("{0}{1}UserID = {2}", sMsg, vbCrLf, CurrentUser.ID)
                    sMsg = String.Format("{0}{1}UserID = {2}", sMsg, vbCrLf, anItem.Tag)
                    MessageBox.Show(sMsg)

                End Try
            End With


        Next

        ShowAreasTab()

    End Sub

    Private Sub cmbAgentArea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAgentArea.SelectedIndexChanged

        'the DS is stored in the tag of control
        'use it to find the ID of the selected area

        Dim DS As DataSet = cmbAgentArea.Tag

        Try
            For Each aRow As DataRow In DS.Tables(0).Rows
                If aRow.Item("Realname").ToString.ToLower = cmbAgentArea.Text.ToLower Then
                    CurrentUser.AreaID = aRow.Item("ID")
                    Exit For
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("")
        End Try


    End Sub




    Private Sub txtlongMax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtlongMax.Leave
        Try
            CurrentUser.LongMaxDist = txtlongMax.Text
        Catch ex As Exception
            MsgBox("all boxes must have a distance")
        End Try
    End Sub

    Private Sub txtlongMax_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtlongMax.TextChanged
        txtlongMax.Text = Common.RemoveNonNumerics(txtlongMax.Text)
    End Sub
    Private Sub txtMedMax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtMedMax.Leave
        Try
            CurrentUser.MedMaxDist = txtMedMax.Text
        Catch ex As Exception
            MsgBox("all boxes must have a distance")
        End Try
    End Sub
    Private Sub txtMedMax_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMedMax.TextChanged
        txtMedMax.Text = Common.RemoveNonNumerics(txtMedMax.Text)
    End Sub
    Private Sub txtMaxOK_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtMaxOK.Leave
        Try
            CurrentUser.OKMaxDist = txtMaxOK.Text
        Catch ex As Exception
            MsgBox("all boxes must have a distance")
        End Try
    End Sub

    Private Sub txtMaxOK_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMaxOK.TextChanged
        txtMaxOK.Text = Common.RemoveNonNumerics(txtMaxOK.Text)
    End Sub



    Dim SelectedArea As ListViewItem
    Private Sub cmnuAreas_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmnuAreas.Opening
        SelectedArea = lvwAreas.SelectedItems(0)
        If SelectedArea.SubItems(1).Text = "Y" Then
            NoColdCallsToolStripMenuItem.Checked = True
        Else
            NoColdCallsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub NoColdCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoColdCallsToolStripMenuItem.Click
        Dim id As Integer = SelectedArea.Tag
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            If SelectedArea.SubItems(1).Text = "Y" Then
                Database.ExecuteSQL("Update Areas set NoColdCalls = 0 where ID =" & id)
            Else
                Database.ExecuteSQL("Update Areas set NoColdCalls = 1 where ID =" & id)
            End If
        End With
        ShowAreasTab()
    End Sub


End Class