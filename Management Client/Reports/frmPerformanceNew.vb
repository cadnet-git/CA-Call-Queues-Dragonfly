

Public Class frmPerformanceNew

    Public Property IsAgentReport As Integer

    Private Sub frmRepPerformanceNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        DTPStart.Value = Now.ToLongDateString
        DTPEnd.Value = Now.AddDays(1).ToLongDateString
        AdvBandedGridView1.OptionsView.ShowFooter = False
    End Sub
    Dim reps As Collection

    Private Sub RefreshStats()
        Cursor = Cursors.WaitCursor
        Dim DS As DataSet
        reps = New Collection

        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection
        Database.CreateParameter(Params, "@IsAgent", SqlDbType.Int, IsAgentReport)
        Database.CreateParameter(Params, "@StartDate", SqlDbType.DateTime, DTPStart.Value.ToLongDateString & " 00:00")
        Database.CreateParameter(Params, "@EndDate", SqlDbType.DateTime, DTPEnd.Value.ToLongDateString & " 23:59:59")

        DS = Database.ExecuteSP("GetPerformanceStats", Params)

        'progress.Value = 0
        'progress.Maximum = DS.Tables(0).Rows.Count
        Dim totalRep As New AppointmentStatsNewHeader() With {.ID = -1, .RealName = " Total"}


        Dim rep As AppointmentStatsNewHeader

        For Each DR As DataRow In DS.Tables(0).Rows
            'progress.Value += 1
            'If CInt(DR("Status")) = 2 Then
            Try
                rep = reps(DR("UserID").ToString)
            Catch ex As Exception
                rep = New AppointmentStatsNewHeader
                rep.ID = DR("userID")
                rep.RealName = DR("RealName")
                reps.Add(rep, rep.ID.ToString)
            End Try
            rep.AddRecord(DR)
            'End If
            '  totalRep.AddRecord(DR)
        Next

        ' reps.Add(totalRep)

        Grid.DataSource = reps
        Grid.RefreshDataSource()

        Cursor = Cursors.Default

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshStats()
        BtnExport.Visible = True
        AdvBandedGridView1.OptionsView.ShowFooter = True
    End Sub


    Private Sub AdvBandedGridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles AdvBandedGridView1.RowStyle
        If e.RowHandle < 0 Then Return
        Dim row As AppointmentStatsNewHeader = AdvBandedGridView1.GetRow(e.RowHandle)
        If row.ID = -1 Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
            e.Appearance.Options.UseBorderColor = True
            e.Appearance.BorderColor = Color.Black
        End If


    End Sub

    Private Sub AdvBandedGridView1_CustomDrawCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles AdvBandedGridView1.CustomDrawCell

        If e.RowHandle < 0 Then Return
        If IsNumeric(e.CellValue) Then
            If e.CellValue = 0 Then
                e.DisplayText = ""
            End If
        End If
    End Sub

    Private Sub AdvBandedGridView1_CustomDrawFooter(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles AdvBandedGridView1.CustomDrawFooter
        Dim b As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.DimGray, Color.DimGray, System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(b, e.Bounds)
        ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

    Private Sub BtnExport_Click(sender As System.Object, e As EventArgs) Handles BtnExport.Click
        If sfd.ShowDialog = DialogResult.OK Then

            Grid.ExportToXls(sfd.FileName)
        End If
        Application.DoEvents()
        Dim p As New System.Diagnostics.Process
        p.StartInfo.FileName = sfd.FileName
        p.Start()
    End Sub

    Private Sub cbReportType_SelectedIndexChanged(sender As System.Object, e As EventArgs) Handles cbReportType.SelectedIndexChanged
        If cbReportType.Text = "Rep" Then
            IsAgentReport = 0
        Else
            IsAgentReport = 1
        End If
    End Sub
End Class