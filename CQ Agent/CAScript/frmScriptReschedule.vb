Public Class frmScriptReschedule

    Private DateLabel As Label = Nothing
    Private TimeLabel As Label = Nothing

    Private oDate As Date = "1/1/1900"
    Private oTime As Date = "12:00:00 AM"

    Public ReadOnly Property SelectedDate() As Date
        Get
            SelectedDate = oDate.ToLongDateString & " " & oTime
        End Get
    End Property
    Private Sub frmScriptReschedule_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim app As Agent.cAgentApp = Agent.cAgentApp.GetInstance
        app.UpdateDeskStatus("Resheduling")

        'get first day of week 1


        Dim StartDate As Date = Common.GetStartOfWeek(Date.Now)

        Dim iOffset As Integer = 0
        Dim iWorkingDays As Integer = 0
        For iWeek As Integer = 0 To 2
            For iDay As Integer = 0 To 4
                Dim oCtrl As Label = Me.Controls("lblW" & iWeek + 1 & "D" & iDay + 1)
                Dim ThisDate As Date
                ThisDate = DateAdd(DateInterval.Day, iDay + iWeek * 7, StartDate).ToString

                oCtrl.Text = ThisDate.Day.ToString
                oCtrl.Tag = ThisDate

                If ThisDate < Today Then
                    'disable the control
                    oCtrl.BackColor = Color.Silver
                    oCtrl.Tag = CDate("1/1/1900")
                Else
                    oCtrl.BackColor = Color.White
                End If

                If ThisDate > Today Then
                    'dont forget to allow for holidays here!
                    iWorkingDays += 1
                End If

                If iWorkingDays > 10 Then
                    'disable the control
                    oCtrl.BackColor = Color.Gray
                    oCtrl.Tag = CDate("1/1/1900")
                End If

            Next
        Next





    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub lblW1D1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblW1D1.Click, lblW1D2.Click, lblW1D3.Click, lblW1D4.Click, lblW1D5.Click, lblW2D5.Click, lblW2D4.Click, lblW2D3.Click, lblW2D2.Click, lblW2D1.Click, lblW3D1.Click, lblW3D2.Click, lblW3D3.Click, lblW3D4.Click, lblW3D5.Click
        Dim aLabel As Label = sender

        oDate = aLabel.Tag

        If oDate > "1/1/1900" Then
            If DateLabel Is Nothing Then

            Else
                DateLabel.BackColor = Color.White
                DateLabel.ForeColor = Color.Black
            End If

            DateLabel = sender
            DateLabel.BackColor = Color.Blue
            DateLabel.ForeColor = Color.White
        End If



        If oDate = Now.Date Then
            'they selected today, so get rid of the times in the past.

            Dim iHour As Integer = Now.TimeOfDay.Hours
            If iHour >= 16 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = False
                Me.lblTime1.Enabled = False
                Me.lblTime2.Enabled = False
                Me.lblTime3.Enabled = False
                Me.lblTime4.Enabled = False

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.Silver
                Me.lblTime1.BackColor = Color.Silver
                Me.lblTime2.BackColor = Color.Silver
                Me.lblTime3.BackColor = Color.Silver
                Me.lblTime4.BackColor = Color.Silver
            ElseIf iHour = 15 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = False
                Me.lblTime1.Enabled = False
                Me.lblTime2.Enabled = False
                Me.lblTime3.Enabled = False
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.Silver
                Me.lblTime1.BackColor = Color.Silver
                Me.lblTime2.BackColor = Color.Silver
                Me.lblTime3.BackColor = Color.Silver
                Me.lblTime4.BackColor = Color.White
            ElseIf iHour = 14 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = False
                Me.lblTime1.Enabled = False
                Me.lblTime2.Enabled = False
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.Silver
                Me.lblTime1.BackColor = Color.Silver
                Me.lblTime2.BackColor = Color.Silver
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            ElseIf iHour = 13 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = False
                Me.lblTime1.Enabled = False
                Me.lblTime2.Enabled = True
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.Silver
                Me.lblTime1.BackColor = Color.Silver
                Me.lblTime2.BackColor = Color.White
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            ElseIf iHour = 12 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = False
                Me.lblTime1.Enabled = True
                Me.lblTime2.Enabled = True
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.Silver
                Me.lblTime1.BackColor = Color.White
                Me.lblTime2.BackColor = Color.White
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            ElseIf iHour = 11 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = False
                Me.lblTime12.Enabled = True
                Me.lblTime1.Enabled = True
                Me.lblTime2.Enabled = True
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.Silver
                Me.lblTime12.BackColor = Color.White
                Me.lblTime1.BackColor = Color.White
                Me.lblTime2.BackColor = Color.White
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            ElseIf iHour = 10 Then
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = False
                Me.lblTime11.Enabled = True
                Me.lblTime12.Enabled = True
                Me.lblTime1.Enabled = True
                Me.lblTime2.Enabled = True
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.Silver
                Me.lblTime11.BackColor = Color.White
                Me.lblTime12.BackColor = Color.White
                Me.lblTime1.BackColor = Color.White
                Me.lblTime2.BackColor = Color.White
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            Else
                Me.lblTime9.Enabled = False
                Me.lblTime10.Enabled = True
                Me.lblTime11.Enabled = True
                Me.lblTime12.Enabled = True
                Me.lblTime1.Enabled = True
                Me.lblTime2.Enabled = True
                Me.lblTime3.Enabled = True
                Me.lblTime4.Enabled = True

                Me.lblTime9.BackColor = Color.Silver
                Me.lblTime10.BackColor = Color.White
                Me.lblTime11.BackColor = Color.White
                Me.lblTime12.BackColor = Color.White
                Me.lblTime1.BackColor = Color.White
                Me.lblTime2.BackColor = Color.White
                Me.lblTime3.BackColor = Color.White
                Me.lblTime4.BackColor = Color.White
            End If

        Else
            Me.lblTime9.Enabled = True
            Me.lblTime10.Enabled = True
            Me.lblTime11.Enabled = True
            Me.lblTime12.Enabled = True
            Me.lblTime1.Enabled = True
            Me.lblTime2.Enabled = True
            Me.lblTime3.Enabled = True
            Me.lblTime4.Enabled = True

            Me.lblTime9.BackColor = Color.White
            Me.lblTime10.BackColor = Color.White
            Me.lblTime11.BackColor = Color.White
            Me.lblTime12.BackColor = Color.White
            Me.lblTime1.BackColor = Color.White
            Me.lblTime2.BackColor = Color.White
            Me.lblTime3.BackColor = Color.White
            Me.lblTime4.BackColor = Color.White


            Me.lblTime9.ForeColor = Color.Black
            Me.lblTime10.ForeColor = Color.Black
            Me.lblTime11.ForeColor = Color.Black
            Me.lblTime12.ForeColor = Color.Black
            Me.lblTime1.ForeColor = Color.Black
            Me.lblTime2.ForeColor = Color.Black
            Me.lblTime3.ForeColor = Color.Black
            Me.lblTime4.ForeColor = Color.Black
        End If




        SetOK()
    End Sub


    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblTime9.Click, lblTime10.Click, lblTime11.Click, lblTime12.Click, lblTime1.Click, lblTime2.Click, lblTime3.Click, lblTime4.Click
        Dim aLabel As Label = sender

        oTime = CDate(aLabel.Text)

        If oTime > "12:00:00 AM" Then
            If TimeLabel Is Nothing Then

            Else
                TimeLabel.BackColor = Color.White
                TimeLabel.ForeColor = Color.Black
            End If

            TimeLabel = sender
            TimeLabel.BackColor = Color.Blue
            TimeLabel.ForeColor = Color.White
        End If

        SetOK()


    End Sub


    Private Sub SetOK()
        If oDate = "1/1/1900" Or oTime = "12:00:00 AM" Then
            Me.btnOK.Enabled = False
        Else
            Me.btnOK.Enabled = True
        End If
    End Sub

    Private Sub txtReason_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtReason.TextChanged
        SetOK()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btn15Mins_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn15Mins.Click

        oDate = Now.Date
        oTime = Now.AddMinutes(15).ToShortTimeString

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btn30Mins_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn30Mins.Click
        oDate = Now.Date
        oTime = Now.AddMinutes(30).ToShortTimeString

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btn1Hour_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn1Hour.Click
        oDate = Now.Date
        oTime = Now.AddMinutes(60).ToShortTimeString

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oDate = Now.Date
        oTime = Now.AddMinutes(5).ToShortTimeString

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button1Week_Click(sender As Object, e As EventArgs) Handles Button1Week.Click
        oDate = Now.Date.AddDays(7)
        oTime = Now.ToShortTimeString()
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2Week_Click(sender As Object, e As EventArgs) Handles Button2Week.Click
        oDate = Now.Date.AddDays(14)
        oTime = Now.ToShortTimeString()
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button3Week_Click(sender As Object, e As EventArgs) Handles Button3Week.Click
        oDate = Now.Date.AddDays(21)
        oTime = Now.ToShortTimeString()
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button4Week_Click(sender As Object, e As EventArgs) Handles Button4Week.Click
        oDate = Now.Date.AddDays(28)
        oTime = Now.ToShortTimeString()
        Me.DialogResult = DialogResult.OK
    End Sub
End Class