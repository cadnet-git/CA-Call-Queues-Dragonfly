<%@ Page Language="VB" AutoEventWireup="false" CodeFile="VitalityRepEmail.aspx.vb" Inherits="Email_VitalityRepEmail" %>

 <!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8">
    <meta name="format-detection" content="telephone=no">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Appointment confirmation</title>
    <style type="text/css">
        a.viewemailonline {
            font-size: 8px;
            color: #929295;
            text-decoration: none;
        }

            a.viewemailonline:link {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:visited {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:hover {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:active {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

        a.unsubscribe {
            font-size: 12px;
            color: #ffffff;
            text-decoration: none;
        }

            a.unsubscribe:link {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:visited {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:hover {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:active {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }


        body[yahoo] table {
            border-spacing: 0px !important;
            border-collapse: collapse !important;
        }

        body[yahoo] img {
            display: block !important;
        }

        body[yahoo] table td {
            border-collapse: collapse !important;
        }

        body[yahoo], html, body {
            margin: 0px !important;
            padding: 0px !important;
            -webkit-text-size-adjust: none !important;
            -ms-text-size-adjust: none !important;
            line-height: 100% !important;
        }

            body[yahoo] .max-width {
                max-width: 600px;
            }

            body[yahoo] .invisible-preheader {
                width: 0px !important;
                height: 0px !important;
                font-size: 0px !important;
                line-height: 0px !important;
                display: none !important;
                color: #e8e8e8 !important;
            }

            body[yahoo] .mobilecookiestatement {
                display: none;
                mso-hide: all;
            }

            body[yahoo] .white a {
                color: #fff !important;
                text-decoration: none !important;
            }

            body[yahoo] .datetime a {
                color: #001001 !important;
                text-decoration: none !important;
            }

        @media screen and (max-width:480px) {
            body[yahoo] .hidethis {
                width: 0px !important;
                display: none !important;
            }

            body[yahoo] .cookiestatement {
                text-align: center !important;
            }

            body[yahoo] .mobilecookiestatement {
                display: block !important;
                width: 300px !important;
                font-family: Arial, Helvetica, sans-serif !important;
                font-size: 9px !important;
                color: #000000 !important;
                text-align: center !important;
                line-height: 30px !important;
            }

            body[yahoo] .mobilecookiestatementlink {
                font-family: Arial, Helvetica, sans-serif !important;
                font-size: 9px !important;
                color: #000000 !important;
                text-align: center !important;
                line-height: 30px !important;
                text-decoration: underline;
            }

            /* -- Layout --*/
            body[yahoo] .max-width {
                max-width: 300px !important;
                width: 300px !important;
            }

            body[yahoo] .fullwidth {
                width: 100% !important;
                display: block !important;
            }

            body[yahoo] .halfwidth {
                width: 50% !important;
                display: block !important;
            }

            body[yahoo] .quarterwidth {
                width: 25% !important;
                display: block !important;
            }

            body[yahoo] .width-260px {
                width: 260px !important;
                max-width: 260px !important;
            }


            body[yahoo] .td10 {
                height: 10px !important;
            }

            body[yahoo] .td20 {
                height: 20px !important;
            }

            body[yahoo] .td24 {
                height: 24px !important;
            }


            body[yahoo] .td30 {
                height: 30px !important;
            }

            body[yahoo] .mb10 {
                display: block !important;
                margin-bottom: 10px !important;
            }

            body[yahoo] .mb15 {
                display: block !important;
                margin-bottom: 15px !important;
            }

            body[yahoo] .mb20 {
                display: block !important;
                margin-bottom: 20px !important;
            }

            body[yahoo] .mt10 {
                display: block !important;
                margin-top: 10px !important;
            }

            body[yahoo] .mt15 {
                display: block !important;
                margin-top: 15px !important;
            }

            body[yahoo] .mt20 {
                display: block !important;
                margin-top: 20px !important;
            }

            body[yahoo] .ml15 {
                margin-left: 15px !important;
            }

            body[yahoo] .pb10 {
                display: block !important;
                padding-bottom: 10px !important;
            }

            body[yahoo] .pb15 {
                display: block !important;
                padding-bottom: 15px !important;
            }

            body[yahoo] .pb20 {
                display: block !important;
                padding-bottom: 20px !important;
            }

            body[yahoo] .pt10 {
                display: block !important;
                padding-top: 10px !important;
            }

            body[yahoo] .pt15 {
                display: block !important;
                padding-top: 15px !important;
            }

            body[yahoo] .pt20 {
                display: block !important;
                padding-top: 20px !important;
            }

            body[yahoo] .imgfull {
                width: 100% !important;
                height: auto !important;
            }

            body[yahoo] .textcenter {
                text-align: center !important;
            }

            body[yahoo] .textleft {
                text-align: left !important;
            }

            body[yahoo] .textright {
                text-align: right !important;
            }

            body[yahoo] .fsz15 {
                font-size: 15px !important;
            }

            body[yahoo] .fsz20 {
                font-size: 20px !important;
            }

            body[yahoo] .fsz22 {
                font-size: 22px !important;
            }

            body[yahoo] .fsz25 {
                font-size: 25px !important;
            }

            body[yahoo] .fsz30 {
                font-size: 30px !important;
            }

            body[yahoo] .lh20 {
                line-height: 30px !important;
            }

            body[yahoo] .lh30 {
                line-height: 30px !important;
            }

            body[yahoo] .lh40 {
                line-height: 40px !important;
            }

            body[yahoo] .bgffffff {
                background-color: #ffffff !important;
            }

            body[yahoo] .bg000000 {
                background-color: #000000 !important;
            }
        }
    </style>
</head>
<body style="font-size: 13px; -webkit-text-size-adjust: none; -ms-text-size-adjust: none; line-height: 100%;" yahoo="fix">
    <style type="text/css">
        a.viewemailonline {
            font-size: 8px;
            color: #929295;
            text-decoration: none;
        }

            a.viewemailonline:link {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:visited {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:hover {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

            a.viewemailonline:active {
                font-size: 8px;
                color: #929295;
                text-decoration: none;
            }

        a.unsubscribe {
            font-size: 12px;
            color: #ffffff;
            text-decoration: none;
        }

            a.unsubscribe:link {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:visited {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:hover {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }

            a.unsubscribe:active {
                font-size: 12px;
                color: #ffffff;
                text-decoration: none;
            }
        </style>

    <span class="preheader" style="display: none !important; visibility: hidden; mso-hide: all; font-size: 1px; line-height: 1px; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;"></span>
    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center">
        <!-- invisible preheader -->
        <tr>
            <td align="center" class="invisible-preheader" style="font-size: 0px; width: 0px; height: 0px; display: none; color: #e8e8e8; line-height: 0px;">
                <span class="invisible-preheader" style="font-size: 0px; width: 0px; height: 0px; display: none; color: #e8e8e8; line-height: 0px;">Appointment confirmation
                </span>
            </td>
        </tr>
        <!-- basic set up of table -->
        <tr>
            <td align="center">
                <table width="600" cellpadding="0" cellspacing="0" border="0" align="center" style="background-color: #fff;" class="max-width">
                    <tbody>
                        <tr>
                            <td align="center" style="border-bottom: 13px solid #ffffff">
                                <table width="560" cellpadding="0" cellspacing="0" border="0" align="center" class="max-width">
                                    <tbody>
                                        <tr>
                                            <td style="height: 30px;"></td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <table width="560" cellpadding="0" cellspacing="0" border="0" align="center" class="max-width">
                                                    <tbody>
                                                        <tr>
                                                            <td style="width: 150px" class="fullwidth">
                                                                <img src="<%=BaseURL%>/email/vitality-logo.gif" width="187" height="62" alt="Vitality Health" style="display: block; border: 0; font-size: 20px; line-height: 28px; font-familt: arial; color: red">
                                                            </td>
                                                            <td style="width: 180px;" class="hidethis"></td>
                                                            <td>
                                                                <table width="230" cellpadding="0" cellspacing="0" border="0" align="center" class="fullwidth">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td width="157" style="font-family: arial, helvetica; font-size: 8px; text-align: right; color: #929295; width: 132px;" class="hidethis"><br>
                                                                            </td>
                                                                            <td width="8"></td>
                                                                            <td style="width: 1px; background-color: #000;"></td>
                                                                            <td style="width: 10px;"></td>
                                                                            <td width="24">
                                                                                <a href="https://twitter.com/Vitality_UK" style="color: #929295; text-decoration: none;" target="_blank">
                                                                                    <img src="<%=BaseURL%>/email/twitter.png" width="24" height="24" alt="t" style="display: block; border: 0; background-color: #00AEEF; color: #ffffff; font-family: arial, helvetica; font-size: 16px;"></a>
                                                                            </td>
                                                                            <td width="6"></td>
                                                                            <td width="24">
                                                                                <a href="https://www.facebook.com/VitalityUK/" style="color: #929295; text-decoration: none;" target="_blank">
                                                                                    <img src="<%=BaseURL%>/email/facebook.png" width="24" height="24" alt="f" style="display: block; border: 0; background-color: #3C5B9A; color: #ffffff; font-family: arial, helvetica; font-size: 16px;"></a>
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center">
                <table width="600" cellpadding="0" cellspacing="0" border="0" align="center" style="background-color: #bfd730" class="max-width">
                    <tr>
                        <td width="380">
                            <table width="100%" cellpadding="2" cellspacing="0" border="0" align="left" class="width-260px ml15">
                                <tr>
                                    <td height="42" padding-left:5px;align="left" valign="middle" 
                                        style="color: #fff; font-family: arial, helvetica; font-size: 18px; text-align: left; line-height: 21px; padding-left: 10px;" >
                                        An appointment has be booked</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center">
                <table width="600" cellpadding="2px" cellspacing="0" border="0" align="center" style="background-color: #fff;" class="max-width">
                    <tr>
                        <td align="center" class="fullwidth" valign="top">
                            <table width="100%" cellpadding="0" cellspacing="0" border="0" align="left" class="max-width">
                                       <tr>
                                    <td align="left" style="font-family: arial, helvetica; font-size: 16px; text-align: left">
                                      <br />  Hi <%=_App.Rep.FirstName %></td>
                                </tr>
                                <tr>
                                    <td style="height: 20px"></td>
                                </tr>
                                <tr>
                                    <td align="left" style="font-family: arial, helvetica; text-align: left; font-size: 16px; font-weight: bold; line-height: 18px; color:#f41c5e">
                                       A MEETING HAS BEEN BOOKED FOR <%= _App.AppointmentDate %> <%= _App.AppointmentTime %>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 20px"></td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <table width="100%" cellpadding="0" cellspacing="0" border="0" align="left" class="max-width" style="background-color: #bfd730">
                                            <tr>
                                                <td  >
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" class="width-260px">
                                                        <tr>
                                                            <td height="33" align="left" valign="middle" 
                                                                style="color: #fff; text-align: left; font-family: arial, helvetica; font-size: 14px; background-color: #bfd730; padding-left: 10px;">
                                                                <strong>Appointment details:</strong>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Prospect Name:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "> <%=_App.TheCompany.ContactFullName %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Job Title:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.ContactPosition %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Company:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.CompanyName %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Booked By:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.theAgent.RealName  %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >When:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.AppointmentDate & " " & _App.AppointmentTime  %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Location:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.FullAddress %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Contact Details:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.ContactDetails %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr> 
                                            <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" > 
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "> 
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                           <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Provider:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.PolicyProvider %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td align="center" style="background-color: #ebebeb" height="30">
                                                    <table width="100%" cellpadding="0" cellspacing="0" border="0" align="center" >
                                                        <tr>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; width: 150px;" >Renewal:
                                                            </td>
                                                            <td align="left" valign="middle" style="color: #001; font-family: arial, helvetica; font-size: 14px; "><%=_App.TheCompany.PolicyExpiresFormatted %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                              <tr>
                                  <td>&nbsp </td>
                                  <td>&nbsp </td>
                              </tr>
                                <tr>
                                    <td align="left" style="font-size: 14px; color: #000; font-family: arial, helvetica; line-height: 16px; text-align: left"><b>Notes</b></td>
                                </tr>
                                <tr>
                                    <td align="left" style="font-size: 14px; color: #000; font-family: arial, helvetica; line-height: 16px; text-align: left"><%=_App.TheCompany.Notes %> </td>
                                </tr>
                                <tr>
                                    <td style="height: 20px"></td>
                                </tr>
                                <tr>
                                    <td align="left" style="font-size: 14px; color: #000; font-family: arial, helvetica; line-height: 16px; text-align: left">Kind regards<br />
                                        <br />
                                        Bolton Lead Generation Team<br /><br />
                                        email us: appointments@va.vitality.co.uk<br /><br />
                                        call us : 01204 843 444
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 30px"></td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </td>
			</tr>
			<tr>
                <td align="center">
                    <table width="600" cellpadding="0" cellspacing="0" border="0" align="center" style="background-color: #888b8d;" class="max-width">
                        <tr>
                            <td align="center">
                                <table width="560" cellpadding="0" cellspacing="0" border="0" align="center" style="background-color: #888b8d;" class="width-260px">
                                    <tr>
                                        <td height="20" style="height: 20px;"></td>
                                    </tr>
                                    <tr>
                                        <td align="center" style="color: #ffffff; font-size: 12px; font-family: arial, helvetica; line-height: 14px; text-align: left">This email is confidential and should not be used by anyone who is not the intended recipient.<br>
                                            <br>
                                            VitalityHealth is a trading name of Vitality Corporate Services Limited. Registered number 05933141.
											Registered in England and Wales. Registered office at 3 More London Riverside, London, SE1 2AQ.
											Vitality Corporate Services Limited is authorised and regulated by the Financial Conduct Authority.
											Trust administration business is handled by Vitality Corporate Services Limited and this activity is
											not regulated by the Financial Conduct Authority.<br>
                                            <br>
                                            1. Source:<em> &#39;Healthy Work Challenges and Opportunities to 2030&#39;</em>,
											2009 report. 2. Flexible individual monthly membership. Joining fees are up to &pound;50 for all clubs other than
											Classic Collection clubs, where joining fees are up to &pound;150. This offer does not apply to the Chiswick Riverside Health and Racquet Club.
										3. British Airways discount applies to return economy flights to more than 70 destinations within the UK and Europe. Up to a maximum of two discounted bookings per member per plan year. The discount ranges between 5% and 40% depending on Vitality status and is subject to a minimum stay depending on the day of departure.<br>
                                            <br>
                                            For further information and terms and conditions
											visit <a href="https://www.vitality.co.uk/" style="text-decoration: none; color: #ffffff;">vitality.co.uk.</a><br>
                                            <br>
                                            An email reply to this address may be subject to interception or monitoring for operational reasons or
											for lawful business practices. If you wish to contact us, please do not reply to this message but
											instead go to the contact us page at
											<a href="https://www.vitality.co.uk/health-insurance/" style="text-decoration: none; color: #ffffff;">vitalityhealth.co.uk</a>.
											Calls may be recorded/monitored to help improve customer service. Call charges may vary.
                                            <br>
                                            <br>
                                            To ensure future emails from us are delivered to your inbox, please add us to your email address book or safe list.<br>
                                            <br>
                                            If you wish to unsubscribe from this service, 
                                            <a href="https://ue.enablermail.com/vitality/unsubscribe.cfm?chid=Oi0jQlcnVkA_NUNPUypQQVstVVAgIAo" class="unsubscribe">please click here.</a>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="td20">
                                <img src="<%=BaseURL%>/email/spacerimg.jpg" width="600" height="24" class="hidethis" style="min-width: 600px;">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
    </table>
    <br />
</body>
</html>



