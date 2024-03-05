Public Class frmNoProvider

    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory

    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall

        ' lblWords.Text = "Is there any perticular reason why you don't have any Health Cover?"
        'lblcoaching.Text = "This is where you make money...."
        ' lblcoaching2.Text = "....lets get that appointment!!!!"
        'frmAgent.Text = Me.Name
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

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim aFrm As New frmScriptReschedule
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        Me.Enabled = False

        Dim oDate As Date = aFrm.SelectedDate

        Me.Enabled = False

        MsgBox("need to end call here")
        'ThisCall.EndCalested(oDate)

        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub BtnAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnAppointment.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.MakeAppointment)
    End Sub

    Private Sub frmNoProvider_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        frmAgent.App.UpdateDeskStatus("Selling No Provider")

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
End Class