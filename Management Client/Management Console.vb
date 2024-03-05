Imports System.Net
Imports System.IO
Imports System.Windows.Forms
Public Class frmManagementConsole
    Public WithEvents aDialer As Common.cDialer
    '  Friend WithEvents CtlAgentMonitor1 As CADNet.CallQueues.ManagerConsole.ctlAgentMonitor
    Private CurrentUser As Common.cUser
    Private loading As Boolean = True
    Dim SelectedDesk As ListViewItem

    Private Delegate Sub DelHandleCallFinished(ByVal type As Common.cDialer.eDisconnectType)

    Private RootTread As Integer


    Private Shared Sub HandleCallFinished(ByVal Type As Common.cDialer.eDisconnectType)
        If Type = Common.cDialer.eDisconnectType.Busy Then
            MsgBox("Busy")
        End If
    End Sub



    Private Sub Management_Console_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Text = "Manager Console V5.03 (Modified Provider Change Routine)"

        RootTread = System.Threading.Thread.CurrentThread.ManagedThreadId
        Try
            aDialer = New Common.cDialer
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        '******************************************************************
        ' user the frmsearch2  form to preload the the devexpress controls 
        '******************************************************************
        Cursor = Cursors.WaitCursor
        Using frm As New frmSearch2() With {.ShowInTaskbar = False, .WindowState = FormWindowState.Minimized, .OnlyLoading = True}
            frm.Show()
        End Using
        Cursor = Cursors.Default
        '*****************************************************************

        tmrStartup.Enabled = True

        ToggleForm(False)

        'SetSizes()

    End Sub

    Private Sub tmrStartup_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles tmrStartup.Tick
        tmrStartup.Enabled = False




        Dim aFrm As Common.frmLogin

        If tmrStartup.Tag Is Nothing Then
            aFrm = New Common.frmLogin(Icon)
            tmrStartup.Tag = aFrm
        Else
            aFrm = tmrStartup.Tag
        End If

        Dim DR As DialogResult = aFrm.ShowDialog()
        Select Case DR
            Case DialogResult.OK
                'try to login
                Cursor = Cursors.WaitCursor
                Application.DoEvents()

                Dim oApp As cManagerApp = cManagerApp.GetInstance
                Dim aUser As New Common.cUser
                Dim bResult As Boolean = oApp.Login(aFrm.Username, aFrm.Password)
                Me.Text = Me.Text + " DB : " + oApp.GetDatabaseName()
                Cursor = Cursors.Default

                If bResult Then
                    'login worked
                    CurrentUser = aUser
                    ' populate desks
                    PopulateDesks()
                    Application.DoEvents()
                    TimerDesks.Enabled = True
                    ' CheckTPSCount()

                    ToggleForm(True)
                Else
                    'login failed
                    MessageBox.Show("Unable to login. Please check your username and password and try again.")
                    aFrm.ClearPassword()
                    tmrStartup.Enabled = True
                End If

            Case DialogResult.Cancel
                'login cancelled
                Application.Exit()
            Case Else
                MessageBox.Show("Unexpected Dialog Result.")
                tmrStartup.Enabled = True
        End Select
        Dim RepDS As New DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        RepDS = Database.ExecuteSQL("Select * from users where id in ( Select userid from DiaryItems d where d.Status =3 group by userid) order by realname")
        cmbSelectRep.DataSource = RepDS.Tables(0)
        cmbSelectRep.DisplayMember = "RealName"
        cmbSelectRep.ValueMember = "ID"
        cmbSelectRep.SelectedIndex = -1

        Application.DoEvents()
        loading = False
        Width = Width + 10

    End Sub
    Private Sub PopulateDesks()
        Dim DS As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSQL("SELECT Desks.ID, Desks.FriendlyName FROM Desks Order by Desks.DisplayOrder")
        Dim LVItem As ListViewItem
        Dim DR As DataRow
        LVDesks.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            LVItem = New ListViewItem(DR("ID").ToString & " ")
            LVItem.SubItems.Add(DR("FriendlyName").ToString)
            LVItem.SubItems.Add("")
            LVItem.SubItems.Add("")
            LVItem.SubItems.Add("")
            LVItem.SubItems.Add("")
            LVItem.SubItems.Add("")
            LVItem.SubItems.Add("")

            LVItem.UseItemStyleForSubItems = True
            LVDesks.Items.Add(LVItem)
        Next

    End Sub
    Private Sub ToggleForm(ByVal State As Boolean)
        Try

            BtnNewDiary.Enabled = State
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNewDiary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewDiary.Click
        'load the form into the placeholder panel
        Dim aFrm As New FrmDiary() With {.TopLevel = False}

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()
    End Sub




    Private Sub TimerDesks_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerDesks.Tick
        TimerDesks.Enabled = False

        Try
            Dim DS As DataSet
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            DS = Database.ExecuteSQL("SELECT Desks.ID, Desks.Status, Desks.Telephone, Desks.Calls, Desks.Apps, Users.RealName AS Agent, Users.ID AS AgentID, Users.SuspendCallbacks,  Users_1.RealName AS Area FROM  Users INNER JOIN  Users AS Users_1 ON Users.AreaID = Users_1.ID RIGHT OUTER JOIN  Desks ON Users.ID = Desks.Agent")

            Dim LVItem As ListViewItem
            Dim DR As DataRow

            For Each DR In DS.Tables(0).Rows

                LVItem = LVDesks.FindItemWithText(DR("ID").ToString & " ")

                If LVItem Is Nothing Then
                    'we need to give some sort of on screen feedback
                    MessageBox.Show("Cannot find List Item for " & DR("ID").ToString)

                    Console.WriteLine("Cannot find listviewitem")
                Else
                    If DR("SuspendCallbacks").ToString = "1" Then
                        LVItem.BackColor = Color.LightSalmon
                    Else
                        LVItem.BackColor = Color.White
                    End If

                    'If Not IsNothing(LVItem) Then

                    If Not LVItem.SubItems(2).Text = DR("Agent").ToString Then
                        LVItem.Tag = DR("AgentID")
                        LVItem.SubItems(2).Text = DR("Agent").ToString
                    End If

                    If Not LVItem.SubItems(3).Text = Common.TitleCase(DR("Area").ToString) Then
                        LVItem.SubItems(3).Text = Common.TitleCase(DR("Area").ToString)
                    End If

                    If Not LVItem.SubItems(4).Text = DR("Status").ToString Then
                        LVItem.SubItems(4).Text = DR("Status").ToString
                        Dim pos As Integer = InStr(DR("Status").ToString, "Seconds")
                        If pos > 0 Then
                            Dim Secs As Integer = DR("Status").ToString.Substring(0, pos - 1).Trim
                            If Secs < 0 Then
                                LVItem.BackColor = Color.LightCoral
                            End If
                        End If

                    End If

                    If Not LVItem.SubItems(5).Text = DR("Telephone").ToString Then
                        LVItem.SubItems(5).Text = DR("Telephone").ToString
                    End If

                    Dim Tempstr As String = DR("Calls").ToString()
                    If Tempstr = "0" Then
                        Tempstr = ""
                    End If

                    If Not LVItem.SubItems(6).Text = Tempstr Then
                        LVItem.SubItems(6).Text = Tempstr
                    End If
                    Tempstr = DR("Apps").ToString()

                    If Tempstr = "0" Then
                        Tempstr = ""
                    End If

                    If Not LVItem.SubItems(7).Text = Tempstr Then
                        LVItem.SubItems(7).Text = Tempstr
                    End If
                    'End If

                End If
            Next

            DS = Database.ExecuteSQL("select count(ID) from diaryitems where Status = 0 and type='CA'")
            TabCancelled.Text = "Cancelled " & DS.Tables(0).Rows(0).Item(0).ToString

        Catch ex As Exception
            Console.WriteLine("Error in Desk Timer Tick - " & ex.Message)
        End Try
        TimerDesks.Enabled = True
    End Sub



    Private Sub DesksMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DesksMenu.Opening
        If LVDesks.SelectedItems.Count > 0 Then
            SelectedDesk = LVDesks.SelectedItems(0)
            If SelectedDesk.SubItems(2).Text = "" Then
                ' no agent
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub AreaClick(ByVal sender As System.Object, ByVal e As EventArgs)

        Dim s As ToolStripMenuItem = sender

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@DeskID", SqlDbType.Int) With {.Value = SelectedDesk.Text}
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@AreaID", SqlDbType.Int) With {.Value = s.Tag}
        Params.Add(parStatus)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spSetDeskUserArea", Params)

    End Sub

    Private Sub ChangeAreaToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles ChangeAreaToolStripMenuItem.DropDownOpening
        Dim Ds As DataSet
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Ds = Database.ExecuteSQL("Select * from Users where Status = 2 and userlevelId=" & Common.eUserLevel.Rep)
        ChangeAreaToolStripMenuItem.DropDownItems.Clear()
        For Each DR As DataRow In Ds.Tables(0).Rows
            Dim windowNewMenu As New ToolStripMenuItem(Common.TitleCase(DR("Realname")), Nothing, New EventHandler(AddressOf AreaClick)) With {.Tag = DR("ID")}
            ChangeAreaToolStripMenuItem.DropDownItems.Add(windowNewMenu)
        Next
    End Sub




    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ImportToolStripMenuItem.Click
        'load the form into the placeholder panel
        ' Dim aFrm As New frmNewData() With {.TopLevel = False}
        Using aFrm As New frmLegacyImport()
            aFrm.ShowDialog()
        End Using


        ResumeLayout()
    End Sub

    'Private Sub OldDiariesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OldDiariesToolStripMenuItem.Click
    ''load the form into the placeholder panel
    'Dim aFrm As frmDiariesManager = frmDiariesManager.GetInstance
    'aFrm.TopLevel = False

    ' SuspendLayout()
    ' pnlPlaceholderWorkspace.Controls.Clear()
    ' pnlPlaceholderWorkspace.Controls.Add(aFrm)

    'With aFrm
    '    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '    .Dock = DockStyle.Fill
    '    .Show()
    'End With

    ' ResumeLayout()
    'End Sub

    Private Sub UsersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UsersToolStripMenuItem1.Click

        'load the form into the placeholder panel
        Dim aFrm As frmUserManager = frmUserManager.GetInstance
        aFrm.TopLevel = False

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()
    End Sub

    Private Sub InfoPointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles InfoPointsToolStripMenuItem.Click


        Cursor = Cursors.WaitCursor
        Dim afrm As New frmInformationPoints

        afrm.RefreshForm()
        afrm.Show()
        Cursor = Cursors.Default


    End Sub

    Private Sub DesksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DesksToolStripMenuItem.Click
        'load the form into the placeholder panel
        Dim aFrm As frmDeskManager = frmDeskManager.GetInstance
        aFrm.TopLevel = False

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()

    End Sub

    Private Sub AreasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AreasToolStripMenuItem1.Click

        'load the form into the placeholder panel
        Dim aFrm As frmAreas = frmAreas.GetInstance
        aFrm.TopLevel = False

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        'load the form into the placeholder panel
        Dim aFrm As New frmDailyStats() With {.TopLevel = False}

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()
    End Sub



    Private Sub setsizes()
        Application.DoEvents()
        Try
            If Not loading Then
                Dim CW As Integer = 0
                CW = CInt((LVDesks.ClientSize.Width) / 14)

                LVDesks.Columns(1).Width = CW * 2
                LVDesks.Columns(2).Width = CW * 2
                LVDesks.Columns(3).Width = CW * 2
                LVDesks.Columns(4).Width = CW * 4
                LVDesks.Columns(5).Width = CW * 2
                LVDesks.Columns(6).Width = CW
                LVDesks.Columns(7).Width = CW - 3
                Application.DoEvents()
                resizeApproved()
                Application.DoEvents()
                resizePending()
                Application.DoEvents()
                resizeAwaitingFeedback()
                Application.DoEvents()
                resizeWithFeedback()
                Application.DoEvents()
                resizeUnapproved()
                Application.DoEvents()
                resizeWithConclusion()
                Application.DoEvents()
                resizeCancelled()
                Application.DoEvents()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub


    Private Sub frmManagementConsole_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        setsizes()
    End Sub






    Private Sub aDialer_Disconnected(ByVal CalledNumber As String, ByVal Type As Common.cDialer.eDisconnectType) Handles aDialer.Disconnected
        'Try
        '    'ToolStatus.Text = ("Disconnected call to " & CalledNumber & " - " & Type.ToString & " " & Now.ToLongTimeString)
        '    'Debug.AddMesage("Disconnect Event Fired tread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
        'Catch ex As Exception
        'End Try
        If System.Threading.Thread.CurrentThread.ManagedThreadId = RootTread Then
            HandleCallFinished(Type)
        Else
            Dim param() As Object = {Type}

            Dim oDel As [Delegate] = CType(AddressOf HandleCallFinished, DelHandleCallFinished)
            Invoke(oDel, param)
        End If

    End Sub



    Private Sub TPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TPSToolStripMenuItem.Click
        ShowDetails("TPS", "TPS")
    End Sub

    Private Sub ShowDetails(ByVal Title As String, ByVal type As String)
        Cursor = Cursors.WaitCursor
        SuspendLayout()
        Dim dFrm As New frmStatsDrillDown() With {.TopLevel = False}

        dFrm.lblType.Text = Title ' what displays "
        dFrm.LBLuser.Text = "All"
        dFrm.LoadData(type, -1, Now, Now)

        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(dFrm)

        With dFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With
        ResumeLayout()
        Cursor = Cursors.Default
    End Sub

    Private Sub OutOfAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OutOfAreaToolStripMenuItem.Click
        ShowDetails("Out of Area", "OutOfArea")
    End Sub

    Private Sub SupervisorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SupervisorToolStripMenuItem.Click
        ShowDetails("Supervisor Attention", "Supervisor")
    End Sub

    Private Sub NotInterestedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotInterestedToolStripMenuItem.Click
        ShowDetails("Not Interested", "NotInterested")
    End Sub

    Private Sub NotANumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotANumberToolStripMenuItem.Click
        ShowDetails("Not a Number", "NumberNotRecognised")
    End Sub




    Private Sub CompaniesToAgentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim afrm As New FrmUserStats
        afrm.ShowDialog()
    End Sub

#Region "Handle Awaiting Feedback Grid"
    Private Sub RefreshAwaitingFeedback()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetAwaitingFeedBackAppointment")
        Dim lvitem As ListViewItem
        LVAwaitingFeedback.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Agent").ToString)
            LVAwaitingFeedback.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeAwaitingFeedback()

    End Sub
    Private Sub resizeAwaitingFeedback()
        Dim CW As Integer = 0
        CW = CInt((LVAwaitingFeedback.ClientSize.Width) / 4)
        LVAwaitingFeedback.Columns(1).Width = CW
        LVAwaitingFeedback.Columns(2).Width = CW
        LVAwaitingFeedback.Columns(3).Width = CW
        LVAwaitingFeedback.Columns(4).Width = CW - 2

    End Sub
    Private Sub LVAwaitingFeedback_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVAwaitingFeedback.DoubleClick
        If LVAwaitingFeedback.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVAwaitingFeedback.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshAwaitingFeedback()
        End If
    End Sub
    Private Sub TabFeedBack_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabFeedBack.Enter
        RefreshAwaitingFeedback()
    End Sub
#End Region

#Region "Handle Pending Grid"
    Private Sub cmbSelectRep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbSelectRep.SelectedIndexChanged
        If loading = False Then
            Try
                RefreshPendings(cmbSelectRep.SelectedItem("ID"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End If
    End Sub
    Private Sub resizePending()
        Dim CW As Integer = CInt((LVPending.ClientSize.Width) / 4)
        LVPending.Columns(1).Width = CW
        LVPending.Columns(2).Width = CW
        LVPending.Columns(3).Width = CW
        LVPending.Columns(4).Width = CW - 2
    End Sub
    Private Sub RefreshPendings(ByVal Rep As Integer)
        Dim DS As DataSet
        Dim DR As DataRow

        Dim Params As New Collection
        Dim parRep = New SqlClient.SqlParameter("@Rep", SqlDbType.Int) With {.Value = Rep}
        Params.Add(parRep)
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetPendingAppointment", Params)
        Dim lvitem As ListViewItem
        LVPending.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Agent").ToString)
            LVPending.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizePending()
    End Sub
    Private Sub LVPending_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVPending.DoubleClick
        If LVPending.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVPending.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshPendings(cmbSelectRep.SelectedItem("ID"))

        End If
    End Sub
#End Region

#Region "Handle Cancelled Grid"
    Private Sub LVCancelled_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVCancelled.DoubleClick
        If LVCancelled.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVCancelled.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshCancels()
        End If
    End Sub

    Private Sub resizeCancelled()
        Dim CW As Integer = 0
        CW = CInt((LVCancelled.ClientSize.Width) / 4)
        LVCancelled.Columns(1).Width = CW
        LVCancelled.Columns(2).Width = CW
        LVCancelled.Columns(3).Width = CW
        LVCancelled.Columns(4).Width = CW - 2

    End Sub
    Private Sub TabCancelled_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabCancelled.Enter
        RefreshCancels()
    End Sub
    Private Sub RefreshCancels()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetCanceledAppointment")
        Dim lvitem As ListViewItem
        LVCancelled.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Nextcalldate").ToString)
            LVCancelled.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeCancelled()

    End Sub
#End Region

#Region "Handle Approved Grid"
    Private Sub TabConfirm_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ToConfirm.Enter
        RefreshApproveds()
    End Sub

    Private Sub RefreshApproveds()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetApprovedAppointment")
        Dim lvitem As ListViewItem
        LVApproved.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Agent").ToString)
            LVApproved.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeApproved()

    End Sub

    Private Sub resizeApproved()
        Dim CW As Integer = 0
        CW = CInt((LVApproved.ClientSize.Width) / 4)
        LVApproved.Columns(1).Width = CW
        LVApproved.Columns(2).Width = CW
        LVApproved.Columns(3).Width = CW
        LVApproved.Columns(4).Width = CW - 2
    End Sub
    Private Sub LVApproved_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVApproved.DoubleClick
        If LVApproved.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVApproved.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshApproveds()
        End If
    End Sub
#End Region



#Region "Handle ApprovedToConfirm Grid"
    Private Sub TabApproved_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabApproved.Enter
        RefreshConfirm()
    End Sub

    Private Sub RefreshConfirm()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetApprovedAppointmentUnconfirmed")
        Dim lvitem As ListViewItem
        lvConfirm.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID")
            lvitem.SubItems.Add(DR("Rep"))
            lvitem.SubItems.Add(DR("CompanyName"))
            lvitem.SubItems.Add(DR("ItemDate"))
            lvitem.SubItems.Add(DR("Agent"))
            lvConfirm.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeApproved()

    End Sub

    Private Sub resizeConfirm()
        Dim CW As Integer = 0
        CW = CInt((lvConfirm.ClientSize.Width) / 4)
        lvConfirm.Columns(1).Width = CW
        lvConfirm.Columns(2).Width = CW
        lvConfirm.Columns(3).Width = CW
        lvConfirm.Columns(4).Width = CW - 2
    End Sub
    Private Sub lvConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvConfirm.DoubleClick
        If lvConfirm.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(lvConfirm.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshConfirm()
        End If
    End Sub
#End Region



#Region "Handle Unapproved Grid"
    Private Sub resizeUnapproved()
        Dim CW As Integer = 0
        CW = CInt((LVUnapproved.ClientSize.Width) / 4)
        LVUnapproved.Columns(1).Width = CW
        LVUnapproved.Columns(2).Width = CW
        LVUnapproved.Columns(3).Width = CW
        LVUnapproved.Columns(4).Width = CW - 2

    End Sub

    Private Sub RefreshUnapproveds()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetUnapprovedAppointment")
        Dim lvitem As ListViewItem
        LVUnapproved.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID")
            lvitem.SubItems.Add(DR("Agent").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Rep").ToString)
            LVUnapproved.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeUnapproved()
    End Sub
    Private Sub LVUnapproved_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVUnapproved.DoubleClick
        If LVUnapproved.SelectedItems.Count > 0 Then
            Using Afrm As New frmAppoinmentDetail(LVUnapproved.SelectedItems(0).Text)
                Afrm.ShowDialog()
                RefreshUnapproveds()
            End Using
        End If
    End Sub
    Private Sub TabUnapproved_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabUnapproved.Enter

        RefreshUnapproveds()

    End Sub
#End Region

#Region "Handle With Feedback Grid"
    Private Sub WithFeedBack_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles WithFeedBack.Enter
        RefreshWithFeedback()
    End Sub

    Private Sub resizeWithFeedback()
        Dim CW As Integer = 0
        CW = CInt((LVWithFeedBack.ClientSize.Width) / 4)
        LVWithFeedBack.Columns(1).Width = CW
        LVWithFeedBack.Columns(2).Width = CW
        LVWithFeedBack.Columns(3).Width = CW
        LVWithFeedBack.Columns(4).Width = CW - 2
    End Sub

    Private Sub RefreshWithFeedback()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetHasFeedBackAppointment")
        Dim lvitem As ListViewItem
        LVWithFeedBack.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Agent").ToString)
            LVWithFeedBack.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeWithFeedback()

    End Sub

    Private Sub LVWithFeedBack_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVWithFeedBack.DoubleClick
        If LVWithFeedBack.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVWithFeedBack.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshWithFeedback()
        End If
    End Sub

#End Region

#Region "Handle With Conclusion Grid"
    Private Sub TabConclussion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabConclussion.Enter
        RefreshWithConclusion()
    End Sub
    Private Sub resizeWithConclusion()
        Dim CW As Integer = 0
        CW = CInt((LVConclusion.ClientSize.Width) / 4)
        LVConclusion.Columns(1).Width = CW
        LVConclusion.Columns(2).Width = CW
        LVConclusion.Columns(3).Width = CW
        LVConclusion.Columns(4).Width = CW - 2
    End Sub

    Private Sub RefreshWithConclusion()
        Dim DS As DataSet
        Dim DR As DataRow
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        DS = Database.ExecuteSP("spGetConcludedAppointment")
        Dim lvitem As ListViewItem
        LVConclusion.Items.Clear()
        For Each DR In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("Rep").ToString)
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("ItemDate").ToString)
            lvitem.SubItems.Add(DR("Agent").ToString)
            LVConclusion.Items.Add(lvitem)
        Next
        Application.DoEvents()
        resizeWithConclusion()

    End Sub

    Private Sub LVConclusion_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVConclusion.DoubleClick
        If LVConclusion.SelectedItems.Count > 0 Then
            Dim Afrm As frmAppoinmentDetail = New frmAppoinmentDetail(LVConclusion.SelectedItems(0).Text)
            Afrm.ShowDialog()
            RefreshWithConclusion()
        End If
    End Sub
#End Region


    Private Sub WatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WatchToolStripMenuItem.Click
        Dim aFrm As New frmAgentWatcher(SelectedDesk.Tag)
        aFrm.Show()
    End Sub



    Private Sub CallBacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Using sfrm As New frmSelectUser()
            If sfrm.ShowDialog = DialogResult.OK Then
                Dim afrm As New frmCheckCallbacks(sfrm.lvAll.SelectedItems(0).Text)
                afrm.lbltitle.Text = "Callbacks for " & sfrm.lvAll.SelectedItems(0).SubItems(1).Text
                afrm.ShowDialog()
            End If
        End Using
    End Sub



    Private Sub ToAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToAreasToolStripMenuItem.Click
        Dim afrm As New FrmAreaStats
        afrm.ShowDialog()
    End Sub

    Private Sub ToAgentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToAgentsToolStripMenuItem.Click
        Dim afrm As New FrmUserStats
        afrm.ShowDialog()
    End Sub

    Private Sub ToRepsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToRepsToolStripMenuItem.Click
        Dim afrm As New FrmRepToCompany
        afrm.ShowDialog()
    End Sub

    Private Sub StatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles StatusToolStripMenuItem.Click
        Dim afrm As New frmDatabaseStats
        afrm.ShowDialog()
    End Sub


    Private Sub StatisticsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles StatisticsToolStripMenuItem1.Click
        Dim afrm As New frmAgentStatsTimeFrame
        afrm.ShowDialog()
    End Sub


    Private Sub TimeExceeededToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TimeExceeededToolStripMenuItem.Click
        Dim afrm As New frmCallTimeExceeded
        afrm.ShowDialog()
    End Sub

    Private Sub ImportReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ImportReportsToolStripMenuItem.Click
        Dim afrm As New frmImportStats
        afrm.ShowDialog()
    End Sub



    Private Sub DiaryWeeksToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles DiaryWeeksToolStripMenuItem.DropDownOpening
        Dim settings As New Common.cSettings

        DiaryWeeksToolStripMenuItem.DropDownItems.Clear()
        For t As Integer = 2 To 6
            Dim windowNewMenu As New ToolStripMenuItem(t & " weeks", Nothing, New EventHandler(AddressOf setWeeks))
            windowNewMenu.Tag = t
            If t = settings.DiaryShowWeeks Then
                windowNewMenu.Checked = True
            End If
            DiaryWeeksToolStripMenuItem.DropDownItems.Add(windowNewMenu)
        Next
    End Sub
    Private Sub setWeeks(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim s As ToolStripMenuItem = sender
        Dim database As New Common.DataLayer
        database.ExecuteSQL("Update settings set Diaryshowweeks=" & s.Tag)
    End Sub

    Private Sub ReleaseNextMonthCallbacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ReleaseNextMonthCallbacksToolStripMenuItem.Click
        If MsgBox("Releasing next months Call Backs" & vbCrLf & vbCrLf & "IS NOT REVERSABLE" & vbCrLf & vbCrLf & "Are you sure you want to do this?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim sSQL As String
            sSQL = "UPDATE Companies"
            sSQL = sSQL & " SET HoldUntil = GETDATE()"
            sSQL = sSQL & " WHERE (CompanyStatus = 'CallBack') AND (MONTH(HoldUntil) = " & Now.AddMonths(1).Month & " ) AND (YEAR(HoldUntil) = " & Now.AddMonths(1).Year & ")"
            Dim database As New Common.DataLayer
            database.ExecuteSQL(sSQL)
        End If
    End Sub


    Private Sub ForCompaniesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ForCompaniesToolStripMenuItem.Click
        Using afrm As New frmSearch2()
            afrm.ShowDialog()
        End Using
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click





        'Dim sSQL As String
        'sSQL = "Select * from  DiaryItems where type='CA' and ItemDate > '1 Jan 2013 00:00'"

        'Dim database As New Common.DataLayer

        'Dim ds As DataSet = database.ExecuteSQL(sSQL)
        'Button2.Text = ds.Tables(0).Rows.Count
        'Application.DoEvents()
        'For Each dr As DataRow In ds.Tables(0).Rows
        '    Dim i As Integer = dr("ID")
        '    Dim app As New Common.cAppointment
        '    app.load(i)

        '    If dr("ID") = 0 Or dr("ID") = 1 Or dr("ID") = 2 Then
        '    Else
        '        If i / 2 = CInt(i / 2) Then
        '            app.setWasInsured(2)
        '        Else
        '            app.setWasInsured(1)
        '        End If
        '    End If
        '    Button2.Text = Button2.Text - 1
        '    Application.DoEvents()
        'Next




        'Dim Ds As DataSet
        'Dim ssql As String
        '' sort out appointments
        'ssql = "SELECT     CompanyID, PolicyStarts FROM         DiaryItems WHERE     (Status = 4) ORDER BY PolicyStarts"
        'Ds = database.ExecuteSQL(ssql)
        'For Each dr As DataRow In Ds.Tables(0).Rows
        '    Dim tsql As String
        '    Dim d As DateTime
        '    d = dr("PolicyStarts")
        '    tsql = String.Format("Update Companies Set TPSUntil='{0}' where ID = {1}", d.AddYears(2).ToLongDateString, dr("companyID"))
        '    database.ExecuteSQL(tsql)
        'Next



        'Dim afrm As New frmOfficePerformance
        'afrm.Show()

        ' '' Dim database As New Common.DataLayer
        ' '' Dim Ds As DataSet
        ' '' Dim ssql As String
        ' '' ssql = "SELECT        ID, CallEndStatus, CallEndTime, CompanyID  FROM    CompanyHistory WHERE   (CallEndStatus = 'NotInterested')"
        ' '' Ds = database.ExecuteSQL(ssql)


        ' ''Button2.Text = Ds.Tables(0).Rows.Count
        ' '' For Each DR As DataRow In Ds.Tables(0).Rows
        ' ''     Dim aDS As DataSet
        ' ''     aDS = database.ExecuteSQL("UPDate CompanyHistory Set Hide=1 WHERE (CompanyID = " & DR("CompanyID") & ") AND (ID <= " & DR("ID") & ")")
        ' ''     Button2.Text = Button2.Text - 1
        ' ''     Application.DoEvents()
        ' '' Next

        ' '' ' sort out sepervisor 
        ' '' ssql = "SELECT        ID, CallEndStatus, CallEndTime, CompanyID  FROM    CompanyHistory WHERE   (CallEndStatus = 'Supervisor')"
        ' '' Ds = database.ExecuteSQL(ssql)

        ' '' Button2.Text = Ds.Tables(0).Rows.Count
        ' '' For Each DR As DataRow In Ds.Tables(0).Rows
        ' ''     Dim aDS As DataSet
        ' ''     aDS = database.ExecuteSQL("UPDate CompanyHistory Set Hide=1 WHERE (CompanyID = " & DR("CompanyID") & ") AND (ID <= " & DR("ID") & ")")
        ' ''     Button2.Text = Button2.Text - 1
        ' ''     Application.DoEvents()
        ' '' Next


        ' '' ' sort out sepervisor 
        ' '' ssql = "SELECT     CompanyID  FROM   CompanyHistory WHERE     (CallFailureReason = 'Killed By Manager')"
        ' '' Ds = database.ExecuteSQL(ssql)

        ' '' Button2.Text = Ds.Tables(0).Rows.Count
        ' '' For Each DR As DataRow In Ds.Tables(0).Rows
        ' ''     Dim aDS As DataSet
        ' ''     aDS = database.ExecuteSQL("UPDate Companies Set CompanyStatus='SupervisorS' WHERE (ID = " & DR("CompanyID") & ") ")
        ' ''     Button2.Text = Button2.Text - 1
        ' ''     Application.DoEvents()
        ' '' Next

        ' '' database.ExecuteSQL("UPDate Companies Set CompanyStatus='ColdCall', AllowCall=1, AgentID=0  WHERE companyStatus ='Supervisor'")

        ' '' database.ExecuteSQL("UPDate Companies Set CompanyStatus='Supervisor'  WHERE companyStatus ='SupervisorS'")



        ' TimerDesks.Enabled = False
        'Dim ssql As String = " SELECT ID from Diaryitems where status<0 "
        'Dim database As New Common.DataLayer
        'Dim ds As DataSet
        '' Dim ads As DataSet
        'ds = database.ExecuteSQL(ssql)
        'Button2.Text = ds.Tables(0).Rows.Count
        'For Each DR As DataRow In ds.Tables(0).Rows
        '    Dim afrm As New frmAppoinmentDetail(DR("ID"))
        '    afrm.ShowDialog()
        'Next
        'Dim database As New Common.DataLayer
        'Dim ssql As String = ""
        'ssql = "SELECT  PostcodeLocations.ID, PostcodeLocations.Latitude, PostcodeLocations.Longitude, PostCodePrefixes.Prefix, PostcodeLocations.PostcodeSuffix"
        'ssql = ssql & " FROM  PostCodePrefixes RIGHT OUTER JOIN"
        'ssql = ssql & " PostcodeLocations ON PostCodePrefixes.ID = PostcodeLocations.PostcodePrefixID "
        'ssql = ssql & " Where PostcodeLocations.ID = 2578"
        'Dim ds As DataSet
        'ds = database.ExecuteSQL(ssql)
        'Button2.Text = 0
        'Dim counter As Integer = 1
        'Label1.Text = 0
        'For Each DR As DataRow In ds.Tables(0).Rows
        '    getLatLong(DR("Prefix") & " " & DR("PostcodeSuffix"))
        '    If dLatitude = 0 Or dLongitude = 0 Then
        '        ' MsgBox("Opps - " & DR("ID"))
        '        Label1.Text = Label1.Text + 1
        '    Else

        '        ' If (dLatitude - DR("Latitude") > 0.05) Or (dLongitude - DR("Longitude") > 0.05) Then
        '        Console.WriteLine(counter)
        '        Console.WriteLine(dLatitude & " - " & DR("Latitude") & "   " & dLongitude & " - " & DR("Longitude"))
        '        Console.WriteLine(Format((dLatitude - DR("Latitude")) * 69.1, "##0.00") & "   " & Format((dLongitude - DR("Longitude")) * 53, "##0.00"))
        '        counter += 1
        '        lblchanged.Text = counter
        '        Dim asql As String = "UPDATE PostcodeLocations Set Latitude=" & dLatitude & ", Longitude=" & dLongitude & " WHERE ID=" & DR("ID")
        '        database.ExecuteSQL(asql)
        '        'End If
        '    End If
        '    Button2.Text = Button2.Text + 1
        '    Application.DoEvents()
        'Next
    End Sub
    Dim dLatitude As Double
    Dim dLongitude As Double
    Private Sub getLatLong(ByVal postcode As String)

        dLatitude = 0
        dLongitude = 0

        'scrapes the lat and long from street map



        Dim URL As String = "http://www.streetmap.co.uk/streetmap.dll?GridConvert?type=Postcode&name=" & postcode

        Try

            Dim request As WebRequest = WebRequest.Create(URL)

            Dim response As WebResponse = request.GetResponse()

            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                Dim str As String = reader.ReadToEnd()
                Dim apoint As Integer = InStr(str, "<strong>Lat</strong> (WGS84)") + 85
                Dim tpoint As Integer = InStr(apoint, str, "(")
                Dim tstr As String = str.Substring(tpoint, 9)
                If tstr = "s) here a" Then
                    'not a vlid postcode
                    Exit Sub
                End If
                dLatitude = CDbl(tstr)
                apoint = InStr(str, "<strong>Long</strong> (WGS84)") + 85
                tpoint = InStr(apoint, str, "(")
                tstr = str.Substring(tpoint, 9)
                dLongitude = CDbl(tstr)
            End Using

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        End Try



    End Sub




    Public Function getMiles(ByVal Latitude1 As Double, ByVal Longitude1 As Double, ByVal Latitude2 As Double, ByVal Longitude2 As Double) As Integer
        Try
            Dim latlen As Double = (Latitude1 - Latitude2) * 69.1
            Dim longlen As Double = (Longitude1 - Longitude2) * 53
            getMiles = Int(Math.Sqrt((latlen * latlen) + (longlen * longlen)))
        Catch ex As Exception
            Throw ex
        End Try
    End Function




    Private Sub ImportStandardLifeDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ImportStandardLifeDataToolStripMenuItem.Click
        'load the form into the placeholder panel
        Using aFrm As New frmLegacyImport()
            aFrm.ShowDialog()

        End Using




        ResumeLayout()
    End Sub

    Private Sub CompanyStatisticsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CompanyStatisticsToolStripMenuItem.Click
        Dim afrm As New frmAgenttoCompanyStats
        afrm.ShowDialog()
    End Sub

    Private Sub StandardLifeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles StandardLifeReportToolStripMenuItem.Click
        Dim afrm As New frmReportStandardLife
        afrm.ShowDialog()
    End Sub



    Private Sub RepPerformanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles RepPerformanceToolStripMenuItem.Click
        Dim afrm As New frmRepPerformanceStats

        afrm.ShowDialog()
    End Sub

    Private Sub AgentPerformanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AgentPerformanceToolStripMenuItem.Click
        Dim afrm As New frmAgentPerformance

        afrm.ShowDialog()
    End Sub

    Private Sub AgentActivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AgentActivityToolStripMenuItem.Click
        Dim afrm As New frmAgentActivity
        afrm.ShowDialog()
    End Sub


    Private Sub SuspendCallBacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SuspendCallBacksToolStripMenuItem.Click
        Dim database As New Common.DataLayer
        Dim Ds As DataSet = database.ExecuteSQL("Select * from Users Where id=" & SelectedDesk.Tag)
        If Ds.Tables(0).Rows(0).Item("SuspendCallbacks").ToString = "1" Then
            database.ExecuteSQL("Update users SET SuspendCallbacks=0 where ID=" & SelectedDesk.Tag)
        Else
            database.ExecuteSQL("Update users SET SuspendCallbacks=1 where ID=" & SelectedDesk.Tag)
        End If
    End Sub

    Private Sub AgentToRepsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AgentToRepsToolStripMenuItem.Click
        Dim afrm As New FrmCompaniesAgentsToReps
        afrm.ShowDialog()
    End Sub

    Private Sub RepToAgentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles RepToAgentsToolStripMenuItem.Click
        Dim afrm As New FrmCompaniesRepToAgent
        afrm.ShowDialog()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AdminToolStripMenuItem.Click
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub SupervisorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SupervisorToolStripMenuItem1.Click
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles GeneralToolStripMenuItem.Click
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = False
    End Sub




    Private Sub FixPostcodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles FixPostcodesToolStripMenuItem.Click
        Using afrm As New frmFixPostcodes()
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AppointmentsToolStripMenuItem.Click
        Dim afrm As New frmAgentApps
        afrm.Show()
    End Sub



    Private Sub OrphanedPostcodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OrphanedPostcodesToolStripMenuItem.Click
        Dim afrm As New frmOrphanedPostcodes
        afrm.ShowDialog()
    End Sub




    Private Sub CallbacksAndReshedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CallbacksAndReshedulesToolStripMenuItem.Click
        Using afrm As New frmCheckCallbacks2
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub FutureCallbacksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles FutureCallbacksToolStripMenuItem.Click
        Using afrm As New frmYearsCallbacks("Agent")
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub RepFutureCallbacksToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles RepFutureCallbacksToolStripMenuItem.Click
        Using afrm As New frmYearsCallbacks("Rep")
            afrm.ShowDialog()
        End Using
    End Sub


    Private Sub ChangeAreaToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ChangeAreaToolStripMenuItem.Click

    End Sub

    Private Sub MultiRepAppointmentsToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles MultiRepAppointmentsToolStripMenuItem.Click
        Using afrm As New frmMultiRepDiaryEntry
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub NewPerformanceStatsToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles NewPerformanceStatsToolStripMenuItem.Click
        Using afrm As New frmPerformanceNew
            afrm.ShowDialog()
        End Using

    End Sub

    Private Sub ManageProvidersToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ManageProvidersToolStripMenuItem.Click
        Using afrm As New frmManageProvierList
            afrm.ShowDialog()
        End Using
    End Sub



    Private Sub SoldToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles SoldToolStripMenuItem.Click
        Using afrm As New frmBook With {.Type = "Sale"}
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub TransfersToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles TransfersToolStripMenuItem.Click
        Using afrm As New frmBook With {.Type = "Transfer"}
            afrm.ShowDialog()
        End Using
    End Sub


    Private Sub UpdateTPSToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles UpdateTPSToolStripMenuItem.Click
        Dim aFrm As New frmImportTPS() With {.TopLevel = False}

        SuspendLayout()
        pnlPlaceholderWorkspace.Controls.Clear()
        pnlPlaceholderWorkspace.Controls.Add(aFrm)

        With aFrm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

        ResumeLayout()


    End Sub

    Private Sub CompanyAllocationsToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles CompanyAllocationsToolStripMenuItem.Click
        Using afrm As New frmRecordAllocation
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub CallbackStatsToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles CallbackStatsToolStripMenuItem.Click
        Using afrm As New frmCallbackStats
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub CancelledHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelledHistoryToolStripMenuItem.Click
        Using afrm As New frmCancelledReport
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub SurveySummariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurveySummariesToolStripMenuItem.Click
        Using afrm As New frmSurveySummary
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub ChangeEmaiPasswordlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeEmaiPasswordlToolStripMenuItem.Click
        Using afrm As New FrmSetEmailPassword
            afrm.ShowDialog()
        End Using
    End Sub

    Private Sub ManualAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualAppointmentToolStripMenuItem.Click
        Dim afrm As frmDiariesManager = frmDiariesManager.GetInstance()
        afrm.ShowDialog()
    End Sub
End Class