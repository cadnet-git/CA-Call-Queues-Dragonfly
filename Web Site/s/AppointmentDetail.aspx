<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Appointment" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script runat="server">

    Dim aRow As System.Data.DataRow = Nothing
    Dim sDescription As String = ""
    Dim sPostcode As String = ""
    Dim ThisCompany As CADNet.CallQueues.Common.cCompany
    Dim Appointment As CADNet.CallQueues.Common.cAppointment
    Public Property ShowHistory As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Appointment = New CADNet.CallQueues.Common.cAppointment
        Appointment.load(Request("ID"))
        ThisCompany = Appointment.TheCompany
        If ThisCompany Is Nothing = False Then
            hf.Set("CompanyID", ThisCompany.ID)
        End If
        Dim sSQL As String = "SELECT     DiaryItems.ID, DiaryItems.UserID, DiaryItems.ItemDate, DiaryItems.ItemPeriod, DiaryItems.CompanyID, DiaryItems.Status, DiaryItems.Type, "
        sSQL = sSQL & " DiaryItems.Description, DiaryItems.Postcode, DiaryItems.Conclusion, DiaryItems.FeedbackStatus, Companies.CompanyName, Companies.ContactTitle, Companies.ContactForename, "
        sSQL = sSQL & " Companies.ContactSurname, Companies.ContactPosition, Companies.Telephone, Companies.Fax, Companies.Address1, Companies.Address2, "
        sSQL = sSQL & " Companies.Town, Companies.County, Companies.Address3, Companies.PostcodeRaw, Companies.PolicyExpires, Companies.PolicyProvider, "
        sSQL = sSQL & " Companies.Notes, Companies.Email"
        sSQL = sSQL & " FROM         DiaryItems LEFT OUTER JOIN"
        sSQL = sSQL & " Companies ON DiaryItems.CompanyID = Companies.ID"

        sSQL = sSQL & " where DiaryItems.ID=" & Request("ID")

        Session("ReturnURL") = "\s\AppointmentDetail.aspx?id=" & Request("ID")
        Dim DB As New CADNet.CallQueues.Common.DataLayer

        Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)

        Try
            aRow = DS.Tables(0).Rows(0)
        Catch ex As Exception

        End Try

        If Not Appointment.TheCompany Is Nothing Then
            Select Case Appointment.Type
                Case "CA"
                    sDescription = Appointment.TheCompany.CompanyName.ToString()

                    Dim dataobj As New CADNet.CallQueues.Common.DataLayer
                    ' Dim AppHistDS As DataSet = dataobj.ExecuteSQL(String.Format("SELECT  Users.RealName, AppointmentHistory.Note, AppointmentHistory.Added, AppointmentHistory.ID FROM AppointmentHistory INNER JOIN  Users ON AppointmentHistory.UserID = Users.ID WHERE (AppointmentHistory.CompanyID = {0}) Order by Added Desc", Appointment.TheCompany.ID))

                    Dim AppHistDS As System.Data.DataSet = dataobj.ExecuteSQL(String.Format("SELECT     Users.RealName, AppointmentHistory.Note, AppointmentHistory.Added, AppointmentHistory.ID FROM AppointmentHistory INNER JOIN  Users ON AppointmentHistory.UserID = Users.ID INNER JOIN  DiaryItems ON AppointmentHistory.AppID = DiaryItems.ID WHERE     (DiaryItems.CompanyID = {0}) ORDER BY AppointmentHistory.Added DESC", Appointment.TheCompany.ID))

                    GridHistory.DataSource = AppHistDS
                    GridHistory.DataBind()

                    Dim DsDocs As System.Data.DataSet = dataobj.ExecuteSQL(String.Format("SELECT AppointmentDocuments.ID, AppointmentDocuments.DateCreated, AppointmentDocuments.Title, AppointmentDocuments.FileName, Users.RealName FROM AppointmentDocuments INNER JOIN   Users ON AppointmentDocuments.UserID = Users.ID  WHERE(CompanyID = {0}) ORDER BY DateCreated DESC", ThisCompany.ID))
                    GridDocs.DataSource = DsDocs
                    GridDocs.DataBind()

                    hf.Set("path", String.Format("{0}\Files\{1}", Server.MapPath(""), hf.Get("CompanyID")))
                    ShowHistory = True
                Case "REP"
                    sDescription = Appointment.Description.ToString()
                    sPostcode = Appointment.TheCompany.Postcode
                Case "GEN"
                    sDescription = Appointment.Description.ToString()
            End Select
        End If







    End Sub
    Protected Sub uplImage_FileUploadComplete(sender As Object, e As FileUploadCompleteEventArgs)
        e.CallbackData = SavePostedFile(e.UploadedFile)
    End Sub

    Private Const UploadDirectory As String = "Files/"

    Private Function SavePostedFile(ByVal uploadedFile As UploadedFile) As String
        If (Not uploadedFile.IsValid) And txtTitle.Text <> "" Then
            Return String.Empty
        Else
            Dim titlestring As String = hf.Get("title")
            Dim file As Array
            Dim filename As String = uploadedFile.FileName
            file = filename.Split(".")
            Dim directoryPath = hf.Get("path")

            Dim fullpath As String = ""
            If System.IO.Directory.Exists(directoryPath) = False Then
                System.IO.Directory.CreateDirectory(directoryPath)
            End If
            Dim Counter = 0
            Do While True
                If Counter = 0 Then
                    filename = String.Format("{0}.{1}", file(0), file(1))
                Else
                    filename = String.Format("{0}({1}).{2}", file(0), Counter, file(1))
                End If
                fullpath = String.Format("{0}\{1}", directoryPath, filename)

                If System.IO.File.Exists(fullpath) = False Then

                    uploadedFile.SaveAs(fullpath)
                    Exit Do
                Else
                    Counter = Counter + 1
                End If
            Loop

            'get the UserID from teh UserName
            Dim sSQL As String = String.Format("SELECT ID from Users where Username='{0}'", My.User.Name)
            Dim DB As New CADNet.CallQueues.Common.DataLayer
            Dim DS As System.Data.DataSet = DB.ExecuteSQL(sSQL)
            Dim iUserID As Integer = DS.Tables(0).Rows(0).Item("ID")

            'create the note
            Dim Params As New Microsoft.VisualBasic.Collection

            DB.CreateParameter(Params, "@UserID", System.Data.SqlDbType.Int, iUserID)
            DB.CreateParameter(Params, "@CompanyID", System.Data.SqlDbType.Int, hf.Get("CompanyID"))
            DB.CreateParameter(Params, "@Title", System.Data.SqlDbType.NVarChar, titlestring)
            DB.CreateParameter(Params, "@FileName", System.Data.SqlDbType.NVarChar, filename)
            DB.ExecuteSPNoQuery("spCreateAppDocument", Params)

            txtTitle.Text = ""
            Return "OK"
        End If
    End Function



</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <%  If aRow Is Nothing Then
    %>
            Cannot find appointment <% response.Write(Request("ID")) %>

    <%
            Response.End()
        End If


        Select Case aRow.Item("Type").toupper
            Case "CA"
                ThisCompany = New CADNet.CallQueues.Common.cCompany(aRow.Item("CompanyID"))

    %>
    <div class="AppointmentDetailContainer">

        <%
            if aRow.Item("Conclusion").ToString <> "" Then
        %>
        <div class="WarnClosed">This appointment is Closed</div>
        <br />
        <%
            end if
        %>
        <table width="100%">
            <tr>
                <td class="AppDetailTitle">When:</td>
                <td rowspan="12">&nbsp;</td>
                <td class="AppDetailData"><% response.write(cdate(arow.Item("ItemDate")).ToLongDateString) %> at <% response.write(cdate(arow.Item("ItemDate")).ToshorttimeString) %></td>
                <td rowspan="12">&nbsp;</td>
                <td class="AppDetailTitle" rowspan="8">Address:</td>
                <td class="AppDetailData" rowspan="8" width="35%" style="line-height: 1.4em;">


                    <%
                        Dim sLine As String
                        Dim sAddress As String = aRow.Item("Address1").ToString.Trim

                        If sAddress.Length > 0 Then
                            sAddress = sAddress & "<br />" & vbCrLf
                        End If

                        sLine = aRow.Item("Address2").ToString.Trim
                        If sLine.Length > 0 Then
                            sLine = sLine & "<br />" & vbCrLf
                        End If
                        sAddress = sAddress & sLine

                        sLine = aRow.Item("Address3").ToString.Trim
                        If sLine.Length > 0 Then
                            sLine = sLine & "<br />" & vbCrLf
                        End If
                        sAddress = sAddress & sLine

                        sLine = aRow.Item("Town").ToString.Trim
                        If sLine.Length > 0 Then
                            sLine = sLine & "<br />" & vbCrLf
                        End If
                        sAddress = sAddress & sLine

                        sLine = aRow.Item("County").ToString.Trim
                        If sLine.Length > 0 Then
                            sLine = sLine & "<br />" & vbCrLf
                        End If
                        sAddress = sAddress & sLine

                        sLine = aRow.Item("PostcodeRaw").ToString.Trim
                        sAddress = sAddress & sLine

                        Response.Write(sAddress.Trim)
                    %>
                                
                </td>
            </tr>


            <tr>
                <td class="AppDetailTitle ">Name:</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("ContactTitle") & " " & aRow.Item("ContactForename") & " " & aRow.Item("ContactSurname"))%></td>
            </tr>

            <% If aRow.Item("ContactPosition").ToString.Trim.Length > 0 Then%>
            <tr>
                <td class="AppDetailTitle ">Position:</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("ContactPosition").ToString.Trim)%></td>
            </tr>
            <% End If%>
            <tr>
                <td class="AppDetailTitle ">Company:</td>
                <td class="AppDetailData"><% Response.Write(aRow.Item("CompanyName").ToString.Trim)%></td>
            </tr>

            <tr>
                <td class="AppDetailTitle ">Tel:</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("telephone"))  %></td>
            </tr>
            <tr>
                <td class="AppDetailTitle ">Email:</td>
                <td class="AppDetailData"><a href="mailto:<%=aRow.Item("Email") %>"><% response.Write(aRow.Item("Email"))%></a></td>
            </tr>
            <tr>
                <td class="AppDetailTitle ">Fax:</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("Fax")) %></td>
            </tr>

            <%  If aRow.Item("PolicyProvider").ToString.Trim.ToLower <> "" Then%>
            <tr>
                <td class="AppDetailTitle ">Cover</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("PolicyProvider")) %> <% If aRow.Item("PolicyProvider").trim.tolower <> "no cover" Then%>&nbsp;until <%=ThisCompany.PolicyExpiresFormatted%><% end If %></td>
            </tr>
            <% end if  %>

            <% If aRow.Item("Notes").ToString.Trim.Length > 0 Then%>
            <tr>
                <td class="AppDetailTitle">Notes</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("Notes")) %></td>
            </tr>
            <% end if  %>
        </table>
    </div>

    <%
        Case "REP"
    %>
                Rep Appointment<br />
    <div class="AppointmentDetailContainer">

        <table width="100%">
            <tr>
                <td class="AppDetailTitle ">Date:</td>
                <td rowspan="13">&nbsp;</td>
                <td class="AppDetailData"><% response.Write(CDate(aRow.Item("ItemDate")).ToLongDateString) %></td>
            </tr>
            <tr>
                <td class="AppDetailTitle ">Time:</td>
                <td class="AppDetailData"><% response.Write(CDate(aRow.Item("ItemDate")).ToShortTimeString)%></td>
            </tr>

            <tr>
                <td class="AppDetailTitle ">Company:</td>
                <td class="AppDetailData"><% Response.Write(aRow.Item("Description").ToString)%></td>
            </tr>

            <tr>
                <td class="AppDetailTitle ">Postcode:</td>
                <td class="AppDetailData"><% Response.Write(aRow.Item("Postcode").ToString)%></td>
            </tr>
        </table>
    </div>



    <%
        Case "GEN"
    %>
                    General Appointment<br />
    <div class="AppointmentDetailContainer">
        <table width="100%">
            <tr>
                <td class="AppDetailTitle " style="height: 18px">Date:</td>
                <td rowspan="12">&nbsp;</td>
                <td class="AppDetailData" style="height: 18px"><% response.Write(CDate(aRow.Item("ItemDate")).ToLongDateString) %></td>
            </tr>
            <tr>
                <td class="AppDetailTitle ">Time:</td>
                <td class="AppDetailData"><% response.Write(CDate(aRow.Item("ItemDate")).ToShortTimeString)%></td>
            </tr>

            <tr>
                <td class="AppDetailTitle ">Description:</td>
                <td class="AppDetailData"><% response.Write(aRow.Item("Description").ToString)%></td>
            </tr>


        </table>
    </div>






    <%
        End Select
    %>
    <br />

    <div align="center">

        <%

            Dim sTemp As String = aRow.Item("Type").toupper
            Select Case sTemp
                Case "CA"

                    If aRow.Item("Status") = 2 And aRow.Item("FeedbackStatus").ToString = "" Then
        %>
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'StartFeedBack.aspx?ID=<% response.Write(Request("ID"))  %>';" value="Feedback" type="button" />
        <%
            elseif arow.Item("Status") = 3 And aRow.Item("Conclusion").ToString = "" Then
        %>
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'CloseAppointment.aspx?ID=<% response.Write(Request("ID")) %>';" type="button" value="Close" />
        <%
            end if
        %>

        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = '../email/VitalityRepEmail.aspx?ID=<% response.Write(Request("ID")) %>';" type="button" value="Print" id="Button1" />
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'AddNote.aspx?ID=<% response.Write(Request("ID"))  %>';" value="Add Note" type="button" />

        <%     
            Case "REP"
        %>

        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'MoveAppointment.aspx?ID=<% response.Write(Request("ID")) %>';" type="button" value="Move Appointment" />
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'CancelAppointment.aspx?ID=<% response.Write(Request("ID"))  %>';" type="button" value="Cancel Appointment" />
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'AddNote.aspx?ID=<% response.Write(Request("ID"))  %>';" value="Add Note" type="button" />


        <%
            Case "GEN"
        %>

        <%--   <input class="FlatButton" onclick="javascript: document.location='MoveAppointment.aspx?ID=<% response.write(request("ID")) %>';" type="button" value="Move Appointment" />
        --%>
        <input class="ui-button" style="width: 140px;" onclick="javascript: document.location = 'CancelAppointment.aspx?ID=<% response.Write(Request("ID"))  %>';" type="button" value="Cancel Appointment" />
        <%--<input class="FlatButton" onclick="javascript: document.location='AddNote.aspx?ID=<% response.write(request("ID"))  %>';" value="Add Note" type="button" />--%>
        <%
            End Select

        %>

        <input class="ui-button" style="width: 140px;" type="button" value="Back" onclick="javascript: history.go(-1);" />

    </div>


    <br />
    <% If ShowHistory  %>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">History</a></li>
            <li><a href="#tabs-2">Documents</a></li>
        </ul>
        <div id="tabs-1" style="text-align: left;">
            <dx:ASPxGridView ID="GridHistory" runat="server" AutoGenerateColumns="False"
                Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css"
                CssPostfix="DevEx">
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="Added" VisibleIndex="0"
                        Width="160px">
                        <HeaderStyle>
                            <Paddings PaddingBottom="5px" PaddingTop="5px" />
                        </HeaderStyle>
                        <CellStyle HorizontalAlign="Left">
                            <Paddings PaddingBottom="15px" PaddingTop="15px" />
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="RealName" VisibleIndex="1" Width="160px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Note" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsBehavior AllowDragDrop="False" AllowGroup="False" AllowSort="False" />

                <SettingsBehavior AllowDragDrop="False" AllowSort="False" AllowGroup="False"></SettingsBehavior>

                <SettingsPager Mode="ShowAllRecords">
                </SettingsPager>
                <Images SpriteCssFilePath="~/App_Themes/DevEx/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/DevEx/GridView/StatusBarLoading.gif">
                    </LoadingPanelOnStatusBar>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </Images>
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </ImagesFilterControl>
                <Styles CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                    <LoadingPanel ImageSpacing="5px">
                    </LoadingPanel>
                </Styles>
                <StylesEditors ButtonEditCellSpacing="0">
                    <ProgressBar Height="21px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
        </div>
        <div id="tabs-2">
            <table>
                <tr>
                    <td width="100px">
                        <dx:ASPxHiddenField ID="hf" runat="server" ClientInstanceName="hf">
                        </dx:ASPxHiddenField>
                    </td>
                    <td style="width: 274px">
                        <script type="text/javascript">
                            // <![CDATA[
                            function Uploader_OnUploadStart() {
                                btnUpload.SetEnabled(false);
                            }
                            function Uploader_OnFileUploadComplete(args) {
                                gridDocs.Refresh();
                                $(".textbox:first-child").val("");
                                btnUpload.SetEnabled(true);
                            }
                            function Uploader_OnFilesUploadComplete(args) {
                                UpdateUploadButton();
                            }
                            function UpdateUploadButton() {
                                btnUpload.SetEnabled(uploader.GetText(0) != "" & $(".textbox:first-child").val().length > 0);
                            }
                            function UploadButtonClicked() {
                                var v = $(".textbox:first-child").val();
                                if (v.length > 0) {
                                    hf.Set("title", v);
                                    uploader.Upload();
                                    $(".textbox:first-child").css("background-color", "white");
                                }
                                else {
                                    $(".textbox:first-child").css("background-color", "red");
                                }
                            }
                              // ]]>
                        </script>
                        <dx:ASPxUploadControl ID="uplImage" runat="server" ClientInstanceName="uploader"
                            OnFileUploadComplete="uplImage_FileUploadComplete" Width="270px">
                            <ClientSideEvents FileUploadComplete="function(s, e) { Uploader_OnFileUploadComplete(e); }"
                                FilesUploadComplete="function(s, e) { Uploader_OnFilesUploadComplete(e); }"
                                FileUploadStart="function(s, e) { Uploader_OnUploadStart(); }"
                                TextChanged="function(s, e) { UpdateUploadButton(); }"></ClientSideEvents>
                            <ValidationSettings MaxFileSize="4194304">
                            </ValidationSettings>
                        </dx:ASPxUploadControl>
                    </td>
                    <td width="15px"></td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server" Width="270px" class="textbox"></asp:TextBox>
                    </td>
                    <td width="15px"></td>
                    <td style="width: 100px">
                        <dx:ASPxButton ID="btnUpload" runat="server" AutoPostBack="False" Text="Upload" ClientInstanceName="btnUpload"
                            Width="100px" ClientEnabled="False">
                            <ClientSideEvents Click="function(s, e) {UploadButtonClicked() }" />
                        </dx:ASPxButton>
                    </td>
                </tr>
                <script type="text/javascript">
                    function OnGridDoubleClick() {
                        gridDocs.GetRowValues(gridDocs.GetFocusedRowIndex(), 'ID;FileName', OnGetRowValues);
                    }

                    function OnGetRowValues(values) {
                        var t = values[0];
                        var path = "Files\\" + hf.Get("CompanyID") + "\\" + values[1];
                        window.open(path);
                    }</script>
            </table>
            <dx:ASPxGridView ID="GridDocs" runat="server" AutoGenerateColumns="False"
                Width="100%" ClientInstanceName="gridDocs" KeyFieldName="ID"
                SettingsBehavior-AllowSelectSingleRowOnly="True"
                SettingsBehavior-AllowFocusedRow="True"
                SettingsBehavior-AllowSelectByRowClick="True"
                CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                <ClientSideEvents RowDblClick="function(s, e) { OnGridDoubleClick();}"></ClientSideEvents>
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="DateCreated" VisibleIndex="0"
                        Width="140px" Caption="Added ">
                        <HeaderStyle>
                            <Paddings PaddingBottom="5px" PaddingTop="5px" />
                        </HeaderStyle>
                        <CellStyle HorizontalAlign="Left" VerticalAlign="Top">
                            <Paddings PaddingBottom="15px" PaddingTop="15px" />
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="RealName" VisibleIndex="1" Width="140px"
                        Caption="By">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="2"
                        UnboundType="String">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataHyperLinkColumn FieldName="FileName" VisibleIndex="4"
                        Width="240px">
                        <DataItemTemplate>
                            <a id="clickElement" target="_blank" href="Files\<%#hf.Get("CompanyID") %>\<%#Eval("FileName").ToString()%>"><%#Eval("FileName").ToString()%></a>
                        </DataItemTemplate>
                    </dx:GridViewDataHyperLinkColumn>
                </Columns>
                <SettingsBehavior AllowDragDrop="False" AllowGroup="False" AllowSort="False" />

                <SettingsBehavior AllowDragDrop="False" AllowSort="False" AllowGroup="False"></SettingsBehavior>

                <SettingsPager Mode="ShowAllRecords">
                </SettingsPager>
                <Images SpriteCssFilePath="~/App_Themes/DevEx/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/DevEx/GridView/StatusBarLoading.gif">
                    </LoadingPanelOnStatusBar>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </Images>
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </ImagesFilterControl>
                <Styles CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                    <LoadingPanel ImageSpacing="5px">
                    </LoadingPanel>
                </Styles>
                <StylesEditors ButtonEditCellSpacing="0">
                    <ProgressBar Height="21px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
        </div>
    </div>
    <% End if %>
    <script type="text/javascript">
        $(function () {
            $("#tabs").tabs();
            $(".textbox:first-child").change(function () {
                UpdateUploadButton();
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    Appointment: <%=sDescription  %>
</asp:Content>

