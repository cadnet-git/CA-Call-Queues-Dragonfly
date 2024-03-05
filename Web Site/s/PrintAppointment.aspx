<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Print Appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Print Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Please wait while your document is created<br /><img src="../Images/wait.gif" />

<%
    
    Dim sFilename As String = System.IO.Path.GetDirectoryName(Request.PhysicalPath)
    sFilename = sFilename & "\PDF\" & My.User.Name & ".pdf"
    
    Dim iCount As Integer = 0
    Do Until System.IO.File.Exists(sFilename) = False Or iCount > 500
        iCount += 1
        Try
            System.IO.File.Delete(sFilename)
        Catch ex As Exception
            Threading.Thread.Sleep(100)
        End Try
    Loop
    
    If System.IO.File.Exists(sFilename) Then
        Response.Write("Unable to delete Temporary file: " & sFilename)
        Response.End()
    End If
    
    Dim anAppt As New CADNet.CallQueues.Common.cAppointment
    anAppt.load(Request("ID"))
    
    Try
        anAppt.Print(CADNet.CallQueues.Common.cAppointment.Styles.Web, sFilename)
    Catch ex As Exception
            %>
            <%=ex.message %>

            <%
                Response.End()
    End Try


Dim sURL As String = Replace(sFilename, Server.MapPath(Request.ApplicationPath), Request.ApplicationPath)
sURL = sURL.Replace("\", "/")

            Response.Redirect(sURL & "?ID=" & anAppt.ID)

    %>
</asp:Content>

