Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ParamNavigation
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub windowsUIView1_NavigatedTo(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs) Handles windowsUIView1.NavigatedTo
			If e.Target Is page1 Then
			e.Parameter = page2
			End If
		End Sub

		Private Sub windowsUIView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles windowsUIView1.QueryControl
			If e.Document Is document1 Then
			e.Control = New ucGeneral()
			Else
				e.Control = New ucDetails()
			End If
		End Sub
	End Class
End Namespace
