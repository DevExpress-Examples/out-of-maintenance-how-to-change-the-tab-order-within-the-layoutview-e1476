Imports DevExpress.XtraLayout
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace S131978
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			productsBindingSource.DataSource = GetProductsDataTable()
			DirectCast(layoutView1, ILayoutControl).OptionsFocus.MoveFocusDirection = MoveFocusDirection.DownThenAcross
		End Sub

		Private Function GetProductsDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "Products"
			table.Columns.Add(New DataColumn("ProductID", GetType(Integer)))
			table.Columns.Add(New DataColumn("ProductName", GetType(String)))
			table.Columns.Add(New DataColumn("SupplierID", GetType(Integer)))
			table.Columns.Add(New DataColumn("CategoryID", GetType(String)))
			table.Columns.Add(New DataColumn("QuantityPerUnit", GetType(Integer)))
			table.Columns.Add(New DataColumn("UnitPrice", GetType(Double)))
			table.Columns.Add(New DataColumn("UnitsInStock", GetType(Integer)))
			table.Columns.Add(New DataColumn("UnitsOnOrder", GetType(Integer)))
			table.Columns.Add(New DataColumn("ReorderLevel", GetType(Integer)))
			For i As Integer = 0 To 19
				Dim index As Integer = i + 1
				table.Rows.Add(index, "Product " & index, index * 2, index * 3, index Mod 7, index * 1000R + index * 100R, index Mod 5, index Mod 9, index Mod 3)
			Next i
			Return table
		End Function
	End Class
End Namespace