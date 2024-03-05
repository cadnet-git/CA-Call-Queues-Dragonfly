
Partial Class s_Feedback_fbNotPresented
    Inherits System.Web.UI.Page
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBOutcome.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click

        If txtPMINotPresented.Text.Trim = "" Then
            lblError.Text = "You need to enter a reason"
            Exit Sub
        End If
        fb.PMINotPresented = txtPMINotPresented.Text
        Session("feedback") = fb
        Response.Redirect("FBLifeOutcome.aspx")

    End Sub

    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")
        If IsPostBack = False Then
            txtPMINotPresented.Text = fb.PMINotPresented
        End If
    End Sub
End Class
