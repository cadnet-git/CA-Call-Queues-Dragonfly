Imports CADNet.CallQueues.Common
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class cPostcode
    'post codes always follow a format: (from wikipedia)

    '   A9   9AA

    '   A99  9AA

    '   A9A  9AA

    '   AA9  9AA

    '   AA99 9AA

    '   AA9A 9AA 

    'so the last part is always 3 characters

    'its always between 5 and 7 alphanumerics


    Private iCompanyID As Integer = 0
    Private sRawPostcode As String = ""
    Private sPrefix As String = ""
    Private sSuffix As String = ""
    Private iPrefixID As Integer = 0
    Private iLocationID As Integer = 0
    Private iAreaID As Integer = 0
    Private iImportBatchID As Integer = 0
    Private dLatitude As Double = 0
    Private dLongitude As Double = 0

    Public Property fail As String = ""


    Private sError As String = ""   'records any errors from the lat/long retrieval

    'this wont be a fatal error, so the caller is supposed to check for it!



    Public Sub New(ByVal RawPostcode As String, ByVal ImportBatchID As Integer)

        Dim Database As New Common.DataLayer
        'test to see if we have a vaguely correct postcode:

        Dim sPostcodeValidation As String = ValidatePostcode(RawPostcode.Trim)


        fail = ""
        If sPostcodeValidation <> "" Then
            fail = sPostcodeValidation
            'the postcode couldnt be validated, so throw an exception
            ' Dim aWobbler As New Exception(sPostcodeValidation)
            'Throw aWobbler
            '    MsgBox(RawPostcode)
            Exit Sub
        End If

        Dim sCleanPostcode As String = RemoveNonAlphaNumerics(RawPostcode.Trim).ToUpper ' do it again cos jp already did it in  the provious function

        'the prefix is the first 3 char of the cleaned version

        Dim Prefix As String = GetPrefix(RawPostcode)
        Dim Suffix As String = GetSuffix(sCleanPostcode)

        'get a postcodeprefix id (along with the assoicated data)

        Dim Params As New Collection

        Database.CreateParameter(Params, "@ID", SqlDbType.Int, 0)

        Database.CreateParameter(Params, "@Prefix", SqlDbType.NVarChar, Prefix)

        Database.CreateParameter(Params, "@AreaID", SqlDbType.Int, DBNull.Value)

        Database.CreateParameter(Params, "@ImportBatchID", SqlDbType.Int, ImportBatchID)

        Dim DS As DataSet = Database.ExecuteSP("spPostCodeSave", Params)

        If DS.Tables(0).Rows(0).Item("AreaID") Is DBNull.Value Then
            iAreaID = 0
        Else
            iAreaID = DS.Tables(0).Rows(0).Item("AreaID")
        End If

        Dim PrefixID As Integer = DS.Tables(0).Rows(0).Item("ID")

        If PrefixID < 1 Then

            'there was some known problem creating the prefix
            'it will be logged in the database - see the stored procedure for more info

            Dim sMsg As String = "Unable to store Prefix in Database: "

            sMsg = sMsg & vbCrLf & "Prefix: " & Prefix

            sMsg = sMsg & vbCrLf & "Suffix: " & Suffix



            Dim aWobbler As New Exception(sMsg)

            Throw aWobbler

            Exit Sub

        End If



        'now we have the postcode prefix id, we can deal with the suffix/location stuff

        'first see if there is already a record:

        Params = New Collection

        Database.CreateParameter(Params, "@PostcodePrefixID", SqlDbType.Int, PrefixID)
        Database.CreateParameter(Params, "@Suffix", SqlDbType.NVarChar, Suffix)
        DS = Database.ExecuteSP("spGetPostcodeLocationBySuffix", Params)

        Dim LocationID As Integer = 0
        If DS.Tables(0).Rows.Count = 0 Then

            'there is not an existing one
            'we need to retrieve the longitude and latitude

            Dim result As LatLong = getLatLongObject(RawPostcode)

            Params = New Collection

            Database.CreateParameter(Params, "@PostcodePrefixID", SqlDbType.Int, PrefixID)

            Database.CreateParameter(Params, "@Suffix", SqlDbType.NVarChar, Suffix)

            Database.CreateParameter(Params, "@Latitude", SqlDbType.Float, result.Latitude)

            Database.CreateParameter(Params, "@Longitude", SqlDbType.Float, result.Longitude)

            DS = Database.ExecuteSP("spPostcodeLocationCreate", Params)

            If DS.Tables(0).Rows.Count = 0 Then

                'there was a problem creating the record

                Dim sMsg As String = "There was an unknown problem creating the Postcode Location"

                sMsg = sMsg & vbCrLf & "Prefix: " & vbTab & Prefix

                sMsg = sMsg & vbCrLf & "PrefixID: " & vbTab & PrefixID

                sMsg = sMsg & vbCrLf & "Suffix: " & vbTab & Suffix


                Dim aWobbler As New Exception(sMsg)

                Throw aWobbler

            End If

            LocationID = DS.Tables(0).Rows(0).Item("ID")

        Else

            LocationID = DS.Tables(0).Rows(0).Item("ID")

        End If

        'save our data to the class

        sRawPostcode = RawPostcode
        sPrefix = Prefix
        sSuffix = Suffix
        iPrefixID = PrefixID
        iLocationID = LocationID

    End Sub



    Public ReadOnly Property Suffix() As String
        Get
            Suffix = sSuffix
        End Get
    End Property

    Public ReadOnly Property Prefix() As String
        Get
            Prefix = sPrefix
        End Get
    End Property

    Public ReadOnly Property AreaID() As Integer
        Get
            AreaID = iAreaID
        End Get
    End Property

    Public ReadOnly Property LocationID() As Integer
        Get
            LocationID = iLocationID
        End Get
    End Property

    Public ReadOnly Property ID() As Integer
        Get
            ID = iPrefixID
        End Get
    End Property

    Private Sub LoadPrefix(ByVal rowPrefix As DataRow)
        'load a postcodeprefix record from a dataset
        iPrefixID = rowPrefix.Item("ID")
        sPrefix = rowPrefix.Item("Prefix")
        iAreaID = rowPrefix.Item("AreaID")
        iImportBatchID = rowPrefix.Item("ImportBatchID")
    End Sub

    Public ReadOnly Property PrefixID() As Integer
        Get
            PrefixID = iPrefixID
        End Get
    End Property



    Public Shared Function GetPrefix(ByVal Postcode As String) As String

        ' work out the prefix and return it
        Dim sCleanPostcode As String = Common.RemoveNonAlphaNumerics(Postcode.Trim).ToUpper
        GetPrefix = sCleanPostcode.Substring(0, sCleanPostcode.Length - 3)

    End Function

    Public Shared Function GetSuffix(ByVal Postcode As String) As String

        Dim suffix = Postcode.Substring(Postcode.Length - 3)
        Return suffix.Substring(0, 1)

    End Function

    Public Shared Function PrefixExists(ByVal Prefix As String) As Boolean

        Dim Database As New Common.DataLayer
        Dim Params As New Collection

        Database.CreateParameter(Params, "@PostCodePrefix", SqlDbType.NVarChar, Prefix)

        Dim DS As DataSet = Database.ExecuteSP("spPostcodeGetID", Params)

        Dim PostcodeID As Integer = DS.Tables(0).Rows(0).Item("ID")

        If PostcodeID < 1 Then

            PrefixExists = False

        Else

            PrefixExists = True

        End If





    End Function



    Public Shared Function ValidatePostcode(ByVal sPostcode As String) As String

        'can the postcode be validated?

        'returns an empty string for yes

        'else returns a description why

        Dim sCleanPostcode As String = RemoveNonAlphaNumerics(sPostcode.Trim).ToUpper

        'see if we have enough characters to make sense of it

        If sCleanPostcode.Length = 0 Then
            Return "Postcode cannot be zero length"
        End If

        If sCleanPostcode.Length < 5 Then
            Return "Postcode too short - cannot have less than 5 characters"
        End If

        If sCleanPostcode.Length > 7 Then
            Return "Postcode too long - cannot have more than 7 characters"
        End If

        'the first character MUST be a letter

        Dim Chars As Char() = sCleanPostcode.ToCharArray

        If Char.IsLetter(sCleanPostcode, 0) = False Then
            Return "Postcode invalid - first character must be a Letter"
        End If

        If Not Text.RegularExpressions.Regex.IsMatch(sPostcode.ToUpper, "[A-Z]{1,2}[0-9R][0-9A-Z]? [0-9][A-Z-[CIMOV]]") Then
            Return "Postcode invalid"
        End If

        'looks like the postcode MAY be ok!
        Return ""

    End Function

    Public Shared Function CleanPostcode(ByVal sPostcode As String) As String
        CleanPostcode = RemoveNonAlphaNumerics(sPostcode.Trim).ToUpper
    End Function


    Public ReadOnly Property ErrorMessage() As String

        Get

            ErrorMessage = sError

        End Get

    End Property


    Public Shared Function getLatLongObject(ByVal postcode As String) As LatLong

        Dim URL As String = "https://api.postcodes.io/postcodes/" & postcode

        Dim request As WebRequest = WebRequest.Create(URL)
        Try
            Dim response As WebResponse = request.GetResponse()
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim str As String = reader.ReadToEnd()
            Dim lookup As PCLookup = JsonConvert.DeserializeObject(Of PCLookup)(str)
            Dim r As New LatLong
            r.Latitude = lookup.result.latitude.ToString()
            r.Longitude = lookup.result.longitude.ToString()
            Return r

        Catch ex As Exception
            Dim r As New LatLong
            r.Latitude = "0"
            r.Longitude = "0"
            Return r
        End Try
    End Function

End Class











