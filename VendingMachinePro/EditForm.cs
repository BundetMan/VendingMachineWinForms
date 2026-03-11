using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using VendingMachinePro.Logic.Data;
using VendingMachinePro.Models;

namespace VendingMachinePro
{
    public partial class EditForm : Form
    {
        private Product _product;
        public EditForm(Product product)
        {
            InitializeComponent();
            pictureImage.SizeMode = PictureBoxSizeMode.StretchImage;

            _product = product;

            // Pre-fill controls
            txtProName.Text = product.Name;
            txtProPrice.Text = product.Price.ToString();
            txtProStock.Text = product.Stock.ToString();
            txtProCategory.Text = product.Category;
            pictureImage.ImageLocation = product.ImagePath;

            btnUpdate.Click += btnSave_Click!;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DbcontextManager.Instance;
                // Update product properties
                _product.Name = txtProName.Text;
                _product.Price = decimal.Parse(txtProPrice.Text);
                _product.Stock = int.Parse(txtProStock.Text);
                _product.Category = txtProCategory.Text;
                _product.ImagePath = pictureImage.ImageLocation!;
                // Save changes to database
                db.SaveChanges();
                MessageBox.Show("Product updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseImage_Click_1(object? sender, EventArgs e)
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

    }
}
