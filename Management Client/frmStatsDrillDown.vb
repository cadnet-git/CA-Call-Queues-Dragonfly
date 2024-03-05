Public Class frmStatsDrillDown
    Public Type As String
    Public Sub LoadData(ByVal Type As String, ByVal UserID As Integer, ByVal StartDate As DateTime, ByVal enddate As DateTime)

        Dim ds As DataSet
        Dim LVitem As ListViewItem

        Dim Params As New Collection

        Dim parUserID As New SqlClient.SqlParameter("@UserID", SqlDbType.Int)
        parUserID.Value = UserID
        Params.Add(parUserID)

        Dim parType As New SqlClient.SqlParameter("@Type", SqlDbType.NVarChar)
        parType.Value = Type
        Params.Add(parType)

        Dim parSD As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parSD.Value = StartDate
        Params.Add(parSD)

        Dim parED As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parED.Value = enddate
        Params.Add(parED)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        ds = Database.ExecuteSP("spGetStatsDetail", Params)
        LVDetails.Items.Clear()
        For Each DR As DataRow In ds.Tables(0).Rows
            LVitem = New ListViewItem
            LVitem.Text = DR("CompanyID")
            LVitem.SubItems.Add(DR("Telephone"))
            LVitem.SubItems.Add(DR("CallFailureReason"))
            LVitem.SubItems.Add(DR("ID"))
            LVitem.UseItemStyleForSubItems = True

            Select Case DR("StatusChecked")
                Case 1
                    LVitem.BackColor = Color.Gainsboro
                Case 2
                    LVitem.BackColor = Color.NavajoWhite
                Case Else
                    LVitem.BackColor = Color.White
            End Select
          
            Me.LVDetails.Items.Add(LVitem)
        Next



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Me.Parent.Controls("frmDailyStats").Show()
        Catch ex As Exception

        End Try

        Me.Close()
    End Sub


    Private Sub LVDetails_ClientSizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LVDetails.ClientSizeChanged

        Try
            LVDetails.Columns(1).Width = CInt(LVDetails.ClientSize.Width / 3)
            LVDetails.Columns(2).Width = CInt(LVDetails.ClientSize.Width / 3 * 2) - 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LVDetails_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LVDetails.DoubleClick
        If LVDetails.SelectedItems.Count > 0 Then

            Select Case Me.lblType.Text
                Case Is = "TPS"
                    checknumber(LVDetails.SelectedItems(0), "Is a TPS Number")
                Case "Not a Number"
                    checknumber(LVDetails.SelectedItems(0), "Is not a Number")
                Case "Not Interested"
                    Dim afrm As New frmCheckNotinterested
                    afrm.ID = LVDetails.SelectedItems(0).SubItems(3).Text
                    afrm.CompanyID = LVDetails.SelectedItems(0).SubItems(0).Text
                    afrm.cbCallBack.SelectedIndex = 0
                    afrm.txtReason.Text = LVDetails.SelectedItems(0).SubItems(2).Text
                    If afrm.ShowDialog = DialogResult.OK Then
                        LVDetails.SelectedItems(0).BackColor = Color.NavajoWhite
                    Else
                        LVDetails.SelectedItems(0).BackColor = Color.Gainsboro
                    End If
                Case Else
                    Dim checkNumber As New FrmCheckNumber
                    checkNumber.BtnOK.Text = "Supervisor Ok"
                    If checkNumber.ShowDialog() = DialogResult.Yes Then
                        ' need to put back in to data 
                        Dim theCompany As New Common.cCompany(LVDetails.SelectedItems(0).Text)

                        With theCompany
                            .Status = "ColdCall"
                            .CallBackOn(Now.AddMinutes(15))
                            .Save()
                        End With
                        Dim dObj As New Common.DataLayer
                        dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=2 where ID=" & LVDetails.SelectedItems(0).SubItems(3).Text)
                        LVDetails.SelectedItems(0).BackColor = Color.NavajoWhite
                    Else
                        Dim dObj As New Common.DataLayer
                        dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=1 where ID=" & LVDetails.SelectedItems(0).SubItems(3).Text)
                        LVDetails.SelectedItems(0).BackColor = Color.Gainsboro
                    End If
            End Select
        End If
    End Sub

    Private Sub checknumber(ByVal LVitem As ListViewItem, ByVal BtnTitle As String)
        Dim checkNumber As New FrmCheckNumber
        checkNumber.BtnOK.Text = BtnTitle
        Try
            frmManagementConsole.aDialer = New Common.cDialer
            Application.DoEvents()
            frmManagementConsole.aDialer.NumberToDial = LVitem.SubItems(1).Text
            Application.DoEvents()
            System.Threading.Thread.Sleep(500)
            frmManagementConsole.aDialer.Dial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If checkNumber.ShowDialog() = DialogResult.Yes Then
            ' need to put back in to data 
            Dim theCompany As New Common.cCompany(LVitem.Text)
            With theCompany
                .Status = "ColdCall"
                .CallBackOn(Now.AddMinutes(15))
                .Save()
            End With
            Dim dObj As New Common.DataLayer
            dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=2 where ID=" & LVDetails.SelectedItems(0).SubItems(3).Text)
            LVDetails.SelectedItems(0).BackColor = Color.NavajoWhite
        Else
            Dim dObj As New Common.DataLayer
            dObj.ExecuteSQL("UPDATE CompanyHistory Set StatusChecked=1 where ID=" & LVDetails.SelectedItems(0).SubItems(3).Text)
            LVDetails.SelectedItems(0).BackColor = Color.Gainsboro

        End If

        ' disconnect call 
        Try
            frmManagementConsole.aDialer.Disconnect()
            Application.DoEvents()
            System.Threading.Thread.Sleep(500)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub pnlAreaHeader_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAreaHeader.Paint

    End Sub



    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim afrm As New frmShowCompany(Me.LVDetails.SelectedItems(0).Text)
        afrm.ShowDialog()
    End Sub
End Class