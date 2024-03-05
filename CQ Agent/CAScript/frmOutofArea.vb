Public Class frmOutofArea

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

    End Sub
    Private Sub btnHangup_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnHangup.Click
        Me.Enabled = False


        ThisCall.EndCallOutofArea("Changed Postcode")


        oScript.EndState(iState, ScriptEngine.States.Finished)
    End Sub

    Private Sub frmOutofArea_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class