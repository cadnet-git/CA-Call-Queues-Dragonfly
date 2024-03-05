Imports System.Data.SqlClient

Public Class cAreas

    Public Event LoadStarted()
    Public Event LoadCompleted()
    Public Event LoadProgress(ByVal Total As Integer, ByVal Loaded As Integer)

   

    Private bLoaded As Boolean = False
    Private oObjects As System.Collections.Generic.List(Of cArea)

    Public ReadOnly Property Areas() As System.Collections.Generic.List(Of cArea)
        'would like this to be a default property, but aint sure how to do it!
        'the default keyword requires paramamters, but dont know how this would affect the list
        Get
            If bLoaded = False Then
                Load()
            End If
            Areas = oObjects
        End Get
    End Property

    Public Function Find(ByVal AreaID As Integer) As cArea

        Find = Nothing

        For Each anArea As cArea In oObjects
            If anArea.ID = AreaID Then
                Find = anArea
                Exit For
            End If
        Next
    End Function
    Public Sub Add(ByVal anArea As cArea)

        'we only need ot add it if it doesnot already exist in the list

        If oObjects.Contains(anArea) = False Then
            oObjects.Add(anArea)
        End If

    End Sub

    Public Function CreateArea(ByVal Title As String) As cArea
        'creates an area object but does not save it.

        'does not test that it is acceptable!
        
        Dim anArea As New cArea
        anArea.Title = Title
        anArea.Save()
        Refresh()

        Return anArea

    End Function

    Public Sub Refresh()
        'do we need to load data?
        Load()


    End Sub

    Private Sub Load()
        'load all the areas from the database

        RaiseEvent LoadStarted()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spAreasGet")

        'now we have the ds we can start to create the objects
        Dim iCount As Integer = 0
        Dim iTotal As Integer = DS.Tables(0).Rows.Count

        oObjects = New System.Collections.Generic.List(Of cArea)

        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anArea As New cArea(aRow)

            oObjects.Add(anArea)

            iCount += 1
            RaiseEvent LoadProgress(iTotal, iCount)
        Next

        Me.bLoaded = True

        RaiseEvent LoadCompleted()


    End Sub
End Class
