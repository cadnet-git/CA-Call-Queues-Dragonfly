<Serializable()> Public Class cUser

#Region "Properties"



    Private iID As Integer = -1
    Public ReadOnly Property ID() As Integer
        Get
            ID = iID
        End Get
    End Property

    Private iUserLevelID As Common.eUserLevel = -1
    Public Property UserLevelID() As Common.eUserLevel
        Get
            UserLevelID = iUserLevelID
        End Get
        Set(ByVal value As Common.eUserLevel)
            If value <> iUserLevelID Then
                iUserLevelID = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sUserLevelTitle As String = ""
    Public ReadOnly Property UserLevelTitle() As String
        Get
            'if you need to edit it, use the ID!
            UserLevelTitle = sUserLevelTitle
        End Get
    End Property

    Private sRealName As String = ""
    Public Property RealName() As String
        Get
            RealName = sRealName
        End Get
        Set(ByVal value As String)
            If sRealName <> value Then
                sRealName = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sUserName As String = ""
    Public Property UserName() As String
        Get
            UserName = sUserName
        End Get
        Set(ByVal value As String)
            If value <> sUserName Then
                sUserName = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private iStatus As Integer = 2  'default to active
    Public Property StatusID() As Integer
        Get
            StatusID = iStatus
        End Get
        Set(ByVal value As Integer)
            If value <> iStatus Then
                iStatus = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sStatus As String = ""
    Public ReadOnly Property StatusTitle() As String
        Get
            StatusTitle = sStatus
        End Get
    End Property


    Private sChangePassword As String = ""
    Public WriteOnly Property Password() As String
        Set(ByVal value As String)
            sChangePassword = value
            bIsDirty = True
        End Set
    End Property


    Private iArea As Integer 'the area an agent is assigned to NOT the reps!
    Public Property AreaID() As Integer
        Get
            AreaID = iArea
        End Get
        Set(ByVal value As Integer)
            If value <> iArea Then
                iArea = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sAreaname As String = ""
    Public Property Areaname() As String
        Get
            Areaname = sAreaname
        End Get
        Set(ByVal value As String)
            If sAreaname <> value Then
                sAreaname = Areaname
            End If
        End Set
    End Property


    Public Property CallsToday() As Integer
    Public Property AppointmentsToday() As Integer

    Public Property GroupCompanyID() As Integer
    'adddress info
    Private sTel As String = ""
    Public Property Tel() As String
        Get
            Tel = sTel
        End Get
        Set(ByVal value As String)
            If value <> sTel Then
                sTel = value
                bIsDirty = True
            End If
        End Set
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
            If value <> sEmail Then
                sEmail = value
                bIsDirty = True
            End If
        End Set
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

    Private sAddress4 As String = ""
    Public Property Address4() As String
        Get
            Address4 = sAddress4
        End Get
        Set(ByVal value As String)
            If value <> sAddress4 Then
                sAddress4 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sAddress5 As String = ""
    Public Property Address5() As String
        Get
            Address5 = sAddress5
        End Get
        Set(ByVal value As String)
            If value <> sAddress5 Then
                sAddress5 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private sPostcode As String = ""


    Public Property Postcode() As String
        Get
            Postcode = sPostcode
        End Get
        Set(ByVal value As String)
            If value <> sPostcode Then
                sPostcode = value
                bIsDirty = True
            End If
        End Set
    End Property
    Private sPosition As String = ""
    Public Property Position() As String
        Get
            Position = sPosition
        End Get
        Set(ByVal value As String)
            If value <> sPosition Then
                sPosition = value
                bIsDirty = True
            End If
        End Set
    End Property

    'diary settings
    Private bHasApp1 As Boolean
    Public Property HasApp1() As Boolean
        Get
            HasApp1 = bHasApp1
        End Get
        Set(ByVal value As Boolean)
            If value <> bHasApp1 Then
                bHasApp1 = value
                bIsDirty = True
            End If
        End Set
    End Property


    Private bHasApp2 As Boolean
    Public Property HasApp2() As Boolean
        Get
            HasApp2 = bHasApp2
        End Get
        Set(ByVal value As Boolean)
            If value <> bHasApp2 Then
                bHasApp2 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private bHasApp3 As Boolean
    Public Property HasApp3() As Boolean
        Get
            HasApp3 = bHasApp3
        End Get
        Set(ByVal value As Boolean)
            If value <> bHasApp3 Then
                bHasApp3 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private bHasApp4 As Boolean
    Public Property HasApp4() As Boolean
        Get
            HasApp4 = bHasApp4
        End Get
        Set(ByVal value As Boolean)
            If value <> bHasApp4 Then
                bHasApp4 = value
                bIsDirty = True
            End If
        End Set
    End Property
    Private bHasApp5 As Boolean
    Public Property HasApp5() As Boolean
        Get
            HasApp5 = bHasApp5
        End Get
        Set(ByVal value As Boolean)
            If value <> bHasApp5 Then
                bHasApp5 = value
                bIsDirty = True
            End If
        End Set
    End Property


    Private dAppTime1 As Date
    Public Property AppTime1() As Date
        Get
            AppTime1 = dAppTime1
        End Get
        Set(ByVal value As Date)
            If dAppTime1 <> value Then
                dAppTime1 = value
                bIsDirty = True
            End If
        End Set
    End Property


    Private dAppTime2 As Date
    Public Property AppTime2() As Date
        Get
            AppTime2 = dAppTime2
        End Get
        Set(ByVal value As Date)
            If dAppTime2 <> value Then
                dAppTime2 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private dAppTime3 As Date
    Public Property AppTime3() As Date
        Get
            AppTime3 = dAppTime3
        End Get
        Set(ByVal value As Date)
            If dAppTime3 <> value Then
                dAppTime3 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private dAppTime4 As Date
    Public Property AppTime4() As Date
        Get
            AppTime4 = dAppTime4
        End Get
        Set(ByVal value As Date)
            If dAppTime4 <> value Then
                dAppTime4 = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private dAppTime5 As Date
    Public Property AppTime5() As Date
        Get
            AppTime5 = dAppTime5
        End Get
        Set(ByVal value As Date)
            If dAppTime5 <> value Then
                dAppTime5 = value
                bIsDirty = True
            End If
        End Set
    End Property


    Private iAppsPerWeek As Integer = 0
    Public Property AppsPerWeek() As Integer
        Get
            AppsPerWeek = iAppsPerWeek
        End Get
        Set(ByVal value As Integer)
            If value <> iAppsPerWeek Then
                iAppsPerWeek = value
                bIsDirty = True
            End If
        End Set
    End Property

    Private bLoggedIn As Boolean

    ''' <summary>
    ''' Does the class have unsaved data?
    ''' </summary>
    Private bIsDirty As Boolean
    Public ReadOnly Property IsDirty() As Boolean
        Get
            IsDirty = bIsDirty
        End Get
    End Property

    Public Property OKMaxDist() As Integer = 25
    Public Property MedMaxDist() As Integer = 35
    Public Property LongMaxDist() As Integer = 49
    Public Property OverrideDiaryWeeks() As Integer

    Public ReadOnly Property DiaryPeriods() As Integer
        Get
            DiaryPeriods = 0
            If bHasApp5 Then
                DiaryPeriods = 5
            ElseIf bHasApp4 Then
                DiaryPeriods = 4
            ElseIf bHasApp3 Then
                DiaryPeriods = 3
            ElseIf bHasApp2 Then
                DiaryPeriods = 2
            Else
                DiaryPeriods = 1
            End If
        End Get
    End Property

#End Region

    Public Function TestUserName(ByVal Username As String) As Boolean

        If Username = sUserName Then
            'user name hasnt changed
            Return True
            Exit Function
        End If

        'is the username long enough?
        Dim sClean As String = Common.RemoveNonAlphaNumerics(Username.Trim)

        If sClean.Length < 2 Then
            'clean username is too short
            Return False
            Exit Function
        End If


        'does the un already exisit?
        Dim Database As New Common.DataLayer
        Dim sSQL As String = "select * from users where username='" & sClean & "'"
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows.Count <> 0 Then
            'its in use
            Return False
            Exit Function
        End If

        Return True
    End Function



    Public Sub Load(ByVal ID As Integer)
        If ID = 1000000 Then
            iID = ID
            Exit Sub
        End If

        Dim Database As New Common.DataLayer
        Dim Params As New Collection

        Database.CreateParameter(Params, "@UserID", SqlDbType.Int, ID)

        Using DS As DataSet = Database.ExecuteSP("spUserGet", Params)
            If DS.Tables(0).Rows.Count = 1 Then
                Load(DS.Tables(0).Rows(0))
            ElseIf DS.Tables(0).Rows.Count = 0 Then
                'no users found
                Dim aWobbler As New Exception("Cannot find user. ID=" & ID)
                Throw aWobbler
            Else
                'too many users returned
                Dim aWobbler As New Exception("User ID is not unique. ID=" & ID)
                Throw aWobbler
            End If
        End Using

    End Sub

    Public Sub Load(ByVal aRow As DataRow)


        iID = aRow.Item("ID")
        sUserName = aRow.Item("UserName").ToString
        iUserLevelID = aRow.Item("UserLevelID")
        sRealName = aRow.Item("RealName").ToString
        sUserLevelTitle = aRow.Item("UserLevelTitle").ToString
        sStatus = aRow.Item("StatusTitle").ToString
        iStatus = aRow.Item("Status")

        If aRow.Item("AreaID") Is DBNull.Value Then
            iArea = 0
        Else
            iArea = aRow.Item("AreaID")
        End If

        sAreaname = aRow.Item("AreaName").ToString

        HasApp1 = aRow.Item("HasApp1")
        HasApp2 = aRow.Item("HasApp2")
        HasApp3 = aRow.Item("HasApp3")
        HasApp4 = aRow.Item("HasApp4")
        HasApp5 = aRow.Item("HasApp5")

        sFax = aRow.Item("Fax").ToString
        sTel = aRow.Item("Tel").ToString
        sEmail = aRow.Item("Email").ToString
        sAddress1 = aRow.Item("Address1").ToString
        sAddress2 = aRow.Item("Address2").ToString
        sAddress3 = aRow.Item("Address3").ToString
        sAddress4 = aRow.Item("Address4").ToString
        sAddress5 = aRow.Item("Address5").ToString
        sPostcode = aRow.Item("Postcode").ToString
        sPosition = aRow.Item("Position").ToString
        If aRow.Item("AppPerWeek") Is DBNull.Value Then
            iAppsPerWeek = 0
        Else
            iAppsPerWeek = aRow.Item("AppPerWeek")
        End If



        If aRow.Item("AppTime1") Is DBNull.Value Then
        Else
            AppTime1 = aRow.Item("AppTime1")
        End If

        If aRow.Item("AppTime2") Is DBNull.Value Then
        Else
            AppTime2 = aRow.Item("AppTime2")
        End If
        OverrideDiaryWeeks = aRow.Item("OverrideDiaryWeeks")

        If aRow.Item("AppTime3") Is DBNull.Value Then
        Else
            AppTime3 = aRow.Item("AppTime3")
        End If

        If aRow.Item("AppTime4") Is DBNull.Value Then
        Else
            AppTime4 = aRow.Item("AppTime4")
        End If

        If aRow.Item("AppTime5") Is DBNull.Value Then
        Else
            AppTime5 = aRow.Item("AppTime5")
        End If
        Try
            OKMaxDist = aRow("OKMaxDist").ToString
            MedMaxDist = aRow("MedMaxDist").ToString
            LongMaxDist = aRow("LongMaxDist").ToString
        Catch ex As Exception
            OKMaxDist = 25
            MedMaxDist = 35
            LongMaxDist = 49
        End Try
        GroupCompanyID = aRow("GroupCompanyID")
        bIsDirty = False

    End Sub

    Public Sub Save()
        'save the current user into the database
        'assumes that all data is good
        Dim Database As New Common.DataLayer
        Dim Params As New Collection

        Dim parUserID As New SqlClient.SqlParameter("@UserID", SqlDbType.Int)
        parUserID.Value = iID
        Params.Add(parUserID)

        Dim parUserName As New SqlClient.SqlParameter("@UserName", SqlDbType.NVarChar)
        parUserName.Value = sUserName
        Params.Add(parUserName)

        Dim parRealName As New SqlClient.SqlParameter("@RealName", SqlDbType.NVarChar)
        parRealName.Value = sRealName
        Params.Add(parRealName)

        Dim parStatusID As New SqlClient.SqlParameter("@StatusID", SqlDbType.Int)
        parStatusID.Value = iStatus
        Params.Add(parStatusID)

        Dim parUserLevel As New SqlClient.SqlParameter("@UserLevel", SqlDbType.Int)
        parUserLevel.Value = iUserLevelID
        Params.Add(parUserLevel)

        Dim parHasApp1 As New SqlClient.SqlParameter("@HasApp1", SqlDbType.Int)
        parHasApp1.Value = bHasApp1
        Params.Add(parHasApp1)

        Dim parHasApp2 As New SqlClient.SqlParameter("@HasApp2", SqlDbType.Int)
        parHasApp2.Value = bHasApp2
        Params.Add(parHasApp2)

        Dim parHasApp3 As New SqlClient.SqlParameter("@HasApp3", SqlDbType.Int)
        parHasApp3.Value = bHasApp3
        Params.Add(parHasApp3)

        Dim parHasApp4 As New SqlClient.SqlParameter("@HasApp4", SqlDbType.Int)
        parHasApp4.Value = bHasApp4
        Params.Add(parHasApp4)

        Dim parHasApp5 As New SqlClient.SqlParameter("@HasApp5", SqlDbType.Int)
        parHasApp5.Value = bHasApp5
        Params.Add(parHasApp5)

        Dim parAppTime1 As New SqlClient.SqlParameter("@AppTime1", SqlDbType.DateTime)
        parAppTime1.Value = dAppTime1
        Params.Add(parAppTime1)

        Dim parAppTime2 As New SqlClient.SqlParameter("@AppTime2", SqlDbType.DateTime)
        parAppTime2.Value = dAppTime2
        Params.Add(parAppTime2)

        Dim parAppTime3 As New SqlClient.SqlParameter("@AppTime3", SqlDbType.DateTime)
        parAppTime3.Value = dAppTime3
        Params.Add(parAppTime3)

        Dim parAppTime4 As New SqlClient.SqlParameter("@AppTime4", SqlDbType.DateTime)
        parAppTime4.Value = dAppTime4
        Params.Add(parAppTime4)



        With Database
            .CreateParameter(Params, "@AppTime5", SqlDbType.DateTime, dAppTime5)
            .CreateParameter(Params, "@AreaID", SqlDbType.Int, iArea)

            .CreateParameter(Params, "@Fax", SqlDbType.NVarChar, sFax)
            .CreateParameter(Params, "@Tel", SqlDbType.NVarChar, sTel)
            .CreateParameter(Params, "@Email", SqlDbType.NVarChar, sEmail)
            .CreateParameter(Params, "@Address1", SqlDbType.NVarChar, sAddress1)
            .CreateParameter(Params, "@Address2", SqlDbType.NVarChar, sAddress2)
            .CreateParameter(Params, "@Address3", SqlDbType.NVarChar, sAddress3)
            .CreateParameter(Params, "@Address4", SqlDbType.NVarChar, sAddress4)
            .CreateParameter(Params, "@Address5", SqlDbType.NVarChar, sAddress5)
            .CreateParameter(Params, "@Postcode", SqlDbType.NVarChar, sPostcode)
            .CreateParameter(Params, "@Position", SqlDbType.NVarChar, sPosition)
            .CreateParameter(Params, "@AppsPerWeek", SqlDbType.Int, iAppsPerWeek)
            .CreateParameter(Params, "@OKMaxDist", SqlDbType.Int, OKMaxDist)
            .CreateParameter(Params, "@MedMaxDist", SqlDbType.Int, MedMaxDist)
            .CreateParameter(Params, "@LongMaxDist", SqlDbType.Int, LongMaxDist)
            .CreateParameter(Params, "@OverrideDiaryWeeks", SqlDbType.Int, OverrideDiaryWeeks)
            .CreateParameter(Params, "@GroupCompanyID", SqlDbType.Int, GroupCompanyID)
        End With



        Dim DS As DataSet = Database.ExecuteSP("spUserSave", Params)

        Load(DS.Tables(0).Rows(0))

        If sChangePassword <> "" Then
            Dim sSQL As String = "update users set password='" & sChangePassword & "' where id=" & iID
            Database.ExecuteSQL(sSQL)

            sChangePassword = ""
        End If

    End Sub

    Public Function Login(ByVal Username As String, ByVal Password As String, ByVal Application As Common.eApplications) As Boolean




        Dim Params As New Collection

        Dim aParam As New SqlClient.SqlParameter("@UserName", SqlDbType.NVarChar)
        aParam.Value = Username
        Params.Add(aParam)

        aParam = New SqlClient.SqlParameter("@Password", SqlDbType.NVarChar)
        aParam.Value = Password
        Params.Add(aParam)

        aParam = New SqlClient.SqlParameter("@Application", SqlDbType.NVarChar)
        aParam.Value = Application.ToString
        Params.Add(aParam)

        Dim Database As New Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spUserLogin", Params)

        If DS.Tables(0).Rows.Count = 1 Then
            Load(DS.Tables(0).Rows(0))
            bLoggedIn = True
        ElseIf DS.Tables(0).Rows.Count = 0 Then
            'no users found
            bLoggedIn = False
        Else
            'too many users returned
            Dim aWobbler As New Exception("Login Error: Too many users with same credentials")
            bLoggedIn = False
        End If

        Dim bSecurityPass As Boolean = False
        If bLoggedIn Then
            'check that the user has credentials to use that application.
            'this is based on the UserLevel
            Select Case Application
                Case eApplications.Agent
                    Select Case Me.iUserLevelID
                        Case eUserLevel.Developer, eUserLevel.Manager, eUserLevel.Agent
                            'these users are allowed to login
                            bSecurityPass = True
                        Case eUserLevel.Rep
                            'these users are not allowed to login
                            bSecurityPass = False
                        Case Else
                            Dim aWobbler As New Exception("Unsupported Userlevel during Login: " & iUserLevelID.ToString)
                            Throw aWobbler

                            bSecurityPass = False
                    End Select
                Case eApplications.ManagementConsole
                    Select Case Me.iUserLevelID
                        Case eUserLevel.Developer, eUserLevel.Manager
                            'these users are allowed to login
                            bSecurityPass = True
                        Case eUserLevel.Rep, eUserLevel.Agent
                            'these users are not allowed to login
                            bSecurityPass = False
                        Case Else
                            Dim aWobbler As New Exception("Unsupported Userlevel during Login: " & iUserLevelID.ToString)
                            Throw aWobbler

                            bSecurityPass = False
                    End Select
                Case eApplications.DeveloperConsole
                    Select Case Me.iUserLevelID
                        Case eUserLevel.Developer
                            'these users are allowed to login
                            bSecurityPass = True
                        Case eUserLevel.Rep, eUserLevel.Agent, eUserLevel.Manager
                            'these users are not allowed to login
                            bSecurityPass = False
                        Case Else
                            Dim aWobbler As New Exception("Unsupported Userlevel during Login: " & iUserLevelID.ToString)
                            Throw aWobbler

                            bSecurityPass = False
                    End Select
                Case Else
                    Dim aWobbler As New Exception("Unsupported Application during Login: " & Application.ToString)
                    Throw aWobbler
            End Select
        End If



        If bSecurityPass = False Then
            'user was not allowed to login to this application
            'log this event

            Params = New Collection

            aParam = New SqlClient.SqlParameter("@Username", SqlDbType.NVarChar)
            aParam.Value = Username
            Params.Add(aParam)

            aParam = New SqlClient.SqlParameter("@UserLevel", SqlDbType.Int)
            aParam.Value = Me.iUserLevelID
            Params.Add(aParam)

            aParam = New SqlClient.SqlParameter("@Application", SqlDbType.NVarChar)
            aParam.Value = Application.ToString
            Params.Add(aParam)


            Database.ExecuteSPNoQuery("spUserLoginSecurityFail", Params)

            bLoggedIn = False
        End If

        Return bLoggedIn

    End Function


    Public ReadOnly Property FirstName() As String
        Get
            Dim array() As String
            array = RealName.Split(" ")
            Return array(0)
        End Get
    End Property







End Class
