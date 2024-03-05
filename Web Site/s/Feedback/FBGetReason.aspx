<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBGetReason.aspx.vb" Inherits="s_FBGetReason" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Appointment Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    <br />
    <br />
    Please select reason for not sitting appointment
    <br />
    <br />
<asp:DropDownList ID="ddReason" runat="server" Width="280px">
    <asp:ListItem Value="0">Not Selected</asp:ListItem>
    <asp:ListItem Value="1">Denied making appointment</asp:ListItem>
    <asp:ListItem Value="2">Not in</asp:ListItem>
    <asp:ListItem Value="3">Called Out</asp:ListItem>
    <asp:ListItem Value="4">Rep Running Late</asp:ListItem>
    <asp:ListItem Value="5">Incorrect details for decision maker</asp:ListItem>
    <asp:ListItem Value="6">Unable to see me</asp:ListItem>
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
