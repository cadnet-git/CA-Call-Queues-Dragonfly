Public Class frmYearsCallbacks
    Dim _type As String
    Public Sub New(type As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _type = type
    End Sub
    Private Sub frmYearsCallbacks_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim DS As DataSet

        Dim StartDate As DateTime = Now.AddDays(-Now.Day + 1).ToLongDateString & " 00:00:00"
        Dim Database As New CADNet.CallQueues.Common.DataLayer

        Dim Params As New Collection
        Database.CreateParameter(Params, "@StartDate", SqlDbType.DateTime, StartDate)
        Database.CreateParameter(Params, "@EndDate", SqlDbType.DateTime, StartDate.AddYears(1))

        If _type = "Rep" Then
            DS = Database.ExecuteSP("spRepFutureCallbacks", Params)
        Else
            DS = Database.ExecuteSP("spFutureCallbacks", Params)
        End If

        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        PivotGridControl1.DataSource = DS.Tables(0)

    End Sub

    Private Sub ExportToXlsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportToXlsToolStripMenuItem.Click
        If sfd.ShowDialog = DialogResult.OK Then
            PivotGridControl1.ExportToXls(sfd.FileName)
        End If
    End Sub
End Class