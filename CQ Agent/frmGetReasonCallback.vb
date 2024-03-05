Public Class frmGetReasonCallback

    Private _thisCall As Common.cCallHistory

    Sub New(ThisCall As Common.cCallHistory)

        InitializeComponent()


        _thisCall = ThisCall
    End Sub



    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        _thisCall.CallbackReason = txtReason.Text
        Select Case txtReason.Text
            Case "Already Renewed", "Callback Next Year"
                If _thisCall.Company.CallbackAttempts > 0 Then
                    ' this is the second time the agent has tried to convert this callback 
                    _thisCall.CallbackStatus = Common.cCallHistory.CallbackNextStage.ManagersPot
                Else
                    _thisCall.CallbackStatus = Common.cCallHistory.CallbackNextStage.StayWithAgent
                End If
            Case "Cancelled Policy"
                _thisCall.CallbackStatus = Common.cCallHistory.CallbackNextStage.ToColdCall
            Case Else
                ' move to manager 
                _thisCall.CallbackStatus = Common.cCallHistory.CallbackNextStage.ManagersPot
        End Select
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtReason_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtReason.TextChanged
        If txtReason.Text.Length > 0 Then
            btnOK.Enabled = True
        End If
    End Sub

    Private Sub txtReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtReason.SelectedIndexChanged
        If txtReason.Text.Length > 0 Then
            btnOK.Enabled = True
        End If
    End Sub



End Class