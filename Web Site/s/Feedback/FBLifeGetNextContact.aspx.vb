Partial Class s_Feedback_fbGetNextAppDate
    Inherits System.Web.UI.Page
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBLifeOutcome.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        If txtNextContact.Text.Trim = "" Then
            lblError.Text = "You need to enter a date"
            Exit Sub
        End If
        fb.LifeNextContact = txtNextContact.Text
        Session("feedback") = fb
        Response.Redirect("FBNote.aspx")

    End Sub

    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        fb = Session("FeedBack")
        If fb.LifeOutCome = "Quoted and 2nd appointment booked" Then
            lblTitle.Text = "When is next appointment?"
            lblReminder.Visible = True
        Else
            lblTitle.Text = "When is next contact with client?"
            lblReminder.Visible = False
        End If
        If IsPostBack = False Then
            txtNextContact.Text = fb.LifeNextContact
        End If

    End Sub
End Class

