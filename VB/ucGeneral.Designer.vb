Imports Microsoft.VisualBasic
Imports System
Namespace ParamNavigation
	Public Partial Class ucGeneral
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New ParamNavigation.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReportsTo = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.employeesTableAdapter = New ParamNavigation.nwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.employeesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(983, 450)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colEmployeeID, Me.colLastName, Me.colFirstName, Me.colTitle, Me.colTitleOfCourtesy, Me.colBirthDate, Me.colHireDate, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colHomePhone, Me.colExtension, Me.colPhoto, Me.colNotes, Me.colReportsTo})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
'			Me.gridView1.DoubleClick += New System.EventHandler(Me.gridView1_DoubleClick);
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 0
			Me.colEmployeeID.Width = 82
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 1
			Me.colLastName.Width = 292
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 2
			Me.colFirstName.Width = 292
			' 
			' colTitle
			' 
			Me.colTitle.FieldName = "Title"
			Me.colTitle.Name = "colTitle"
			' 
			' colTitleOfCourtesy
			' 
			Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
			Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
			Me.colTitleOfCourtesy.Visible = True
			Me.colTitleOfCourtesy.VisibleIndex = 3
			Me.colTitleOfCourtesy.Width = 299
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			' 
			' colHireDate
			' 
			Me.colHireDate.FieldName = "HireDate"
			Me.colHireDate.Name = "colHireDate"
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			' 
			' colHomePhone
			' 
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.Name = "colHomePhone"
			' 
			' colExtension
			' 
			Me.colExtension.FieldName = "Extension"
			Me.colExtension.Name = "colExtension"
			' 
			' colPhoto
			' 
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.Name = "colPhoto"
			' 
			' colNotes
			' 
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.Name = "colNotes"
			' 
			' colReportsTo
			' 
			Me.colReportsTo.FieldName = "ReportsTo"
			Me.colReportsTo.Name = "colReportsTo"
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' ucGeneral
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "ucGeneral"
			Me.Size = New System.Drawing.Size(983, 450)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private employeesTableAdapter As nwindDataSetTableAdapters.EmployeesTableAdapter
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colHireDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtension As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
		Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
		Private colReportsTo As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace
