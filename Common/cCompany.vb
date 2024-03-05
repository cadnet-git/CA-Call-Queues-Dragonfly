Public Class cCompany

#Region "Properties"

    Public Property Attemps() As Integer

    Public ReadOnly Property ContactFullName() As String
        Get
            Dim temp As String = ""
            temp = temp & ContactTitle & " "
            temp = temp & ContactForename & " "
            temp = temp & ContactSurname
            Return temp.Trim()
        End Get
    End Property

    Public ReadOnly Property FullAddress() As String
        Get
            Dim temp As String = ""
            temp = temp & Address1 & ", "
            If (Address2.Trim.Length > 0) Then
                temp = temp & Address2 & ", "
            End If
            If (Address2.Trim.Length > 0) Then
                temp = temp & Address2 & ", "
            End If

            If (Address3.Trim.Length > 0) Then
                temp = temp & Address3 & ", "
            End If

            If (Town.Trim.Length > 0) Then
                temp = temp & Town & ", "
            End If
            If (County.Trim.Length > 0) Then
                temp = temp & County & ", "
            End If
            temp = temp.Trim() & Postcode
            Return temp.Trim()
        End Get
    End Property


    Public ReadOnly Property ContactDetails() As String
        Get
            Dim temp As String = ""
            temp = temp & Telephone & " "
            temp = temp & MobileTelephone & " "
            temp = temp & Email
            Return temp.Trim()
        End Get
    End Property

    Public ReadOnly Property Rep() As Common.cUser
        Get
            Rep = cRep
        End Get
    End Property

    Public ReadOnly Property Agent() As Common.cUser
        Get
            Agent = cAgent
        End Get
    End Property


    Private iID As Integer = -1
    Public ReadOnly Property ID() As Integer
        Get
            ID = iID
        End Get
    End Property

    Public AgentID As Integer = -1


    Private sCompanyName As String = ""
    Public Property CompanyName() As String
        Get
            CompanyName = sCompanyName
        End Get
        Set(ByVal value As String)
            If value <> sCompanyName Then
                bIsDirty = True
                sCompanyName = value
            End If
        End Set
    End Property


    Private sContactTitle As String = ""
    Public Property ContactTitle() As String
        Get
            ContactTitle = sContactTitle
        End Get
        Set(ByVal value As String)
            If value <> sContactTitle Then
                sContactTitle = Common.TitleCase(value)
                bIsDirty = True
            End If
        End Set
    End Property



    Private sContactForename As String = ""
    Public Property ContactForename() As String
        Get
            ContactForename = sContactForename
        End Get
        Set(ByVal value As String)
            If value <> sContactForename Then
                sContactForename = Common.TitleCase(value)
                bIsDirty = True
            End If
        End Set
    End Property

    Private sContactSurname As String = ""
    Public Property ContactSurname() As String
        Get
            ContactSurname = sContactSurname
        End Get
        Set(ByVal value As String)
            If value <> sContactSurname Then
                sContactSurname = Common.TitleCase(value)
                bIsDirty = True
            End If
        End Set
    End Property

    Private sContactPosition As String = ""
    Public Property ContactPosition() As String
        Get
            ContactPosition = sContactPosition
        End Get
        Set(ByVal value As String)
            If value <> sContactPosition Then
                sContactPosition = value
                bIsDirty = True
            End If
        End Set
    End Property


    Public ReadOnly Property ContactFirstNameOrSurnameAndTitle() As String
        Get
            If ContactForename.Trim.Length > 0 Then
                Return ContactForename
            End If
            Return (ContactTitle.Trim() & " " & ContactSurname.Trim()).Trim()
        End Get
    End Property




    Private sAddress1 As String = ""
    Public Property Address1() As String
        Get
            Address1 = sAddress1
        End Get
        Set(ByVal value As String)
            If value <> sAddress1 Then
                sAddress1 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sAddress2 As String = ""
    Public Property Address2() As String
        Get
            Address2 = sAddress2
        End Get
        Set(ByVal value As String)
            If value <> sAddress2 Then
                sAddress2 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sAddress3 As String = ""
    Public Property Address3() As String
        Get
            Address3 = sAddress3
        End Get
        Set(ByVal value As String)
            If value <> sAddress3 Then
                sAddress3 = value
                bIsDirty = True
            End If
        End Set
    End Property
    Private sTown As String = ""
    Public Property Town() As String
        Get
            Town = sTown
        End Get
        Set(ByVal value As String)
            If value <> sTown Then
                sTown = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sCounty As String = ""
    Public Property County() As String
        Get
            County = sCounty
        End Get
        Set(ByVal value As String)
            If value <> sCounty Then
                sCounty = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sPostcode As String = ""
    Public ReadOnly Property Postcode() As String
        Get
            Postcode = sPostcode.ToUpper
        End Get
    End Property

    Private iPostcodeID As Integer = -1

    Private iAreaID As Integer = -1
    Public ReadOnly Property AreaID() As Integer
        Get
            AreaID = iAreaID
        End Get
    End Property

    Private sArea As String = ""
    Public ReadOnly Property Area() As String
        Get
            Area = sArea
        End Get
    End Property
    Private sFax As String = ""
    Public Property Fax() As String
        Get
            Fax = sFax
        End Get
        Set(ByVal value As String)
            If value <> sFax Then
                sFax = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sEmail As String = ""
    Public Property Email() As String
        Get
            Email = sEmail
        End Get
        Set(ByVal value As String)
            If sEmail <> value Then
                sEmail = value
                bIsDirty = True
            End If
        End Set
    End Property




    Private sTel As String = ""

    Private dPolicyExpires As Date
    Public Property PolicyExpires() As Date
        Get
            PolicyExpires = dPolicyExpires
        End Get
        Set(ByVal value As Date)
            If value <> dPolicyExpires Then
                dPolicyExpires = value
                bIsDirty = True
            End If
        End Set
    End Property

    Public ReadOnly Property PolicyExpiresFormatted() As String
        Get
            Dim sTemp As String = ""

            If sPolicyProvider.ToLower <> "no cover" Then

                sTemp = Common.DateManipulation.DateToString(dPolicyExpires, DateFormats.ForDisplayMonthNameYear)

            End If
            PolicyExpiresFormatted = sTemp

        End Get
    End Property

    Private sPolicyProvider As String
    Public Property PolicyProvider() As String
        Get
            PolicyProvider = sPolicyProvider
        End Get
        Set(ByVal value As String)
            If value <> sPolicyProvider Then
                sPolicyProvider = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private dLastCalled As Date
    Public ReadOnly Property LastCalled() As Date
        Get
            LastCalled = dLastCalled
        End Get
    End Property

    Private sNotes As String
    Public Property Notes() As String
        Get
            Notes = sNotes
        End Get
        Set(ByVal value As String)
            If value <> sNotes Then
                sNotes = value
                bIsDirty = True
            End If
        End Set
    End Property


    Private iRepID As Integer = -1
    Private cRep As Common.cUser
    Private cAgent As Common.cUser
    Public HoldUntil As Date
    Public BusinessType As String
    Public EmployeeCount As Integer?
    Public URN As String
    Public GroupCompanyID As Integer


    Public ReadOnly Property GroupCompany() As String
        Get
            Select Case GroupCompanyID
                Case 1
                    Return "CA"
                Case 2
                    Return "DF"
                Case Else
                    Return ""
            End Select
        End Get
    End Property



    Private iCallType As Common.eCallTypes = Common.eCallTypes.Unknown
    Public Property CallType() As Common.eCallTypes
        Get
            CallType = iCallType
        End Get
        Set(ByVal value As Common.eCallTypes)
            If value <> iCallType Then
                iCallType = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sStatus As String
    Public Property Status() As String
        Get
            Status = sStatus
        End Get
        Set(ByVal value As String)
            sStatus = value
            Select Case sStatus
                Case "OutofArea"
                    iAllowCall = 1
                Case Common.enums.eCompanyStatus.Appointment.ToString, Common.enums.eCompanyStatus.InProgress.ToString, Common.enums.eCompanyStatus.InvalidNumber.ToString, Common.enums.eCompanyStatus.ReviewRequired.ToString, Common.enums.eCompanyStatus.TPS.ToString
                    iAllowCall = 1
                Case Else
                    iAllowCall = 1
            End Select

        End Set
    End Property

    Private iAllowCall As Integer = -1
    Public Property AllowCalls() As Boolean
        Get
            If iAllowCall = 1 Then
                AllowCalls = True
            Else
                AllowCalls = False
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                iAllowCall = 1
            Else
                iAllowCall = 0
            End If
            bIsDirty = True
        End Set
    End Property

    Private bIsDirty As Boolean
    Public Property CallbackAttempts As Integer

    Public History As Collection = New Collection

    Private tHistoryTable As DataTable


    Private dLatitude As Double
    Public ReadOnly Property Latitude() As Double
        Get
            Latitude = dLatitude
        End Get
    End Property

    Private dLongitude As Double
    Public ReadOnly Property Longitude() As Double
        Get
            Longitude = dLongitude
        End Get
    End Property

    Public Property ThisCall() As cCallHistory

    Public Property StandardLife() As Integer
    Public Property Promotion() As String = ""

    Public Property TPSUntil() As DateTime = "1 Jan 1900"

    Public Property Id118 As Integer
    Public Property SeniorDecisionMaker As String
    Public Property MainTelephone As String
    Public Property OriginalTelephone As String
    Public Property DirectTelephone As String
    Public Property MobileTelephone As String

    Public Property Employees As String

    Public Property LegalEntity As Int32?
    Public Property ConsentGivenBy As String
    Public Property ConsentGivenByPosition As String
    Public Property ConsentGivenByDate As DateTime?
    Public Property ConsentUntil As DateTime?
    Public Property ConsentRefused As Boolean?
    Public Property ConsentCollectedBy As String
#End Region


    Public Sub Refresh()
        'reload the company data
        'first get the history

        Dim Database As New Common.DataLayer

        Dim Params As New Collection
        Database.CreateParameter(Params, "@CompanyID", SqlDbType.Int, iID)
        Dim DS As DataSet = Database.ExecuteSP("spCompanyHistoryGetAll", Params)

        tHistoryTable = DS.Tables(0)

        'now get the company data:
        Params = New Collection
        Database.CreateParameter(Params, "@CompanyID", SqlDbType.Int, iID)
        DS = Database.ExecuteSP("spCompanyGet", Params)

        Load(DS.Tables(0).Rows(0))
    End Sub
    Public Sub New(ByVal ID As Integer)

        'first get the history
        Dim Database As New Common.DataLayer

        Dim Params As New Collection
        Database.CreateParameter(Params, "@CompanyID", SqlDbType.Int, ID)
        Dim DS As DataSet = Database.ExecuteSP("spCompanyHistoryGetAll", Params)

        tHistoryTable = DS.Tables(0)

        'now get the company data:
        Params = New Collection
        Database.CreateParameter(Params, "@CompanyID", SqlDbType.Int, ID)
        DS = Database.ExecuteSP("spCompanyGet", Params)

        Load(DS.Tables(0).Rows(0))

    End Sub
    Public Sub New(ByVal aRow As DataRow, ByVal HistoryTable As DataTable)
        tHistoryTable = HistoryTable
        Load(aRow)

    End Sub


    Private Sub Load(ByVal aRow As DataRow)
        With aRow

            iID = aRow("ID")
            sCompanyName = .Item("CompanyName")

            sContactTitle = .Item("ContactTitle").ToString
            sContactForename = .Item("ContactForename").ToString
            sContactSurname = .Item("ContactSurname").ToString
            sContactPosition = .Item("ContactPosition").ToString

            sAddress1 = .Item("Address1").ToString
            sAddress2 = .Item("Address2").ToString
            sAddress3 = .Item("Address3").ToString

            sTown = .Item("Town").ToString
            sCounty = .Item("County").ToString
            sPostcode = .Item("PostcodeRaw").ToString
            URN = .Item("URN").ToString
            sTel = .Item("Telephone").ToString
            sFax = .Item("Fax").ToString
            sEmail = .Item("Email").ToString

            BusinessType = .Item("BusinessType").ToString

            Employees = .Item("Employees").ToString

            If .Item("AreaID") Is DBNull.Value Then
                iAreaID = 0
            Else
                iAreaID = .Item("AreaID")
            End If

            If .Item("Area") Is DBNull.Value Then
                sArea = ""
            Else
                sArea = .Item("Area")
            End If

            iPostcodeID = .Item("PostcodeID")
            cAgent = New cUser
            If .Item("AgentID") Is DBNull.Value Then
                AgentID = 0
            Else
                AgentID = .Item("AgentID")
            End If
            If AgentID > 0 Then
                cAgent.Load(AgentID)
            End If
            Try
                If .Item("RepID") Is DBNull.Value Then
                    iRepID = 0
                Else
                    iRepID = .Item("RepID")
                End If
            Catch ex As Exception
                'this company has no rep assigned
                iRepID = 0
                Console.WriteLine("oops")
            End Try

            Try
                GroupCompanyID = .Item("GroupCompanyID")
            Catch ex As Exception
                GroupCompanyID = 0
            End Try



            cRep = New Common.cUser

            If iRepID > 0 Then
                cRep.Load(iRepID)
            End If

            Try
                dLongitude = .Item("Longitude")
                dLatitude = .Item("Latitude")
            Catch ex As Exception
                Console.WriteLine("oops")
            End Try


            If .Item("PolicyExpires") Is DBNull.Value Then
                dPolicyExpires = Nothing
            Else
                dPolicyExpires = .Item("PolicyExpires")
            End If

            sPolicyProvider = .Item("PolicyProvider").ToString

            If .Item("LastCalled") Is DBNull.Value Then
                dLastCalled = Nothing
            Else
                dLastCalled = .Item("LastCalled")
            End If

            sNotes = .Item("Notes").ToString
            sStatus = .Item("CompanyStatus")
            iAllowCall = .Item("AllowCall")
            StandardLife = .Item("isStandardLifedata")
            Promotion = .Item("Promotion").ToString

            HoldUntil = .Item("HoldUntil")
            TPSUntil = .Item("TPSUntil")

            MainTelephone = .Item("MainTel").ToString
            DirectTelephone = .Item("DDITel").ToString
            MobileTelephone = .Item("MobileTel").ToString
            OriginalTelephone = .Item("OriginalNumber").ToString

            If .Item("LegalEntity") Is DBNull.Value Then
                LegalEntity = Nothing
            Else
                LegalEntity = .Item("LegalEntity")
            End If

            ConsentGivenBy = .Item("ConsentGivenBy").ToString
            ConsentGivenByPosition = .Item("ConsentGivenByPosition").ToString

            If .Item("ConsentGivenByDate") Is DBNull.Value Then
                ConsentGivenByDate = Nothing
            Else
                ConsentGivenByDate = .Item("ConsentGivenByDate")
            End If

            If .Item("ConsentUntil") Is DBNull.Value Then
                ConsentUntil = Nothing
            Else
                ConsentUntil = .Item("ConsentUntil")
            End If


            If .Item("ConsentRefused") Is DBNull.Value Then
                ConsentRefused = Nothing
            Else
                ConsentRefused = .Item("ConsentRefused")
            End If

            ConsentCollectedBy = .Item("ConsentCollectedBy").ToString

            bIsDirty = False
            SeniorDecisionMaker = .Item("SeniorDecisionMaker").ToString

            If .Item("id118") Is DBNull.Value Then
                Id118 = -1
            Else
                Id118 = .Item("id118")
            End If

            'ok time to load history 
            Attemps = 0
            CallbackAttempts = 0
            Dim counter As Integer = 0
            For Each hRow As DataRow In tHistoryTable.Rows
                If counter = 0 Then
                    ' First row
                    ThisCall = New cCallHistory(hRow, Me)
                Else
                    ' other rows
                    Dim ACall As cCallHistory = New cCallHistory(hRow, Me)
                    If ACall.UserID = AgentID And ACall.Hide = 0 Then
                        ' not hidden and for this agent so calls this agent has made since the agent was given the record
                        Attemps = Attemps + 1
                        If ACall.CallStartStatus = "CallBack" And ACall.CallEndStatus = "CallBack" Then
                            CallbackAttempts = CallbackAttempts + 1
                        End If
                    End If
                    History.Add(ACall)
                End If
                counter = counter + 1
            Next

        End With

    End Sub



    Public Sub HideHistory()
        ' hide histroey to agents in the future 

        Dim Database As New Common.DataLayer
        Dim ssql As String
        ssql = String.Format("UPDate CompanyHistory Set Hide=1 WHERE (CompanyID = {0})", iID)
        Database.ExecuteSQL(ssql)
        ssql = String.Format("UPDate Companies Set Notes='' WHERE (ID = {0})", iID)
        Database.ExecuteSQL(ssql)
    End Sub
    Public Sub Save()
        Dim Params As New Collection

        Dim Database As New Common.DataLayer
        'If cAgentApp.GetInstance.User.UserLevelID = Common.eUserLevel.Developer Then
        '    MessageBox.Show("CompanyID=" & iID, "Company.Save")
        'End If
        Database.CreateParameter(Params, "@CompanyID", SqlDbType.Int, iID)
        Database.CreateParameter(Params, "@CompanyName", SqlDbType.NVarChar, sCompanyName)

        Database.CreateParameter(Params, "@ContactTitle", SqlDbType.NVarChar, sContactTitle)
        Database.CreateParameter(Params, "@ContactForename", SqlDbType.NVarChar, sContactForename)
        Database.CreateParameter(Params, "@ContactSurname", SqlDbType.NVarChar, sContactSurname)
        Database.CreateParameter(Params, "@ContactPosition", SqlDbType.NVarChar, sContactPosition)

        Database.CreateParameter(Params, "@Address1", SqlDbType.NVarChar, sAddress1)
        Database.CreateParameter(Params, "@Address2", SqlDbType.NVarChar, sAddress2)
        Database.CreateParameter(Params, "@Address3", SqlDbType.NVarChar, sAddress3)
        Database.CreateParameter(Params, "@Town", SqlDbType.NVarChar, sTown)
        Database.CreateParameter(Params, "@County", SqlDbType.NVarChar, sCounty)
        Database.CreateParameter(Params, "@Postcode", SqlDbType.NVarChar, sPostcode)

        Database.CreateParameter(Params, "@Tel", SqlDbType.NVarChar, sTel)
        Database.CreateParameter(Params, "@Fax", SqlDbType.NVarChar, sFax)
        Database.CreateParameter(Params, "@Email", SqlDbType.NVarChar, sEmail)

        Database.CreateParameter(Params, "@PolicyProvider", SqlDbType.NVarChar, sPolicyProvider)

        Dim parPolicyExpires As New SqlClient.SqlParameter("@PolicyExpires", SqlDbType.DateTime)
        If dPolicyExpires = #12:00:00 AM# Then
            parPolicyExpires.Value = DBNull.Value
        Else
            parPolicyExpires.Value = dPolicyExpires
        End If
        Params.Add(parPolicyExpires)

        Database.CreateParameter(Params, "@Notes", SqlDbType.NVarChar, sNotes)
        Database.CreateParameter(Params, "@Status", SqlDbType.NVarChar, Status)
        Database.CreateParameter(Params, "@HoldUntil", SqlDbType.DateTime, HoldUntil)

        Database.CreateParameter(Params, "@PostcodeID", SqlDbType.Int, iPostcodeID)
        Database.CreateParameter(Params, "@AllowCall", SqlDbType.Int, iAllowCall)

        Database.CreateParameter(Params, "@AgentID", SqlDbType.Int, AgentID)
        Database.CreateParameter(Params, "@StandardLife", SqlDbType.Int, StandardLife)
        Database.CreateParameter(Params, "@Promotion", SqlDbType.NVarChar, Promotion)

        Database.CreateParameter(Params, "@TPSUntil", SqlDbType.DateTime, TPSUntil)

        Database.CreateParameter(Params, "@SeniorDecisionMaker", SqlDbType.NVarChar, SeniorDecisionMaker)
        Database.CreateParameter(Params, "@id118", SqlDbType.Int, Id118)

        Database.CreateParameter(Params, "@MainTel", SqlDbType.NVarChar, MainTelephone)
        Database.CreateParameter(Params, "@DirectTel", SqlDbType.NVarChar, DirectTelephone)
        Database.CreateParameter(Params, "@MobileTel", SqlDbType.NVarChar, MobileTelephone)
        Database.CreateParameter(Params, "@OriginalNumber", SqlDbType.NVarChar, OriginalTelephone)
        Database.CreateParameter(Params, "@Employees", SqlDbType.NVarChar, Employees)




        Database.CreateParameter(Params, "@LegalEntity", SqlDbType.Int, LegalEntity)

        Database.CreateParameter(Params, "@ConsentGivenBy", SqlDbType.NVarChar, ConsentGivenBy)
        Database.CreateParameter(Params, "@ConsentGivenByPosition", SqlDbType.NVarChar, ConsentGivenByPosition)
        Database.CreateParameter(Params, "@ConsentGivenByDate", SqlDbType.DateTime, ConsentGivenByDate)
        Database.CreateParameter(Params, "@ConsentUntil", SqlDbType.DateTime, ConsentUntil)

        Database.CreateParameter(Params, "@ConsentRefused", SqlDbType.Bit, ConsentRefused)
        Database.CreateParameter(Params, "@ConsentCollectedBy", SqlDbType.NVarChar, ConsentCollectedBy)
        Database.CreateParameter(Params, "@BusinessType", SqlDbType.NVarChar, BusinessType)
        Database.CreateParameter(Params, "@URN", SqlDbType.NVarChar, URN)
        Database.CreateParameter(Params, "@GroupCompanyID", SqlDbType.Int, GroupCompanyID)
        Database.ExecuteSPNoQuery("spCompanySave", Params)
        bIsDirty = False

    End Sub





    Public Property Telephone() As String
        Get
            Telephone = sTel
        End Get
        Set(ByVal value As String)
            If value <> sTel Then

                Dim sTemp As String = value.Trim


                If Common.StringManipulation.RemoveNonNumerics(sTemp) <> sTemp Then
                    'can only have numerics in a telephone number
                    Dim aWobbler As New Exception("Telephone numbers can only contain numbers")
                    Throw aWobbler
                    Exit Property
                End If

                'need to make sure the telephone number is unique in the database

                Dim sSQL As String = "SELECT * from Companies where telephone='" & sTemp & "' AND CompanyStatus <> 'Supervisor' AND ID <>" & ID & " AND GroupCompanyID= " & GroupCompanyID
                Dim Database As New Common.DataLayer
                Dim DS As DataSet = Database.ExecuteSQL(sSQL)
                If DS.Tables(0).Rows.Count > 0 Then
                    'the telephone number is already in use
                    Dim aWobbler As New Exception("Telephone number is already in use")
                    Throw aWobbler
                    Exit Property
                End If

                sTel = sTemp
                bIsDirty = True
            End If
        End Set
    End Property

    Public ReadOnly Property ImportHistory() As DataTable
        Get
            Dim database As New CADNet.CallQueues.Common.DataLayer
            Dim ds As DataSet = database.ExecuteSQL("Select * from ImportHistory where companyId =" & ID & " Order by ID desc")
            Return ds.Tables(0)
        End Get
    End Property


    Public Sub CallBackOn(ByVal CallbackDate As Date)
        HoldUntil = CallbackDate
    End Sub

    Public Sub CreateAppointment(ByVal Rep As Common.cUser, ByVal AppointmentDate As DateTime, ByVal Period As Integer)
        'make the entry in the reps diary
        'alter the settings for the company  and save em
        'dont forget to increment the user counts and update the monitor



        'may be this would be better in the call object???
        'or will have to pass the call object anyway


        Dim Params As New Collection

        Dim parDate As New SqlClient.SqlParameter("@AppointmentDate", SqlDbType.DateTime)
        parDate.Value = AppointmentDate.Date
        Params.Add(parDate)

        Dim parPeriod As New SqlClient.SqlParameter("@Period", SqlDbType.Int)
        parPeriod.Value = Period
        Params.Add(parPeriod)

        Dim parUserID As New SqlClient.SqlParameter("@UserID", SqlDbType.Int)
        parUserID.Value = Rep.ID
        Params.Add(parUserID)

        Dim parCompanyID As New SqlClient.SqlParameter("@CompanyID", SqlDbType.Int)
        parCompanyID.Value = iID
        Params.Add(parCompanyID)

        Dim Database As New Common.DataLayer
        Database.ExecuteSPNoQuery("spAppointmentCreate", Params)


    End Sub
End Class
