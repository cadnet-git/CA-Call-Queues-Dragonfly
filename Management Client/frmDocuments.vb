Public Class frmDocuments
    Dim path As String = "\\ca-sql\c$\Website\s\Files\"
    Dim cID As Integer


    Private Sub frmDocuments_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load

        Select Case My.Computer.Name.ToUpper
            Case "LAPTOPXPS"
                path = "C:\Cadnet Team\Callqueues - C A HeathCare\CA Healthcare\Web Site\s\Files\"
        End Select
    End Sub
    Public Sub LoadDocs(companyID As Integer)
        cID = companyID
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        LVDocuments.SuspendLayout()
        Using DsDocs As DataSet = Database.ExecuteSQL(String.Format("SELECT AppointmentDocuments.ID, AppointmentDocuments.DateCreated, AppointmentDocuments.Title, AppointmentDocuments.FileName, Users.RealName FROM AppointmentDocuments INNER JOIN   Users ON AppointmentDocuments.UserID = Users.ID  WHERE(CompanyID = {0}) ORDER BY DateCreated DESC", companyID))
            LVDocuments.Items.Clear()
            Dim lvi As ListViewItem
            For Each dr As DataRow In DsDocs.Tables(0).Rows
                lvi = New ListViewItem()
                lvi.Text = dr("ID")
                lvi.SubItems.Add(dr("DateCreated").ToString)
                lvi.SubItems.Add(dr("RealName").ToString)
                lvi.SubItems.Add(dr("Title").ToString)
                lvi.SubItems.Add(dr("FileName").ToString)
                LVDocuments.Items.Add(lvi)
            Next
        End Using
        LVDocuments.ResumeLayout()
    End Sub

    Private Sub LVDocuments_DoubleClick(sender As Object, e As EventArgs) Handles LVDocuments.DoubleClick
        If LVDocuments.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = LVDocuments.SelectedItems(0)
            Dim temppath As String = String.Format("{0}{1}\{2}", path, cID, lvi.SubItems(4).Text)
            '   MsgBox(temppath)
            Process.Start(temppath)
        End If
    End Sub


    Private Sub AddFileToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles AddFileToolStripMenuItem.Click
        Using addform As New frmAddFile() With {.CompanyID = cID}
            addform.ShowDialog()
            LoadDocs(cID)
        End Using
    End Sub


End Class