Imports Microsoft.VisualBasic.FileIO
Imports CADNet.CallQueues.Common

Public Class frmCompanyImport

    '#Region "Singleton"

    '    Private Shared oInstance As frmCompanyImport

    '    Private Sub New()

    '        ' This call is required by the Windows Form Designer.
    '        InitializeComponent()

    '        ' Add any initialization after the InitializeComponent() call.

    '    End Sub

    '    Public Shared Function GetInstance()

    '        If oInstance Is Nothing Then
    '            oInstance = New frmCompanyImport
    '        End If

    '        GetInstance = oInstance

    '    End Function
    '#End Region

    Private Const PREVIEWROWS As Integer = 6

    Private bFirstRowIsData As Boolean = True

    Private iBatchID As Integer = 0

    Private Const FIELD_COMPANYNAME As Integer = 0
    Private Const FIELD_POSTCODE As Integer = 1
    Private Const FIELD_TELEPHONE As Integer = 2
    Private Const FIELD_TITLE As Integer = 3
    Private Const FIELD_FORENAME As Integer = 4
    Private Const FIELD_SURNAME As Integer = 5

    'variables to store progress counts:
    Dim iTotalCount As Integer = 0
    Dim iRecordCount As Integer = 0 'this is the count of records processed (not used/inserted etc)
    Dim iCreatedCount As Integer = 0
    Dim iSkippedCount As Integer = 0

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBrowse.Click

        With Me.OpenFileDialog1
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = "csv"
            .DereferenceLinks = True
            .Filter = "CSV files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All files (*.*)|*.*"
            .FilterIndex = 0
            .Multiselect = False
            .ShowHelp = False
            .ShowReadOnly = False
            .Title = "Select file to import"
            .FileName = ""

            Dim DR As DialogResult = .ShowDialog
            Select Case DR
                Case DialogResult.OK
                Case Else
                    Exit Sub
            End Select

            Me.txtFilename.Text = Me.OpenFileDialog1.FileName

        End With


    End Sub

    Private Sub PreviewData()
        'open the file and show the first n rows

        If Me.txtFilename.Text.Length = 0 Then
            'no text file selected
            Exit Sub
        Else
            If System.IO.File.Exists(Me.txtFilename.Text) = False Then
                'file does not exist
                Exit Sub
            End If
        End If


        Dim bFirstRow As Boolean = True
        Dim bProcessRow As Boolean = True

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Dim iRecordCount As Integer = 0

        Dim arrFields As String()
        Dim sDelimiter As String = ","

        'create a dataset and a table
        Dim DS As New DataSet
        Dim DT As New DataTable
        DS.Tables.Add(DT)

        DT.Columns.Add(New DataColumn("Company Name"))
        DT.Columns.Add(New DataColumn("Postcode"))
        DT.Columns.Add(New DataColumn("Telephone"))


        Using parser As New TextFieldParser(Me.txtFilename.Text)
            parser.SetDelimiters(sDelimiter)
            While Not parser.EndOfData

                arrFields = parser.ReadFields()

                If bFirstRow And Me.bFirstRowIsData = False Then
                    'this is the first row in the file, but the user said its not data
                    'so dont process it
                    bProcessRow = False
                Else
                    'this is the first row in the file and the user said it is data
                    'so we can process it
                    bProcessRow = True
                End If
                bFirstRow = False

                If bProcessRow Then
                    Dim aRow As DataRow = DT.NewRow

                    iRecordCount = iRecordCount + 1

                    'for this bit we dont care about errors...
                    Try
                        aRow.Item("Company Name") = arrFields(FIELD_COMPANYNAME)
                        aRow.Item("Postcode") = arrFields(FIELD_POSTCODE)
                        aRow.Item("Telephone") = arrFields(FIELD_TELEPHONE)

                    Catch ex As Exception

                    End Try

                    DT.Rows.Add(aRow)

                    If iRecordCount >= PREVIEWROWS Then
                        Exit While
                    End If

                    Me.DataGridView1.DataSource = DT
                End If

                Application.DoEvents()

            End While
        End Using

        Me.btnImportFile.Enabled = True

        Me.Cursor = Cursors.Default

    End Sub


    Private Sub radioFirstRowIsData_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles radioFirstRowIsData.CheckedChanged
        Me.bFirstRowIsData = True
        PreviewData()
    End Sub

    Private Sub radioFirstRowIsTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles radioFirstRowIsTitle.CheckedChanged
        Me.bFirstRowIsData = False
        PreviewData()
    End Sub

    Private Sub txtFilename_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtFilename.TextChanged
        PreviewData()
    End Sub

    Private Sub btnImportFile_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImportFile.Click
        Me.pnlSettings.Visible = False
        Me.pnlImportProgress.Visible = True
        DoImport()

    End Sub

    Private Sub frmCompanyImport_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        With pnlSettings
            Me.pnlImportProgress.Top = .Top
            Me.pnlImportProgress.Left = .Left
            Me.pnlImportProgress.Width = .Width
            Me.pnlImportProgress.Visible = False
        End With
    End Sub

    Private Sub UpdateTotals()

        Me.lblNewCompanies.Text = iCreatedCount
        Me.lblNewPostcodes.Text = GetBatchPostcodeCount(iBatchID)
        Me.lblDuplicatedTelephones.Text = GetBatchDupeTelCount(iBatchID)
        Me.lblSkipped.Text = Me.iSkippedCount

    End Sub

    Private Function GetBatchID(ByVal Filename As String) As Integer
        'get a batch id
        Dim Params As New Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
        Database.CreateParameter(Params, "@FileName", SqlDbType.NVarChar, Filename)
        Database.CreateParameter(Params, "@DataProvider", SqlDbType.NVarChar, "")
        Dim DS As DataSet = Database.ExecuteSP("spBatchImportCreate", Params)

        GetBatchID = DS.Tables(0).Rows(0).Item("ImportBatchID")

    End Function
    Private Function GetBatchPostcodeCount(ByVal BatchID As Integer) As Integer

        Dim sSQL As String = "select count(ID) as RecCount from postcodeprefixes where importbatchid=" & BatchID
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        GetBatchPostcodeCount = DS.Tables(0).Rows(0).Item("RecCount")

    End Function
    Private Function GetBatchDupeTelCount(ByVal BatchID As Integer) As Integer

        Dim sSQL As String = "select count(ID) as RecCount from BatchImportProblems where ReasonCode = -1 and importbatchid=" & BatchID
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        GetBatchDupeTelCount = DS.Tables(0).Rows(0).Item("RecCount")

    End Function



    Private Sub DoImport()

        'retrieve a batchid for this import
        iBatchID = GetBatchID(Me.txtFilename.Text)
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Application.DoEvents()

        Dim arrFields As String()
        Dim sDelimiter As String = ","

        'read all the data into an array
        Dim AllRecords As String() = My.Computer.FileSystem.ReadAllText(Me.txtFilename.Text).Split(vbCrLf)

        'is the first record data or titles?
        Dim iStartRecord As Integer = 0
        If Me.bFirstRowIsData Then
            iTotalCount = AllRecords.Length
            iStartRecord = 0
        Else
            iTotalCount = AllRecords.Length - 1
            iStartRecord = 1
        End If

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Maximum = iTotalCount

        'loop through the array:
        For iRecordNum As Integer = iStartRecord To AllRecords.Length - 1

            Dim ThisPostcode As Common.cPostcode = Nothing
            Dim Validated As Boolean = False

            Dim bDataEdited As Boolean = False

            'extract the record data into variables
            arrFields = AllRecords(iRecordNum).Trim.Split(",")

            Dim sCompanyName As String = ""
            Dim sPostcode As String = ""
            Dim sTelephone As String = ""
            Dim sTitle As String = ""
            Dim sForename As String = ""
            Dim sSurname As String = ""

            Try
                sPostcode = arrFields(FIELD_POSTCODE).Trim.ToUpper.Replace(" O", " 0").Replace(" I", " 1")
                sCompanyName = arrFields(FIELD_COMPANYNAME).Trim
                sTelephone = arrFields(FIELD_TELEPHONE).Trim
                sTitle = arrFields(FIELD_TITLE).Trim
                sForename = arrFields(FIELD_FORENAME).Trim
                sSurname = arrFields(FIELD_SURNAME).Trim

            Catch ex As Exception

            End Try

            'tidy up the phone number:
            sTelephone = Common.StringManipulation.RemoveNonNumerics(sTelephone)

            'carry on until we get validated data:
            Do Until Validated = True

                If sPostcode = "" And sCompanyName = "" And sTelephone = "" Then
                    'the row in the datafile was empty, so just skip it
                    Validated = False
                    'update the totals:
                    iTotalCount -= 1
                    Me.ProgressBar1.Maximum = iTotalCount
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
                            Exit Sub
                        Case DialogResult.OK
                            Dim vTelNumber As String = ""
                            Dim bTemp As String = Common.cPostcode.ValidatePostcode(aFrm.txtPostcode.Text)
                            vTelNumber = Common.ValidateTelephone(aFrm.txtTelephone.Text)
                            If bTemp = "" And vTelNumber <> "" Then
                                'both the new postcode and new tel validate
                                'get the new values and run through the loop again
                                sPostcode = aFrm.txtPostcode.Text
                                sTelephone = vTelNumber
                                sCompanyName = aFrm.txtCompany.Text
                                Validated = True
                                Try
                                    ThisPostcode = New Common.cPostcode(sPostcode, iBatchID)
                                Catch ex As Exception
                                    Validated = False
                                End Try
                                bDataEdited = True
                            End If
                        Case DialogResult.Cancel
                            'they clicked the skip button
                            Validated = False
                            LogSkipEvent(iBatchID, sCompanyName, sTelephone, sPostcode)
                            iSkippedCount = iSkippedCount + 1
                            Exit Do
                        Case Else
                            MessageBox.Show("unexpected dialog result during edit postcode: " & DR.ToString)
                            Validated = False
                    End Select
                End If


            Loop    'Until Validated = True

            If Validated Then

                'write the variables back into the array
                AllRecords(iRecordNum) = sCompanyName & "," & sPostcode & "," & sTelephone

                If bDataEdited Then
                    'the data has changed, so write the modifcation back into the file
                    Dim oSR As New System.IO.StreamWriter(Me.txtFilename.Text)
                    For Index As Integer = 0 To AllRecords.Length - 1
                        oSR.WriteLine(AllRecords(Index))
                    Next
                    oSR.Close()
                End If

                'save the company info

                Dim Params As New Collection
                With Database
                    .CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
                    .CreateParameter(Params, "@BatchID", SqlDbType.Int, iBatchID)
                    .CreateParameter(Params, "@CompanyName", SqlDbType.NVarChar, sCompanyName)
                    .CreateParameter(Params, "@Telephone", SqlDbType.NVarChar, sTelephone)
                    .CreateParameter(Params, "@PostCodeRaw", SqlDbType.NVarChar, sPostcode)
                    .CreateParameter(Params, "@PostCodeID", SqlDbType.Int, ThisPostcode.PrefixID)
                    .CreateParameter(Params, "@LocationID", SqlDbType.Int, ThisPostcode.LocationID)
                    .CreateParameter(Params, "@Title", SqlDbType.NVarChar, sTitle)
                    .CreateParameter(Params, "@Forename", SqlDbType.NVarChar, sForename)
                    .CreateParameter(Params, "@Surname", SqlDbType.NVarChar, sSurname)
                End With

                Dim DS As DataSet = Database.ExecuteSP("spCompanyImport", Params)
      
                Dim iCompanyID As Integer = DS.Tables(0).Rows(0).Item("ID")

                If iCompanyID < 0 Then
                    'MessageBox.Show("Problems!" & vbCrLf & vbCrLf & "insert returned " & iID)

                Else
                    'was created ok

                    iCreatedCount += 1
                End If
            End If 'validated


            iRecordCount += 1
            Me.lblRemaining.Text = iTotalCount - iRecordCount

            Try
                Me.ProgressBar1.Value = iRecordCount
            Catch ex As Exception

            End Try

            UpdateTotals()

            Application.DoEvents()
        Next



        Me.Cursor = Cursors.Default
        Application.DoEvents()

        Me.DialogResult = DialogResult.OK

        'finished the import.

        MessageBox.Show("Data Import Completed")
        Me.pnlImportProgress.Hide()

    End Sub

    Public Sub LogSkipEvent(ByVal BatchID As Integer, ByVal sCompanyName As String, ByVal sTelephone As String, ByVal sPostcode As String, Optional ByVal Description As String = "User skipped import")
        Dim Database As New CADNet.CallQueues.Common.DataLayer

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

    Private Sub pnlImportProgress_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlImportProgress.Paint

    End Sub
End Class