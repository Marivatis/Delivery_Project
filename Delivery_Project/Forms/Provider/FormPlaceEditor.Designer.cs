namespace Delivery_Project.Forms.Provider
{
    partial class FormPlaceEditor
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
            richTextBox1 = new RichTextBox();
            labelPlaceName = new Label();
            textBoxPlaceName = new TextBox();
            labelProductName = new Label();
            textBoxAddress = new TextBox();
            label1 = new Label();
            labelRegistration = new Label();
            buttonSaveChanges = new Button();
            labelPlaceDeliveryPrice = new Label();
            textBoxPlaceDeliveryPrice = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(61, 61, 61);
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(11, 351);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 63);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Enter place description";
            richTextBox1.Enter += richTextBox1_Enter;
            richTextBox1.Leave += richTextBox1_Leave;
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = Color.White;
            labelPlaceName.Location = new Point(11, 95);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(151, 32);
            labelPlaceName.TabIndex = 40;
            labelPlaceName.Text = "Place name:";
            // 
            // textBoxPlaceName
            // 
            textBoxPlaceName.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPlaceName.BorderStyle = BorderStyle.FixedSingle;
            textBoxPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPlaceName.ForeColor = Color.White;
            textBoxPlaceName.Location = new Point(11, 132);
            textBoxPlaceName.Name = "textBoxPlaceName";
            textBoxPlaceName.Size = new Size(430, 39);
            textBoxPlaceName.TabIndex = 39;
            textBoxPlaceName.Text = "Enter place name";
            textBoxPlaceName.Enter += textBoxPlaceName_Enter;
            textBoxPlaceName.Leave += textBoxPlaceName_Leave;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.ForeColor = Color.White;
            labelProductName.Location = new Point(11, 245);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(150, 30);
            labelProductName.TabIndex = 42;
            labelProductName.Text = "Place address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(61, 61, 61);
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAddress.ForeColor = Color.White;
            textBoxAddress.Location = new Point(11, 280);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(430, 33);
            textBoxAddress.TabIndex = 41;
            textBoxAddress.Text = "Enter place address";
            textBoxAddress.Enter += textBoxAddress_Enter;
            textBoxAddress.Leave += textBoxAddress_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 316);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 43;
            label1.Text = "Place description:";
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistration.ForeColor = Color.White;
            labelRegistration.Location = new Point(190, 29);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(344, 37);
            labelRegistration.TabIndex = 45;
            labelRegistration.Text = "Editing place information";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveChanges.ForeColor = Color.White;
            buttonSaveChanges.Location = new Point(461, 439);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(250, 40);
            buttonSaveChanges.TabIndex = 46;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // labelPlaceDeliveryPrice
            // 
            labelPlaceDeliveryPrice.AutoSize = true;
            labelPlaceDeliveryPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceDeliveryPrice.ForeColor = Color.White;
            labelPlaceDeliveryPrice.Location = new Point(11, 174);
            labelPlaceDeliveryPrice.Name = "labelPlaceDeliveryPrice";
            labelPlaceDeliveryPrice.Size = new Size(208, 30);
            labelPlaceDeliveryPrice.TabIndex = 48;
            labelPlaceDeliveryPrice.Text = "Place delivery price:";
            // 
            // textBoxPlaceDeliveryPrice
            // 
            textBoxPlaceDeliveryPrice.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPlaceDeliveryPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPlaceDeliveryPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPlaceDeliveryPrice.ForeColor = Color.White;
            textBoxPlaceDeliveryPrice.Location = new Point(11, 209);
            textBoxPlaceDeliveryPrice.Name = "textBoxPlaceDeliveryPrice";
            textBoxPlaceDeliveryPrice.Size = new Size(430, 33);
            textBoxPlaceDeliveryPrice.TabIndex = 47;
            textBoxPlaceDeliveryPrice.Text = "Enter place delivery price";
            textBoxPlaceDeliveryPrice.Enter += textBoxPlaceDeliveryPrice_Enter;
            textBoxPlaceDeliveryPrice.Leave += textBoxPlaceDeliveryPrice_Leave;
            textBoxPlaceDeliveryPrice.KeyPress += textBoxPlaceDeliveryPrice_KeyPress;
            // 
            // FormPlaceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 492);
            Controls.Add(labelPlaceDeliveryPrice);
            Controls.Add(textBoxPlaceDeliveryPrice);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelRegistration);
            Controls.Add(label1);
            Controls.Add(labelProductName);
            Controls.Add(textBoxAddress);
            Controls.Add(labelPlaceName);
            Controls.Add(textBoxPlaceName);
            Controls.Add(richTextBox1);
            Name = "FormPlaceEditor";
            Text = "FormPlaceEditor";
            Load += FormPlaceEditor_Load;
            Controls.SetChildIndex(richTextBox1, 0);
            Controls.SetChildIndex(textBoxPlaceName, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(labelProductName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(labelRegistration, 0);
            Controls.SetChildIndex(buttonSaveChanges, 0);
            Controls.SetChildIndex(textBoxPlaceDeliveryPrice, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPrice, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label labelPlaceName;
        private TextBox textBoxPlaceName;
        private Label labelProductName;
        private TextBox textBoxAddress;
        private Label label1;
        private Label labelRegistration;
        private Button buttonSaveChanges;
        private Label labelPlaceDeliveryPrice;
        private TextBox textBoxPlaceDeliveryPrice;
    }
}