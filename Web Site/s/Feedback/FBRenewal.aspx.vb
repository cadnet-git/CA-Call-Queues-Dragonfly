Imports System.Data
Partial Class FBRenewal
    Inherits System.Web.UI.Page
    Dim fb As Feedback
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        fb = Session("FeedBack")

        Dim MyListItemCollection As ListItemCollection = New ListItemCollection()

        ' Dimensions an array of ListItems that are used to populate the collection.    
        Dim NewListItemArray(17) As System.Web.UI.WebControls.ListItem

        ' Populates the array of ListItems with generic data.
        If IsPostBack = False Then
            ddRenewalDate.Items.Add("Not Selected")
            ddRenewalDate.Items.Add("No Cover")
            For i As Integer = 0 To 11
                Dim aDate As Date = (New DateTime(Today.Year, Today.Month, 1))
                aDate = DateAdd(DateInterval.Month, i, aDate)
                ddRenewalDate.Items.Add(aDate.ToString("MMMM"))
            Next
            Dim d As New CADNet.CallQueues.Common.DataLayer
            Using ds As DataSet = d.ExecuteSQL("SELECT Description FROM Insurers order by description")
                ddProvider.Items.Add("")
                For Each dr As DataRow In ds.Tables(0).Rows
                    ddProvider.Items.Add(dr("Description"))
                Next
            End Using

            lblError.Text = ""
        End If



    End Sub


    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect("FBOutcome.aspx")
    End Sub

    Protected Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNext.Click
        If ddProvider.Text = "Not Selected" Or ddRenewalDate.Text = "Not Selected" Then
            lblError.Text = "You must enter this information"
            Exit Sub
        End If

        fb.RenewalDate = ddRenewalDate.Text
        fb.Provider = ddProvider.Text
        Session("FeedBack") = fb
        Response.Redirect("FBLifeOutcome.aspx")

    End Sub
End Class
