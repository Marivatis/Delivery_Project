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
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPlaceName = new Label();
            dataGridView1 = new DataGridView();
            panelSeparator1 = new Panel();
            labelProductName = new Label();
            textBoxLogin = new TextBox();
            buttonMyProfile = new Button();
            labelProductPrice = new Label();
            textBoxProductPrice = new TextBox();
            labelProductDescription = new Label();
            textBoxProductDescription = new TextBox();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductDescription = new DataGridViewTextBoxColumn();
            buttonChooseProduct = new Button();
            buttonRemove = new Button();
            buttonApply = new Button();
            buttonAddProduct = new Button();
            buttonAddPlace = new Button();
            buttonEditPlace = new Button();
            comboBoxPlaces = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(280, 158);
            label5.MaximumSize = new Size(400, 50);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 35;
            label5.Text = "Menu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(280, 67);
            label2.MaximumSize = new Size(500, 25);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 34;
            label2.Text = "Place address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(280, 92);
            label3.MaximumSize = new Size(700, 63);
            label3.Name = "label3";
            label3.Size = new Size(688, 42);
            label3.TabIndex = 33;
            label3.Text = "Place description Place description Place description Place description Place description Place description Place description Place description Place description ";
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, ProductPrice, ProductDescription });
            dataGridView1.Location = new Point(280, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(708, 306);
            dataGridView1.TabIndex = 31;
            // 
            // panelSeparator1
            // 
            panelSeparator1.BackColor = Color.FromArgb(61, 61, 61);
            panelSeparator1.Location = new Point(262, 26);
            panelSeparator1.Name = "panelSeparator1";
            panelSeparator1.Size = new Size(1, 522);
            panelSeparator1.TabIndex = 36;
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
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(12, 192);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(234, 33);
            textBoxLogin.TabIndex = 37;
            textBoxLogin.Text = "Enter product name";
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
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Price";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            // 
            // ProductDescription
            // 
            ProductDescription.HeaderText = "Description";
            ProductDescription.Name = "ProductDescription";
            ProductDescription.ReadOnly = true;
            // 
            // buttonChooseProduct
            // 
            buttonChooseProduct.FlatStyle = FlatStyle.Flat;
            buttonChooseProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChooseProduct.ForeColor = Color.White;
            buttonChooseProduct.Location = new Point(754, 504);
            buttonChooseProduct.Name = "buttonChooseProduct";
            buttonChooseProduct.Size = new Size(234, 34);
            buttonChooseProduct.TabIndex = 44;
            buttonChooseProduct.Text = "Choose product";
            buttonChooseProduct.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(12, 464);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 34);
            buttonRemove.TabIndex = 45;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.FlatStyle = FlatStyle.Flat;
            buttonApply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApply.ForeColor = Color.White;
            buttonApply.Location = new Point(129, 464);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(117, 34);
            buttonApply.TabIndex = 46;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.FlatStyle = FlatStyle.Flat;
            buttonAddProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.White;
            buttonAddProduct.Location = new Point(12, 504);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(234, 34);
            buttonAddProduct.TabIndex = 47;
            buttonAddProduct.Text = "Add new product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlace
            // 
            buttonAddPlace.FlatStyle = FlatStyle.Flat;
            buttonAddPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPlace.ForeColor = Color.White;
            buttonAddPlace.Location = new Point(12, 35);
            buttonAddPlace.Name = "buttonAddPlace";
            buttonAddPlace.Size = new Size(234, 34);
            buttonAddPlace.TabIndex = 48;
            buttonAddPlace.Text = "Add new place";
            buttonAddPlace.UseVisualStyleBackColor = true;
            // 
            // buttonEditPlace
            // 
            buttonEditPlace.FlatStyle = FlatStyle.Flat;
            buttonEditPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPlace.ForeColor = Color.White;
            buttonEditPlace.Location = new Point(12, 75);
            buttonEditPlace.Name = "buttonEditPlace";
            buttonEditPlace.Size = new Size(234, 34);
            buttonEditPlace.TabIndex = 49;
            buttonEditPlace.Text = "Edit place";
            buttonEditPlace.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlaces
            // 
            comboBoxPlaces.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxPlaces.FlatStyle = FlatStyle.Flat;
            comboBoxPlaces.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPlaces.ForeColor = Color.White;
            comboBoxPlaces.FormattingEnabled = true;
            comboBoxPlaces.Location = new Point(754, 38);
            comboBoxPlaces.Name = "comboBoxPlaces";
            comboBoxPlaces.Size = new Size(234, 33);
            comboBoxPlaces.TabIndex = 50;
            comboBoxPlaces.Text = "Place...";
            // 
            // FormProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(comboBoxPlaces);
            Controls.Add(buttonEditPlace);
            Controls.Add(buttonAddPlace);
            Controls.Add(buttonAddProduct);
            Controls.Add(buttonApply);
            Controls.Add(buttonRemove);
            Controls.Add(buttonChooseProduct);
            Controls.Add(labelProductDescription);
            Controls.Add(textBoxProductDescription);
            Controls.Add(labelProductPrice);
            Controls.Add(textBoxProductPrice);
            Controls.Add(buttonMyProfile);
            Controls.Add(labelProductName);
            Controls.Add(textBoxLogin);
            Controls.Add(panelSeparator1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelPlaceName);
            Controls.Add(dataGridView1);
            Name = "FormProvider";
            Text = "FormProvider";
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(panelSeparator1, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelProductName, 0);
            Controls.SetChildIndex(buttonMyProfile, 0);
            Controls.SetChildIndex(textBoxProductPrice, 0);
            Controls.SetChildIndex(labelProductPrice, 0);
            Controls.SetChildIndex(textBoxProductDescription, 0);
            Controls.SetChildIndex(labelProductDescription, 0);
            Controls.SetChildIndex(buttonChooseProduct, 0);
            Controls.SetChildIndex(buttonRemove, 0);
            Controls.SetChildIndex(buttonApply, 0);
            Controls.SetChildIndex(buttonAddProduct, 0);
            Controls.SetChildIndex(buttonAddPlace, 0);
            Controls.SetChildIndex(buttonEditPlace, 0);
            Controls.SetChildIndex(comboBoxPlaces, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private Label label3;
        private Label labelPlaceName;
        private DataGridView dataGridView1;
        private Panel panelSeparator1;
        private Label labelProductName;
        private TextBox textBoxLogin;
        private Button buttonMyProfile;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductDescription;
        private Label labelProductPrice;
        private TextBox textBoxProductPrice;
        private Label labelProductDescription;
        private TextBox textBoxProductDescription;
        private Button buttonChooseProduct;
        private Button buttonRemove;
        private Button buttonApply;
        private Button buttonAddProduct;
        private Button buttonAddPlace;
        private Button buttonEditPlace;
        private ComboBox comboBoxPlaces;
    }
}