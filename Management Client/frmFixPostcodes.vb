Public Class frmFixPostcodes

    Dim database As New Common.DataLayer
    Dim Fixes As New List(Of PostcodeFix)
    Dim ds As DataSet
    Dim NeededingFixing As Integer
    Private Sub frmFixPostcodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = database.ExecuteSQL("SELECT PostcodeLocations.ID,(PostCodePrefixes.Prefix +' ' + PostcodeLocations.PostcodeSuffix) as Location FROM  PostcodeLocations INNER JOIN   PostCodePrefixes ON PostcodeLocations.PostcodePrefixID = PostCodePrefixes.ID   WHERE(PostcodeLocations.Latitude = 0)")
        NeededingFixing = ds.Tables(0).Rows.Count
        lblFeedback.Text = $"{NeededingFixing} Postocde Locations need fixing"
    End Sub

    Private Sub BtnFix_Click(sender As Object, e As EventArgs) Handles BtnFix.Click
        Dim ToFix As PostcodeFix
        For Each dr As DataRow In ds.Tables(0).Rows
            ToFix = New PostcodeFix
            ToFix.ID = dr("ID")
            ToFix.Location = dr("Location")
            Fixes.Add(ToFix)
        Next

        For x As Integer = 0 To Fixes.Count - 1
            ToFix = Fixes(x)
            Dim ls As DataSet
            ls = database.ExecuteSQL($"SELECT PostcodeRaw from companies  WHERE(LocationID = {ToFix.ID})")
            Dim Str As String = ""
            If ls.Tables(0).Rows.Count = 0 Then
                ToFix.Result = "No Companies use this location"
            Else
                ToFix.Companies = ls.Tables(0).Rows.Count
                For Each ldr As DataRow In ls.Tables(0).Rows
                    Str = ldr("PostcodeRaw").ToString()
                    Dim r As Common.LatLong = Common.cPostcode.getLatLongObject(Str)
                    If (r.Latitude <> 0) Then
                        database.ExecuteSQL($"UPDATE PostcodeLocations SET Latitude = {r.Latitude,0}, Longitude={r.Longitude} Where ID={ToFix.ID}")
                        ToFix.Result = "Found"
                        Exit For
                    Else
                        ToFix.Result = "NOT Found"
                    End If
                Next
            End If
            lblFeedback.Text = $"{x + 1} of {NeededingFixing} Complete"
            Application.DoEvents()
        Next
        Grid.DataSource = Fixes
        Grid.RefreshDataSource()
    End Sub
End Class