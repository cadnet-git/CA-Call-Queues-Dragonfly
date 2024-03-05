Imports System.Linq

Public Class frmChangeGroupCompany


    Public Sub New(GroupCompany As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim CompanyGroups As New List(Of Common.cSimpleItem)

        CompanyGroups.Add(New Common.cSimpleItem(0, ""))
        CompanyGroups.Add(New Common.cSimpleItem(1, "CA"))
        CompanyGroups.Add(New Common.cSimpleItem(2, "DF"))
        CompanyGroups.Add(New Common.cSimpleItem(3, "PI"))
        cbGroupCompany.DataSource = CompanyGroups

        cbGroupCompany.SelectedItem = CompanyGroups.Where(Function(c) c.Value = GroupCompany).First()
    End Sub


End Class