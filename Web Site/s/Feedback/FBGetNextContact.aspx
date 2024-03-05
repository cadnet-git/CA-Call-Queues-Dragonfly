<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBGetNextContact.aspx.vb" Inherits="s_Feedback_fbGetNextAppDate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    &nbsp;<asp:Label ID="lblTitle" runat="server" Text="."></asp:Label>
        <br />
    <br />
    
    
    <asp:TextBox ID="txtNextContact" runat="server" Width="270px"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="lblReminder" runat="server" Text="*** Have you  put this in  your diary? ***"></asp:Label>
    <br />
     <br />
    <br />
     <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="13px" 
        ForeColor="Red"></asp:Label>
     <br />
    <br />
      <asp:Button ID="BtnBack" runat="server" Text="Back" Width="120px" Height="40px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
  
       <asp:Button ID="BtnNext" runat="server" Text="Next" Width="120px" Height="40px" />

    </div>
</asp:Content>
