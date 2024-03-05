Public Class frmCheckNotinterested


    Private iid As Integer
    Public Property ID() As Integer
        Get
            Return iid
        End Get
        Set(ByVal value As Integer)
            iid = value
        End Set
    End Property

    Private iCompanyid As Integer
    Public Property CompanyID() As Integer
        Get
            Return iCompanyid
        End Get
        Set(ByVal value As Integer)
            iCompanyid = value
        End Set
    End Property


    Private Sub frmCheckNotinterested_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnOK.Click
        Dim months As Integer = 0
        Select Case cbCallBack.Text
            Case "4 Months"
                months = 0
            Case "8 Months"
                months = 4
            Case "12 Months"
                months = 8
            Case "18 Months"
                months = 14
            Case "24 Months"
                months = 20
        End Select
        Dim theCompany As New Common.cCompany(CompanyID)
        With theCompany

            .CallBackOn(Now.AddMonths(months))
            .Save()
        End With
        Dim dObj As New Common.DataLayer
        dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=1 where ID=" & ID)
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Dim months As Integer = 0
        Select Case cbCallBack.Text
            Case "4 Months"
                months = 0
            Case "8 Months"
                months = 4
            Case "12 Months"
                months = 8
            Case "18 Months"
                months = 14
            Case "24 Months"
                months = 20
        End Select
        Dim theCompany As New Common.cCompany(CompanyID)
        With theCompany
            .Status = "ColdCall"
            .CallBackOn(Now.AddMinutes(15))
            .Save()
        End With
        Dim dObj As New Common.DataLayer
        dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=2 where ID=" & ID)
        DialogResult = DialogResult.OK
    End Sub
End Class