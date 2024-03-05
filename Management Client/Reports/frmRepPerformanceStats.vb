Imports System.Drawing.Printing
Imports System.Drawing
Public Class frmRepPerformanceStats
    Dim WithEvents pd As Printing.PrintDocument

    Public PageCount As Integer
    Public Thispage As Integer

    Dim StartDate As DateTime
    Dim endDate As DateTime
    Dim Reps As Collection
    Dim Rep As ManagerConsole.AppointmentStats


    Dim printFont = New Font("Times New Roman", 10)
    Dim printFontB = New Font("Times New Roman", 11, FontStyle.Bold)
    Dim printFontBig = New Font("Times New Roman", 14, FontStyle.Bold)
    Dim printFontTitle = New Font("Times New Roman", 16, FontStyle.Bold)
    Dim printFontI = New Font("Times New Roman", 9, FontStyle.Italic)
    Dim printFontS = New Font("Times New Roman", 9)
    Dim printFontTotals = New Font("Times New Roman", 11)
    Dim printFontTotalsB = New Font("Times New Roman", 11, FontStyle.Bold)
    Dim printFontSm = New Font("Times New Roman", 8, FontStyle.Italic)

    Dim stringSize As New SizeF

    Private Sub frmRepPerformanceStats_ClientSizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ClientSizeChanged
        resizeme()
    End Sub
    Private Sub frmDailyStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        StartDate = Now.ToLongDateString
        endDate = StartDate.AddDays(1)
        pd = New PrintDocument
        EndDP.Value = endDate
        DTP1.Value = Now

        Dtime1.Text = "9:00"
        Dtime2.Text = "9:00"
    End Sub
    Private Sub RefreshStats()
        Me.Cursor = Cursors.WaitCursor
        Dim DS As DataSet
        Reps = New Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection

        Dim parDeskID As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parDeskID.Value = String.Format("{0} {1}", StartDate.ToLongDateString, Dtime1.Text)
        Params.Add(parDeskID)

        Dim parStatus As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parStatus.Value = String.Format("{0} {1}", endDate.ToLongDateString, Dtime2.Text)
        Params.Add(parStatus)

        DS = Database.ExecuteSP("GetRepPerformanceStats", Params)

        progress.Value = 0
        progress.Maximum = DS.Tables(0).Rows.Count




        For Each DR As DataRow In DS.Tables(0).Rows
            progress.Value += 1
            'If CInt(DR("Status")) = 2 Then
            Try
                Rep = Reps(DR("UserID").ToString)
            Catch ex As Exception
                Rep = New ManagerConsole.AppointmentStats
                Rep.ID = DR("userID")
                Rep.RealName = DR("RealName")
                Reps.Add(Rep, Rep.ID.ToString)
            End Try
            Rep.AddRecord(DR)
            'End If

        Next


        If ShowAsPercent.Checked Then
            Me.RefreshPercent()
        Else
            Me.RefreshNumbers()
        End If

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub RefreshNumbers()
        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        Dim lvTotal As ListViewItem = New ListViewItem
        lvTotal.BackColor = Color.AliceBlue
        lvTotal.Text = "aaa"
        lvTotal.SubItems.Add("Total")
        LVStats.Items.Add(lvTotal)
        For x As Integer = 2 To 15
            lvTotal.SubItems.Add("0")
        Next

        For Each Rep In Reps
            LVitem = New ListViewItem
            ' update screen
            LVitem.Text = Rep.RealName
            LVitem.SubItems.Add(Rep.RealName)
            LVitem.SubItems.Add(Format(Rep.AppointmentTotal, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.Unapproved, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.Approved, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.DeadTotal, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.DeadAgent, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.AppsSat, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.Sold, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.Value, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.Pending, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.NotSold, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.ToExpencive, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.ExistingMedical, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.NoFeedback, "#,###,##0"))

            For t As Integer = 2 To 14

                If LVitem.SubItems(t).Text = 0 Then
                    LVitem.SubItems(t).Text = ""
                Else
                    lvTotal.SubItems(t).Text = Format(CInt(lvTotal.SubItems(t).Text) + CInt(LVitem.SubItems(t).Text), "#,###,##0")
                End If
            Next
            LVStats.Items.Add(LVitem)
        Next
        resizeme()
    End Sub


    Private Sub resizeme()
        Application.DoEvents()
        Dim colsize As Integer = LVStats.ClientRectangle.Width / 15
        LVStats.Columns(1).Width = (colsize * 2) - 3
        For t As Integer = 2 To 14
            LVStats.Columns(t).Width = colsize
        Next
    End Sub


    Private Sub RefreshPercent()
        Dim LVitem As ListViewItem
        LVStats.Items.Clear()
        Dim aTotal As New ManagerConsole.AppointmentStats

        Dim lvTotal As ListViewItem = New ListViewItem
        lvTotal.BackColor = Color.AliceBlue
        lvTotal.Text = "aaa"
        lvTotal.SubItems.Add("Total")
        LVStats.Items.Add(lvTotal)
        For x As Integer = 2 To 14
            lvTotal.SubItems.Add("0")
        Next

        For Each Rep In Reps
            LVitem = New ListViewItem
            ' update screen

            LVitem.Text = Rep.RealName
            LVitem.SubItems.Add(Rep.RealName)
            LVitem.SubItems.Add(Format(Rep.AppointmentTotal, "#,###,##0"))
            aTotal.AppointmentTotal = aTotal.AppointmentTotal + Rep.AppointmentTotal

            LVitem.SubItems.Add(Format(Rep.PercentUnApproved, "#0.0"))
            aTotal.Unapproved = aTotal.Unapproved + Rep.Unapproved

            LVitem.SubItems.Add(Format(Rep.PercentApproved, "#0.0"))
            aTotal.Approved = aTotal.Approved + Rep.Approved
            LVitem.SubItems.Add(Format(Rep.PercentDeadTotal, "#0.0"))
            aTotal.DeadOther = aTotal.DeadOther + Rep.DeadTotal - Rep.DeadAgent
            LVitem.SubItems.Add(Format(Rep.PercentDeadAgent, "#0.0"))
            aTotal.DeadAgent = aTotal.DeadAgent + Rep.DeadAgent
            LVitem.SubItems.Add(Format(Rep.AppsSat, "#,###,##0"))
            LVitem.SubItems.Add(Format(Rep.PercentSold, "#0.0"))
            aTotal.Sold = aTotal.Sold + Rep.Sold
            LVitem.SubItems.Add(Format(Rep.AverageAPi, "#,###,##0"))
            aTotal.Value = aTotal.Value + Rep.Value
            LVitem.SubItems.Add(Format(Rep.PercentPending, "#0.0"))
            aTotal.Pending = aTotal.Pending + Rep.Pending
            LVitem.SubItems.Add(Format(Rep.PercentNotSold, "#0.0"))
            aTotal.NotSold = aTotal.NotSold + Rep.NotSold
            LVitem.SubItems.Add(Format(Rep.PercentToExpencive, "#0.0"))
            aTotal.ToExpencive = aTotal.ToExpencive + Rep.ToExpencive
            LVitem.SubItems.Add(Format(Rep.PercentExitingMedical, "#0.0"))
            aTotal.ExistingMedical = aTotal.ExistingMedical + Rep.ExistingMedical
            LVitem.SubItems.Add(Format(Rep.PercentNoFeedback, "#0.0"))
            aTotal.NoFeedback = aTotal.NoFeedback + Rep.NoFeedback
            For t As Integer = 2 To 14
                If LVitem.SubItems(t).Text = 0 Or LVitem.SubItems(t).Text = "NaN" Then
                    LVitem.SubItems(t).Text = ""
                End If
            Next

            LVStats.Items.Add(LVitem)
        Next
        lvTotal.SubItems(2).Text = Format(aTotal.AppointmentTotal, "#,###,##0")
        lvTotal.SubItems(3).Text = Format(aTotal.PercentUnApproved, "#0.0")
        lvTotal.SubItems(4).Text = Format(aTotal.PercentApproved, "#0.0")
        lvTotal.SubItems(5).Text = Format(aTotal.PercentDeadTotal, "#0.0")
        lvTotal.SubItems(6).Text = Format(aTotal.PercentDeadAgent, "#0.0")
        lvTotal.SubItems(7).Text = Format(aTotal.AppsSat, "#,###,##0")
        lvTotal.SubItems(8).Text = Format(aTotal.PercentSold, "#0.0")
        lvTotal.SubItems(9).Text = Format(aTotal.AverageAPi, "#,###,##0")
        lvTotal.SubItems(10).Text = Format(aTotal.PercentPending, "#0.0")
        lvTotal.SubItems(11).Text = Format(aTotal.PercentNotSold, "#0.0")
        lvTotal.SubItems(12).Text = Format(aTotal.PercentToExpencive, "#0.0")
        lvTotal.SubItems(13).Text = Format(aTotal.PercentExitingMedical, "#0.0")
        lvTotal.SubItems(14).Text = Format(aTotal.PercentNoFeedback, "#0.0")
        resizeme()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DTP1.ValueChanged
        StartDate = DTP1.Value.ToLongDateString
    End Sub



    Private Sub ShowAsPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ShowAsPercent.CheckedChanged
        Application.DoEvents()
        If ShowAsPercent.Checked Then
            Me.RefreshPercent()
        Else
            Me.RefreshNumbers()
        End If
    End Sub













    Private Sub EndDP_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EndDP.ValueChanged
        endDate = EndDP.Value.ToLongDateString & " 23:59:59"
    End Sub



    Private Sub LVStats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles LVStats.SelectedIndexChanged
        For Each lvitem As ListViewItem In LVStats.SelectedItems
            If lvitem.Tag = "Highlighted" Then
                lvitem.Tag = ""
                lvitem.BackColor = Color.White
            Else
                lvitem.Tag = "Highlighted"
                lvitem.BackColor = Color.LightCoral
            End If
        Next
        LVStats.SelectedItems.Clear()
    End Sub

    'Public Sub PrintOrderList(ByVal ev As PrintPageEventArgs)
    '    Dim linesPerPage As Single = 0
    '    Dim yPos As Single = 0
    '    Dim count As Integer = 0
    '    Dim leftMargin As Single = ev.MarginBounds.Left - 35
    '    Dim RightMargin As Single = ev.MarginBounds.Right + 30
    '    Dim topMargin As Single = ev.MarginBounds.Top
    '    Dim line As String = Nothing

    '    line = "Agent Statistics " & StartDate.ToLongDateString & " to " & endDate.ToLongDateString
    '    stringSize = ev.Graphics.MeasureString(line, printFontBig)
    '    ev.Graphics.DrawString(line, printFontBig, Brushes.Black, leftMargin + 20, 40, New StringFormat())

    '    ev.Graphics.DrawString("Page " & Thispage & " of " & PageCount, printFont, Brushes.Black, RightMargin - 125, 25, New StringFormat())

    '    ' header  data


    '    ev.Graphics.DrawString("Company", printFontB, Brushes.Black, leftMargin - 50, 90, New StringFormat())
    '    ev.Graphics.DrawString("#", printFontB, Brushes.Black, leftMargin + 100, 90, New StringFormat())
    '    ev.Graphics.DrawString("NC", printFontB, Brushes.Black, leftMargin + 150, 90, New StringFormat())
    '    ev.Graphics.DrawString("APP", printFontB, Brushes.Black, leftMargin + 200, 90, New StringFormat())
    '    ev.Graphics.DrawString("BO", printFontB, Brushes.Black, leftMargin + 250, 90, New StringFormat())
    '    ev.Graphics.DrawString("NApp", printFontB, Brushes.Black, leftMargin + 300, 90, New StringFormat())
    '    ev.Graphics.DrawString("CB", printFontB, Brushes.Black, leftMargin + 350, 90, New StringFormat())
    '    ev.Graphics.DrawString("RS", printFontB, Brushes.Black, leftMargin + 400, 90, New StringFormat())
    '    ev.Graphics.DrawString("NtH", printFontB, Brushes.Black, leftMargin + 450, 90, New StringFormat())
    '    ev.Graphics.DrawString("NI", printFontB, Brushes.Black, leftMargin + 500, 90, New StringFormat())
    '    ev.Graphics.DrawString("SU", printFontB, Brushes.Black, leftMargin + 550, 90, New StringFormat())
    '    ev.Graphics.DrawString("OA", printFontB, Brushes.Black, leftMargin + 600, 90, New StringFormat())
    '    ev.Graphics.DrawString("TPS", printFontB, Brushes.Black, leftMargin + 650, 90, New StringFormat())
    '    ev.Graphics.DrawString("NR", printFontB, Brushes.Black, leftMargin + 700, 90, New StringFormat())
    '    Dim nextline As Integer = 120
    '    Dim counter As Integer = 1
    '    For Each lvitem As ListViewItem In LVStats.Items

    '        ev.Graphics.DrawString(lvitem.SubItems(1).Text, printFontS, Brushes.Black, leftMargin - 50, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(2).Text, printFontS, Brushes.Black, leftMargin + 100, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(3).Text, printFontS, Brushes.Black, leftMargin + 150, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(4).Text, printFontS, Brushes.Black, leftMargin + 200, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(5).Text, printFontS, Brushes.Black, leftMargin + 250, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(6).Text, printFontS, Brushes.Black, leftMargin + 300, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(7).Text, printFontS, Brushes.Black, leftMargin + 350, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(8).Text, printFontS, Brushes.Black, leftMargin + 400, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(9).Text, printFontS, Brushes.Black, leftMargin + 450, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(10).Text, printFontS, Brushes.Black, leftMargin + 500, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(11).Text, printFontS, Brushes.Black, leftMargin + 550, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(12).Text, printFontS, Brushes.Black, leftMargin + 600, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(13).Text, printFontS, Brushes.Black, leftMargin + 650, nextline, New StringFormat())
    '        ev.Graphics.DrawString(lvitem.SubItems(14).Text, printFontS, Brushes.Black, leftMargin + 700, nextline, New StringFormat())


    '        lvitem.Remove()
    '        nextline = nextline + 20
    '        counter = counter + 1
    '        If counter = 46 Then

    '            Exit For
    '        End If
    '    Next

    '    If LVStats.Items.Count > 0 Then
    '        ' has more to print 
    '        ev.HasMorePages = True
    '        Thispage = Thispage + 1
    '        line = Format("Continued on Page " & Thispage)
    '        stringSize = ev.Graphics.MeasureString(line, printFont)
    '        ev.Graphics.DrawString(line, printFontS, Brushes.Black, RightMargin - 40 - stringSize.Width, 1055, New StringFormat())
    '    Else
    '        'done print totals 
    '        'totals section 
    '        ev.HasMorePages = False
    '    End If


    'End Sub
    'Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
    '    PrintOrderList(e)
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
    '    If LVStats.Items.Count > 0 Then

    '        Me.PrintDialog1.Document = pd
    '        If PrintDialog1.ShowDialog = DialogResult.OK Then
    '            PageCount = Decimal.Ceiling(LVStats.Items.Count / 46)
    '            Thispage = 1
    '            pd.Print()
    '            RefreshStats()
    '        End If
    '    Else
    '        MsgBox("Your trying to print a report with no records")
    '    End If
    'End Sub



End Class