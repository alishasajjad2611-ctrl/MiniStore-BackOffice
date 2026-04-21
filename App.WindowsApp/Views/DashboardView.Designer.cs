namespace App.WinForms.Views
{
    partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblDashboard = new TableLayoutPanel();
            flpKpi = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlOrders = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Lowstock = new Label();
            dgvLowStock = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pnlRecentOredrs = new Panel();
            tlprecentorders = new TableLayoutPanel();
            lblrecentsorders = new Label();
            dgvRecentorders = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tblDashboard.SuspendLayout();
            flpKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            pnlRecentOredrs.SuspendLayout();
            tlprecentorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentorders).BeginInit();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(flpKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOredrs, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(1478, 579);
            tblDashboard.TabIndex = 0;
            tblDashboard.Paint += tblDashboard_Paint_1;
            // 
            // flpKpi
            // 
            flpKpi.Controls.Add(pnlSales);
            flpKpi.Controls.Add(pnlOrders);
            flpKpi.Controls.Add(pnlRevenue);
            flpKpi.Dock = DockStyle.Fill;
            flpKpi.Location = new Point(3, 4);
            flpKpi.Margin = new Padding(3, 4, 3, 4);
            flpKpi.Name = "flpKpi";
            flpKpi.Size = new Size(1472, 142);
            flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Location = new Point(3, 4);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(222, 125);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Location = new Point(141, 26);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(22, 25);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "0";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(17, 26);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(52, 25);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(lblOrdersV);
            pnlOrders.Controls.Add(lblOrdersT);
            pnlOrders.Location = new Point(231, 4);
            pnlOrders.Margin = new Padding(3, 4, 3, 4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(222, 125);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.Location = new Point(159, 26);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(22, 25);
            lblOrdersV.TabIndex = 1;
            lblOrdersV.Text = "0";
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.Location = new Point(41, 26);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(66, 25);
            lblOrdersT.TabIndex = 0;
            lblOrdersT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(459, 4);
            pnlRevenue.Margin = new Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(222, 125);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(148, 26);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(22, 25);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "0";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(37, 26);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(78, 25);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = SystemColors.Control;
            pnlLowStock.Controls.Add(tableLayoutPanel1);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(3, 154);
            pnlLowStock.Margin = new Padding(3, 4, 3, 4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Padding = new Padding(11, 0, 0, 0);
            pnlLowStock.Size = new Size(1472, 206);
            pnlLowStock.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Lowstock, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvLowStock, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(11, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1461, 206);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Lowstock
            // 
            Lowstock.AutoSize = true;
            Lowstock.BackColor = SystemColors.ControlDark;
            Lowstock.Dock = DockStyle.Fill;
            Lowstock.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lowstock.Location = new Point(3, 0);
            Lowstock.Name = "Lowstock";
            Lowstock.Size = new Size(1455, 44);
            Lowstock.TabIndex = 1;
            Lowstock.Text = "Low Stock";
            Lowstock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvLowStock
            // 
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.BackgroundColor = SystemColors.Control;
            dgvLowStock.BorderStyle = BorderStyle.None;
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(3, 48);
            dgvLowStock.Margin = new Padding(3, 4, 3, 4);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.ReadOnly = true;
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.RowHeadersWidth = 62;
            dgvLowStock.RowTemplate.Height = 28;
            dgvLowStock.Size = new Size(1455, 154);
            dgvLowStock.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 50F;
            Column1.HeaderText = "Products";
            Column1.MinimumWidth = 50;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 50F;
            Column2.HeaderText = "Stock";
            Column2.MinimumWidth = 50;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // pnlRecentOredrs
            // 
            pnlRecentOredrs.Controls.Add(tlprecentorders);
            pnlRecentOredrs.Dock = DockStyle.Fill;
            pnlRecentOredrs.Location = new Point(3, 368);
            pnlRecentOredrs.Margin = new Padding(3, 4, 3, 4);
            pnlRecentOredrs.Name = "pnlRecentOredrs";
            pnlRecentOredrs.Padding = new Padding(11, 0, 0, 0);
            pnlRecentOredrs.Size = new Size(1472, 207);
            pnlRecentOredrs.TabIndex = 2;
            // 
            // tlprecentorders
            // 
            tlprecentorders.ColumnCount = 1;
            tlprecentorders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlprecentorders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlprecentorders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tlprecentorders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tlprecentorders.Controls.Add(lblrecentsorders, 0, 0);
            tlprecentorders.Controls.Add(dgvRecentorders, 0, 1);
            tlprecentorders.Dock = DockStyle.Fill;
            tlprecentorders.Location = new Point(11, 0);
            tlprecentorders.Margin = new Padding(3, 4, 3, 4);
            tlprecentorders.Name = "tlprecentorders";
            tlprecentorders.RowCount = 2;
            tlprecentorders.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlprecentorders.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlprecentorders.Size = new Size(1461, 207);
            tlprecentorders.TabIndex = 0;
            // 
            // lblrecentsorders
            // 
            lblrecentsorders.AutoSize = true;
            lblrecentsorders.BackColor = SystemColors.ControlDark;
            lblrecentsorders.Dock = DockStyle.Fill;
            lblrecentsorders.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblrecentsorders.Location = new Point(3, 0);
            lblrecentsorders.Name = "lblrecentsorders";
            lblrecentsorders.Size = new Size(1455, 103);
            lblrecentsorders.TabIndex = 0;
            lblrecentsorders.Text = "Recent Orders";
            // 
            // dgvRecentorders
            // 
            dgvRecentorders.BackgroundColor = SystemColors.Control;
            dgvRecentorders.BorderStyle = BorderStyle.None;
            dgvRecentorders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentorders.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column3, Column4 });
            dgvRecentorders.Dock = DockStyle.Fill;
            dgvRecentorders.Location = new Point(3, 107);
            dgvRecentorders.Margin = new Padding(3, 4, 3, 4);
            dgvRecentorders.Name = "dgvRecentorders";
            dgvRecentorders.RowHeadersWidth = 62;
            dgvRecentorders.RowTemplate.Height = 28;
            dgvRecentorders.Size = new Size(1455, 96);
            dgvRecentorders.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "orders";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Customers";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "total";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(1478, 579);
            Click += DashboardView_Click;
            tblDashboard.ResumeLayout(false);
            flpKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            pnlRecentOredrs.ResumeLayout(false);
            tlprecentorders.ResumeLayout(false);
            tlprecentorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentorders).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lowstock;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel pnlRecentOredrs;
        private System.Windows.Forms.TableLayoutPanel tlprecentorders;
        private System.Windows.Forms.Label lblrecentsorders;
        private System.Windows.Forms.DataGridView dgvRecentorders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
