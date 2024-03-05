Public Class frmOrphanedPostcodes

    Private Sub frmOrphanedPostcodes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim ds As DataSet
        Dim ssql As String = ""
        ssql = "SELECT  PostCodePrefixes.ID, PostCodePrefixes.Prefix, Areas.Title, Users.RealName FROM  Users RIGHT OUTER JOIN   Areas ON Users.ID = Areas.RepID RIGHT OUTER JOIN  PostCodePrefixes ON Areas.ID = PostCodePrefixes.AreaID ORDER BY Areas.Title"
        ds = Database.ExecuteSQL(ssql)
        Dim li As ListViewItem
        For Each dr As DataRow In ds.Tables(0).Rows
            li = New ListViewItem
            li.Text = dr("ID")
            li.SubItems.Add(dr("Prefix").ToString)
            li.SubItems.Add(dr("Title").ToString)
            li.SubItems.Add(dr("RealName").ToString)
            lv.Items.Add(li)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class