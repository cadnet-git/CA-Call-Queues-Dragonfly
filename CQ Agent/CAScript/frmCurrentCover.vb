Public Class frmCurrentCover

    Private oScript As ScriptEngine
    Private iState As ScriptEngine.States
    Private ThisCall As Common.cCallHistory
    Dim monthcount As Integer = 14
    Public Sub New(ByVal Script As ScriptEngine, ByVal MyState As ScriptEngine.States, ByVal oCall As Common.cCallHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oScript = Script
        iState = MyState
        ThisCall = oCall
        'frmAgent.Text = Me.Name
    End Sub

    Private Sub btnNotInterested_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotInterested.Click
        Dim sReason As String = ""
        frmAgent.App.UpdateDeskStatus("Not Interested")
        Dim aFrm As New frmGetReasonNotInterested
        Dim DR As DialogResult = aFrm.ShowDialog

        If DR <> DialogResult.OK Then
            Exit Sub
        End If

        sReason = aFrm.txtReason.Text

        ThisCall.EndCallNotInterested(sReason, aFrm.Months)
        oScript.EndState(iState, ScriptEngine.States.Finished)

    End Sub

    Private Sub frmCurrentCover_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load




        AddHandler frmAgent.gotContactInfo_Changed, AddressOf Me.GotContactChanged
        Dim ampm As String
        If DateTime.Compare(Now, DateTime.Parse("11:59:59 AM")) = 1 Then
            ampm = "Afternoon"
        Else
            ampm = "Morning"
        End If
        If ThisCall.Company.Status = "NotToHand" Then
            lblText1.Text = "Good " & ampm & ", " & ThisCall.Company.ContactTitle & " " & ThisCall.Company.ContactForename & " " & ThisCall.Company.ContactSurname & " it is " & frmAgent.App.User.RealName & " from Dragonfly Crowd."
            lbltext2.Text = "Last time we spoke you were going get me the details of your current"
            lbltext3.Text = "healthcare provider"
        ElseIf ThisCall.Company.Status = "CallBack" Then
            lblText1.Text = "Please Confirm the current provider and the next renewal date"
            lbltext2.Text = ""
            lbltext3.Text = ""
            Me.btnNotInterested.Visible = False
            Me.btnNotToHand.Visible = False
            Me.btnOK.Text = "Finish"
            monthcount = 16
        Else
            lblText1.Text = "All I am looking for is a chance to put some quotes forward for you when"
            lbltext2.Text = "your next renewal comes round"
            lbltext3.Text = ""
        End If
        With Me.cmbExpires
            For i As Integer = 0 To monthcount
                Dim aDate As Date = (New DateTime(Today.Year, Today.Month, 1))
                aDate = DateAdd(DateInterval.Month, i, aDate)
                .Items.Add(aDate.ToString("MMMM yyyy"))
            Next
        End With

        cmbExpiresDay.Items.Clear()
        For t As Integer = 1 To 31
            cmbExpiresDay.Items.Add(t)
        Next


        Dim ds As DataSet
        Dim Database As New Common.DataLayer
        ds = Database.ExecuteSQL("Select * from insurers order By description")
        cboProvider.Items.Add("No Cover")
        For Each dr As DataRow In ds.Tables(0).Rows
            cboProvider.Items.Add(dr("Description".ToString))
        Next

        frmAgent.App.UpdateDeskStatus("Checking Current Cover")
    End Sub
    Private Sub GotContactChanged()

        ' btnNotToHand.Enabled = frmAgent.GotContactInfo
        ' btnOK.Enabled = frmAgent.GotContactInfo

    End Sub
    Private Sub btnNotToHand_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNotToHand.Click
        frmAgent.App.UpdateDeskStatus("Not to Hand")
        If frmAgent.GotContactInfo Then
            If ThisCall.Company.ContactSurname <> "" Then
                Dim aFrm As New frmScriptReschedule
                Dim DR As DialogResult = aFrm.ShowDialog

                If DR <> DialogResult.OK Then
                    Exit Sub
                End If

                Me.Enabled = False

                Dim oDate As Date
                If frmAgent.IsInTrainingMode Then
                    oDate = Now
                Else
                    oDate = aFrm.SelectedDate
                End If


                Enabled = False

                ThisCall.EndCallNotToHand(oDate, "")

                oScript.EndState(iState, ScriptEngine.States.Finished)
            Else
                MsgBox("You need to Enter the contacts name to use not  to hand option")
            End If
        Else
            MsgBox("Get Contact Information")
        End If
    End Sub



    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOK.Click
        If ThisCall.Company.PolicyProvider = "Other" Then
            MsgBox("your have selected 'Other' you need to enter the Provider")
            Exit Sub
        End If
        'the next state depends on the renewal period.
        If btnOK.Text = "Finish" Then
            Using afrm As New frmGetReasonCallback(ThisCall)
                If afrm.ShowDialog() = DialogResult.OK Then
                    frmAgent.App.UpdateDeskStatus("Create Callback")
                    ThisCall.EndCallCreateCallBack(frmAgent.IsInTrainingMode)
                    oScript.EndState(iState, ScriptEngine.States.Finished)
                End If
            End Using

            oScript.EndState(iState, ScriptEngine.States.Finished)

        Else

            'if its within 2 months then try to set an appointment
            'if not then just reschedule
            If frmAgent.GotContactInfo Then
                'we can just look at the index in the combbox
                Me.Enabled = False
                Select Case ThisCall.Company.PolicyProvider
                    Case "No Cover"
                        Enabled = False
                        oScript.EndState(iState, ScriptEngine.States.NoCurrentProvider)
                    Case Else

                        If cmbExpires.Text <> "" Then
                            If cmbExpires.SelectedIndex < 3 Then
                                'selected 0 or 1 (thismonth or next month)
                                'move to the appointment request
                                oScript.EndState(iState, ScriptEngine.States.TryForAppointment)
                            Else
                                oScript.EndState(iState, ScriptEngine.States.CheckPayMonthly)
                            End If
                        Else
                            MsgBox("You need to get renewal date")
                            Enabled = True
                        End If
                End Select
            Else
                MsgBox("Get Contact Information")
            End If
        End If
    End Sub

    Private Sub btnNoProvider_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Me.Enabled = False
        oScript.EndState(iState, ScriptEngine.States.NoCurrentProvider)
    End Sub


    Private Sub cmbExpires_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbExpires.SelectedIndexChanged
        If cmbExpiresDay.Text = "" Then
            cmbExpiresDay.Text = 1
        End If
        ThisCall.Company.PolicyExpires = cmbExpiresDay.Text & cmbExpires.Text
        ThisCall.Company.Save()
        frmAgent.ShowCompany()
    End Sub

    Private Sub cmbExpiresDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpiresDay.SelectedIndexChanged
        If cmbExpires.Text <> "" Then
            ThisCall.Company.PolicyExpires = cmbExpiresDay.Text & cmbExpires.Text
            ThisCall.Company.Save()
            frmAgent.ShowCompany()
        End If
    End Sub


    Private Sub cboProvider_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cboProvider.SelectedIndexChanged
        If cboProvider.Text = "Other" Then
            txtOther.Visible = True
            txtOther.Focus()
        Else
            txtOther.Text = ""
            txtOther.Visible = False
            ThisCall.Company.PolicyProvider = cboProvider.Text
            ThisCall.Company.Save()
            frmAgent.ShowCompany()
        End If

    End Sub

    Private Sub txtOther_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtOther.Leave
        If txtOther.Text.Trim.Length > 1 Then
            ThisCall.Company.PolicyProvider = txtOther.Text
            ThisCall.Company.Save()
            frmAgent.ShowCompany()
        Else
            ThisCall.Company.PolicyProvider = "Other"
            ThisCall.Company.Save()
            frmAgent.ShowCompany()
        End If

    End Sub
    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnBack.Click
        oScript.EndState(iState, ScriptEngine.States.CheckContact)
    End Sub




End Class