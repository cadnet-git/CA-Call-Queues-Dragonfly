Public Class frmEditImport

    Private bLoading As Boolean = True
   Private ColorAlert As System.Drawing.Color = Color.LightSalmon

    Public Sub New(ByVal CompanyName As String, ByVal Telephone As String, ByVal OriginalPostCode As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        bLoading = False
        ' Add any initialization after the InitializeComponent() call.

        Me.txtPostcode.Text = OriginalPostCode.Trim.ToUpper
        Me.txtTelephone.Text = Telephone.Trim.ToUpper
        Me.txtCompany.Text = CompanyName.Trim

        Me.lblPostcode.Text = OriginalPostCode.Trim.ToUpper
        Me.lblCompany.Text = CompanyName
        Me.lblTelephone.Text = Telephone.ToUpper

    End Sub

    Private Sub btnRetry_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRetry.Click

        If Me.chkCreatePostcode.Checked Then
            Dim sMsg As String = "Are you sure you want to create '" & Common.cPostcode.CleanPostcode(Me.txtPostcode.Text) & "?"

            Dim DR As DialogResult = MessageBox.Show(sMsg, "Create Postcode?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            Select Case DR
                Case DialogResult.No
                    Exit Sub
                Case DialogResult.Yes
                Case Else
                    MessageBox.Show("Unexpected result: " & DR.ToString)
                    Exit Sub
            End Select
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSkip.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtCompany_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCompany.TextChanged
        If txtCompany.Text.Trim.Length < 1 Then
            txtCompany.BackColor = ColorAlert
        Else
            txtCompany.BackColor = Color.White
        End If
    End Sub

    Private Sub txtTelephone_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTelephone.TextChanged

        If bLoading Then Exit Sub

        If Common.ValidateTelephone(txtTelephone.Text).Length < 1 Then
            txtTelephone.BackColor = Color.LightSalmon
        Else
            txtTelephone.BackColor = Color.White
        End If

    End Sub


    Private Sub txtPostcode_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPostcode.TextChanged

        If bLoading Then Exit Sub

        If txtPostcode.ReadOnly Then
            txtPostcode.BackColor = Color.Silver
            Exit Sub
        End If

        Me.chkCreatePostcode.Checked = False

        If Common.cPostcode.ValidatePostcode(txtPostcode.Text).Length > 0 Then
            txtPostcode.BackColor = ColorAlert
        Else
            txtPostcode.BackColor = Color.White
            'now the postcode has validated, we need to check if it already exisits.
            If Common.cPostcode.PrefixExists(Common.cPostcode.GetPrefix(Me.txtPostcode.Text)) Then
                'the post code exists, so dont need confirmation
                Me.chkCreatePostcode.Enabled = False
                Me.chkCreatePostcode.BackColor = Me.BackColor
                Me.btnRetry.Enabled = True
            Else
                'the post code does not exist, so we need to get a confirmation from the user
                Me.chkCreatePostcode.Enabled = True

                Me.chkCreatePostcode.BackColor = ColorAlert
                Me.btnRetry.Enabled = False
            End If
        End If

    End Sub

    Private Sub chkCreatePostcode_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCreatePostcode.CheckedChanged
        Me.btnRetry.Enabled = Me.chkCreatePostcode.Checked
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnStop.Click
        Me.DialogResult = DialogResult.Abort
    End Sub

    Private Sub frmEditImport_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class