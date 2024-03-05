Public Class frmScriptColdContactDetails

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

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFinish.Click

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

    Private Sub txtForename_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtForename.Leave
        With ThisCall.Company
            .ContactForename = Me.txtForename.Text
            .Save()
            frmAgent.ShowCompany()
            Me.txtForename.Text = .ContactForename
        End With
    End Sub

    Private Sub txtSurname_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtSurname.Leave
        With ThisCall.Company
            .ContactSurname = Me.txtSurname.Text
            .Save()
            frmAgent.ShowCompany()
            Me.txtSurname.Text = .ContactSurname
        End With
    End Sub

    Private Sub txtPosition_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtPosition.Leave
        With ThisCall.Company
            .ContactPosition = Me.txtPosition.Text
            .Save()
            frmAgent.ShowCompany()
            Me.txtPosition.Text = .ContactPosition
        End With
    End Sub

    Private Sub cmbTitle_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTitle.Leave
        With ThisCall.Company
            .ContactTitle = Me.cmbTitle.Text
            .Save()
            frmAgent.ShowCompany()
        End With
    End Sub



    Private Sub frmScriptColdContactDetails_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        frmAgent.App.UpdateDeskStatus("Collecting Contact Details")

    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnBack.Click
        Me.Enabled = False

        oScript.EndState(iState, ScriptEngine.States.Introduction)

    End Sub

    Private Sub txtForename_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtForename.TextChanged

    End Sub
End Class