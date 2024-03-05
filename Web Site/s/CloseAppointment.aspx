<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Close Appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)

        If Me.txtFeedback.Text = "" Then
            'UserMsgBox("Please enter a reason why")
            Exit Sub
        End If


        'updated to SP
        'Dim sSQL As String = "update DiaryItems set"
        'sSQL = sSQL & " ConclusionDate='" & Now.ToLongDateString & "'"
        'sSQL = sSQL & ", Conclusion='" & Me.txtFeedback.Text & "'"
        'sSQL = sSQL & " WHERE ID=" & Request("ID")



        Dim DB As New CADNet.CallQueues.Common.DataLayer
        Dim ConclusionParams As New Collection
        DB.CreateParameter(ConclusionParams, "@ID", Data.SqlDbType.Int, Request("ID"))
        DB.CreateParameter(ConclusionParams, "@Feedback", Data.SqlDbType.NVarChar, Me.txtFeedback.Text)
        DB.ExecuteSPNoQuery("spWebAppointmentClose", ConclusionParams)

        'get the UserID from the UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"

        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")

        'add a note to the appointment
        Dim NoteParams As New Collection
        DB.CreateParameter(NoteParams, "@UserID", Data.SqlDbType.Int, iUserID)
        DB.CreateParameter(NoteParams, "@AppID", Data.SqlDbType.Int, Request("ID"))
        DB.CreateParameter(NoteParams, "@Note", Data.SqlDbType.NVarChar, "Closed: " & Me.txtFeedback.Text)

        DB.ExecuteSPNoQuery("spCreateAppNote", NoteParams)

        Server.Transfer("default.aspx")

    End Sub



</script>


    Close Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
Please enter a reason why the appointment should be closed:<br />
    <asp:TextBox ID="txtFeedback" runat="server" MaxLength="255" Width="250px"></asp:TextBox><br />
    <asp:Button class="ui-button" style="width: 140px;" ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
</asp:Content>

