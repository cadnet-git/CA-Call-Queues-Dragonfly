<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Add Note" %>

<script runat="server">

Protected Sub btnAddNote_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.txtNote.Text.Trim.Length < 1 Then
            UserMsgBox("Please enter a note")
            Exit Sub
        End If
        
        
        'get the UserID from teh UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        
        
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        
        
        
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")
        
        
        'create the note
        Dim Params As New Collection

        DB.CreateParameter(Params, "@UserID", Data.SqlDbType.Int, iUserID)
        DB.CreateParameter(Params, "@AppID", Data.SqlDbType.Int, Request("ID"))
        DB.CreateParameter(Params, "@Note", Data.SqlDbType.NVarChar, Me.txtNote.Text)
        
        DB.ExecuteSPNoQuery("spCreateAppNote", Params)
        
        Response.Redirect("appointmentdetail.aspx?ID=" & Request("ID"))
   
    End Sub
    
    Public Sub UserMsgBox(ByVal sMsg As String)

        Dim sb As New StringBuilder
        Dim oFormObject As System.Web.UI.Control = Nothing

        sMsg = sMsg.Replace("'", "\'")
        sMsg = sMsg.Replace(Chr(34), "\" & Chr(34))
        sMsg = sMsg.Replace(vbCrLf, "\n")
       
        sMsg = "<script language='javascript'>alert(""" & sMsg & """)</sc" & "ript>"

        sb = New StringBuilder

        sb.Append(sMsg)

        For Each oFormObject In Me.Controls
            If TypeOf oFormObject Is HtmlForm Then
                Exit For
            End If
        Next

        oFormObject.Controls.AddAt(oFormObject.Controls.Count, New LiteralControl(sb.ToString()))

    End Sub
    
    
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Add Note
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:TextBox ID="txtNote" runat="server" MaxLength="100" Width="300px"></asp:TextBox>
    <asp:Button ID="btnAddNote" runat="server" OnClick="btnAddNote_Click" Text="Add Note" />
</asp:Content>

