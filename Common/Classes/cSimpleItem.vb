Public Class cSimpleItem

    Private sTitle As String = ""
    Private oValue As Object = Nothing

    Public Sub New(ByVal Value As Object, ByVal Title As String)
        sTitle = Title
        oValue = Value
    End Sub

    Public Property Value() As Object
        Get
            Value = oValue
        End Get
        Set(ByVal InValue As Object)
            oValue = InValue
        End Set
    End Property
    Public Property Title() As String
        Get
            Title = sTitle
        End Get
        Set(ByVal value As String)
            sTitle = value
        End Set
    End Property

End Class
