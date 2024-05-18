namespace Delivery_Project.Forms.Customer
{
    partial class FormOrderConfirmation
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
            labelCart = new Label();
            listBoxCart = new ListBox();
            labelOrderDetails = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            buttonOrder = new Button();
            labelTotalPrice = new Label();
            SuspendLayout();
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCart.ForeColor = SystemColors.Control;
            labelCart.Location = new Point(40, 244);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(108, 30);
            labelCart.TabIndex = 22;
            labelCart.Text = "Your cart:";
            // 
            // listBoxCart
            // 
            listBoxCart.BackColor = Color.FromArgb(31, 31, 31);
            listBoxCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxCart.ForeColor = Color.White;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 21;
            listBoxCart.Location = new Point(40, 278);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(250, 130);
            listBoxCart.TabIndex = 21;
            // 
            // labelOrderDetails
            // 
            labelOrderDetails.AutoSize = true;
            labelOrderDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderDetails.ForeColor = Color.White;
            labelOrderDetails.Location = new Point(73, 35);
            labelOrderDetails.Name = "labelOrderDetails";
            labelOrderDetails.Size = new Size(184, 37);
            labelOrderDetails.TabIndex = 23;
            labelOrderDetails.Text = "Order details";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(61, 61, 61);
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxAddress.ForeColor = Color.White;
            textBoxAddress.Location = new Point(40, 198);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 33);
            textBoxAddress.TabIndex = 39;
            textBoxAddress.Text = "Enter your address";
            textBoxAddress.Enter += textBoxAddress_Enter;
            textBoxAddress.Leave += textBoxAddress_Leave;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.ForeColor = Color.White;
            labelAddress.Location = new Point(40, 165);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 30);
            labelAddress.TabIndex = 38;
            labelAddress.Text = "Address:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(40, 95);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 30);
            labelPhoneNumber.TabIndex = 37;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = Color.White;
            textBoxPhoneNumber.Location = new Point(40, 129);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 36;
            textBoxPhoneNumber.Text = "Enter your phone number";
            textBoxPhoneNumber.Enter += textBoxPhoneNumber_Enter;
            textBoxPhoneNumber.Leave += textBoxPhoneNumber_Leave;
            // 
            // buttonOrder
            // 
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrder.ForeColor = Color.White;
            buttonOrder.Location = new Point(40, 488);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(250, 34);
            buttonOrder.TabIndex = 40;
            buttonOrder.Text = "Order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPrice.ForeColor = SystemColors.Control;
            labelTotalPrice.Location = new Point(40, 411);
            labelTotalPrice.MaximumSize = new Size(400, 50);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(165, 25);
            labelTotalPrice.TabIndex = 41;
            labelTotalPrice.Text = "Total price: 150@";
            // 
            // FormOrderConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 550);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonOrder);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelOrderDetails);
            Controls.Add(labelCart);
            Controls.Add(listBoxCart);
            Name = "FormOrderConfirmation";
            Text = "FormOrderConfirmation";
            Load += FormOrderConfirmation_Load;
            Controls.SetChildIndex(listBoxCart, 0);
            Controls.SetChildIndex(labelCart, 0);
            Controls.SetChildIndex(labelOrderDetails, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(labelAddress, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(buttonOrder, 0);
            Controls.SetChildIndex(labelTotalPrice, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private ListBox listBoxCart;
        private Button buttonOrder;
        private Label labelCart;
        private Label labelOrderDetails;
        private Label labelAddress;
        private Label labelPhoneNumber;
        private Label labelTotalPrice;
    }
}