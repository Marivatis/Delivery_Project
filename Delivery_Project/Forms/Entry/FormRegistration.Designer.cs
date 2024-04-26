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
            labelRegistration = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxRepeatPassword = new TextBox();
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
            labelLogin.Location = new Point(40, 112);
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
            textBoxLogin.Location = new Point(40, 146);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Text = "Enter your login";
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistration.ForeColor = Color.White;
            labelRegistration.Location = new Point(78, 35);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(175, 37);
            labelRegistration.TabIndex = 17;
            labelRegistration.Text = "Registration";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(40, 182);
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
            textBoxPassword.Location = new Point(40, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Enter your password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 252);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 19;
            label1.Text = "Repeat password:";
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxRepeatPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxRepeatPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxRepeatPassword.ForeColor = Color.White;
            textBoxRepeatPassword.Location = new Point(40, 286);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(250, 33);
            textBoxRepeatPassword.TabIndex = 3;
            textBoxRepeatPassword.Text = "Repeat your password";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 440);
            Controls.Add(label1);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(labelRegistration);
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
            Controls.SetChildIndex(labelRegistration, 0);
            Controls.SetChildIndex(textBoxRepeatPassword, 0);
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private Label labelLogin;
        private TextBox textBoxLogin;
        private Label labelRegistration;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxRepeatPassword;
    }
}