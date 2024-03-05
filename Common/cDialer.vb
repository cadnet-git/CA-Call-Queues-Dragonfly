Imports TAPI3Lib

Public Class cDialer

    Private WithEvents oTAPI As TAPIClass
    Private ThisCall As ITBasicCallControl
    Private Program_Disconnected As Boolean = False
    Private sAddressName As String = ""
    Private sNumberToDial As String = ""

    Public Enum eDisconnectType
        Normal
        BadAddress
        Busy
        Blocked
        NoAnswer
        Rejected
        Other
    End Enum

    Public Event Connected(ByVal CalledNumber As String)
    Public Event Disconnected(ByVal CalledNumber As String, ByVal Type As eDisconnectType)
    Public Event Debug(ByVal Location As String, ByVal Comment As String)

    Private Enum MediaType As Integer
        MediaAudio = 8
        MediaModem = 16
        MediaFax = 32
        MediaVideo = 32768
    End Enum

    Private Const LINEADDRESSTYPE_PHONENUMBER As Integer = 1

    Public Sub New()
        'connect to the database and determine the extension (ITAddress) to use
        Dim Database As New Common.DataLayer
        Dim sSQL As String = "Select * from Desks where TerminalName='" & My.Computer.Name & "'"
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows.Count < 1 Then
            Dim aWobbler As New Exception("Exception while Getting Desk: Desk not found")
            Throw aWobbler
        End If

        sAddressName = DS.Tables(0).Rows(0).Item("Extension")
        'check to see if the address is available to tapi

        Dim bFound As Boolean = False
        For Each aStr As String In Me.Addresses
            If aStr = sAddressName Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = False Then
            'contains wont find it!
            ' If Me.Addresses.Contains(sAddressName) = False Then
            Dim aWobbler As New Exception("Address is not available to TAPI: " & sAddressName)
            Throw aWobbler
        End If

    End Sub

    Private Sub InitTapi()

        Try
            ThisCall = Nothing
            oTAPI.Shutdown()
        Catch ex As Exception

        End Try

        Dim oT As New TAPIClass
        oT.Initialize()
        System.Threading.Thread.Sleep(500)
        Program_Disconnected = False
        oTAPI = oT

    End Sub

    Private Function FindTAPIAddress(ByVal AddressName As String) As ITAddress

        Dim bFound As Boolean = False
        Dim anAddress As ITAddress = Nothing

        If oTAPI Is Nothing Then
            InitTapi()
        End If

        Dim oAddresses As Object = oTAPI.Addresses

        For Each anAddress In oAddresses
            If anAddress.AddressName.ToString = AddressName Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = False Then
            FindTAPIAddress = Nothing
            Exit Function
        End If

        FindTAPIAddress = anAddress

    End Function



    Public Function Addresses() As Collection

        InitTapi()

        Dim sAddresses As New Collection

        For Each anAddress As ITAddress In oTAPI.Addresses
            sAddresses.Add(anAddress.AddressName.ToString)
            Console.WriteLine("cDialer.Addresses() - Found address: " & anAddress.AddressName.ToString)
        Next

        Addresses = sAddresses

    End Function
    Public ReadOnly Property ExtensionName() As String
        Get
            ExtensionName = sAddressName
        End Get
    End Property
    Public Property NumberToDial() As String
        Get
            NumberToDial = sNumberToDial
        End Get
        Set(ByVal value As String)
            sNumberToDial = value
        End Set
    End Property

    Public Sub Dial()
        If sNumberToDial.Length < 1 Then
            Dim aWobbler As New Exception("NumberToDial not set")
            Throw aWobbler
        End If
        If Me.sAddressName.Length < 1 Then
            Dim aWobbler As New Exception("Extension Address not set")
            Throw aWobbler
        End If

        InitTapi()

        'set up the call:
        Dim oAddress As ITAddress = Nothing

        If oAddress Is Nothing Then
            oAddress = FindTAPIAddress(sAddressName)

            Dim MediaSupport As ITMediaSupport = oAddress
            Dim MediaTypes As Integer = MediaSupport.MediaTypes
            MediaSupport = Nothing

            oTAPI.RegisterCallNotifications(oAddress, True, True, MediaTypes, 1)

            'specify the notifications we want to receive
            oTAPI.EventFilter = (TAPI_EVENT.TE_CALLNOTIFICATION _
                    Or TAPI_EVENT.TE_CALLSTATE _
                    Or TAPI_EVENT.TE_CALLINFOCHANGE _
                    Or TAPI_EVENT.TE_DIGITEVENT _
                    Or TAPI_EVENT.TE_PHONEEVENT _
                    Or TAPI_EVENT.TE_GENERATEEVENT _
                    Or TAPI_EVENT.TE_GATHERDIGITS _
                    Or TAPI_EVENT.TE_REQUEST _
                    Or TAPI_EVENT.TE_TONEEVENT _
                    Or TAPI_EVENT.TE_GENERATEEVENT _
                    Or TAPI_EVENT.TE_CALLMEDIA _
                    Or TAPI_EVENT.TE_DIGITEVENT _
                    Or TAPI_EVENT.TE_ASRTERMINAL _
                    Or TAPI_EVENT.TE_ADDRESS Or _
                    TAPI_EVENT.TE_TONETERMINAL _
                   )
        End If

        ThisCall = oAddress.CreateCall(sNumberToDial, LINEADDRESSTYPE_PHONENUMBER, MediaType.MediaModem)

        Try
            ThisCall.Connect(False)
        Catch ex As Exception
            Dim aWobbler As New Exception("Exception while Connecting: " & ex.Message)
            Throw aWobbler
        End Try

    End Sub


    Private Sub oTAPI_Event(ByVal TapiEvent As TAPI3Lib.TAPI_EVENT, ByVal pEvent As Object) Handles oTAPI.Event

        Dim sState As String = ""
        Dim sData As String = ""
        Dim sNum As String = ""

        Select Case TapiEvent
            Case TAPI_EVENT.TE_CALLSTATE
                Dim oCS As ITCallStateEvent
                oCS = CType(pEvent, ITCallStateEvent)

                Dim sCalledNumber As String = oCS.Call.CallInfoString(CALLINFO_STRING.CIS_CALLEDIDNUMBER)

                Select Case oCS.State
                    Case CALL_STATE.CS_CONNECTED
                        RaiseEvent Connected(sCalledNumber)
                    Case CALL_STATE.CS_DISCONNECTED
                        Dim iType As eDisconnectType = eDisconnectType.Other

                        Select Case oCS.Cause
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_NORMAL
                                iType = eDisconnectType.Normal
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_BADADDRESS
                                iType = eDisconnectType.BadAddress
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_BLOCKED
                                iType = eDisconnectType.Blocked
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_BUSY
                                iType = eDisconnectType.Busy
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_NOANSWER
                                iType = eDisconnectType.NoAnswer
                            Case CALL_STATE_EVENT_CAUSE.CEC_DISCONNECT_REJECTED
                                iType = eDisconnectType.Rejected
                        End Select
                        '    Common.WriteLog(eSource.AgentApp, "Dialer class Disconnect Event Type =" & iType.ToString)

                        ' added this if to seperate program disconnectong from people disconnecting 
                        If Not Program_Disconnected Then
                            RaiseEvent Disconnected(sCalledNumber, iType)
                            Try
                                Disconnect()
                            Catch ex As Exception
                                RaiseEvent Debug("TapiEvent", ex.Message)
                            End Try

                        End If
                End Select
        End Select

    End Sub

    Public Sub Disconnect()
        Try
            ' ProgramDisconnected is checked when disconnect event fires 
            Program_Disconnected = True
            ThisCall.Disconnect(DISCONNECT_CODE.DC_NORMAL)
           
            System.Threading.Thread.Sleep(100)
            ThisCall = Nothing
            oTAPI.Shutdown()
            oTAPI = Nothing
        Catch ex As Exception
            RaiseEvent Debug("Disconnect", ex.Message)
        End Try
    End Sub

End Class

