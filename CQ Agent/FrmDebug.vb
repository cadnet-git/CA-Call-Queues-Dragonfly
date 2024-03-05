Public Class FrmDebug
   
    Public Sub AddMesage(ByVal Message As String)
        Dim LVitem As New ListViewItem
        LVitem.Text = Now.ToLongTimeString
        LVitem.SubItems.Add(Message)
        Me.LVMessages.Items.Add(LVitem)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class