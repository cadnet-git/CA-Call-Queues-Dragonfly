<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Add Note" %>


<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<script runat="server">

    Protected Sub btnAddNote_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtNote.Text.Trim.Length < 6 Then
            UserMsgBox("Please enter a note")
            Exit Sub
        End If

        If Me.NextDate.Text.Trim = "" Then
            UserMsgBox("Please enter a date for when this note is due to be completed")
            Exit Sub
        End If

        If Me.ddTime.Text.Trim = "" Then
            UserMsgBox("Please enter a Time for when this note is due to be completed")
            Exit Sub
        End If
        'get the UserID from teh UserName
        Dim sSQL As String = "SELECT ID from Users where Username='" & My.User.Name & "'"
        Dim DB As New CADNet.CallQueues.Common.DataLayer
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
        Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")

        Dim NextActionDate As String = NextDate.Text & " " & ddTime.Text

        'create the note
        Dim Params As New Microsoft.VisualBasic.Collection

        DB.CreateParameter(Params, "@UserID", System.Data.SqlDbType.Int, iUserID)
        DB.CreateParameter(Params, "@AppID", System.Data.SqlDbType.Int, Request("ID"))
        DB.CreateParameter(Params, "@Note", System.Data.SqlDbType.NVarChar, Me.txtNote.Text)
        DB.CreateParameter(Params, "@NextCall", System.Data.SqlDbType.DateTime, NextActionDate)
        DB.ExecuteSPNoQuery("spCreateAppUserNote", Params)

        Response.Redirect("appointmentdetail.aspx?ID=" & Request("ID"))


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

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    Add Note
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />

    <table style="width: 100%" align="left">
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px">&nbsp;</td>
            <td style="text-align: left">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px; text-align: left;">Note</td>
            <td style="text-align: left">

                <asp:TextBox ID="txtNote" runat="server" MaxLength="100" Width="443px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px; text-align: left;">&nbsp;</td>
            <td style="text-align: left">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px; text-align: left;">Next Action Date</td>
            <td style="text-align: left">
                <table>
                    <tr>
                        <td>
                            <dx:ASPxDateEdit ID="NextDate" runat="server"
                                DisplayFormatString="dd MMMM yyyy">
                            </dx:ASPxDateEdit>

                        </td>
                        <td style="padding-left:25px;">
                            <asp:DropDownList ID="ddTime" runat="server">
                                <asp:ListItem Value=""></asp:ListItem>
                                <asp:ListItem>8:00</asp:ListItem>
                                <asp:ListItem>8:15</asp:ListItem>
                                <asp:ListItem>8:30</asp:ListItem>
                                <asp:ListItem>8:45</asp:ListItem>
                                <asp:ListItem>9:00</asp:ListItem>
                                <asp:ListItem>9:15</asp:ListItem>
                                <asp:ListItem>9:30</asp:ListItem>
                                <asp:ListItem>9:45</asp:ListItem>
                                <asp:ListItem>10:00</asp:ListItem>
                                <asp:ListItem>10:15</asp:ListItem>
                                <asp:ListItem>10:30</asp:ListItem>
                                <asp:ListItem>10:45</asp:ListItem>
                                <asp:ListItem>11:00</asp:ListItem>
                                <asp:ListItem>11:15</asp:ListItem>
                                <asp:ListItem>11:30</asp:ListItem>
                                <asp:ListItem>11:45</asp:ListItem>
                                <asp:ListItem>12:00</asp:ListItem>
                                <asp:ListItem>12:15</asp:ListItem>
                                <asp:ListItem>12:30</asp:ListItem>
                                <asp:ListItem>12:45</asp:ListItem>
                                <asp:ListItem>13:00</asp:ListItem>
                                <asp:ListItem>13:15</asp:ListItem>
                                <asp:ListItem>13:30</asp:ListItem>
                                <asp:ListItem>13:45</asp:ListItem>
                                <asp:ListItem>14:00</asp:ListItem>
                                <asp:ListItem>14:15</asp:ListItem>
                                <asp:ListItem>14:30</asp:ListItem>
                                <asp:ListItem>14:45</asp:ListItem>
                                <asp:ListItem>15:00</asp:ListItem>
                                <asp:ListItem>15:15</asp:ListItem>
                                <asp:ListItem>15:30</asp:ListItem>
                                <asp:ListItem>15:45</asp:ListItem>
                                <asp:ListItem>16:00</asp:ListItem>
                                <asp:ListItem>16:15</asp:ListItem>
                                <asp:ListItem>16:30</asp:ListItem>
                                <asp:ListItem>16:45</asp:ListItem>
                                <asp:ListItem>17:00</asp:ListItem>
                                <asp:ListItem>17:15</asp:ListItem>
                                <asp:ListItem>17:30</asp:ListItem>
                                <asp:ListItem>17:45</asp:ListItem>
                                <asp:ListItem>18:00</asp:ListItem>
                            </asp:DropDownList>


                        </td>
                         <td style="padding-left:25px;">
                             &nbsp;</td>
                    </tr>
                </table>




            </td>
            <td width="50px">&nbsp;</td>
        </tr>
        <tr>
            <td width="50px"></td>
            <td style="width: 200px">&nbsp;</td>
            <td style="text-align: left"></td>
            <td width="50px"></td>
        </tr>
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px">&nbsp;</td>
            <td style="text-align: left">
                <asp:Button ID="btnAddNote" runat="server" OnClick="btnAddNote_Click" Text="Add Note" />
            </td>
            <td width="50px">&nbsp;</td>
        </tr>
        <tr>
            <td width="50px">&nbsp;</td>
            <td style="width: 200px">&nbsp;</td>
            <td>&nbsp;</td>
            <td width="50px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

