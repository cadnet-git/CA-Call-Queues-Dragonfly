Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting.Channels
Imports System.Net.Http

Public Class cAgentApp

    Public CurrentUser As New Common.cUser
    Private iDeskID As Integer

    Private Event Alert(ByVal Title As String, ByVal Description As String)
    Private Event Info(ByVal Title As String, ByVal Description As String)

    Public Event UpdateAliveCount(ByVal iCount As Integer)
    Public Settings As Common.cSettings

#Region "Singleton support"

    Private Shared Instance As cAgentApp


    Public Shared Function GetInstance() As cAgentApp
        If Instance Is Nothing Then
            Instance = New cAgentApp
        End If
        Return Instance
    End Function
#End Region

    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean

        Login = CurrentUser.Login(Username, Password, Common.eApplications.Agent)

    End Function

    Public ReadOnly Property User() As Common.cUser
        Get
            User = CurrentUser
        End Get
    End Property

    Public Property Attempts As Integer

    Public Function GetNextCompany() As Common.cCompany
        Settings = New Common.cSettings
        Dim Database As New Common.DataLayer
        Dim DS As DataSet

        Dim storeText As String = frmAgent.Text
        Dim count As Integer = 0
        Do While True
            Try
                Dim Params As New Collection
                Database.CreateParameter(Params, "@UserID", SqlDbType.Int, CurrentUser.ID)
                DS = Database.ExecuteSP("spGetCompanyToCall", Params)
            Catch ex As Exception
                Dim aWobbler As New Exception("Error " & ex.Message)
                Throw aWobbler
            End Try

            count = count + 1
            frmAgent.Text = String.Format("{0} Checking Company - {1}", storeText, count)
            Application.DoEvents()

            If DS.Tables(0).Rows.Count = 0 Then
                Dim aWobbler As New Exception("No more Companies to call")
                Throw aWobbler
            Else
                Dim aCompany As New Common.cCompany(DS.Tables(0).Rows(0), DS.Tables(1))

                If aCompany.TPSUntil < Now Then
                    Dim result As String = CheckTPSOK(aCompany.Telephone)

                    Select Case result
                        Case "safe"
                            Database.ExecuteSQL(String.Format("INSERT into Tracker (CompanyID,Telephone,Path,TPS) values ({0},'{1}','Checked','OK')", aCompany.ID, aCompany.Telephone))
                            aCompany.TPSUntil = Now.AddDays(28)
                            aCompany.Save()
                            Return aCompany
                            Exit Do
                        Case "listed"
                            Database.ExecuteSQL(String.Format("INSERT into Tracker (CompanyID,Telephone,Path,TPS) values ({0},'{1}','Checked','TPS')", aCompany.ID, aCompany.Telephone))
                            aCompany.ThisCall.EndCallTPS()
                        Case Else
                            Database.ExecuteSQL(String.Format("INSERT into Tracker (CompanyID,Telephone,Path,TPS) values ({0},'{1}','Checked','No answer from TPS service')", aCompany.ID, aCompany.Telephone))
                            aCompany.ThisCall.EndCallReschedule(Now.AddDays(1), "TPS Error = " & result)
                            MsgBox("TPS Error = " & result & "  -  Telephone =  " & aCompany.Telephone)
                    End Select
                Else
                    Database.ExecuteSQL(String.Format("INSERT into Tracker (CompanyID,Telephone,Path,TPS) values ({0},'{1}','TPS until in the future','')", aCompany.ID, aCompany.Telephone))
                    Return aCompany
                    Exit Do

                End If

            End If
        Loop


    End Function

    Public Function GetDatabaseName() As String
        Dim Database As New Common.DataLayer
        Database.ExecuteSQL("Select * from Users")

        Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()

        builder.ConnectionString = Database.sCS

        ' String server = builder["Data Source"] as string;
        Dim DatabaseName As String = builder("Initial Catalog")
        Return DatabaseName

    End Function

    Public Function CheckTPSOK(ByVal tel As String) As String

        Dim Url As String = "https://121prodata.co.uk/api/?token=bbb52011d26cc445530e812c69d85443&number=" & tel & "&output=text"
        Dim s As String
        Using _http As HttpClient = New HttpClient()
            s = _http.GetStringAsync(Url).Result
        End Using

        Diagnostics.Debug.WriteLine("s = " & s)

        Return s
    End Function
#Region "desk"

    Public Property DeskID() As Integer
        Get
            DeskID = iDeskID
        End Get
        Set(ByVal value As Integer)
            iDeskID = value
        End Set
    End Property
    Public Sub UpdateDeskStatus(ByVal Status As String)

        Dim Database As New Common.DataLayer

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@DeskID", SqlDbType.Int)
        parDeskID.Value = DeskID
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@Status", SqlDbType.NVarChar)
        parStatus.Value = Status
        Params.Add(parStatus)

        Dim DS As DataSet = Database.ExecuteSP("spSetDeskStatus", Params)


    End Sub
    Public Sub UpdateDeskTelephone(ByVal Telephone As String)

        Dim Database As New Common.DataLayer

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@DeskID", SqlDbType.Int)
        parDeskID.Value = DeskID
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@Telephone", SqlDbType.NVarChar)
        parStatus.Value = Telephone
        Params.Add(parStatus)

        Dim DS As DataSet = Database.ExecuteSP("spSetDeskTelephone", Params)


    End Sub
    Public Sub UpdateDeskUser(ByVal UserID As Integer)

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@DeskID", SqlDbType.Int)
        parDeskID.Value = DeskID
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@UserID", SqlDbType.NVarChar)
        parStatus.Value = UserID
        Params.Add(parStatus)

        Dim Database As New Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spSetDeskUser", Params)


    End Sub
    Public Sub UpdateDeskCalls(ByVal UserID As Integer)

        Dim Database As New Common.DataLayer

        Dim Params As New Collection

        With Database
            .CreateParameter(Params, "@DeskID", SqlDbType.Int, DeskID)
            .CreateParameter(Params, "@UserID", SqlDbType.Int, UserID)
            .CreateParameter(Params, "@StartTime", SqlDbType.NVarChar, Now.ToLongDateString & " 00:00:01")

            '  Try
            .ExecuteSPNoQuery("spSetDeskCalls", Params)
            '  Catch ex As Exception

            '  End Try
        End With


    End Sub
    Public Sub CloseDesk()
        Dim Database As New Common.DataLayer
        Database.ExecuteSQL("UPDATE Desks Set Agent=-1,Status='',Telephone='', calls=0, apps=0 where ID=" & DeskID)
    End Sub
#End Region


    Public Sub WriteAgentEvent(ByVal theEvent As String)
        Dim params As New Collection
        Dim Database As New Common.DataLayer
        With Database
            .CreateParameter(params, "@AgentID", SqlDbType.Int, CurrentUser.ID)
            .CreateParameter(params, "@Event", SqlDbType.NVarChar, theEvent)
            Try
                .ExecuteSPNoQuery("spCreateAgentEvent", params)
            Catch ex As Exception
                MsgBox("spCreateAgentEvent - " & ex.Message)
            End Try
        End With


    End Sub

End Class
