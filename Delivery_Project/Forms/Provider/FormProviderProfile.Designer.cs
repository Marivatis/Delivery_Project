namespace Delivery_Project.Forms.Provider
{
    partial class FormProviderProfile
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
            buttonEditLoginPhone = new Button();
            buttonEditPassword = new Button();
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
            // buttonEdit2
            // 
            buttonEditLoginPhone.FlatStyle = FlatStyle.Flat;
            buttonEditLoginPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditLoginPhone.ForeColor = Color.White;
            buttonEditLoginPhone.Location = new Point(224, 284);
            buttonEditLoginPhone.Name = "buttonEdit2";
            buttonEditLoginPhone.Size = new Size(66, 36);
            buttonEditLoginPhone.TabIndex = 62;
            buttonEditLoginPhone.Text = "Edit";
            buttonEditLoginPhone.UseVisualStyleBackColor = true;
            buttonEditLoginPhone.Click += buttonEdit2_Click;
            // 
            // buttonEdit1
            // 
            buttonEditPassword.FlatStyle = FlatStyle.Flat;
            buttonEditPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPassword.ForeColor = Color.White;
            buttonEditPassword.Location = new Point(224, 114);
            buttonEditPassword.Name = "buttonEdit1";
            buttonEditPassword.Size = new Size(66, 36);
            buttonEditPassword.TabIndex = 61;
            buttonEditPassword.Text = "Edit";
            buttonEditPassword.UseVisualStyleBackColor = true;
            buttonEditPassword.Click += buttonEdit1_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(40, 292);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 30);
            labelPassword.TabIndex = 60;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(40, 326);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 59;
            textBoxPassword.Text = "Enter your password";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(40, 192);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 30);
            labelPhoneNumber.TabIndex = 58;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Enabled = false;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = Color.White;
            textBoxPhoneNumber.Location = new Point(40, 226);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 57;
            textBoxPhoneNumber.Text = "Enter your phone number";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(40, 122);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 56;
            labelLogin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Enabled = false;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(40, 156);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 55;
            textBoxLogin.Text = "Enter your login";
            // 
            // labelMyProfileTitle
            // 
            labelMyProfileTitle.AutoSize = true;
            labelMyProfileTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMyProfileTitle.ForeColor = Color.White;
            labelMyProfileTitle.Location = new Point(89, 30);
            labelMyProfileTitle.Name = "labelMyProfileTitle";
            labelMyProfileTitle.Size = new Size(151, 37);
            labelMyProfileTitle.TabIndex = 54;
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
            buttonDeleteAccount.TabIndex = 63;
            buttonDeleteAccount.Text = "Delete account";
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // FormProviderProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 550);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(buttonEditLoginPhone);
            Controls.Add(buttonEditPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(labelMyProfileTitle);
            Name = "FormProviderProfile";
            Text = "FormProviderProfile";
            Load += FormProviderProfile_Load;
            Controls.SetChildIndex(labelMyProfileTitle, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(buttonEditPassword, 0);
            Controls.SetChildIndex(buttonEditLoginPhone, 0);
            Controls.SetChildIndex(buttonDeleteAccount, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPassword;
        private Button buttonDeleteAccount;
        private Button buttonEditLoginPhone;
        private Button buttonEditPassword;
        private Label labelLogin;
        private Label labelPhoneNumber;
        private Label labelPassword;
        private Label labelMyProfileTitle;
    }
}