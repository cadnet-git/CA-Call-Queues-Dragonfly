Public Class CallBackTryForApointment
    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory
    Private noname As Boolean = False
    Private ThisUser As String
    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory, ByVal AUser As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall
        ThisUser = AUser
        'frmAgent.Text = Me.Name
    End Sub

    Private Sub CallBackTryForApointment_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load




        Dim ampm As String
        If DateTime.Compare(Now, DateTime.Parse("11:59:59 AM")) = 1 Then
            ampm = "Afternoon"
        Else

            ampm = "Morning"
        End If

        'its the afternoon
        Label1.Text = "Good " & ampm & ", " & ThisCall.Company.ContactTitle & " " & ThisCall.Company.ContactForename & " " & ThisCall.Company.ContactSurname & ". It is " & ThisUser & " from Dragonfly Crowd"
        Label3.Text = "You told me that you are covered by " & ThisCall.Company.PolicyProvider & " and your renewal is comming up. "
        noname = False
        frmAgent.App.UpdateDeskStatus("CallBack trying for appointment")
    End Sub

    Private Sub BtnAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnAppointment.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.MakeAppointment)
    End Sub


    Private Sub btnNotInterested_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotInterested.Click
        frmAgent.App.UpdateDeskStatus("Not Interested")
        Dim sReason As String = ""

        Dim aFrm As New frmGetReasonNotInterested
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then

            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        ThisCall.EndCallNotInterested(sReason, aFrm.Months)
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub


    Private Sub BtnReshedule_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnReshedule.Click

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

        ThisCall.EndCallReschedule(oDate, "Rescheduled")

        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnCreateCallback_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCreateCallback.Click
        frmAgent.App.UpdateDeskStatus("Call back Next Year")
        oScript.EndState(iState, ScriptEngine.States.CurrentCover)
    End Sub
End Class