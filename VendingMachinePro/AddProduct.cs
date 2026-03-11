using VendingMachinePro.Logic.Data;
using VendingMachinePro.Logic.FactoryMethodPattern;
using VendingMachinePro.Models;

namespace DrinkStoreUI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            pictureImage.SizeMode = PictureBoxSizeMode.StretchImage;

            btnBrowseImage.Click += btnBrowseImage_Click;
            btnAdd.Click += btnAdd_Click;        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                var db = DbcontextManager.Instance;

                ProductFactory factory;

                // Create new product
                if (txtProCategory.Text.ToLower() == "snack")
                    factory = new SnackFactory();
                else if (txtProCategory.Text.ToLower() == "drink")
                    factory = new DrinkFactory();
                else
                    throw new Exception("Unknown category");

                var product = (Product) factory.Create(
                    txtProName.Text,
                    decimal.Parse(txtProPrice.Text),
                    int.Parse(txtProStock.Text),
                    txtProCategory.Text,
                    pictureImage.ImageLocation!
                );

                // Save to database
                db.Products.Add(product);
                db.SaveChanges();

                this.DialogResult = DialogResult.OK;


                MessageBox.Show("Product added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form for next entry
                txtProName.Clear();
                txtProPrice.Clear();
                txtProStock.Clear();
                pictureImage.Image = null;
                txtProCategory.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseImage_Click(object? sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select an Image",
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                };
                string filePath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    pictureImage.ImageLocation = filePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
