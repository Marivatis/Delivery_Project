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
            buttonShowMyProfile = new Button();
            labelTotalPrice = new Label();
            buttonAddToCart = new Button();
            buttonRemoveCartProduct = new Button();
            labelCartTitle = new Label();
            listBoxCustomerCart = new ListBox();
            dataGridViewPlaceMenu = new DataGridView();
            buttonMakeOrder = new Button();
            buttonAddCartProduct = new Button();
            panelDecorativeSeparator = new Panel();
            labelMenuTitle = new Label();
            comboBoxPlacesList = new ComboBox();
            labelProductPrice = new Label();
            labelDeliveryPrice = new Label();
            labelPlaceDeliveryPrice = new Label();
            labelPlaceAddress = new Label();
            labelPlaceDescription = new Label();
            labelPlaceName = new Label();
            labelOrderStatus = new Label();
            labelDeliveryPercent = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaceMenu).BeginInit();
            SuspendLayout();
            // 
            // buttonMyProfile
            // 
            buttonShowMyProfile.FlatAppearance.BorderSize = 0;
            buttonShowMyProfile.FlatStyle = FlatStyle.Flat;
            buttonShowMyProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowMyProfile.ForeColor = Color.White;
            buttonShowMyProfile.Location = new Point(1, 1);
            buttonShowMyProfile.Name = "buttonMyProfile";
            buttonShowMyProfile.Size = new Size(75, 25);
            buttonShowMyProfile.TabIndex = 6;
            buttonShowMyProfile.Text = "My Profile";
            buttonShowMyProfile.UseVisualStyleBackColor = true;
            buttonShowMyProfile.Click += buttonMyProfile_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPrice.ForeColor = SystemColors.Control;
            labelTotalPrice.Location = new Point(12, 380);
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
            buttonAddToCart.Location = new Point(746, 504);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(234, 34);
            buttonAddToCart.TabIndex = 23;
            buttonAddToCart.Text = "Add to cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // buttonRemove
            // 
            buttonRemoveCartProduct.FlatStyle = FlatStyle.Flat;
            buttonRemoveCartProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveCartProduct.ForeColor = Color.White;
            buttonRemoveCartProduct.Location = new Point(12, 268);
            buttonRemoveCartProduct.Name = "buttonRemove";
            buttonRemoveCartProduct.Size = new Size(117, 34);
            buttonRemoveCartProduct.TabIndex = 21;
            buttonRemoveCartProduct.Text = "Remove";
            buttonRemoveCartProduct.UseVisualStyleBackColor = true;
            buttonRemoveCartProduct.Click += buttonRemove_Click;
            // 
            // labelCart
            // 
            labelCartTitle.AutoSize = true;
            labelCartTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCartTitle.ForeColor = SystemColors.Control;
            labelCartTitle.Location = new Point(12, 35);
            labelCartTitle.Name = "labelCart";
            labelCartTitle.Size = new Size(108, 30);
            labelCartTitle.TabIndex = 20;
            labelCartTitle.Text = "Your cart:";
            // 
            // listBoxCart
            // 
            listBoxCustomerCart.BackColor = Color.FromArgb(31, 31, 31);
            listBoxCustomerCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxCustomerCart.ForeColor = Color.White;
            listBoxCustomerCart.FormattingEnabled = true;
            listBoxCustomerCart.ItemHeight = 21;
            listBoxCustomerCart.Location = new Point(12, 69);
            listBoxCustomerCart.Name = "listBoxCart";
            listBoxCustomerCart.Size = new Size(234, 193);
            listBoxCustomerCart.TabIndex = 19;
            listBoxCustomerCart.SelectedValueChanged += ListBoxCart_SelectedValueChanged;
            // 
            // dataGridView1
            // 
            dataGridViewPlaceMenu.AllowUserToResizeColumns = false;
            dataGridViewPlaceMenu.AllowUserToResizeRows = false;
            dataGridViewPlaceMenu.BackgroundColor = Color.FromArgb(61, 61, 61);
            dataGridViewPlaceMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlaceMenu.Location = new Point(280, 191);
            dataGridViewPlaceMenu.Name = "dataGridView1";
            dataGridViewPlaceMenu.ReadOnly = true;
            dataGridViewPlaceMenu.RowTemplate.Height = 25;
            dataGridViewPlaceMenu.Size = new Size(700, 307);
            dataGridViewPlaceMenu.TabIndex = 17;
            dataGridViewPlaceMenu.CellClick += DataGridView1_CellClick;
            // 
            // buttonOrder
            // 
            buttonMakeOrder.FlatStyle = FlatStyle.Flat;
            buttonMakeOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMakeOrder.ForeColor = Color.White;
            buttonMakeOrder.Location = new Point(12, 504);
            buttonMakeOrder.Name = "buttonOrder";
            buttonMakeOrder.Size = new Size(234, 34);
            buttonMakeOrder.TabIndex = 26;
            buttonMakeOrder.Text = "Order";
            buttonMakeOrder.UseVisualStyleBackColor = true;
            buttonMakeOrder.Click += buttonOrder_Click;
            // 
            // buttonAdd
            // 
            buttonAddCartProduct.FlatStyle = FlatStyle.Flat;
            buttonAddCartProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCartProduct.ForeColor = Color.White;
            buttonAddCartProduct.Location = new Point(129, 268);
            buttonAddCartProduct.Name = "buttonAdd";
            buttonAddCartProduct.Size = new Size(117, 34);
            buttonAddCartProduct.TabIndex = 27;
            buttonAddCartProduct.Text = "Add";
            buttonAddCartProduct.UseVisualStyleBackColor = true;
            buttonAddCartProduct.Click += buttonAdd_Click;
            // 
            // panelSeparator1
            // 
            panelDecorativeSeparator.BackColor = Color.FromArgb(61, 61, 61);
            panelDecorativeSeparator.Location = new Point(262, 26);
            panelDecorativeSeparator.Name = "panelSeparator1";
            panelDecorativeSeparator.Size = new Size(1, 522);
            panelDecorativeSeparator.TabIndex = 28;
            // 
            // label5
            // 
            labelMenuTitle.AutoSize = true;
            labelMenuTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuTitle.ForeColor = SystemColors.Control;
            labelMenuTitle.Location = new Point(280, 157);
            labelMenuTitle.MaximumSize = new Size(400, 50);
            labelMenuTitle.Name = "label5";
            labelMenuTitle.Size = new Size(76, 30);
            labelMenuTitle.TabIndex = 30;
            labelMenuTitle.Text = "Menu:";
            // 
            // comboBoxPlaces
            // 
            comboBoxPlacesList.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxPlacesList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlacesList.FlatStyle = FlatStyle.Flat;
            comboBoxPlacesList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPlacesList.ForeColor = Color.White;
            comboBoxPlacesList.FormattingEnabled = true;
            comboBoxPlacesList.Location = new Point(746, 39);
            comboBoxPlacesList.Name = "comboBoxPlaces";
            comboBoxPlacesList.Size = new Size(234, 33);
            comboBoxPlacesList.TabIndex = 31;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelProductPrice.ForeColor = SystemColors.Control;
            labelProductPrice.Location = new Point(12, 355);
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
            labelDeliveryPrice.Location = new Point(12, 330);
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
            labelOrderStatus.Location = new Point(12, 473);
            labelOrderStatus.MaximumSize = new Size(400, 50);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(126, 25);
            labelOrderStatus.TabIndex = 55;
            labelOrderStatus.Text = "Order status:";
            labelOrderStatus.Visible = false;
            // 
            // labelDeliveryPercent
            // 
            labelDeliveryPercent.AutoSize = true;
            labelDeliveryPercent.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDeliveryPercent.ForeColor = SystemColors.Control;
            labelDeliveryPercent.Location = new Point(12, 305);
            labelDeliveryPercent.MaximumSize = new Size(400, 50);
            labelDeliveryPercent.Name = "labelDeliveryPercent";
            labelDeliveryPercent.Size = new Size(219, 25);
            labelDeliveryPercent.TabIndex = 56;
            labelDeliveryPercent.Text = "Delivery percent: 0 UAH";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(labelDeliveryPercent);
            Controls.Add(labelOrderStatus);
            Controls.Add(labelPlaceDeliveryPrice);
            Controls.Add(labelPlaceAddress);
            Controls.Add(labelPlaceDescription);
            Controls.Add(labelPlaceName);
            Controls.Add(labelProductPrice);
            Controls.Add(labelDeliveryPrice);
            Controls.Add(comboBoxPlacesList);
            Controls.Add(buttonAddToCart);
            Controls.Add(labelMenuTitle);
            Controls.Add(panelDecorativeSeparator);
            Controls.Add(buttonAddCartProduct);
            Controls.Add(buttonMakeOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonRemoveCartProduct);
            Controls.Add(labelCartTitle);
            Controls.Add(listBoxCustomerCart);
            Controls.Add(dataGridViewPlaceMenu);
            Controls.Add(buttonShowMyProfile);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            Controls.SetChildIndex(buttonShowMyProfile, 0);
            Controls.SetChildIndex(dataGridViewPlaceMenu, 0);
            Controls.SetChildIndex(listBoxCustomerCart, 0);
            Controls.SetChildIndex(labelCartTitle, 0);
            Controls.SetChildIndex(buttonRemoveCartProduct, 0);
            Controls.SetChildIndex(labelTotalPrice, 0);
            Controls.SetChildIndex(buttonMakeOrder, 0);
            Controls.SetChildIndex(buttonAddCartProduct, 0);
            Controls.SetChildIndex(panelDecorativeSeparator, 0);
            Controls.SetChildIndex(labelMenuTitle, 0);
            Controls.SetChildIndex(buttonAddToCart, 0);
            Controls.SetChildIndex(comboBoxPlacesList, 0);
            Controls.SetChildIndex(labelDeliveryPrice, 0);
            Controls.SetChildIndex(labelProductPrice, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(labelPlaceDescription, 0);
            Controls.SetChildIndex(labelPlaceAddress, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPrice, 0);
            Controls.SetChildIndex(labelOrderStatus, 0);
            Controls.SetChildIndex(labelDeliveryPercent, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaceMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panelDecorativeSeparator;
        private ListBox listBoxCustomerCart;
        private DataGridView dataGridViewPlaceMenu;
        private ComboBox comboBoxPlacesList;
        private Button buttonShowMyProfile;
        private Button buttonAddToCart;
        private Button buttonRemoveCartProduct;
        private Button buttonAddCartProduct;
        private Button buttonMakeOrder;
        private Label labelTotalPrice;
        private Label labelCartTitle;
        private Label labelMenuTitle;
        private Label labelProductPrice;
        private Label labelDeliveryPrice;
        private Label labelPlaceDeliveryPrice;
        private Label labelPlaceAddress;
        private Label labelPlaceDescription;
        private Label labelPlaceName;
        private Label labelOrderStatus;
        private Label labelDeliveryPercent;
    }
}