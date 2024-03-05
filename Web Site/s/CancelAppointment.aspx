<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Cancel Appointment" %>

<script runat="server">

    
    Dim aRow As System.Data.DataRow = Nothing
    
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

End Sub

    Protected Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs)
        
        If Me.txtReason.Text.Length < 10 Then
            
            UserMsgBox("Please enter a reason")
            
            Exit Sub
            
        End If
        
        'get the UserID from the UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")
        
        
        'add an appointment note
        Dim Params As New Collection

        DB.CreateParameter(Params, "@UserID", Data.SqlDbType.Int, iUserID)
        DB.CreateParameter(Params, "@AppID", Data.SqlDbType.Int, Request("ID"))
        DB.CreateParameter(Params, "@Note", Data.SqlDbType.NVarChar, "Cancelled: " & Me.txtReason.Text)
        
        DB.ExecuteSPNoQuery("spCreateAppNote", Params)
        
        
        'update the DiaryItem
        sSQL = "Update DiaryItems SET"
        sSQL = sSQL & " Status=0"
        ssql = ssql & " WHERE"
        sSQL = sSQL & " ID=" & Request("ID")
        DB.ExecuteSQL(sSQL)
        
        Response.Redirect("default.aspx?DateToShow=" & CDate(Me.ItemDate.Value).ToLongDateString)
        
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

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    
    <%
        Dim sSQL As String = "SELECT     DiaryItems.ID, DiaryItems.UserID, DiaryItems.ItemDate, DiaryItems.ItemPeriod, DiaryItems.CompanyID, DiaryItems.Status, DiaryItems.Type, "
        sSQL = sSQL & " DiaryItems.Description, DiaryItems.Postcode, Companies.CompanyName, Companies.ContactTitle, Companies.ContactForename, "
        sSQL = sSQL & " Companies.ContactSurname, Companies.ContactPosition, Companies.Telephone, Companies.Fax, Companies.Address1, Companies.Address2, "
        sSQL = sSQL & " Companies.Town, Companies.County, Companies.Address3, Companies.PostcodeRaw, Companies.PolicyExpires, Companies.PolicyProvider, "
        sSQL = sSQL & " Companies.Notes, Companies.Email"
        sSQL = sSQL & " FROM         DiaryItems LEFT OUTER JOIN"
        sSQL = sSQL & " Companies ON DiaryItems.CompanyID = Companies.ID"
        
        sSQL = sSQL & " where DiaryItems.ID=" & Request("ID")
        
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        
        If DS.Tables(0).Rows.Count < 1 Then
            %>
            Cannot find appointment <%=request("ID") %>
            
            <%
                Response.End()
            End If
            
            
            
            
            aRow = DS.Tables(0).Rows(0)
            Me.ItemDate.Value = aRow.Item("ItemDate")
            
            
            Select Case aRow.Item("Type").toupper
                Case "REP"
                %>
                <br />
                <table align=center>
                    <tr>
                        <td align="centre" colspan="2">Cancel Rep appointment<br /></td>
                    </tr>
                    <tr>
                        <td style="text-align:left;">Description:</td>
                        <td style="text-align: left;"><% response.write(aRow.Item("Description"))%></td>
                    </tr>
                    <tr>
                        <td style="text-align: left;">Date:</td>
                        <td style="text-align: left;"><% response.write(cdate(arow.Item("ItemDate")).ToLongDateString) %>  at <% response.write(CDate(aRow.Item("ItemDate")).ToShortTimeString)%></td>
                    </tr>                                       
                </table>
                <br />
  
    
   
                <%
                Case "GEN"
                    %>
                    
                                    <br />
                <table align=center>
                    <tr>
                        <td align="centre" colspan="2">Cancel General appointment<br /></td>
                    </tr>
                    <tr>
                        <td style="text-align:left;">Description:</td>
                        <td style="text-align: left;"><% response.write(aRow.Item("Description"))%></td>
                    </tr>
                    <tr>
                        <td style="text-align: left;">Date:</td>
                        <td style="text-align: left;"><% response.write(cdate(arow.Item("ItemDate")).ToLongDateString) %>  at <% response.write(CDate(aRow.Item("ItemDate")).ToShortTimeString)%></td>
                    </tr>                                       
                </table>
                <br />
                
             
                    <% End Select%>
    <br />
    <br />
    Reason for cancellation:<br /><asp:TextBox ID="txtReason" runat="server"
        TextMode="MultiLine" Width="272px" MaxLength="89"></asp:TextBox>
    <br />
  
<asp:hiddenfield id="ItemDate" runat="server"></asp:hiddenfield>
    <asp:Button class="ui-button" style="width: 140px;" ID="btnConfirm" runat="server" Text="Confirm Cancellation" OnClick="btnConfirm_Click" /><br />
        
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    Cancel Appointment</asp:Content>

