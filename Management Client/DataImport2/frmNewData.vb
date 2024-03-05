Imports System.IO

Public Class frmNewData

    Public Enum position
        incoming_urn
        id118
        dupe_urn
        businessname
        add1
        add2
        locality
        town
        county
        post_code
        telno
        sdm_title
        sdm_forename
        sdm_surname
        sdm_email
        company_email
        emps_band
        market_sector
        location_type
        indicator
        sdm_title_118
        sdm_forename_118
        sdm_surname_118
        sdm_position_118
        sdm_email_118
        company_email_118
    End Enum
    Dim records As Integer
    Private Sub Button1_Click(sender As System.Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False

        Dim FILE_NAME As String = lblFiles.Text
        records = GetLineCount(FILE_NAME)
        Dim starttime As DateTime = Now

        Dim database As New Common.DataLayer
        Dim counter As Integer = 0
        If System.IO.File.Exists(FILE_NAME) = True Then
            counter = counter + 1
            Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(FILE_NAME)
            Dim CurrentRecord As String() ' this array will hold each line of data
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.Delimiters = New String() {","}
            afile.HasFieldsEnclosedInQuotes = True
            Dim headers As String()
            Dim firstline As Boolean = True

            ' parse the actual file
            Do While Not afile.EndOfData
                Try
                    CurrentRecord = afile.ReadFields
                Catch ex As Exception
                    Stop
                End Try

                If firstline Then
                    headers = CurrentRecord
                    firstline = False
                Else
                    If CurrentRecord.Length <> 26 Then
                        Console.WriteLine(CurrentRecord(0).ToString)
                    Else
                        'Dim params As New Collection
                        'For t As Integer = 0 To CurrentRecord.Length - 1
                        '    Dim param As String = "@" & headers(t).Replace("""", "")
                        '    database.CreateParameter(params, param, SqlDbType.NVarChar, CurrentRecord(t))
                        'Next
                        'database.ExecuteSP("spnewdata", params)
                        'stored a copy now need to  process 
                        Dim id118 As String = CurrentRecord(position.id118)
                        Dim sSql As String = "SELECT ID,CompanyStatus,AgentID from Companies where id118 = " & id118
                        Dim ds As DataSet = database.ExecuteSQL(sSql)


                        Dim RecordCount As Integer = ds.Tables(0).Rows.Count
                        If RecordCount = 1 Then
                            ' found company
                            Dim companyID As String = ds.Tables(0).Rows(0).Item("ID")
                            Dim Status As String = ds.Tables(0).Rows(0).Item("CompanyStatus")
                            Dim AgentID As Integer = ds.Tables(0).Rows(0).Item("AgentID")
                            ds = Nothing
                            Select Case Status.ToLower
                                Case "callback", "appointment", "transfer", "sale", "nottohand", "supervisor"
                                    ' update primary contact details only 
                                    Dim c As New Common.cCompany(companyID)
                                    c.SeniorDecisionMaker = String.Format("{0} {1} {2} {3}", CurrentRecord(position.sdm_title_118), CurrentRecord(position.sdm_forename_118), CurrentRecord(position.sdm_surname_118), CurrentRecord(position.sdm_position_118))
                                    c.Save()
                                    database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'SeniorDecisionMaker updated')")
                                    c = Nothing
                                    lblcallbacks.Text = lblcallbacks.Text + 1
                                    lbltotal.Text = lbltotal.Text + 1
                                Case "gone", "notfound", "notsure"
                                    ' originally out of pot so just check if it has magically got live
                                    If CurrentRecord(position.indicator) = "LV " Then
                                        Dim c As New Common.cCompany(companyID)
                                        ' going to update other stuff 
                                        c.ContactTitle = CurrentRecord(position.sdm_title_118)
                                        c.ContactForename = CurrentRecord(position.sdm_forename_118)
                                        c.ContactSurname = CurrentRecord(position.sdm_surname_118)
                                        c.ContactPosition = CurrentRecord(position.sdm_position_118)

                                        c.SeniorDecisionMaker = String.Format("{0} {1} {2} {3}", CurrentRecord(position.sdm_title_118), CurrentRecord(position.sdm_forename_118), CurrentRecord(position.sdm_surname_118), CurrentRecord(position.sdm_position_118))
                                        c.Status = "ColdCall"
                                        c.AgentID = 0
                                        c.HoldUntil = Now
                                        c.Save()
                                        database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'brought back from unknown')")

                                        c = Nothing

                                        lblcold.Text = lblcold.Text + 1
                                    End If
                                    lbltotal.Text = lbltotal.Text + 1

                                Case "coldcall"
                                    ' update primary contact details ,address,company name , status (gone away etc)
                                    Dim c As New Common.cCompany(companyID)
                                    If AgentID = 0 Then
                                        ' going to update other stuff 
                                        c.ContactTitle = CurrentRecord(position.sdm_title_118)
                                        c.ContactForename = CurrentRecord(position.sdm_forename_118)
                                        c.ContactSurname = CurrentRecord(position.sdm_surname_118)
                                        c.ContactPosition = CurrentRecord(position.sdm_position_118)

                                    End If
                                    c.SeniorDecisionMaker = String.Format("{0} {1} {2} {3}", CurrentRecord(position.sdm_title_118), CurrentRecord(position.sdm_forename_118), CurrentRecord(position.sdm_surname_118), CurrentRecord(position.sdm_position_118))

                                    ' need to sortout gone away etc.
                                    Select Case CurrentRecord(position.indicator)
                                        Case "NS"
                                            c.Status = "NotSure"
                                            database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'Coldcall Status set to not sure')")
                                        Case "LV"
                                            ' already set at coldcall
                                            database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'Coldcall Status set to Live')")
                                        Case "GA"
                                            c.Status = "Gone"
                                            database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'Coldcall Status set to Gone')")
                                        Case ""
                                            c.Status = "NotFound"
                                            database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'Coldcall Status set to Not Found')")
                                    End Select

                                    c.Save()
                                    c = Nothing
                                    lblcold.Text = lblcold.Text + 1
                                    lbltotal.Text = lbltotal.Text + 1
                                Case "invalidnumber", "outofarea"
                                    ' not doing anything with these at the moment
                                    Dim c As New Common.cCompany(companyID)
                                    database.ExecuteSQL("Insert into ImportHistory (CompanyID,[description]) values (" & c.ID & ",'Out of Area/invalid number')")
                                    lbltotal.Text = lbltotal.Text + 1
                                Case Else
                                    Dim app As cManagerApp = cManagerApp.GetInstance

                                    app.AddManagerNote("status not recognised in import " & Status, companyID, 0)
                                    lbltotal.Text = lbltotal.Text + 1
                            End Select
                        ElseIf RecordCount > 1 Then
                            ' opps something wrong here 
                            Dim app As cManagerApp = cManagerApp.GetInstance
                            app.AddManagerNote("more than one company in import id118 = " & id118, 0, 0)
                            lbltotal.Text = lbltotal.Text + 1
                        Else
                            ' new company 
                            CreateRecord(CurrentRecord)
                            lblnew.Text = lblnew.Text + 1
                            lbltotal.Text = lbltotal.Text + 1
                        End If


                    End If
                End If
                counter = counter + 1
                If counter = 100 Then
                    counter = 0
                    Dim total As Integer = lbltotal.Text
                    Dim Endtime As DateTime = Now
                    Dim ts As TimeSpan = Endtime - starttime
                    Dim elapsed As Integer = ts.TotalSeconds
                    Dim recordspersecond As Double = total / elapsed
                    Dim secondsLeft As Integer = (records - total) / recordspersecond
                    Dim hours As Integer = Math.Floor(secondsLeft / 3600)
                    Dim minutes As Integer = Math.Floor((secondsLeft - (hours * 3600)) / 60)
                    Dim seconds As Integer = secondsLeft - ((hours * 3600) + (minutes * 60))
                    lblTime.Text = Format(hours, "00:") & Format(minutes, "00:") & Format(seconds, "00")
                End If
                Application.DoEvents()
            Loop
        Else
            MsgBox("File Does Not Exist")
        End If
        Button1.Enabled = True
    End Sub



    Private Sub CreateRecord(CurrentRecord As String())

        'get the postcode id
        'this save the post code to the save if it aint already there
        'as well as create a location record with a lat/long

        Dim ThisPostcode As Common.cPostcode = New Common.cPostcode(CurrentRecord(position.post_code), -99)

        If ThisPostcode.fail = "" Then
            Dim DB As New Common.DataLayer

            Dim Params As New Collection
            With DB
                .CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
                .CreateParameter(Params, "@BatchID", SqlDbType.Int, -99)
                .CreateParameter(Params, "@CompanyName", SqlDbType.NVarChar, CurrentRecord(position.businessname))
                .CreateParameter(Params, "@Telephone", SqlDbType.NVarChar, CurrentRecord(position.telno))
                .CreateParameter(Params, "@PostCodeRaw", SqlDbType.NVarChar, CurrentRecord(position.post_code))
                .CreateParameter(Params, "@PostCodeID", SqlDbType.Int, ThisPostcode.PrefixID)
                .CreateParameter(Params, "@LocationID", SqlDbType.Int, ThisPostcode.LocationID)
                .CreateParameter(Params, "@Title", SqlDbType.NVarChar, CurrentRecord(position.sdm_title_118))
                .CreateParameter(Params, "@Forename", SqlDbType.NVarChar, CurrentRecord(position.sdm_forename_118))
                .CreateParameter(Params, "@Surname", SqlDbType.NVarChar, CurrentRecord(position.sdm_surname_118))
                .CreateParameter(Params, "@Position", SqlDbType.NVarChar, CurrentRecord(position.sdm_position_118))
                .CreateParameter(Params, "@URN", SqlDbType.NVarChar, CurrentRecord(position.id118))
            End With

            Using DS As DataSet = DB.ExecuteSP("spCompanyImport", Params)
            End Using
        Else
            'do not create records, log 118ID  and postcode 
            Debug.WriteLine("118ID = " & CurrentRecord(position.id118) & " Postcode = " & CurrentRecord(position.post_code))
            Dim lvi As New ListViewItem

            lvi.SubItems(0).Text = CurrentRecord(position.id118)
            lvi.SubItems.Add(CurrentRecord(position.post_code))
            lv.Items.Add(lvi)


        End If
    End Sub


    Private Function CreateCompany(ByRef CompanyID As Integer, ByVal sCompanyName As String, ByVal sTelephone As String, ByVal sPostcode As String, ByVal iBatchID As Integer, ByVal salutation As String, ByVal firstname As String, ByVal surname As String, urn As Integer) As DialogResult

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
                .CreateParameter(Params, "@URN", SqlDbType.NVarChar, urn)
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



    Private Function GetLineCount(FILE_NAME As String) As Integer
        Using sr As StreamReader = File.OpenText(FILE_NAME)
            Dim LineCount As Integer = 0
            While Not (sr.ReadLine() Is Nothing)
                LineCount += 1
            End While
            Return LineCount
        End Using
    End Function







    Private Sub BtnBrowse_Click(sender As System.Object, e As EventArgs) Handles BtnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            lblFiles.Text = OpenFileDialog1.FileName
            Button1.Visible = True
        End If
    End Sub
End Class
