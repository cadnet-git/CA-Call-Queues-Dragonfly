<%@ Page Title="" Language="VB" MasterPageFile="~/LoggedIn.master" AutoEventWireup="false" CodeFile="FBAppSat.aspx.vb" Inherits="s_FBStage1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <p>
        Appointment Feedback</p>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 40px; padding-left: 50px" >
    <br />
    <br />
    Was the appointment held? 
    <br />
    <br />
    <asp:Button ID="BtnYes" runat="server" Text="Yes" Width="120px" Height="40px" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="BtnNo" runat="server" Text="No" Width="120px" Height="40px" />
    </div>
</asp:Content>

