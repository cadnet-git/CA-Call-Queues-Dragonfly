<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Move Appointment" %>
<script runat="server">

    Dim aRow As Data.DataRow = Nothing
    Dim sDescription As String = ""
    
    Dim dTargetDate As Date = Nothing
    
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        dTargetDate = Request("TargetDate")
        
   Dim sSQL As String = "SELECT     DiaryItems.ID, DiaryItems.UserID, DiaryItems.ItemDate, DiaryItems.ItemPeriod, DiaryItems.CompanyID, DiaryItems.Status, DiaryItems.Type, "
        sSQL = sSQL & " DiaryItems.Description, DiaryItems.Postcode, Companies.CompanyName, Companies.ContactTitle, Companies.ContactForename, "
        sSQL = sSQL & " Companies.ContactSurname, Companies.ContactPosition, Companies.Telephone, Companies.Fax, Companies.Address1, Companies.Address2, "
        sSQL = sSQL & " Companies.Town, Companies.County, Companies.Address3, Companies.PostcodeRaw, Companies.PolicyExpires, Companies.PolicyProvider, "
        sSQL = sSQL & " Companies.Notes, Companies.Email"
        sSQL = sSQL & " FROM         DiaryItems LEFT OUTER JOIN"
        sSQL = sSQL & " Companies ON DiaryItems.CompanyID = Companies.ID"
        
        sSQL = sSQL & " where DiaryItems.ID=" & Request("ID")
        
        Dim DB As New CADNet.CallQueues.Common.DataLayer
         
        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
     
        Try
            aRow = DS.Tables(0).Rows(0)
        Catch ex As Exception

        End Try
     
        If Not aRow Is Nothing Then
            Select Case aRow.Item("Type")
                Case "CA"
                    sDescription = aRow.Item("CompanyName").ToString
                Case "REP"
                    sDescription = aRow.Item("Description").ToString
                Case "GEN"
                    sDescription = aRow.Item("Description").ToString
            End Select
        End If

        
    End Sub

    Protected Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim iAppointmentID As Integer = Request("ID")
        Dim dTargetDate As Date = Request("TargetDate")
        Dim iPeriod As Integer = Request("P")
        
        Dim sSQL As String = "UPDATE DiaryItems SET"
        sSQL = sSQL & " ItemDate='" & CADNet.CallQueues.Common.DateManipulation.DateToString(dTargetDate, CADNet.CallQueues.Common.DateFormats.ForSQLInsertion) & " " & dTargetDate.ToLongTimeString & "'"
        sSQL = sSQL & ", ItemPeriod=" & iPeriod
        sSQL = sSQL & " WHERE ID=" & iAppointmentID

        Dim DB As New CADNet.CallQueues.Common.DataLayer
        
        Try
            DB.ExecuteSQL(sSQL)
        Catch ex As Exception
            Response.Write("Unable to save Changes: " & ex.Message & "<BR/>")
            Response.Write(sSQL)
            Response.End()

        End Try
        
        
        Response.Redirect("default.aspx?DateToShow=" & dTargetDate.ToLongDateString & "")
    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Move Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <br />
    Move appointment '<%=sDescription %>' to <%=cadnet.CallQueues.Common.DateManipulation.DateToString(dtargetdate,CADNet.CallQueues.Common.DateFormats.ForDisplayWithFullDay) %> at <%=dTargetDate.ToShortTimeString%>
    <br />
    <br />
    <asp:Button ID="btnConfirm" runat="server" Text="Confirm Move" OnClick="btnConfirm_Click" />
</asp:Content>

