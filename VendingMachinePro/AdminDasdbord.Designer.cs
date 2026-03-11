namespace DrinkStoreUI
{
    partial class AdminDasdbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDasdbord));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblTotalRevenue = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            lblTotalProducts = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            lblTotalSales = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            lblNeedRestock = new Label();
            label12 = new Label();
            btnBacktoStore = new Button();
            btnRefresh = new Button();
            btnAddProduct = new Button();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            dataGridViewProducts = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(335, 27);
            label1.Name = "label1";
            label1.Size = new Size(290, 46);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 73);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 1;
            label2.Text = "Manage products and monitor sales";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTotalRevenue);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(214, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 169);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 132);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 2;
            label5.Text = "All from Sale";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 11F);
            lblTotalRevenue.Location = new Point(36, 92);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(52, 25);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "100$";
            lblTotalRevenue.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(36, 26);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Revenue";
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblTotalProducts);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(838, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 169);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 132);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 4;
            label11.Text = "In Inventory";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 11F);
            lblTotalProducts.Location = new Point(58, 92);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(42, 25);
            lblTotalProducts.TabIndex = 3;
            lblTotalProducts.Text = "100";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(58, 26);
            label9.Name = "label9";
            label9.Size = new Size(136, 25);
            label9.TabIndex = 2;
            label9.Text = " Total Products";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblTotalSales);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(519, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 169);
            panel3.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 132);
            label8.Name = "label8";
            label8.Size = new Size(166, 20);
            label8.TabIndex = 3;
            label8.Text = "Completed transactions";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 11F);
            lblTotalSales.Location = new Point(37, 92);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(52, 25);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "100$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(71, 26);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 1;
            label6.Text = " Total Sales";
            // 
            // panel4
            // 
            panel4.Controls.Add(label14);
            panel4.Controls.Add(lblNeedRestock);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(1163, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 169);
            panel4.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 132);
            label14.Name = "label14";
            label14.Size = new Size(121, 20);
            label14.TabIndex = 5;
            label14.Text = "Need Restocking";
            // 
            // lblNeedRestock
            // 
            lblNeedRestock.AutoSize = true;
            lblNeedRestock.Font = new Font("Segoe UI", 11F);
            lblNeedRestock.Location = new Point(52, 92);
            lblNeedRestock.Name = "lblNeedRestock";
            lblNeedRestock.Size = new Size(42, 25);
            lblNeedRestock.TabIndex = 4;
            lblNeedRestock.Text = "100";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(52, 26);
            label12.Name = "label12";
            label12.Size = new Size(136, 25);
            label12.TabIndex = 3;
            label12.Text = " Total Products";
            // 
            // btnBacktoStore
            // 
            btnBacktoStore.Location = new Point(1265, 27);
            btnBacktoStore.Name = "btnBacktoStore";
            btnBacktoStore.Size = new Size(124, 29);
            btnBacktoStore.TabIndex = 4;
            btnBacktoStore.Text = "Back to Store";
            btnBacktoStore.UseVisualStyleBackColor = true;
            btnBacktoStore.Click += btnBacktoStore_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Blue;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(214, 349);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(146, 35);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 192, 0);
            btnAddProduct.Location = new Point(1220, 339);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(169, 29);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add New Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(519, 349);
            label17.Name = "label17";
            label17.Size = new Size(164, 20);
            label17.TabIndex = 9;
            label17.Text = "Products Managements";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(713, 349);
            label18.Name = "label18";
            label18.Size = new Size(308, 20);
            label18.TabIndex = 5;
            label18.Text = "Add, edit, or remove products from inventory";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(214, 405);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(1043, 395);
            dataGridViewProducts.TabIndex = 10;
            // 
            // AdminDasdbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 845);
            Controls.Add(dataGridViewProducts);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddProduct);
            Controls.Add(btnRefresh);
            Controls.Add(btnBacktoStore);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDasdbord";
            Text = "AdminDasdbord";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnBacktoStore;
        private Label label3;
        private Label lblTotalRevenue;
        private Label label5;
        private Label label8;
        private Label lblTotalSales;
        private Label label6;
        private Label label9;
        private Label label11;
        private Label lblTotalProducts;
        private Label label12;
        private Label label14;
        private Label lblNeedRestock;
        private Button btnRefresh;
        private Button btnAddProduct;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label18;
        private DataGridView dataGridViewProducts;
    }
}