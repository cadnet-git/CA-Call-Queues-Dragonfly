Public Class cPhoneQuote
    Public Enum PhoneQuoteStatus
        New_Quote
        Quoted
        With_Feedback
        Sale
        Complete
        Dead
    End Enum

    Private iID As Integer
    Public Property ID() As Integer
        Get
            Return iID
        End Get
        Set(ByVal value As Integer)
            iID = value
        End Set
    End Property

    Private cRep As CADNet.CallQueues.Common.cUser
    Public Property Rep() As CADNet.CallQueues.Common.cUser
        Get
            Return cRep
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cUser)
            cRep = value
        End Set
    End Property

    Private cAgent As CADNet.CallQueues.Common.cUser
    Public Property Agent() As CADNet.CallQueues.Common.cUser
        Get
            Return cAgent
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cUser)
            cAgent = value
        End Set
    End Property

    Private cSup As CADNet.CallQueues.Common.cUser
    Public Property Sup() As CADNet.CallQueues.Common.cUser
        Get
            Return cSup
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cUser)
            cSup = value
        End Set
    End Property
    Private eStatus As PhoneQuoteStatus
    Public Property Status() As PhoneQuoteStatus
        Get
            Return eStatus
        End Get
        Set(ByVal value As PhoneQuoteStatus)
            eStatus = value
        End Set
    End Property

    Private cCompany As CADNet.CallQueues.Common.cCompany
    Public Property Company() As CADNet.CallQueues.Common.cCompany
        Get
            Return cCompany
        End Get
        Set(ByVal value As CADNet.CallQueues.Common.cCompany)
            cCompany = value
        End Set
    End Property

    Private sFeedback As String
    Public Property Feedback() As String
        Get
            Return sFeedback
        End Get
        Set(ByVal value As String)
            sFeedback = value
        End Set
    End Property


    Private dFeedbackDate As DateTime
    Public Property FeedBackDate() As DateTime
        Get
            Return dFeedbackDate
        End Get
        Set(ByVal value As DateTime)
            dFeedbackDate = value
        End Set
    End Property


    Private iAppID As Integer
    Public Property AppID() As Integer
        Get
            Return iAppID
        End Get
        Set(ByVal value As Integer)
            iAppID = value
        End Set
    End Property

    Public Sub load(ByVal ID As Integer)
        Dim Database As New Common.DataLayer
        Dim DS As DataSet
        DS = Database.ExecuteSQL("SELECT * from PhoneQuotes where ID=" & ID)
        load(DS.Tables(0).Rows(0))
    End Sub

    Public Sub load(ByVal DR As DataRow)
        Me.cAgent.Load(DR("AgentID"))
        Me.cRep.Load(DR("RepID"))
        Me.cSup.Load(DR("SupID"))
        Me.cCompany = New Common.cCompany(DR("CompanyID"))
        Me.Feedback = DR("FeedBack")
        If DR.IsNull("FeedbackDate") = False Then
            Me.FeedBackDate = DR("FeedbackDate")
        End If
        AppID = DR("AppID")
    End Sub
    Public Sub Save()
        Dim database As New Common.DataLayer
        Dim params As New Collection
        With database
            .CreateParameter(params, "@ID", SqlDbType.Int, iID)
            .CreateParameter(params, "@AgentID", SqlDbType.Int, cAgent.ID)
            .CreateParameter(params, "@RepID", SqlDbType.Int, cRep.ID)
            .CreateParameter(params, "@CompanyID", SqlDbType.Int, cCompany.ID)
            .CreateParameter(params, "@AppID", SqlDbType.Int, iAppID)
            .CreateParameter(params, "@FeedBack", SqlDbType.NVarChar, sFeedback)
            .CreateParameter(params, "@FeedBackDate", SqlDbType.DateTime, dFeedbackDate)
            .CreateParameter(params, "@Status", SqlDbType.NVarChar, eStatus.ToString)
            .CreateParameter(params, "@SupID", SqlDbType.Int, cSup.ID)
        End With
        Dim ds As DataSet
        DS = database.ExecuteSP("spSavePhoneQuote", params)
        load(DS.Tables(0).Rows(0))
    End Sub
End Class
