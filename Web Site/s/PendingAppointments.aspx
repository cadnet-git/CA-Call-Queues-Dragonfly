<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Open Appointments" %>
<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim Params As New Microsoft.VisualBasic.Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@UserName", System.Data.SqlDbType.NVarChar, My.User.Name)

        Dim DS As System.Data.DataSet = Database.ExecuteSP("spGetPendingAppointmentForWeb", Params)
        GridPending.DataSource = DS.Tables(0)
        GridPending.DataBind()
    End Sub



    Protected Sub GridPending_HtmlRowPrepared(sender As Object, e As ASPxGridViewTableRowEventArgs)
        If (e.RowType <> GridViewRowType.Data) Then Return
        Dim Status As String = e.GetValue("StatusDescription")
        If (Status = "Approved") Then
            e.Row.BackColor = System.Drawing.Color.LightGreen
        End If
    End Sub

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Pending Appointments
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <script type="text/javascript">
       function OnGridDoubleClick() {
           gridPending.GetRowValues(gridPending.GetFocusedRowIndex(), 'ID', OnGetRowValues);
       }
 
       function OnGetRowValues(values) {
           window.location = "AppointmentDetail.aspx?ID=" + values[0];
       }
        
        </script>
        <dx:ASPxGridView ID="GridPending" runat="server" AutoGenerateColumns="False" 
            Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" 
            CssPostfix="DevEx"  ClientInstanceName="gridPending" KeyFieldName="ID" SettingsBehavior-AllowSelectSingleRowOnly="True" SettingsBehavior-AllowFocusedRow="False" SettingsBehavior-AllowSelectByRowClick="True" OnHtmlRowPrepared="GridPending_HtmlRowPrepared" >
           <ClientSideEvents RowDblClick="function(s, e) {
                   var eID = gridPending.GetRowKey(e.visibleIndex)
                   window.location = 'AppointmentDetail.aspx?ID=' +  eID;
                   }" />
           <Columns>
               <dx:GridViewDataDateColumn Caption="Appointment Date" FieldName="ItemDate" 
                    UnboundType="DateTime" VisibleIndex="0" Width="160px" ReadOnly="True">
                    <PropertiesDateEdit DisplayFormatString="dd MMMM yyyy">
                    </PropertiesDateEdit>
                    <HeaderStyle>
                    <Paddings PaddingBottom="10px" PaddingTop="10px" />
                    </HeaderStyle>
                    <CellStyle HorizontalAlign="Right">
                        <Paddings PaddingRight="10px" PaddingBottom="15px" PaddingTop="15px" />
                    </CellStyle>
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn Caption="Time" FieldName="ItemDate" 
                    UnboundType="DateTime" VisibleIndex="1" Width="60px">
                    <PropertiesDateEdit DisplayFormatString="hh:mm">
                    </PropertiesDateEdit>
                    <CellStyle HorizontalAlign="Right">
                        <Paddings PaddingRight="10px" />
                    </CellStyle>
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataHyperLinkColumn FieldName="CompanyName" VisibleIndex="2">
                 <DataItemTemplate>
                    <a id="clickElement" target="_self" href="AppointmentDetail.aspx?ID=<%#Eval("ID").ToString()%>"><%#Eval("CompanyName").ToString()%></a>
                </DataItemTemplate>
               </dx:GridViewDataHyperLinkColumn>
                <dx:GridViewDataDateColumn Caption="Next Action" FieldName="NextcallDate" 
                    UnboundType="DateTime" VisibleIndex="4" Width="160px">
                    <PropertiesDateEdit DisplayFormatString="dd MMMM yyyy H:mm">
                    </PropertiesDateEdit>
                    <CellStyle HorizontalAlign="Right">
                        <Paddings PaddingRight="10px" />
                    </CellStyle>
                </dx:GridViewDataDateColumn>
               <dx:GridViewDataTextColumn Caption="Status" FieldName="StatusDescription" Name="colStatus" VisibleIndex="3">
               </dx:GridViewDataTextColumn>
            </Columns>
            <Settings ShowFilterRow="True" />
         <SettingsBehavior AllowDragDrop="False" AllowGroup="False" AllowSort="False" />
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

<SettingsPopup>
<HeaderFilter MinHeight="140px"></HeaderFilter>
</SettingsPopup>

            <StylesEditors ButtonEditCellSpacing="0">
                <ProgressBar Height="21px">
                </ProgressBar>
            </StylesEditors>
        </dx:ASPxGridView>

<%--<%

    Dim Params As New Collection
    Dim Database As New CADNet.CallQueues.Common.DataLayer
     
    Database.CreateParameter(Params, "@Rep", Data.SqlDbType.Int, Session("UserID"))
    
    Dim DS As System.Data.DataSet = Database.ExecuteSP("spGetPendingAppointment", Params)

    If DS.Tables(0).Rows.Count > 0 Then
%>


<table border="0" width="100%" cellspacing="0">
<tr>
<th class="NoFeedbackItemTitle">Date</th>
<th class="NoFeedbackItemTitle">Company</th>
    <th class="NoFeedbackItemTitle">Location</th>
</tr>
<%
    For Each aRow As System.Data.DataRow In DS.Tables(0).Rows
        Dim sURL As String = "AppointmentDetail.aspx?ID=" & aRow.Item("ID")
        %>
        <tr onclick="javascript: document.location='<%=sURL %>';" class="Row Clickable" onmouseover="Javascript: className='RowHighlight Clickable';" onmouseout="Javascript: className='Row Clickable';">
<td class="NoFeedbackItemData"><% response.write(Format(aRow.Item("ItemDate"), "dd MMM yyyy")) %></td>
<td class="NoFeedbackItemData"><% Response.Write(aRow.Item("CompanyName").ToString)%></td>
<td class="NoFeedbackItemData"><% Response.Write(aRow.Item("Town").ToString)%></td>
</tr>
<%
Next

%> </table> <%
                
            Else
                %>
                You have no Pending Appointments
                
                <%
            End If
    %>--%>
</asp:Content>

