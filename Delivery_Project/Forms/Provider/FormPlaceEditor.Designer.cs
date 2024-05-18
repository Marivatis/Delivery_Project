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
            richTextBoxPlaceDescription = new RichTextBox();
            labelPlaceName = new Label();
            textBoxPlaceName = new TextBox();
            labelProductName = new Label();
            textBoxPlaceAddress = new TextBox();
            labelPlaceDescription = new Label();
            labelFormTitle = new Label();
            buttonSaveChanges = new Button();
            labelPlaceDeliveryPrice = new Label();
            textBoxPlaceDeliveryPrice = new TextBox();
            labelPlaceDeliveryPercent = new Label();
            textBoxPlaceDeliveryPercent = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBoxPlaceDescription.BackColor = Color.FromArgb(61, 61, 61);
            richTextBoxPlaceDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxPlaceDescription.ForeColor = Color.White;
            richTextBoxPlaceDescription.Location = new Point(11, 422);
            richTextBoxPlaceDescription.Name = "richTextBox1";
            richTextBoxPlaceDescription.Size = new Size(700, 63);
            richTextBoxPlaceDescription.TabIndex = 6;
            richTextBoxPlaceDescription.Text = "Enter place description";
            richTextBoxPlaceDescription.Enter += richTextBox1_Enter;
            richTextBoxPlaceDescription.Leave += richTextBox1_Leave;
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = Color.White;
            labelPlaceName.Location = new Point(11, 94);
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
            labelProductName.Location = new Point(11, 316);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(150, 30);
            labelProductName.TabIndex = 42;
            labelProductName.Text = "Place address:";
            // 
            // textBoxAddress
            // 
            textBoxPlaceAddress.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPlaceAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxPlaceAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPlaceAddress.ForeColor = Color.White;
            textBoxPlaceAddress.Location = new Point(11, 351);
            textBoxPlaceAddress.Name = "textBoxAddress";
            textBoxPlaceAddress.Size = new Size(430, 33);
            textBoxPlaceAddress.TabIndex = 41;
            textBoxPlaceAddress.Text = "Enter place address";
            textBoxPlaceAddress.Enter += textBoxAddress_Enter;
            textBoxPlaceAddress.Leave += textBoxAddress_Leave;
            // 
            // label1
            // 
            labelPlaceDescription.AutoSize = true;
            labelPlaceDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceDescription.ForeColor = Color.White;
            labelPlaceDescription.Location = new Point(11, 387);
            labelPlaceDescription.Name = "label1";
            labelPlaceDescription.Size = new Size(186, 30);
            labelPlaceDescription.TabIndex = 43;
            labelPlaceDescription.Text = "Place description:";
            // 
            // labelRegistration
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormTitle.ForeColor = Color.White;
            labelFormTitle.Location = new Point(190, 29);
            labelFormTitle.Name = "labelRegistration";
            labelFormTitle.Size = new Size(344, 37);
            labelFormTitle.TabIndex = 45;
            labelFormTitle.Text = "Editing place information";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveChanges.ForeColor = Color.White;
            buttonSaveChanges.Location = new Point(461, 507);
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
            labelPlaceDeliveryPrice.Location = new Point(11, 245);
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
            textBoxPlaceDeliveryPrice.Location = new Point(11, 280);
            textBoxPlaceDeliveryPrice.Name = "textBoxPlaceDeliveryPrice";
            textBoxPlaceDeliveryPrice.Size = new Size(430, 33);
            textBoxPlaceDeliveryPrice.TabIndex = 47;
            textBoxPlaceDeliveryPrice.Text = "Enter place delivery price";
            textBoxPlaceDeliveryPrice.Enter += textBoxPlaceDeliveryPrice_Enter;
            textBoxPlaceDeliveryPrice.KeyPress += textBoxPlaceDeliveryPrice_KeyPress;
            textBoxPlaceDeliveryPrice.Leave += textBoxPlaceDeliveryPrice_Leave;
            // 
            // labelPlaceDeliveryPercent
            // 
            labelPlaceDeliveryPercent.AutoSize = true;
            labelPlaceDeliveryPercent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceDeliveryPercent.ForeColor = Color.White;
            labelPlaceDeliveryPercent.Location = new Point(12, 174);
            labelPlaceDeliveryPercent.Name = "labelPlaceDeliveryPercent";
            labelPlaceDeliveryPercent.Size = new Size(234, 30);
            labelPlaceDeliveryPercent.TabIndex = 50;
            labelPlaceDeliveryPercent.Text = "Place delivery percent:";
            // 
            // textBoxPlaceDeliveryPercent
            // 
            textBoxPlaceDeliveryPercent.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPlaceDeliveryPercent.BorderStyle = BorderStyle.FixedSingle;
            textBoxPlaceDeliveryPercent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPlaceDeliveryPercent.ForeColor = Color.White;
            textBoxPlaceDeliveryPercent.Location = new Point(12, 209);
            textBoxPlaceDeliveryPercent.Name = "textBoxPlaceDeliveryPercent";
            textBoxPlaceDeliveryPercent.Size = new Size(430, 33);
            textBoxPlaceDeliveryPercent.TabIndex = 49;
            textBoxPlaceDeliveryPercent.Text = "Enter place delivery percent";
            textBoxPlaceDeliveryPercent.Enter += textBoxPlaceDeliveryPercent_Enter;
            textBoxPlaceDeliveryPercent.KeyPress += textBoxPlaceDeliveryPercent_KeyPress;
            textBoxPlaceDeliveryPercent.Leave += textBoxPlaceDeliveryPercent_Leave;
            // 
            // FormPlaceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 559);
            Controls.Add(labelPlaceDeliveryPercent);
            Controls.Add(textBoxPlaceDeliveryPercent);
            Controls.Add(labelPlaceDeliveryPrice);
            Controls.Add(textBoxPlaceDeliveryPrice);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelFormTitle);
            Controls.Add(labelPlaceDescription);
            Controls.Add(labelProductName);
            Controls.Add(textBoxPlaceAddress);
            Controls.Add(labelPlaceName);
            Controls.Add(textBoxPlaceName);
            Controls.Add(richTextBoxPlaceDescription);
            Name = "FormPlaceEditor";
            Text = "FormPlaceEditor";
            Load += FormPlaceEditor_Load;
            Controls.SetChildIndex(richTextBoxPlaceDescription, 0);
            Controls.SetChildIndex(textBoxPlaceName, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(textBoxPlaceAddress, 0);
            Controls.SetChildIndex(labelProductName, 0);
            Controls.SetChildIndex(labelPlaceDescription, 0);
            Controls.SetChildIndex(labelFormTitle, 0);
            Controls.SetChildIndex(buttonSaveChanges, 0);
            Controls.SetChildIndex(textBoxPlaceDeliveryPrice, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPrice, 0);
            Controls.SetChildIndex(textBoxPlaceDeliveryPercent, 0);
            Controls.SetChildIndex(labelPlaceDeliveryPercent, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxPlaceDescription;
        private TextBox textBoxPlaceName;
        private TextBox textBoxPlaceDeliveryPrice;
        private TextBox textBoxPlaceDeliveryPercent;
        private TextBox textBoxPlaceAddress;
        private Button buttonSaveChanges;
        private Label labelFormTitle;
        private Label labelPlaceName;
        private Label labelProductName;
        private Label labelPlaceDescription;
        private Label labelPlaceDeliveryPrice;
        private Label labelPlaceDeliveryPercent;
    }
}