Public Class frmTryForAppointment

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



    Private Sub frmTryForAppointment_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        frmAgent.App.UpdateDeskStatus("Selling Appointment")
    End Sub

    Private Sub BtnAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnAppointment.Click
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.MakeAppointment)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        oScript.EndState(iState, ScriptEngine.States.CurrentCover)
    End Sub
End Class