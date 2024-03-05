Public Class DiaryListItem

    Private iID As Integer = 0

    Private ColorBack As System.Drawing.Color = Color.White
    Private ColorHover As System.Drawing.Color = Color.LemonChiffon

    Public Shadows Event Click(ByVal sender As System.Object, ByVal e As EventArgs)

    Public Sub New(ByVal ID As Integer, ByVal AppointmentDate As DateTime, ByVal AppointmentTime As DateTime, ByVal CompanyName As String, ByVal AreaName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        iID = ID

        Me.BackColor = ColorBack

        ' Add any initialization after the InitializeComponent() call.
        Dim sTemp As String = ""

        sTemp = Common.DateManipulation.GetDateDescription(AppointmentDate)

        sTemp = sTemp & " " & AppointmentDate.ToString("MMM")

        Me.lblDate.Text = sTemp
        Me.lblTime.Text = AppointmentTime.ToString("HH:mm")
        Me.lblCompany.Text = CompanyName
        ToolTip1.SetToolTip(Me.lblCompany, CompanyName)
        lblArea.Text = Common.TitleCase(AreaName)

    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            ID = iID
        End Get
    End Property
    Private Sub DiaryListItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Me.MouseEnter, lblArea.MouseEnter, lblCompany.MouseEnter, lblDate.MouseEnter, lblTime.MouseEnter
        Me.BackColor = Me.ColorHover
    End Sub

    Private Sub DiaryListItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.MouseLeave, lblArea.MouseLeave, lblCompany.MouseLeave, lblDate.MouseLeave, lblTime.MouseLeave
        Me.BackColor = Me.ColorBack
    End Sub

    Public Sub HideDate()
        Me.lblDate.Visible = False
    End Sub

    Private Sub lblArea_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblArea.Click, lblCompany.Click, lblDate.Click, lblTime.Click
        RaiseEvent Click(Me, e)
    End Sub
End Class
