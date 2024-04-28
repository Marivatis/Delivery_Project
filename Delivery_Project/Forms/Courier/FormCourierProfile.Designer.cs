namespace Delivery_Project.Forms.Courier
{
    partial class FormCourierProfile
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
            buttonEdit3 = new Button();
            textBoxCardNumber = new TextBox();
            buttonEdit2 = new Button();
            buttonEdit1 = new Button();
            labelCardNumber = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelMyProfileTitle = new Label();
            buttonDeleteAccount = new Button();
            SuspendLayout();
            // 
            // buttonEdit3
            // 
            buttonEdit3.FlatStyle = FlatStyle.Flat;
            buttonEdit3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit3.ForeColor = Color.White;
            buttonEdit3.Location = new Point(225, 388);
            buttonEdit3.Name = "buttonEdit3";
            buttonEdit3.Size = new Size(66, 36);
            buttonEdit3.TabIndex = 48;
            buttonEdit3.Text = "Edit";
            buttonEdit3.UseVisualStyleBackColor = true;
            buttonEdit3.Click += buttonEdit3_Click;
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxCardNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxCardNumber.Enabled = false;
            textBoxCardNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxCardNumber.ForeColor = Color.White;
            textBoxCardNumber.Location = new Point(41, 430);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new Size(250, 33);
            textBoxCardNumber.TabIndex = 47;
            textBoxCardNumber.Text = "Enter your card number";
            // 
            // buttonEdit2
            // 
            buttonEdit2.FlatStyle = FlatStyle.Flat;
            buttonEdit2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit2.ForeColor = Color.White;
            buttonEdit2.Location = new Point(225, 289);
            buttonEdit2.Name = "buttonEdit2";
            buttonEdit2.Size = new Size(66, 36);
            buttonEdit2.TabIndex = 46;
            buttonEdit2.Text = "Edit";
            buttonEdit2.UseVisualStyleBackColor = true;
            // 
            // buttonEdit1
            // 
            buttonEdit1.FlatStyle = FlatStyle.Flat;
            buttonEdit1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit1.ForeColor = Color.White;
            buttonEdit1.Location = new Point(225, 119);
            buttonEdit1.Name = "buttonEdit1";
            buttonEdit1.Size = new Size(66, 36);
            buttonEdit1.TabIndex = 45;
            buttonEdit1.Text = "Edit";
            buttonEdit1.UseVisualStyleBackColor = true;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCardNumber.ForeColor = Color.White;
            labelCardNumber.Location = new Point(41, 396);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(148, 30);
            labelCardNumber.TabIndex = 44;
            labelCardNumber.Text = "Card number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(41, 297);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 30);
            labelPassword.TabIndex = 43;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(41, 331);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 42;
            textBoxPassword.Text = "Enter your password";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(41, 197);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 30);
            labelPhoneNumber.TabIndex = 41;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Enabled = false;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = Color.White;
            textBoxPhoneNumber.Location = new Point(41, 231);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 40;
            textBoxPhoneNumber.Text = "Enter your phone number";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(41, 127);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 39;
            labelLogin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Enabled = false;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(41, 161);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 38;
            textBoxLogin.Text = "Enter your login";
            // 
            // labelMyProfileTitle
            // 
            labelMyProfileTitle.AutoSize = true;
            labelMyProfileTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMyProfileTitle.ForeColor = Color.White;
            labelMyProfileTitle.Location = new Point(90, 35);
            labelMyProfileTitle.Name = "labelMyProfileTitle";
            labelMyProfileTitle.Size = new Size(151, 37);
            labelMyProfileTitle.TabIndex = 37;
            labelMyProfileTitle.Text = "My Profile";
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.FlatAppearance.BorderSize = 0;
            buttonDeleteAccount.FlatStyle = FlatStyle.Flat;
            buttonDeleteAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteAccount.ForeColor = Color.White;
            buttonDeleteAccount.Location = new Point(1, 1);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(103, 25);
            buttonDeleteAccount.TabIndex = 49;
            buttonDeleteAccount.Text = "Delete account";
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // FormCourierProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 550);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(buttonEdit3);
            Controls.Add(textBoxCardNumber);
            Controls.Add(buttonEdit2);
            Controls.Add(buttonEdit1);
            Controls.Add(labelCardNumber);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(labelMyProfileTitle);
            Name = "FormCourierProfile";
            Text = "FormCourierProfile";
            Load += FormCourierProfile_Load;
            Controls.SetChildIndex(labelMyProfileTitle, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(labelCardNumber, 0);
            Controls.SetChildIndex(buttonEdit1, 0);
            Controls.SetChildIndex(buttonEdit2, 0);
            Controls.SetChildIndex(textBoxCardNumber, 0);
            Controls.SetChildIndex(buttonEdit3, 0);
            Controls.SetChildIndex(buttonDeleteAccount, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit3;
        private TextBox textBoxCardNumber;
        private Button buttonEdit2;
        private Button buttonEdit1;
        private Label labelCardNumber;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Label labelLogin;
        private TextBox textBoxLogin;
        private Label labelMyProfileTitle;
        private Button buttonDeleteAccount;
    }
}