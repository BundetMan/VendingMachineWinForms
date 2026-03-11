namespace DrinkStoreUI
{
    partial class AllForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnFilterAll = new Button();
            btnFilterDrink = new Button();
            btnFilterSnack = new Button();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            txtInputCash = new TextBox();
            label2 = new Label();
            labelBalance = new Label();
            comboSelectCurrency = new ComboBox();
            btnInsertCash = new Button();
            labelState = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(252, 26);
            label1.Name = "label1";
            label1.Size = new Size(377, 46);
            label1.TabIndex = 3;
            label1.Text = "Smart Vending Machine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(264, 86);
            label3.Name = "label3";
            label3.Size = new Size(308, 28);
            label3.TabIndex = 5;
            label3.Text = "Select Your Favorite Product Here ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnFilterAll);
            flowLayoutPanel1.Controls.Add(btnFilterDrink);
            flowLayoutPanel1.Controls.Add(btnFilterSnack);
            flowLayoutPanel1.Location = new Point(690, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 36);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnFilterAll
            // 
            btnFilterAll.Location = new Point(3, 3);
            btnFilterAll.Name = "btnFilterAll";
            btnFilterAll.Size = new Size(94, 29);
            btnFilterAll.TabIndex = 1;
            btnFilterAll.Text = "All";
            btnFilterAll.UseVisualStyleBackColor = true;
            // 
            // btnFilterDrink
            // 
            btnFilterDrink.Location = new Point(103, 3);
            btnFilterDrink.Name = "btnFilterDrink";
            btnFilterDrink.Size = new Size(94, 29);
            btnFilterDrink.TabIndex = 0;
            btnFilterDrink.Text = "Drink";
            btnFilterDrink.UseVisualStyleBackColor = true;
            // 
            // btnFilterSnack
            // 
            btnFilterSnack.Location = new Point(203, 3);
            btnFilterSnack.Name = "btnFilterSnack";
            btnFilterSnack.Size = new Size(94, 29);
            btnFilterSnack.TabIndex = 2;
            btnFilterSnack.Text = "Snacks";
            btnFilterSnack.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(65, 183);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(1152, 580);
            flowLayoutPanelProducts.TabIndex = 9;
            // 
            // txtInputCash
            // 
            txtInputCash.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputCash.Location = new Point(1223, 198);
            txtInputCash.Name = "txtInputCash";
            txtInputCash.Size = new Size(161, 30);
            txtInputCash.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1223, 137);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 11;
            label2.Text = "Input money here";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.Location = new Point(1223, 370);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(159, 28);
            labelBalance.TabIndex = 12;
            labelBalance.Text = "Your money is : 0";
            // 
            // comboSelectCurrency
            // 
            comboSelectCurrency.FormattingEnabled = true;
            comboSelectCurrency.Items.AddRange(new object[] { "USD", "KHR" });
            comboSelectCurrency.Location = new Point(1223, 164);
            comboSelectCurrency.Name = "comboSelectCurrency";
            comboSelectCurrency.Size = new Size(174, 28);
            comboSelectCurrency.TabIndex = 13;
            comboSelectCurrency.Text = "Select Currency";
            comboSelectCurrency.SelectedIndexChanged += comboSelectCurrency_SelectedIndexChanged;
            // 
            // btnInsertCash
            // 
            btnInsertCash.Location = new Point(1358, 234);
            btnInsertCash.Name = "btnInsertCash";
            btnInsertCash.Size = new Size(94, 29);
            btnInsertCash.TabIndex = 14;
            btnInsertCash.Text = "Insert";
            btnInsertCash.UseVisualStyleBackColor = true;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Font = new Font("Segoe UI", 12F);
            labelState.Location = new Point(1223, 26);
            labelState.Name = "labelState";
            labelState.Size = new Size(65, 28);
            labelState.TabIndex = 15;
            labelState.Text = "State: ";
            // 
            // AllForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1454, 806);
            Controls.Add(labelState);
            Controls.Add(btnInsertCash);
            Controls.Add(comboSelectCurrency);
            Controls.Add(labelBalance);
            Controls.Add(label2);
            Controls.Add(txtInputCash);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllForm";
            Text = " ";
            Load += AllForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnFilterDrink;
        private Button btnFilterAll;
        private Button btnFilterSnack;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private TextBox txtInputCash;
        private Label label2;
        private Label labelBalance;
        private ComboBox comboSelectCurrency;
        private Button btnInsertCash;
        private Label labelState;
    }
}
