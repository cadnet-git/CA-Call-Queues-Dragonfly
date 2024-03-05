Imports CADNet.CallQueues.Common


Public Class frmGetPostcode
    Dim fParent As Form
    '  Private Settings As Common.cSettings = New Common.cSettings
    Public Sub New(ByVal Postcode As String, ByVal myparent As Form)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        fParent = myparent
        ' Add any initialization after the InitializeComponent() call.
        GetPostcode(Postcode)
    End Sub

    Private Sub frmGetPostcode_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub GetPostcode(ByVal _Postcode As String)
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Try

            Dim myapp = cAgentApp.GetInstance()
            Dim _PostcodeResult As PostcodeResult = Postcode.GetAddresses(_Postcode)

            'Make the request
            '   objInterimResults = objLookup.ByFreeText(Postcode, Settings.PCAccount, Settings.PCCode, "")
            'Tidy up
            '    objLookup.Dispose()


            'Copy the results into the list box
            If _PostcodeResult.HasError Then
                'Write the error message to the address label
                lblError.Visible = True
                lblError.Text = _PostcodeResult.ErrorMessage
            Else

                lblError.Visible = False
                lblError.Text = ""



                'Add the new items to the list

                If _PostcodeResult.Addresses.Count > 0 Then

                    ResultsList.DataSource = _PostcodeResult.Addresses
                    ResultsList.DisplayMember = "AddressSummary"
                    ResultsList.ValueMember = "id"
                Else
                    lblError.Visible = True
                    lblError.Text = "No Records Found"
                End If

            End If
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ResultsList_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ResultsList.DoubleClick
        populateAddress(ResultsList.SelectedValue)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub populateAddress(_Address As Address)
        If _Address.CompanyName <> "" Then
            fParent.Controls("txtCompanyName").Text = _Address.CompanyName
        End If
        fParent.Controls("txtAddress1").Text = _Address.Address1
        fParent.Controls("txtAddress2").Text = _Address.Address2
        '  fParent.Controls("txtAddress3").Text = objAddress.Line3
        fParent.Controls("txttown").Text = _Address.Town
        fParent.Controls("txtcounty").Text = _Address.County
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub
    Private Sub BtnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSelect.Click
        If ResultsList.SelectedItems.Count > 0 Then
            populateAddress(ResultsList.SelectedValue)
        End If
    End Sub

    Private Sub BtnEditAddress_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEditAddress.Click
        fParent.Controls("txtAddress1").Enabled = True
        fParent.Controls("txtAddress2").Enabled = True
        fParent.Controls("txtAddress3").Enabled = True
        fParent.Controls("txttown").Enabled = True
        fParent.Controls("txtcounty").Enabled = True
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
Public Class ListClass
    Private mID As Integer
    Private mDescription As String
    Private mSubItems As New ArrayList
    Public Property ID() As Integer
        Get
            ID = mID

        End Get
        Set(ByVal Value As Integer)
            mID = Value
        End Set
    End Property
    Public Property Description() As String
        Get
            Description = mDescription
        End Get
        Set(ByVal Value As String)
            mDescription = Value
        End Set
    End Property
    Public Property SubItems() As ArrayList
        Get
            SubItems = mSubItems
        End Get
        Set(ByVal Value As ArrayList)
            mSubItems = Value
        End Set
    End Property
End Class
