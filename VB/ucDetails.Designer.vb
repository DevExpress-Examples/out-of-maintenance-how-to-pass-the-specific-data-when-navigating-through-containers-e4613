Imports Microsoft.VisualBasic
Imports System
Namespace ParamNavigation
	Public Partial Class ucDetails
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
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colTitle = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colHireDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colExtension = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.colNotes = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
			Me.colReportsTo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.employeesTableAdapter = New ParamNavigation.nwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewField_colLastName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colFirstName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colTitle = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colTitleOfCourtesy = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colHomePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colNotes = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colReportsTo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colEmployeeID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colBirthDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colCity = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colAddress = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colRegion = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colPostalCode = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colHireDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colCountry = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colExtension = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colTitleOfCourtesy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colHomePhone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colNotes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colReportsTo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colEmployeeID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colRegion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colHireDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colExtension, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.employeesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemRichTextEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(669, 388)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
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
			' layoutView1
			' 
			Me.layoutView1.CardMinSize = New System.Drawing.Size(581, 333)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colEmployeeID, Me.colLastName, Me.colFirstName, Me.colTitle, Me.colTitleOfCourtesy, Me.colBirthDate, Me.colHireDate, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colHomePhone, Me.colExtension, Me.colPhoto, Me.colNotes, Me.colReportsTo})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsCustomization.AllowFilter = False
			Me.layoutView1.OptionsView.ShowCardBorderIfCaptionHidden = False
			Me.layoutView1.OptionsView.ShowCardCaption = False
			Me.layoutView1.OptionsView.ShowCardFieldBorders = True
			Me.layoutView1.OptionsView.ShowCardLines = False
			Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.AppearanceCell.Options.UseTextOptions = True
			Me.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.LayoutViewField = Me.layoutViewField_colEmployeeID
			Me.colEmployeeID.Name = "colEmployeeID"
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.LayoutViewField = Me.layoutViewField_colLastName
			Me.colLastName.Name = "colLastName"
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.LayoutViewField = Me.layoutViewField_colFirstName
			Me.colFirstName.Name = "colFirstName"
			' 
			' colTitle
			' 
			Me.colTitle.FieldName = "Title"
			Me.colTitle.LayoutViewField = Me.layoutViewField_colTitle
			Me.colTitle.Name = "colTitle"
			' 
			' colTitleOfCourtesy
			' 
			Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
			Me.colTitleOfCourtesy.LayoutViewField = Me.layoutViewField_colTitleOfCourtesy
			Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.LayoutViewField = Me.layoutViewField_colBirthDate
			Me.colBirthDate.Name = "colBirthDate"
			' 
			' colHireDate
			' 
			Me.colHireDate.FieldName = "HireDate"
			Me.colHireDate.LayoutViewField = Me.layoutViewField_colHireDate
			Me.colHireDate.Name = "colHireDate"
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.LayoutViewField = Me.layoutViewField_colAddress
			Me.colAddress.Name = "colAddress"
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.LayoutViewField = Me.layoutViewField_colCity
			Me.colCity.Name = "colCity"
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.LayoutViewField = Me.layoutViewField_colRegion
			Me.colRegion.Name = "colRegion"
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.LayoutViewField = Me.layoutViewField_colPostalCode
			Me.colPostalCode.Name = "colPostalCode"
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.LayoutViewField = Me.layoutViewField_colCountry
			Me.colCountry.Name = "colCountry"
			' 
			' colHomePhone
			' 
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.LayoutViewField = Me.layoutViewField_colHomePhone
			Me.colHomePhone.Name = "colHomePhone"
			' 
			' colExtension
			' 
			Me.colExtension.FieldName = "Extension"
			Me.colExtension.LayoutViewField = Me.layoutViewField_colExtension
			Me.colExtension.Name = "colExtension"
			' 
			' colPhoto
			' 
			Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
			Me.colPhoto.Name = "colPhoto"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' colNotes
			' 
			Me.colNotes.ColumnEdit = Me.repositoryItemRichTextEdit1
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.LayoutViewField = Me.layoutViewField_colNotes
			Me.colNotes.Name = "colNotes"
			' 
			' repositoryItemRichTextEdit1
			' 
			Me.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1"
			Me.repositoryItemRichTextEdit1.ShowCaretInReadOnly = False
			' 
			' colReportsTo
			' 
			Me.colReportsTo.AppearanceCell.Options.UseTextOptions = True
			Me.colReportsTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colReportsTo.FieldName = "ReportsTo"
			Me.colReportsTo.LayoutViewField = Me.layoutViewField_colReportsTo
			Me.colReportsTo.Name = "colReportsTo"
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.GroupBordersVisible = False
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colLastName, Me.layoutViewField_colFirstName, Me.layoutViewField_colTitle, Me.layoutViewField_colTitleOfCourtesy, Me.layoutViewField_colHomePhone, Me.layoutViewField_colNotes, Me.layoutViewField_colReportsTo, Me.layoutViewField_colEmployeeID, Me.layoutViewField_colPhoto, Me.layoutViewField_colBirthDate, Me.layoutViewField_colCity, Me.layoutViewField_colAddress, Me.layoutViewField_colRegion, Me.layoutViewField_colPostalCode, Me.layoutViewField_colHireDate, Me.layoutViewField_colCountry, Me.layoutViewField_colExtension})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' layoutViewField_colLastName
			' 
			Me.layoutViewField_colLastName.EditorPreferredWidth = 177
			Me.layoutViewField_colLastName.Location = New System.Drawing.Point(289, 24)
			Me.layoutViewField_colLastName.Name = "layoutViewField_colLastName"
			Me.layoutViewField_colLastName.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colLastName.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colLastName.TextToControlDistance = 5
			' 
			' layoutViewField_colFirstName
			' 
			Me.layoutViewField_colFirstName.EditorPreferredWidth = 177
			Me.layoutViewField_colFirstName.Location = New System.Drawing.Point(289, 48)
			Me.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName"
			Me.layoutViewField_colFirstName.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colFirstName.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colFirstName.TextToControlDistance = 5
			' 
			' layoutViewField_colTitle
			' 
			Me.layoutViewField_colTitle.EditorPreferredWidth = 177
			Me.layoutViewField_colTitle.Location = New System.Drawing.Point(289, 72)
			Me.layoutViewField_colTitle.Name = "layoutViewField_colTitle"
			Me.layoutViewField_colTitle.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colTitle.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colTitle.TextToControlDistance = 5
			' 
			' layoutViewField_colTitleOfCourtesy
			' 
			Me.layoutViewField_colTitleOfCourtesy.EditorPreferredWidth = 177
			Me.layoutViewField_colTitleOfCourtesy.Location = New System.Drawing.Point(289, 96)
			Me.layoutViewField_colTitleOfCourtesy.Name = "layoutViewField_colTitleOfCourtesy"
			Me.layoutViewField_colTitleOfCourtesy.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colTitleOfCourtesy.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colTitleOfCourtesy.TextToControlDistance = 5
			' 
			' layoutViewField_colHomePhone
			' 
			Me.layoutViewField_colHomePhone.EditorPreferredWidth = 185
			Me.layoutViewField_colHomePhone.Location = New System.Drawing.Point(0, 240)
			Me.layoutViewField_colHomePhone.Name = "layoutViewField_colHomePhone"
			Me.layoutViewField_colHomePhone.Size = New System.Drawing.Size(280, 24)
			Me.layoutViewField_colHomePhone.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colHomePhone.TextToControlDistance = 5
			' 
			' layoutViewField_colNotes
			' 
			Me.layoutViewField_colNotes.EditorPreferredWidth = 466
			Me.layoutViewField_colNotes.Location = New System.Drawing.Point(0, 264)
			Me.layoutViewField_colNotes.Name = "layoutViewField_colNotes"
			Me.layoutViewField_colNotes.Size = New System.Drawing.Size(561, 24)
			Me.layoutViewField_colNotes.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colNotes.TextToControlDistance = 5
			' 
			' layoutViewField_colReportsTo
			' 
			Me.layoutViewField_colReportsTo.EditorPreferredWidth = 466
			Me.layoutViewField_colReportsTo.Location = New System.Drawing.Point(0, 288)
			Me.layoutViewField_colReportsTo.Name = "layoutViewField_colReportsTo"
			Me.layoutViewField_colReportsTo.Size = New System.Drawing.Size(561, 25)
			Me.layoutViewField_colReportsTo.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colReportsTo.TextToControlDistance = 5
			' 
			' layoutViewField_colEmployeeID
			' 
			Me.layoutViewField_colEmployeeID.EditorPreferredWidth = 177
			Me.layoutViewField_colEmployeeID.Location = New System.Drawing.Point(289, 0)
			Me.layoutViewField_colEmployeeID.Name = "layoutViewField_colEmployeeID"
			Me.layoutViewField_colEmployeeID.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colEmployeeID.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colEmployeeID.TextToControlDistance = 5
			' 
			' layoutViewField_colPhoto
			' 
			Me.layoutViewField_colPhoto.EditorPreferredWidth = 194
			Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
			Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(289, 120)
			Me.layoutViewField_colPhoto.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colPhoto.TextToControlDistance = 5
			' 
			' layoutViewField_colBirthDate
			' 
			Me.layoutViewField_colBirthDate.EditorPreferredWidth = 195
			Me.layoutViewField_colBirthDate.Location = New System.Drawing.Point(0, 120)
			Me.layoutViewField_colBirthDate.Name = "layoutViewField_colBirthDate"
			Me.layoutViewField_colBirthDate.Size = New System.Drawing.Size(290, 24)
			Me.layoutViewField_colBirthDate.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colBirthDate.TextToControlDistance = 5
			' 
			' layoutViewField_colCity
			' 
			Me.layoutViewField_colCity.EditorPreferredWidth = 177
			Me.layoutViewField_colCity.Location = New System.Drawing.Point(289, 168)
			Me.layoutViewField_colCity.Name = "layoutViewField_colCity"
			Me.layoutViewField_colCity.Size = New System.Drawing.Size(272, 24)
			Me.layoutViewField_colCity.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colCity.TextToControlDistance = 5
			' 
			' layoutViewField_colAddress
			' 
			Me.layoutViewField_colAddress.EditorPreferredWidth = 466
			Me.layoutViewField_colAddress.Location = New System.Drawing.Point(0, 144)
			Me.layoutViewField_colAddress.Name = "layoutViewField_colAddress"
			Me.layoutViewField_colAddress.Size = New System.Drawing.Size(561, 24)
			Me.layoutViewField_colAddress.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colAddress.TextToControlDistance = 5
			' 
			' layoutViewField_colRegion
			' 
			Me.layoutViewField_colRegion.EditorPreferredWidth = 466
			Me.layoutViewField_colRegion.Location = New System.Drawing.Point(0, 192)
			Me.layoutViewField_colRegion.Name = "layoutViewField_colRegion"
			Me.layoutViewField_colRegion.Size = New System.Drawing.Size(561, 24)
			Me.layoutViewField_colRegion.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colRegion.TextToControlDistance = 5
			' 
			' layoutViewField_colPostalCode
			' 
			Me.layoutViewField_colPostalCode.EditorPreferredWidth = 466
			Me.layoutViewField_colPostalCode.Location = New System.Drawing.Point(0, 216)
			Me.layoutViewField_colPostalCode.Name = "layoutViewField_colPostalCode"
			Me.layoutViewField_colPostalCode.Size = New System.Drawing.Size(561, 24)
			Me.layoutViewField_colPostalCode.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colPostalCode.TextToControlDistance = 5
			' 
			' layoutViewField_colHireDate
			' 
			Me.layoutViewField_colHireDate.EditorPreferredWidth = 176
			Me.layoutViewField_colHireDate.Location = New System.Drawing.Point(290, 120)
			Me.layoutViewField_colHireDate.Name = "layoutViewField_colHireDate"
			Me.layoutViewField_colHireDate.Size = New System.Drawing.Size(271, 24)
			Me.layoutViewField_colHireDate.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colHireDate.TextToControlDistance = 5
			' 
			' layoutViewField_colCountry
			' 
			Me.layoutViewField_colCountry.EditorPreferredWidth = 194
			Me.layoutViewField_colCountry.Location = New System.Drawing.Point(0, 168)
			Me.layoutViewField_colCountry.Name = "layoutViewField_colCountry"
			Me.layoutViewField_colCountry.Size = New System.Drawing.Size(289, 24)
			Me.layoutViewField_colCountry.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colCountry.TextToControlDistance = 5
			' 
			' layoutViewField_colExtension
			' 
			Me.layoutViewField_colExtension.EditorPreferredWidth = 186
			Me.layoutViewField_colExtension.Location = New System.Drawing.Point(280, 240)
			Me.layoutViewField_colExtension.Name = "layoutViewField_colExtension"
			Me.layoutViewField_colExtension.Size = New System.Drawing.Size(281, 24)
			Me.layoutViewField_colExtension.TextSize = New System.Drawing.Size(86, 13)
			Me.layoutViewField_colExtension.TextToControlDistance = 5
			' 
			' ucDetails
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "ucDetails"
			Me.Size = New System.Drawing.Size(669, 388)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colLastName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colTitle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colTitleOfCourtesy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colHomePhone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colNotes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colReportsTo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colEmployeeID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colRegion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colHireDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colExtension, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private employeesTableAdapter As nwindDataSetTableAdapters.EmployeesTableAdapter
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colEmployeeID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colLastName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colTitle As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colBirthDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colHireDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colAddress As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colCity As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colRegion As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colCountry As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colHomePhone As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colExtension As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colNotes As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colReportsTo As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private layoutViewField_colEmployeeID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colLastName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colFirstName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colTitle As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colTitleOfCourtesy As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colBirthDate As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colHireDate As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colAddress As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colCity As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colRegion As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPostalCode As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colCountry As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colHomePhone As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colExtension As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colNotes As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colReportsTo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	End Class
End Namespace
