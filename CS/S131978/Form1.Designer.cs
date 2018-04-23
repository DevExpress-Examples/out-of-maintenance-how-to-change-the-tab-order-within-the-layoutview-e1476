namespace S131978 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new S131978.nwindDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colProductID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colProductID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colProductName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colProductName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSupplierID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSupplierID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCategoryID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colQuantityPerUnit = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUnitPrice = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUnitsInStock = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUnitsOnOrder = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUnitsOnOrder = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReorderLevel = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReorderLevel = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.productsTableAdapter = new S131978.nwindDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSupplierID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantityPerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(626, 430);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(591, 111);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colSupplierID,
            this.colCategoryID,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder,
            this.colReorderLevel});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Product";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.LayoutViewField = this.layoutViewField_colProductID;
            this.colProductID.Name = "colProductID";
            // 
            // layoutViewField_colProductID
            // 
            this.layoutViewField_colProductID.EditorPreferredWidth = 79;
            this.layoutViewField_colProductID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colProductID.Name = "layoutViewField_colProductID";
            this.layoutViewField_colProductID.Size = new System.Drawing.Size(182, 27);
            this.layoutViewField_colProductID.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colProductID.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.LayoutViewField = this.layoutViewField_colProductName;
            this.colProductName.Name = "colProductName";
            // 
            // layoutViewField_colProductName
            // 
            this.layoutViewField_colProductName.EditorPreferredWidth = 100;
            this.layoutViewField_colProductName.Location = new System.Drawing.Point(182, 0);
            this.layoutViewField_colProductName.Name = "layoutViewField_colProductName";
            this.layoutViewField_colProductName.Size = new System.Drawing.Size(203, 27);
            this.layoutViewField_colProductName.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colProductName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colSupplierID
            // 
            this.colSupplierID.Caption = "Supplier";
            this.colSupplierID.FieldName = "SupplierID";
            this.colSupplierID.LayoutViewField = this.layoutViewField_colSupplierID;
            this.colSupplierID.Name = "colSupplierID";
            // 
            // layoutViewField_colSupplierID
            // 
            this.layoutViewField_colSupplierID.EditorPreferredWidth = 101;
            this.layoutViewField_colSupplierID.Location = new System.Drawing.Point(385, 0);
            this.layoutViewField_colSupplierID.Name = "layoutViewField_colSupplierID";
            this.layoutViewField_colSupplierID.Size = new System.Drawing.Size(204, 27);
            this.layoutViewField_colSupplierID.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colSupplierID.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "Category";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.LayoutViewField = this.layoutViewField_colCategoryID;
            this.colCategoryID.Name = "colCategoryID";
            // 
            // layoutViewField_colCategoryID
            // 
            this.layoutViewField_colCategoryID.EditorPreferredWidth = 79;
            this.layoutViewField_colCategoryID.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID";
            this.layoutViewField_colCategoryID.Size = new System.Drawing.Size(182, 27);
            this.layoutViewField_colCategoryID.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCategoryID.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colQuantityPerUnit
            // 
            this.colQuantityPerUnit.Caption = "Quantity per Unit";
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.LayoutViewField = this.layoutViewField_colQuantityPerUnit;
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            // 
            // layoutViewField_colQuantityPerUnit
            // 
            this.layoutViewField_colQuantityPerUnit.EditorPreferredWidth = 100;
            this.layoutViewField_colQuantityPerUnit.Location = new System.Drawing.Point(182, 27);
            this.layoutViewField_colQuantityPerUnit.Name = "layoutViewField_colQuantityPerUnit";
            this.layoutViewField_colQuantityPerUnit.Size = new System.Drawing.Size(203, 27);
            this.layoutViewField_colQuantityPerUnit.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colQuantityPerUnit.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.LayoutViewField = this.layoutViewField_colUnitPrice;
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // layoutViewField_colUnitPrice
            // 
            this.layoutViewField_colUnitPrice.EditorPreferredWidth = 101;
            this.layoutViewField_colUnitPrice.Location = new System.Drawing.Point(385, 27);
            this.layoutViewField_colUnitPrice.Name = "layoutViewField_colUnitPrice";
            this.layoutViewField_colUnitPrice.Size = new System.Drawing.Size(204, 27);
            this.layoutViewField_colUnitPrice.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colUnitPrice.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "Units in Stock";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.LayoutViewField = this.layoutViewField_colUnitsInStock;
            this.colUnitsInStock.Name = "colUnitsInStock";
            // 
            // layoutViewField_colUnitsInStock
            // 
            this.layoutViewField_colUnitsInStock.EditorPreferredWidth = 79;
            this.layoutViewField_colUnitsInStock.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colUnitsInStock.Name = "layoutViewField_colUnitsInStock";
            this.layoutViewField_colUnitsInStock.Size = new System.Drawing.Size(182, 27);
            this.layoutViewField_colUnitsInStock.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colUnitsInStock.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colUnitsOnOrder
            // 
            this.colUnitsOnOrder.Caption = "Units on Order";
            this.colUnitsOnOrder.FieldName = "UnitsOnOrder";
            this.colUnitsOnOrder.LayoutViewField = this.layoutViewField_colUnitsOnOrder;
            this.colUnitsOnOrder.Name = "colUnitsOnOrder";
            // 
            // layoutViewField_colUnitsOnOrder
            // 
            this.layoutViewField_colUnitsOnOrder.EditorPreferredWidth = 100;
            this.layoutViewField_colUnitsOnOrder.Location = new System.Drawing.Point(182, 54);
            this.layoutViewField_colUnitsOnOrder.Name = "layoutViewField_colUnitsOnOrder";
            this.layoutViewField_colUnitsOnOrder.Size = new System.Drawing.Size(203, 27);
            this.layoutViewField_colUnitsOnOrder.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colUnitsOnOrder.TextSize = new System.Drawing.Size(87, 13);
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.Caption = "Reorder Level";
            this.colReorderLevel.FieldName = "ReorderLevel";
            this.colReorderLevel.LayoutViewField = this.layoutViewField_colReorderLevel;
            this.colReorderLevel.Name = "colReorderLevel";
            // 
            // layoutViewField_colReorderLevel
            // 
            this.layoutViewField_colReorderLevel.EditorPreferredWidth = 101;
            this.layoutViewField_colReorderLevel.Location = new System.Drawing.Point(385, 54);
            this.layoutViewField_colReorderLevel.Name = "layoutViewField_colReorderLevel";
            this.layoutViewField_colReorderLevel.Size = new System.Drawing.Size(204, 27);
            this.layoutViewField_colReorderLevel.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colReorderLevel.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCategoryID,
            this.layoutViewField_colUnitsInStock,
            this.layoutViewField_colProductName,
            this.layoutViewField_colProductID,
            this.layoutViewField_colSupplierID,
            this.layoutViewField_colQuantityPerUnit,
            this.layoutViewField_colUnitPrice,
            this.layoutViewField_colUnitsOnOrder,
            this.layoutViewField_colReorderLevel});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 430);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSupplierID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantityPerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private S131978.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProductID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colProductID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProductName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colProductName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSupplierID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSupplierID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUnitPrice;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUnitsInStock;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUnitsInStock;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUnitsOnOrder;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUnitsOnOrder;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colReorderLevel;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colReorderLevel;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

