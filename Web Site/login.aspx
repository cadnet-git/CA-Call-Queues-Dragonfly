<%@ Page Language="VB" MasterPageFile="~/NotLoggedIn.master" Title="Call Queues - Please Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div align="center"><asp:Login ID="Login1" runat="server" DestinationPageUrl="~/s/Default.aspx">
    </asp:Login></div>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    Welcome - Please Login</asp:Content>

