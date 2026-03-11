namespace VendingMachinePro
{
    partial class EditForm
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
            btnUpdate = new Button();
            btnCancel = new Button();
            label7 = new Label();
            label6 = new Label();
            txtProStock = new TextBox();
            label5 = new Label();
            txtProPrice = new TextBox();
            label4 = new Label();
            txtProName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            SuspendLayout();
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(316, 609);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(94, 42);
            btnBrowseImage.TabIndex = 33;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click_1;
            // 
            // pictureImage
            // 
            pictureImage.Location = new Point(298, 541);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(125, 62);
            pictureImage.TabIndex = 32;
            pictureImage.TabStop = false;
            // 
            // txtProCategory
            // 
            txtProCategory.Location = new Point(221, 439);
            txtProCategory.Name = "txtProCategory";
            txtProCategory.Size = new Size(298, 27);
            txtProCategory.TabIndex = 31;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdate.Font = new Font("Segoe UI", 13F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(429, 676);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 42);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 13F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(106, 676);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 42);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(224, 499);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 28;
            label7.Text = "Image URL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(224, 406);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 27;
            label6.Text = "Categorys";
            // 
            // txtProStock
            // 
            txtProStock.Location = new Point(221, 349);
            txtProStock.Name = "txtProStock";
            txtProStock.Size = new Size(298, 27);
            txtProStock.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(224, 316);
            label5.Name = "label5";
            label5.Size = new Size(158, 30);
            label5.TabIndex = 25;
            label5.Text = "Stock quantitys";
            // 
            // txtProPrice
            // 
            txtProPrice.Location = new Point(221, 259);
            txtProPrice.Name = "txtProPrice";
            txtProPrice.Size = new Size(298, 27);
            txtProPrice.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(221, 226);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 23;
            label4.Text = "Price";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(221, 174);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(298, 27);
            txtProName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(221, 141);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 21;
            label3.Text = "Products Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(268, 26);
            label1.Name = "label1";
            label1.Size = new Size(204, 46);
            label1.TabIndex = 19;
            label1.Text = "Edit Product";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 775);
            Controls.Add(btnBrowseImage);
            Controls.Add(pictureImage);
            Controls.Add(txtProCategory);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtProStock);
            Controls.Add(label5);
            Controls.Add(txtProPrice);
            Controls.Add(label4);
            Controls.Add(txtProName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseImage;
        private PictureBox pictureImage;
        private TextBox txtProCategory;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label7;
        private Label label6;
        private TextBox txtProStock;
        private Label label5;
        private TextBox txtProPrice;
        private Label label4;
        private TextBox txtProName;
        private Label label3;
        private Label label1;
    }
}