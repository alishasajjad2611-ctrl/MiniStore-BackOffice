using System.Windows.Forms;
namespace App.WinForms.Views
{
    partial class ProductsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            tblProducts = new TableLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnDelete = new Button();
            tbsRefresh = new Button();
            tblTop = new TableLayoutPanel();
            lblStock = new Label();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            lblSearch = new Label();
            lblCategory = new Label();
            dgvProducts = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            flpButtons.SuspendLayout();
            tblTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(flpButtons, 0, 0);
            tblProducts.Controls.Add(tblTop, 0, 1);
            tblProducts.Controls.Add(dgvProducts, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Name = "tblProducts";
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(1200, 700);
            tblProducts.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnView);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(tbsRefresh);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.Location = new Point(3, 3);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(1194, 54);
            flpButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Image = WindowsApp.Properties.Resources.add_32dp_1F1F1F_FILL0_wght400_GRAD0_opsz401;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = WindowsApp.Properties.Resources.icons8_edit_32;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(84, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Image = (Image)resources.GetObject("btnView.Image");
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.Location = new Point(165, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 40);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.TextAlign = ContentAlignment.MiddleRight;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(246, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbsRefresh
            // 
            tbsRefresh.Image = WindowsApp.Properties.Resources.icons8_refresh_32;
            tbsRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            tbsRefresh.Location = new Point(344, 3);
            tbsRefresh.Name = "tbsRefresh";
            tbsRefresh.Size = new Size(103, 40);
            tbsRefresh.TabIndex = 4;
            tbsRefresh.Text = "Refresh";
            tbsRefresh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblTop
            // 
            tblTop.ColumnCount = 3;
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tblTop.Controls.Add(lblStock, 2, 0);
            tblTop.Controls.Add(txtSearch, 0, 1);
            tblTop.Controls.Add(cmbCategory, 1, 1);
            tblTop.Controls.Add(cmbStockStatus, 2, 1);
            tblTop.Controls.Add(lblSearch, 0, 0);
            tblTop.Controls.Add(lblCategory, 1, 0);
            tblTop.Dock = DockStyle.Fill;
            tblTop.Location = new Point(0, 60);
            tblTop.Margin = new Padding(0);
            tblTop.Name = "tblTop";
            tblTop.Padding = new Padding(3);
            tblTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblTop.Size = new Size(1200, 120);
            tblTop.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(794, 3);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(6, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(388, 31);
            txtSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.Location = new Point(400, 26);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(388, 33);
            cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.Location = new Point(794, 26);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(400, 33);
            cmbStockStatus.TabIndex = 5;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(6, 3);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(400, 3);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 34;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 183);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1194, 514);
            dgvProducts.TabIndex = 2;
            // 
            // colID
            // 
            colID.DataPropertyName = "Id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            Controls.Add(tblProducts);
            Name = "ProductsView";
            Size = new Size(1200, 700);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            tblTop.ResumeLayout(false);
            tblTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblProducts;
        private FlowLayoutPanel flpButtons;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnView;
        private Button btnDelete;
        private Button tbsRefresh;

        private TableLayoutPanel tblTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblStock;
        private ComboBox cmbStockStatus;

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}