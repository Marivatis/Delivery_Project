namespace Delivery_Project.Forms.Entry
{
    partial class FormRegistration
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
            buttonRegister = new Button();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelTitle = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelRepeatPassword = new Label();
            textBoxRepeatPassword = new TextBox();
            labelInformingMessage = new Label();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(40, 373);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 40);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(40, 137);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 13;
            labelLogin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(40, 171);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Text = "Enter your login";
            textBoxLogin.Enter += textBoxLogin_Enter;
            textBoxLogin.Leave += textBoxLogin_Leave;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(78, 35);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 37);
            labelTitle.TabIndex = 17;
            labelTitle.Text = "Registration";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(40, 207);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 30);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(40, 241);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Enter your password";
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // label1
            // 
            labelRepeatPassword.AutoSize = true;
            labelRepeatPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRepeatPassword.ForeColor = Color.White;
            labelRepeatPassword.Location = new Point(40, 277);
            labelRepeatPassword.Name = "label1";
            labelRepeatPassword.Size = new Size(185, 30);
            labelRepeatPassword.TabIndex = 19;
            labelRepeatPassword.Text = "Repeat password:";
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxRepeatPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxRepeatPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxRepeatPassword.ForeColor = Color.White;
            textBoxRepeatPassword.Location = new Point(40, 311);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(250, 33);
            textBoxRepeatPassword.TabIndex = 3;
            textBoxRepeatPassword.Text = "Repeat your password";
            textBoxRepeatPassword.Enter += textBoxRepeatPassword_Enter;
            textBoxRepeatPassword.Leave += textBoxRepeatPassword_Leave;
            // 
            // labelMessage
            // 
            labelInformingMessage.AutoSize = true;
            labelInformingMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelInformingMessage.ForeColor = Color.White;
            labelInformingMessage.Location = new Point(40, 98);
            labelInformingMessage.Name = "labelMessage";
            labelInformingMessage.Size = new Size(97, 21);
            labelInformingMessage.TabIndex = 20;
            labelInformingMessage.Text = "No message";
            labelInformingMessage.Visible = false;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 440);
            Controls.Add(labelInformingMessage);
            Controls.Add(labelRepeatPassword);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(labelTitle);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonRegister);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Name = "FormRegistration";
            Text = "FormRegistration";
            Load += FormRegistration_Load;
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(buttonRegister, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(labelTitle, 0);
            Controls.SetChildIndex(textBoxRepeatPassword, 0);
            Controls.SetChildIndex(labelRepeatPassword, 0);
            Controls.SetChildIndex(labelInformingMessage, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPassword;
        private Button buttonRegister;
        private Label labelTitle;
        private Label labelInformingMessage;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelRepeatPassword;
    }
}