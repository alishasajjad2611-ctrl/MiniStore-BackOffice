namespace App.WindowsApp.Forms;

partial class MainForm
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
        pnlHeader = new Panel();
        flpRight = new FlowLayoutPanel();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        flpLeft = new FlowLayoutPanel();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        pnlSidebar = new Panel();
        flpButton = new FlowLayoutPanel();
        btnDashboard = new Button();
        btnProducts = new Button();
        btnOrders = new Button();
        btnReports = new Button();
        btnSync = new Button();
        btnLogs = new Button();
        btnSettings = new Button();
        pnlContent = new Panel();
        pnlHeader.SuspendLayout();
        flpRight.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        flpLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        pnlSidebar.SuspendLayout();
        flpButton.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(flpRight);
        pnlHeader.Controls.Add(flpLeft);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Margin = new Padding(3, 4, 3, 4);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(876, 62);
        pnlHeader.TabIndex = 3;
        // 
        // flpRight
        // 
        flpRight.Controls.Add(pictureBox1);
        flpRight.Controls.Add(label1);
        flpRight.Controls.Add(label2);
        flpRight.Dock = DockStyle.Right;
        flpRight.Location = new Point(723, 0);
        flpRight.Margin = new Padding(4);
        flpRight.Name = "flpRight";
        flpRight.Size = new Size(153, 62);
        flpRight.TabIndex = 4;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.user1;
        pictureBox1.Location = new Point(3, 4);
        pictureBox1.Margin = new Padding(3, 4, 3, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(46, 51);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(55, 0);
        label1.Name = "label1";
        label1.Padding = new Padding(0, 12, 0, 0);
        label1.Size = new Size(65, 37);
        label1.TabIndex = 5;
        label1.Text = "Admin";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 59);
        label2.Name = "label2";
        label2.Size = new Size(59, 25);
        label2.TabIndex = 5;
        label2.Text = "label2";
        // 
        // flpLeft
        // 
        flpLeft.Controls.Add(pictureBox2);
        flpLeft.Controls.Add(pictureBox3);
        flpLeft.Dock = DockStyle.Left;
        flpLeft.Location = new Point(0, 0);
        flpLeft.Margin = new Padding(4);
        flpLeft.Name = "flpLeft";
        flpLeft.Size = new Size(154, 62);
        flpLeft.TabIndex = 3;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.building_store1;
        pictureBox2.Location = new Point(3, 4);
        pictureBox2.Margin = new Padding(3, 4, 3, 4);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(81, 51);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 0;
        pictureBox2.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Location = new Point(3, 63);
        pictureBox3.Margin = new Padding(3, 4, 3, 4);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(111, 62);
        pictureBox3.TabIndex = 1;
        pictureBox3.TabStop = false;
        // 
        // pnlSidebar
        // 
        pnlSidebar.Controls.Add(flpButton);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 62);
        pnlSidebar.Margin = new Padding(3, 4, 3, 4);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(222, 705);
        pnlSidebar.TabIndex = 4;
        // 
        // flpButton
        // 
        flpButton.AutoScroll = true;
        flpButton.Controls.Add(btnDashboard);
        flpButton.Controls.Add(btnProducts);
        flpButton.Controls.Add(btnOrders);
        flpButton.Controls.Add(btnReports);
        flpButton.Controls.Add(btnSync);
        flpButton.Controls.Add(btnLogs);
        flpButton.Controls.Add(btnSettings);
        flpButton.Dock = DockStyle.Fill;
        flpButton.FlowDirection = FlowDirection.TopDown;
        flpButton.Location = new Point(0, 0);
        flpButton.Margin = new Padding(3, 4, 3, 4);
        flpButton.Name = "flpButton";
        flpButton.Size = new Size(222, 705);
        flpButton.TabIndex = 8;
        flpButton.WrapContents = false;
        // 
        // btnDashboard
        // 
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.Image = Properties.Resources.dasboard;
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        btnDashboard.Location = new Point(3, 4);
        btnDashboard.Margin = new Padding(3, 4, 3, 4);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Padding = new Padding(17, 0, 0, 0);
        btnDashboard.Size = new Size(222, 69);
        btnDashboard.TabIndex = 3;
        btnDashboard.Text = "Dashboard";
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnDashboard.UseVisualStyleBackColor = false;
        btnDashboard.Click += btnDashboard_Click_1;
        // 
        // btnProducts
        // 
        btnProducts.FlatAppearance.BorderSize = 0;
        btnProducts.FlatStyle = FlatStyle.Flat;
        btnProducts.Image = Properties.Resources.new_product;
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
        btnProducts.Location = new Point(3, 81);
        btnProducts.Margin = new Padding(3, 4, 3, 4);
        btnProducts.Name = "btnProducts";
        btnProducts.Padding = new Padding(17, 0, 0, 0);
        btnProducts.Size = new Size(222, 69);
        btnProducts.TabIndex = 4;
        btnProducts.Text = "Products";
        btnProducts.TextAlign = ContentAlignment.MiddleLeft;
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnProducts.UseVisualStyleBackColor = false;
        btnProducts.Click += btnProducts_Click;
        // 
        // btnOrders
        // 
        btnOrders.FlatAppearance.BorderSize = 0;
        btnOrders.FlatStyle = FlatStyle.Flat;
        btnOrders.Image = Properties.Resources.order;
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
        btnOrders.Location = new Point(3, 158);
        btnOrders.Margin = new Padding(3, 4, 3, 4);
        btnOrders.Name = "btnOrders";
        btnOrders.Padding = new Padding(17, 0, 0, 0);
        btnOrders.Size = new Size(222, 69);
        btnOrders.TabIndex = 5;
        btnOrders.Text = "Orders";
        btnOrders.TextAlign = ContentAlignment.MiddleLeft;
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnOrders.UseVisualStyleBackColor = false;
        // 
        // btnReports
        // 
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.Image = Properties.Resources.report;
        btnReports.ImageAlign = ContentAlignment.MiddleLeft;
        btnReports.Location = new Point(3, 235);
        btnReports.Margin = new Padding(3, 4, 3, 4);
        btnReports.Name = "btnReports";
        btnReports.Padding = new Padding(17, 0, 0, 0);
        btnReports.Size = new Size(222, 69);
        btnReports.TabIndex = 6;
        btnReports.Text = "Reports";
        btnReports.TextAlign = ContentAlignment.MiddleLeft;
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnReports.UseVisualStyleBackColor = false;
        // 
        // btnSync
        // 
        btnSync.FlatAppearance.BorderSize = 0;
        btnSync.FlatStyle = FlatStyle.Flat;
        btnSync.Image = Properties.Resources.sync;
        btnSync.ImageAlign = ContentAlignment.MiddleLeft;
        btnSync.Location = new Point(3, 312);
        btnSync.Margin = new Padding(3, 4, 3, 4);
        btnSync.Name = "btnSync";
        btnSync.Padding = new Padding(17, 0, 0, 0);
        btnSync.Size = new Size(222, 69);
        btnSync.TabIndex = 7;
        btnSync.Text = "Sync";
        btnSync.TextAlign = ContentAlignment.MiddleLeft;
        btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSync.UseVisualStyleBackColor = false;
        // 
        // btnLogs
        // 
        btnLogs.FlatAppearance.BorderSize = 0;
        btnLogs.FlatStyle = FlatStyle.Flat;
        btnLogs.Image = Properties.Resources.log;
        btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
        btnLogs.Location = new Point(3, 389);
        btnLogs.Margin = new Padding(3, 4, 3, 4);
        btnLogs.Name = "btnLogs";
        btnLogs.Padding = new Padding(17, 0, 0, 0);
        btnLogs.Size = new Size(222, 69);
        btnLogs.TabIndex = 8;
        btnLogs.Text = "Logs";
        btnLogs.TextAlign = ContentAlignment.MiddleLeft;
        btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnLogs.UseVisualStyleBackColor = false;
        // 
        // btnSettings
        // 
        btnSettings.FlatAppearance.BorderSize = 0;
        btnSettings.FlatStyle = FlatStyle.Flat;
        btnSettings.Image = Properties.Resources.setting;
        btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
        btnSettings.Location = new Point(3, 466);
        btnSettings.Margin = new Padding(3, 4, 3, 4);
        btnSettings.Name = "btnSettings";
        btnSettings.Padding = new Padding(17, 0, 0, 0);
        btnSettings.Size = new Size(222, 69);
        btnSettings.TabIndex = 9;
        btnSettings.Text = "Settings";
        btnSettings.TextAlign = ContentAlignment.MiddleLeft;
        btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSettings.UseVisualStyleBackColor = false;
        // 
        // pnlContent
        // 
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(222, 62);
        pnlContent.Margin = new Padding(3, 4, 3, 4);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(654, 705);
        pnlContent.TabIndex = 5;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(876, 767);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Controls.Add(pnlHeader);
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        Click += btnDashboard_Click;
        pnlHeader.ResumeLayout(false);
        flpRight.ResumeLayout(false);
        flpRight.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        flpLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        pnlSidebar.ResumeLayout(false);
        flpButton.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.FlowLayoutPanel flpButton;
    private System.Windows.Forms.Button btnDashboard;
    private System.Windows.Forms.Button btnProducts;
    private System.Windows.Forms.Button btnOrders;
    private System.Windows.Forms.Button btnReports;
    private System.Windows.Forms.Button btnSync;
    private System.Windows.Forms.Button btnLogs;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.FlowLayoutPanel flpLeft;
    private System.Windows.Forms.FlowLayoutPanel flpRight;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel pnlContent;
}

