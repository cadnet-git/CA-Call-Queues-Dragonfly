Imports Microsoft.VisualBasic

Public Class Feedback

    Private iID As Integer
 


    Public Property ID() As Integer
        Get
            Return iID
        End Get
        Set(ByVal value As Integer)
            iID = value
        End Set
    End Property


    Private bSat As Boolean
    Public Property Sat() As Boolean
        Get
            Return bSat
        End Get
        Set(ByVal value As Boolean)
            bSat = value
        End Set
    End Property

    Private sReasonNotSat As String = ""
    Public Property ReasonNotSat() As String
        Get
            Return sReasonNotSat
        End Get
        Set(ByVal value As String)
            sReasonNotSat = value
        End Set
    End Property


    Private sContact As String = ""
    Public Property Contact() As String
        Get
            Return sContact
        End Get
        Set(ByVal value As String)
            sContact = value
        End Set
    End Property


    Private sPosition As String = ""
    Public Property Position() As String
        Get
            Return sPosition
        End Get
        Set(ByVal value As String)
            sPosition = value
        End Set
    End Property

    Private bInvolvedInPMI As Boolean
    Public Property InvolvedInPMI() As Boolean
        Get
            Return bInvolvedInPMI
        End Get
        Set(ByVal value As Boolean)
            bInvolvedInPMI = value
        End Set
    End Property

    Private sRenewalDate As String = ""
    Public Property RenewalDate() As String
        Get
            Return sRenewalDate
        End Get
        Set(ByVal value As String)
            sRenewalDate = value
        End Set
    End Property

    Private sProvider As String = ""
    Public Property Provider() As String
        Get
            Return sProvider
        End Get
        Set(ByVal value As String)
            sProvider = value
        End Set
    End Property


    Private sOutCome As String = ""
    Public Property OutCome() As String
        Get
            Return sOutCome
        End Get
        Set(ByVal value As String)
            sOutCome = value
        End Set
    End Property


    Private sNote As String = ""
    Public Property Note() As String
        Get
            Return sNote
        End Get
        Set(ByVal value As String)
            sNote = value
        End Set

    End Property



    Private bIsSale As Boolean = False
    Public Property isSale() As Boolean
        Get
            Return bIsSale
        End Get
        Set(ByVal value As Boolean)
            bIsSale = value
        End Set
    End Property


    Private sValue As String = ""
    Public Property Value() As String
        Get
            Return sValue
        End Get
        Set(ByVal value As String)
            sValue = value
        End Set
    End Property


    Private sSoldDate As String = ""
    Public Property SoldDate() As String
        Get
            Return sSoldDate
        End Get
        Set(ByVal value As String)
            sSoldDate = value
        End Set
    End Property


    Private sStartDate As String = ""
    Public Property StartDate() As String
        Get
            Return sStartDate
        End Get
        Set(ByVal value As String)
            sStartDate = value
        End Set
    End Property


    Private sSaleType As String = ""
    Public Property SaleType() As String
        Get
            Return sSaleType
        End Get
        Set(ByVal value As String)
            sSaleType = value
        End Set
    End Property

    '**************************************************************************************

    Private sNextContact As String = ""
    Public Property NextContact() As String
        Get
            Return sNextContact
        End Get
        Set(ByVal value As String)
            sNextContact = value
        End Set
    End Property

    Private sPreviousProvider As String = ""
    Public Property PreviousProvider() As String
        Get
            Return sPreviousProvider
        End Get
        Set(ByVal value As String)
            sPreviousProvider = value
        End Set
    End Property
    Private sPMINotPresented As String = ""
    Public Property PMINotPresented() As String
        Get
            Return sPMINotPresented
        End Get
        Set(ByVal value As String)
            sPMINotPresented = value
        End Set
    End Property



    Private sLifeOutCome As String = ""
    Public Property LifeOutCome() As String
        Get
            Return sLifeOutCome
        End Get
        Set(ByVal value As String)
            sLifeOutCome = value
        End Set
    End Property

    Private sLifeNextContact As String = ""
    Public Property LifeNextContact() As String
        Get
            Return sLifeNextContact
        End Get
        Set(ByVal value As String)
            sLifeNextContact = value
        End Set
    End Property
    Private _lifeNotPresented As String = ""
    Property LifeNotPresented As String
        Get
            Return _lifeNotPresented
        End Get
        Set(value As String)
            _lifeNotPresented = value
        End Set
    End Property
    Private _lifeValue As String = ""

    Property LifeValue As String
        Get
            Return _lifeValue
        End Get
        Set(value As String)
            _lifeValue = value
        End Set
    End Property
    Private _lifeStartDate As String = ""

    Property LifeStartDate As String
        Get
            Return _lifeStartDate
        End Get
        Set(value As String)
            _lifeStartDate = value
        End Set
    End Property
    Private _lifeSoldDate As String = ""
    Property LifeSoldDate As String
        Get
            Return _lifeSoldDate
        End Get
        Set(value As String)
            _lifeSoldDate = value
        End Set
    End Property




    Public Sub Save(ByVal LoggedOnUserID As Integer)
        Dim db As New CADNet.CallQueues.Common.DataLayer
        Dim FBParams As New Collection
        db.CreateParameter(FBParams, "@ID", Data.SqlDbType.Int, ID)
        db.CreateParameter(FBParams, "@FBAppSat", Data.SqlDbType.Int, bSat)
        db.CreateParameter(FBParams, "@FBInvolvedPMI", Data.SqlDbType.Int, bInvolvedInPMI)
        db.CreateParameter(FBParams, "@FBContact", Data.SqlDbType.NVarChar, sContact)
        db.CreateParameter(FBParams, "@FBPosition", Data.SqlDbType.NVarChar, sPosition)
        db.CreateParameter(FBParams, "@FBProvider", Data.SqlDbType.NVarChar, sProvider)
        db.CreateParameter(FBParams, "@FBRenewal", Data.SqlDbType.NVarChar, sRenewalDate)
        db.CreateParameter(FBParams, "@FBNote", Data.SqlDbType.NVarChar, sNote)
        db.CreateParameter(FBParams, "@FBOutCome", Data.SqlDbType.NVarChar, sOutCome)
        db.CreateParameter(FBParams, "@FbReason", Data.SqlDbType.NVarChar, sReasonNotSat)


        db.CreateParameter(FBParams, "@FBisSale", Data.SqlDbType.Int, bIsSale)
        db.CreateParameter(FBParams, "@FBSaleType", Data.SqlDbType.NVarChar, sSaleType)
        db.CreateParameter(FBParams, "@FBSoldDate", Data.SqlDbType.NVarChar, sSoldDate)
        db.CreateParameter(FBParams, "@FBValue", Data.SqlDbType.NVarChar, sValue)
        db.CreateParameter(FBParams, "@FbStartDate", Data.SqlDbType.NVarChar, sStartDate)

        db.CreateParameter(FBParams, "@FBPMINextContact", Data.SqlDbType.NVarChar, sNextContact)
        db.CreateParameter(FBParams, "@FBPreviousProvider", Data.SqlDbType.NVarChar, sPreviousProvider)
        db.CreateParameter(FBParams, "@FBPMINotPresented", Data.SqlDbType.NVarChar, sPMINotPresented)

        db.CreateParameter(FBParams, "@FBLifeOutCome", Data.SqlDbType.NVarChar, sLifeOutCome)
        db.CreateParameter(FBParams, "@FBLifeNextContact", Data.SqlDbType.NVarChar, sLifeNextContact)
        db.CreateParameter(FBParams, "@FBLifeNotPresented", Data.SqlDbType.NVarChar, _lifeNotPresented)
        db.CreateParameter(FBParams, "@FBLifeSoldDate", Data.SqlDbType.NVarChar, _lifeSoldDate)
        db.CreateParameter(FBParams, "@FBLifeValue", Data.SqlDbType.NVarChar, _lifeValue)
        db.CreateParameter(FBParams, "@FbLifeStartDate", Data.SqlDbType.NVarChar, _lifeStartDate)


        db.ExecuteSPNoQuery("spSaveFeedback", FBParams)


        Dim NoteParams As New Collection
        db.CreateParameter(NoteParams, "@UserID", Data.SqlDbType.Int, LoggedOnUserID)
        db.CreateParameter(NoteParams, "@AppID", Data.SqlDbType.Int, ID)
        db.CreateParameter(NoteParams, "@Note", Data.SqlDbType.NVarChar, "Feedback: Added  " & Now.ToLongDateString & " " & Now.ToShortTimeString)
        db.ExecuteSPNoQuery("spCreateAppNote", NoteParams)


    End Sub

End Class
