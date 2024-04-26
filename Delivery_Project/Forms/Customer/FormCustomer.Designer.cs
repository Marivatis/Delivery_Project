namespace Delivery_Project.Forms.Customer
{
    partial class FormCustomer
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
            buttonMyProfile = new Button();
            label4 = new Label();
            label3 = new Label();
            buttonAddToCart = new Button();
            buttonRemove = new Button();
            labelCart = new Label();
            listBoxCart = new ListBox();
            labelPlaceName = new Label();
            dataGridView1 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            buttonOrder = new Button();
            buttonAdd = new Button();
            panelSeparator1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            comboBoxPlaces = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonMyProfile
            // 
            buttonMyProfile.FlatAppearance.BorderSize = 0;
            buttonMyProfile.FlatStyle = FlatStyle.Flat;
            buttonMyProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMyProfile.ForeColor = Color.White;
            buttonMyProfile.Location = new Point(1, 1);
            buttonMyProfile.Name = "buttonMyProfile";
            buttonMyProfile.Size = new Size(75, 25);
            buttonMyProfile.TabIndex = 6;
            buttonMyProfile.Text = "My Profile";
            buttonMyProfile.UseVisualStyleBackColor = true;
            buttonMyProfile.Click += buttonMyProfile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 415);
            label4.MaximumSize = new Size(400, 50);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 25;
            label4.Text = "Total price: 150@";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(280, 93);
            label3.MaximumSize = new Size(700, 63);
            label3.Name = "label3";
            label3.Size = new Size(688, 42);
            label3.TabIndex = 24;
            label3.Text = "Place description Place description Place description Place description Place description Place description Place description Place description Place description ";
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.FlatStyle = FlatStyle.Flat;
            buttonAddToCart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToCart.ForeColor = Color.White;
            buttonAddToCart.Location = new Point(801, 494);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(187, 34);
            buttonAddToCart.TabIndex = 23;
            buttonAddToCart.Text = "Add to cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(12, 268);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 34);
            buttonRemove.TabIndex = 21;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCart.ForeColor = SystemColors.Control;
            labelCart.Location = new Point(12, 36);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(108, 30);
            labelCart.TabIndex = 20;
            labelCart.Text = "Your cart:";
            // 
            // listBoxCart
            // 
            listBoxCart.BackColor = Color.FromArgb(31, 31, 31);
            listBoxCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxCart.ForeColor = Color.White;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 21;
            listBoxCart.Location = new Point(12, 69);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(234, 193);
            listBoxCart.TabIndex = 19;
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = SystemColors.Control;
            labelPlaceName.Location = new Point(280, 36);
            labelPlaceName.MaximumSize = new Size(500, 32);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(144, 32);
            labelPlaceName.TabIndex = 18;
            labelPlaceName.Text = "Place name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Description });
            dataGridView1.Location = new Point(280, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(708, 297);
            dataGridView1.TabIndex = 17;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // buttonOrder
            // 
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrder.ForeColor = Color.White;
            buttonOrder.Location = new Point(12, 308);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(234, 34);
            buttonOrder.TabIndex = 26;
            buttonOrder.Text = "Order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(129, 268);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 34);
            buttonAdd.TabIndex = 27;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panelSeparator1
            // 
            panelSeparator1.BackColor = Color.FromArgb(61, 61, 61);
            panelSeparator1.Location = new Point(262, 26);
            panelSeparator1.Name = "panelSeparator1";
            panelSeparator1.Size = new Size(1, 550);
            panelSeparator1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(280, 68);
            label2.MaximumSize = new Size(500, 25);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 29;
            label2.Text = "Place address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(280, 163);
            label5.MaximumSize = new Size(400, 50);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 30;
            label5.Text = "Menu:";
            // 
            // comboBoxPlaces
            // 
            comboBoxPlaces.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxPlaces.FlatStyle = FlatStyle.Flat;
            comboBoxPlaces.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPlaces.ForeColor = Color.White;
            comboBoxPlaces.FormattingEnabled = true;
            comboBoxPlaces.Location = new Point(779, 39);
            comboBoxPlaces.Name = "comboBoxPlaces";
            comboBoxPlaces.Size = new Size(209, 33);
            comboBoxPlaces.TabIndex = 31;
            comboBoxPlaces.Text = "Place...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 390);
            label1.MaximumSize = new Size(400, 50);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 32;
            label1.Text = "Delivery price: 45@";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 365);
            label6.MaximumSize = new Size(400, 50);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 33;
            label6.Text = "Products price: 105@";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(comboBoxPlaces);
            Controls.Add(buttonAddToCart);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panelSeparator1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonRemove);
            Controls.Add(labelCart);
            Controls.Add(listBoxCart);
            Controls.Add(labelPlaceName);
            Controls.Add(dataGridView1);
            Controls.Add(buttonMyProfile);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            Controls.SetChildIndex(buttonMyProfile, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(listBoxCart, 0);
            Controls.SetChildIndex(labelCart, 0);
            Controls.SetChildIndex(buttonRemove, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(buttonOrder, 0);
            Controls.SetChildIndex(buttonAdd, 0);
            Controls.SetChildIndex(panelSeparator1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(buttonAddToCart, 0);
            Controls.SetChildIndex(comboBoxPlaces, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label6, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMyProfile;
        private Label label4;
        private Label label3;
        private Button buttonAddToCart;
        private Button buttonRemove;
        private Label labelCart;
        private ListBox listBoxCart;
        private Label labelPlaceName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private Button buttonOrder;
        private Button buttonAdd;
        private Panel panelSeparator1;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxPlaces;
        private Label label1;
        private Label label6;
    }
}