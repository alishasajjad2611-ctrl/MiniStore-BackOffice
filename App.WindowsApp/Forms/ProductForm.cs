using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            ProductsFormModeEnum _mode;
            Product _product;
            IProductService _service;
        }
        public ProductForm(ProductsFormModeEnum mode, Product? p, IProductService service)
        {

            InitializeComponent();

            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cmbCat.Items.Clear();
            cmbCat.DataSource = (Enum.GetValues(typeof(ProductsCategoryEnum)));
            cmbCat.SelectedIndex = 0;

            cmbProductStatus.Items.Clear();
            cmbProductStatus.DataSource = (Enum.GetValues(typeof(ProductStatusEnum)));
            cmbProductStatus.SelectedIndex = 0;

            //_mode = mode;
            //_product = p;
            //_service = service;
            if (mode == ProductsFormModeEnum.Edit)
            {
                btnsave.Text = " Update";
            }
            else if (mode == ProductsFormModeEnum.View)
            {
                btnsave.Visible = false;

            }
            if (mode == ProductsFormModeEnum.Edit || mode == ProductsFormModeEnum.View)
            {

                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cmbCat.SelectedItem = p.Category;
                cmbProductStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
