Imports System.Data.SqlClient

Public Class cArea

    'represents a geographical area
    'which will consist of a collection of PostCodePrefixes.



    Private iID As Integer = -1
    Private sTitle As String = ""
    Private iRepID As Integer = -1
    Private sRepName As String = ""
    Private bNoColdCalls As Boolean = False
    Private bIsDirty As Boolean = False




    Public Sub New()

    End Sub
    Public Sub New(ByVal Row As DataRow)
        Load(Row)
    End Sub
    Public Sub New(ByVal AreaID As Integer)
        Load(AreaID)
    End Sub

    Private oPostCodes As cPostCodes
    Public ReadOnly Property PostCodes() As cPostCodes
        Get
            If opostcodes Is Nothing Then
                Return New cPostCodes(iID)
            End If
            Return oPostCodes
        End Get
    End Property


    Public ReadOnly Property ID() As Integer
        Get
            'id is allocated by the database so cannot be changed.
            ID = iID
        End Get
    End Property

    Public Property Title() As String
        Get
            Title = Common.StringManipulation.TitleCase(sTitle)
        End Get
        Set(ByVal value As String)
            If value <> sTitle Then
                'todo Area.Title - add uniqueness check 
                sTitle = value
                bIsDirty = True
            End If
        End Set
    End Property

    Public ReadOnly Property NoColdCalls As String
        Get
            If bNoColdCalls Then
                Return "Y"
            Else
                Return ""
            End If
        End Get

    End Property

    Public Sub ToggleNoColdCalls()
        bNoColdCalls = Not bNoColdCalls
    End Sub


    Public ReadOnly Property RepName() As String
        Get
            RepName = sRepName
        End Get
    End Property


    Private Sub Load(ByVal Row As DataRow)

        iID = Row.Item("ID")
        sTitle = Row.Item("Title").ToString
        If Row.Item("RepID") Is DBNull.Value Then
            iRepID = 0
        Else
            iRepID = Row.Item("RepID")
        End If

        If Row.Item("Realname") Is DBNull.Value Then
            sRepName = ""
        Else
            sRepName = Row.Item("RealName").ToString()
        End If

        bNoColdCalls = Row.Item("NoColdCalls")

        bIsDirty = False

    End Sub
    Private Sub Load(ByVal AreaID As Integer)

        Dim Params As New Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.CreateParameter(Params, "@AreaID", SqlDbType.Int, AreaID)


        Dim DS As DataSet = Database.ExecuteSP("spAreaGet", Params)

        Load(DS.Tables(0).Rows(0))

    End Sub

    Private Function TitleInUse(ByVal TitleToTest As String) As Boolean

        Dim sSQL As String = "select dbo.IsAreaUnique('" & TitleToTest & "', " & iID & ") as Result"
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows(0).Item("Result") = 1 Then
            TitleInUse = False
        Else
            TitleInUse = True
        End If

    End Function


    Public Function CleanAndTestName(ByRef NameToTest As String) As String

        'test to see if the (proposed) name for the area is acceptable

        'first, clean up the input string

        Dim sNameToTest As String = NameToTest.Trim
        sNameToTest = Common.RemoveNonAlphaNumerics(sNameToTest)

        If TitleInUse(sNameToTest) Then
            CleanAndTestName = ""
        Else
            CleanAndTestName = sNameToTest
        End If

    End Function

    Public Sub Save()
        'save the area back into the database
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim Params As New Collection
        Dim paramID As New SqlParameter("@ID", SqlDbType.Int)
        paramID.Value = iID
        Params.Add(paramID)

        Dim paramTitle As New SqlParameter("@Title", SqlDbType.NVarChar)
        paramTitle.Value = Common.StringManipulation.TitleCase(sTitle)
        Params.Add(paramTitle)

        Database.CreateParameter(Params, "@NoColdCalls", SqlDbType.Bit, bNoColdCalls)

        Dim DS As DataSet = Database.ExecuteSP("spAreaSave", Params)

        iID = DS.Tables(0).Rows(0).Item("ID")
        bIsDirty = False

    End Sub

    Public Sub RemovePostcode(ByVal ID As Integer)
        'remove the postcode from the area (but not the database)

        Dim Params As New Collection

        Dim parPostcodeID As New SqlParameter("@PostcodeID", SqlDbType.Int)
        parPostcodeID.Value = ID
        Params.Add(parPostcodeID)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spAreaPostcodeRemove", Params)

        Me.oPostCodes = Nothing

    End Sub

    Public Sub Remove()
        'remove the area from the database

        Dim Params As New Collection

        Dim parID As New SqlClient.SqlParameter("@AreaID", SqlDbType.Int)
        parID.Value = iID
        Params.Add(parID)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.ExecuteSPNoQuery("spAreaRemove", Params)

    End Sub
End Class
