Imports System.Net
Imports System.IO

Public Class frmChangeAddress

    Private oCompany As Common.cCompany

    Public InArea As Boolean = True

    Private dLatitude As Double
    Private dLongitude As Double

    Public Sub New(ByVal Company As Common.cCompany)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oCompany = Company
    End Sub
    Private Function GetBatchID(ByVal Filename As String) As Integer
        'get a batch id
        Dim Params As New Collection
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Database.CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
        Database.CreateParameter(Params, "@FileName", SqlDbType.NVarChar, Filename)
        Database.CreateParameter(Params, "@DataProvider", SqlDbType.NVarChar, "")
        Dim DS As DataSet = Database.ExecuteSP("spBatchImportCreate", Params)

        GetBatchID = DS.Tables(0).Rows(0).Item("ImportBatchID")

    End Function


    Private Function GetLocationID(ByVal oPostcode As Common.cPostcode) As Integer

        Dim sSQL As String

        sSQL = "SELECT * FROM PostcodeLocations INNER JOIN PostCodePrefixes ON PostcodeLocations.PostcodePrefixID = PostCodePrefixes.ID"
        sSQL = sSQL & " WHERE Prefix='" & oPostcode.Prefix & "' and Postcodesuffix='" & oPostcode.Suffix & "'"
        'sSQL = "select * from postcodelocations where PostcodePrefixID=" & PostcodeID & " AND PostcodeSuffix='" & sSuffix & "'"
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim ds2 As DataSet = Database.ExecuteSQL(sSQL)

        If ds2.Tables(0).Rows.Count = 0 Then
            'it dont exisit so create it
            Try
                getLatLong(oPostcode.Prefix & " " & oPostcode.Suffix)
            Catch ex As Exception

            End Try

            If dLatitude = 0 And dLongitude = 0 Then
                'try with just the prefix
                Try
                    getLatLong(oPostcode.Prefix)
                Catch ex As Exception

                End Try
            End If

            If dLatitude = 0 And dLongitude = 0 Then
                GetLocationID = 0
            Else
                Dim sqlInsert As String = "INSERT INTO postcodelocations (postcodeprefixid, postcodesuffix, latitude, longitude) "
                sqlInsert = sqlInsert & " values (" & oPostcode.ID & ", '" & oPostcode.Suffix & "', " & dLatitude & ", " & dLongitude & ")"
                Database.ExecuteSQL(sqlInsert)

                sSQL = "select * from postcodelocations where PostcodePrefixID=" & oPostcode.ID & " AND PostcodeSuffix='" & oPostcode.Suffix & "'"
                ds2 = Database.ExecuteSQL(sSQL)
                GetLocationID = ds2.Tables(0).Rows(0).Item("ID")
            End If


        Else
            GetLocationID = ds2.Tables(0).Rows(0).Item("ID")
        End If


    End Function


    Private Sub getLatLong(ByVal postcode As String)

        'scrapes the lat and long from street map

        Dim URL As String = "http://www.streetmap.co.uk/streetmap.dll?GridConvert?type=Postcode&name=" & postcode
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim str As String = reader.ReadToEnd()
            Dim apoint As Integer = InStr(str, "<strong>Lat</strong> (WGS84)") + 85
            Dim tpoint As Integer = InStr(apoint, str, "(")
            Dim tstr As String = str.Substring(tpoint, 9)
            dLatitude = CDbl(tstr)
            apoint = InStr(str, "<strong>Long</strong> (WGS84)") + 85
            tpoint = InStr(apoint, str, "(")
            tstr = str.Substring(tpoint, 9)
            dLongitude = CDbl(tstr)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click


        'see if the postcode has been editied 
        'if it aint, we dont need to validate it
        Dim bConfirmed As Boolean = False

        Static iBatchid As Integer = 0

        If iBatchid = 0 Then
            iBatchid = GetBatchID("Agent edited company")
        End If

        Dim sPostcode As String = Me.txtPostcode.Text

        If sPostcode <> oCompany.Postcode Then
            'the post code has been edited so we need to validate it

            'see if the postcode already exists in the db
            Dim sPrefix As String = Common.cPostcode.GetPrefix(sPostcode)
            Dim bPrefixExists As Boolean = Common.cPostcode.PrefixExists(sPrefix)

            Dim oPostcode As Common.cPostcode = Nothing

            If bPrefixExists = False Then

                Dim aFrm As New frmConfirmPostcode
                aFrm.lblPostcode.Text = Me.txtPostcode.Text
                Dim DR As DialogResult = aFrm.ShowDialog

                If DR = DialogResult.No Then
                    Exit Sub
                End If

                bConfirmed = True
                'the postcode is not in teh db,
                'but the user has confirmed its correct
                'save the new post code in to the database
                'it will be saved to the company later on in this routine

                InArea = False
                Try
                    'if the opostcode object can be created without exceptions, then
                    'the postcode has been saved to or found in the database
                    oPostcode = New Common.cPostcode(Me.txtPostcode.Text, iBatchid)
                Catch ex As Exception
                    Dim sMsg As String = ""
                    sMsg = "There was a problem creating the postcode: "
                    sMsg = sMsg & vbCrLf & ex.Message
                    MessageBox.Show(sMsg)
                    Exit Sub
                End Try
            Else
                'the post code exisits, so open it
                Try
                    'if the opostcode object can be created without exceptions, then
                    'the postcode has been saved to or found in the database
                    oPostcode = New Common.cPostcode(Me.txtPostcode.Text, iBatchid)
                Catch ex As Exception
                    Dim sMsg As String = "There was a problem creating the postcode: "
                    sMsg = sMsg & vbCrLf & ex.Message
                    MessageBox.Show(sMsg)
                    Exit Sub
                End Try
            End If

            'get the location for the postcode
            Dim iLocationID As Integer = GetLocationID(oPostcode)

            'save the postcoderaw, locationid and the postcodeid into the company
            'clear the old address at the same time
            Dim sSQL As String = "update companies set "
            sSQL = sSQL & " PostcodeRaw='" & Me.txtPostcode.Text & "'"
            sSQL = sSQL & ", PostcodeID=" & oPostcode.ID
            sSQL = sSQL & ", LocationID=" & iLocationID
            sSQL = sSQL & ", Address1=''"
            sSQL = sSQL & ", Address2=''"
            sSQL = sSQL & ", Address3=''"
            sSQL = sSQL & ", Town=''"
            sSQL = sSQL & ", County=''"
            sSQL = sSQL & " WHERE ID=" & oCompany.ID.ToString
            Dim Database As New CADNet.CallQueues.Common.DataLayer
            Database.ExecuteSQL(sSQL)

            If iLocationID < 1 Then
                If bConfirmed = False Then
                    'no location could be found, so get the user to confirm:
                    'ask the user to check their input

                    Dim aFrm As New frmConfirmPostcode
                    aFrm.lblPostcode.Text = Me.txtPostcode.Text
                    Dim DR As DialogResult = aFrm.ShowDialog

                    If DR = DialogResult.No Then
                        Exit Sub
                    End If

                    bConfirmed = True
                    InArea = False
                End If

            End If

            'see if the new area has a rep
            sSQL = "select isnull(repId,0) as repid from Areas where ID=" & oPostcode.AreaID
            Dim DS As DataSet = Database.ExecuteSQL(sSQL)
            Dim bOutofArea As Boolean = False

            If DS.Tables(0).Rows.Count < 1 Then
                bOutofArea = True
            ElseIf DS.Tables(0).Rows(0).Item("RepID") < 1 Then
                bOutofArea = True
            End If

            If bOutofArea = True Then
                'there is no rep for this area


                If bConfirmed Then
                    'the user has already confirmed the postcode is correct
                    'accept the change and carry on.
                    'the code after this will have to check for out of area and move the script accordingly

                Else
                    'the post code is out of area, but the user has not confirmed it yet so...

                    Dim aFrm As New frmConfirmPostcode
                    aFrm.lblPostcode.Text = Me.txtPostcode.Text
                    Dim DR As DialogResult = aFrm.ShowDialog

                    If DR = DialogResult.No Then
                        Exit Sub
                    End If

                    bConfirmed = True
                    InArea = False

                End If

            End If
        End If


        'either the data is correct and in area, or the user has confirmed that its ok

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPostcode.TextChanged

        If Common.cPostcode.ValidatePostcode(Me.txtPostcode.Text) <> "" Then
            'failed basic tests 
            Me.txtPostcode.BackColor = Color.LightCoral
            Me.btnOK.Enabled = False
        Else
            Me.txtPostcode.BackColor = Color.White
            Me.btnOK.Enabled = True
        End If

    End Sub
End Class