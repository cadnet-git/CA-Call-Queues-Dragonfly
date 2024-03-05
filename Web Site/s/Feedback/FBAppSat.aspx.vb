
Partial Class s_FBStage1
    Inherits System.Web.UI.Page
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")
    End Sub

    Protected Sub BtnYes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnYes.Click
        fb.Sat = True
        Session("FeedBack") = fb
        Response.Redirect("fbinvolvedinProduct.aspx")
    End Sub

    Protected Sub BtnNo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNo.Click
        fb.Sat = False
        Session("FeedBack") = fb
        Response.Redirect("FBGetReason.aspx")
    End Sub
End Class
