<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Create Appointment" %>

<script runat="server">

Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim sUrl As String = ""
        
        If Me.radioRep.Checked Then
            sUrl = "CreateAppointmentRep.aspx"
        ElseIf Me.radioGeneral.Checked Then
            sUrl = "CreateAppointmentGen.aspx"
        Else
            Exit Sub
        End If
        
        
        If Request("DateToShow") <> "" And Request("P") <> "" Then
            'dont need to get a date and time so can skip that step
            
            If Me.radioRep.Checked Then
                sUrl = "CreateAppointmentRepDo.aspx"
            ElseIf Me.radioGeneral.Checked Then
                sUrl = "CreateAppointmentGenDo.aspx"
            End If
            
            sUrl = sUrl & "?TargetDate=" & Me.Request("DateToShow")
            sUrl = sUrl & "&P=" & Request("P")
            
        Else
            sUrl = sUrl & "?DateToShow=" & Me.Request("DateToShow")
            sUrl = sUrl & "&P=" & Request("P")
        End If
        
        Response.Redirect(sUrl)
        
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)


    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
        Select Type of Appointment:</p>
    <p>
        <asp:RadioButton ID="radioRep" runat="server" Text="Rep (self managed appointment)" GroupName="AppType" />
    </p>
    <p>
        <asp:RadioButton ID="radioGeneral" runat="server" Text="General (holiday, time off etc...)" GroupName="AppType" />&nbsp;</p>
    <p>
        <asp:Button class="ui-button" style="width: 140px;" ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next >>" />&nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    Create Appointment</asp:Content>

