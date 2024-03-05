<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBInvolvedInProduct.aspx.vb" Inherits="s_FBStage2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Appointment Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 30px; padding-left: 40px" >
    <br />
    <br />
        Was the the person involved in the buying of the products? 
    <br />
    <br />
       <asp:Button ID="BtnYes" runat="server" Text="Yes" Width="120px" Height="40px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnNo" runat="server" Text="No" Width="120px" Height="40px" />
    </div>
</asp:Content>

