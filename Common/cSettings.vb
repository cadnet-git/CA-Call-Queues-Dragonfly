Public Class cSettings
    Private sEmailUser As String
    Private sEmailPassword As String
    Private sSMTPServer As String
    Private sLogoPath As String
    Private sFaxServer As String
    Private sPCAccount As String
    Private sPCCode As String
    Private iDiaryShowWeeks As Integer

     Public ReadOnly Property DiaryShowWeeks() As Integer
        Get
            DiaryShowWeeks = iDiaryShowWeeks
        End Get
    End Property
    Public ReadOnly Property PCCode() As String
        Get
            PCCode = sPCCode
        End Get
    End Property

    Public ReadOnly Property PCAccount() As String
        Get
            PCAccount = sPCAccount
        End Get
    End Property

    Public ReadOnly Property EmailUser() As String
        Get
            EmailUser = sEmailUser
        End Get
    End Property
    Public ReadOnly Property EmailPassword() As String
        Get
            EmailPassword = sEmailPassword
        End Get
    End Property

    Public ReadOnly Property SMTPServer() As String
        Get
            SMTPServer = sSMTPServer
        End Get
    End Property

    Public ReadOnly Property LogoPath() As String
        Get
            LogoPath = sLogoPath
        End Get
    End Property
    Public ReadOnly Property FaxServer() As String
        Get
            FaxServer = sFaxServer
        End Get
    End Property
    Public Sub New()
        Dim Database As New Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL("Select * from Settings")
        Dim DR As DataRow
        DR = DS.Tables(0).Rows(0)
        sEmailUser = DR("Emailuser")
        sEmailPassword = DR("EmailPassword")
        sSMTPServer = DR("SMTPServer")
        sLogoPath = DR("LogoPath")
        sFaxServer = DR("FaxServer")
        sPCCode = DR("PCCode")
        sPCAccount = DR("PCAccount")
        iDiaryShowWeeks = DR("DiaryShowWeeks")
    End Sub
End Class
