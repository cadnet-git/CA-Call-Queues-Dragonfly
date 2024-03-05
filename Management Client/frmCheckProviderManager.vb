Public Class frmCheckProviderManager
    Public ThisCompany As Common.cCompany
    Public Sub New(ByVal acompany As Common.cCompany)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ThisCompany = acompany
    End Sub



    Private Sub frmCheckProviderManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        With cmbExpires
            For i As Integer = 0 To 16
                Dim aDate As Date = (New DateTime(Today.Year, Today.Month, 1))
                aDate = DateAdd(DateInterval.Month, i, aDate)
                .Items.Add(aDate.ToString("MMMM yyyy"))
            Next
        End With

        With cmbExpiresDay
            For i As Integer = 1 To 31
                .Items.Add(i)
            Next
        End With

        Dim ds As DataSet
        Dim Database As New Common.DataLayer
        ds = Database.ExecuteSQL("Select * from insurers order By description")
        cboProvider.Items.Add("No Cover")
        For Each dr As DataRow In ds.Tables(0).Rows
            cboProvider.Items.Add(dr("Description".ToString))
        Next
       
      
    End Sub

 

    Private Sub cboProvider_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboProvider.SelectedIndexChanged
        If cboProvider.Text = "Other" Then
            txtOther.Visible = True
            txtOther.Focus()
        Else
            txtOther.Visible = False
        End If
    End Sub
    Private Sub checkOk()
        Dim result As Boolean = False
        If cboProvider.Text <> "" Then
            If cboProvider.Text = "No Cover" Then
                result = True
            Else
                If cmbExpires.Text <> "" Then
                    result = True
                End If
            End If
        End If
        BtnOK.Enabled = result
    End Sub
    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
        If cmbExpiresDay.Text = "" Then cmbExpiresDay.Text = "1"
        DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

  
    Private Sub cboProvider_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboProvider.TextChanged
        checkOk()
    End Sub

    Private Sub cmbExpires_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbExpires.TextChanged
        checkOk()
    End Sub
End Class