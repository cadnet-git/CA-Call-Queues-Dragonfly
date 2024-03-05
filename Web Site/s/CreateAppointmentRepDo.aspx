<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Create General Appointment" %>
<%@ Import Namespace="CADNet.CallQueues.Common" %>
<script runat="server">

    Dim dApp As Date = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        dApp = Request("TargetDate")
    End Sub

    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs)


        'getta resolve the postcode to an set of coords.
        'first a quick check:
        Dim Result As New LatLong
        Dim sResult As String = cPostcode.ValidatePostcode(txtPostcode.Text)
        If sResult.Length > 0 Then
            MsgBox(sResult)
        Else
            ' ok sofar 
            Result = cPostcode.getLatLongObject(txtPostcode.Text)
        End If


        'get the UserID from the UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer

        Dim DS As System.Data.DataSet = dB.ExecuteSQL(ssql)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")

        Dim Params As New Collection

        dB.CreateParameter(Params, "@AppointmentDate", Data.SqlDbType.DateTime, dApp)
        dB.CreateParameter(Params, "@Period", Data.SqlDbType.Int, Request("P"))
        dB.CreateParameter(Params, "@UserID", Data.SqlDbType.Int, iUserID)
        dB.CreateParameter(Params, "@Description", Data.SqlDbType.NVarChar, Me.txtDescription.Text.Trim)
        DB.CreateParameter(Params, "@Latitude", Data.SqlDbType.Float, Result.Latitude)
        DB.CreateParameter(Params, "@Longitude", Data.SqlDbType.Float, Result.Longitude)
        DB.CreateParameter(Params, "@Status", Data.SqlDbType.Int, 1)
        DB.CreateParameter(Params, "@Postcode", Data.SqlDbType.NVarChar, txtPostcode.Text)
        dB.ExecuteSPNoQuery("spAppointmentCreateREP", Params)

        Response.Redirect("default.aspx?DateToShow=" & dApp.ToLongDateString)

    End Sub



    Public Sub UserMsgBox(ByVal sMsg As String)

        Dim sb As New StringBuilder
        Dim oFormObject As System.Web.UI.Control = Nothing

        sMsg = sMsg.Replace("'", "\'")
        sMsg = sMsg.Replace(Chr(34), "\" & Chr(34))
        sMsg = sMsg.Replace(vbCrLf, "\n")

        sMsg = "<script language='javascript'>alert(""" & sMsg & """)</sc" & "ript>"

        sb = New StringBuilder

        sb.Append(sMsg)

        For Each oFormObject In Me.Controls
            If TypeOf oFormObject Is HtmlForm Then
                Exit For
            End If
        Next

        oFormObject.Controls.AddAt(oFormObject.Controls.Count, New LiteralControl(sb.ToString()))

    End Sub



</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Create Rep Appointment
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
            <td style="text-align:left;">Company:</td>
            <td style="text-align:left;"><asp:TextBox ID="txtDescription" runat="server" Width="200px" MaxLength="50"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align: left;">Postcode:</td>
            <td style="text-align: left;"><asp:TextBox ID="txtPostcode" runat="server" Width="100px" MaxLength="10"></asp:TextBox></td>
        </tr>        
        <tr>
            <td align="left"></td>
            <td style="text-align:right;"><input class="ui-button" style="width: 140px;" type="button" value="Back" onclick="javascript: history.go(-1);" />
                <asp:Button class="ui-button" style="width: 140px;" ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Create Appointment" /></td>
        </tr>
    </table>
    
    
</asp:Content>

