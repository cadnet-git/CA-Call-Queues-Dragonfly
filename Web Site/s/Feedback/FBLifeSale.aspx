<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBLifeSale.aspx.vb" Inherits="s_FBSale" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="padding-top: 30px; padding-left: 40px" >
    
    Value
    <br />
    <asp:TextBox ID="TxtValue" runat="server" Width="150px"></asp:TextBox>
    <br />
    <br />
    Payment Frequency<br />
    

    
<asp:DropDownList ID="ddPayment" runat="server" Width="150px">
    <asp:ListItem Value="Not Selected">Not Selected</asp:ListItem>
    <asp:ListItem Value="PCM">Monthly</asp:ListItem>
    <asp:ListItem Value="YEAR">Annual</asp:ListItem>
  
       
    </asp:DropDownList>
    <br />
    <br />
    Sale Date<br />
    <asp:TextBox ID="txtSoldDate" runat="server" CssClass="TradeList" 
        Width="150px"></asp:TextBox>
   
    <br />
    <br />
    Start Date<br />
    <asp:TextBox ID="txtStartDate" runat="server" CssClass="TradeList" 
        Width="150px"></asp:TextBox>
   
    <br />
   
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

