Imports CADNet.CallQueues.Common

Public Class frmAgent


    Friend WithEvents oDialer As Common.cDialer

    'Public Event CallFinished()
    Public Event gotContactInfo_Changed()

    Private bGotContactInfo As Boolean
    Public WithEvents App As cAgentApp
    Private ThisCompany As Common.cCompany
    Private WithEvents Script As ScriptEngine
    Public counter As Integer
    Public nextAction As String = ""
    Public IsInTrainingMode As Boolean
    Public IsInDebugMode As Boolean


    Dim isloading As Boolean = True
    Dim FirstTime As Boolean = True
    Dim RootTread As Integer
    Dim Debug As New FrmDebug

    Dim ChangedNumber As Boolean

    Public CadnetDisconnecting As Boolean
    Dim newCompany As Boolean
    Dim LegalEntities As List(Of cSimpleItem)

    Private Sub frmAgent_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        App.CloseDesk()

        App.WriteAgentEvent("Application Closed")
    End Sub
    Private Sub frmAgent_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'get an reference to the application
        Text = "Agent V5.02 (Cloud)"
        Debug.AddMesage("master thread thread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
        RootTread = System.Threading.Thread.CurrentThread.ManagedThreadId
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim bUseDialer As Boolean = False

        LoadLegalEntities()
        If InStr(Environment.CommandLine, "/T") > 0 Then
            IsInTrainingMode = True
            MsgBox("Training Mode")
            Text = Text & " TRAINING MODE"
            Database.SetTraining(True)
            btnEmulatedisconnect.Visible = True
        ElseIf InStr(Environment.CommandLine, "/D") > 0 Then
            Text = Text & " DEBUG MODE"
            MsgBox("Debug Mode")
            IsInDebugMode = True
            Database.DebugMode = True
            Debug.Show()
            bUseDialer = True
        Else
            IsInTrainingMode = False
            Database.SetTraining(False)
            btnEmulatedisconnect.Visible = False
            bUseDialer = True
        End If
        If bUseDialer Then
            Try
                oDialer = New cDialer
            Catch ex As Exception

                MessageBox.Show(ex.Message)
                WriteLog(eSource.AgentApp, "Can't use dialer: " & ex.Message)

            End Try
        End If

        App = cAgentApp.GetInstance

        Dim Params As New Collection
        Database.CreateParameter(Params, "@TerminalName", SqlDbType.NVarChar, My.Computer.Name)
        Database.ExecuteSP("spTerminalSave", Params)

        Params = New Collection
        Database.CreateParameter(Params, "@TerminalName", SqlDbType.NVarChar, My.Computer.Name)
        Dim DS As DataSet = Database.ExecuteSP("spGetTerminal", Params)
        Dim bNoDesk As Boolean = False
        If DS.Tables(0).Rows.Count = 0 Then
            'no row for the desk
            bNoDesk = True
        Else
            If DS.Tables(0).Rows(0).Item("Extension").ToString.Trim = "" Then
                'there is a record, but no allocated extension

                bNoDesk = True
            Else
                ' store Extension Number and DeskID
                App.DeskID = DS.Tables(0).Rows(0).Item("ID").ToString
                'App.DeskID = 6
            End If
        End If

        If bNoDesk Then
            MessageBox.Show("Your computer has not been properly registered.  Please contact your manager")
        End If

        ToggleForm(False)
        ToggleStateofForm(False)

        '    AddHandler CallFinished, AddressOf Me.HandleCallFinished
        tmrStartup.Enabled = True
        App.UpdateDeskStatus("Application Running")

    End Sub

    Private Sub LoadLegalEntities()
        LegalEntities = New List(Of cSimpleItem)

        LegalEntities.Add(New cSimpleItem(0, ""))
        LegalEntities.Add(New cSimpleItem(1, "Limited"))
        LegalEntities.Add(New cSimpleItem(2, "Limited Partnership"))
        LegalEntities.Add(New cSimpleItem(3, "PLC"))
        LegalEntities.Add(New cSimpleItem(4, "Partnership"))
        LegalEntities.Add(New cSimpleItem(5, "Sole Trader"))

        cboLegalEntity.DataSource = LegalEntities
    End Sub

    Public Property GotContactInfo() As Boolean
        Get
            GotContactInfo = bGotContactInfo
        End Get
        Set(ByVal value As Boolean)
            If bGotContactInfo <> value Then
                bGotContactInfo = value
                RaiseEvent gotContactInfo_Changed()
            End If
        End Set
    End Property

    'Public Sub FireEvent()
    '    RaiseEvent CallFinished()
    'End Sub
    Private Sub HandleCallFinished(ByVal type As Common.cDialer.eDisconnectType)
        Debug.AddMesage("handlecall " & type.ToString)

        Select Case type
            Case cDialer.eDisconnectType.Busy
                Debug.AddMesage("Busy get next call ")
                ThisCompany.ThisCall.EndCallReschedule(Now.AddMinutes(15), "Busy ")
                Script.EndState(ScriptEngine.States.Starting, ScriptEngine.States.Finished)
            Case cDialer.eDisconnectType.BadAddress, cDialer.eDisconnectType.NoAnswer
                ThisCompany.ThisCall.EndCallNotRecognised(type.ToString)
                Script.EndState(ScriptEngine.States.Starting, ScriptEngine.States.Finished)
            Case cDialer.eDisconnectType.Normal, cDialer.eDisconnectType.Other, cDialer.eDisconnectType.Rejected
                If Not ChangedNumber Then
                    Try
                        Debug.AddMesage("not busy start counter ")
                        FirstTime = True
                        counter = 30
                        App.UpdateDeskTelephone("")
                    Catch ex As Exception
                        MsgBox("HandleCallFinished - " & ex.Message)
                    End Try
                    counterDown()
                End If
                ChangedNumber = False
            Case Else
                MsgBox("EndType not recognised - " & type.ToString)
                If Not ChangedNumber Then
                    Try
                        Debug.AddMesage("not busy start counter ")
                        FirstTime = True
                        counter = 30
                        App.UpdateDeskTelephone("")
                    Catch ex As Exception
                        MsgBox("HandleCallFinished - " & ex.Message)
                    End Try
                    counterDown()
                End If
                ChangedNumber = False
        End Select

    End Sub


    Private Sub tmrStartup_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles tmrStartup.Tick
        tmrStartup.Enabled = False
        CmbNextAction.Items.Add("")
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

                '   Dim aUser As New Common.cUser
                Dim bResult As Boolean = App.Login(aFrm.Username, aFrm.Password)

                Cursor = Cursors.Default
                Me.Text = Me.Text + " DB : " + App.GetDatabaseName()
                If bResult Then
                    'login worked
                    App.UpdateDeskStatus("Logged On")
                    App.UpdateDeskUser(App.User.ID)
                    App.WriteAgentEvent("Logged In")


                    If App.User.UserLevelID = Common.eUserLevel.Developer Then
                        lblMagicNumber.Visible = True
                        ToolStatus.Visible = True
                        btnEmulatedisconnect.Visible = True
                    Else
                        lblMagicNumber.Visible = True
                        ToolStatus.Visible = True
                        btnEmulatedisconnect.Visible = False
                    End If

                    '' preload webservice
                    'Dim tempwaitstring As String = lblPleaseWait.Text
                    'lblPleaseWait.Text = "Preloading Postcode Web Service"
                    'Dim frmPostcode As frmGetPostcode
                    'frmPostcode = New frmGetPostcode("WR2 6NJ", Me)
                    'lblPleaseWait.Text = tempwaitstring


                    'by now the remoting will have completed....
                    ToggleForm(True)

                    ' this loads sidebar information 
                    LoadInfo()


                    GetNextCompany()
                    lblPleaseWait.Visible = False
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


    End Sub




    Public Sub ToggleForm(ByVal State As Boolean)

        'If State Then
        '    App.RegisterAgent()

        'Else
        '    'todo 'de-enable the form (lock session)
        'End If
    End Sub

    Private Sub GetNextCompany()
        If nextAction = "Logoff" Then
            Console.WriteLine("Exiting App")
            Application.Exit()
            Exit Sub
        End If
        newCompany = True
        ' System.Threading.Thread.Sleep(2000)
        Console.WriteLine(" Getting next Company")
        CountDown.Enabled = False
        Dim storeText As String = Text
        Try
            ThisCompany = App.GetNextCompany
            Text = storeText
        Catch ex As Exception
            Select Case ex.Message
                Case "No more Companies to call"
                    MessageBox.Show(String.Format("There are no more companies to call in your area.{0}{0}Please contact your supervisor", vbCrLf))
                    Exit Sub
                Case Else
                    MessageBox.Show(String.Format("Unable to get Company: {0}{1}{1}Please contact your supervisor", ex.Message, vbCrLf))
                    Exit Sub
            End Select
        End Try

        ShowCompany()
        Dim ThisCall As cCallHistory = ThisCompany.ThisCall

        App.UpdateDeskStatus("Dialing")
        App.UpdateDeskTelephone(ThisCall.Company.Telephone)

        Script = New ScriptEngine(pnlScriptContainer, App.User, ThisCall)

        If oDialer Is Nothing Then
            Script.Start(False)
        Else
            Script.Start(True)
        End If

        If App.User.UserLevelID = Common.eUserLevel.Developer Then
            lblMagicNumber.Visible = True
        Else
            lblMagicNumber.Visible = True
        End If

        lblCounter.Text = "Details"
        counter = 30
        CountDown.Enabled = False
        lblCounter.BackColor = Color.LightGoldenrodYellow
        lblCounter.ForeColor = Color.Black
        Try
            CmbNextAction.Text = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        isloading = False
    End Sub

    Public Sub ShowCompany()

        pnlCompanyInfo.Visible = True
        GotContactInfo = True
        With ThisCompany
            lblMagicNumber.Text = "CompanyID=" & ThisCompany.ID.ToString

            cmbTitle.Text = .ContactTitle
            txtCompanyName.Text = .CompanyName
            txtContactForeName.Text = .ContactForename
            txtContactSurname.Text = .ContactSurname
            txtContactPosition.Text = .ContactPosition
            lblAddress1.Text = .Address1
            lblAddress2.Text = .Address2
            lblAddress3.Text = .Address3
            lblTown.Text = .Town
            lblCounty.Text = .County
            lblPostcode.Text = .Postcode
            lblSDM.Text = .SeniorDecisionMaker

            lblTel.Text = .Telephone

            cmbEmployees.Text = ThisCompany.Employees

            txtMobile.Text = .MobileTelephone
            txtDirectDial.Text = .DirectTelephone

            BtnDialDirect.Enabled = Common.ValidateTelephone(txtDirectDial.Text) <> ""
            BtnMobile.Enabled = Common.ValidateTelephone(txtMobile.Text) <> ""

            txtFax.Text = .Fax
            txtEmail.Text = .Email

            lblArea.Text = .Area
            lblRep.Text = .Rep.RealName

            tslGroupCompany.Text = .GroupCompany

            If ThisCompany.LegalEntity Is Nothing Then
                cboLegalEntity.SelectedValue = 0
            Else
                cboLegalEntity.SelectedValue = ThisCompany.LegalEntity
            End If
            lblConsentGivenBy.Text = ThisCompany.ConsentGivenBy

            If (ThisCompany.ConsentGivenByDate Is Nothing) Then
                lblConsentDate.Text = ""
            Else

                lblConsentDate.Text = ThisCompany.ConsentGivenByDate.Value.ToLongDateString
            End If

            If (ThisCompany.ConsentUntil Is Nothing) Then
                lblConsentUntil.Text = ""
            Else
                lblConsentUntil.Text = ThisCompany.ConsentUntil.Value.ToLongDateString
            End If

            lblConsentPosition.Text = ThisCompany.ConsentGivenByPosition


            If .PolicyExpires = #12:00:00 AM# Then
                lblPolicyExpiry.Text = ""
            Else
                lblPolicyExpiry.Text = .PolicyExpires.ToLongDateString
            End If

            lblPolicyProvider.Text = .PolicyProvider


            txtNotes.Text = .Notes
            lvHistory.Items.Clear()

            Dim aItem As ListViewItem

            For Each ahistory As Common.cCallHistory In .History
                If ahistory.Hide = 0 Then
                    aItem = New ListViewItem(ahistory.Agent)
                    aItem.SubItems.Add(String.Format("{0} - {1}", Format(ahistory.CallStarted, "d MMM yy"), ahistory.CallStarted.ToShortTimeString))
                    aItem.SubItems.Add(ahistory.CallStartStatus)
                    aItem.SubItems.Add(ahistory.CallEndStatus)
                    aItem.SubItems.Add(ahistory.CallFailureReason)
                    lvHistory.Items.Add(aItem)
                End If
            Next
        End With
        ToggleStateofForm(True)
        CheckOk()
        TVInfo.Visible = True

    End Sub


    Private Sub ToggleStateofForm(ByVal State As Boolean)

        'column 1
        lbltitle.Enabled = State
        cmbTitle.Enabled = State

        lblPosition.Enabled = State
        lblForename.Enabled = State
        lblSurname.Enabled = State
        lblTelLabel.Enabled = State
        lblFax.Enabled = State
        lblEmail.Enabled = State

        'column 2
        txtContactPosition.Enabled = State
        txtContactForeName.Enabled = State
        txtContactSurname.Enabled = State
        lblTel.Enabled = State
        txtFax.Enabled = State
        txtEmail.Enabled = State

        'column 3
        lblCompany.Enabled = State
        lblAddress.Enabled = State
        lblTownTitle.Enabled = State
        lblCountyTitle.Enabled = State
        lblPostcodelbl.Enabled = State

        'column 4
        txtCompanyName.Enabled = State
        lblPostcode.Enabled = State

        'column 5
        lblPolExp.Enabled = State
        lblPolProv.Enabled = State

        lblAreaLbl.Enabled = State
        lblRepName.Enabled = State

        'column 6
        lblPolicyExpiry.Enabled = State
        lblPolicyProvider.Enabled = State
        lblArea.Enabled = State
        lblRep.Enabled = State

        txtNotes.Enabled = State
        lvHistory.Enabled = State
        Label1.Enabled = State
    End Sub

    Private Sub txtContactPosition_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactPosition.Leave
        ThisCompany.ContactPosition = txtContactPosition.Text
        ThisCompany.Save()
        txtContactPosition.Text = ThisCompany.ContactPosition
    End Sub


    Private Sub txtContactForeName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactForeName.Leave
        With ThisCompany
            .ContactForename = txtContactForeName.Text
            .Save()
            txtContactForeName.Text = .ContactForename
        End With
    End Sub

    Private Sub txtContactSurname_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtContactSurname.Leave
        With ThisCompany
            .ContactSurname = txtContactSurname.Text
            .Save()
            txtContactSurname.Text = .ContactSurname
        End With
    End Sub


    Private Sub txtFax_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFax.Leave
        With ThisCompany
            .Fax = txtFax.Text
            .Save()
        End With
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmail.Leave
        With ThisCompany
            .Email = txtEmail.Text.ToLower
            .Save()
            txtEmail.Text = .Email
        End With
    End Sub

    Private Sub txtCompanyName_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCompanyName.Leave
        With ThisCompany
            .CompanyName = txtCompanyName.Text
            .Save()
            txtCompanyName.Text = .CompanyName
        End With
    End Sub

    Private Sub Script_Completed() Handles Script.Completed
        GetNextCompany()
    End Sub
    Private Sub LoadInfo()
        isloading = True
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("Select * from InfoCategories order by sortorder")
        Dim CatDS As DataSet
        Dim aRow As DataRow
        Dim cRow As DataRow
        Dim anode As TreeNode
        Dim cnode As TreeNode

        Dim sTitle As String = ""
        TVInfo.Nodes.Clear()
        For Each aRow In DS.Tables(0).Rows
            anode = TVInfo.Nodes.Add(Common.TitleCase(aRow("Title")))
            anode.Tag = "Header"
            anode.NodeFont = New Font(TVInfo.Font, FontStyle.Bold)
            sTitle = aRow("Title")
            If sTitle.Trim.Length < 1 Then
                sTitle = "<No Title>"
            End If
            anode.Text = sTitle
            Console.WriteLine(anode.NodeFont)
            CatDS = Database.ExecuteSQL("Select * from InfoItems where CategoryID = " & aRow("ID") & " order by sortorder")

            For Each cRow In CatDS.Tables(0).Rows
                sTitle = Common.TitleCase(cRow("Title"))
                If sTitle.Trim.Length < 1 Then
                    sTitle = "<No Title>"
                End If
                cnode = anode.Nodes.Add(sTitle)
                cnode.Tag = cRow("Data")
            Next
        Next
        TVInfo.ExpandAll()
        SetInfoPointsVisability(True)
    End Sub
    Private Sub SetInfoPointsVisability(ShowTree As Boolean)
        If ShowTree Then
            lcViewer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lcButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lcTree.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lcViewer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lcButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lcTree.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

    End Sub

    Private Sub TVInfo_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVInfo.AfterSelect
        If isloading Then
        Else
            Dim atree As TreeView = sender
            Dim anode As TreeNode = atree.SelectedNode
            If anode.Tag <> "Header" Then
                Try
                    rtfViewer.RtfText = anode.Tag

                Catch ex As Exception
                    rtfViewer.RtfText = ""
                End Try
                SetInfoPointsVisability(False)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        TVInfo.SelectedNode = Nothing
        SetInfoPointsVisability(True)
    End Sub

    Private Sub cmbTitle_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTitle.Leave
        With ThisCompany
            .ContactTitle = cmbTitle.Text
            .Save()
        End With
    End Sub

    Private Sub txtNotes_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtNotes.Leave
        With ThisCompany
            .Notes = txtNotes.Text
            .Save()
        End With
    End Sub

    Private Sub counterDown()


        ' Debug.AddMesage("CounterDownEntered tread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
        Try
            CountDown.Enabled = False
            newCompany = False
            counter = counter - 1
            lblCounter.Text = "updating satus "
            App.UpdateDeskStatus(counter & " Seconds to complete Call")
            lblCounter.Text = String.Format(" Time to Complete Call .... {0} Seconds", counter)
            If counter < 15 Then
                lblCounter.BackColor = Color.SandyBrown
                lblCounter.ForeColor = Color.White
            End If
            If counter < 0 Then
                lblCounter.BackColor = Color.Red
                lblCounter.ForeColor = Color.White
                If FirstTime Then
                    App.UpdateDeskStatus("Exceeded Call End Time")
                    App.WriteAgentEvent("Exceeded Call End Time")
                    FirstTime = False
                End If
            End If
            If Not newCompany Then
                CountDown.Enabled = True
            End If
            'Debug.AddMesage("CountDown Enabled tread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
        Catch ex As Exception
            MsgBox("Countdown - " & ex.Message)
        End Try
        ' Debug.AddMesage("CounterDownLeft tread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
    End Sub
    Private Sub CountDown_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles CountDown.Tick
        counterDown()
    End Sub

    Private Sub CmbNextAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CmbNextAction.SelectedIndexChanged
        nextAction = CmbNextAction.Text
    End Sub


    Private Sub CheckOk()
        Dim OKtoSave As Boolean = True
        OKtoSave = True
        If cmbTitle.Text = "" Then
            OKtoSave = False
            cmbTitle.BackColor = Color.LightCoral
            cmbTitle.Text = ""
        Else
            cmbTitle.BackColor = Color.White
        End If

        If txtContactSurname.Text.Trim = "" Then
            txtContactSurname.BackColor = Color.LightCoral
            txtContactSurname.Text = ""
            OKtoSave = False
        Else
            txtContactSurname.BackColor = Color.White
        End If

        If txtContactPosition.Text.Trim = "" Then
            txtContactPosition.BackColor = Color.LightCoral
            txtContactPosition.Text = ""
            OKtoSave = False
        Else
            txtContactPosition.BackColor = Color.White
        End If
        GotContactInfo = OKtoSave
    End Sub


    Private Sub cmbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTitle.SelectedIndexChanged
        CheckOk()
    End Sub

    Private Sub txtContactForeName_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactForeName.TextChanged
        CheckOk()
    End Sub

    Private Sub txtContactSurname_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactSurname.TextChanged
        CheckOk()
    End Sub

    Private Sub txtContactPosition_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContactPosition.TextChanged
        CheckOk()
    End Sub


    Private Sub btnChangeTelephone_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnChangeTelephone.Click

        Dim aFrm As New Common.frmChangeTelephone(ThisCompany)

        If aFrm.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        'update the company with the new telephone
        With ThisCompany

            'if you set the telephone number to a used telephone number it will throw an exception
            'if its ok, we need to drop the exisitng call and dial the new number (from a button)
            Dim sOldTelephone As String = .Telephone
            Try
                .Telephone = RemoveNonNumerics(aFrm.txtTelephone.Text)
                .Save()
                lblTel.BackColor = Color.White
            Catch ex As Exception
                Select Case ex.Message
                    'Case "Telephone number is already in use"
                    '    Dim sMsg As String = "That telephone number is already allocated to a different company."
                    '    sMsg = sMsg & vbCrLf & "Please confirm that it is correct" '& vbCrLf
                    '    MessageBox.Show(sMsg)
                    '    Exit Sub
                    Case Else
                        MessageBox.Show("Cannot change telephone number: " & vbCrLf & ex.Message)
                        Exit Sub
                End Select
            End Try

            lblTel.Text = ThisCompany.Telephone

            If IsInTrainingMode Then

            Else

                If sOldTelephone <> .Telephone Then
                    'the telephone number has changed, so we need to drop the line and dial the new number
                    Dim sMsg As String = String.Format("Click OK to dial the new number:{0}{1}{2}", vbCrLf, vbTab, ThisCompany.Telephone)

                    'Dim R As String = App.CheckTPSOK(.Telephone)
                    'Select Case R
                    '   Case "OK"

                    Dim oDR As DialogResult = MessageBox.Show(sMsg, "Click OK to dial the new number", MessageBoxButtons.OKCancel)

                    'we allow a cancel in case something has gone wrong
                    If oDR <> DialogResult.OK Then
                        Exit Sub
                    End If

                    Try
                        ChangedNumber = True
                        oDialer.Disconnect()

                    Catch ex As Exception

                    End Try

                    If cAgentApp.GetInstance.User.UserLevelID = Common.eUserLevel.Developer Then
                        'Dim sNumber As String = ""
                        'Dim oFrm As New frmNumberToDial
                        'oFrm.ShowDialog()
                        'sNumber = oFrm.Number
                        'oDialer = New Common.cDialer
                        'oDialer.NumberToDial = sNumber
                        'oDialer.Dial()
                        lblCounter.Text = "Details"
                        counter = 30
                        CountDown.Enabled = False
                        lblCounter.BackColor = Color.LightGoldenrodYellow
                        lblCounter.ForeColor = Color.Black
                    Else
                        ' System.Threading.Thread.Sleep(2000)
                        oDialer = New Common.cDialer
                        oDialer.NumberToDial = ThisCompany.Telephone
                        oDialer.Dial()
                        lblCounter.Text = "Details"
                        counter = 30
                        CountDown.Enabled = False
                        lblCounter.BackColor = Color.LightGoldenrodYellow
                        lblCounter.ForeColor = Color.Black
                    End If
                    '    Case "TPS"
                    'MessageBox.Show("New number is TPS, Press OK to move to next call", "Warning", MessageBoxButtons.OK)
                    '.TPSUntil = Now.AddDays(-1)
                    '.ThisCall.EndCallTPS()
                    'Script.EndState(ScriptEngine.States.TPS, ScriptEngine.States.Finished)
                    'End Select
                End If
            End If

        End With
    End Sub

    Private Sub oDialer_Connected(ByVal CalledNumber As String) Handles oDialer.Connected
        ToolStatus.Text = ("Connected call to " & CalledNumber & " - " & Now.ToLongTimeString)
        App.UpdateDeskStatus("Connected")
        Me.newCompany = True
    End Sub

    Private Sub oDialer_Debug(ByVal Location As String, ByVal Comment As String) Handles oDialer.Debug
        ' MessageBox.Show("Dialer Debug: " & vbCrLf & "Location: " & Location & vbCrLf & vbCrLf & Comment)
    End Sub

    Private Delegate Sub DelHandleCallFinished(ByVal type As Common.cDialer.eDisconnectType)

    Private Sub oDialer_Disconnected(ByVal CalledNumber As String, ByVal Type As Common.cDialer.eDisconnectType) Handles oDialer.Disconnected
        Try
            ToolStatus.Text = ("Disconnected call to " & CalledNumber & " - " & Type.ToString & " " & Now.ToLongTimeString)
            Debug.AddMesage("Disconnect Event Fired tread " & System.Threading.Thread.CurrentThread.ManagedThreadId)
        Catch ex As Exception
        End Try
        If System.Threading.Thread.CurrentThread.ManagedThreadId = RootTread Then
            Debug.AddMesage("call handlecall directly " & System.Threading.Thread.CurrentThread.ManagedThreadId)
            HandleCallFinished(Type)
        Else
            Debug.AddMesage("call handlecall delegated " & System.Threading.Thread.CurrentThread.ManagedThreadId)
            Dim param() As Object = {Type}
            Dim oDel As [Delegate] = CType(AddressOf HandleCallFinished, DelHandleCallFinished)
            Invoke(oDel, param)
        End If

    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TimeTick_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles TimeTick.Tick
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub txtDirectDial_LostFocus(sender As Object, e As EventArgs) Handles txtDirectDial.LostFocus
        ThisCompany.DirectTelephone = txtDirectDial.Text
        ThisCompany.Save()
    End Sub



    Private Sub txtDirectDialtxt_TextChanged(sender As System.Object, e As EventArgs) Handles txtDirectDial.TextChanged
        BtnDialDirect.Enabled = Common.ValidateTelephone(txtDirectDial.Text) <> ""
    End Sub

    Private Sub txtMobile_LostFocus(sender As Object, e As EventArgs) Handles txtMobile.LostFocus
        ThisCompany.MobileTelephone = txtMobile.Text
        ThisCompany.Save()
    End Sub

    Private Sub txtMobile_TextChanged(sender As System.Object, e As EventArgs) Handles txtMobile.TextChanged
        BtnMobile.Enabled = Common.ValidateTelephone(txtMobile.Text) <> ""
    End Sub

    Private Sub BtnDialMain_Click(sender As System.Object, e As EventArgs) Handles BtnDialMain.Click
        Callnumber(ThisCompany.Telephone)
    End Sub


    Private Sub Callnumber(tel As String)
        Try
            ChangedNumber = True
            oDialer.Disconnect()
        Catch ex As Exception
        End Try
        oDialer = New Common.cDialer() With {.NumberToDial = tel}
        oDialer.Dial()
        lblCounter.Text = "Details"
        counter = 30
        CountDown.Enabled = False
        lblCounter.BackColor = Color.LightGoldenrodYellow
        lblCounter.ForeColor = Color.Black
    End Sub

    Private Sub BtnDialDirect_Click(sender As System.Object, e As EventArgs) Handles BtnDialDirect.Click
        Callnumber(ThisCompany.DirectTelephone)
    End Sub

    Private Sub BtnMobile_Click(sender As System.Object, e As EventArgs) Handles BtnMobile.Click
        Callnumber(ThisCompany.MobileTelephone)
    End Sub


    Private Sub cmbEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployees.SelectedIndexChanged
        ThisCompany.Employees = cmbEmployees.Text
        ThisCompany.Save()
    End Sub

    Private Sub cboLegalEntity_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLegalEntity.SelectedValueChanged
        If ThisCompany Is Nothing = False Then
            ThisCompany.LegalEntity = cboLegalEntity.SelectedValue
            ThisCompany.Save()
            ShowHideConsent()
        End If

    End Sub

    Private Sub ShowHideConsent()
        'If ThisCompany.LegalEntity > 0 And ThisCompany.LegalEntity < 4 Then
        '    ' hide 
        '    ShowConsent(False)
        'Else
        '    'show
        '    ShowConsent(True)
        'End If

    End Sub

    Public Sub ShowConsent(value As Boolean)
        lblConsentDate.Visible = value
        lblConsentGivenBy.Visible = value
        lblConsentPosition.Visible = value
        lblConsentUntil.Visible = value
        lblconsentt1.Visible = value
        lblconsentt2.Visible = value
        lblconsentt3.Visible = value
        lblconsentt4.Visible = value
        btnSetConsent.Visible = value
    End Sub

    Private Sub btnSetConsent_Click(sender As Object, e As EventArgs) Handles btnSetConsent.Click
        Using frm As New frmGetConsent()
            Select Case frm.ShowDialog()
                Case DialogResult.Yes
                    ThisCompany.ConsentGivenBy = frm.txtName.Text
                    ThisCompany.ConsentGivenByPosition = frm.txtContactPosition.Text
                    ThisCompany.ConsentGivenByDate = DateTime.Now
                    ThisCompany.ConsentUntil = DateTime.Now.AddYears(2)
                    ThisCompany.ConsentRefused = False
                    ThisCompany.ConsentCollectedBy = cAgentApp.GetInstance().CurrentUser.RealName
                    ThisCompany.Save()
                    ShowCompany()
                Case DialogResult.No
                    ThisCompany.ConsentGivenBy = frm.txtName.Text
                    ThisCompany.ConsentGivenByPosition = frm.txtContactPosition.Text
                    ThisCompany.ConsentGivenByDate = DateTime.Now
                    ThisCompany.ConsentUntil = DateTime.Now
                    ThisCompany.ConsentRefused = True
                    ThisCompany.ConsentCollectedBy = cAgentApp.GetInstance().CurrentUser.RealName
                    ThisCompany.Save()
                    ShowCompany()
                Case Else
            End Select

        End Using
    End Sub
End Class
