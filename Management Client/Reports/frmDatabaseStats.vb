Public Class frmDatabaseStats

    Private Sub frmDatabaseStats_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim ado As New Common.DataLayer
        Dim ds As DataSet

        ds = ado.ExecuteSQL("SELECT COUNT(ID) AS Total FROM Companies")
        Me.lblRecords.Text = Format(ds.Tables(0).Rows(0).Item("Total"), "#,###,##0")


        ds = ado.ExecuteSQL("SELECT COUNT(ID) AS Total FROM Companies  WHERE(AgentID > 0)")

        Me.lblCalled.Text = Format(ds.Tables(0).Rows(0).Item("Total"), "#,###,##0")
        Me.lblLive.Text = 0
        Me.lbldead.Text = 0

        ds = ado.ExecuteSQL("SELECT COUNT(ID) AS Total, CompanyStatus FROM Companies  WHERE(AgentID > 0) GROUP BY CompanyStatus")
        For Each Dr As DataRow In ds.Tables(0).Rows
            Select Case Dr("companyStatus")
                Case "ColdCall", "CallBack", "NotToHand", "Appointment"
                    Me.lblLive.Text = Me.lblLive.Text + Dr("Total")
                Case Else
                    Me.lbldead.Text = Me.lbldead.Text + Dr("Total")
            End Select
        Next

        Me.lblwastagePercent.Text = CInt(Me.lbldead.Text / Me.lblCalled.Text * 100) & "%"
        Me.lblprojected.Text = Format(CInt(Me.lblRecords.Text * (Me.lblLive.Text / Me.lblCalled.Text)), "#,###,##0")


        Me.lblLive.Text = Format(CInt(Me.lblLive.Text), "#,###,##0")
        Me.lbldead.Text = Format(CInt(Me.lbldead.Text), "#,###,##0")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class