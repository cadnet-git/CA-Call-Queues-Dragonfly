Imports System.IO

Public Class frmImportTPS
    Dim NewTPSUntilDate As DateTime
    Dim records As Integer
    Private Sub Button1_Click(sender As System.Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        btnBrowse.Enabled = False
        Dim FILE_NAME As String = OpenFileDialog1.FileName    '"C:\temp\alldata_280513.csv"
        records = GetLineCount(FILE_NAME)
        lblrecs.Text = records.ToString("###,###,###")
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
                    If CurrentRecord.Length <> 2 Then
                        ' Console.WriteLine(CurrentRecord(0).ToString)
                    Else

                        Dim id118 As String = CurrentRecord(0)
                        Dim TPS As String = CurrentRecord(1)
                        Dim sSql As String = "SELECT ID,TPSuntil  from Companies where id118 = " & id118
                        Dim ds As DataSet = database.ExecuteSQL(sSql)
                        Dim RecordCount As Integer = ds.Tables(0).Rows.Count
                        If RecordCount = 1 Then
                            ' found company
                            Dim companyID As String = ds.Tables(0).Rows(0).Item("ID")
                            Dim TPSCurrentlyAllowedUntil As DateTime = ds.Tables(0).Rows(0).Item("TPSuntil")
                            ds = Nothing
                            ' heres where we do the real work 
                            If TPS = "N" Then
                                ' not tps
                                ' is ok  if NextTPSDate is less than tpsuntil then need to set the tpsdate to check date + 28 days
                                If TPSCurrentlyAllowedUntil > NewTPSUntilDate Then
                                    ' this is someone we have a business relationship leave it alone
                                    lblOKExistingRelationship.Text = lblOKExistingRelationship.Text + 1
                                Else
                                    ' Set TPsdate until newtpsdate
                                    Dim UpdateSQL As String = String.Format("Update companies set tpsuntil= '{0}' where id = {1}", NewTPSUntilDate.ToLongDateString, companyID)
                                    database.ExecuteSQL(UpdateSQL)
                                    lblOk.Text = lblOk.Text + 1
                                End If
                            Else
                                '    ' is tps so need to ckeck if we think we are in the clear 
                                '    ' is tps until  greater check date  + 28  then we can leave it alone cost we 
                                If TPSCurrentlyAllowedUntil > NewTPSUntilDate Then
                                    '        ' this is someone we have a business relationship leave it alone
                                    lblTPSExistingRelationship.Text = lblTPSExistingRelationship.Text + 1
                                Else
                                    '        'this TPS until should just be left to expire
                                    lblTPS.Text = lblTPS.Text + 1
                                End If
                            End If
                            lbltotal.Text = (lbltotal.Text + 1).ToString("###,###,###")
                        Else
                            ' opps something wrong here 
                            Dim app As cManagerApp = cManagerApp.GetInstance
                            app.AddManagerNote("more than one company in TPS check id118 = " & id118, 0, 0)
                            lbltotal.Text = (lbltotal.Text + 1).ToString("###,###,###")
                        End If

                        Application.DoEvents()
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
                    End If
                End If

                Application.DoEvents()
            Loop
        Else
            MsgBox("File Does Not Exist")
        End If
        Button1.Enabled = True
    End Sub





    Private Sub btnBrowse_Click(sender As System.Object, e As EventArgs) Handles btnBrowse.Click

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
                Dim anArray As Array = OpenFileDialog1.FileName.Split("\")
                Dim FileName As String = anArray(anArray.Length - 1).ToString
                txtFilename.Text = FileName
                Dim ext As String = FileName.Substring(Len(FileName) - 3)
                If ext = "csv" Then
                    checkready()
                End If
            End If
        End With
    End Sub

    Private Sub frmImportTPS_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GetLineCount(FILE_NAME As String) As Integer
        Using sr As StreamReader = File.OpenText(FILE_NAME)
            Dim LineCount As Integer = 0
            While Not (sr.ReadLine() Is Nothing)
                LineCount += 1
            End While
            Return LineCount
        End Using
    End Function

    Private Sub ReportDate_EditValueChanged(sender As System.Object, e As EventArgs) Handles ReportDate.EditValueChanged
        If ReportDate.Text <> "" Then
            NewTPSUntilDate = CDate(ReportDate.Text).AddDays(28)
        End If

        checkready()

    End Sub
    Private Sub checkready()
        If txtFilename.Text.Trim <> "" And ReportDate.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

End Class