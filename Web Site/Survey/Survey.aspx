<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Survey.aspx.vb" Inherits="Survey_Survey" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%  Response.Expires = -1%>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Appointment Confirmation</title>
    <style type="text/css">
        #IMG1 {
            height: 104px;
            width: 181px;
        }
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            height: 27px;
        }
        </style>
   
</head>
<body style="background-color:Silver;font-family:Arial,sans-serif; font-size:10pt;">
    <form id="form1" runat="server" >
   
    
        <table style="width: 700px; background-color: white; text-align: left; font-family:Arial,sans-serif;font-size:10.0pt;padding-left:20px;padding-right:20px;" border="0" cellpadding="3" cellspacing="2">
           
              <tr>
                <td align="center" colspan="4" >
                    <img alt="Securehealth Logo" src="../Email/vitality-logo.gif" />
                    <br />
                </td>
             </tr>
             <tr>
                <td colspan="4" ></td>
            </tr>
             <tr>
                <td colspan="4" align="center" >&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style2" ></td>
                <td class="auto-style2" >
                    <span style="font-size:12.0pt; color: #F41C5E;"><strong>Customer Satisfaction Survey</strong></span></td>
                <td colspan="2" class="auto-style2" ></td>
            </tr>
             <tr>
                <td colspan="4" align="center" >&nbsp;</td>
            </tr>
            <tr><td>&nbsp;</td>
               <td>Was our representative punctual?</td>
               <td>
                   <asp:DropDownList ID="ddPunctual" runat="server" Width="130px">
                       <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                   </asp:DropDownList>
                </td>
               <td>&nbsp;</td>
               
            </tr>
           
            <tr> <td>
                   &nbsp;</td>
               <td>
                  Was our representative professional?</td>
               <td>
                   <asp:DropDownList ID="ddProfessional" runat="server" Width="130px">
                       <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                   </asp:DropDownList>
                </td>
               <td>
                   &nbsp;</td>
              
            </tr>
           
            <tr> <td >&nbsp;</td>
                <td >Did our representative ring to confirm the appointment beforehand?</td>
                <td >
                    <asp:DropDownList ID="ddCalledBefore" runat="server" Width="130px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td >&nbsp;</td>
               
            </tr>
            <tr> 
                <td>&nbsp;</td>
                <td>Did the representative quote whilst in the appointment?</td>
                <td>
                    <asp:DropDownList ID="ddQuotedInMeeting" runat="server" Width="130px" onchange="quotedInMeeting()">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
               
            </tr>
            <tr id="HowQuoteDelivered"> 
                <td >&nbsp;</td>
                <td >How was the quote delivered?</td>
                <td >
                    <asp:DropDownList ID="ddQuoteMethod" runat="server" Width="130px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="Verbally in Meeting">Verbally in Meeting</asp:ListItem>
                        <asp:ListItem>Email in Meeting</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td >&nbsp;</td>
               
            </tr>
            <tr id="QuoteInfo"> 
                <td >&nbsp;</td>
                <td >Have arrangements been made to provide a quote at a later date?&nbsp;</td>
                <td >
                    <asp:DropDownList ID="ddQuoteInfo" runat="server" Width="130px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList></td>
                <td >&nbsp;</td>
               
            </tr>
            <tr> 
                <td >&nbsp;</td>
                <td >&nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >&nbsp;</td>
               
            </tr>
            <tr> 
                <td >&nbsp;</td>
                <td >Any additional comments you may have</td>
                <td >
                    &nbsp;</td>
                <td >&nbsp;</td>
               
            </tr>
            <tr> 
                <td >&nbsp;</td>
                <td colspan="2" >
                    <asp:TextBox ID="txtComments" runat="server" MaxLength="500" Rows="5" TextMode="MultiLine" Width="590px"></asp:TextBox>
                </td>
                <td >&nbsp;</td>
               
            </tr>
            <tr> 
                <td class="auto-style1" ></td>
                <td class="auto-style1" ></td>
                <td class="auto-style1" >
                    </td>
                <td class="auto-style1" ></td>
               
            </tr>
            <tr> 
                <td >&nbsp;</td>
                <td style="padding-left: 30px" >&nbsp;</td>
                <td >
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/sendFeddback.png" />
                </td>
                <td >&nbsp;</td>
               
            </tr>
            <tr>
                <td colspan="4" >
                    </td>
            </tr>
            
                   <tr>
                <td  colspan="4">
                    &nbsp;</td>
            </tr>       <tr>
                <td style="font-family:Arial,sans-serif;font-size:10px" colspan="4" align="center">
                    Office Address:  Suite N/1/17,  Nortex Business Centre, 105 Chorley Old Road, Bolton, BL1 3AG
                        <br />
                    Telephone 01204 845422 or  Fax: 01204 437163</td>
            </tr>
              
                    <tr>
                <td colspan="4" align="center" >
                    &nbsp;</td>
            </tr>
                    <tr>
                        <td style="height: 16px" colspan="4">
                        </td>
            </tr>
        
        </table>
    </form>

</body>
     <script type="text/javascript">
         function quotedInMeeting() {
             var val = document.getElementById("ddQuotedInMeeting").value;
             if (val == '') {
                 document.getElementById("HowQuoteDelivered").style.display = 'none';
                 document.getElementById("QuoteInfo").style.display = 'none';
             }
             if (val == 'No') {
                 document.getElementById("HowQuoteDelivered").style.display = 'none';
                 document.getElementById("QuoteInfo").style.display = '';
             }
             if (val == 'Yes') {
                 document.getElementById("HowQuoteDelivered").style.display = '';
                 document.getElementById("QuoteInfo").style.display = 'none';
             }
         }
         quotedInMeeting();


    </script>
</html>
