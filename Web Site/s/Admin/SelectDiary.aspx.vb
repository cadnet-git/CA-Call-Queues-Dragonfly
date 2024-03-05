
Partial Class s_Admin_SelectDiary
    Inherits System.Web.UI.Page

    Protected Sub s_Admin_SelectDiary_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            'get all the appointments for the week including the date passed // My.User.Name
            Dim sSQL As String = "Select ID,RealName from Users WHERE userLevelID = 4 and Status = 2 order by realname"
            Dim dsUsers As System.Data.DataSet = Database.ExecuteSQL(sSQL)
            ddSelectDiary.DataSource = dsUsers.Tables(0)
            ddSelectDiary.DataValueField = "ID"
            ddSelectDiary.DataTextField = "RealName"
            ddSelectDiary.DataBind()
        End If

    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Session("UserID") = ddSelectDiary.SelectedItem.Value
        Session("RealName") = ddSelectDiary.SelectedItem.Text
        Response.Redirect("\s\default.aspx")
    End Sub
End Class
