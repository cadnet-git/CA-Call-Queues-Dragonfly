Public Class frmCheckContact

    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory

    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory, ByVal Username As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall


        lblUsernameGreet.Text = lblUsernameGreet.Text.Replace("<username>", Username)
        'frmAgent.Text = Me.Name

    End Sub




    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNo.Click
        ' need to do something different here 
        oScript.EndState(iState, ScriptEngine.States.RedirectedContactInfo)

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

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnYes.Click
        oScript.EndState(iState, ScriptEngine.States.CurrentCover)
    End Sub

    Private Sub frmScriptIntroContact_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load



        If DateTime.Compare(Now, DateTime.Parse("11:59:59 AM")) = 1 Then
            'its the afternoon
            Me.lblGreet.Text = "Good Afternoon,"
        Else
            'its still morning
            Me.lblGreet.Text = "Good Morning,"
        End If
        frmAgent.App.UpdateDeskStatus("Checking is Contact")
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


    Private Sub btnOutofArea_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOutofArea.Click
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

    Private Sub btnSupervisor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSupervisor.Click
        frmAgent.App.UpdateDeskStatus("Supervisor Attention")
        Dim sReason As String = ""

        Dim aFrm As New FrmGetReasonSupervisor
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        Me.Enabled = False
        ThisCall.EndCallSupervisor(sReason)
        oScript.EndState(iState, ScriptEngine.States.Finished)

    End Sub

    Private Sub pnlQ1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlQ1.Paint

    End Sub
End Class