<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="SelectDiary.aspx.vb" Inherits="s_Admin_SelectDiary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="padding-top: 30px; padding-left: 40px">
    <br />
    <asp:DropDownList ID="ddSelectDiary" runat="server">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Change" />
</p>
<p>
</p>
</asp:Content>

