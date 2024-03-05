<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Call Queues Diary" %>
<%@ Import Namespace="CADNet.CallQueues.Common" %>

<script runat="server">

    Dim DS As System.Data.DataSet = Nothing
    Dim UserRow As System.Data.DataRow = Nothing
    
    Dim aDate As Date = Nothing
    Dim bHasApp5 As Boolean = True
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        If Session("UserID") Is Nothing Then
            Dim SQL As String = "Select * from Users WHERE Username='" & My.User.Name & "'"
            Dim User As System.Data.DataSet = Database.ExecuteSQL(SQL)
            Session("UserID") = User.Tables(0).Rows(0).Item("ID")
            Session("RealName") = User.Tables(0).Rows(0).Item("RealName")
        End If
 
        If Request("DateToShow") = "" Then
            aDate = Now.ToLongDateString
        Else
            aDate = Request("DateToShow")
        End If
        aDate = CADNet.CallQueues.Common.DateManipulation.GetStartOfWeek(aDate)
        
      
        
        'get the appointment schedule for the rep
        Dim App1Time As Date = Nothing
        Dim App2Time As Date = Nothing
        Dim App3Time As Date = Nothing
        Dim App4Time As Date = Nothing
        Dim App5Time As Date = Nothing
        
        'get all the appointments for the week including the date passed // My.User.Name
        Dim userid As Integer = Session("UserID")
        
        Dim sSQL As String = "Select * from Users WHERE ID='" & userid & "'"
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
        Database.CreateParameter(Params, "@UserName", Data.SqlDbType.NVarChar, UserRow.Item("UserName"))
        Database.CreateParameter(Params, "@DiaryDate", Data.SqlDbType.DateTime, aDate)

        DS = Database.ExecuteSP("spGetDiaryForWeb", Params)
    
    
        
        
    End Sub
</script>

         
         
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
     <table width="100%" class="DiaryView">
        <tr>
      
            <td class="NavCellLeft"   onclick="javascript: location.href='<%=Request.FilePath%>?DateToShow=<%=aDate.AddDays(-7).ToShortDateString%>'"
                
                rowspan="<% if bhasapp5 then response.write("7") else response.write("6")  %>">
            &lt; 
            </td>
            <% For iDay As Integer = 0 To 4%>
            
                <% Dim ThisDate As Date = aDate.AddDays(iDay)%>
                <td class="DayofWeekCell"><%=ThisDate.DayOfWeek.ToString%> </td>
            <% Next%>
            <td class="NavCellRight" rowspan="<% if bhasapp5 then response.write("7") else response.write("6")  %>"
            
            
            onclick="javascript: location.href='<%=Request.FilePath%>?DateToShow=<%=aDate.AddDays(7).ToShortDateString%>'"
             
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
                    Dim CoverRequired As String = ""

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
                    Dim sLink As String = ""
                    If UserRow.Item("AppTime" & iApp) Is DBNull.Value Then
                        sLink = ""
                    Else
                        sLink = " title=""" & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString & " - Click to Create an Appointment"" onclick=""javascript: location.href='CreateAppointment.aspx?DateToShow=" & Server.UrlEncode(ThisDate.ToLongDateString) & " " & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString & "&P=" & iApp & "'"""
                        sLink = ""
                    End If

                    If ThisDate < Now.Date Then
                        sLink = ""
                    End If

                    If Not ThisRow Is Nothing Then
                        Select Case ThisRow.Item("Type").toupper
                            Case "CA"
                                sClass = sClass & " AppointmentCA Clickable"
                                sLink = "onclick=""javascript: location.href='appointmentdetail.aspx?ID=" & ThisRow.Item("ID") & "&DateToShow=" & ThisDate.ToLongDateString & "'"""
                            Case "REP"
                                sClass = sClass & " AppointmentRep Clickable"
                                sLink = "onclick=""javascript: location.href='appointmentdetail.aspx?ID=" & ThisRow.Item("ID") & "&DateToShow=" & ThisDate.ToLongDateString & "'"""
                            Case "GEN"
                                sClass = sClass & " AppointmentGeneral clickable"
                                sLink = "onclick=""javascript: location.href='appointmentdetail.aspx?ID=" & ThisRow.Item("ID") & "&DateToShow=" & ThisDate.ToLongDateString & "'"""
                        End Select
                    End If
                    'onmouseout=""javascript: event.target.className='" & sClass & "'"" onmouseover=""javascript: event.target.className='" & sClass & " AppointmentHover';""
                    Response.Write("<TD  class=""" & sClass & """ " & sLink & "> ")

                    'show an image to ensure the minimumheight for a cell
                    'the css min-height dont work!
                    Response.Write("<img src=""pixel.gif"" border=0 height=""" & MinHeight & """ width=""0"" align=""left"">")

                    'If ThisRow Is Nothing Then
                    'no appointment
                    'Response.Write(Now.ToString("hh:mm"))
                    'Else
                    'has appointment


                    Dim sTargetDate As String = ""
                    Try
                        sTargetDate = Server.UrlEncode(ThisDate.ToLongDateString & " " & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString)
                    Catch ex As Exception
                        'Response.Write("No Times in User")
                        'Response.Write("Username=[" & My.User.Name & "]<br/>")
                        'Response.Write("AppTime" & iApp & "=[" & UserRow.Item("AppTime" & iApp) & "]<br/>")
                        'Response.End()
                    End Try


                    Dim sAppointmentTitle As String = ""
                    Dim sLocation As String = ""
                    If sTargetDate = "" Then
                        sAppointmentTitle = "User has no times"
                        sLocation = ""
                    Else
                        sAppointmentTitle = "<input class=""ui-button"" style=""width: 180px;margin:10px;"" type=""button"" value=""Create Rep Appt"" onclick=""javascript: window.location='CreateAppointmentRepDo.aspx?TargetDate=" & sTargetDate & "&P=" & iApp & "'"">"
                        sLocation = "" ' "<input class=""FlatButton"" type=""button"" value=""Create General Appt""onclick=""javascript: window.location='CreateAppointmentGenDo.aspx?TargetDate=" & Server.UrlEncode(ThisDate.ToLongDateString & " " & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString) & "&P=" & iApp & "'"" >"

                    End If


                    If ThisDate < Now.Date Then
                        sAppointmentTitle = ""
                        sLocation = ""
                    End If

                    If Not ThisRow Is Nothing Then
                        Select Case ThisRow.Item("Type").toupper
                            Case "CA"
                                sAppointmentTitle = ThisRow.Item("CompanyName").ToString
                                If sAppointmentTitle.Length < 1 Then
                                    sAppointmentTitle = "Unknown Company"
                                End If

                                If ThisRow.Item("Conclusion").ToString <> "" Then
                                    sAppointmentTitle = sAppointmentTitle & "<br/>[Closed]"
                                End If

                                sLocation = CADNet.CallQueues.Common.StringManipulation.TitleCase(ThisRow.Item("Town").ToString)
                                If sLocation = "" Then
                                    'try
                                    sLocation = CADNet.CallQueues.Common.StringManipulation.TitleCase(ThisRow.Item("Area").ToString)
                                    'catch ex as exception

                                    'end try
                                End If
                                If ThisRow.Item("CoverRequired") = 1 Then CoverRequired = "<BR><BR><b>PMI</b>"
                                If ThisRow.Item("CoverRequired") = 2 Then CoverRequired = "<BR><BR><b>LIFE</b>"
                                If ThisRow.Item("CoverRequired") = 3 Then CoverRequired = "<BR><BR><b>BOTH</b>"

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
                    End If




                    Try
                        Response.Write("<br/>" & CDate(UserRow.Item("AppTime" & iApp)).ToShortTimeString & "<br/>")
                    Catch ex As Exception

                    End Try

                    Response.Write(sAppointmentTitle)

                    If sLocation <> "" Then
                        Response.Write("<BR>" & sLocation)
                    End If

                    'End If
                    Response.Write(CoverRequired)
                    Response.Write("<BR><img src=""pixel.gif"" border=0 height=""0"" width=""" & MinWidth & """ align=""top"">")



                    Response.Write("</TD>" & vbCrLf)
                Next

                Response.Write("</tr>")

            Next %>
     </table>
  
     
     

</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <div class="PageHeader">Your Diary for <%=CADNet.CallQueues.Common.DateManipulation.DateToString(aDate, DateFormats.ForDisplayWithFullDay)%> - <%=CADNet.CallQueues.Common.DateManipulation.DateToString(aDate.AddDays(4), DateFormats.ForDisplayWithFullDay)%></div></asp:Content>

