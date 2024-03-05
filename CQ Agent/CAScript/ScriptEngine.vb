Public Class ScriptEngine
    'drives/controls the running of a telephone script

    Public Enum States
        Starting

        PleaseDial

        NumberNotRecognised
        TPS
        NotInterested

        Introduction
        IntroCold
        IntroColdContactDetails
        IntroContact    'intro to the really contact

        CheckContact

        CurrentCover
        NoCurrentProvider

        TryForAppointment
        TryForCallBackApointment
        ' CheckBroker
        AgentDirect

        MakeAppointment
        MadeAppointment
        RedirectedContactInfo

        AppointmentMade

        CheckPayMonthly
        'Goodbye
        'Cleanup

        OutofArea

        Finished
    End Enum

    Private CurrentState As States = States.Starting

    Private oContainer As Control 'this is the control on form that will hold the script
    Private ThisUser As Common.cUser
    Private ThisCompany As Common.cCompany
    Private ThisCall As Common.cCallHistory
    Public previousState As States
    Public Event Completed()

    Public Sub New(ByVal Container As Control, ByVal User As Common.cUser, ByVal oCall As Common.cCallHistory)
        oContainer = Container
        ThisUser = User
        ThisCall = oCall
    End Sub

    Public Sub Start(ByVal UseDialer As Boolean)
        'start the script


        'do any stuff required before we start here


        'kick off the first stage:


        If frmAgent.nextAction <> "" Then
            frmAgent.App.WriteAgentEvent("Started " & frmAgent.nextAction)
            Dim afrm As New frmHolder(frmAgent.nextAction)
            afrm.ShowDialog()
            frmAgent.App.WriteAgentEvent("Ended " & frmAgent.nextAction)
        End If
        frmAgent.nextAction = ""
        Try
            frmAgent.App.UpdateDeskUser(frmAgent.App.User.ID)
        Catch ex As Exception

        End Try

        If UseDialer = False Then
            ThisCall.StartCall()
            StartStage(States.PleaseDial)
        Else
            StartStage(States.Starting)

        End If



    End Sub

    Public Sub EndState(ByVal EndingState As States, ByVal NextState As States, Optional ByVal Data As Object = Nothing)


        'do any finalising processing for the ending state (if any)
        'startign the next state will remove the form for the previous state

        'execute the next stage
        previousState = CurrentState
        StartStage(NextState)

    End Sub

    Private Sub StartStage(ByVal NextState As States)
        'prepare for the stage, then start it going
        CurrentState = NextState

        Select Case CurrentState
            Case States.AppointmentMade

                ThisCall.StartCall()
                StartStage(States.Introduction)
                'Case States.CheckBroker
                '    Dim aFrm As New frmCheckBroker(Me, CurrentState, ThisCall)
                '    ShowForm(aFrm)
                'Case States.AgentDirect
                '    Dim aFrm As New frmAgentDirect(Me, CurrentState, ThisCall)
                'ShowForm(aFrm)
            Case States.RedirectedContactInfo

                Dim aFrm As New frmRedirectedContactInfo(Me, CurrentState, ThisCall)
                ShowForm(aFrm)

            Case States.PleaseDial
                'the telecoms server aint working,
                'ask the user to dial manually
                Dim aFrm As New frmManualDial(Me, CurrentState, ThisCall)
                ShowForm(aFrm)

            Case States.Starting

                ThisCall.StartCall()
                frmAgent.App.UpdateDeskCalls(ThisUser.ID)

                ' frmAgent.IsInTrainingMode = True
                If frmAgent.IsInTrainingMode Then

                Else
                    If cAgentApp.GetInstance.User.UserLevelID = Common.eUserLevel.Developer Then
                        Dim sNumber As String = ""
                        Dim aFrm As New frmNumberToDial
                        aFrm.ShowDialog()
                        sNumber = aFrm.Number
                        frmAgent.ToolStatus.Text = ""
                        Try
                            frmAgent.oDialer = New Common.cDialer
                            frmAgent.oDialer.NumberToDial = sNumber
                            frmAgent.oDialer.Dial()

                        Catch ex As Exception

                        End Try
                    Else
                        Try
                            frmAgent.oDialer = New Common.cDialer
                            frmAgent.oDialer.NumberToDial = ThisCall.Company.Telephone
                            frmAgent.oDialer.Dial()
                        Catch ex As Exception

                        End Try

                    End If
                End If

                StartStage(States.Introduction)

            Case States.CheckContact
                Dim aFrm As New frmCheckContact(Me, CurrentState, ThisCall, cAgentApp.GetInstance.User.RealName)
                ShowForm(aFrm)

            Case States.Introduction
                Dim aFrm As New frmIntroduction(Me, CurrentState, ThisCall, cAgentApp.GetInstance.User)
                ShowForm(aFrm)

            Case States.TryForAppointment
                Dim aFrm As New frmTryForAppointment(Me, CurrentState, ThisCall)
                ShowForm(aFrm)

            Case States.IntroColdContactDetails
                Dim aFrm As New frmScriptColdContactDetails(Me, CurrentState, ThisCall)
                ShowForm(aFrm)

            Case States.IntroContact
                Dim aFrm As New frmCheckContact(Me, CurrentState, ThisCall, ThisUser.RealName)
                ShowForm(aFrm)

            Case States.CurrentCover
                Dim aFrm As New frmCurrentCover(Me, CurrentState, ThisCall)
                ShowForm(aFrm)

            Case States.NoCurrentProvider
                Dim aFrm As New frmNoProvider(Me, CurrentState, ThisCall)
                ShowForm(aFrm)
            Case States.CheckPayMonthly
                Dim aFrm As New FrmCheckPayMonthly(Me, CurrentState, ThisCall)
                ShowForm(aFrm)
            Case States.MakeAppointment
                Dim aFrm As New frmMakeAppointment(Me, CurrentState, ThisCall)
                ShowForm(aFrm)
            Case States.TryForCallBackApointment
                Dim aFrm As New CallBackTryForApointment(Me, CurrentState, ThisCall, ThisUser.RealName)
                ShowForm(aFrm)
            Case States.Finished
                Try
                    frmAgent.oDialer.Disconnect()
                Catch ex As Exception
                End Try
                Try
                    cAgentApp.GetInstance.UpdateDeskCalls(ThisUser.ID)
                Catch ex As Exception
                    MessageBox.Show("Exception during UpdateDeskCalls(" & ThisUser.ID & ") - " & ex.Message)
                End Try

                RaiseEvent Completed()

            Case States.OutofArea
                Dim aFrm As New frmOutofArea(Me, CurrentState, ThisCall, ThisUser.RealName)
                ShowForm(aFrm)
            Case Else
                MessageBox.Show("StartStage: unexpected state: " & CurrentState.ToString)
        End Select

    End Sub

    Private Sub ShowForm(ByVal aForm As Form)

        aForm.TopLevel = False
        Dim xFrm As Form
        For Each obj As Object In oContainer.Controls
            Try
                xFrm = obj
                xFrm.Dispose()
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        Next
        GC.Collect()
        GC.WaitForPendingFinalizers()

        oContainer.Controls.Clear()


        oContainer.Controls.Add(aForm)

        With aForm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With

    End Sub

End Class
