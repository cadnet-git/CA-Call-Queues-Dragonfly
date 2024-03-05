<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Create General Appointment" %>
<%@ Import Namespace="CADNet.CallQueues.Common" %>
<script runat="server">

    Dim dApp As Date = Nothing
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
               
        dApp = Request("TargetDate")
    End Sub
    
    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs)
 
        
        'get the UserID from teh UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        
        Dim DS As System.Data.DataSet = dB.ExecuteSQL(ssql)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")
        
        
        Dim Params As New Collection
        
        dB.CreateParameter(Params, "@AppointmentDate", Data.SqlDbType.DateTime, dApp)
        dB.CreateParameter(Params, "@Period", Data.SqlDbType.Int, Request("P"))
        dB.CreateParameter(Params, "@UserID", Data.SqlDbType.Int, iUserID)
        dB.CreateParameter(Params, "@Description", Data.SqlDbType.NVarChar, Me.txtDescription.Text.Trim)
        DB.CreateParameter(Params, "@Status", Data.SqlDbType.Int, 1)
        dB.ExecuteSPNoQuery("[spAppointmentCreateGEN]", Params)
        
        Response.Redirect("default.aspx?DateToShow=" & dApp.ToLongDateString)

    End Sub


</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Create General Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table align=center>
        <tr>
            <td style="text-align:left;">Date:</td>
            <td style="text-align:left;"><%=cadnet.CallQueues.Common.DateManipulation.DateToString(dApp, CADNet.CallQueues.Common.DateFormats.ForDisplayWithFullDay) %></td>
        </tr>
        <tr>
            <td style="text-align:left;">Time:</td>
            <td style="text-align:left;"><%=dApp.ToShortTimeString%></td>
        </tr>
        <tr>
            <td style="text-align:left;">Description:</td>
            <td style="text-align:left;"><asp:TextBox ID="txtDescription" runat="server" Width="200px" MaxLength="50"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left"></td>
            <td style="text-align:right;"><input class="ui-button" style="width: 140px;" type="button" value="Back" onclick="javascript: history.go(-1);" />
                <asp:Button class="ui-button" style="width: 140px;" ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Create Appointment" />

            </td>
        </tr>
    </table>


    
</asp:Content>

