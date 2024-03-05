Public Class frmIntroduction

    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory
    Private thisuser As Common.cUser
    Private NoName As Boolean
    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory, ByVal User As Common.cUser)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall

        thisuser = User
        Me.lblContactName.Text = ThisCall.Company.ContactTitle & " " & ThisCall.Company.ContactSurname
        'frmAgent.Text = Me.Name
    End Sub

    Private Sub frmReschedIntro_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        If ThisCall.Company.StandardLife = 1 Then
            Me.BackColor = Color.LightGoldenrodYellow
            Me.lblStdLife.Text = ThisCall.Company.Promotion
            Me.lblStdLife.Visible = True
        End If

        Dim ampm As String


        If DateTime.Compare(Now, DateTime.Parse("11:59:59 AM")) = 1 Then
            ampm = "Afternoon"
        Else
            ampm = "Morning"
        End If

        'its the afternoon
        If ThisCall.Company.ContactSurname <> "" Then
            Me.lblGreet.Text = "Good " & ampm & ", May I speak to " & ThisCall.Company.ContactTitle & " " & ThisCall.Company.ContactForename & " " & ThisCall.Company.ContactSurname
            Me.lblContactName.Text = ""
            NoName = False
        Else
            Me.lblGreet.Text = "Good " & ampm & ", May I speak to the person who would make the decision"
            Me.lblContactName.Text = "regarding the company's medical insurance?"
            NoName = True
        End If

        'its still morning


    End Sub


    Private Sub btnNotRecognised_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotRecognised.Click
        frmAgent.App.UpdateDeskStatus("Not Recognised")
        Me.Enabled = False
        ThisCall.EndCallNotRecognised(Name)
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub btnTPS_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTPS.Click
        frmAgent.App.UpdateDeskStatus("TPS")
        Me.Enabled = False
        ThisCall.EndCallTPS()
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub BtnYes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnYes.Click
        Me.Enabled = False
        Select Case ThisCall.Company.Status
            Case "CallBack"
                '  If ThisCall.Company.PolicyProvider = "Standard Life" Or ThisCall.Company.PolicyProvider = "Prime Health" Then
                '  oScript.EndState(iState, ScriptEngine.States.CheckBroker)
                ' Else
                oScript.EndState(iState, ScriptEngine.States.TryForCallBackApointment)
                '  End If

            Case "NotToHand"
                oScript.EndState(iState, ScriptEngine.States.CurrentCover)
            Case Else
                oScript.EndState(iState, ScriptEngine.States.CheckContact)
        End Select

    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNo.Click

        If NoName Then
            oScript.EndState(iState, ScriptEngine.States.IntroColdContactDetails)
        Else
            Dim aFrm As New frmScriptReschedule
            Dim DR As DialogResult = aFrm.ShowDialog

            If DR <> DialogResult.OK Then
                Exit Sub
            End If

            Dim oDate As Date
            If frmAgent.IsInTrainingMode Then
                oDate = Now
            Else
                oDate = aFrm.SelectedDate
            End If
            ThisCall.EndCallReschedule(oDate, aFrm.txtReason.Text)

            oScript.EndState(iState, ScriptEngine.States.Finished)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Dim sReason As String = ""
        frmAgent.App.UpdateDeskStatus("Out of Area")
        Dim aFrm As New frmGetReason
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        ThisCall.EndCallOutofArea(sReason)

        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub btnReschedule_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReschedule.Click
        Dim aFrm As New frmScriptReschedule
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        Dim oDate As Date
        If frmAgent.IsInTrainingMode Then
            oDate = Now
        Else
            oDate = aFrm.SelectedDate
        End If

        ThisCall.EndCallReschedule(oDate, aFrm.txtReason.Text)

        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub btnNotInterested_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotInterested.Click
        Dim sReason As String = ""
        frmAgent.App.UpdateDeskStatus("Not Interested")
        Dim aFrm As New frmGetReasonNotInterested
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        ThisCall.EndCallNotInterested(sReason, aFrm.Months)
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub


    Private Sub btnSupervisor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSupervisor.Click
        frmAgent.App.UpdateDeskStatus("Supervisor Attention")
        Dim sReason As String = ""

        Dim aFrm As New FrmGetReasonSupervisor
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        Enabled = False
        ThisCall.EndCallSupervisor(sReason)
        oScript.EndState(iState, ScriptEngine.States.Finished)

    End Sub
End Class