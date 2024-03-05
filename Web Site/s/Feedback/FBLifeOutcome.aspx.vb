
Partial Class s_Feedback_FBLifeOutcome
    Inherits System.Web.UI.Page
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBOutcome.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        fb.LifeOutCome = ddOutcome.SelectedItem.Text
        Select Case ddOutcome.SelectedValue
            Case 1, 2
                fb.LifeNotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("FBLifeGetNextContact.aspx")
            Case 6
                fb.LifeNextContact = ""
                fb.LifeNotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("fbLifeSale.aspx")
            Case 10
                fb.LifeNextContact = ""
                Session("Feedback") = fb
                Response.Redirect("fbLifeNotPresented.aspx")
            Case Else
                fb.LifeNextContact = ""
                fb.LifeNotPresented = ""
                Session("Feedback") = fb
                Response.Redirect("fbNote.aspx")
        End Select

    End Sub

    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")
        If IsPostBack Then
            ddOutcome.Text = fb.LifeOutCome
        End If

    End Sub
End Class
