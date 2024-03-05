Public Class cDesk

    Private iID As Integer
    Private sFriendlyName As String
    Private sTerminalName As String
    Private sExtension As String

    Private bIsDirty As Boolean = False

    Public Sub New()
        iID = 0
        sFriendlyName = ""
        sTerminalName = ""
        sExtension = ""

        bIsDirty = False

    End Sub
    Public Sub New(ByVal aRow As DataRow)

        Load(aRow)

    End Sub
    Public ReadOnly Property ID() As Integer
        Get
            ID = iID
        End Get
    End Property
    Public Property FriendlyName() As String
        Get
            FriendlyName = sFriendlyName
        End Get
        Set(ByVal value As String)
            If value <> sFriendlyName Then
                sFriendlyName = value
                bIsDirty = True
            End If
        End Set
    End Property
    Public Property TerminalName() As String
        Get
            TerminalName = sTerminalName
        End Get
        Set(ByVal value As String)
            If value <> sTerminalName Then
                sTerminalName = value
                bIsDirty = True
            End If
        End Set
    End Property
    Public Property Extension() As String
        Get
            Extension = sExtension
        End Get
        Set(ByVal value As String)
            If value <> sExtension Then
                sExtension = value
                bIsDirty = True
            End If
        End Set
    End Property
    Private Sub Load(ByVal aRow As DataRow)
        iID = aRow.Item("ID")
        sFriendlyName = aRow.Item("FriendlyName")
        sTerminalName = aRow.Item("TerminalName")
        sExtension = aRow.Item("Extension")

        bIsDirty = False

    End Sub
    Public Sub Save()
        Dim Params As New Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        With Database
            .CreateParameter(Params, "@ID", SqlDbType.Int, iID)
            .CreateParameter(Params, "@FriendlyName", SqlDbType.NVarChar, sFriendlyName)
            .CreateParameter(Params, "@TerminalName", SqlDbType.NVarChar, sTerminalName)
            .CreateParameter(Params, "@Extension", SqlDbType.NVarChar, sExtension)

            Dim DS As DataSet = .ExecuteSP("spDeskSave", Params)
            Load(DS.Tables(0).Rows(0))
        End With

    End Sub
End Class
