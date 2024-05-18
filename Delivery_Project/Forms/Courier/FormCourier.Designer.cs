namespace Delivery_Project.Forms.Courier
{
    partial class FormCourier
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
            panelDecorativeSeparator = new Panel();
            buttonTakeOrder = new Button();
            labelOrderDetails = new Label();
            listBoxOrderDetails = new ListBox();
            labelAvailableOrders = new Label();
            dataGridView1 = new DataGridView();
            Earning = new DataGridViewTextBoxColumn();
            DestinationAddress = new DataGridViewTextBoxColumn();
            ProviderAdress = new DataGridViewTextBoxColumn();
            buttonMyProfile = new Button();
            buttonRefresh = new Button();
            labelDeliveryStatus = new Label();
            labelCustomerLogin = new Label();
            labelCustomerPhone = new Label();
            labelPlaceName = new Label();
            labelTotalEarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSeparator1
            // 
            panelDecorativeSeparator.BackColor = Color.FromArgb(61, 61, 61);
            panelDecorativeSeparator.Location = new Point(328, 27);
            panelDecorativeSeparator.Name = "panelSeparator1";
            panelDecorativeSeparator.Size = new Size(1, 522);
            panelDecorativeSeparator.TabIndex = 32;
            // 
            // buttonTakeOrder
            // 
            buttonTakeOrder.FlatStyle = FlatStyle.Flat;
            buttonTakeOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTakeOrder.ForeColor = Color.White;
            buttonTakeOrder.Location = new Point(12, 504);
            buttonTakeOrder.Name = "buttonTakeOrder";
            buttonTakeOrder.Size = new Size(301, 34);
            buttonTakeOrder.TabIndex = 31;
            buttonTakeOrder.Text = "Take order";
            buttonTakeOrder.UseVisualStyleBackColor = true;
            buttonTakeOrder.Click += buttonTakeOrder_Click;
            // 
            // labelOrderDetails
            // 
            labelOrderDetails.AutoSize = true;
            labelOrderDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderDetails.ForeColor = SystemColors.Control;
            labelOrderDetails.Location = new Point(12, 32);
            labelOrderDetails.Name = "labelOrderDetails";
            labelOrderDetails.Size = new Size(145, 30);
            labelOrderDetails.TabIndex = 30;
            labelOrderDetails.Text = "Order details:";
            // 
            // listBoxOrderDetails
            // 
            listBoxOrderDetails.BackColor = Color.FromArgb(31, 31, 31);
            listBoxOrderDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxOrderDetails.ForeColor = Color.White;
            listBoxOrderDetails.FormattingEnabled = true;
            listBoxOrderDetails.ItemHeight = 21;
            listBoxOrderDetails.Location = new Point(12, 66);
            listBoxOrderDetails.Name = "listBoxOrderDetails";
            listBoxOrderDetails.Size = new Size(301, 193);
            listBoxOrderDetails.TabIndex = 29;
            // 
            // labelAvailableOrders
            // 
            labelAvailableOrders.AutoSize = true;
            labelAvailableOrders.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvailableOrders.ForeColor = SystemColors.Control;
            labelAvailableOrders.Location = new Point(333, 32);
            labelAvailableOrders.Name = "labelAvailableOrders";
            labelAvailableOrders.Size = new Size(177, 30);
            labelAvailableOrders.TabIndex = 33;
            labelAvailableOrders.Text = "Available orders:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(61, 61, 61);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Earning, DestinationAddress, ProviderAdress });
            dataGridView1.Location = new Point(333, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 432);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // Earning
            // 
            Earning.HeaderText = "Earning";
            Earning.Name = "Earning";
            Earning.ReadOnly = true;
            Earning.Width = 140;
            // 
            // DestinationAddress
            // 
            DestinationAddress.HeaderText = "Destination address";
            DestinationAddress.Name = "DestinationAddress";
            DestinationAddress.ReadOnly = true;
            DestinationAddress.Width = 235;
            // 
            // ProviderAdress
            // 
            ProviderAdress.HeaderText = "Provider address";
            ProviderAdress.Name = "ProviderAdress";
            ProviderAdress.ReadOnly = true;
            ProviderAdress.Width = 235;
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
            buttonMyProfile.TabIndex = 37;
            buttonMyProfile.Text = "My Profile";
            buttonMyProfile.UseVisualStyleBackColor = true;
            buttonMyProfile.Click += buttonMyProfile_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(812, 504);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(174, 34);
            buttonRefresh.TabIndex = 39;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelDeliveryStatus
            // 
            labelDeliveryStatus.AutoSize = true;
            labelDeliveryStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeliveryStatus.ForeColor = SystemColors.Control;
            labelDeliveryStatus.Location = new Point(12, 473);
            labelDeliveryStatus.Name = "labelDeliveryStatus";
            labelDeliveryStatus.Size = new Size(152, 25);
            labelDeliveryStatus.TabIndex = 40;
            labelDeliveryStatus.Text = "Delivery status: ";
            labelDeliveryStatus.Visible = false;
            // 
            // labelCustomerLogin
            // 
            labelCustomerLogin.AutoSize = true;
            labelCustomerLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerLogin.ForeColor = SystemColors.Control;
            labelCustomerLogin.Location = new Point(12, 299);
            labelCustomerLogin.Name = "labelCustomerLogin";
            labelCustomerLogin.Size = new Size(154, 25);
            labelCustomerLogin.TabIndex = 41;
            labelCustomerLogin.Text = "Customer login:";
            labelCustomerLogin.Visible = false;
            // 
            // labelCustomerPhone
            // 
            labelCustomerPhone.AutoSize = true;
            labelCustomerPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerPhone.ForeColor = SystemColors.Control;
            labelCustomerPhone.Location = new Point(12, 324);
            labelCustomerPhone.Name = "labelCustomerPhone";
            labelCustomerPhone.Size = new Size(165, 25);
            labelCustomerPhone.TabIndex = 42;
            labelCustomerPhone.Text = "Customer phone:";
            labelCustomerPhone.Visible = false;
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = SystemColors.Control;
            labelPlaceName.Location = new Point(12, 262);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(117, 25);
            labelPlaceName.TabIndex = 43;
            labelPlaceName.Text = "Place name:";
            labelPlaceName.Visible = false;
            // 
            // labelTotalEarning
            // 
            labelTotalEarning.AutoSize = true;
            labelTotalEarning.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalEarning.ForeColor = SystemColors.Control;
            labelTotalEarning.Location = new Point(12, 363);
            labelTotalEarning.Name = "labelTotalEarning";
            labelTotalEarning.Size = new Size(134, 25);
            labelTotalEarning.TabIndex = 44;
            labelTotalEarning.Text = "Total earning:";
            labelTotalEarning.Visible = false;
            // 
            // FormCourier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(labelTotalEarning);
            Controls.Add(labelPlaceName);
            Controls.Add(labelCustomerPhone);
            Controls.Add(labelCustomerLogin);
            Controls.Add(labelDeliveryStatus);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonMyProfile);
            Controls.Add(dataGridView1);
            Controls.Add(labelAvailableOrders);
            Controls.Add(panelDecorativeSeparator);
            Controls.Add(buttonTakeOrder);
            Controls.Add(labelOrderDetails);
            Controls.Add(listBoxOrderDetails);
            Name = "FormCourier";
            Text = "FormCourierMain";
            Load += FormCourier_Load;
            Controls.SetChildIndex(listBoxOrderDetails, 0);
            Controls.SetChildIndex(labelOrderDetails, 0);
            Controls.SetChildIndex(buttonTakeOrder, 0);
            Controls.SetChildIndex(panelDecorativeSeparator, 0);
            Controls.SetChildIndex(labelAvailableOrders, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(buttonMyProfile, 0);
            Controls.SetChildIndex(buttonRefresh, 0);
            Controls.SetChildIndex(labelDeliveryStatus, 0);
            Controls.SetChildIndex(labelCustomerLogin, 0);
            Controls.SetChildIndex(labelCustomerPhone, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(labelTotalEarning, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDecorativeSeparator;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Earning;
        private DataGridViewTextBoxColumn DestinationAddress;
        private DataGridViewTextBoxColumn ProviderAdress;
        private ListBox listBoxOrderDetails;
        private Button buttonTakeOrder;
        private Button buttonMyProfile;
        private Button buttonRefresh;
        private Label labelOrderDetails;
        private Label labelAvailableOrders;
        private Label labelDeliveryStatus;
        private Label labelCustomerLogin;
        private Label labelCustomerPhone;
        private Label labelPlaceName;
        private Label labelTotalEarning;
    }
}