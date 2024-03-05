Public Class frmMultiRepDiaryEntry

    Dim Ds As DataSet
    Dim Database As New CADNet.CallQueues.Common.DataLayer

    Private Sub frmMultiRepDiaryEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ds = Database.ExecuteSQL("Select * from Users where Status = 2 and userlevelId=" & Common.eUserLevel.Rep)
        lvReps.Items.Clear()
        For Each DR As DataRow In Ds.Tables(0).Rows
            Dim lvi As New ListViewItem With {.Text = DR("Realname").ToString, .Tag = DR("ID")}
            lvReps.Items.Add(lvi)
        Next
        lvReps.Columns(0).Width = lvReps.ClientSize.Width - 2
        dtp.MinDate = Now.AddDays(1).ToLongDateString
        dtp.Value = Now.AddDays(1).ToLongDateString
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        ' first check if any appointments  already exist for each of the reps selected
        If cmbDescription.Text = "" Then
            MsgBox("Please enter something in the Description")
            Exit Sub
        End If
        If ValidateRequest() Then
            'ok need to add items 
            Dim Rep As Common.cUser
            For Each lvi As ListViewItem In lvReps.CheckedItems

                Rep = New Common.cUser
                Rep.Load(CInt(lvi.Tag))
                Dim x As Integer
                If Rep.HasApp5 Then
                    x = 5
                Else
                    x = 4
                End If

                For t As Integer = 1 To x
                    Dim cb As CheckBox = Controls("cb" & t)
                    If cb.Checked Then
                        ' need to create appointment 
                        Dim Params As New Collection()
                        Dim adate As New DateTime()
                        Dim Atime As String = ""

                        Select Case t
                            Case 1
                                Atime = Rep.AppTime1.ToShortTimeString
                            Case 2
                                Atime = Rep.AppTime2.ToShortTimeString
                            Case 3
                                Atime = Rep.AppTime3.ToShortTimeString
                            Case 4
                                Atime = Rep.AppTime4.ToShortTimeString
                            Case 5
                                Atime = Rep.AppTime5.ToShortTimeString
                        End Select
                        adate = String.Format("{0} {1}", dtp.Value.ToLongDateString, Atime)
                        Params = New Collection()
                        With Database
                            .CreateParameter(Params, "@AppointmentDate", SqlDbType.DateTime, adate)
                            .CreateParameter(Params, "@Period", SqlDbType.Int, t)
                            .CreateParameter(Params, "@UserID", SqlDbType.Int, Rep.ID)
                            .CreateParameter(Params, "@Description", SqlDbType.NVarChar, cmbDescription.Text)
                            .CreateParameter(Params, "@Status", SqlDbType.Int, 1)
                            Try
                                .ExecuteSPNoQuery("spAppointmentCreateGen", Params)
                            Catch ex As Exception
                                MsgBox("spAppointmentCreate - " & ex.Message)
                            End Try
                        End With
                    End If
                Next
            Next
            Close()
        End If
    End Sub


    Private Function ValidateRequest() As Boolean

        Dim responce As String = ""
        For Each lvi As ListViewItem In lvReps.CheckedItems
            Dim PeriodSearch As String = ""
            Dim First As Boolean = True
            For t As Integer = 1 To 5
                Dim cb As CheckBox = Controls("cb" & t)

                If cb.Checked Then
                    If First Then
                        PeriodSearch = String.Format("{0} itemPeriod={1} ", PeriodSearch, t)
                        First = False
                    Else
                        PeriodSearch = String.Format("{0} or itemPeriod={1} ", PeriodSearch, t)
                    End If
                End If
            Next
            PeriodSearch = PeriodSearch
            If PeriodSearch.Length > 2 Then
                Ds = Database.ExecuteSQL(String.Format("Select ID from Diaryitems where CONVERT(date, itemdate) = '{0}' and ({2}) and UserID={1} and status > 0", dtp.Value.ToLongDateString, lvi.Tag, PeriodSearch))
                If Ds.Tables(0).Rows.Count > 0 Then
                    responce = responce & vbCrLf & lvi.Text
                End If
            End If

        Next

        If responce.Length > 0 Then
            MsgBox(String.Format("The following Reps have already got items at this time:-{0}{1}", vbCrLf, responce))
            Return False
        End If

        Return True

    End Function
End Class