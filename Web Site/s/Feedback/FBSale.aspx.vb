Imports System.Data

Partial Class s_FBSale
    Inherits System.Web.UI.Page
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")

        If IsPostBack = False Then

            Dim d As New CADNet.CallQueues.Common.DataLayer
            Using ds As DataSet = d.ExecuteSQL("SELECT Description FROM Insurers order by description")
                ddProvider.Items.Add("Not Selected")
                ddProvider.Items.Add("No Cover")
                For Each dr As DataRow In ds.Tables(0).Rows
                    ddProvider.Items.Add(dr("Description"))
                Next
            End Using

            lblError.Text = ""
        End If

    End Sub
    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        If ddType.Text = "Not Selected" Then
            lblError.Text = "You need to select a type"
            Exit Sub
        End If
        If ddPayment.Text = "Not Selected" Then
            lblError.Text = "You need to select a payment Frequency"
            Exit Sub
        End If
        If TxtValue.Text = "" Then
            lblError.Text = "You need to enter a value"
            Exit Sub
        End If

        If txtSoldDate.Text = "" Then
            lblError.Text = "You need to enter a sold date"
            Exit Sub
        End If
        If txtStartDate.Text = "" Then
            lblError.Text = "You need to enter a start date"
            Exit Sub
        End If

        If ddProvider.Text = "Not Selected" Then
            lblError.Text = "You need to select a previous provider"
            Exit Sub
        End If

        fb.SoldDate = txtSoldDate.Text
        fb.StartDate = txtStartDate.Text
        fb.Value = TxtValue.Text & " " & ddPayment.SelectedValue
        fb.PreviousProvider = ddProvider.Text

        fb.SaleType = ddType.Text
        Session("FeedBack") = fb

        Response.Redirect("FBLifeOutcome.aspx")
    End Sub

    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBoutcome.aspx")
    End Sub


End Class
