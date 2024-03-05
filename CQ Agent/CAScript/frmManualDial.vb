Public Class frmManualDial

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

        Me.lblNumberToDial.Text = ThisCall.Company.Telephone
        'frmAgent.Text = Me.Name
    End Sub

    Private Sub btnTPS_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTPS.Click
        Me.Enabled = False
        ThisCall.EndCallTPS()
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub btnNotRecognised_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotRecognised.Click
        Me.Enabled = False
        ThisCall.EndCallNotRecognised(Name)
        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub



    Private Sub btnConnected_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConnected.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.Starting)
    End Sub

    Private Sub frmManualDial_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub
End Class