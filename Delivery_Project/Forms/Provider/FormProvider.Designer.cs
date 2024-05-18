namespace Delivery_Project.Forms.Provider
{
    partial class FormProvider
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
            labelMenuTitle = new Label();
            labelPlaceAddress = new Label();
            labelPlaceDescription = new Label();
            labelPlaceName = new Label();
            dataGridViewPlaceMenu = new DataGridView();
            panelDecorativeSeparator = new Panel();
            labelProductName = new Label();
            textBoxProductName = new TextBox();
            buttonMyProfile = new Button();
            labelProductPrice = new Label();
            textBoxProductPrice = new TextBox();
            labelProductDescription = new Label();
            textBoxProductDescription = new TextBox();
            buttonRemoveProduct = new Button();
            buttonApplyProductChanges = new Button();
            buttonAddNewProduct = new Button();
            buttonEditPlace = new Button();
            labelPlaceDeliveryPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaceMenu).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            labelMenuTitle.AutoSize = true;
            labelMenuTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuTitle.ForeColor = SystemColors.Control;
            labelMenuTitle.Location = new Point(280, 158);
            labelMenuTitle.MaximumSize = new Size(400, 50);
            labelMenuTitle.Name = "label5";
            labelMenuTitle.Size = new Size(76, 30);
            labelMenuTitle.TabIndex = 35;
            labelMenuTitle.Text = "Menu:";
            // 
            // labelPlaceAddress
            // 
            labelPlaceAddress.AutoSize = true;
            labelPlaceAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceAddress.ForeColor = SystemColors.Control;
            labelPlaceAddress.Location = new Point(280, 91);
            labelPlaceAddress.MaximumSize = new Size(500, 25);
            labelPlaceAddress.Name = "labelPlaceAddress";
            labelPlaceAddress.Size = new Size(131, 25);
            labelPlaceAddress.TabIndex = 34;
            labelPlaceAddress.Text = "Place address";
            // 
            // labelPlaceDescription
            // 
            labelPlaceDescription.AutoSize = true;
            labelPlaceDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPlaceDescription.ForeColor = SystemColors.Control;
            labelPlaceDescription.Location = new Point(280, 116);
            labelPlaceDescription.MaximumSize = new Size(700, 42);
            labelPlaceDescription.Name = "labelPlaceDescription";
            labelPlaceDescription.Size = new Size(688, 42);
            labelPlaceDescription.TabIndex = 33;
            labelPlaceDescription.Text = "Place description Place description Place description Place description Place description Place description Place description Place description Place description ";
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = SystemColors.Control;
            labelPlaceName.Location = new Point(280, 35);
            labelPlaceName.MaximumSize = new Size(500, 32);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(144, 32);
            labelPlaceName.TabIndex = 32;
            labelPlaceName.Text = "Place name";
            // 
            // dataGridView1
            // 
            dataGridViewPlaceMenu.AllowUserToResizeColumns = false;
            dataGridViewPlaceMenu.AllowUserToResizeRows = false;
            dataGridViewPlaceMenu.BackgroundColor = Color.FromArgb(61, 61, 61);
            dataGridViewPlaceMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlaceMenu.Location = new Point(280, 192);
            dataGridViewPlaceMenu.Name = "dataGridView1";
            dataGridViewPlaceMenu.ReadOnly = true;
            dataGridViewPlaceMenu.RowTemplate.Height = 25;
            dataGridViewPlaceMenu.Size = new Size(700, 306);
            dataGridViewPlaceMenu.TabIndex = 31;
            dataGridViewPlaceMenu.CellClick += DataGridView1_CellClick;
            // 
            // panelSeparator1
            // 
            panelDecorativeSeparator.BackColor = Color.FromArgb(61, 61, 61);
            panelDecorativeSeparator.Location = new Point(262, 26);
            panelDecorativeSeparator.Name = "panelSeparator1";
            panelDecorativeSeparator.Size = new Size(1, 522);
            panelDecorativeSeparator.TabIndex = 36;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.ForeColor = Color.White;
            labelProductName.Location = new Point(12, 158);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(157, 30);
            labelProductName.TabIndex = 38;
            labelProductName.Text = "Product name:";
            // 
            // textBoxProductName
            // 
            textBoxProductName.BackColor = Color.FromArgb(61, 61, 61);
            textBoxProductName.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxProductName.ForeColor = Color.White;
            textBoxProductName.Location = new Point(12, 192);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(234, 33);
            textBoxProductName.TabIndex = 37;
            textBoxProductName.Text = "Enter product name";
            textBoxProductName.Enter += textBoxProductName_Enter;
            textBoxProductName.Leave += textBoxProductName_Leave;
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
            buttonMyProfile.TabIndex = 39;
            buttonMyProfile.Text = "My Profile";
            buttonMyProfile.UseVisualStyleBackColor = true;
            buttonMyProfile.Click += buttonMyProfile_Click;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductPrice.ForeColor = Color.White;
            labelProductPrice.Location = new Point(12, 228);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(151, 30);
            labelProductPrice.TabIndex = 41;
            labelProductPrice.Text = "Product price:";
            // 
            // textBoxProductPrice
            // 
            textBoxProductPrice.BackColor = Color.FromArgb(61, 61, 61);
            textBoxProductPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxProductPrice.ForeColor = Color.White;
            textBoxProductPrice.Location = new Point(12, 262);
            textBoxProductPrice.Name = "textBoxProductPrice";
            textBoxProductPrice.Size = new Size(234, 33);
            textBoxProductPrice.TabIndex = 40;
            textBoxProductPrice.Text = "Enter product price";
            textBoxProductPrice.Enter += textBoxProductPrice_Enter;
            textBoxProductPrice.KeyPress += textBoxProductPrice_KeyPress;
            textBoxProductPrice.Leave += textBoxProductPrice_Leave;
            // 
            // labelProductDescription
            // 
            labelProductDescription.AutoSize = true;
            labelProductDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductDescription.ForeColor = Color.White;
            labelProductDescription.Location = new Point(12, 298);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(213, 30);
            labelProductDescription.TabIndex = 43;
            labelProductDescription.Text = "Product description:";
            // 
            // textBoxProductDescription
            // 
            textBoxProductDescription.BackColor = Color.FromArgb(61, 61, 61);
            textBoxProductDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxProductDescription.ForeColor = Color.White;
            textBoxProductDescription.Location = new Point(12, 332);
            textBoxProductDescription.Name = "textBoxProductDescription";
            textBoxProductDescription.Size = new Size(234, 33);
            textBoxProductDescription.TabIndex = 42;
            textBoxProductDescription.Text = "Enter product description";
            textBoxProductDescription.Enter += textBoxProductDescription_Enter;
            textBoxProductDescription.Leave += textBoxProductDescription_Leave;
            // 
            // buttonRemove
            // 
            buttonRemoveProduct.FlatStyle = FlatStyle.Flat;
            buttonRemoveProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveProduct.ForeColor = Color.White;
            buttonRemoveProduct.Location = new Point(12, 381);
            buttonRemoveProduct.Name = "buttonRemove";
            buttonRemoveProduct.Size = new Size(117, 34);
            buttonRemoveProduct.TabIndex = 45;
            buttonRemoveProduct.Text = "Remove";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += buttonRemove_Click;
            // 
            // buttonApply
            // 
            buttonApplyProductChanges.FlatStyle = FlatStyle.Flat;
            buttonApplyProductChanges.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApplyProductChanges.ForeColor = Color.White;
            buttonApplyProductChanges.Location = new Point(129, 381);
            buttonApplyProductChanges.Name = "buttonApply";
            buttonApplyProductChanges.Size = new Size(117, 34);
            buttonApplyProductChanges.TabIndex = 46;
            buttonApplyProductChanges.Text = "Apply";
            buttonApplyProductChanges.UseVisualStyleBackColor = true;
            buttonApplyProductChanges.Click += buttonApply_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddNewProduct.FlatStyle = FlatStyle.Flat;
            buttonAddNewProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNewProduct.ForeColor = Color.White;
            buttonAddNewProduct.Location = new Point(746, 504);
            buttonAddNewProduct.Name = "buttonAddProduct";
            buttonAddNewProduct.Size = new Size(234, 34);
            buttonAddNewProduct.TabIndex = 47;
            buttonAddNewProduct.Text = "Add new product";
            buttonAddNewProduct.UseVisualStyleBackColor = true;
            buttonAddNewProduct.Click += buttonAddProduct_Click;
            // 
            // buttonEditPlace
            // 
            buttonEditPlace.FlatStyle = FlatStyle.Flat;
            buttonEditPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPlace.ForeColor = Color.White;
            buttonEditPlace.Location = new Point(746, 35);
            buttonEditPlace.Name = "buttonEditPlace";
            buttonEditPlace.Size = new Size(234, 34);
            buttonEditPlace.TabIndex = 49;
            buttonEditPlace.Text = "Edit place";
            buttonEditPlace.UseVisualStyleBackColor = true;
            buttonEditPlace.Click += buttonEditPlace_Click;
            // 
            // labelPlaceDeliveryPrice
            // 
            labelPlaceDeliveryPrice.AutoSize = true;
            labelPlaceDeliveryPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceDeliveryPrice.ForeColor = SystemColors.Control;
            labelPlaceDeliveryPrice.Location = new Point(280, 67);
            labelPlaceDeliveryPrice.MaximumSize = new Size(500, 25);
            labelPlaceDeliveryPrice.Name = "labelPlaceDeliveryPrice";
            labelPlaceDeliveryPrice.Size = new Size(183, 25);
            labelPlaceDeliveryPrice.TabIndex = 50;
            labelPlaceDeliveryPrice.Text = "Place delivery price";
            // 
            // FormProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(labelPlaceDeliveryPrice);
            Controls.Add(buttonEditPlace);
            Controls.Add(buttonAddNewProduct);
            Controls.Add(buttonApplyProductChanges);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(labelProductDescription);
            Controls.Add(textBoxProductDescription);
            Controls.Add(labelProductPrice);
            Controls.Add(textBoxProductPrice);
            Controls.Add(buttonMyProfile);
            Controls.Add(labelProductName);
            Controls.Add(textBoxProductName);
            Controls.Add(panelDecorativeSeparator);
            Controls.Add(labelMenuTitle);
            Controls.Add(labelPlaceAddress);
            Controls.Add(labelPlaceDescription);
            Controls.Add(labelPlaceName);
            Controls.Add(dataGridViewPlaceMenu);
            Name = "FormProvider";
            Text = "FormProvider";
            Load += FormProvider_Load;
            Controls.SetChildIndex(dataGridViewPlaceMenu, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(labelPlaceDescription, 0);
            Controls.SetChildIndex(labelPlaceAddress, 0);
            Controls.SetChildIndex(labelMenuTitle, 0);
            Controls.SetChildIndex(panelDecorativeSeparator, 0);
            Controls.SetChildIndex(textBoxProductName, 0);
            Controls.SetChildIndex(labelProductName, 0);
            Controls.SetChildIndex(buttonMyProfile, 0);
            Controls.SetChildIndex(textBoxProductPrice, 0);
            Controls.SetChildIndex(labelProductPrice, 0);
            Controls.SetChildIndex(textBoxProductDescription, 0);
            Controls.SetChildIndex(labelProductDescription, 0);
            Controls.SetChildIndex(buttonRemoveProduct, 0);
            Controls.SetChildIndex(buttonApplyProductChanges, 0);
            Controls.SetChildIndex(buttonAddNewProduct, 0);
            Controls.SetChildIndex(buttonEditPlace, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPrice, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaceMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panelDecorativeSeparator;
        private DataGridView dataGridViewPlaceMenu;
        private TextBox textBoxProductName;
        private TextBox textBoxProductPrice;
        private TextBox textBoxProductDescription;
        private Button buttonMyProfile;
        private Button buttonEditPlace;
        private Button buttonRemoveProduct;
        private Button buttonApplyProductChanges;
        private Button buttonAddNewProduct;
        private Label labelMenuTitle;
        private Label labelPlaceAddress;
        private Label labelPlaceDescription;
        private Label labelPlaceName;
        private Label labelProductName;
        private Label labelProductPrice;
        private Label labelProductDescription;
        private Label labelPlaceDeliveryPrice;
    }
}