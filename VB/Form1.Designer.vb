Imports Microsoft.VisualBasic
Imports System
Namespace ParamNavigation
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
            Me.page1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.page2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.GeneralTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucDetailsTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.page1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.page2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GeneralTile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ucDetailsTile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'documentManager1
            '
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.windowsUIView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIView1})
            '
            'windowsUIView1
            '
            Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.page1, Me.page2})
            Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2})
            Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.GeneralTile, Me.ucDetailsTile})
            '
            'page1
            '
            Me.page1.Caption = "Employees"
            Me.page1.Document = Me.document1
            Me.page1.Name = "page1"
            '
            'document1
            '
            Me.document1.Caption = "General"
            Me.document1.ControlName = "General"
            Me.document1.ControlTypeName = "ParamNavigation.General"
            '
            'page2
            '
            Me.page2.Caption = "Details"
            Me.page2.Document = Me.document2
            Me.page2.Name = "page2"
            Me.page2.Parent = Me.page1
            '
            'document2
            '
            Me.document2.Caption = "ucDetails"
            Me.document2.ControlName = "ucDetails"
            Me.document2.ControlTypeName = "ParamNavigation.ucDetails"
            '
            'GeneralTile
            '
            Me.GeneralTile.Document = Me.document1
            Me.GeneralTile.Group = ""
            Me.GeneralTile.Name = "GeneralTile"
            '
            'ucDetailsTile
            '
            Me.ucDetailsTile.Document = Me.document2
            Me.ucDetailsTile.Group = ""
            Me.ucDetailsTile.Name = "ucDetailsTile"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(709, 557)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.page1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.page2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GeneralTile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ucDetailsTile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private page1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page
		Private document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private page2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page
		Private document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private GeneralTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private ucDetailsTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
	End Class
End Namespace

