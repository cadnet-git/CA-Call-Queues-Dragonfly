Imports System.Data.SqlClient
Imports System.Linq

Public Class cPostCodes

    'Private Class cPostCodeComparer
    '    Implements IComparer(Of cPostCode)

    '    Public Function Compare(ByVal x As cPostCode, ByVal y As cPostCode) As Integer Implements IComparer(Of cPostCode).Compare

    '        If x Is Nothing AndAlso y Is Nothing Then
    '            Return 0
    '        ElseIf x Is Nothing And Not y Is Nothing Then
    '            Return 1
    '        ElseIf Not x Is Nothing And y Is Nothing Then
    '            Return -1
    '        Else
    '            Return String.Compare(x.Prefix, y.Prefix)
    '        End If
    '    End Function

    'End Class

    Public Event LoadStarted()
    Public Event LoadCompleted()
    Public Event LoadProgress(ByVal Total As Integer, ByVal Loaded As Integer)

    Public Event Update()   'this event will be used to tell the ui to update/refresh lists etc.

    Private bLoaded As Boolean = False
    Private _PostCodes As List(Of cPostCode)

    Private iAreaID As Integer = -1

    Public Sub New()
        'will just load all of the postcodes into the collection
        iAreaID = 0
    End Sub
    Public Sub New(ByVal AreaID As Integer)
        'only load the postcodes assigned to this area
        iAreaID = AreaID
    End Sub

    Public ReadOnly Property PostCodes() As List(Of cPostCode)
        Get
            If bLoaded = False Then
                Load()
            End If
            Return _PostCodes
        End Get
    End Property

    'Public Function Find(ByVal Prefix As String) As cPostCode
    '    'find the matching post code object (if any)
    '    ' Dim bFound As Boolean = False

    '    '  Find = Nothing
    '    Dim result As cPostCode = oObjects.Where(Function(c) c.Prefix = Prefix).FirstOrDefault()

    '    If (result Is Nothing) Then

    '    End If


    '    For Each aPostcode As cPostCode In oObjects
    '        If String.Compare(aPostcode.Prefix, Prefix, True) = 0 Then
    '            '      bFound = True
    '            '       Find = aPostcode
    '            Exit For
    '        End If
    '    Next

    'End Function

    'Public Sub Add(ByVal aPostCode As cPostCode)

    '    'we only need to add it if it doesnot already exist in the list

    '    If oObjects.Contains(aPostCode) = False Then
    '        oObjects.Add(aPostCode)
    '    End If

    '    RaiseEvent Update()

    'End Sub

    'Public Function Create(ByVal Prefix As String) As cPostCode
    '    'creates an area object but does not save it.
    '    'does not test that it is acceptable!
    '    'does not add it to the list (how to do this correctly?)

    '    Dim anObject As New cPostCode
    '    anObject.Prefix = Prefix

    '    Return anObject

    'End Function

    'Public Sub Refresh()
    '    'do we need to load data?
    '    If bLoaded = False Then
    '        Load()
    '    Else
    '        'data is loaded, so just issue and update event
    '        RaiseEvent Update()
    '    End If

    'End Sub

    Private Sub Load()
        'load all the objects from the database

        RaiseEvent LoadStarted()

        Dim DS As DataSet

        Dim Database As New Common.DataLayer

        If iAreaID < 1 Then
            'load all postcodes
            DS = Database.ExecuteSP("spPostCodesGet")
        Else
            'only load the post code for the area
            Dim Params As New Collection
            Dim parID As New SqlParameter("@AreaID", SqlDbType.Int)
            parID.Value = iAreaID
            Params.Add(parID)
            DS = Database.ExecuteSP("spAreaPostcodesGet", Params)
        End If

        _PostCodes = New List(Of cPostCode)

        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anObject As New cPostCode(aRow)
            _PostCodes.Add(anObject)
        Next

        bLoaded = True

        RaiseEvent LoadCompleted()
        RaiseEvent Update()

    End Sub
End Class
