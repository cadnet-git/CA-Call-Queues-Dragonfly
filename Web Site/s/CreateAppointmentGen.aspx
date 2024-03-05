<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Create Appointment" %>
<%@ Import Namespace="CADNet.CallQueues.Common" %>

<script runat="server">

    Dim DS As System.Data.DataSet = Nothing
    Dim UserRow As System.Data.DataRow = Nothing
    
    Dim aDate As Date = Nothing
    Dim bHasApp5 As Boolean = True
    
    Dim AppointmentID As Integer = 0

    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

       
        AppointmentID = Request("ID")
        
        If Request("DateToShow") = "" Then
            aDate = Now.ToLongDateString
        Else
            try
                aDate = Request("DateToShow")
            catch ex as Exception

            end try
        End If
        aDate = CADNet.CallQueues.Common.DateManipulation.GetStartOfWeek(aDate)
        
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        
        
        'get the appointment schedule for the rep
        Dim App1Time As Date = Nothing
        Dim App2Time As Date = Nothing
        Dim App3Time As Date = Nothing
        Dim App4Time As Date = Nothing
        Dim App5Time As Date = Nothing
        
        'get all the appointments for the week including the date passed
        Dim sSQL As String = "Select * from Users WHERE Username='" & My.User.Name & "'"
        Dim dsUser As System.Data.DataSet = Database.ExecuteSQL(sSQL)
        
        UserRow = dsUser.Tables(0).Rows(0)
        
        If UserRow.Item("HasApp5") = 1 Then
            bHasApp5 = True
        Else
            bHasApp5 = False
        End If
        
        If Not UserRow.Item("AppTime1") Is DBNull.Value Then
            App1Time = UserRow.Item("AppTime1")
        End If
        
        If Not UserRow.Item("AppTime2") Is DBNull.Value Then
            App2Time = UserRow.Item("AppTime2")
        End If
        
        If Not UserRow.Item("AppTime3") Is DBNull.Value Then
            App3Time = UserRow.Item("AppTime3")
        End If
        
        If Not UserRow.Item("AppTime4") Is DBNull.Value Then
            App4Time = UserRow.Item("AppTime4")
        End If
        
        If Not UserRow.Item("AppTime5") Is DBNull.Value Then
            App5Time = UserRow.Item("AppTime5")
        End If

        
        'get the diary data
        Dim Params As New Collection
        Database.CreateParameter(Params, "@UserName", Data.SqlDbType.NVarChar, My.User.Name)
        Database.CreateParameter(Params, "@DiaryDate", Data.SqlDbType.DateTime, aDate)
    
        
        'check if the SP returns for the week or just a day.
        
        ds = Database.ExecuteSP("spGetDiaryForDate", Params)
    
    
        
        
    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Create General Appointment
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


Select the date and time of the appointment:
<table width="100%" class="DiaryView">
        <tr>
      
            <td class="NavCellLeft"  onclick="javascript: location.href='<%=Request.FilePath%>?ID=<%=AppointmentID %>&DateToShow=<%=aDate.AddDays(-7).ToShortDateString%>'"
                
                rowspan="<% if bhasapp5 then response.write("7") else response.write("6")  %>">
            &lt; 
            </td>
            <% For iDay As Integer = 0 To 4%>
            
                <% Dim ThisDate As Date = aDate.AddDays(iDay)%>
                <td class="DayofWeekCell"><%=ThisDate.DayOfWeek.ToString%> </td>
            <% Next%>
            <td class="NavCellRight" rowspan="<% if bhasapp5 then response.write("7") else response.write("6")  %>"
            
            
            onclick="javascript: location.href='<%=Request.FilePath%>?ID=<%=AppointmentID %>&DateToShow=<%=aDate.AddDays(7).ToShortDateString%>'"
             
            >&gt;</td>
        </tr>
         <tr>
             <% For iDay As Integer = 0 To 4
              Dim ThisDate As Date = aDate.AddDays(iDay)
                     Response.Write("<td Class=""DateCell"">" & ThisDate.ToString("d MMM yy") & "</td>")
             Next%>
         </tr>        
      
        <% 
            Dim i As Integer = 4
            If bHasApp5 Then
                i = 5
            End If
            
            Dim MinHeight As Integer = 100
            Dim MinWidth As Integer = 130
            
            For iApp As Integer = 1 To i
                'write out the appointment rows
                Response.Write("<tr>")

                For iDay As Integer = 0 To 4
                    
                    Dim ThisDate As Date = aDate.AddDays(iDay)
                    
                    
                    'see if there is a database record that matches the date and period
                    Dim ThisRow As Data.DataRow = Nothing
                    For Each aRow As Data.DataRow In DS.Tables(0).Rows
                        Dim ItemDate As Date = aRow.Item("ItemDate")
                        If ItemDate.ToShortDateString = ThisDate.ToShortDateString Then
                            If aRow.Item("ItemPeriod") = iApp Then
                                ThisRow = aRow
                                Exit For
                            End If
                        End If
                    Next
                    
                    Dim sClass As String = "AppointmentCell"
                    Dim sLink As String = "onclick=""javascript: location.href='CreateAppointmentGenDo.aspx?Description=" & Request("Description") & "&TargetDate=" & ThisDate.ToShortDateString & " " & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString & "&P=" & iApp & "'"""
                    If Not ThisRow Is Nothing Then
                        Select Case ThisRow.Item("Type").toupper
                            Case "CA"
                                sClass = sClass & " AppointmentCA"
                                sLink = ""
                            Case "REP"
                                sClass = sClass & " AppointmentRep"
                                sLink = ""
                            Case "GEN"
                                sClass = sClass & " AppointmentGeneral"
                                sLink = ""
                        End Select
                    End If

                    Response.Write("<TD class=""" & sClass & """ " & sLink & ">")
                    
                    'show an image ot ensure the minimumheight for a cell
                    'the css min-height dont work!
                    Response.Write("<img src=""pixel.gif"" border=0 height=""" & MinHeight & """ width=""0"" align=""left"">")
                    
   
                    
                    If ThisRow Is Nothing Then
                        'no appointment
                        'Response.Write(Now.ToString("hh:mm"))
                    Else
                        'has appointment
                        
                        Dim sAppointmentTitle As String = ""
                        Dim sLocation As String = ""
                        
                        Select Case ThisRow.Item("Type").toupper
                            Case "CA"
                                sAppointmentTitle = ThisRow.Item("CompanyName").ToString
                                If sAppointmentTitle.Length < 1 Then
                                    sAppointmentTitle = "Unknown Company"
                                End If
                                
                                sLocation = CADNet.CallQueues.Common.StringManipulation.TitleCase(ThisRow.Item("Town").ToString)
                                If sLocation = "" Then
                                    sLocation = CADNet.CallQueues.Common.StringManipulation.TitleCase(ThisRow.Item("Area").ToString)
                                End If
                            Case "REP"
                                sAppointmentTitle = ThisRow.Item("Description").ToString
                                If sAppointmentTitle.Length < 1 Then
                                    sAppointmentTitle = "Unknown Company"
                                End If
                                
                                sLocation = ""
                            Case "GEN"
                                sAppointmentTitle = ThisRow.Item("Description").ToString
                                If sAppointmentTitle.Length < 1 Then
                                    sAppointmentTitle = "Appointment"
                                End If
                                
                                sLocation = ""
                        End Select
                        
                        Response.Write(sAppointmentTitle)
                        
                        If sLocation <> "" Then
                            Response.Write("<BR>" & sLocation)
                        End If
                        
                    End If
                    
                    Response.Write("<BR><img src=""pixel.gif"" border=0 height=""0"" width=""" & MinWidth & """ align=""top"">")
                    
                    
                    Response.Write("</TD>" & vbCrLf)
                Next

                Response.Write("</tr>")
        
         Next %>
     </table>
     
     
</asp:Content>

