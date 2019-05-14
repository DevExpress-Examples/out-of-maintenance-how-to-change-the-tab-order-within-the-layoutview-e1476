Namespace S131978
    Partial Class Form1
        Private colCategoryID As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colProductID As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colProductName As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colSupplierID As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private components As System.ComponentModel.IContainer = Nothing
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Private layoutViewField_colCategoryID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colProductID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colProductName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colQuantityPerUnit As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colReorderLevel As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colSupplierID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colUnitPrice As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colUnitsInStock As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colUnitsOnOrder As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private productsBindingSource As System.Windows.Forms.BindingSource

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colProductID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colProductID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colProductName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colProductName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colSupplierID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colSupplierID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colCategoryID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colQuantityPerUnit = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colUnitPrice = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colUnitsInStock = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colUnitsOnOrder = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colReorderLevel = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colProductID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colProductName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colSupplierID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colCategoryID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colQuantityPerUnit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colUnitPrice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colUnitsInStock), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colUnitsOnOrder), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colReorderLevel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridControl1.DataSource = Me.productsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = String.Empty
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.layoutView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(626, 430)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutView1})
            Me.productsBindingSource.DataMember = "Products"
            Me.layoutView1.CardMinSize = New System.Drawing.Size(591, 111)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel})
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            Me.colProductID.Caption = "Product"
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.LayoutViewField = Me.layoutViewField_colProductID
            Me.colProductID.Name = "colProductID"
            Me.layoutViewField_colProductID.EditorPreferredWidth = 79
            Me.layoutViewField_colProductID.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colProductID.Name = "layoutViewField_colProductID"
            Me.layoutViewField_colProductID.Size = New System.Drawing.Size(182, 27)
            Me.layoutViewField_colProductID.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colProductID.TextSize = New System.Drawing.Size(87, 13)
            Me.colProductName.Caption = "Name"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.LayoutViewField = Me.layoutViewField_colProductName
            Me.colProductName.Name = "colProductName"
            Me.layoutViewField_colProductName.EditorPreferredWidth = 100
            Me.layoutViewField_colProductName.Location = New System.Drawing.Point(182, 0)
            Me.layoutViewField_colProductName.Name = "layoutViewField_colProductName"
            Me.layoutViewField_colProductName.Size = New System.Drawing.Size(203, 27)
            Me.layoutViewField_colProductName.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colProductName.TextSize = New System.Drawing.Size(87, 13)
            Me.colSupplierID.Caption = "Supplier"
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.LayoutViewField = Me.layoutViewField_colSupplierID
            Me.colSupplierID.Name = "colSupplierID"
            Me.layoutViewField_colSupplierID.EditorPreferredWidth = 101
            Me.layoutViewField_colSupplierID.Location = New System.Drawing.Point(385, 0)
            Me.layoutViewField_colSupplierID.Name = "layoutViewField_colSupplierID"
            Me.layoutViewField_colSupplierID.Size = New System.Drawing.Size(204, 27)
            Me.layoutViewField_colSupplierID.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colSupplierID.TextSize = New System.Drawing.Size(87, 13)
            Me.colCategoryID.Caption = "Category"
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.LayoutViewField = Me.layoutViewField_colCategoryID
            Me.colCategoryID.Name = "colCategoryID"
            Me.layoutViewField_colCategoryID.EditorPreferredWidth = 79
            Me.layoutViewField_colCategoryID.Location = New System.Drawing.Point(0, 27)
            Me.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID"
            Me.layoutViewField_colCategoryID.Size = New System.Drawing.Size(182, 27)
            Me.layoutViewField_colCategoryID.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colCategoryID.TextSize = New System.Drawing.Size(87, 13)
            Me.colQuantityPerUnit.Caption = "Quantity per Unit"
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.LayoutViewField = Me.layoutViewField_colQuantityPerUnit
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.layoutViewField_colQuantityPerUnit.EditorPreferredWidth = 100
            Me.layoutViewField_colQuantityPerUnit.Location = New System.Drawing.Point(182, 27)
            Me.layoutViewField_colQuantityPerUnit.Name = "layoutViewField_colQuantityPerUnit"
            Me.layoutViewField_colQuantityPerUnit.Size = New System.Drawing.Size(203, 27)
            Me.layoutViewField_colQuantityPerUnit.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colQuantityPerUnit.TextSize = New System.Drawing.Size(87, 13)
            Me.colUnitPrice.Caption = "Unit Price"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.LayoutViewField = Me.layoutViewField_colUnitPrice
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.layoutViewField_colUnitPrice.EditorPreferredWidth = 101
            Me.layoutViewField_colUnitPrice.Location = New System.Drawing.Point(385, 27)
            Me.layoutViewField_colUnitPrice.Name = "layoutViewField_colUnitPrice"
            Me.layoutViewField_colUnitPrice.Size = New System.Drawing.Size(204, 27)
            Me.layoutViewField_colUnitPrice.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colUnitPrice.TextSize = New System.Drawing.Size(87, 13)
            Me.colUnitsInStock.Caption = "Units in Stock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.LayoutViewField = Me.layoutViewField_colUnitsInStock
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.layoutViewField_colUnitsInStock.EditorPreferredWidth = 79
            Me.layoutViewField_colUnitsInStock.Location = New System.Drawing.Point(0, 54)
            Me.layoutViewField_colUnitsInStock.Name = "layoutViewField_colUnitsInStock"
            Me.layoutViewField_colUnitsInStock.Size = New System.Drawing.Size(182, 27)
            Me.layoutViewField_colUnitsInStock.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colUnitsInStock.TextSize = New System.Drawing.Size(87, 13)
            Me.colUnitsOnOrder.Caption = "Units on Order"
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.LayoutViewField = Me.layoutViewField_colUnitsOnOrder
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.layoutViewField_colUnitsOnOrder.EditorPreferredWidth = 100
            Me.layoutViewField_colUnitsOnOrder.Location = New System.Drawing.Point(182, 54)
            Me.layoutViewField_colUnitsOnOrder.Name = "layoutViewField_colUnitsOnOrder"
            Me.layoutViewField_colUnitsOnOrder.Size = New System.Drawing.Size(203, 27)
            Me.layoutViewField_colUnitsOnOrder.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colUnitsOnOrder.TextSize = New System.Drawing.Size(87, 13)
            Me.colReorderLevel.Caption = "Reorder Level"
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.LayoutViewField = Me.layoutViewField_colReorderLevel
            Me.colReorderLevel.Name = "colReorderLevel"
            Me.layoutViewField_colReorderLevel.EditorPreferredWidth = 101
            Me.layoutViewField_colReorderLevel.Location = New System.Drawing.Point(385, 54)
            Me.layoutViewField_colReorderLevel.Name = "layoutViewField_colReorderLevel"
            Me.layoutViewField_colReorderLevel.Size = New System.Drawing.Size(204, 27)
            Me.layoutViewField_colReorderLevel.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutViewField_colReorderLevel.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard"
            Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colCategoryID, Me.layoutViewField_colUnitsInStock, Me.layoutViewField_colProductName, Me.layoutViewField_colProductID, Me.layoutViewField_colSupplierID, Me.layoutViewField_colQuantityPerUnit, Me.layoutViewField_colUnitPrice, Me.layoutViewField_colUnitsOnOrder, Me.layoutViewField_colReorderLevel})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(626, 430)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colProductID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colProductName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colSupplierID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colCategoryID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colQuantityPerUnit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colUnitPrice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colUnitsInStock), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colUnitsOnOrder), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colReorderLevel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
