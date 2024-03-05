Imports System.Windows.Forms
Imports System.Drawing
Public Class frmChangeTelephone

    Private oCompany As Common.cCompany

    Public Sub New(ByVal Company As Common.cCompany)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        oCompany = Company
    End Sub
    Private Sub txtTelephone_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTelephone.KeyUp
        Dim aTxt As TextBox = sender
        lblError.Text = ""
        If IsNumeric(aTxt.Text) Then
            aTxt.BackColor = Color.White
        Else
            aTxt.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub txtTelephone_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTelephone.TextChanged

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim sTemp As String = Me.txtTelephone.Text.Trim
        If sTemp.Length < 1 Then
            lblError.Text = "Please enter a telephone number"

            Exit Sub
        End If
        If sTemp.Substring(0, 1) <> "0" Then
            lblError.Text = "Telephone number must start with a zero"
            Exit Sub
        End If
        If Common.StringManipulation.RemoveNonNumerics(sTemp) <> sTemp Then
            'can only have numerics in a telephone number
            lblError.Text = "Tel No. can only contain numbers"
            Exit Sub
        End If
        'need to make sure the telephone number is unique in the database
        Dim sSQL As String = "SELECT * from Companies where telephone='" & sTemp & "' AND CompanyStatus <> 'Supervisor' AND ID <>" & oCompany.ID & " AND GroupCompanyID= " & oCompany.GroupCompanyID
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)
        If DS.Tables(0).Rows.Count > 0 Then
            'the telephone number is already in use
            lblError.Text = "Number already in use"
            Exit Sub
        End If
        DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmChangeTelephone_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        lblError.Text = ""
    End Sub
End Class