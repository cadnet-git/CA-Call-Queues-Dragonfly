Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class cPostCode

    'represents a postcode area (well the first half of the post code)

    Private iID As Integer = -1
    Private sPrefix As String = ""
    Private iAreaID As Integer = -1 'the area that this post code is assigned to

    Private bIsDirty As Boolean = False

    Public Sub New()
        iID = 0
        sPrefix = ""
        iAreaID = 0
        bIsDirty = True
    End Sub
    Public Sub New(ByVal aRow As DataRow)
        iID = aRow.Item("ID")
        sPrefix = aRow.Item("Prefix").ToString.ToUpper
        If IsDBNull(aRow.Item("areaid")) Then
            iAreaID = 0
        Else
            iAreaID = aRow.Item("AreaID")
        End If

        bIsDirty = False
    End Sub
    Public Sub New(ByVal Prefix As String)
        iID = -1
        sPrefix = Common.RemoveNonAlphaNumerics(Prefix)
        bIsDirty = False

        Load()

    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            'id is allocated by the database so cannot be changed.
            ID = iID
        End Get
    End Property

    Public Property Prefix() As String
        Get
            Prefix = sPrefix.ToUpper
        End Get
        Set(ByVal value As String)
            If value <> sPrefix Then
                'todo PostCode.Prefix - add uniqueness check 
                sPrefix = value.ToUpper
                bIsDirty = True
            End If
        End Set
    End Property

    Public Property AreaID() As Integer
        Get
            AreaID = iAreaID
        End Get
        Set(ByVal value As Integer)
            If value <> AreaID Then
                iAreaID = value
                bIsDirty = True
            End If
        End Set
    End Property

    Public ReadOnly Property Area() As cArea
        Get
            Dim oArea As New cArea(iAreaID)
            Area = oArea
        End Get
    End Property


    Private Function PrefixInUse() As Boolean

        Dim sSQL As String = "select dbo.IsPostCodeUnique('" & sPrefix & "', " & iID.ToString & ") as Result"
        Dim Database As New Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows(0).Item("Result") = 1 Then
            PrefixInUse = False
        Else
            PrefixInUse = True
        End If

    End Function



    Public Function Exists() As Boolean
        'does this postcode exist in the database under a different id

        If PrefixInUse() Then
            Exists = True
        Else
            Exists = False
        End If

    End Function

    Public Function PrefixTest() As String
        'test to see if the name for the area is acceptable
        Dim sTestName As String = ""

        'check to see if the title is already in use
        If PrefixInUse() Then
            sTestName = "* Postcode already in use"
        End If

        Return sTestName

    End Function

    Private Sub Load()
        'try to load the postcode from the database (it may not exisit yet)

        Dim sSQL As String = ""
        If iID < 1 Then
            sSQL = "select * from PostcodePrefixes where prefix='" & sPrefix & "'"
        Else
        End If

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows.Count > 1 Then
            'too many rows found
            Dim aWobbler As New Exception("Multiple rows found for postcode " & sPrefix)
            Throw aWobbler
            Exit Sub
        ElseIf DS.Tables(0).Rows.Count = 1 Then
            'found it!
            Dim aRow As DataRow = DS.Tables(0).Rows(0)
            iID = aRow.Item("ID")
            sPrefix = aRow.Item("Prefix").ToString.ToUpper
            If IsDBNull(aRow.Item("areaid")) Then
                iAreaID = 0
            Else
                iAreaID = aRow.Item("AreaID")
            End If

            bIsDirty = False
        Else
            'no post code found
            iID = -1
        End If
    End Sub

    Public Sub Save()
        'save the postcode back into the database

        Dim Params As New Collection

        Dim paramID As New SqlParameter("@ID", SqlDbType.Int)
        paramID.Value = iID
        Params.Add(paramID)

        Dim paramPrefix As New SqlParameter("@Prefix", SqlDbType.NVarChar)
        paramPrefix.Value = sPrefix
        Params.Add(paramPrefix)

        Dim paramAreaID As New SqlParameter("@AreaID", SqlDbType.Int)
        If iAreaID = 0 Then
            paramAreaID.Value = DBNull.Value 'we can set the field to null, but not to zero (not matching record)
        Else
            paramAreaID.Value = iAreaID
        End If
        Params.Add(paramAreaID)

        Params.Add(New SqlParameter("@ImportBatchID", 0))

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spPostCodeSave", Params)

        iID = DS.Tables(0).Rows(0).Item("ID")
        bIsDirty = False

    End Sub

End Class
