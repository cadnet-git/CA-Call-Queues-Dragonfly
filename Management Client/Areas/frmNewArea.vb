Public Class frmNewArea

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
                Me.Text = "Create Area"
                btnCreate.Text = "Create"
                Label1.Text = "To create a new area, enter its title below:"
            Case eDisplayMode.Edit
                Me.Text = "Edit Area"
                btnCreate.Text = "Save"
                Label1.Text = "Edit the areas title below:"
        End Select

    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCreate.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTitle.TextChanged
        'test the proposed area name to see if its acceptable

        Dim TestArea = New cArea
        Dim sClean As String = TestArea.cleanandtestname(Me.txtTitle.Text)

        If sClean.Length = 0 Then
            'cant use that yet
            Me.btnCreate.Enabled = False
        Else
            Me.btnCreate.Enabled = True
        End If

    End Sub

    Private Sub frmNewArea_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class