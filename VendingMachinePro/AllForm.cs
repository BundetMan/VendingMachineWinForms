using VendingMachinePro.Logic.Data;
using VendingMachinePro.Logic.StrategyPattern;
using VendingMachinePro.Models;

namespace DrinkStoreUI
{
    public partial class AllForm : Form
    {
        private VendingMachine machine;

        public AllForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += AllForm_KeyDown;

            // No strategy yet — will be set when user picks currency
            machine = new VendingMachine(new RielPayment()); // default strategy
            machine.AddObserver(new MachineLogger());

            var stateObserver = new StateObserver(labelState);
            machine.AddObserver(stateObserver);

            txtInputCash.Enabled = false;
            btnInsertCash.Enabled = false;

            btnInsertCash.Click += btnInsertCash_Click;
            btnFilterAll.Click += (s, e) => LoadProducts("All");
            btnFilterSnack.Click += (s, e) => LoadProducts("Snack");
            btnFilterDrink.Click += (s, e) => LoadProducts("Drink");
        }

        private void AllForm_Load(object sender, EventArgs e)
        {
            LoadProducts("All");
        }

        private void LoadProducts(string category = "All")
        {
            flowLayoutPanelProducts.Controls.Clear();

            var db = DbcontextManager.Instance;
            var products = db.Products.AsQueryable();

            if (category != "All")
                products = products.Where(p => p.Category.ToLower() == category.ToLower());

            foreach (var product in products)
            {
                Panel card = new Panel
                {
                    Width = 257,
                    Height = 328,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pic = new PictureBox
                {
                    Width = 240,
                    Height = 180,
                    Top = 10,
                    Left = 8,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = product.ImagePath
                };

                Label lblName = new Label
                {
                    Text = product.Name,
                    Top = 200,
                    Left = 10,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold)
                };

                Label lblPrice = new Label
                {
                    Text = $"Riel {product.Price}",
                    Top = 230,
                    Left = 10,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };

                Label lblStock = new Label
                {
                    Text = product.Stock > 0 ? "In Stock" : "Out of Stock",
                    Top = 260,
                    Left = 10,
                    AutoSize = true,
                    ForeColor = product.Stock > 0 ? Color.Green : Color.Red,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic)
                };

                Button btnBuy = new Button
                {
                    Text = "Buy Now",
                    Top = 290,
                    Left = 10,
                    Width = 100,
                    Height = 30,
                    Enabled = product.Stock > 0
                };

                btnBuy.Click += (s, e) =>
                {
                    try
                    {
                        machine.SelectProduct(product.Id);
                        labelBalance.Text = $"Balance: {machine.CurrentMoney}";
                        LoadProducts(category); // refresh stock
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                card.Controls.AddRange(new Control[] { pic, lblName, lblPrice, lblStock, btnBuy });
                flowLayoutPanelProducts.Controls.Add(card);
            }
        }

        private void btnInsertCash_Click(object sender, EventArgs e)
        {

            if (machine == null)
            {
                MessageBox.Show("Machine not initialized.");
                return;
            }

            if (!decimal.TryParse(txtInputCash.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                machine.InsertMoney(amount);

                labelBalance.Text = $"Balance: {machine.CurrentMoney}";
                txtInputCash.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboSelectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboSelectCurrency.SelectedItem?.ToString();

            if (selected == "USD")
            {
                machine.SetPaymentStrategy(new DollarPayment());
                txtInputCash.Enabled = true;
                btnInsertCash.Enabled = true;
            }
            else if (selected == "KHR")
            {
                machine.SetPaymentStrategy(new RielPayment());
                txtInputCash.Enabled = true;
                btnInsertCash.Enabled = true;
            }
            else
            {
                txtInputCash.Enabled = false;
                btnInsertCash.Enabled = false;
            }
            txtInputCash.Clear();
        }

        private void AllForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.Hide();
                AdminDasdbord adminDasdbord = new AdminDasdbord();
                adminDasdbord.Show();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}