Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class FrmListenToCalls
    Private Sub FrmListToCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub LoadGrid(Company As Common.cCompany)
        Grid.DataSource = CallRecorder.CallRecorder.GetRecordingsForTelephoneNumbers(Company.Telephone, Company.MobileTelephone, Company.DirectTelephone)
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)

        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRow OrElse info.InRowCell Then
            Dim recording As CallRecorder.Recording = view.GetRow(info.RowHandle)

            AxWindowsMediaPlayer1.URL = ""
            CallRecorder.CallRecorder.GetRecording(recording.uid, recording.FileSize)
            AxWindowsMediaPlayer1.URL = "c:\\Client Data\\tmp.wav"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If SFD.ShowDialog() = DialogResult.OK Then
            FileCopy("c:\\Client Data\\tmp.wav", SFD.FileName)
        End If
    End Sub
End Class