using App.Core.Contracts;
using App.Core.Services;
using App.WinForms.Views;
using System;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        IProductService _productService = new InMemoryProductService();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();

        public MainForm()
        {
            InitializeComponent();
            btnDashboard.Click += btnDashboard_Click;
            btnProducts.Click += btnProducts_Click;


        }

        private void ShowView(Func<UserControl> viewFactory)
        {
            pnlContent.Controls.Clear();
            var view = viewFactory();
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductsView(_productService));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //ShowView(() => new CustomerView(_customerService));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports coming soon!", "Reports");
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sync feature coming soon!");
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logs feature coming soon!");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings coming soon!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            //var key = typeof(DashboardView);
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
                /*  var view = new T();*/

            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();


        }
    }
}
