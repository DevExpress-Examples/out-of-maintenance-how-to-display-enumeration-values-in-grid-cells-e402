Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication274
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim list As BindingList(Of Record) = New BindingList(Of Record)()
			list.Add(New Record(temp.valuefor1))
			list.Add(New Record(temp.valuefor2))

			Dim item As New RepositoryItemImageComboBox()
			item.Items.AddEnum(GetType(temp))
			gridControl1.RepositoryItems.Add(item)
			gridControl1.DataSource = list
			gridView1.PopulateColumns()
			gridView1.Columns("EnumValue").ColumnEdit = item
			gridView1.Columns("EnumValue").OptionsColumn.ReadOnly = True
			gridView1.Columns("EnumValue").OptionsColumn.AllowEdit = False
		End Sub
	End Class

	Public Enum temp
		valuefor1 = 1
		valuefor2 = 2
	End Enum
	Friend Class Record
		Public Sub New(ByVal eVal As temp)
			_enumValue = eVal
		End Sub
		Private _enumValue As temp
		Public ReadOnly Property EnumValue() As temp
			Get
				Return _enumValue
			End Get
		End Property
	End Class
End Namespace