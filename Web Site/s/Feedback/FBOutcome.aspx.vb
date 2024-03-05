
Partial Class s_FBOutcome
    Inherits System.Web.UI.Page

    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("fbinvolvedinProduct.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        fb.OutCome = ddOutcome.SelectedItem.Text

        Select Case ddOutcome.SelectedValue
            Case 5, 6
                fb.PMINotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("fbGetNextContact.aspx")
            Case 8
                fb.NextContact = ""
                fb.PMINotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("fbSale.aspx")
            Case 10
                fb.NextContact = ""
                Session("Feedback") = fb
                Response.Redirect("fbNotPresented.aspx")
            Case Else
                fb.NextContact = ""
                fb.PMINotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("fbrenewal.aspx")
        End Select
    End Sub

    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")
        If IsPostBack = False Then
            ddOutcome.SelectedItem.Text = fb.OutCome
        End If

    End Sub
End Class
