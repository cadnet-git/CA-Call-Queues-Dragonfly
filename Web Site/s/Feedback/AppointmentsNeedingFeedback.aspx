<%@ Page Language="VB" MasterPageFile="~/LoggedIn.master" Title="Call Queues - Appointments Needing Feedback" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Params As New Microsoft.VisualBasic.Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@Rep", System.Data.SqlDbType.Int, Session("UserID"))

        Dim DS As System.Data.DataSet = Database.ExecuteSP("spGetAwaitingFeedBackAppointmentForWeb", Params)
        GridPending.DataSource = DS.Tables(0)
        GridPending.DataBind()
    End Sub
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Appointments Needing Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <dx:ASPxGridView ID="GridPending" runat="server" AutoGenerateColumns="False" 
            Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" 
            CssPostfix="DevEx"  ClientInstanceName="gridPending" KeyFieldName="ID" SettingsBehavior-AllowSelectSingleRowOnly="True" SettingsBehavior-AllowFocusedRow="True" SettingsBehavior-AllowSelectByRowClick="True" >
           <ClientSideEvents RowDblClick="function(s, e) {
                   var eID = gridPending.GetRowKey(e.visibleIndex)
                   window.location = '/s/AppointmentDetail.aspx?ID=' +  eID;
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
                 <dx:GridViewDataHyperLinkColumn FieldName="CompanyName" VisibleIndex="2">
                 <DataItemTemplate>
                    <a id="clickElement" target="_self" href="/s/AppointmentDetail.aspx?ID=<%#Eval("ID").ToString()%>"><%#Eval("CompanyName").ToString()%></a>
                </DataItemTemplate>
               </dx:GridViewDataHyperLinkColumn>
            </Columns>
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
            <StylesEditors ButtonEditCellSpacing="0">
                <ProgressBar Height="21px">
                </ProgressBar>
            </StylesEditors>
        </dx:ASPxGridView>
</asp:Content>

