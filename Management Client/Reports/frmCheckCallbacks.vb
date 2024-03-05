Public Class frmCheckCallbacks
    Dim RecordCount As Integer = 0
    Dim Start As Integer = 0
    Private Const PageLength As Integer = 100
    Private iAgent As Integer
    Public Sub New(ByVal AgentID As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iAgent = AgentID
    End Sub


    Private Sub frmCheckCallbacks_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        position.Text = ""

    End Sub

    Private Sub Refreshform()
        Me.Cursor = Cursors.WaitCursor
        Dim database As New Common.DataLayer
        Dim ds As DataSet
        Dim params As New Collection

        database.CreateParameter(params, "@AgentID", SqlDbType.Int, iAgent)
        database.CreateParameter(params, "@Start", SqlDbType.Int, Start)
        database.CreateParameter(params, "@End", SqlDbType.Int, Start + PageLength)
        ds = database.ExecuteSP("spGetCallBacks", params)
        Application.DoEvents()
        Try
            RecordCount = ds.Tables(1).Rows(0).Item("Records")
        Catch ex As Exception
            RecordCount = 0
            position.Text = "No Records"
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        position.Text = Start & " to " & Start + PageLength & " of " & RecordCount
        Dim lvitem As ListViewItem
        lvCallbacks.Items.Clear()
        lvCallbacks.SuspendLayout()
        Try

            For Each DR As DataRow In ds.Tables(0).Rows
                lvitem = New ListViewItem
                lvitem.Text = DR("ID")
                lvitem.SubItems.Add(DR("Companyname"))
                lvitem.SubItems.Add(DR("ContactTitle"))
                lvitem.SubItems.Add(DR("ContactSurname"))
                lvitem.SubItems.Add(DR("ContactPosition"))
                lvitem.SubItems.Add(DR("PolicyProvider"))
                Dim adate As DateTime
                adate = DR("PolicyExpires")
                lvitem.SubItems.Add(adate.ToLongDateString)
                Me.lvCallbacks.Items.Add(lvitem)
            Next

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
        Application.DoEvents()
        Dim Colwidth As Integer = CInt(lvCallbacks.ClientSize.Width / 7)
        lvCallbacks.Columns(1).Width = Colwidth * 2.5
        lvCallbacks.Columns(2).Width = Colwidth * 0.5
        lvCallbacks.Columns(3).Width = Colwidth
        lvCallbacks.Columns(4).Width = Colwidth
        lvCallbacks.Columns(5).Width = Colwidth
        lvCallbacks.Columns(6).Width = Colwidth - 3
        lvCallbacks.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub ViewHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ViewHistoryToolStripMenuItem.Click
        If lvCallbacks.SelectedItems.Count > 0 Then
            Dim afrm As New frmShowCompany(lvCallbacks.SelectedItems(0).Text)
            afrm.ShowDialog()
            Dim aCompany As Common.cCompany
            aCompany = New Common.cCompany(lvCallbacks.SelectedItems(0).Text)
            With lvCallbacks.SelectedItems(0)
                .SubItems(1).Text = aCompany.CompanyName
                .SubItems(2).Text = aCompany.ContactTitle
                .SubItems(3).Text = aCompany.ContactSurname
                .SubItems(4).Text = aCompany.ContactPosition
                .SubItems(5).Text = aCompany.PolicyProvider
                .SubItems(6).Text = aCompany.PolicyExpires.ToLongDateString
            End With
            If aCompany.Status <> "CallBack" Then
                lvCallbacks.SelectedItems(0).Remove()
            End If
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Refreshform()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnNext.Click
        Start = Start + PageLength
        btnBack.Enabled = True
        If Start > RecordCount Then
            Start = RecordCount - PageLength
            BtnNext.Enabled = False
        Else
            BtnNext.Enabled = True
        End If
        Refreshform()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBack.Click
        Start = Start - PageLength
        BtnNext.Enabled = True
        If Start < 0 Then
            Start = 0
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If
        Refreshform()
    End Sub


    Private Sub cMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cMenu.Opening

    End Sub

    Private Sub RestToColdCallToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RestToColdCallToolStripMenuItem.Click
        If lvCallbacks.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to return this to Cold Call?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim database As New Common.DataLayer
                database.ExecuteSQL("UPDATE  Companies SET  companyStatus='ColdCall', AgentID =0, PolicyExpires='1 Jan 1900', PolicyProvider ='', HoldUntil = '" & Now.ToLongDateString & " " & Now.AddMinutes(15).ToShortTimeString & "' WHERE   ID = " & lvCallbacks.SelectedItems(0).Text)
                Refreshform()
            End If
        End If
    End Sub
End Class