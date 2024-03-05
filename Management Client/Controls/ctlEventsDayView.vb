Public Class ctlEventsDayView

    Public Sub SetAgentAndDay(ByVal AgentID As Integer, ByVal Day As DateTime)
        Dim sSQL As String
        Dim Starttime As DateTime

        sSQL = "SELECT ID, AgentID, Event, Time   FROM AgentEvents WHERE (AgentID = " & AgentID & ") AND (Time > '" & Day.ToLongDateString & " 00:01') AND (Time < '" & Day.ToLongDateString & " 23:59') AND (Event <> 'Ending Appointment ') ORDER BY Time"
        Dim Database As New Common.DataLayer
        Dim DS As DataSet
        DS = Database.ExecuteSQL(sSQL)
        lblDate.Text = Day.ToLongDateString
        LVEvents.Items.Clear()
        Dim lvitem As ListViewItem
        Dim aDate As DateTime
        Dim Counter As Integer = 0
        For Each DR As DataRow In DS.Tables(0).Rows
            If DR("Event").ToString <> "Exceeded Call End Time" Then
                lvitem = New ListViewItem
                lvitem.Text = DR("Event")
                aDate = DR("Time")
                lvitem.SubItems.Add(aDate.ToShortTimeString)
                If lvitem.Text.IndexOf("Ended") > -1 Then
                    Dim TS As New TimeSpan
                    TS = aDate.Subtract(Starttime)
                    Dim hours As String = ""
                    If TS.Hours > 0 Then
                        hours = TS.Hours & ":"
                    End If

                    Select Case lvitem.Text
                        Case "Ended Appointment"
                            If TS.TotalSeconds > 150 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If
                        Case "Ended Lunch"
                            If TS.TotalMinutes > 47 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If
                        Case "Ended Bins"
                            If TS.TotalMinutes > 5 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If
                        Case "Ended Break"
                            If TS.TotalMinutes > 11 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If

                        Case "Ended Toilet"
                            If TS.TotalMinutes > 6 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If
                        Case "Ended Washing"
                            If TS.TotalMinutes > 10 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If

                        Case "Ended Water"
                            If TS.TotalMinutes > 2 Then
                                lvitem.BackColor = Color.LightSalmon
                            End If
                    End Select

                    lvitem.Text = "Ended (" & hours & Format(TS.Minutes, "00") & ":" & Format(TS.Seconds, "00") & ")"
                Else
                    Starttime = aDate
                End If
                LVEvents.Items.Add(lvitem)

            Else
                Counter = Counter + 1
            End If
        Next
        lblExceeded.Text = Counter
    End Sub

 
    
End Class
