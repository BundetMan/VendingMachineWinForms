namespace DrinkStoreUI
{
    partial class AddProduct
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
            btnBrowseImage = new Button();
            pictureImage = new PictureBox();
            txtProCategory = new TextBox();
            txtProStock = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtProPrice = new TextBox();
            label4 = new Label();
            txtProName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            SuspendLayout();
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(311, 607);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(94, 42);
            btnBrowseImage.TabIndex = 18;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // pictureImage
            // 
            pictureImage.Location = new Point(293, 539);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(125, 62);
            pictureImage.TabIndex = 17;
            pictureImage.TabStop = false;
            // 
            // txtProCategory
            // 
            txtProCategory.Location = new Point(216, 437);
            txtProCategory.Name = "txtProCategory";
            txtProCategory.Size = new Size(298, 27);
            txtProCategory.TabIndex = 16;
            // 
            // txtProStock
            // 
            txtProStock.Location = new Point(216, 347);
            txtProStock.Name = "txtProStock";
            txtProStock.Size = new Size(298, 27);
            txtProStock.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 13F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(424, 674);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 42);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Products";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 13F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(101, 674);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 42);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 46);
            label1.TabIndex = 0;
            label1.Text = "Add New Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(219, 497);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 11;
            label7.Text = "Image URL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(219, 404);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 8;
            label6.Text = "Categorys";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(219, 314);
            label5.Name = "label5";
            label5.Size = new Size(158, 30);
            label5.TabIndex = 6;
            label5.Text = "Stock quantitys";
            // 
            // txtProPrice
            // 
            txtProPrice.Location = new Point(216, 257);
            txtProPrice.Name = "txtProPrice";
            txtProPrice.Size = new Size(298, 27);
            txtProPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(216, 224);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(216, 172);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(298, 27);
            txtProName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(216, 139);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 2;
            label3.Text = "Products Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(204, 76);
            label2.Name = "label2";
            label2.Size = new Size(421, 35);
            label2.TabIndex = 1;
            label2.Text = "Enter the details for the new product";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(890, 766);
            Controls.Add(btnBrowseImage);
            Controls.Add(pictureImage);
            Controls.Add(txtProCategory);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtProStock);
            Controls.Add(label5);
            Controls.Add(txtProPrice);
            Controls.Add(label4);
            Controls.Add(txtProName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S";
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseImage;
        private PictureBox pictureImage;
        private TextBox txtProCategory;
        private TextBox txtProStock;
        private Button btnAdd;
        private Button btnCancel;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtProPrice;
        private Label label4;
        private TextBox txtProName;
        private Label label3;
        private Label label2;
    }
}