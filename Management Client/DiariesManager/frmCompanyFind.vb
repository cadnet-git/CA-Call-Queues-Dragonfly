Public Class frmCompanyFind

    Private iCompanyID As Integer = 0


    Public ReadOnly Property CompanyID() As Integer
        Get
            CompanyID = iCompanyID
        End Get
    End Property

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click

        Dim aFrm As New frmCompanyCreate
        aFrm.Text = "Edit company"
        aFrm.CompanyID = iCompanyID
        Dim DR As DialogResult = aFrm.ShowDialog

        Dim CompanyID As Integer = 0

        Select Case DR
            Case DialogResult.OK
                CompanyID = aFrm.CompanyID
        End Select

        If CompanyID > 0 Then
            iCompanyID = CompanyID
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub DoSearch()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        'If CStr(Me.txtCompanyName.Text & Me.txtPostcode.Text & Me.txtTelephone.Text).Trim.Length = 0 Then
        If Me.txtTelephone.Text.Length = 0 Then
            'they havent entered any search params
            Beep()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Me.lvwCompanies.Items.Clear()

        Me.SuspendLayout()

        Dim sSQL As String = "SELECT * FROM Companies"
        Dim sWhere As String = ""

        'If Me.txtCompanyName.Text.Trim.Length > 0 Then
        '    If sWhere.Length <> 0 Then
        '        sWhere = sWhere & " AND "
        '    End If
        '    sWhere = sWhere & "CompanyName like '" & Me.txtCompanyName.Text.Trim & "%'"
        'End If

        If Me.txtTelephone.Text.Trim.Length > 0 Then
            If sWhere.Length <> 0 Then
                sWhere = sWhere & " AND "
            End If
            sWhere = sWhere & "replace(Telephone,' ','') like '" & Me.txtTelephone.Text.Trim.Replace(" ", "") & "%'"
        End If

        'If Me.txtPostcode.Text.Trim.Length > 0 Then
        '    If sWhere.Length <> 0 Then
        '        sWhere = sWhere & " AND "
        '    End If
        '    sWhere = sWhere & "postcoderaw like '" & Me.txtPostcode.Text.Trim & "%'"
        'End If


        sSQL = sSQL & " WHERE " & sWhere
        sSQL = sSQL & " ORDER BY CompanyName"

        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anItem As ListViewItem = Me.lvwCompanies.Items.Add(aRow.Item("CompanyName"))

            anItem.SubItems.Add(aRow.Item("Telephone"))
            anItem.SubItems.Add(aRow.Item("postcoderaw"))

            anItem.Tag = aRow

        Next

        Me.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSearch.Click

        DoSearch()
    End Sub

    Private Sub lvwCompanies_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles lvwCompanies.Resize
        Me.colCompanyName.Width = (Me.lvwCompanies.Width * 0.9) / Me.lvwCompanies.Columns.Count
        Me.colTelephone.Width = (Me.lvwCompanies.Width * 0.9) / Me.lvwCompanies.Columns.Count
        Me.colPostcode.Width = (Me.lvwCompanies.Width * 0.9) / Me.lvwCompanies.Columns.Count
    End Sub

    Private Sub lvwCompanies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lvwCompanies.SelectedIndexChanged

        If Me.lvwCompanies.SelectedItems.Count = 0 Then
            iCompanyID = 0
            Me.btnOK.Enabled = False
        Else
            Dim anItem As ListViewItem = Me.lvwCompanies.SelectedItems(0)
            Dim aRow As DataRow = anItem.Tag
            iCompanyID = aRow.Item("ID")
            Me.btnOK.Enabled = True
        End If
    End Sub

    Private Sub btnCreateNew_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCreateNew.Click
        Dim aFrm As New frmCompanyCreate
        Dim DR As DialogResult = aFrm.ShowDialog

        Dim CompanyID As Integer = 0

        Select Case DR
            Case DialogResult.OK
                CompanyID = aFrm.CompanyID
        End Select

        If CompanyID > 0 Then
            iCompanyID = CompanyID
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub txtTelephone_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTelephone.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                DoSearch()
        End Select
    End Sub


End Class