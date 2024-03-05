Public Class frmTodaysCallbacksByAgent
    Dim iAgentID As Integer = 0
    Dim SDate As DateTime
    Public Sub New(ByVal AgentID As Integer, ByVal AgentName As String, ByVal aDate As DateTime)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iAgentID = AgentID
        Me.lblAgent.Text = AgentName & " - " & aDate.ToLongDateString
        SDate = aDate
        refreshform()
    End Sub

    Private Sub frmTodaysCallbacksByAgent_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub refreshform()
        Me.Cursor = Cursors.WaitCursor
        Dim database As New Common.DataLayer
        Dim ds As DataSet
        Dim params As New Collection
        Dim enddate As DateTime = SDate.AddDays(1)
        database.CreateParameter(params, "@AgentID", SqlDbType.Int, iAgentID)
        database.CreateParameter(params, "@StartDate", SqlDbType.DateTime, SDate.ToLongDateString)
        database.CreateParameter(params, "@EndDate", SqlDbType.DateTime, enddate.ToLongDateString)
        ds = database.ExecuteSP("spTodaysCallBacks", params)

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
                If DR("AgentID") <> iAgentID Then
                    lvitem.BackColor = Color.LightSalmon
                End If

                lvitem.SubItems.Add(adate.ToLongDateString)
                Me.lvCallbacks.Items.Add(lvitem)
            Next

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
        Application.DoEvents()
        Dim Colwidth As Integer = CInt(lvCallbacks.ClientSize.Width / 7)
        lvCallbacks.Columns(1).Width = (Colwidth * 2.5) - 10
        lvCallbacks.Columns(2).Width = Colwidth * 0.5
        lvCallbacks.Columns(3).Width = Colwidth
        lvCallbacks.Columns(4).Width = Colwidth
        lvCallbacks.Columns(5).Width = Colwidth
        lvCallbacks.Columns(6).Width = Colwidth
        lvCallbacks.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmTodaysCallbacksByAgent_ResizeEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResizeEnd
        Application.DoEvents()
        Dim Colwidth As Integer = CInt(lvCallbacks.ClientSize.Width / 7)
        lvCallbacks.Columns(1).Width = (Colwidth * 2.5) - 10
        lvCallbacks.Columns(2).Width = Colwidth * 0.5
        lvCallbacks.Columns(3).Width = Colwidth
        lvCallbacks.Columns(4).Width = Colwidth
        lvCallbacks.Columns(5).Width = Colwidth
        lvCallbacks.Columns(6).Width = Colwidth
        lvCallbacks.ResumeLayout()
    End Sub

    Private Sub lvCallbacks_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvCallbacks.DoubleClick
        If lvCallbacks.SelectedItems.Count > 0 Then

            Using Afrm As New frmShowCompany(lvCallbacks.SelectedItems(0).Text)
                Afrm.ShowDialog()
            End Using
        End If
    End Sub


End Class