<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBNote.aspx.vb" Inherits="s_FBNote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    Additional note if required 
    <br />
    <br />
    <asp:TextBox ID="txtNote" runat="server" MaxLength="1000" Height="114px" 
        Width="500px" TextMode="MultiLine"></asp:TextBox>
     <br />
    <br />
    
       <asp:Button ID="BtnBack" runat="server" Text="Back" Width="120px" Height="40px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnFinish" runat="server" Text="Finish" Width="120px" Height="40px" />
&nbsp;&nbsp;
    </div>
</asp:Content>

