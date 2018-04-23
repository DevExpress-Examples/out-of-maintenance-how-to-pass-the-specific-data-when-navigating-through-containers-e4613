Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI

Namespace ParamNavigation
	Public Partial Class ucGeneral
		Inherits UserControl
		Implements ISupportNavigation
		Private generalView As WindowsUIView
		Private detailsPage As Page
		Public Sub New()
			InitializeComponent()
			employeesTableAdapter.Fill(nwindDataSet.Employees)
		End Sub

        Public Sub OnNavigatedFrom(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedFrom
            args.Parameter = gridView1.GetDataRow(gridView1.FocusedRowHandle)
        End Sub

        Public Sub OnNavigatedTo(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedTo
            generalView = args.View
            detailsPage = TryCast(args.Parameter, Page)
        End Sub

		Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.DoubleClick
			generalView.Controller.Activate(detailsPage)
		End Sub
	End Class
End Namespace
