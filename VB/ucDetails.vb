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
	Public Partial Class ucDetails
		Inherits UserControl
        Implements ISupportNavigation
        Private detailsID As String
        Public Sub New()
            InitializeComponent()
            employeesTableAdapter.Fill(nwindDataSet.Employees)
        End Sub

        Public Sub OnNavigatedFrom(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedFrom

        End Sub

        Public Sub OnNavigatedTo(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedTo
            detailsID = (TryCast(args.Parameter, ParamNavigation.nwindDataSet.EmployeesRow)).EmployeeID.ToString()
            layoutView1.ActiveFilterString = "[EmployeeID] = " & detailsID
        End Sub
    End Class
End Namespace
