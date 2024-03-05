<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBGetContact.aspx.vb" Inherits="FBGetContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    Enter correct contacts name&nbsp; 
        <br />
    <br />
    
    
    <asp:TextBox ID="txtName" runat="server" Width="270px"></asp:TextBox>
    <br />
    <br />
    and their position
    <br />
    <br />
    <asp:TextBox ID="txtPosition" runat="server" Width="270px"></asp:TextBox>
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

