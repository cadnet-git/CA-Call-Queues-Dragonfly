Imports CADNet.CallQueues.Common
Imports System.Net
Imports System.IO


Public Class frmCompanyCreate

    Private iBatchID As Integer = 0
    Private iCompanyID As Integer = 0

    Private dLatitude As Double = 0
    Private dLongitude As Double = 0

    Public Property CompanyID() As Integer
        Get
            CompanyID = iCompanyID
        End Get
        Set(ByVal value As Integer)
            iCompanyID = value
            LoadCompany()
        End Set
    End Property
    Private Sub frmCompanyCreate_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        With cmbProvider
            .Items.Add("No Cover")
            .Items.Add("Standard Life")
            .Items.Add("BUPA")
            .Items.Add("AXA PPP")
            .Items.Add("Norwich Union")
            .Items.Add("Pru Healthcare")
            .Items.Add("GROUPAMA")
            .Items.Add("BCWA")
            .Items.Add("Legal & General")
            .Items.Add("Secure Health")
            .Items.Add("WPA")
            .Items.Add("Universal Provident")
        End With

        PopulateExpires()

        EnableOK()

    End Sub

    Private Sub PopulateExpires()
        With Me.cmbExpires
            For i As Integer = 0 To 12
                Dim aDate As Date = (New DateTime(Today.Year, Today.Month, 1))
                aDate = DateAdd(DateInterval.Month, i, aDate)

                .Items.Add(aDate.ToString("MMMM yyyy"))
            Next
        End With
    End Sub
    Private Sub EnableOK()

        'this only does simple checks - it dont hit the database or anything time consuming
        'the ok button should do proper checks

        Dim bState As Boolean = True

        With Me.txtCompanyName
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.txtTelephone
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                If IsNumeric(txtTelephone.Text) Then
                    txtTelephone.BackColor = Color.White
                Else
                    txtTelephone.BackColor = Color.LightCoral
                    bState = False
                End If

            End If
        End With

        With Me.txtPostcode
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.cmbProvider
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        If Me.cmbProvider.Text = "No Cover" Then
            Me.cmbExpires.BackColor = Color.White
        Else
            With Me.cmbExpires
                If .Text.Trim.Length < 1 Then
                    bState = False
                    .BackColor = Color.LightCoral
                Else
                    .BackColor = Color.White
                End If
            End With
        End If


        With Me.txtAddress1
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        'With Me.txtAddress2
        '    If .Text.Trim.Length < 1 Then
        '        bState = False
        '        .BackColor = Color.LightCoral
        '    Else
        '        .BackColor = Color.White
        '    End If
        'End With

        'With Me.txtAddress3
        '    If .Text.Trim.Length < 1 Then
        '        bState = False
        '        .BackColor = Color.LightCoral
        '    Else
        '        .BackColor = Color.White
        '    End If
        'End With

        With Me.txtTown
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.txtCounty
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With


        With Me.txtContactTitle
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.txtContactForename
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.txtContactSurname
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        With Me.txtContactPosition
            If .Text.Trim.Length < 1 Then
                bState = False
                .BackColor = Color.LightCoral
            Else
                .BackColor = Color.White
            End If
        End With

        If Me.txtFax.Text.Length < 1 And Me.txtEmail.Text.Length < 1 Then
            bState = True
            Me.txtFax.BackColor = Color.LightCoral
            Me.txtEmail.BackColor = Color.LightCoral
        Else
            Me.txtFax.BackColor = Color.White
            Me.txtEmail.BackColor = Color.White
        End If

        Me.btnOk.Enabled = bState

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOk.Click

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        'use the common.cpostcode class to verify the postcode

        Dim sValidatedPostcode As String = Common.cPostcode.ValidatePostcode(Me.txtPostcode.Text)
        If sValidatedPostcode.Length > 0 Then
            'the postcode did not validate
            Dim sMsg As String = "Sorry, but that post code is not acceptable:"
            sMsg = sMsg & vbCrLf & sValidatedPostcode
            sMsg = sMsg & vbCrLf & vbCrLf
            sMsg = sMsg & "Please check your details and try again."
            MessageBox.Show(sMsg)
            Exit Sub
        End If

        Dim sValidatedTelephone As String = Common.DataImport.ValidateTelephoneReason(Me.txtTelephone.Text)
        If sValidatedTelephone.Length > 0 Then
            'the telephone didnt validate
            Dim sMsg As String = "Sorry, but that telephone number is not acceptable:"
            sMsg = sMsg & vbCrLf & sValidatedTelephone
            sMsg = sMsg & vbCrLf & vbCrLf
            sMsg = sMsg & "Please check your details and try again."
            MessageBox.Show(sMsg)
            Exit Sub
        End If

        'now that they have passed the simple tests we can do the more time consume stuff
        'ie create the damn things!
        If iBatchID < 1 Then
            iBatchID = GetBatchID("User Created Company")
        End If

        Dim oPostcode As Common.cPostcode
        Try
            'if the opostcode object can be created without exceoptions, then
            'the postcode has been saved to the database
            oPostcode = New Common.cPostcode(Me.txtPostcode.Text, iBatchID)
        Catch ex As Exception
            Dim sMsg As String = "There was a problem creating the postcode: "
            sMsg = sMsg & vbCrLf & ex.Message
            MessageBox.Show(sMsg)
            Exit Sub
        End Try

        Dim sSQL As String = ""

        If Me.iCompanyID > 0 Then
            'only edit the record

            sSQL = "UPDATE Companies SET"

            sSQL = sSQL & " CompanyName='" & Me.txtCompanyName.Text & "' "
            sSQL = sSQL & ", Telephone='" & Me.txtTelephone.Text & "'"
            sSQL = sSQL & ", PostcodeID=" & oPostcode.ID
            sSQL = sSQL & ", PostcodeRaw='" & Me.txtPostcode.Text & "' "
            sSQL = sSQL & ", LocationID=" & oPostcode.LocationID
            sSQL = sSQL & ", Address1='" & Me.txtAddress1.Text.Trim & "'"
            sSQL = sSQL & ", Address2='" & Me.txtAddress2.Text.Trim & "'"
            sSQL = sSQL & ", Address3='" & Me.txtAddress3.Text.Trim & "'"
            sSQL = sSQL & ", Town='" & Me.txtTown.Text.Trim & "'"
            sSQL = sSQL & ", County='" & Me.txtCounty.Text.Trim & "'"
            sSQL = sSQL & ", Fax='" & Me.txtFax.Text.Trim & "'"
            sSQL = sSQL & ", ContactTitle='" & Me.txtContactTitle.Text.Trim & "'"
            sSQL = sSQL & ", ContactForename='" & Me.txtContactForename.Text.Trim & "'"
            sSQL = sSQL & ", ContactSurname='" & Me.txtContactSurname.Text.Trim & "'"
            sSQL = sSQL & ", ContactPosition='" & Me.txtContactPosition.Text & "'"
            sSQL = sSQL & ", Email='" & Me.txtEmail.Text.Trim & "'"
            sSQL = sSQL & ", PolicyExpires='" & Me.cmbExpires.Text & "'"
            sSQL = sSQL & ", PolicyProvider='" & Me.cmbProvider.Text & "'"

            sSQL = sSQL & " WHERE ID=" & iCompanyID

            Database.ExecuteSQL(sSQL)

        Else
            'create a new company

            'now create the company and save it
            sSQL = "INSERT INTO Companies ("

            sSQL = sSQL & " CompanyName, Telephone, PostcodeID, PostcodeRaw, LocationID"
            sSQL = sSQL & ", Address1, Address2, Address3"
            sSQL = sSQL & ", Town, County, Fax, ContactTitle, ContactForename, ContactSurname"
            sSQL = sSQL & ", ContactPosition, Email, ImportBatchID, HoldUntil"
            sSQL = sSQL & ", PolicyExpires, PolicyProvider"
            sSQL = sSQL & ")"
            sSQL = sSQL & " VALUES ( "

            sSQL = sSQL & "'" & Me.txtCompanyName.Text & "'"
            sSQL = sSQL & ", '" & Me.txtTelephone.Text & "'"
            sSQL = sSQL & ", " & oPostcode.ID
            sSQL = sSQL & ", '" & Me.txtPostcode.Text & "'"
            sSQL = sSQL & ", " & oPostcode.LocationID
            sSQL = sSQL & ", '" & Me.txtAddress1.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtAddress2.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtAddress3.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtTown.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtCounty.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtFax.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtContactTitle.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtContactForename.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtContactSurname.Text.Trim & "'"
            sSQL = sSQL & ", '" & Me.txtContactPosition.Text & "'"
            sSQL = sSQL & ", '" & Me.txtEmail.Text.Trim & "'"
            sSQL = sSQL & ", " & iBatchID
            sSQL = sSQL & ", '" & Common.DateManipulation.DateToString(Today, DateFormats.ForSQLInsertion) & "'"
            sSQL = sSQL & ", '" & Me.cmbExpires.Text & "'"
            sSQL = sSQL & ", '" & Me.cmbProvider.Text & "'"
            sSQL = sSQL & ")"

            sSQL = sSQL & "; SELECT @@IDENTITY AS ID"

            Dim DS As DataSet = Database.ExecuteSQL(sSQL)
            iCompanyID = DS.Tables(0).Rows(0).Item("ID")

        End If

        'get the location and update the record
        Dim iLocationID As Integer = GetLocationID(oPostcode)
        If iLocationID > 0 Then
            sSQL = "Update Companies set LocationID=" & iLocationID & " WHERE ID=" & iCompanyID
            Database.ExecuteSQL(sSQL)
        Else
            MessageBox.Show("Company has been created, but location cannot be found")
        End If

        'the selected company MUST be in an area (ie the PostcodePrefix record must have an area ID)
        If oPostcode.AreaID < 1 Then
            Dim aFrm As New frmPostcodeAssignArea
            Dim DR As DialogResult = aFrm.ShowDialog
            Select Case DR
                Case DialogResult.OK

                    sSQL = "Update Postcodeprefixes set AreaID=" & aFrm.AreaID & " WHERE ID=" & oPostcode.ID
                    Database.ExecuteSQL(sSQL)

                Case DialogResult.Cancel
                    Exit Sub
                Case Else
                    MessageBox.Show("Unhandled dialog result: " & DR.ToString)

            End Select
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

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

            Dim sqlInsert As String = "INSERT INTO postcodelocations (postcodeprefixid, postcodesuffix, latitude, longitude) "
            sqlInsert = sqlInsert & " values (" & oPostcode.ID & ", '" & oPostcode.Suffix & "', " & dLatitude & ", " & dLongitude & ")"
            Database.ExecuteSQL(sqlInsert)

            sSQL = "select * from postcodelocations where PostcodePrefixID=" & oPostcode.ID & " AND PostcodeSuffix='" & oPostcode.Suffix & "'"
            ds2 = Database.ExecuteSQL(sSQL)
            GetLocationID = ds2.Tables(0).Rows(0).Item("ID")
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

    Private Sub txtTelephone_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        EnableOK()
    End Sub

    Private Sub UpdateOKButtonAferEdit(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCompanyName.TextChanged, txtAddress1.TextChanged, txtAddress2.TextChanged, txtAddress3.TextChanged, txtTown.TextChanged, txtCounty.TextChanged, txtPostcode.TextChanged, txtTelephone.TextChanged, txtFax.TextChanged, txtContactTitle.TextChanged, txtContactForename.TextChanged, txtContactSurname.TextChanged, txtContactPosition.TextChanged, txtEmail.TextChanged, cmbExpires.SelectedIndexChanged, cmbProvider.SelectedIndexChanged
        EnableOK()
    End Sub


    Private Sub LoadCompany()
        'get the company details from the database and put them on the form
        Dim sSQL As String = ""

        sSQL = "SELECT * FROM Companies  WHERE ID=" & iCompanyID
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        Dim aRow As DataRow = DS.Tables(0).Rows(0)

        Me.txtCompanyName.Text = aRow.Item("CompanyName")
        Me.txtTelephone.Text = aRow.Item("Telephone")
        Me.txtPostcode.Text = aRow.Item("PostcodeRaw")
        Me.txtAddress1.Text = aRow.Item("Address1").ToString
        Me.txtAddress2.Text = aRow.Item("Address2").ToString
        Me.txtAddress3.Text = aRow.Item("Address3").ToString
        Me.txtTown.Text = aRow.Item("Town").ToString
        Me.txtCounty.Text = aRow.Item("County").ToString
        Me.txtFax.Text = aRow.Item("Fax").ToString
        Me.txtContactTitle.Text = aRow.Item("ContactTitle").ToString
        Me.txtContactForename.Text = aRow.Item("ContactForename").ToString
        Me.txtContactSurname.Text = aRow.Item("ContactSurname").ToString
        Me.txtContactPosition.Text = aRow.Item("ContactPosition").ToString
        Me.txtEmail.Text = aRow.Item("Email").ToString

        Dim aDate As DateTime
        If aRow.Item("PolicyExpires") Is DBNull.Value Then
            aDate = Nothing
        Else
            aDate = aRow.Item("PolicyExpires")
            If Me.cmbExpires.Items.Count < 1 Then
                PopulateExpires()
            End If

            If Me.cmbExpires.Items.Contains(aDate.ToString("MMMM yyyy")) = False Then
                Me.cmbExpires.Items.Add(aDate.ToString("MMMM yyyy"))
            End If

            Me.cmbExpires.Text = aDate.ToString("MMMM yyyy")
        End If

        Me.cmbProvider.Text = aRow.Item("PolicyProvider").ToString

        EnableOK()


    End Sub

    Private Function GetBatchID(ByVal Filename As String) As Integer
        'get a batch id
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim Params As New Collection
        Database.CreateParameter(Params, "@UserID", SqlDbType.Int, cManagerApp.GetInstance.CurrentUser.ID)
        Database.CreateParameter(Params, "@FileName", SqlDbType.NVarChar, Filename)
        Database.CreateParameter(Params, "@DataProvider", SqlDbType.NVarChar, "")
        Dim DS As DataSet = Database.ExecuteSP("spBatchImportCreate", Params)

        GetBatchID = DS.Tables(0).Rows(0).Item("ImportBatchID")

    End Function


    Private Sub txtProvider_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        EnableOK()
    End Sub

End Class