Imports System.IO
Public Class frmAddFile
    Public Property CompanyID() As Integer

    Dim path As String = "\\ca-sql\c$\Website\s\Files\"
    Private Sub frmAddfile_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load


        Select Case My.Computer.Name.ToUpper
            Case "LAPTOPXPS"
                path = "C:\Cadnet Team\Callqueues - C A HeathCare\CA Healthcare\Web Site\s\Files\"
        End Select
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As EventArgs) Handles BtnSave.Click
        If ofd.FileName = "" And txtTitle.Text = "" Then

            lblFileName.BackColor = Color.LightSalmon
            txtTitle.BackColor = Color.LightSalmon
            Exit Sub
        Else
            Dim titlestring As String = txtTitle.Text
            Dim file As Array

            Dim s As String = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\"c) + 1)

            Dim filename As String = s
            file = filename.Split(".")
            Dim directoryPath = path & CompanyID

            Dim fullpath As String = ""
            If Directory.Exists(directoryPath) = False Then
                Directory.CreateDirectory(directoryPath)
            End If
            Dim Counter = 0
            Do While True
                If Counter = 0 Then
                    filename = String.Format("{0}.{1}", file(0), file(1))
                Else
                    filename = String.Format("{0}({1}).{2}", file(0), Counter, file(1))
                End If
                fullpath = String.Format("{0}\{1}", directoryPath, filename)

                If System.IO.File.Exists(fullpath) = False Then

                    System.IO.File.Copy(ofd.FileName, fullpath)

                    Exit Do
                Else
                    Counter = Counter + 1
                End If
            Loop

            'get the UserID from teh UserName

            Dim DB As New CADNet.CallQueues.Common.DataLayer

            Dim oApp As cManagerApp = cManagerApp.GetInstance
            'create the note
            Dim Params As New Collection

            DB.CreateParameter(Params, "@UserID", Data.SqlDbType.Int, oApp.CurrentUser.ID)
            DB.CreateParameter(Params, "@CompanyID", Data.SqlDbType.Int, CompanyID)
            DB.CreateParameter(Params, "@Title", Data.SqlDbType.NVarChar, titlestring)
            DB.CreateParameter(Params, "@FileName", Data.SqlDbType.NVarChar, filename)
            DB.ExecuteSPNoQuery("spCreateAppDocument", Params)

            txtTitle.Text = ""
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As EventArgs) Handles BtnBrowse.Click
        If ofd.ShowDialog = DialogResult.OK Then
            lblFileName.Text = ofd.FileName
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As EventArgs) Handles BtnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class