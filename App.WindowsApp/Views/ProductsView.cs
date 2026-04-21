using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Utilities;
using App.Core.Models;

using App.WindowsApp.Forms;
namespace App.WinForms.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;
        BindingSource _dgvbindingSource = new BindingSource();
        public ProductsView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;
        }

        private void SetupGrid()
        {
            // Clear existing columns (optional safety)
            dgvProducts.Columns.Clear();

            // Add columns
            dgvProducts.Columns.Add("ID", "ID");
            dgvProducts.Columns.Add("Name", "Name");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price");
            dgvProducts.Columns.Add("Stock", "Stock");
            dgvProducts.Columns.Add("Status", "Status");
        }

        private void LoadSampleData()
        {
            dgvProducts.Rows.Clear();

            dgvProducts.Rows.Add(1, "Product A", "Category 1", "100", "50", "In Stock");
            dgvProducts.Rows.Add(2, "Product B", "Category 2", "200", "0", "Out of Stock");
        }

        private void tblTop_Paint(object sender, PaintEventArgs e) { }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductsCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;
            if (_service == null)
                return;
            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductsFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            //RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductsFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                //RefreshGrid();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {

                ProductForm prodForm = new ProductForm(ProductsFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }
        }
    }
}