Public Class FrmRepToCompany


    Private Enum Cols
        AreaID
        Title
        Records
        Live
        Appointment
        Sale
        Callback
        ColdCall
        NotToHand
        Dead
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

        DS = ado.ExecuteSQL("Select ID,RealName from Users Where userlevelID=4 order by realname")
        Me.lvwAreas.Items.Clear()
        For Each DR As DataRow In DS.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("ID")
            LVitem.SubItems.Add(Common.StringManipulation.TitleCase(DR("RealName")))
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
           

            ' get records agents have control of 

            Dim params As New Collection
            ado.CreateParameter(params, "@RepID", SqlDbType.Int, LVitem.Text)


            DS = ado.ExecuteSP("spCompaniestoRepStats ", params)
            For Each DR As DataRow In DS.Tables(0).Rows
                Select Case DR("CompanyStatus")
                    Case "Appointment"
                        LVitem.SubItems(Cols.Appointment).Text = LVitem.SubItems(Cols.Appointment).Text + DR("Total")
                        LVitem.SubItems(Cols.Live).Text = LVitem.SubItems(Cols.Live).Text + DR("Total")
                    Case "CallBack"
                        LVitem.SubItems(Cols.Callback).Text = LVitem.SubItems(Cols.Callback).Text + DR("Total")
                        LVitem.SubItems(Cols.Live).Text = LVitem.SubItems(Cols.Live).Text + DR("Total")
                    Case "ColdCall"
                        LVitem.SubItems(Cols.ColdCall).Text = LVitem.SubItems(Cols.ColdCall).Text + DR("Total")
                        LVitem.SubItems(Cols.Live).Text = LVitem.SubItems(Cols.Live).Text + DR("Total")
                    Case "Sale"
                        LVitem.SubItems(Cols.Sale).Text = LVitem.SubItems(Cols.Sale).Text + DR("Total")
                        LVitem.SubItems(Cols.Live).Text = LVitem.SubItems(Cols.Live).Text + DR("Total")
                    Case "Supervisor"
                        LVitem.SubItems(Cols.Supervisor).Text = LVitem.SubItems(Cols.Supervisor).Text + DR("Total")
                        LVitem.SubItems(Cols.Dead).Text = LVitem.SubItems(Cols.Dead).Text + DR("Total")
                    Case "OutOfArea"
                        LVitem.SubItems(Cols.OutOfArea).Text = LVitem.SubItems(Cols.OutOfArea).Text + DR("Total")
                        LVitem.SubItems(Cols.Dead).Text = LVitem.SubItems(Cols.Dead).Text + DR("Total")
                    Case "NotToHand"
                        LVitem.SubItems(Cols.NotToHand).Text = LVitem.SubItems(Cols.NotToHand).Text + DR("Total")
                        LVitem.SubItems(Cols.Live).Text = LVitem.SubItems(Cols.Live).Text + DR("Total")
                    Case "InvalidNumber"
                        LVitem.SubItems(Cols.NotANumber).Text = LVitem.SubItems(Cols.NotANumber).Text + DR("Total")
                        LVitem.SubItems(Cols.Dead).Text = LVitem.SubItems(Cols.Dead).Text + DR("Total")
                    Case "Gone", "NotFound", "Notsure"
                        LVitem.SubItems(Cols.Gone).Text = LVitem.SubItems(Cols.Gone).Text + DR("Total")
                        LVitem.SubItems(Cols.Dead).Text = LVitem.SubItems(Cols.Dead).Text + DR("Total")
                End Select
                LVitem.SubItems(Cols.Records).Text = LVitem.SubItems(Cols.Records).Text + DR("Total")


            Next

           
            For t As Integer = 2 To 13
                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next

        Next

        For Each LVitem In Me.lvwAreas.Items
            If LVitem.SubItems(Cols.Records).Text = "" Then
                lvwAreas.Items.Remove(LVitem)
            End If
        Next



        lvwAreas.ResumeLayout()
        PBar.Visible = False
        TBLabel.Visible = False
    End Sub

    Private Sub pnlAreaHeader_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAreaHeader.Paint

    End Sub
End Class