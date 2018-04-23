Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace dxQ529392
	Public Class DataHelper
		Public Shared Function GetDataSource() As Object
			Dim table = New DataTable()
			table.Columns.Add(New DataColumn("ID"))
			table.Columns.Add(New DataColumn("Name"))
			table.Columns.Add(New DataColumn("SecondName"))
			table.Columns.Add(New DataColumn("Adress"))
			table.Columns.Add(New DataColumn("PhoneNum"))
			table.Columns.Add(New DataColumn("Personal information"))
			Return table
		End Function
	End Class
End Namespace
