using DevExpress.XtraLayout;
using System;
using System.Data;
using System.Windows.Forms;

namespace S131978
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = GetProductsDataTable();
            ((ILayoutControl)layoutView1).OptionsFocus.MoveFocusDirection = MoveFocusDirection.DownThenAcross;
        }

        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ProductID", typeof(int)));
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("SupplierID", typeof(int)));
            table.Columns.Add(new DataColumn("CategoryID", typeof(string)));
            table.Columns.Add(new DataColumn("QuantityPerUnit", typeof(int)));
            table.Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            table.Columns.Add(new DataColumn("UnitsInStock", typeof(int)));
            table.Columns.Add(new DataColumn("UnitsOnOrder", typeof(int)));
            table.Columns.Add(new DataColumn("ReorderLevel", typeof(int)));
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add(index, "Product " + index, index * 2, index * 3, index % 7, index * 1000d + index * 100d, index % 5, index % 9, index % 3);
            }
            return table;
        }
    }
}