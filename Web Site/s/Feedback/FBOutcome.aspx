<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBOutcome.aspx.vb" Inherits="s_FBOutcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
        <br />
        Please select an outcome of <strong>PMI </strong>
    <br />
    <br />
<asp:DropDownList ID="ddOutcome" runat="server">
    <asp:ListItem Value="0">Not Selected</asp:ListItem>
    <asp:ListItem Value="10">PMI Not Presented</asp:ListItem>
    <asp:ListItem Value="1">Agreed Renewal</asp:ListItem>
    <asp:ListItem Value="3">Too Expensive</asp:ListItem>
    <asp:ListItem Value="2">Existing Medical</asp:ListItem>
    <asp:ListItem Value="5">Quoted and 2nd appointment booked</asp:ListItem>
    <asp:ListItem Value="4">Quote done trying to book 2nd appointment</asp:ListItem>
    <asp:ListItem Value="9">Quoted and client received in meeting</asp:ListItem>
    <asp:ListItem Value="6">Waiting for info to quote</asp:ListItem>
    <asp:ListItem Value="8">Sale</asp:ListItem>
    </asp:DropDownList>
     <br />
    <br />
    <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="13px" 
        ForeColor="Red"></asp:Label>
    <br />
    <br />
       <asp:Button ID="BtnBack" runat="server" Text="Back" Width="120px" Height="40px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnNext" runat="server" Text="Next" Width="120px" Height="40px" />
    </div>
</asp:Content>

