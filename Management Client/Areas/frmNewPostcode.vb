Public Class frmNewPostcode

    Public Enum eDisplayMode
        Create
        Edit
    End Enum

    Public Sub New(ByVal DisplayMode As eDisplayMode)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case DisplayMode
            Case eDisplayMode.Create
                Me.Text = "Create Postcode"
                btnCreate.Text = "Create"
                Label1.Text = "To create a new postcode, enter its below:"
            Case eDisplayMode.Edit
                Me.Text = "Edit Postcode"
                btnCreate.Text = "Save"
                Label1.Text = "Edit the postcode below:"
        End Select

    End Sub

    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTitle.TextChanged

        Dim sClean As String = Common.RemoveNonAlphaNumerics(txtTitle.Text)

        If sClean.Length > 1 Then
            Me.btnCreate.Enabled = True
        Else
            Me.btnCreate.Enabled = False
        End If

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCreate.Click
        Dim sClean As String = Common.RemoveNonAlphaNumerics(txtTitle.Text)
        If sClean.Length = 2 Then
            If MsgBox("This Postcode is ony 2 characters. Is this correct?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class