
Partial Class s_FBGetReason
    Inherits System.Web.UI.Page


    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        ddReason.SelectedValue = 0
        Response.Redirect("FBAppSat.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        Select Case CInt(ddReason.SelectedValue)
            Case 0
                lblError.Text = "You need to Select a Reason"
            Case 5
                fb.ReasonNotSat = ddReason.SelectedItem.Text
                Session("feedback") = fb
                Response.Redirect("FBGetContact.aspx")
            Case Else
                fb.ReasonNotSat = ddReason.SelectedItem.Text
                Session("feedback") = fb
                Response.Redirect("FBnote.aspx")
        End Select

    End Sub

    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        fb = Session("FeedBack")
        If IsPostBack = False Then
            ddReason.Text = fb.ReasonNotSat
        End If

    End Sub
End Class
