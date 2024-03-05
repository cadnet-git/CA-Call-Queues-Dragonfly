
Partial Class FBGetContact
    Inherits System.Web.UI.Page


    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click

        If txtName.Text.Trim = "" Or txtPosition.Text.Trim = "" Then
            lblError.Text = "You need to enter both a name and position"
            Exit Sub
        End If
        fb.Contact = txtName.Text.Trim
        fb.Position = txtPosition.Text.Trim
        Session("feedback") = fb
        Response.Redirect("FBNote.aspx")
    End Sub

    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        fb.Contact = ""
        fb.Position = ""
    End Sub
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        fb = Session("FeedBack")
        If IsPostBack = False Then
            Dim myFile As String = System.IO.Path.GetFileName(Request.UrlReferrer.AbsoluteUri)
            If myFile.ToLower <> "fbnote.aspx" Then
                Session("GetContact") = myFile
            End If
            BtnBack.PostBackUrl = Session("GetContact")
            txtName.Text = fb.Contact
            txtPosition.Text = fb.Position
        End If
        BtnNext.Focus()
    End Sub


End Class
