Public Class FrmCheckPayMonthly

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
        'frmAgent.Text = Me.Name
    End Sub

    Private Sub BtnAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnAppointment.Click

        oScript.EndState(iState, ScriptEngine.States.MakeAppointment)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click

        Using afrm As New frmGetReasonCallback(ThisCall)
            If afrm.ShowDialog() = DialogResult.OK Then
                frmAgent.App.UpdateDeskStatus("Create Callback")
                ThisCall.EndCallCreateCallBack(frmAgent.IsInTrainingMode)
                oScript.EndState(iState, ScriptEngine.States.Finished)
            End If
        End Using


    End Sub

    Private Sub FrmCheckPayMonthly_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        frmAgent.App.UpdateDeskStatus("Check for Pay Monthly")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        oScript.EndState(iState, ScriptEngine.States.CurrentCover)
    End Sub
End Class