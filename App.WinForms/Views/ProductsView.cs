using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinForms.Views
{
    public partial class ProductsView : UserControl
    {
        private DataGridView dgvProducts;

        public ProductsView()
        {
            InitializeComponent();
            this.Load += ProductsView_Load;
        }

        private void ProductsView_Load(object sender, System.EventArgs e)
        {
            AddProductsGrid();
            LoadSampleData();
        }

        private void AddProductsGrid()
        {
            dgvProducts = new DataGridView();

            // Basic settings
            dgvProducts.Name = "dgvProducts";
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.RowHeadersVisible = false;

            // Add columns
            dgvProducts.Columns.Add("ID", "ID");
            dgvProducts.Columns.Add("Name", "Name");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price");
            dgvProducts.Columns.Add("Stock", "Stock");
            dgvProducts.Columns.Add("Status", "Status");

            // Dock to fill TableLayoutPanel row
            dgvProducts.Dock = DockStyle.Fill;

            // Add to tblProducts, row 2 (below flpButtons and tblTop)
            // Ensure tblProducts has 3 rows
            if (tblProducts.RowCount < 3)
                tblProducts.RowCount = 3;

            // Add DataGridView to row 2
            tblProducts.Controls.Add(dgvProducts, 0, 2);

            // Fix row styles
            if (tblProducts.RowStyles.Count < 3)
            {
                tblProducts.RowStyles.Clear();
                tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F)); // Buttons
                tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F)); // Filters
                tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));  // DataGridView
            }
            else
            {
                tblProducts.RowStyles[0].SizeType = SizeType.Absolute;
                tblProducts.RowStyles[0].Height = 100;
                tblProducts.RowStyles[1].SizeType = SizeType.Absolute;
                tblProducts.RowStyles[1].Height = 120;
                tblProducts.RowStyles[2].SizeType = SizeType.Percent;
                tblProducts.RowStyles[2].Height = 100;
            }
        }

        private void LoadSampleData()
        {
            // Sample data
            dgvProducts.Rows.Add(1, "Product A", "Category 1", "100", "50", "In Stock");
            dgvProducts.Rows.Add(2, "Product B", "Category 2", "200", "0", "Out of Stock");
        }

        private void tblProducts_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}