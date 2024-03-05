Public Class FrmAreaStats

    Private Enum Cols
        AreaID
        Title
        Records
        Free
        OnHold
        Appointment
        Sale
        Callback
        ColdCall
        NotToHand
        Supervisor
        NotANumber
        OutOfArea
        Gone
    End Enum
    Private Sub FrmAreaStats_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load





    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Refreshform()
    End Sub
    Private Sub Refreshform()
        Dim ado As New Common.DataLayer
        Dim DS As DataSet
        Dim LVitem As ListViewItem
        Dim sSQL As String = ""
        lvwAreas.SuspendLayout()
        DS = ado.ExecuteSQL("Select ID,Title from Areas order by title")
        Me.lvwAreas.Items.Clear()
        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("ID")
            LVitem.SubItems.Add(Common.StringManipulation.TitleCase(DR("Title")))
            For t As Integer = 1 To 12
                LVitem.SubItems.Add("0")
            Next
            Me.lvwAreas.Items.Add(LVitem)
        Next
        PBar.Maximum = lvwAreas.Items.Count
        PBar.Visible = True
        TBLabel.Visible = True
        For Each LVitem In Me.lvwAreas.Items
            PBar.Value = PBar.Value + 1

            ' get free records 
            sSQL = "SELECT COUNT(Companies.ID) AS Recs"
            sSQL = sSQL & " FROM Companies LEFT OUTER JOIN PostCodePrefixes ON Companies.PostCodeID = PostCodePrefixes.ID LEFT OUTER JOIN"
            sSQL = sSQL & " Areas ON PostCodePrefixes.AreaID = Areas.ID"
            sSQL = sSQL & " WHERE (PostCodePrefixes.AreaID = " & LVitem.Text & ") AND (Companies.CompanyStatus = 'ColdCall') And (HoldUntil < CONVERT(Datetime, '" & Now.ToLongDateString & " " & Now.ToLongTimeString & "'))"
            ' sSQL = sSQL & " GROUP BY Companies.CompanyStatus"
            DS = ado.ExecuteSQL(sSQL)

            Try
                Dim DR As DataRow = DS.Tables(0).Rows(0)
                ' LVitem.SubItems(Cols.Records).Text = LVitem.SubItems(Cols.Records).Text + DR("Recs")
                LVitem.SubItems(Cols.Free).Text = LVitem.SubItems(Cols.Free).Text + DR("Recs")
            Catch ex As Exception

            End Try

            sSQL = "SELECT COUNT(Companies.ID) AS Recs"
            sSQL = sSQL & " FROM Companies LEFT OUTER JOIN PostCodePrefixes ON Companies.PostCodeID = PostCodePrefixes.ID LEFT OUTER JOIN"
            sSQL = sSQL & " Areas ON PostCodePrefixes.AreaID = Areas.ID"
            sSQL = sSQL & " WHERE (PostCodePrefixes.AreaID = " & LVitem.Text & ")  And  (HoldUntil >= CONVERT(Datetime, '" & Now.ToLongDateString & " " & Now.ToLongTimeString & "'))"
            '  sSQL = sSQL & " GROUP BY Companies.CompanyStatus"
            DS = ado.ExecuteSQL(sSQL)
            Try
                Dim DR As DataRow = DS.Tables(0).Rows(0)
                ' LVitem.SubItems(Cols.Records).Text = LVitem.SubItems(Cols.Records).Text + DR("Recs")
                LVitem.SubItems(Cols.OnHold).Text = LVitem.SubItems(Cols.OnHold).Text + DR("Recs")
            Catch ex As Exception

            End Try


            ' get records agents have control of 
            sSQL = "SELECT COUNT(Companies.ID) AS Recs, Companies.CompanyStatus "
            sSQL = sSQL & " FROM Companies LEFT OUTER JOIN PostCodePrefixes ON Companies.PostCodeID = PostCodePrefixes.ID LEFT OUTER JOIN"
            sSQL = sSQL & " Areas ON PostCodePrefixes.AreaID = Areas.ID"
            sSQL = sSQL & " WHERE (PostCodePrefixes.AreaID = " & LVitem.Text & ") "
            sSQL = sSQL & " GROUP BY Companies.CompanyStatus"
            DS = ado.ExecuteSQL(sSQL)
            For Each DR As DataRow In DS.Tables(0).Rows
                Select Case DR("CompanyStatus")
                    Case "Appointment"
                        LVitem.SubItems(Cols.Appointment).Text = LVitem.SubItems(Cols.Appointment).Text + DR("Recs")
                    Case "Sale"
                        LVitem.SubItems(Cols.Sale).Text = LVitem.SubItems(Cols.Sale).Text + DR("Recs")
                    Case "CallBack"
                        LVitem.SubItems(Cols.Callback).Text = LVitem.SubItems(Cols.Callback).Text + DR("Recs")
                    Case "ColdCall"
                        LVitem.SubItems(Cols.ColdCall).Text = LVitem.SubItems(Cols.ColdCall).Text + DR("Recs")
                    Case "Supervisor"
                        LVitem.SubItems(Cols.Supervisor).Text = LVitem.SubItems(Cols.Supervisor).Text + DR("Recs")
                    Case "OutOfArea"
                        LVitem.SubItems(Cols.OutOfArea).Text = LVitem.SubItems(Cols.OutOfArea).Text + DR("Recs")
                    Case "NotToHand"
                        LVitem.SubItems(Cols.NotToHand).Text = LVitem.SubItems(Cols.NotToHand).Text + DR("Recs")
                    Case "InvalidNumber"
                        LVitem.SubItems(Cols.NotANumber).Text = LVitem.SubItems(Cols.NotANumber).Text + DR("Recs")
                    Case "Gone", "NotFound", "NotSure"
                        LVitem.SubItems(Cols.Gone).Text = LVitem.SubItems(Cols.Gone).Text + DR("Recs")
                End Select
                LVitem.SubItems(Cols.Records).Text = LVitem.SubItems(Cols.Records).Text + DR("Recs")


            Next


            For t As Integer = 2 To 12
                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next

        Next
        lvwAreas.ResumeLayout()
        PBar.Visible = False
        TBLabel.Visible = False
    End Sub



End Class
