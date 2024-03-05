Imports CADNet.CallQueues

Public Class DiaryListView

    Public Event RangeChange(ByVal Startdate As Date)

    Private dStartDate As Date
    Private iDiaryID As Integer = 0    'whose diary?

    Private colItems As New Collection

    Public ReadOnly Property Items() As Collection
        Get
            Items = colItems
        End Get
    End Property
    Public Property StartDate() As Date
        Get
            StartDate = dStartDate
        End Get
        Set(ByVal value As Date)
            If value.Date <> dStartDate Then
                dStartDate = value.Date
                RefreshControl()

                RaiseEvent RangeChange(dStartDate)
            End If
        End Set
    End Property
    Public Property DiaryID() As Integer
        Get
            DiaryID = iDiaryID
        End Get
        Set(ByVal value As Integer)
            If iDiaryID <> value Then
                iDiaryID = value
            End If
            RefreshControl()
        End Set
    End Property
    Private Sub RefreshControl()

        lblNoDiaryID.Visible = False

        Me.SuspendLayout()
        'remove all the previous items
        Do Until colItems.Count = 0
            Dim anItem As DiaryListItem = Me.colItems(1)
            RemoveHandler anItem.Click, AddressOf DiaryItemClick
            Me.Controls.Remove(anItem)
            Me.pnlAppointments.Controls.Remove(anItem)
            Me.colItems.Remove(1)
        Loop


        Me.lblNoAppointments.Visible = False
        Me.lblUpdating.Visible = True
        Me.ResumeLayout()

        Application.DoEvents()

        Me.SuspendLayout()

        Dim dEndDate As DateTime = DateAdd(DateInterval.Day, 7, dStartDate)

        Dim sTemp As String = ""
        sTemp = Common.DateManipulation.GetDateDescription(dStartDate, False)
        If dEndDate.Month <> dStartDate.Month Then
            sTemp = sTemp & " "
            sTemp = sTemp & dStartDate.ToString("MMM")
        End If
        If dEndDate.Year <> dStartDate.Year Then
            sTemp = sTemp & " "
            sTemp = sTemp & dStartDate.Year
        End If
        sTemp = sTemp & " - "
        sTemp = sTemp & Common.DateManipulation.GetDateDescription(dEndDate, False)
        sTemp = sTemp & " "
        sTemp = sTemp & dEndDate.ToString("MMM")
        sTemp = sTemp & " "
        sTemp = sTemp & " " & dEndDate.Year

        Me.lblThisWeek.Text = sTemp

        If iDiaryID < 1 Then
            lblNoDiaryID.Visible = True
            Me.pnlControls.Visible = False
        Else
            Me.pnlControls.Visible = True
        End If

        'get the appointments for the date range

        Dim sSQL As String = ""

        sSQL = "SELECT * FROM vwAppointments"
        sSQL = sSQL & " WHERE"
        sSQL = sSQL & " UserID=" & iDiaryID
        sSQL = sSQL & " AND DATEDIFF(day ,'" & Common.DateManipulation.FormatSQLDate(dStartDate) & "',ItemDate) >=0 "
        sSQL = sSQL & " AND DATEDIFF(day ,'" & Common.DateManipulation.FormatSQLDate(dStartDate) & "',ItemDate) <=6 "
        sSQL = sSQL & " ORDER BY ItemDate, ItemPeriod"

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSQL(sSQL)

        If DS.Tables(0).Rows.Count = 0 Then
            Me.lblNoAppointments.Visible = True
        Else
            Dim aPrevDate As Date
            For Each aRow As DataRow In DS.Tables(0).Rows
                'add a control for each item

                Dim dTime As DateTime

                Dim bSkip As Boolean = False
                Select Case aRow.Item("ItemPeriod")
                    Case 1
                        dTime = aRow.Item("AppTime1")
                    Case 2
                        dTime = aRow.Item("AppTime2")
                    Case 3
                        dTime = aRow.Item("AppTime3")
                    Case 4
                        dTime = aRow.Item("AppTime4")
                    Case 5
                        dTime = aRow.Item("AppTime5")
                    Case Else
                        Dim sMsg As String = "Unexpected Period for Appointment: "
                        sMsg = sMsg & vbCrLf & "Appointment" & vbTab & aRow.Item("ID")
                        sMsg = sMsg & vbCrLf & "Period" & vbTab & aRow.Item("ItemPeriod")

                        MessageBox.Show(sMsg)

                        bSkip = True
                End Select

                If bSkip = False Then
                    Dim sCompanyName As String = ""
                    If aRow.Item("CompanyName") Is DBNull.Value Then
                        sCompanyName = "<unknown>"
                    Else
                        sCompanyName = aRow.Item("CompanyName")
                    End If

                    Dim sAreaName As String = ""
                    If aRow.Item("AreaName") Is DBNull.Value Then
                        sAreaName = ""
                    Else
                        sAreaName = aRow.Item("AreaName")
                    End If
                    Dim aCtl As New DiaryListItem(aRow.Item("ID"), aRow.Item("ItemDate"), dTime, sCompanyName, sAreaName)

                    If CDate(aRow.Item("ItemDate")).Date <> aPrevDate Then

                        aPrevDate = CDate(aRow.Item("ItemDate")).Date
                    Else
                        aCtl.HideDate()
                    End If


                    pnlAppointments.Controls.Add(aCtl)

                    With aCtl
                        .Top = 1 + colItems.Count * aCtl.Height
                        .Left = 1

                        .Show()
                    End With

                    AddHandler aCtl.Click, AddressOf DiaryItemClick
                    colItems.Add(aCtl)
                End If

            Next
        End If


        Me.lblUpdating.Visible = False

        Me.ResumeLayout()
    End Sub


    Private Sub DiaryItemClick(ByVal sender As System.Object, ByVal e As EventArgs)
        'MessageBox.Show("DiaryItem Click")

        Dim anItem As DiaryListItem = sender

        Dim aFrm As New frmAppoinmentDetail(anItem.ID)
        aFrm.ShowDialog()

        RefreshControl()

    End Sub


    Private Sub btnWeekForward_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnWeekForward.Click
        dStartDate = DateAdd(DateInterval.Day, 7, dStartDate)
        RefreshControl()

        RaiseEvent RangeChange(dStartDate)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        dStartDate = DateAdd(DateInterval.Day, -7, dStartDate)
        RefreshControl()

        RaiseEvent RangeChange(dStartDate)
    End Sub

    Private Sub DiaryListView_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        With Me.lblNoAppointments
            .Dock = DockStyle.Fill
        End With

        With Me.lblNoDiaryID
            .Dock = DockStyle.Fill
        End With

        With Me.lblUpdating
            .Dock = DockStyle.Fill
        End With

        RefreshControl()

    End Sub

    Private Sub btnThisWeek_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnThisWeek.Click
        dStartDate = Common.DateManipulation.GetStartOfWeek(Date.Now)
        RefreshControl()

        RaiseEvent RangeChange(dStartDate)
    End Sub

    Private Sub btnAddAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAddAppointment.Click
        Dim aFrm As New frmCreateAppointment(iDiaryID)
        aFrm.DiaryListView1.StartDate = StartDate
        aFrm.ShowDialog()

        RefreshControl()

    End Sub

End Class
