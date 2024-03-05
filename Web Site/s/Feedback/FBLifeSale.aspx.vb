Imports System.Data

Partial Class s_FBSale
    Inherits System.Web.UI.Page
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")



        If IsPostBack = False Then
            lblError.Text = ""
        End If

    End Sub
    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click

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



        fb.LifeSoldDate = txtSoldDate.Text
        fb.LifeStartDate = txtStartDate.Text
        fb.LifeValue = TxtValue.Text & " " & ddPayment.SelectedValue

        Response.Redirect("FBNote.aspx")
    End Sub

    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBoutcome.aspx")
    End Sub


End Class
