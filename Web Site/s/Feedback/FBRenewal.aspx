<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBRenewal.aspx.vb" Inherits="FBRenewal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Appointment Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    Please select the existing policy provider 
    <br />
    <br />
    
    
    <asp:DropDownList ID="ddProvider" runat="server" Width="200px">
    </asp:DropDownList>
    <br />
    <br />
    and their renewal month
    <br />
    <br />
  <asp:DropDownList ID="ddRenewalDate" runat="server" Width="150px">
  
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