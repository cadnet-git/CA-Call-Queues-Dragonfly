'Imports System.Runtime.Remoting
'Imports System.Runtime.Remoting.Channels.Tcp
'Imports System.Runtime.Remoting.Channels


Public Class cManagerApp

    Private oCurrentUser As New Common.cUser
    
    Private oAreas As cAreas

#Region "Singleton Behaviour"

    Private Shared _Instance As cManagerApp

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As cManagerApp
        If _Instance Is Nothing Then
            _Instance = New cManagerApp
        End If

        GetInstance = _Instance
    End Function
#End Region


    Public ReadOnly Property CurrentUser() As Common.cUser
        Get
            CurrentUser = oCurrentUser
        End Get
    End Property
    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean

        Login = oCurrentUser.Login(Username, Password, Common.eApplications.ManagementConsole)

    End Function

    Public ReadOnly Property Areas() As cAreas
        Get
            If oAreas Is Nothing Then
                oAreas = New cAreas
            End If

            Areas = oAreas
        End Get
    End Property


    Public Sub AddManagerNote(Note As String, CompanyID As Integer, AgentID As Integer)
        Dim d As New CADNet.CallQueues.Common.DataLayer
        Dim params As New Collection
        d.CreateParameter(params, "@UserID", SqlDbType.Int, CurrentUser.ID)
        d.CreateParameter(params, "@CompanyID", SqlDbType.Int, CompanyID)
        d.CreateParameter(params, "@Note", SqlDbType.NVarChar, Note)
        d.CreateParameter(params, "@AgentID", SqlDbType.Int, AgentID)
        d.ExecuteSPNoQuery("spAddManagerNote", params)
    End Sub

    '  Dim listenform As FrmListenToCalls
    Public Sub ShowListenerForm(Company As Common.cCompany)
        ' If listenform Is Nothing Then
        '     listenform = New FrmListenToCalls
        ' End If
        ' listenform.LoadGrid(Company)
        ' listenform.Show()
    End Sub

    Public Function GetDatabaseName() As String
        Dim Database As New Common.DataLayer
        Database.ExecuteSQL("Select * from Users")

        Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()

        builder.ConnectionString = Database.sCS

        ' String server = builder["Data Source"] as string;
        Dim DatabaseName As String = builder("Initial Catalog")
        Return DatabaseName

    End Function
End Class
