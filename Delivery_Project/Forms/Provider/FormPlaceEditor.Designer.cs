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
            textBoxPlacename = new TextBox();
            labelProductName = new Label();
            textBoxLogin = new TextBox();
            label1 = new Label();
            labelRegistration = new Label();
            buttonSaveChanges = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(61, 61, 61);
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 280);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 63);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // labelPlaceName
            // 
            labelPlaceName.AutoSize = true;
            labelPlaceName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaceName.ForeColor = Color.White;
            labelPlaceName.Location = new Point(12, 98);
            labelPlaceName.Name = "labelPlaceName";
            labelPlaceName.Size = new Size(151, 32);
            labelPlaceName.TabIndex = 40;
            labelPlaceName.Text = "Place name:";
            // 
            // textBoxPlacename
            // 
            textBoxPlacename.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPlacename.BorderStyle = BorderStyle.FixedSingle;
            textBoxPlacename.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPlacename.ForeColor = Color.White;
            textBoxPlacename.Location = new Point(12, 134);
            textBoxPlacename.Name = "textBoxPlacename";
            textBoxPlacename.Size = new Size(430, 39);
            textBoxPlacename.TabIndex = 39;
            textBoxPlacename.Text = "Enter place name";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.ForeColor = Color.White;
            labelProductName.Location = new Point(12, 176);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(150, 30);
            labelProductName.TabIndex = 42;
            labelProductName.Text = "Place address:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(12, 210);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(430, 33);
            textBoxLogin.TabIndex = 41;
            textBoxLogin.Text = "Enter place address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 246);
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
            buttonSaveChanges.Location = new Point(12, 365);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(250, 40);
            buttonSaveChanges.TabIndex = 46;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(462, 365);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(250, 40);
            buttonDelete.TabIndex = 47;
            buttonDelete.Text = "Delete place";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormPlaceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 420);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelRegistration);
            Controls.Add(label1);
            Controls.Add(labelProductName);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPlaceName);
            Controls.Add(textBoxPlacename);
            Controls.Add(richTextBox1);
            Name = "FormPlaceEditor";
            Text = "FormPlaceEditor";
            Load += FormPlaceEditor_Load;
            Controls.SetChildIndex(richTextBox1, 0);
            Controls.SetChildIndex(textBoxPlacename, 0);
            Controls.SetChildIndex(labelPlaceName, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelProductName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(labelRegistration, 0);
            Controls.SetChildIndex(buttonSaveChanges, 0);
            Controls.SetChildIndex(buttonDelete, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label labelPlaceName;
        private TextBox textBoxPlacename;
        private Label labelProductName;
        private TextBox textBoxLogin;
        private Label label1;
        private Label labelRegistration;
        private Button buttonSaveChanges;
        private Button buttonDelete;
    }
}