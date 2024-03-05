Public Class frmAgentWatcher
    Dim ado As Common.DataLayer
    Dim iAgentID As Integer
    Dim params As Collection
    Dim DS As DataSet
    Dim dCallStart As DateTime
    Dim dEndDialing As DateTime
    Dim OldStatus As String
    Public Ext As String = ""
    Public Sub New(ByVal AgentID As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        iAgentID = AgentID
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        ado = New Common.DataLayer
        params = New Collection
        ado.CreateParameter(params, "@AgentID", SqlDbType.Int, iAgentID)
        DS = ado.ExecuteSP("spAgentWatcher", params)

        Dim ThisCompany As Common.cCompany

        Dim mytime As TimeSpan
        Try
            Dim DR As DataRow = DS.Tables(0).Rows(0)
            Text = DR("RealName")
            ThisCompany = New Common.cCompany(DR("ID"))
            Ext = DR("Extension").ToString.Trim.Substring(DR("Extension").ToString.Trim.Length - 3)
            If OldStatus <> DR("Status") Then
                Select Case DR("Status")
                    Case ""
                    Case "Dialing"
                    Case "Connected"
                        mytime = Now - dCallStart
                        lblDialTime.Text = Format(mytime.TotalSeconds, "#0") & " seconds"  'mytime.Minutes & ":" & mytime.Seconds
                    Case Else
                End Select
                OldStatus = DR("Status")
            End If
            mytime = Now - dCallStart
            lblCalltime.Text = Format(mytime.TotalSeconds, "#0") & " seconds"  'mytime.Minutes & ":" & mytime.Seconds

            lblStatus.Text = DR("Status")

            With ThisCompany
                If Not lblMagicNumber.Text = "CompanyID=" & ThisCompany.ID.ToString Then
                    ' company has changed
                    dCallStart = Now
                    lblDialTime.Text = ""
                    lblCalltime.Text = ""
                    Try
                        Dim oldcomp As New Common.cCompany(Replace(lblMagicNumber.Text, "CompanyID=", ""))
                        lvResults.Items.Insert(0, New ListViewItem(New String() {oldcomp.ID, oldcomp.CompanyName, oldcomp.ContactTitle, oldcomp.ContactSurname, oldcomp.ContactPosition, oldcomp.Status, oldcomp.ThisCall.CallFailureReason}))
                    Catch ex As Exception
                        '  MsgBox(Replace(lblMagicNumber.Text, "CompanyID=", "") & ex.Message)
                    End Try
                    Application.DoEvents()
                    Dim colwidth As Integer = CInt(lvResults.ClientSize.Width / 20)
                    lvResults.Columns(0).Width = 0
                    lvResults.Columns(1).Width = (colwidth * 4) - 1
                    lvResults.Columns(2).Width = (colwidth * 1) - 1
                    lvResults.Columns(3).Width = (colwidth * 3) - 1
                    lvResults.Columns(4).Width = (colwidth * 3) - 1
                    lvResults.Columns(5).Width = (colwidth * 2.5) - 1
                    lvResults.Columns(6).Width = (colwidth * 6.5) - 3
                End If
                lblMagicNumber.Text = "CompanyID=" & ThisCompany.ID.ToString
                txtStartedCallAt.Text = .Status
                txtTitle.Text = .ContactTitle
                lblCompany.Text = .CompanyName
                txtContactForeName.Text = .ContactForename
                txtContactSurname.Text = .ContactSurname
                txtContactPosition.Text = .ContactPosition
                lblAddress1.Text = .Address1
                lblAddress2.Text = .Address2
                lblAddress3.Text = .Address3
                lblTown.Text = .Town
                lblCounty.Text = .County
                lblPostcode.Text = .Postcode
                lblTel.Text = .Telephone
                txtFax.Text = .Fax
                txtEmail.Text = .Email
                lblArea.Text = .Area
                lblRep.Text = .Rep.RealName
                If .PolicyExpires = #12:00:00 AM# Then
                    lblPolicyExpiry.Text = ""
                Else
                    lblPolicyExpiry.Text = .PolicyExpires.ToLongDateString
                End If
                lblPolicyProvider.Text = .PolicyProvider
                txtNotes.Text = .Notes
            End With
        Catch ex As Exception
            ' MsgBox(ex.Message)
            lblStatus.Text = ""
        End Try

        Timer1.Enabled = True

    End Sub

    Private Sub frmAgentWatcher_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        Try
            frmManagementConsole.aDialer.Disconnect()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAgentWatcher_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        frmManagementConsole.aDialer = New Common.cDialer
        Application.DoEvents()
        frmManagementConsole.aDialer.NumberToDial = "*90*" & Ext & "#"
        Application.DoEvents()
        System.Threading.Thread.Sleep(500)
        frmManagementConsole.aDialer.Dial()
    End Sub
    Private Sub lvResults_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvResults.DoubleClick
        If lvResults.SelectedItems(0).SubItems(5).Text = "Appointment" Then
            Dim ado As New Common.DataLayer
            Dim ads As DataSet
            ads = ado.ExecuteSQL("SELECT TOP (1) ID, CompanyID FROM   DiaryItems   WHERE  (CompanyID = " & lvResults.SelectedItems(0).Text & ")  ORDER BY ID DESC")
            Try
                Dim afrm As New frmAppoinmentDetail(ads.Tables(0).Rows(0).Item("ID"))
                afrm.ShowDialog()
            Catch ex As Exception
                MsgBox("Cannot find appointment for this company")
            End Try
        Else
            Dim afrm As New frmShowCompany(lvResults.SelectedItems(0).Text)
            afrm.ShowDialog()
        End If
    End Sub
End Class