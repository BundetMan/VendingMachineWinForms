using VendingMachinePro;
using VendingMachinePro.Logic.Data;
using VendingMachinePro.Models;

namespace DrinkStoreUI
{
    public partial class AdminDasdbord : Form
    {
        public AdminDasdbord()
        {
            InitializeComponent();
            SetupAdminGrid();
            LoadAdminProducts();
            LoadDashboardStats();
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnAddProduct.Click += btnAddProduct_Click!;
            btnRefresh.Click += btnRefresh_Click!;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SetupAdminGrid()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Clear();

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Product Name"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price (KHR)"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock"
            });

            // Edit button
            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };

            // Delete button
            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridViewProducts.Columns.Add(editButton);
            dataGridViewProducts.Columns.Add(deleteButton);

            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
        }
        private void LoadAdminProducts()
        {
            var db = DbcontextManager.Instance;
            dataGridViewProducts.DataSource = db.Products.ToList();
        }

        private void dataGridViewProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewProducts.Columns.Count)
            {
                var db = DbcontextManager.Instance;
                var product = (Product)dataGridViewProducts.Rows[e.RowIndex].DataBoundItem;

                var column = dataGridViewProducts.Columns[e.ColumnIndex];

                if (column is DataGridViewButtonColumn)
                {
                    if (e.ColumnIndex == 3) // Edit button
                    {
                        // Open Add/Edit form in edit mode
                        using (var form = new EditForm(product!)) // pass product to form
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                db.SaveChanges(); // persist changes
                                LoadAdminProducts(); // refresh grid
                            }
                        }
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        var confirm = MessageBox.Show(
                            $"Are you sure you want to delete {product!.Name}?",
                            "Confirm Delete",
                            MessageBoxButtons.YesNo);

                        if (confirm == DialogResult.Yes)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            LoadAdminProducts();
                        }
                    }
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void btnBacktoStore_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new AllForm();
            this.DialogResult = DialogResult.OK;
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdminProducts();
        }

        private void LoadDashboardStats()
        {
            var db = DbcontextManager.Instance;

            lblTotalRevenue.Text = db.Sales.Sum(s => s.Amount).ToString();
            lblTotalSales.Text = db.Sales.Count().ToString();
            lblTotalProducts.Text = db.Products.Count().ToString();
            lblNeedRestock.Text = db.Products.Count(p => p.Stock < 5).ToString();
        }

    }
}