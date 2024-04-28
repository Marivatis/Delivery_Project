namespace Delivery_Project.Forms.Provider
{
    partial class FormProviderRegistration
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
            labelSecretWord = new Label();
            textBoxSecretWord = new TextBox();
            labelPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            buttonRegister = new Button();
            labelRegistration = new Label();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelSecretWord
            // 
            labelSecretWord.AutoSize = true;
            labelSecretWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSecretWord.ForeColor = Color.White;
            labelSecretWord.Location = new Point(38, 264);
            labelSecretWord.Name = "labelSecretWord";
            labelSecretWord.Size = new Size(136, 30);
            labelSecretWord.TabIndex = 49;
            labelSecretWord.Text = "Secret word:";
            // 
            // textBoxSecretWord
            // 
            textBoxSecretWord.BackColor = Color.FromArgb(61, 61, 61);
            textBoxSecretWord.BorderStyle = BorderStyle.FixedSingle;
            textBoxSecretWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxSecretWord.ForeColor = Color.White;
            textBoxSecretWord.Location = new Point(38, 299);
            textBoxSecretWord.Name = "textBoxSecretWord";
            textBoxSecretWord.Size = new Size(250, 33);
            textBoxSecretWord.TabIndex = 48;
            textBoxSecretWord.Text = "Enter secret word";
            textBoxSecretWord.Enter += textBoxSecretWord_Enter;
            textBoxSecretWord.Leave += textBoxSecretWord_Leave;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(38, 193);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 30);
            labelPhoneNumber.TabIndex = 47;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = Color.White;
            textBoxPhoneNumber.Location = new Point(38, 228);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 46;
            textBoxPhoneNumber.Text = "Enter your phone number";
            textBoxPhoneNumber.Enter += textBoxPhoneNumber_Enter;
            textBoxPhoneNumber.Leave += textBoxPhoneNumber_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(38, 388);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 40);
            buttonRegister.TabIndex = 45;
            buttonRegister.Text = "Become a provider";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistration.ForeColor = Color.White;
            labelRegistration.Location = new Point(76, 35);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(175, 37);
            labelRegistration.TabIndex = 44;
            labelRegistration.Text = "Registration";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.White;
            labelMessage.Location = new Point(38, 127);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(97, 21);
            labelMessage.TabIndex = 50;
            labelMessage.Text = "No message";
            labelMessage.Visible = false;
            // 
            // FormProviderRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 440);
            Controls.Add(labelMessage);
            Controls.Add(labelSecretWord);
            Controls.Add(textBoxSecretWord);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(buttonRegister);
            Controls.Add(labelRegistration);
            Name = "FormProviderRegistration";
            Text = "FormProviderRegistration";
            Load += FormProviderRegistration_Load;
            Controls.SetChildIndex(labelRegistration, 0);
            Controls.SetChildIndex(buttonRegister, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(textBoxSecretWord, 0);
            Controls.SetChildIndex(labelSecretWord, 0);
            Controls.SetChildIndex(labelMessage, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecretWord;
        private TextBox textBoxSecretWord;
        private Label labelPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Button buttonRegister;
        private Label labelRegistration;
        private Label labelMessage;
    }
}