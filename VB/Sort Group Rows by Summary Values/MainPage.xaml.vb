Imports System
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Sort_Group_Rows_by_Summary_Values
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = (New AccountList()).GetData()
            SortGroupsBySummary(view.GroupedColumns(0))
        End Sub
        Private Sub SortGroupsBySummary(ByVal column As GridColumn)
            Dim sortInfo As New GridGroupSummarySortInfo(grid.GroupSummary(0), column.FieldName, System.ComponentModel.ListSortDirection.Ascending)
            grid.GroupSummarySortInfo.Add(sortInfo)
        End Sub
    End Class
    Public Class AccountList
        Public Function GetData() As List(Of Account)
            Return CreateAccounts()
        End Function
        Private Function CreateAccounts() As List(Of Account)
            Dim list As New List(Of Account)()
            list.Add(New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Age = 57})
            list.Add(New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New Date(2009, 5, 10), .Age = 24})
            list.Add(New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New Date(2009, 5, 10), .Age = 35})
            list.Add(New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Age = 19})
            list.Add(New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New Date(2008, 10, 18), .Age = 42})
            Return list
        End Function
    End Class
    Public Class Account
        Public Property UserName() As String
        Public Property RegistrationDate() As Date
        Public Property Age() As Integer
    End Class
End Namespace
