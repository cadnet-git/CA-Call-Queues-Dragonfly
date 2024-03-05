
Partial Class s_FBNote
    Inherits System.Web.UI.Page

    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click

    End Sub
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("Feedback")
        If IsPostBack = False Then
            Dim myFile As String = System.IO.Path.GetFileName(Request.UrlReferrer.AbsoluteUri)
            BtnBack.PostBackUrl = myFile
        End If
        BtnFinish.Focus()

    End Sub

    Private sNote As String
    Public Property Note() As String
        Get
            Return sNote
        End Get
        Set(ByVal value As String)
            sNote = value
        End Set
    End Property


    Protected Sub BtnFinish_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFinish.Click
        fb.Note = txtNote.Text

        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")

        fb.Save(iUserID)
        If Session("ReturnURL") = Nothing Then
            Response.Redirect("AppointmentsNeedingFeedback.aspx")
        Else
            Response.Redirect(Session("ReturnURL"))
        End If

    End Sub
End Class