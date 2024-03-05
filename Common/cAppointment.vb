Imports System.Drawing

Imports System.Windows.Forms

Imports System.Net.Mail

Imports iTextSharp.text

Imports iTextSharp.text.pdf

Imports System.IO

Imports System.Net



Public Class cAppointment



    Private iID As Integer = -1

    Private dAppointmentDate As DateTime

    Private sTime As String



    Private Company As cCompany

    Private Agent As cUser = New cUser

    Public Rep As cUser = New cUser

    Dim sDescription As String = ""
    Dim sFeedback As String = ""
    Dim sConclusion As String = ""
    Private sType As String = ""

    Private sStatus As String

    Public ReadOnly Property AppointmentTime() As String
        Get
            Return sTime
        End Get
    End Property
    Public ReadOnly Property AppointmentDate() As String
        Get
            Return dAppointmentDate.ToLongDateString()
        End Get
    End Property
    Private sConfirmed As String
    Public ReadOnly Property Confirmed() As String
        Get
            Return sConfirmed
        End Get
    End Property
    Public Sub SetConfirmed(ByVal Who As String)
        Dim database As New CADNet.CallQueues.Common.DataLayer
        database.ExecuteSQL("UPDATE DiaryItems Set Confirmed='" & Who & "' where ID=" & iID)
        sConfirmed = Who
    End Sub


    Private bFBAppSat As Boolean = False
    Public Property FBAppSat() As Boolean
        Get
            Return bFBAppSat
        End Get
        Set(ByVal value As Boolean)
            bFBAppSat = value
        End Set
    End Property


    Private sFBReasonNotSat As String = ""
    Public Property FBReasonNotSat() As String
        Get
            Return sFBReasonNotSat
        End Get
        Set(ByVal value As String)
            sFBReasonNotSat = value
        End Set
    End Property

    Private sFBoutcome As String = ""
    Public Property FBOutCome() As String
        Get
            Return sFBoutcome
        End Get
        Set(ByVal value As String)
            sFBoutcome = value
        End Set
    End Property


    Private sFBContactName As String = "" 
    Public Property FBContactName() As String
        Get
            Return sFBContactName
        End Get
        Set(ByVal value As String)
            sFBContactName = value
        End Set
    End Property

    Private sFBContactPositon As String = ""
    Public Property FBContactPositon() As String
        Get
            Return sFBContactPositon
        End Get
        Set(ByVal value As String)
            sFBContactPositon = value
        End Set
    End Property


    Private bFBInvolvedinPMI As Boolean = False
    Public Property FBInvolvedinPMI() As Boolean
        Get
            Return bFBInvolvedinPMI
        End Get
        Set(ByVal value As Boolean)
            bFBInvolvedinPMI = value
        End Set
    End Property

    Private sFBProvider As String =""
    Public Property FBProvider() As String
        Get
            Return sFBProvider
        End Get
        Set(ByVal value As String)
            sFBProvider = value
        End Set
    End Property

    Private sFBRenewal As String = ""
    Public Property FBRenewal() As String
        Get
            Return sFBRenewal
        End Get
        Set(ByVal value As String)
            sFBRenewal = value
        End Set
    End Property

    Private sFBNote As String = ""
    Public Property FBNote() As String
        Get
            Return sFBNote
        End Get
        Set(ByVal value As String)
            sFBNote = value
        End Set
    End Property


    Private bFBIsSale As Boolean = False
    Public Property FBisSale() As Boolean
        Get
            Return bFBIsSale
        End Get
        Set(ByVal value As Boolean)
            bFBIsSale = value
        End Set
    End Property


    Private sFBValue As String = ""
    Public Property FBValue() As String
        Get
            Return sFBValue
        End Get
        Set(ByVal value As String)
            sFBValue = value
        End Set
    End Property


    Private sFBSoldDate As String = ""
    Public Property FBSoldDate() As String
        Get
            Return sFBSoldDate
        End Get
        Set(ByVal value As String)
            sFBSoldDate = value
        End Set
    End Property


    Private sFBStartDate As String = ""
    Public Property FBStartDate() As String
        Get
            Return sFBStartDate
        End Get
        Set(ByVal value As String)
            sFBStartDate = value
        End Set
    End Property


    Private sFBSaleType As String = ""
    Public Property FBSaleType() As String
        Get
            Return sFBSaleType
        End Get
        Set(ByVal value As String)
            sFBSaleType = value
        End Set
    End Property

    Private sNextContact As String
    Public Property NextContact() As String
        Get
            Return sNextContact
        End Get
        Set(ByVal value As String)
            sNextContact = value
        End Set
    End Property

    Private sPreviousProvider As String
    Public Property PreviousProvider() As String
        Get
            Return sPreviousProvider
        End Get
        Set(ByVal value As String)
            sPreviousProvider = value
        End Set
    End Property
    Private sPMINotPresented As String
    Public Property PMINotPresented() As String
        Get
            Return sPMINotPresented
        End Get
        Set(ByVal value As String)
            sPMINotPresented = value
        End Set
    End Property



    Private sLifeOutCome As String = ""
    Public Property LifeOutCome() As String
        Get
            Return sLifeOutCome
        End Get
        Set(ByVal value As String)
            sLifeOutCome = value
        End Set
    End Property

    Private sLifeNextContact As String
    Public Property LifeNextContact() As String
        Get
            Return sLifeNextContact
        End Get
        Set(ByVal value As String)
            sLifeNextContact = value
        End Set
    End Property
    Private _lifeNotPresented As String
    Property LifeNotPresented As String
        Get
            Return _lifeNotPresented
        End Get
        Set(value As String)
            _lifeNotPresented = value
        End Set
    End Property
    Private _lifeValue As String

    Property LifeValue As String
        Get
            Return _lifeValue
        End Get
        Set(value As String)
            _lifeValue = value
        End Set
    End Property
    Private _lifeStartDate As String

    Property LifeStartDate As String
        Get
            Return _lifeStartDate
        End Get
        Set(value As String)
            _lifeStartDate = value
        End Set
    End Property
    Private _lifeSoldDate As String
    Property LifeSoldDate As String
        Get
            Return _lifeSoldDate
        End Get
        Set(value As String)
            _lifeSoldDate = value
        End Set
    End Property




    Public Property Description() As String

        Get

            Description = sDescription

        End Get

        Set(ByVal value As String)

            sDescription = value

        End Set

    End Property


    Public Property Feedback() As String

        Get

            Feedback = sFeedback

        End Get

        Set(ByVal value As String)

            sFeedback = value

        End Set

    End Property


    Public Property Conclusion() As String

        Get

            Conclusion = sConclusion

        End Get

        Set(ByVal value As String)

            sConclusion = value

        End Set

    End Property


    Public Property Type() As String

        Get

            Type = sType

        End Get

        Set(ByVal value As String)

            sType = value

        End Set

    End Property

    Public Property WasInsured() As Integer
    Public Property CoverRequired() As Integer
    Public Property DateCreated() As String

    Public Property CSSent As DateTime
    Public Property CSCompletedDate As DateTime
    Public Property CSPunctual() As String
    Public Property CSProfessional() As String
    Public Property CSCalledBefore() As String
    Public Property CSQuotedInMeeting() As String


    Public Property CSQuoteMethod() As String
    Public Property CSQuoteInfo() As String
    Public Property CSComments() As String
    Public Property CSCompleted() As Integer

    Private Settings As Common.cSettings = New Common.cSettings

    Public Enum Styles

        Hidden

        Preview

        PickPrinter

        Fax

        Web

    End Enum

    Public Enum EmailRecipient

        Client

        Rep

    End Enum

    Public ReadOnly Property TheCompany() As cCompany

        Get

            TheCompany = Company

        End Get

    End Property
    Public Property RepPostcode() As String



    Public Sub SaveSurvey(Punctual As String, Professional As String, CalledBefore As String, QuotedInMeeting As String, QuoteMethod As String, QuoteInfo As String, Comments As String)

        Dim Params As Microsoft.VisualBasic.Collection = New Microsoft.VisualBasic.Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@AppID", SqlDbType.NVarChar, ID)

        Database.CreateParameter(Params, "@Punctual", SqlDbType.NVarChar, Punctual)
        Database.CreateParameter(Params, "@Professional", SqlDbType.NVarChar, Professional)
        Database.CreateParameter(Params, "@CalledBefore", SqlDbType.NVarChar, CalledBefore)
        Database.CreateParameter(Params, "@QuotedInMeeting", SqlDbType.NVarChar, QuotedInMeeting)
        Database.CreateParameter(Params, "@QuoteMethod", SqlDbType.NVarChar, QuoteMethod)
        Database.CreateParameter(Params, "@QuoteInfo", SqlDbType.NVarChar, QuoteInfo)
        Database.CreateParameter(Params, "@Comments", SqlDbType.NVarChar, Comments)

        Database.ExecuteSP("spSaveSurvey", Params)

    End Sub


    Public Sub load(ByVal ID As Integer)

        Dim DS As DataSet

        ' get data

        Dim Params As Microsoft.VisualBasic.Collection = New Microsoft.VisualBasic.Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.CreateParameter(Params, "@AppointmentID", SqlDbType.Int, ID)

        DS = Database.ExecuteSP("spAppointmentGet", Params)

        Dim DR As DataRow = DS.Tables(0).Rows(0)

        iID = DR("ID")

        sType = DR("Type")

        Select Case sType

            Case "CA"

                Company = New cCompany(DR("CompanyID"))

                Agent.Load(DR("AgentID"))
                sConfirmed = DR("Confirmed")

                If DR.IsNull("FBAppSat") = False Then
                    FBAppSat = DR("FBAppSat")
                End If

                FBReasonNotSat = DR("FbReason").ToString
                FBContactName = DR("FBContact").ToString
                FBContactPositon = DR("FBposition").ToString
                If DR.IsNull("FBInvolvedPMI") = False Then
                    FBInvolvedinPMI = DR("FBInvolvedPMI")
                End If
                FBOutCome = DR("FBOutCome").ToString
                FBProvider = DR("FBProvider").ToString
                FBRenewal = DR("FBRenewal").ToString
                FBNote = DR("FBnote").ToString
                If DR.IsNull("FBisSale") = False Then
                    FBisSale = DR("FBisSale")
                End If

                FBValue = DR("fbvalue").ToString
                FBSoldDate = DR("FBSoldDate").ToString
                FBStartDate = DR("FBStartDate").ToString
                FBSaleType = DR("FBSaleType").ToString


                NextContact = DR("FBPMINextContact").ToString
                PreviousProvider = DR("FBPreviousProvider").ToString

                PMINotPresented = DR("FBPMINotPresented").ToString
                LifeOutCome = DR("FBLifeOutCome").ToString
                LifeNextContact = DR("FBLifeNextContact").ToString
                LifeNotPresented = DR("FBLifeNotPresented").ToString

                LifeSoldDate = DR("FBLifeSoldDate").ToString
                LifeValue = DR("FBLifeValue").ToString
                LifeStartDate = DR("FBLifeStartedDate").ToString
              
                WasInsured = DR("WasInsured").ToString
                CoverRequired = DR("CoverRequired").ToString
                If DR.IsNull("CSSent") = False Then
                    CSSent = DR("CSSent")
                End If

                CSPunctual = DR("CSPunctual").ToString
                CSProfessional = DR("CSProfessional").ToString
                CSCalledBefore = DR("CSCalledBefore").ToString
                CSQuotedInMeeting = DR("CSQuotedInMeeting").ToString
                CSQuoteMethod = DR("CSQuoteMethod").ToString
                CSQuoteInfo = DR("CSQuoteInfo").ToString
                CSComments = DR("CSComments").ToString
                CSCompleted = DR("CSCompleted")
                If DR.IsNull("CSCompletedDate") = False Then
                    CSCompletedDate = DR("CSCompletedDate")
                End If

            Case "REP"
                RepPostcode = DR("Postcode").ToString
                'Latitude = arow("DiaryLat")

                'Longitude = arow("DiaryLong")

            Case "GEN"



        End Select

        Rep.Load(DR("userID"))

        dAppointmentDate = DR("itemdate")
        Dim dc As DateTime = DR("Created")
        DateCreated = dc.ToLongDateString & " " & dc.ToLongTimeString


        sTime = dAppointmentDate.ToShortTimeString

        sDescription = DR("Description").ToString

        sStatus = DR("StatusString").ToString
        sFeedback = DR("FeedbackStatus").ToString
        sConclusion = DR("Conclusion").ToString
        sConfirmed = DR("Confirmed").ToString

    End Sub



    Public Property Status() As String
        Get
            Status = sStatus
        End Get
        Set(ByVal value As String)
            sStatus = value
        End Set
    End Property




    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As Drawing.Printing.PrintPageEventArgs)

        printAppointment(ev)

    End Sub

    Public ReadOnly Property ID() As Integer

        Get

            ID = iID

        End Get

    End Property

    Public Sub ChangeSlot(ByVal appointmentTime As String, ByVal period As Integer)

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Database.ExecuteSQL("UPDATE DiaryItems SET  ItemDate='" & appointmentTime & "', ItemPeriod=" & period & ", Status=1 Where ID=" & iID)

    End Sub

    Public Sub setWasInsured(val As Integer)
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.ExecuteSQL("UPDATE DiaryItems SET  WasInsured = " & val & " Where ID=" & iID)
    End Sub

    Public Property theAgent() As cUser

        Get

            theAgent = Agent

        End Get

        Set(ByVal value As cUser)

            Agent = value

        End Set

    End Property

    Public Sub Print(ByVal Style As Styles, Optional ByVal Filename As String = "")


        Dim pd As New Printing.PrintDocument

        AddHandler pd.PrintPage, AddressOf pd_PrintPage

        Select Case Style



            Case Styles.Hidden

                pd.Print()

            Case Styles.Preview

                Dim pp As PrintPreviewDialog = New PrintPreviewDialog

                pp.Document = pd
                pp.Height = Screen.PrimaryScreen.Bounds.Height
                pp.Width = Screen.PrimaryScreen.Bounds.Width
                pp.Show()

            Case Styles.Web

                'TODO REPLACE THIS printing method for  rep website
                'CreatePDF(Filename)
            Case Else

                ' pick printer 
                Dim pp As PrintDialog = New PrintDialog
                pp.Document = pd
                If pp.ShowDialog() = DialogResult.OK Then
                    pd.Print()
                End If

        End Select









    End Sub

    'Public Sub Fax(ByVal Number As String)



    '    Dim objFaxDocument As New FAXCOMEXLib.FaxDocument

    '    Dim objFaxServer As New FAXCOMEXLib.FaxServer

    '    '   Dim objSender As FAXCOMEXLib.FaxSender

    '    Dim JobID As Object

    '    '  MsgBox("About to connect to  = " & Settings.FaxServer)

    '    'Connect to the fax server

    '    objFaxServer.Connect(Settings.FaxServer)

    '    ' MsgBox("connectd to  = " & Settings.FaxServer)

    '    'Name the document

    '    objFaxDocument.DocumentName = "Confirmation"



    '    'Set the fax priority

    '    objFaxDocument.Priority = FAXCOMEXLib.FAX_PRIORITY_TYPE_ENUM.fptHIGH



    '    'Add the recipient with the fax number 12225550100

    '    objFaxDocument.Recipients.Add(Number, Company.ContactTitle & " " & Company.ContactForename & " " & Company.ContactSurname)



    '    'Choose to attach the fax to the fax receipt

    '    objFaxDocument.AttachFaxToReceipt = True



    '    ''Set the cover page type and the path to the cover page

    '    objFaxDocument.CoverPageType = FAXCOMEXLib.FAX_COVERPAGE_TYPE_ENUM.fcptLOCAL

    '    objFaxDocument.CoverPage = "\\sbserver\faxcover\SHPMI.cov"



    '    'Provide the cover page note



    '    ' build titles string 

    '    Dim Titles As String

    '    Titles = "Date: " & vbCrLf & vbCrLf

    '    Titles = Titles & "Time:" & vbCrLf & vbCrLf

    '    Titles = Titles & "Our Consultant:" & vbCrLf & vbCrLf

    '    Titles = Titles & "Your Address:" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

    '    Titles = Titles & "Current Insurer:" & vbCrLf

    '    Titles = Titles & "Renewal Date:" & vbCrLf

    '    Titles = Titles & "Notes:"

    '    objFaxDocument.Note = Titles



    '    Dim Fields As String

    '    Fields = Format(dAppointmentDate, "dddd d MMMM yyyy") & vbCrLf & vbCrLf

    '    Fields = Fields & dAppointmentDate.ToShortTimeString & vbCrLf & vbCrLf

    '    Fields = Fields & Rep.RealName & vbCrLf & vbCrLf

    '    Fields = Fields & Company.Address1 & vbCrLf

    '    Fields = Fields & Company.Address2 & vbCrLf

    '    Fields = Fields & Company.Address3 & vbCrLf

    '    Fields = Fields & Company.Town & vbCrLf

    '    Fields = Fields & Company.County & vbCrLf

    '    Fields = Fields & Company.Postcode & vbCrLf & vbCrLf



    '    Fields = Fields & Company.PolicyProvider & vbCrLf

    '    Fields = Fields & Company.PolicyExpiresFormatted & vbCrLf
    '    Fields = Fields & Company.Notes & vbCrLf



    '    objFaxDocument.Sender.HomePhone = Fields

    '    'Provide the address for the fax receipt

    '    objFaxDocument.ReceiptAddress = "office@slhc-pmi.co.uk"



    '    'Set the receipt type to email

    '    objFaxDocument.ReceiptType = FAXCOMEXLib.FAX_RECEIPT_TYPE_ENUM.frtMAIL



    '    'Specify that the fax is to be sent at a particular time

    '    objFaxDocument.ScheduleType = FAXCOMEXLib.FAX_SCHEDULE_TYPE_ENUM.fstNOW

    '    'CDate converts the time to the Date data type

    '    ' objFaxDocument.ScheduleTime = Now



    '    objFaxDocument.Subject = "Confirmation for " & Company.CompanyName



    '    'Set the sender properties.

    '    objFaxDocument.Sender.Title = Company.ContactPosition

    '    objFaxDocument.Sender.Name = "conversation with " & Agent.RealName & " from our Bolton Office."

    '    objFaxDocument.Sender.City = "Manchester"

    '    objFaxDocument.Sender.State = "Manachester"

    '    objFaxDocument.Sender.Company = ""

    '    objFaxDocument.Sender.Country = "UK"

    '    objFaxDocument.Sender.Email = "office@secure-ppp.co.uk"

    '    objFaxDocument.Sender.FaxNumber = "01204437163"



    '    objFaxDocument.Sender.OfficeLocation = Company.CompanyName

    '    objFaxDocument.Sender.OfficePhone = Company.Telephone

    '    objFaxDocument.Sender.StreetAddress = ""

    '    objFaxDocument.Sender.TSID = "Cadnet"

    '    objFaxDocument.Sender.ZipCode = "44118"

    '    objFaxDocument.Sender.BillingCode = "23A54"

    '    objFaxDocument.Sender.Department = Company.Email & " "

    '    'Save sender information as default

    '    objFaxDocument.Sender.SaveDefaultSender()

    '    'Submit the document to the connected fax server

    '    'and get back the job ID.

    '    Try

    '        'MsgBox("try  to send ")

    '        JobID = objFaxDocument.Submit(objFaxServer.ServerName)

    '        ' MsgBox("Fax Sent ")

    '    Catch ex As Exception

    '        MsgBox("Error Faxing  " & ex.Source.ToString & "   " & ex.Message)

    '    End Try

    '    objFaxServer.Disconnect()

    'End Sub



    'Private Sub CreatePDF(ByVal FileName As String)


    '    Dim MyDoc As Document

    '    Dim MyWriter As PdfWriter



    '    Dim cb As PdfContentByte

    '    Dim HeaderImage As iTextSharp.text.Image = Nothing

    '    Dim nf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)

    '    Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)

    '    Dim inf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA_OBLIQUE, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)


    '    MyDoc = New Document()



    '    Try

    '        HeaderImage = iTextSharp.text.Image.GetInstance(Settings.LogoPath & "SecureHealthLogo.png")

    '    Catch ex As Exception

    '        Dim aWobbler As New Exception("Exception while Creating PDF - " & ex.Message & ": " & Settings.LogoPath, ex)

    '        Throw aWobbler

    '    End Try
    '    MyWriter = PdfWriter.GetInstance(MyDoc, New FileStream(FileName, FileMode.Create))
    '    MyDoc.Open()
    '    cb = MyWriter.DirectContent



    '    Dim _topoffset As Integer = -17 * 8

    '    Dim _LineHeight As Integer = 14

    '    Dim _wideline As Integer = 20

    '    Dim _top As Integer = 688

    '    Dim _Bottom As Integer = 0

    '    Dim _LeftMargin As Integer = 0

    '    Dim _RightMargin As Integer = 565

    '    Dim wideline As Integer = 25

    '    Dim middleCol As Integer = 160



    '    HeaderImage.SetAbsolutePosition(_LeftMargin + ((_RightMargin - 110) / 2), _top + 42)

    '    HeaderImage.ScaleToFit(170, 106)

    '    cb.AddImage(HeaderImage)



    '    cb.BeginText()

    '    cb.SetFontAndSize(nf, 12)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Local Representatives working in your local area.", 185, _top + 35, 0)

    '    cb.SetFontAndSize(nf, 10)
    '    _topoffset = _topoffset + _LineHeight + 120


    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Now.ToLongDateString, 80, _top - _topoffset, 0)

    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "If this has been incorrectly addressed please advise by return", 45, _top - _topoffset, 0)


    '    _topoffset = _topoffset + _wideline + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Dear", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.ContactTitle & " " & Company.ContactForename & " " & Company.ContactSurname, 80, _top - _topoffset, 0)


    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Position:", 345, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.ContactPosition, 400, _top - _topoffset, 0)


    '    _topoffset = _topoffset + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Thank you for your interest in Securehealth arranging your Private Medical Insurance. I am writing to confirm your ", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "conversation  with " & Agent.RealName & " from our local office.", 45, _top - _topoffset, 0)



    '    cb.SetFontAndSize(nf, 10)

    '    _topoffset = _topoffset + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Your appointment details are as below:", 45, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Format(dAppointmentDate, "dddd d MMMM yyyy"), middleCol, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Time:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dAppointmentDate.ToLongTimeString, middleCol, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Our Consultant:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Rep.RealName, middleCol, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Your Address:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.CompanyName, middleCol, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Address1, middleCol, _top - _topoffset, 0)



    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Address2, middleCol, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Address3, middleCol, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Town, middleCol, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.County, middleCol, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Postcode, middleCol, _top - _topoffset, 0)


    '    _topoffset = _topoffset + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Tel No:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Telephone, middleCol, _top - _topoffset, 0)


    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Current Insurer:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.PolicyProvider, middleCol, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Renewal Date:", 45, _top - _topoffset, 0)
    '    If Company.PolicyProvider <> "No Cover" Then
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.PolicyExpiresFormatted, middleCol, _top - _topoffset, 0)
    '    End If

    '    _topoffset = _topoffset + wideline
    '    cb.SetFontAndSize(inf, 10)
    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Note:", 45, _top - _topoffset, 0)

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Company.Notes, middleCol, _top - _topoffset, 0)




    '    cb.SetFontAndSize(nf, 10)

    '    _topoffset = _topoffset + _LineHeight + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "If you already belong to a Private Healthcare Scheme, it would be helpful if you could have the details to hand", 45, _top - _topoffset, 0)



    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "at the meeting.", 45, _top - _topoffset, 0)



    '    _topoffset = _topoffset + wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Out of courtesy, if you are unable to keep the above appointment, please contact the Office on", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "01204 845422 or by return email to rearrange the appointment", 45, _top - _topoffset, 0)



    '    cb.SetFontAndSize(nf, 10)

    '    _topoffset = _topoffset + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "We look forward to meeting you to show how simple and cost-effective private medical cover can be when", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "arranged through SecureHealth.", 45, _top - _topoffset, 0)


    '    _topoffset = _topoffset + _LineHeight + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Yours sincerely", 45, _top - _topoffset, 0)


    '    _topoffset = _topoffset + _wideline

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ann MacDonald", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Head of Operations", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _wideline + _LineHeight
    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Suite N/1/17, Nortex Business Centre, 105 Chorley Old Road, Bolton, BL1 3AG", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Tel: 01204 845422 or Fax: 01204 437163", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _wideline

    '    cb.SetFontAndSize(bf, 8)
    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "SecureHealth Ltd is a member of the AXA UK group of insurance businesses,", 45, _top - _topoffset, 0)

    '    _topoffset = _topoffset + _LineHeight

    '    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "and is authorised and regulated by the Financial Conduct Authority.", 45, _top - _topoffset, 0)


    '    cb.EndText()



    '    MyDoc.NewPage()



    '    cb = Nothing

    '    MyDoc.Close()

    '    MyWriter.Close()

    '    MyDoc = Nothing

    '    MyWriter = Nothing



    'End Sub

    Public Shared Function GetHTML(ByVal URL As String) As String

        Dim sHTML As String = Nothing

        Dim Client As New WebClient
        Client.Encoding = System.Text.Encoding.UTF8
        Client.Headers = New WebHeaderCollection
        Client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2;)")
        sHTML = Client.DownloadString(URL)

        Return sHTML

    End Function

    Public Sub EmailSurvey(ByVal Recipient As String, ByVal CopyTo As String)



        Dim mail As New MailMessage()



        'set the addresses

        mail.From = New MailAddress("appointments@va.vitality.co.uk")



        mail.To.Add(Recipient)

        If CopyTo <> "" Then

            mail.Bcc.Add(CopyTo)

        End If



        'set the content

        mail.Subject = "Vitality Customer Satisfaction Survey"
        mail.IsBodyHtml = True
        'mail.Body = "Please find attached details of your appointment with our consultant " & vbCrLf & vbCrLf & "Alison Gorman" & vbCrLf & vbCrLf & "Office Manager"

        mail.Body = GetHTML("https://vitality.cahealthcare.co.uk/Survey/SurveyEmail.aspx?ID=" & Me.iID)

        'Dim toSend As Attachment = New Attachment("C:\Standard Life Healthcare Appointment Confirmation.pdf")
        'Dim toSend As Attachment = New Attachment(Settings.LogoPath & "SecureHealthLogo.png")

        ' Application.DoEvents()

        '  mail.Attachments.Add(toSend)

        'send the message

        Try

            Dim smtp As New SmtpClient(Settings.SMTPServer)
            smtp.Credentials = New NetworkCredential(Settings.EmailUser, Settings.EmailPassword)
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Send(mail)
            smtp = Nothing

        Catch ex As Exception

            MsgBox("Error Emailing  - " & ex.Message)

        End Try
        '   toSend.Dispose()
        '   toSend = Nothing
        mail.Dispose()
        mail = Nothing

        Application.DoEvents()

    End Sub

    Public Sub EmailRep(Recipient As String, CopyTo As String)
        Dim mail As New MailMessage()

        'set the addresses

        mail.From = New MailAddress("appointments@va.vitality.co.uk")
        mail.To.Add(Recipient)

        If CopyTo <> "" Then

            mail.Bcc.Add(CopyTo)

        End If

        'set the content

        mail.Subject = "New Appointment Booked"
        mail.IsBodyHtml = True
        Dim ct As Integer
        ct = CoverRequired
        If ct = 0 Then ct = 1
        mail.Body = GetHTML("https://vitality.cahealthcare.co.uk/Email/VitalityRepEmail.aspx?id=" & Me.iID)

        Try

            Dim smtp As New SmtpClient(Settings.SMTPServer)
            smtp.Credentials = New NetworkCredential(Settings.EmailUser, Settings.EmailPassword)
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Send(mail)
            smtp = Nothing

        Catch ex As Exception

            MsgBox("Error Emailing  - " & ex.Message)

        End Try

        mail.Dispose()
        mail = Nothing


        Application.DoEvents()
    End Sub


    Public Sub Email(ByVal Recipient As String, ByVal CopyTo As String)

        Dim mail As New MailMessage()

        'set the addresses

        mail.From = New MailAddress("appointments@va.vitality.co.uk")
        mail.To.Add(Recipient)

        If CopyTo <> "" Then

            mail.Bcc.Add(CopyTo)

        End If

        'set the content

        mail.Subject = "Vitality Appointment Confirmation"
        mail.IsBodyHtml = True
        Dim ct As Integer
        ct = CoverRequired
        If ct = 0 Then ct = 1
        mail.Body = GetHTML("https://vitality.cahealthcare.co.uk/Email/VitalityEmail.aspx?id=" & Me.iID)

        Try

            Dim smtp As New SmtpClient(Settings.SMTPServer)
            smtp.Credentials = New NetworkCredential(Settings.EmailUser, Settings.EmailPassword)
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Send(mail)
            smtp = Nothing

        Catch ex As Exception

            MsgBox("Error Emailing  - " & ex.Message)

        End Try

        mail.Dispose()
        mail = Nothing


        Application.DoEvents()

    End Sub

    Private Sub printAppointment(ByVal ev As Printing.PrintPageEventArgs)



        'Dim DS As DataSet

        '' get data

        'Dim Params As Collection = New Collection

        'Common.DataLayer.CreateParameter(Params, "@AppointmentID", SqlDbType.Int, AppointmentID)

        'DS = Common.DataLayer.ExecuteSP("spAppointmentGet", Params)

        'Dim DR As DataRow



        'DR = DS.Tables(0).Rows(0)

        Dim BlackBrush As New SolidBrush(System.Drawing.Color.Black)

        Dim redBrush As New SolidBrush(System.Drawing.Color.Red)

        Dim BoldFont As System.Drawing.Font = New System.Drawing.Font("Arial", 12, FontStyle.Regular)

        Dim StandardFont As System.Drawing.Font = New System.Drawing.Font("Arial", 10, FontStyle.Regular)

        Dim ItalicFont As System.Drawing.Font = New System.Drawing.Font("Arial", 10, FontStyle.Italic)
        Dim SmallBoldFont As System.Drawing.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)

        Dim textsize As SizeF = New SizeF

        ' check text width

        Dim lineheight As Integer = 19

        Dim wideline As Integer = 25

        Dim lineX As Integer = 50

        Dim rightEdge As Integer = ev.PageBounds.Width - 60

        Dim LeftEdge As Integer = 60

        Dim DataEdge As Integer = 280





        Dim newImage As System.Drawing.Image = System.Drawing.Image.FromFile(Settings.LogoPath & "SecureHealthLogo.gif")

        ev.Graphics.DrawImage(newImage, 310, lineX - 9)



        lineX = lineX + wideline + 76

        ev.Graphics.DrawString("Local Representatives working in your local area. ", BoldFont, BlackBrush, 220, lineX)

        lineX = lineX + wideline + lineheight

        ev.Graphics.DrawString("Date:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Now.ToLongDateString, StandardFont, BlackBrush, LeftEdge + 35, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("If this has been incorrectly addressed please advise by return", StandardFont, BlackBrush, LeftEdge, lineX)



        lineX = lineX + wideline + wideline

        ev.Graphics.DrawString("Dear", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Company.ContactTitle & " " & Company.ContactForename & " " & Company.ContactSurname, StandardFont, BlackBrush, LeftEdge + 35, lineX)

        ev.Graphics.DrawString("Position:", StandardFont, BlackBrush, 460, lineX)

        ev.Graphics.DrawString(Company.ContactPosition, StandardFont, BlackBrush, 520, lineX)





        'lineX = lineX + wideline

        'ev.Graphics.DrawString("Tel No:", StdFont, BlackBrush, LeftEdge, lineX)

        'ev.Graphics.DrawString(Company.Telephone, StdFont, BlackBrush, DataEdge, lineX)



        'lineX = lineX + wideline

        'ev.Graphics.DrawString("Fax No:", StdFont, BlackBrush, LeftEdge, lineX)

        'ev.Graphics.DrawString(Company.Fax, StdFont, BlackBrush, DataEdge, lineX)



        'lineX = lineX + wideline

        'ev.Graphics.DrawString("Email:", StdFont, BlackBrush, LeftEdge, lineX)

        'ev.Graphics.DrawString(Company.Email, StdFont, BlackBrush, DataEdge, lineX)



        'lineX = lineX + lineheight + lineheight

        'ev.Graphics.DrawString("Dear " & Company.ContactTitle & " " & Company.ContactForename & " " & Company.ContactSurname, SoftFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("Thank you for your interest in Securehealth arranging your Private Medical Insurance. I am writing to confirm your ", StandardFont, BlackBrush, LeftEdge, lineX)

        '   ev.Graphics.DrawLine(New Pen(Color.DarkSlateBlue), 50, lineheight, 360, lineheight)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("conversation with " & Agent.RealName & " from our Local Office.", StandardFont, BlackBrush, LeftEdge, lineX)





        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("Your appointment details are as below:", StandardFont, BlackBrush, LeftEdge, lineX)





        lineX = lineX + wideline

        ev.Graphics.DrawString("Date:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Format(dAppointmentDate, "dddd d MMMM yyyy"), StandardFont, BlackBrush, DataEdge, lineX)



        lineX = lineX + wideline

        ev.Graphics.DrawString("Time:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(dAppointmentDate.ToShortTimeString, StandardFont, BlackBrush, DataEdge, lineX)



        lineX = lineX + wideline

        ev.Graphics.DrawString("Our Consultant:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Rep.RealName, StandardFont, BlackBrush, DataEdge, lineX)



        lineX = lineX + wideline

        ev.Graphics.DrawString("Your Address:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Company.CompanyName & ", ", StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.Address1 & ", ", StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.Address2 & ", ", StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.Address3 & ", ", StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.Town & ", ", StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.County, StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString(Company.Postcode, StandardFont, BlackBrush, DataEdge, lineX)



        lineX = lineX + wideline

        ev.Graphics.DrawString("Current Insurer:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Company.PolicyProvider, StandardFont, BlackBrush, DataEdge, lineX)

        lineX = lineX + wideline

        ev.Graphics.DrawString("Renewal Date:", StandardFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Company.PolicyExpiresFormatted, StandardFont, BlackBrush, DataEdge, lineX)
        lineX = lineX + wideline

        ev.Graphics.DrawString("Notes:", ItalicFont, BlackBrush, LeftEdge, lineX)

        ev.Graphics.DrawString(Company.Notes, ItalicFont, BlackBrush, DataEdge, lineX)
        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("If you already belong to a Private Healthcare Scheme, it would be helpful if you could have the details to hand", StandardFont, BlackBrush, LeftEdge, lineX)



        lineX = lineX + lineheight

        ev.Graphics.DrawString("at the meeting.", StandardFont, BlackBrush, LeftEdge, lineX)



        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("Out of courtesy, if you are unable to keep the above appointment, please contact the Office on ", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("01204 845422 or by return email to rearrange the appointment. ", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("We look forward to meeting you to show how simple and cost-effective private medical cover can be when", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("arranged through SecureHealth.", StandardFont, BlackBrush, LeftEdge, lineX)



        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("Yours sincerely", StandardFont, BlackBrush, LeftEdge, lineX)



        lineX = lineX + lineheight + lineheight

        ev.Graphics.DrawString("Ann MacDonald", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("Head of Operations.", StandardFont, BlackBrush, LeftEdge, lineX)


        lineX = lineX + lineheight + lineheight + lineheight

        ev.Graphics.DrawString("Office Address: Suite N/1/17, Nortex Business Centre, 105 Chorley Old Road, Bolton, BL1 3AG", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("Telephone 01204 845422 or Fax: 01204 437163", StandardFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight + lineheight + lineheight

        ev.Graphics.DrawString("SecureHealth Ltd is a member of the AXA UK group of insurance businesses, ", SmallBoldFont, BlackBrush, LeftEdge, lineX)

        lineX = lineX + lineheight

        ev.Graphics.DrawString("and is authorised and regulated by the Financial Conduct Authority.  ", SmallBoldFont, BlackBrush, LeftEdge, lineX)


        ev.HasMorePages = False

    End Sub

End Class


