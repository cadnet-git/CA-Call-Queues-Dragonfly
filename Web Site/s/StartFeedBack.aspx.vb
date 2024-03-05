
Partial Class s_StartFeedBack
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim fb As New Feedback
        fb.ID = Request("ID")
        Session("FeedBack") = fb
        Response.Redirect("feedback/FBAppSat.aspx")
    End Sub
End Class
