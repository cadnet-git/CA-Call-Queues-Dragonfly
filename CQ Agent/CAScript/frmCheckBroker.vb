Public Class frmCheckBroker
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
    End Sub


    Private Sub frmCheckBroker_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        frmAgent.App.UpdateDeskStatus("Checking for broker")
    End Sub


    Private Sub btnBroker_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBroker.Click
        If DateDiff(DateInterval.Month, Now, ThisCall.Company.PolicyExpires) < 3 Then
            If ThisCall.Company.Status = "CallBack" Then
                oScript.EndState(iState, ScriptEngine.States.TryForCallBackApointment)
            Else
                oScript.EndState(iState, ScriptEngine.States.TryForAppointment)
            End If

        Else
            oScript.EndState(iState, ScriptEngine.States.CheckPayMonthly)
        End If
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnBack.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.CurrentCover)
    End Sub

    Private Sub BtnDirect_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnDirect.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.AgentDirect)
    End Sub
End Class