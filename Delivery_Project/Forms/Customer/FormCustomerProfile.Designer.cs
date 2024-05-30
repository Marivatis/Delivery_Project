namespace Delivery_Project.Forms.Customer
{
    partial class FormCustomerProfile
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
            labelMyProfileTitle = new Label();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelAddress = new Label();
            buttonEditLoginPhone = new Button();
            labelBecomeProvider = new Label();
            labelBecomePart2 = new Label();
            labelBecomeCourier = new Label();
            buttonEditPassword = new Button();
            textBoxAddress = new TextBox();
            buttonEditAddress = new Button();
            buttonDeleteAccount = new Button();
            labelBecomePart1 = new Label();
            SuspendLayout();
            // 
            // labelMyProfileTitle
            // 
            labelMyProfileTitle.AutoSize = true;
            labelMyProfileTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMyProfileTitle.ForeColor = Color.White;
            labelMyProfileTitle.Location = new Point(90, 35);
            labelMyProfileTitle.Name = "labelMyProfileTitle";
            labelMyProfileTitle.Size = new Size(151, 37);
            labelMyProfileTitle.TabIndex = 18;
            labelMyProfileTitle.Text = "My Profile";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(40, 132);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 20;
            labelLogin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Enabled = false;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(40, 166);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 19;
            textBoxLogin.Text = "Enter your login";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(40, 202);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 30);
            labelPhoneNumber.TabIndex = 22;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Enabled = false;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = Color.White;
            textBoxPhoneNumber.Location = new Point(40, 236);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 21;
            textBoxPhoneNumber.Text = "Enter your phone number";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(40, 304);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 30);
            labelPassword.TabIndex = 24;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(40, 338);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 23;
            textBoxPassword.Text = "Enter your password";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.ForeColor = Color.White;
            labelAddress.Location = new Point(40, 406);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 30);
            labelAddress.TabIndex = 25;
            labelAddress.Text = "Address:";
            // 
            // buttonEditLoginPhone
            // 
            buttonEditLoginPhone.FlatStyle = FlatStyle.Flat;
            buttonEditLoginPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditLoginPhone.ForeColor = Color.White;
            buttonEditLoginPhone.Location = new Point(224, 124);
            buttonEditLoginPhone.Name = "buttonEditLoginPhone";
            buttonEditLoginPhone.Size = new Size(66, 36);
            buttonEditLoginPhone.TabIndex = 27;
            buttonEditLoginPhone.Text = "Edit";
            buttonEditLoginPhone.UseVisualStyleBackColor = true;
            buttonEditLoginPhone.Click += buttonEdit1_Click;
            // 
            // labelBecomeProvider
            // 
            labelBecomeProvider.AutoSize = true;
            labelBecomeProvider.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBecomeProvider.ForeColor = Color.White;
            labelBecomeProvider.Location = new Point(196, 509);
            labelBecomeProvider.Name = "labelBecomeProvider";
            labelBecomeProvider.Size = new Size(90, 21);
            labelBecomeProvider.TabIndex = 32;
            labelBecomeProvider.Text = "a provider";
            labelBecomeProvider.Click += labelBecomeProvider_Click;
            // 
            // labelBecomePart2
            // 
            labelBecomePart2.AutoSize = true;
            labelBecomePart2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBecomePart2.ForeColor = Color.White;
            labelBecomePart2.Location = new Point(175, 509);
            labelBecomePart2.Name = "labelBecomePart2";
            labelBecomePart2.Size = new Size(25, 21);
            labelBecomePart2.TabIndex = 31;
            labelBecomePart2.Text = "or";
            // 
            // labelBecomeCourier
            // 
            labelBecomeCourier.AutoSize = true;
            labelBecomeCourier.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBecomeCourier.ForeColor = Color.White;
            labelBecomeCourier.Location = new Point(101, 509);
            labelBecomeCourier.Name = "labelBecomeCourier";
            labelBecomeCourier.Size = new Size(79, 21);
            labelBecomeCourier.TabIndex = 33;
            labelBecomeCourier.Text = "a courier";
            labelBecomeCourier.Click += labelBecomeCourier_Click;
            // 
            // buttonEditPassword
            // 
            buttonEditPassword.FlatStyle = FlatStyle.Flat;
            buttonEditPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPassword.ForeColor = Color.White;
            buttonEditPassword.Location = new Point(224, 296);
            buttonEditPassword.Name = "buttonEditPassword";
            buttonEditPassword.Size = new Size(66, 36);
            buttonEditPassword.TabIndex = 34;
            buttonEditPassword.Text = "Edit";
            buttonEditPassword.UseVisualStyleBackColor = true;
            buttonEditPassword.Click += buttonEdit2_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(61, 61, 61);
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Enabled = false;
            textBoxAddress.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxAddress.ForeColor = Color.White;
            textBoxAddress.Location = new Point(40, 440);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 33);
            textBoxAddress.TabIndex = 35;
            textBoxAddress.Text = "Enter your address";
            // 
            // buttonEditAddress
            // 
            buttonEditAddress.FlatStyle = FlatStyle.Flat;
            buttonEditAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditAddress.ForeColor = Color.White;
            buttonEditAddress.Location = new Point(224, 398);
            buttonEditAddress.Name = "buttonEditAddress";
            buttonEditAddress.Size = new Size(66, 36);
            buttonEditAddress.TabIndex = 36;
            buttonEditAddress.Text = "Edit";
            buttonEditAddress.UseVisualStyleBackColor = true;
            buttonEditAddress.Click += buttonEdit3_Click;
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
            buttonDeleteAccount.TabIndex = 37;
            buttonDeleteAccount.Text = "Delete account";
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // label1
            // 
            labelBecomePart1.AutoSize = true;
            labelBecomePart1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBecomePart1.ForeColor = Color.White;
            labelBecomePart1.Location = new Point(40, 509);
            labelBecomePart1.Name = "label1";
            labelBecomePart1.Size = new Size(66, 21);
            labelBecomePart1.TabIndex = 38;
            labelBecomePart1.Text = "Become";
            // 
            // FormCustomerProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 550);
            Controls.Add(labelBecomePart1);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(buttonEditAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(buttonEditPassword);
            Controls.Add(labelBecomeCourier);
            Controls.Add(labelBecomeProvider);
            Controls.Add(labelBecomePart2);
            Controls.Add(buttonEditLoginPhone);
            Controls.Add(labelAddress);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(labelMyProfileTitle);
            Name = "FormCustomerProfile";
            Text = "FormCustomerProfile";
            Load += FormCustomerProfile_Load;
            Controls.SetChildIndex(labelMyProfileTitle, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(labelAddress, 0);
            Controls.SetChildIndex(buttonEditLoginPhone, 0);
            Controls.SetChildIndex(labelBecomePart2, 0);
            Controls.SetChildIndex(labelBecomeProvider, 0);
            Controls.SetChildIndex(labelBecomeCourier, 0);
            Controls.SetChildIndex(buttonEditPassword, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(buttonEditAddress, 0);
            Controls.SetChildIndex(buttonDeleteAccount, 0);
            Controls.SetChildIndex(labelBecomePart1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeleteAccount;
        private Button buttonEditLoginPhone;
        private Button buttonEditPassword;
        private Button buttonEditAddress;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxAddress;
        private Label labelMyProfileTitle;
        private Label labelLogin;
        private Label labelPhoneNumber;
        private Label labelPassword;
        private Label labelAddress;
        private Label labelBecomePart1;
        private Label labelBecomePart2;
        private Label labelBecomeProvider;
        private Label labelBecomeCourier;
    }
}