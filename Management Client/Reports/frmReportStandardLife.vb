Imports System.Drawing.Printing
Imports System.Drawing
Public Class frmReportStandardLife
    Dim WithEvents pd As Printing.PrintDocument


    Public PageCount As Integer
    Public Thispage As Integer
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
    Private Sub frmReportStandardLife_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        pd = New PrintDocument
        ResizeMe()
        Me.StartDP.Value = Now.ToLongDateString & " 00:01"
        Me.EndDP.Value = Now.ToLongDateString & " 23:59"
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        PrintOrderList(e)
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnFind.Click
        refreshform(Me.StartDP.Value, Me.EndDP.Value)
    End Sub
    Private Sub refreshform(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

        Dim Params As New Collection
        Dim parStartDate As New SqlClient.SqlParameter("@StartDate", SqlDbType.DateTime)
        parStartDate.Value = StartDate
        Params.Add(parStartDate)

        Dim parEndDate As New SqlClient.SqlParameter("@EndDate", SqlDbType.DateTime)
        parEndDate.Value = EndDate
        Params.Add(parEndDate)

        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("GetStandardLifeApps", Params)
        Me.LVApps.Items.Clear()
        Dim lvitem As ListViewItem
        For Each DR As DataRow In DS.Tables(0).Rows
            lvitem = New ListViewItem
            lvitem.Text = DR("ID").ToString
            lvitem.SubItems.Add(DR("CompanyName").ToString)
            lvitem.SubItems.Add(DR("Telephone").ToString)
            Dim aDate As DateTime = DR("Created")
            lvitem.SubItems.Add(aDate.ToLongDateString)
            LVApps.Items.Add(lvitem)
        Next
        lblRecs.Text = DS.Tables(0).Rows.Count
        ResizeMe()
    End Sub
    Private Sub ResizeMe()
        Dim colwidth As Integer = LVApps.ClientSize.Width / 4
        LVApps.Columns(0).Width = 0
        LVApps.Columns(1).Width = (colwidth * 2) - 3
        LVApps.Columns(2).Width = colwidth
        LVApps.Columns(3).Width = colwidth
    End Sub

    Public Sub PrintOrderList(ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left - 35
        Dim RightMargin As Single = ev.MarginBounds.Right + 30
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        line = "Standard Life Appointments " & Me.StartDP.Value.ToLongDateString & " to " & Me.EndDP.Value.ToLongDateString
        stringSize = ev.Graphics.MeasureString(line, printFontBig)
        ev.Graphics.DrawString(line, printFontBig, Brushes.Black, leftMargin + 20, 40, New StringFormat())

        ev.Graphics.DrawString("Page " & Thispage & " of " & PageCount, printFont, Brushes.Black, RightMargin - 125, 25, New StringFormat())

        ' header  data


        ev.Graphics.DrawString("Company", printFontB, Brushes.Black, leftMargin + 20, 90, New StringFormat())
        ev.Graphics.DrawString("Telephone", printFontB, Brushes.Black, leftMargin + 400, 90, New StringFormat())
        ev.Graphics.DrawString("Date", printFontB, Brushes.Black, leftMargin + 600, 90, New StringFormat())

        Dim nextline As Integer = 120
        Dim counter As Integer = 1
        For Each lvitem As ListViewItem In LVApps.Items

            ev.Graphics.DrawString(lvitem.SubItems(1).Text, printFontS, Brushes.Black, leftMargin + 20, nextline, New StringFormat())
            ev.Graphics.DrawString(lvitem.SubItems(2).Text, printFontS, Brushes.Black, leftMargin + 400, nextline, New StringFormat())
            ev.Graphics.DrawString(lvitem.SubItems(3).Text, printFontS, Brushes.Black, leftMargin + 600, nextline, New StringFormat())

            lvitem.Remove()
            nextline = nextline + 20
            counter = counter + 1
            If counter = 46 Then

                Exit For
            End If
        Next

        If LVApps.Items.Count > 0 Then
            ' has more to print 
            ev.HasMorePages = True
            Thispage = Thispage + 1
            line = Format("Continued on Page " & Thispage)
            stringSize = ev.Graphics.MeasureString(line, printFont)
            ev.Graphics.DrawString(line, printFontS, Brushes.Black, RightMargin - 40 - stringSize.Width, 1055, New StringFormat())
        Else
            'done print totals 
            'totals section 
            ev.HasMorePages = False
        End If


    End Sub



    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles PrintToolStripMenuItem.Click

        If LVApps.Items.Count > 0 Then

            Me.PrintDialog1.Document = pd
            If PrintDialog1.ShowDialog = DialogResult.OK Then
                PageCount = Decimal.Ceiling(LVApps.Items.Count / 46)
                Thispage = 1
                pd.Print()
                refreshform(Me.StartDP.Value, Me.EndDP.Value)
            End If
        Else
            MsgBox("Your trying to print a report with no records")
        End If

    End Sub
End Class