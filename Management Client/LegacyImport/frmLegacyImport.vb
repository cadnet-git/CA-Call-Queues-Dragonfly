Imports Microsoft.VisualBasic.FileIO
'Imports Microsoft.Office.Interop

Public Class frmLegacyImport

    Dim DS As DataSet
    Dim database As New Common.DataLayer
    '  Dim app As New Microsoft.Office.Interop.Excel.Application
    '  Dim eWB As Excel.Workbook
    '   Dim WS As Excel.Worksheet
    Dim NextAgent As Integer
    Dim ext As String = ""
    Dim parser As TextFieldParser

    '  Dim ER As Excel.Range


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBrowse.Click

        BtnStart.Visible = True
        btnChangeAgents.Visible = True
        lvSelected.Visible = True
        With OpenFileDialog1
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = "csv"
            .DereferenceLinks = True
            .Filter = "CSV files (*.csv)|*.csv"
            .FilterIndex = 0
            .Multiselect = False
            .ShowHelp = False
            .ShowReadOnly = False
            .Title = "Select file to import"
            .FileName = ""

            If .ShowDialog = DialogResult.OK Then
                Dim anArray As Array
                anArray = OpenFileDialog1.FileName.Split("\")
                Dim FileName As String = anArray(anArray.Length - 1).ToString
                txtFilename.Text = FileName
                ext = FileName.Substring(Len(FileName) - 3)
                parser = New TextFieldParser(OpenFileDialog1.FileName)
                parser.SetDelimiters(",")
                Dim arrFields As String()
                arrFields = parser.ReadFields()
                For t As Integer = 0 To arrFields.Length - 1
                    Dim tempstr As String = arrFields(t)
                    If tempstr.Trim = "" Then
                        tempstr = "Column: " & t + 1
                    End If
                    Dim si As New Common.cSimpleItem(t, tempstr)
                    cbID.Items.Add(si)
                    cbCompany.Items.Add(si)
                    cbtelephone.Items.Add(si)
                    cbPostcode.Items.Add(si)
                    cbSalutation.Items.Add(si)
                    cbFirstName.Items.Add(si)
                    cbSurname.Items.Add(si)
                    cbPosition.Items.Add(si)
                    cbshortBusiness.Items.Add(si)
                    cboEmployees.Items.Add(si)
                    cbProvider.Items.Add(si)
                    cboRenewal.Items.Add(si)
                    cbHoldUntil.Items.Add(si)
                    cbCompany.DisplayMember = "Title"
                    cbCompany.ValueMember = "Value"
                Next

            End If
        End With
    End Sub



    Private Enum index
        Company = 1
        Telephone = 2
        Postcode = 3
        Salutation = 4
        Firstname = 5
        Surname = 6
        Position = 7
    End Enum

    Private Function CreateCompany(ByRef CompanyID As Integer, ByVal sCompanyName As String, ByVal sTelephone As String,
                                   ByVal sPostcode As String, ByVal iBatchID As Integer, ByVal salutation As String,
                                   ByVal firstname As String, ByVal surname As String, ByVal position As String) As DialogResult

        'returns:
        '   abort if the user clicked cancel
        '   OK if the company was created
        '   Cancel if they clicked skip
        '   None if the stored procedure was unable to create the company (ie it already exisits)


        Dim ThisPostcode As Common.cPostcode = Nothing

        Dim Validated As Boolean = False


        'tidy up the phone number:
        sTelephone = Common.StringManipulation.RemoveNonNumerics(sTelephone)

        'carry on until we get validated data (or kicked out of the loop unvalidated):
        Do Until Validated = True

            If sPostcode = "" And sCompanyName = "" And sTelephone = "" Then
                'the row in the datafile was empty, so just skip it
                Validated = False

                Exit Do
            End If

            Dim sPostcodeValidation As String = Common.cPostcode.ValidatePostcode(sPostcode)
            Dim sTelephoneValidation As String = Common.ValidateTelephone(sTelephone)

            If sPostcodeValidation = "" And sTelephoneValidation <> "" Then
                'both the postcode and telephone number have validated
                Validated = True
            End If

            If Validated Then
                'get the postcode id
                'this save the post code to the save if it aint already there
                'as well as create a location record with a lat/long
                Try
                    ThisPostcode = New Common.cPostcode(sPostcode, iBatchID)
                Catch ex As Exception
                    Validated = False
                End Try
            End If

            If Validated = False Then
                'the data didnt validate, so we need to get the user to correct it
                Dim aFrm As New frmEditImport(sCompanyName, sTelephone, sPostcode)
                Dim DR As DialogResult = aFrm.ShowDialog

                Select Case DR
                    Case DialogResult.Abort
                        'they clicked the stop import button
                        CreateCompany = DialogResult.Abort
                        Exit Function
                    Case DialogResult.OK

                        Dim bTemp As Boolean = Common.cPostcode.ValidatePostcode(aFrm.txtPostcode.Text).Length = 0

                        If bTemp Then
                            'the new postcode validated, so lets see if the telephone does
                            bTemp = Common.ValidateTelephone(aFrm.txtTelephone.Text)
                        End If

                        If bTemp Then
                            'both the new postcode and new tel validate

                            'get the new values and run through the loop again

                            sPostcode = aFrm.txtPostcode.Text
                            sTelephone = aFrm.txtTelephone.Text
                            sCompanyName = aFrm.txtCompany.Text

                        End If


                    Case DialogResult.Cancel
                        'they clicked the skip button
                        Validated = False
                        CreateCompany = DialogResult.Cancel
                        Exit Function
                    Case Else
                        MessageBox.Show("unexpected dialog result during edit postcode: " & DR.ToString)
                        Validated = False
                End Select
            End If


        Loop    'Until Validated = True


        If Validated Then
            'save the company info
            Dim DB As New CADNet.CallQueues.Common.DataLayer

            Dim Params As New Collection
            With DB
                .CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
                .CreateParameter(Params, "@BatchID", SqlDbType.Int, iBatchID)
                .CreateParameter(Params, "@CompanyName", SqlDbType.NVarChar, sCompanyName)
                .CreateParameter(Params, "@Telephone", SqlDbType.NVarChar, sTelephone)
                .CreateParameter(Params, "@PostCodeRaw", SqlDbType.NVarChar, sPostcode)
                .CreateParameter(Params, "@PostCodeID", SqlDbType.Int, ThisPostcode.PrefixID)
                .CreateParameter(Params, "@LocationID", SqlDbType.Int, ThisPostcode.LocationID)
                .CreateParameter(Params, "@Title", SqlDbType.NVarChar, salutation)
                .CreateParameter(Params, "@Forename", SqlDbType.NVarChar, firstname)
                .CreateParameter(Params, "@Surname", SqlDbType.NVarChar, surname)
                .CreateParameter(Params, "@Position", SqlDbType.NVarChar, position)
                .CreateParameter(Params, "@GroupCompanyID", SqlDbType.Int, cbGroupCompany.SelectedItem.Value) ' set GroupCompanyID
            End With

            Dim DS As DataSet = DB.ExecuteSP("spCompanyImport", Params)

            CompanyID = DS.Tables(0).Rows(0).Item("ID")

            If CompanyID < 0 Then
                'MessageBox.Show("Problems!" & vbCrLf & vbCrLf & "insert returned " & iID)
                CreateCompany = DialogResult.None
            Else
                'was created ok
                CreateCompany = DialogResult.OK
            End If
        End If 'validated

    End Function

    Private Sub CboWS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)

        ' now is time to select the agents 
        Dim afrm As New frmSelectUsers
        If afrm.ShowDialog = DialogResult.OK Then
            lvSelected.Items.Clear()
            For Each obj As ListViewItem In afrm.lvSelected.Items
                lvSelected.Items.Add(obj.Clone)
            Next
            btnChangeAgents.Visible = True
            lvSelected.Visible = True
        End If

    End Sub
    Private Function GetBatchID(ByVal Filename As String) As Integer
        'get a batch id
        Dim Params As New Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
        Database.CreateParameter(Params, "@FileName", SqlDbType.NVarChar, Filename)
        Database.CreateParameter(Params, "@DataProvider", SqlDbType.NVarChar, cboDataProvider.Text)
        Dim DS As DataSet = Database.ExecuteSP("spBatchImportCreate", Params)

        GetBatchID = DS.Tables(0).Rows(0).Item("ImportBatchID")

    End Function
    'Function GetExcelCellValue(ByVal row, ByVal col) As String
    '    ER = WS.Cells(row, col)
    '    Return ER.Text
    'End Function

    Dim IDCol As Integer = -1
    Dim CompanyCol As Integer = -1
    Dim PostcodeCol As Integer = -1
    Dim TelephoneCol As Integer = -1
    Dim SalutationCol As Integer = -1
    Dim FirstNameCol As Integer = -1
    Dim SurnameCol As Integer = -1
    Dim PositionCol As Integer = -1
    Dim shortBusinessCol As Integer = -1
    Dim EmployeesCol As Integer = -1
    Dim ProviderCol As Integer = -1
    Dim RenewalCol As Integer = -1
    Dim HoldUntilCol As Integer = -1

    Dim importDS As New DataSet
    Dim DT As New DataTable
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnStart.Click

        ' biuld Array 
        If txtFilename.Text = "" Then
            MsgBox("Please select a file")
            Exit Sub
        End If

        If cbGroupCompany.SelectedValue < 1 Then
            MsgBox("Please Select a Group Company CA or DF")
            Exit Sub
        End If

        If cbCompany.Text = "" Or cbtelephone.Text = "" Or cbPostcode.Text = "" Then
            MsgBox("You need to select a column for Company, Telephone and Postcode!")
            Exit Sub
        End If

        Dim GroupCompanyID As Integer = cbGroupCompany.SelectedItem.Value

        BtnStart.Visible = False
        lblAction.Text = "Reading File"
        Cursor = Cursors.WaitCursor
        If Not cbID.SelectedItem Is Nothing Then
            IDCol = cbID.SelectedItem.value()
        End If
        If Not cbCompany.SelectedItem Is Nothing Then
            CompanyCol = cbCompany.SelectedItem.value()
        End If

        If Not cbtelephone.SelectedItem Is Nothing Then
            TelephoneCol = cbtelephone.SelectedItem.value()
        End If

        If Not cbPostcode.SelectedItem Is Nothing Then
            PostcodeCol = cbPostcode.SelectedItem.value()
        End If

        If Not cbSalutation.SelectedItem Is Nothing Then
            SalutationCol = cbSalutation.SelectedItem.value()
        End If

        If Not cbFirstName.SelectedItem Is Nothing Then
            FirstNameCol = cbFirstName.SelectedItem.value()
        End If

        If Not cbSurname.SelectedItem Is Nothing Then
            SurnameCol = cbSurname.SelectedItem.value()
        End If

        If Not cbPosition.SelectedItem Is Nothing Then
            PositionCol = cbPosition.SelectedItem.value
        End If


        If Not cbshortBusiness.SelectedItem Is Nothing Then
            shortBusinessCol = cbshortBusiness.SelectedItem.value
        End If
        If Not cboEmployees.SelectedItem Is Nothing Then
            EmployeesCol = cboEmployees.SelectedItem.value
        End If
        If Not cbProvider.SelectedItem Is Nothing Then
            ProviderCol = cbProvider.SelectedItem.value
        End If
        If Not cboRenewal.SelectedItem Is Nothing Then
            RenewalCol = cboRenewal.SelectedItem.value
        End If

        If Not cbHoldUntil.SelectedItem Is Nothing Then
            HoldUntilCol = cbHoldUntil.SelectedItem.value
        End If

        importDS.Tables.Add(DT)
        DT.Columns.Add(New DataColumn("ID"))

        DT.Columns.Add(New DataColumn("Company"))
        DT.Columns.Add(New DataColumn("Postcode"))
        DT.Columns.Add(New DataColumn("Telephone"))

        DT.Columns.Add(New DataColumn("Salutation"))
        DT.Columns.Add(New DataColumn("FirstName"))
        DT.Columns.Add(New DataColumn("Surname"))
        DT.Columns.Add(New DataColumn("Position"))

        DT.Columns.Add(New DataColumn("BusinessType"))
        DT.Columns.Add(New DataColumn("Employees"))
        DT.Columns.Add(New DataColumn("Provider"))
        DT.Columns.Add(New DataColumn("Renewal"))
        DT.Columns.Add(New DataColumn("HoldUntil"))


        Dim isfirstrow As Boolean = True
        While Not parser.EndOfData
            If FirstRow.Checked = True And isfirstrow Then
                isfirstrow = False ' do not import title Row 
            Else
                Dim arrFields As String()
                arrFields = parser.ReadFields()
                Dim aRow As DataRow = DT.NewRow

                aRow.Item("Company") = Common.TitleCase(arrFields(CompanyCol))
                aRow.Item("Postcode") = arrFields(PostcodeCol).ToUpper
                aRow.Item("Telephone") = arrFields(TelephoneCol)
                If IDCol > -1 Then
                    aRow.Item("ID") = Common.TitleCase(arrFields(IDCol))
                Else
                    aRow.Item("ID") = ""
                End If
                If SalutationCol > -1 Then
                    aRow.Item("Salutation") = Common.TitleCase(arrFields(SalutationCol))
                Else
                    aRow.Item("Salutation") = ""
                End If

                If FirstNameCol > -1 Then
                    aRow.Item("FirstName") = Common.TitleCase(arrFields(FirstNameCol))
                Else
                    aRow.Item("FirstName") = ""
                End If

                If SurnameCol > -1 Then
                    aRow.Item("Surname") = Common.TitleCase(arrFields(SurnameCol))
                Else
                    aRow.Item("Surname") = ""
                End If

                If PositionCol > -1 Then
                    aRow.Item("Position") = Common.TitleCase(arrFields(PositionCol))
                Else
                    aRow.Item("Position") = ""
                End If

                If shortBusinessCol > -1 Then
                    aRow.Item("BusinessType") = Common.TitleCase(arrFields(shortBusinessCol))
                Else
                    aRow.Item("BusinessType") = ""
                End If
                If EmployeesCol > -1 Then
                    aRow.Item("Employees") = Common.TitleCase(arrFields(EmployeesCol))
                Else
                    aRow.Item("Employees") = ""
                End If
                If ProviderCol > -1 Then
                    aRow.Item("Provider") = Common.TitleCase(arrFields(ProviderCol))
                Else
                    aRow.Item("Provider") = ""
                End If
                If RenewalCol > -1 Then
                    aRow.Item("Renewal") = Common.TitleCase(arrFields(RenewalCol))
                Else
                    aRow.Item("Renewal") = ""
                End If
                If HoldUntilCol > -1 Then
                    aRow.Item("HoldUntil") = Common.TitleCase(arrFields(HoldUntilCol))
                Else
                    aRow.Item("HoldUntil") = ""
                End If

                DT.Rows.Add(aRow)
                lblNumbers.Text = lblNumbers.Text + 1
                ' ***** Check if ok before going mad 
                If lblNumbers.Text = 14 Then
                    Dim afrm As New frmCheckImport

                    For x As Integer = 0 To 12
                        Dim li As New ListViewItem
                        li.Text = DT.Rows(x).Item("Company").ToString
                        li.SubItems.Add(DT.Rows(x).Item("Postcode").ToString)
                        li.SubItems.Add(DT.Rows(x).Item("Telephone").ToString)
                        li.SubItems.Add(DT.Rows(x).Item("Salutation").ToString)
                        li.SubItems.Add(DT.Rows(x).Item("FirstName").ToString)
                        li.SubItems.Add(DT.Rows(x).Item("Surname").ToString)
                        li.SubItems.Add(DT.Rows(x).Item("Position").ToString)
                        afrm.lv.Items.Add(li)
                    Next
                    For Each li As ListViewItem In lvSelected.Items
                        afrm.lvSelected.Items.Add(li.Clone)
                    Next
                    If afrm.ShowDialog = DialogResult.Cancel Then
                        BtnStart.Visible = True
                        lblAction.Text = ""
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
            End If
        End While


        Cursor = Cursors.Default


        Dim batchID As Integer = GetBatchID(txtFilename.Text)


        lblAction.Text = "Processing"
        ' need to biuld date array 
        Dim C As Integer = 1
        Dim aDate As DateTime = Now.AddDays(1)

        Dim Dates(10) As String
        Do While C < 11
            If aDate.DayOfWeek <> DayOfWeek.Saturday And aDate.DayOfWeek <> DayOfWeek.Sunday Then
                Dates(C) = aDate.ToLongDateString & " 09:00"
                C = C + 1
            End If
            aDate = aDate.AddDays(1)
        Loop

        Dim NextDate As Integer = 1


        For Each DR As DataRow In DT.Rows
            Dim Company As String = DR("Company").ToString
            Dim PostCode As String = DR("Postcode").ToString
            Dim telephone As String = Common.RemoveNonNumerics(DR("Telephone"))
            If telephone.Substring(0, 1) <> "0" Then
                telephone = "0" & telephone
            End If
            Dim Salutation As String = DR("Salutation").ToString
            Dim firstName As String = DR("FirstName").ToString
            Dim Surname As String = DR("Surname").ToString
            Dim Position As String = DR("Position").ToString
            Dim BusinessType As String = DR("BusinessType").ToString
            Dim Employees As String = DR("Employees").ToString
            Dim Provider As String = DR("Provider").ToString
            Dim URN As String = DR("ID").ToString
            Dim Renewal As String = DR("Renewal").ToString
            Dim HoldUntil As String = DR("HoldUntil").ToString

            DS = database.ExecuteSQL("Select * from companies where Telephone='" & telephone & "' and GroupCompanyID = " & GroupCompanyID)

            If DS.Tables(0).Rows.Count = 1 Then
                ' number in the database 
                Dim acompany As Common.cCompany = New Common.cCompany(DS.Tables(0).Rows(0).Item("ID"))
                lblHave.Text = lblHave.Text + 1
                LogSkipEvent(batchID, Company, telephone, PostCode, "Duplicated Record")
                If acompany.Status = "Appointment" Then
                    lblApps.Text = lblApps.Text + 1
                    Dim aitem As ListViewItem = New ListViewItem(telephone)
                    aitem.SubItems.Add(Company)
                    LVApps.Items.Add(aitem)

                Else
                    ' need to check if ever appointed on the system 
                    'If acompany.History.Count > 0 Then
                    Dim beenAppointed As Boolean = False
                    For Each hist As Common.cCallHistory In acompany.History
                        If hist.CallEndStatus = "Appointment" Then
                            beenAppointed = True
                            Exit For
                        End If
                    Next

                    If beenAppointed Then
                        lblApps.Text = lblApps.Text + 1
                        Dim aitem As ListViewItem = New ListViewItem(telephone)
                        aitem.SubItems.Add(Company)
                        LVApps.Items.Add(aitem)
                    Else
                        ' exists and no app in the history
                        Dim isCallback As Boolean = False
                        If acompany.Status = "CallBack" Then
                            isCallback = True
                        End If
                        If isCallback = True Then
                            lblCB.Text = lblCB.Text + 1
                            Dim aitem As ListViewItem = New ListViewItem(telephone)
                            aitem.SubItems.Add(Company)
                            LVCB.Items.Add(aitem)
                        End If
                    End If

                End If

            ElseIf DS.Tables(0).Rows.Count > 1 Then
                MsgBox("Duplicate Telephone numbers in DB")
            Else
                ' is new add to database 
                Me.lblNew.Text = Me.lblNew.Text + 1
                'these are new 
                Dim CompanyID As Integer
                If CreateCompany(CompanyID, Company, telephone, PostCode, batchID, Salutation, firstName, Surname, Position) = DialogResult.OK Then
                    Dim acompany As Common.cCompany = New Common.cCompany(CompanyID)

                    If lvSelected.Items.Count > 0 Then
                        acompany.AgentID = lvSelected.Items(NextAgent).Text
                    Else
                        acompany.AgentID = 0
                    End If

                    acompany.Status = "ColdCall"
                    acompany.CallBackOn(Now.ToLongDateString)
                    acompany.BusinessType = BusinessType
                    acompany.Employees = Employees
                    acompany.PolicyProvider = Provider
                    acompany.URN = URN
                    acompany.GroupCompanyID = cbGroupCompany.SelectedItem.Value
                    Try
                        acompany.PolicyExpires = CDate(Renewal)
                        acompany.HoldUntil = acompany.PolicyExpires.AddMonths(-2)
                    Catch ex As Exception

                    End Try

                    If acompany.PolicyExpires <> Nothing Then
                        acompany.Status = "CallBack"
                    End If

                    If HoldUntil <> "" Then
                        acompany.HoldUntil = CDate(HoldUntil)
                    End If

                    acompany.Save()

                    NextAgent = NextAgent + 1
                    If NextAgent > lvSelected.Items.Count - 1 Then
                        NextAgent = 0
                        NextDate = NextDate + 1
                        If NextDate = 11 Then
                            NextDate = 1
                        End If
                    End If
                End If
            End If
            Application.DoEvents()
        Next
        MsgBox("Import Completed")
        BtnStart.Visible = True
        lblAction.Text = ""
    End Sub



    Private Sub btnChangeAgents_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnChangeAgents.Click

        ' now is time to select the agents 
        Dim afrm As New frmSelectUsers

        afrm.lvSelected.Items.Clear()
        For Each obj As ListViewItem In lvSelected.Items
            afrm.lvSelected.Items.Add(obj.Clone)
        Next

        If afrm.ShowDialog = DialogResult.OK Then
            lvSelected.Items.Clear()
            For Each obj As ListViewItem In afrm.lvSelected.Items
                lvSelected.Items.Add(obj.Clone)
            Next
            btnChangeAgents.Visible = True
            lvSelected.Visible = True
            BtnStart.Visible = True
        End If

    End Sub



    Public Sub LogSkipEvent(ByVal BatchID As Integer, ByVal sCompanyName As String, ByVal sTelephone As String, ByVal sPostcode As String, Optional ByVal Description As String = "User skipped import")
        Dim Database As New Common.DataLayer

        Dim Params As New Collection
        With Database
            .CreateParameter(Params, "@BatchID", SqlDbType.Int, BatchID)
            .CreateParameter(Params, "@CompanyName", SqlDbType.NVarChar, sCompanyName)
            .CreateParameter(Params, "@Telephone", SqlDbType.NVarChar, sTelephone)
            .CreateParameter(Params, "@PostcodeRaw", SqlDbType.NVarChar, sPostcode)
            .CreateParameter(Params, "@ReasonCode", SqlDbType.Int, 3)
            .CreateParameter(Params, "@ReasonDescription", SqlDbType.NVarChar, Description)

            .ExecuteSPNoQuery("spBatchImportLog", Params)
        End With

    End Sub

    Private Sub frmLegacyImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CompanyGroups As New List(Of Common.cSimpleItem)

        CompanyGroups.Add(New Common.cSimpleItem(0, ""))
        CompanyGroups.Add(New Common.cSimpleItem(1, "CA"))
        CompanyGroups.Add(New Common.cSimpleItem(2, "DF"))
        CompanyGroups.Add(New Common.cSimpleItem(3, "PI"))
        cbGroupCompany.DataSource = CompanyGroups
    End Sub
End Class