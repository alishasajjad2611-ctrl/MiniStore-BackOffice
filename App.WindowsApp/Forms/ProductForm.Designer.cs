namespace App.WindowsApp.Forms
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            cmbCat = new ComboBox();
            nuStock = new NumericUpDown();
            nuPrice = new NumericUpDown();
            cmbProductStatus = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnsave = new Button();
            btncancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtId, 1, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbCat, 1, 1);
            tableLayoutPanel1.Controls.Add(nuStock, 1, 3);
            tableLayoutPanel1.Controls.Add(nuPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(cmbProductStatus, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1066, 376);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 200);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(30, 25);
            label6.TabIndex = 5;
            label6.Text = "ID";
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(93, 253);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(970, 31);
            txtId.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(93, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(970, 31);
            txtName.TabIndex = 12;
            // 
            // cmbCat
            // 
            cmbCat.Dock = DockStyle.Fill;
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(93, 53);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(970, 33);
            cmbCat.TabIndex = 13;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(93, 153);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(970, 31);
            nuStock.TabIndex = 15;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(93, 103);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(970, 31);
            nuPrice.TabIndex = 16;
            // 
            // cmbProductStatus
            // 
            cmbProductStatus.Dock = DockStyle.Fill;
            cmbProductStatus.FormattingEnabled = true;
            cmbProductStatus.Location = new Point(93, 203);
            cmbProductStatus.Name = "cmbProductStatus";
            cmbProductStatus.Size = new Size(970, 33);
            cmbProductStatus.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnsave);
            flowLayoutPanel1.Controls.Add(btncancel);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 395);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1066, 284);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsave.AutoSize = true;
            btnsave.Image = Properties.Resources.icons8_save_32;
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(960, 3);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(103, 38);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            btncancel.Image = Properties.Resources.icons8_cancel_32;
            btncancel.ImageAlign = ContentAlignment.MiddleLeft;
            btncancel.Location = new Point(830, 3);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(124, 34);
            btncancel.TabIndex = 1;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 679);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCat;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox2;
        private TextBox txtId;
        private TextBox txtName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnsave;
        private Button btncancel;
        private NumericUpDown nuStock;
        private NumericUpDown nuPrice;
        private ComboBox cmbProductStatus;
    }
}