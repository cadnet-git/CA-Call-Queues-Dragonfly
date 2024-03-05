Public Class frmDiariesManager

#Region "Singleton"

    Private Shared oInstance As frmDiariesManager

    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shared Function GetInstance()

        If oInstance Is Nothing Then
            oInstance = New frmDiariesManager
        End If

        GetInstance = oInstance

    End Function
#End Region

    Private CurrentDiary As Common.cUser

    Private Sub frmDiariesManager_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        DiaryListView1.StartDate = Common.DateManipulation.GetStartOfWeek(Date.Today)
        lvwDiaries.HeaderStyle = ColumnHeaderStyle.None

        RefreshDiaries()

    End Sub

    Private Sub RefreshDiaries()
        Dim Database As New CADNet.CallQueues.Common.DataLayer
        Dim DS As DataSet = Database.ExecuteSP("spDiariesList")

        Me.lvwDiaries.Items.Clear()
        For Each aRow As DataRow In DS.Tables(0).Rows
            Dim anItem As ListViewItem = Me.lvwDiaries.Items.Add(aRow.Item("RealName"))
            anItem.Tag = aRow
        Next

    End Sub

    Private Sub lvwDiaries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lvwDiaries.SelectedIndexChanged
        If Me.lvwDiaries.SelectedItems.Count > 0 Then
            Dim aRow As DataRow = Me.lvwDiaries.SelectedItems(0).Tag
            Me.lblCurrentUser.Text = Me.lvwDiaries.SelectedItems(0).Text
            Me.DiaryListView1.DiaryID = aRow.Item("ID")
        End If


    End Sub

    Private Sub ShowDiary()
        Me.lblCurrentUser.Text = CurrentDiary.RealName
        Me.pnlOptions.Visible = True

    End Sub

    Private Sub btnAddAppointment_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAddAppointment.Click

        'create a new appointment.

        'we try to find a match for an existing company
        If True Then
            'first get the telephone number and the agent name:
            Dim aFrm As New frmDiariesManager
            aFrm.DiaryListView1.StartDate = DiaryListView1.StartDate
            Dim DR As DialogResult = aFrm.ShowDialog

            Select Case DR
                Case DialogResult.OK
                Case Else
                    Exit Sub
            End Select


            'extract the data from the form:


        End If


    End Sub
End Class