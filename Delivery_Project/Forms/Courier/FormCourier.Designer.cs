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
            panelSeparator1 = new Panel();
            buttonTakeOrder = new Button();
            labelOrderDetails = new Label();
            listBoxOrderDetails = new ListBox();
            labelAvailableOrders = new Label();
            dataGridView1 = new DataGridView();
            Earning = new DataGridViewTextBoxColumn();
            DeliveryTime = new DataGridViewTextBoxColumn();
            DestinationAdress = new DataGridViewTextBoxColumn();
            buttonOrderDetails = new Button();
            labelTotalWeight = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSeparator1
            // 
            panelSeparator1.BackColor = Color.FromArgb(61, 61, 61);
            panelSeparator1.Location = new Point(261, 27);
            panelSeparator1.Name = "panelSeparator1";
            panelSeparator1.Size = new Size(1, 422);
            panelSeparator1.TabIndex = 32;
            // 
            // buttonTakeOrder
            // 
            buttonTakeOrder.FlatStyle = FlatStyle.Flat;
            buttonTakeOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTakeOrder.ForeColor = Color.White;
            buttonTakeOrder.Location = new Point(12, 404);
            buttonTakeOrder.Name = "buttonTakeOrder";
            buttonTakeOrder.Size = new Size(234, 34);
            buttonTakeOrder.TabIndex = 31;
            buttonTakeOrder.Text = "Take order";
            buttonTakeOrder.UseVisualStyleBackColor = true;
            // 
            // labelOrderDetails
            // 
            labelOrderDetails.AutoSize = true;
            labelOrderDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderDetails.ForeColor = SystemColors.Control;
            labelOrderDetails.Location = new Point(12, 33);
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
            listBoxOrderDetails.Size = new Size(234, 193);
            listBoxOrderDetails.TabIndex = 29;
            // 
            // labelAvailableOrders
            // 
            labelAvailableOrders.AutoSize = true;
            labelAvailableOrders.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvailableOrders.ForeColor = SystemColors.Control;
            labelAvailableOrders.Location = new Point(268, 33);
            labelAvailableOrders.Name = "labelAvailableOrders";
            labelAvailableOrders.Size = new Size(177, 30);
            labelAvailableOrders.TabIndex = 33;
            labelAvailableOrders.Text = "Available orders:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Earning, DeliveryTime, DestinationAdress });
            dataGridView1.Location = new Point(268, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 332);
            dataGridView1.TabIndex = 34;
            // 
            // Earning
            // 
            Earning.HeaderText = "Earning";
            Earning.Name = "Earning";
            Earning.ReadOnly = true;
            // 
            // DeliveryTime
            // 
            DeliveryTime.HeaderText = "Delivery time";
            DeliveryTime.Name = "DeliveryTime";
            DeliveryTime.ReadOnly = true;
            // 
            // DestinationAdress
            // 
            DestinationAdress.HeaderText = "Destination adress";
            DestinationAdress.Name = "DestinationAdress";
            DestinationAdress.ReadOnly = true;
            // 
            // buttonOrderDetails
            // 
            buttonOrderDetails.FlatStyle = FlatStyle.Flat;
            buttonOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrderDetails.ForeColor = Color.White;
            buttonOrderDetails.Location = new Point(554, 404);
            buttonOrderDetails.Name = "buttonOrderDetails";
            buttonOrderDetails.Size = new Size(234, 34);
            buttonOrderDetails.TabIndex = 35;
            buttonOrderDetails.Text = "Order details";
            buttonOrderDetails.UseVisualStyleBackColor = true;
            // 
            // labelTotalWeight
            // 
            labelTotalWeight.AutoSize = true;
            labelTotalWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalWeight.ForeColor = SystemColors.Control;
            labelTotalWeight.Location = new Point(12, 262);
            labelTotalWeight.Name = "labelTotalWeight";
            labelTotalWeight.Size = new Size(159, 25);
            labelTotalWeight.TabIndex = 36;
            labelTotalWeight.Text = "Total weight: 2@";
            // 
            // FormCourier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotalWeight);
            Controls.Add(buttonOrderDetails);
            Controls.Add(dataGridView1);
            Controls.Add(labelAvailableOrders);
            Controls.Add(panelSeparator1);
            Controls.Add(buttonTakeOrder);
            Controls.Add(labelOrderDetails);
            Controls.Add(listBoxOrderDetails);
            Name = "FormCourier";
            Text = "FormCourierMain";
            Controls.SetChildIndex(listBoxOrderDetails, 0);
            Controls.SetChildIndex(labelOrderDetails, 0);
            Controls.SetChildIndex(buttonTakeOrder, 0);
            Controls.SetChildIndex(panelSeparator1, 0);
            Controls.SetChildIndex(labelAvailableOrders, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(buttonOrderDetails, 0);
            Controls.SetChildIndex(labelTotalWeight, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSeparator1;
        private Button buttonTakeOrder;
        private Label labelOrderDetails;
        private ListBox listBoxOrderDetails;
        private Label labelAvailableOrders;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Earning;
        private DataGridViewTextBoxColumn DeliveryTime;
        private DataGridViewTextBoxColumn DestinationAdress;
        private Button buttonOrderDetails;
        private Label labelTotalWeight;
    }
}