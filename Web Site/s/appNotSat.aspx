<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Untitled Page" %>

<script runat="server">
    Dim thisApp As CADNet.CallQueues.Common.cAppointment
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Session("app") Is Nothing Then
            ' no app need to flag this 
        Else
            thisApp = Session("app")
        End If
End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Appointment Not Sat
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="50px" Width="80%">
        <table border="0" cellpadding="5" cellspacing="5" style="text-align: left" width="100%">
            <tr>
                <td align="right" style="width: 260px; text-align: right">
                    Why was the appointment not sat ?:</td>
                <td colspan="2" style="width: 269px; height: 44px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Denied making appointment</asp:ListItem>
                        <asp:ListItem>Client not in</asp:ListItem>
                        <asp:ListItem>Client called out</asp:ListItem>
                        <asp:ListItem>I was running late</asp:ListItem>
                        <asp:ListItem>Incorrect details for decision maker</asp:ListItem>
                    </asp:DropDownList>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

