Public Class frmSearch2 
    Dim d As New Common.DataLayer
    Public Property OnlyLoading As Boolean = False
    Private Sub frmSearch2_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        If OnlyLoading = False Then


            showColumns()
            Using StatusDS As DataSet = d.ExecuteSQL("Select Distinct CompanyStatus from Companies order by companyStatus")
                luStatus.Properties.Items.Add("")
                For Each dr As DataRow In StatusDS.Tables(0).Rows
                    luStatus.Properties.Items.Add(dr("CompanyStatus"))
                Next
            End Using

            Dim sSql As String = "SelecT Distinct rep.RealName as Rep from Companies c "
            sSql = sSql & " inner Join PostCodePrefixes pc on pc.ID = c.PostCodeID"
            sSql = sSql & " inner join Areas a on pc.AreaID = a.ID "
            sSql = sSql & " Left outer join Users Rep on Rep.ID = a.RepID ORDER BY Rep"
            luReps.Properties.Items.Add("")
            Using RepsDS As DataSet = d.ExecuteSQL(sSql)
                For Each dr As DataRow In RepsDS.Tables(0).Rows
                    luReps.Properties.Items.Add(dr("Rep"))
                Next
            End Using

            sSql = "SelecT Distinct Ag.RealName as Agent from Companies c "
            sSql = sSql & " inner Join PostCodePrefixes pc on pc.ID = c.PostCodeID"
            sSql = sSql & " inner join Areas a on pc.AreaID = a.ID "
            sSql = sSql & " Left outer join Users Ag on Ag.ID = c.AgentID  ORDER BY Agent"
            luAgent.Properties.Items.Add("")
            Using AgentsDS As DataSet = d.ExecuteSQL(sSql)
                For Each dr As DataRow In AgentsDS.Tables(0).Rows
                    luAgent.Properties.Items.Add(dr("Agent"))
                Next
            End Using

            sSql = "SelecT Distinct A.Title as Area from Companies c "
            sSql = sSql & " inner Join PostCodePrefixes pc on pc.ID = c.PostCodeID"
            sSql = sSql & " inner join Areas a on pc.AreaID = a.ID  order by Area"
            luAreas.Properties.Items.Add("")
            Using AreaDS As DataSet = d.ExecuteSQL(sSql)
                For Each dr As DataRow In AreaDS.Tables(0).Rows
                    luAreas.Properties.Items.Add(dr("Area"))
                Next
            End Using

        End If

    End Sub
    Public Sub refreshgrid()
        Cursor = Cursors.WaitCursor
        Dim sSql As String = "SelecT c.id, c.CompanyName,c.Address1,c.Address2,c.Town, c.County,c.PostcodeRaw,c.ContactForename, c.ContactSurname, c.CompanyStatus ,c.Telephone, rep.RealName as Rep,A.Title as Area,Ag.RealName as Agent  from Companies c "
        sSql = sSql & " Left Outer join PostCodePrefixes pc on pc.ID = c.PostCodeID"
        sSql = sSql & " Left Outer join Areas a on pc.AreaID = a.ID "
        sSql = sSql & " Left outer join Users Rep on Rep.ID = a.RepID "
        sSql = sSql & " Left outer join Users Ag on Ag.ID = c.AgentID "
        sSql = sSql & " Where "

        Dim whereStr As String = ""

        If txtCompany.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.companyName like '%{0}%'", txtCompany.Text)
            Else
                whereStr = String.Format("{0}  and c.companyName like '%{1}%'", whereStr, txtCompany.Text)
            End If
        End If
        If txtFirstname.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.ContactForename like '%{0}%'", txtFirstname.Text)
            Else
                whereStr = String.Format("{0}  and c.ContactForename like '%{1}%'", whereStr, txtFirstname.Text)
            End If
        End If
        If txtSurname.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.ContactSurname like '%{0}%'", txtSurname.Text)
            Else
                whereStr = String.Format("{0}  and c.ContactSurname like '%{1}%'", whereStr, txtSurname.Text)
            End If
        End If

        If txtAddress1.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.Address1 like '%{0}%'", txtAddress1.Text)
            Else
                whereStr = String.Format("{0}  and c.Address1 like '%{1}%'", whereStr, txtAddress1.Text)
            End If
        End If

        If txtAddress2.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.Address2 like '%{0}%'", txtAddress2.Text)
            Else
                whereStr = String.Format("{0}  and c.Address2 like '%{1}%'", whereStr, txtAddress2.Text)
            End If
        End If


        If txtTown.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.town like '%{0}%'", txtTown.Text)
            Else
                whereStr = String.Format("{0}  and c.town like '%{1}%'", whereStr, txtTown.Text)
            End If
        End If

        If txtCounty.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.County like '%{0}%'", txtCounty.Text)
            Else
                whereStr = String.Format("{0}  and c.County like '%{1}%'", whereStr, txtCounty.Text)
            End If
        End If

        If txtPostcode.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" Replace(c.postcoderaw,' ','') like '%{0}%'", txtPostcode.Text.Replace(" ", ""))
            Else
                whereStr = String.Format("{0}  and  Replace(c.postcoderaw,' ','')  like '%{1}%'", whereStr, txtPostcode.Text.Replace(" ", ""))
            End If
        End If


        If txtTelephone.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.Telephone like '%{0}%'", txtTelephone.Text)
            Else
                whereStr = String.Format("{0}  and c.telephone like '%{1}%'", whereStr, txtTelephone.Text)
            End If
        End If

        If luStatus.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" c.companystatus like '{0}'", luStatus.Text)
            Else
                whereStr = String.Format("{0}  and c.companystatus like '{1}'", whereStr, luStatus.Text)
            End If
        End If
        If luReps.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" rep.RealName like '{0}'", luReps.Text)
            Else
                whereStr = String.Format("{0}  and rep.RealName like '{1}'", whereStr, luReps.Text)
            End If
        End If
        If luAgent.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" ag.RealName like '{0}'", luAgent.Text)
            Else
                whereStr = String.Format("{0}  and ag.RealName like '{1}'", whereStr, luAgent.Text)
            End If
        End If

        If luAreas.Text.Trim.Length > 0 Then
            If whereStr.Length = 0 Then
                whereStr = String.Format(" a.Title like '{0}'", luAreas.Text)
            Else
                whereStr = String.Format("{0}  and a.Title  like '{1}'", whereStr, luAreas.Text)
            End If
        End If

        If whereStr.Length = 0 Then
            MsgBox("No search entered")

            Grid.DataSource = Nothing
            Grid.RefreshDataSource()
            Cursor = Cursors.Default
            Exit Sub
        End If
        Dim ds As DataSet = d.ExecuteSQL(String.Format("{0}{1} Order by CompanyName", sSql, whereStr))
        Grid.DataSource = ds.Tables(0)
        Grid.RefreshDataSource()
        Cursor = Cursors.Default

        showColumns()

    End Sub


    Private Sub showColumns()
        colAddress1.Visible = cbAddress1.Checked
        If cbAddress1.Checked Then
            lcAddress1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lcAddress1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If


        colAddress2.Visible = cbAddress2.Checked
        If cbAddress2.Checked Then
            lcAddress2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lcAddress2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        colCounty.Visible = cbCounty.Checked
        If cbCounty.Checked Then
            lcCounty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lcCounty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If



        colArea.Visible = cbArea.Checked
        If cbArea.Checked Then
            lcArea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lcArea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        GridView1.BestFitColumns()
    End Sub



    Private Sub SimpleButton1_Click(sender As System.Object, e As EventArgs) Handles SimpleButton1.Click
        refreshgrid()

    End Sub



    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
        Dim dr As DataRow = GridView1.GetFocusedDataRow

        If dr("CompanyStatus") = "Appointment" Then
            Dim ado As New Common.DataLayer
            Dim ads As DataSet = ado.ExecuteSQL(String.Format("SELECT TOP (1) ID, CompanyID FROM   DiaryItems   WHERE  (CompanyID = {0})  ORDER BY ID DESC", dr("ID")))
            Try
                Using afrm As New frmAppoinmentDetail(ads.Tables(0).Rows(0).Item("ID"))
                    afrm.ShowDialog()
                End Using
            Catch ex As Exception
                MsgBox("Cannot find appointment for this company")
            End Try
        Else
            Using afrm As New frmShowCompany(dr("ID"))
                afrm.ShowDialog()
            End Using

        End If
        refreshgrid()
    End Sub

    Private Sub cbAddress1_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbAddress1.CheckedChanged, cbAddress2.CheckedChanged, cbArea.CheckedChanged, cbCounty.CheckedChanged
        showColumns()
    End Sub

    Private Sub Grid_SizeChanged(sender As System.Object, e As EventArgs) Handles Grid.SizeChanged
        GridView1.BestFitColumns()
    End Sub
End Class