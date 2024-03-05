<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<%

    Session.Abandon
    Response.Redirect("default.aspx")
    
    %>
</asp:Content>

