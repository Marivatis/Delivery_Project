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
            labelTotalPrice = new Label();
            buttonAddToCart = new Button();
            buttonRemove = new Button();
            labelCart = new Label();
            listBoxCart = new ListBox();
            dataGridView1 = new DataGridView();
            buttonOrder = new Button();
            buttonAdd = new Button();
            panelSeparator1 = new Panel();
            label5 = new Label();
            comboBoxPlaces = new ComboBox();
            labelProductPrice = new Label();
            labelDeliveryPrice = new Label();
            labelPlaceDeliveryPrice = new Label();
            labelPlaceAddress = new Label();
            labelPlaceDescription = new Label();
            labelPlaceName = new Label();
            labelOrderStatus = new Label();
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
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPrice.ForeColor = SystemColors.Control;
            labelTotalPrice.Location = new Point(12, 359);
            labelTotalPrice.MaximumSize = new Size(400, 50);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(172, 25);
            labelTotalPrice.TabIndex = 25;
            labelTotalPrice.Text = "Total price: 0 UAH";
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.FlatStyle = FlatStyle.Flat;
            buttonAddToCart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToCart.ForeColor = Color.White;
            buttonAddToCart.Location = new Point(746, 494);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(234, 34);
            buttonAddToCart.TabIndex = 23;
            buttonAddToCart.Text = "Add to cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
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
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCart.ForeColor = SystemColors.Control;
            labelCart.Location = new Point(12, 35);
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
            listBoxCart.SelectedValueChanged += ListBoxCart_SelectedValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(61, 61, 61);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(280, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 297);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // buttonOrder
            // 
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrder.ForeColor = Color.White;
            buttonOrder.Location = new Point(12, 494);
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
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelSeparator1
            // 
            panelSeparator1.BackColor = Color.FromArgb(61, 61, 61);
            panelSeparator1.Location = new Point(262, 26);
            panelSeparator1.Name = "panelSeparator1";
            panelSeparator1.Size = new Size(1, 522);
            panelSeparator1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(280, 157);
            label5.MaximumSize = new Size(400, 50);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 30;
            label5.Text = "Menu:";
            // 
            // comboBoxPlaces
            // 
            comboBoxPlaces.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxPlaces.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlaces.FlatStyle = FlatStyle.Flat;
            comboBoxPlaces.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPlaces.ForeColor = Color.White;
            comboBoxPlaces.FormattingEnabled = true;
            comboBoxPlaces.Location = new Point(746, 39);
            comboBoxPlaces.Name = "comboBoxPlaces";
            comboBoxPlaces.Size = new Size(234, 33);
            comboBoxPlaces.TabIndex = 31;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelProductPrice.ForeColor = SystemColors.Control;
            labelProductPrice.Location = new Point(12, 309);
            labelProductPrice.MaximumSize = new Size(400, 50);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(200, 25);
            labelProductPrice.TabIndex = 33;
            labelProductPrice.Text = "Products price: 0 UAH";
            // 
            // labelDeliveryPrice
            // 
            labelDeliveryPrice.AutoSize = true;
            labelDeliveryPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDeliveryPrice.ForeColor = SystemColors.Control;
            labelDeliveryPrice.Location = new Point(12, 334);
            labelDeliveryPrice.MaximumSize = new Size(400, 50);
            labelDeliveryPrice.Name = "labelDeliveryPrice";
            labelDeliveryPrice.Size = new Size(196, 25);
            labelDeliveryPrice.TabIndex = 32;
            labelDeliveryPrice.Text = "Delivery price: 0 UAH";
            // 
            // labelPlaceDeliveryPrice
            // 
            labelPlaceDeliveryPrice.AutoSize = true;
            labelPlaceDeliveryPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceDeliveryPrice.ForeColor = SystemColors.Control;
            labelPlaceDeliveryPrice.Location = new Point(280, 66);
            labelPlaceDeliveryPrice.MaximumSize = new Size(500, 25);
            labelPlaceDeliveryPrice.Name = "labelPlaceDeliveryPrice";
            labelPlaceDeliveryPrice.Size = new Size(183, 25);
            labelPlaceDeliveryPrice.TabIndex = 54;
            labelPlaceDeliveryPrice.Text = "Place delivery price";
            // 
            // labelPlaceAddress
            // 
            labelPlaceAddress.AutoSize = true;
            labelPlaceAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceAddress.ForeColor = SystemColors.Control;
            labelPlaceAddress.Location = new Point(280, 90);
            labelPlaceAddress.MaximumSize = new Size(500, 25);
            labelPlaceAddress.Name = "labelPlaceAddress";
            labelPlaceAddress.Size = new Size(131, 25);
            labelPlaceAddress.TabIndex = 53;
            labelPlaceAddress.Text = "Place address";
            // 
            // labelPlaceDescription
            // 
            labelPlaceDescription.AutoSize = true;
            labelPlaceDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPlaceDescription.ForeColor = SystemColors.Control;
            labelPlaceDescription.Location = new Point(280, 115);
            labelPlaceDescription.MaximumSize = new Size(700, 42);
            labelPlaceDescription.Name = "labelPlaceDescription";
            labelPlaceDescription.Size = new Size(688, 42);
            labelPlaceDescription.TabIndex = 52;
            labelPlaceDescription.Text = "Place description Place description Place description Place description Place description Place description Place description Place description Place description ";
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = SystemColors.Control;
            labelPlaceName.Location = new Point(280, 34);
            labelPlaceName.MaximumSize = new Size(500, 32);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(144, 32);
            labelPlaceName.TabIndex = 51;
            labelPlaceName.Text = "Place name";
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderStatus.ForeColor = SystemColors.Control;
            labelOrderStatus.Location = new Point(12, 463);
            labelOrderStatus.MaximumSize = new Size(400, 50);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(126, 25);
            labelOrderStatus.TabIndex = 55;
            labelOrderStatus.Text = "Order status:";
            labelOrderStatus.Visible = false;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(labelOrderStatus);
            Controls.Add(labelPlaceDeliveryPrice);
            Controls.Add(labelPlaceAddress);
            Controls.Add(labelPlaceDescription);
            Controls.Add(labelPlaceName);
            Controls.Add(labelProductPrice);
            Controls.Add(labelDeliveryPrice);
            Controls.Add(comboBoxPlaces);
            Controls.Add(buttonAddToCart);
            Controls.Add(label5);
            Controls.Add(panelSeparator1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonRemove);
            Controls.Add(labelCart);
            Controls.Add(listBoxCart);
            Controls.Add(dataGridView1);
            Controls.Add(buttonMyProfile);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            Controls.SetChildIndex(buttonMyProfile, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(listBoxCart, 0);
            Controls.SetChildIndex(labelCart, 0);
            Controls.SetChildIndex(buttonRemove, 0);
            Controls.SetChildIndex(labelTotalPrice, 0);
            Controls.SetChildIndex(buttonOrder, 0);
            Controls.SetChildIndex(buttonAdd, 0);
            Controls.SetChildIndex(panelSeparator1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(buttonAddToCart, 0);
            Controls.SetChildIndex(comboBoxPlaces, 0);
            Controls.SetChildIndex(labelDeliveryPrice, 0);
            Controls.SetChildIndex(labelProductPrice, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(labelPlaceDescription, 0);
            Controls.SetChildIndex(labelPlaceAddress, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPrice, 0);
            Controls.SetChildIndex(labelOrderStatus, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button buttonMyProfile;
        private Label labelTotalPrice;
        private Button buttonAddToCart;
        private Button buttonRemove;
        private Label labelCart;
        private ListBox listBoxCart;
        private DataGridView dataGridView1;
        private Button buttonOrder;
        private Button buttonAdd;
        private Panel panelSeparator1;
        private Label label5;
        private ComboBox comboBoxPlaces;
        private Label labelProductPrice;
        private Label labelDeliveryPrice;
        private Label labelPlaceDeliveryPrice;
        private Label labelPlaceAddress;
        private Label labelPlaceDescription;
        private Label labelPlaceName;
        private Label labelOrderStatus;
    }
}