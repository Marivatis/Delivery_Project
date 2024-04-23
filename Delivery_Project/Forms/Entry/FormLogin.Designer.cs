namespace Delivery_Project.Forms.Entry
{
    partial class FormLogin
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            labelLoginMain = new Label();
            buttonEnter = new Button();
            label1 = new Label();
            labelSignUp = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(61, 61, 61);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(40, 147);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 33);
            textBoxLogin.TabIndex = 6;
            textBoxLogin.Text = "Enter your login";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 61, 61);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(40, 217);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 33);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.Text = "Enter your password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(40, 114);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 8;
            labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(40, 184);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 30);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password:";
            // 
            // labelLoginMain
            // 
            labelLoginMain.AutoSize = true;
            labelLoginMain.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginMain.ForeColor = Color.White;
            labelLoginMain.Location = new Point(117, 35);
            labelLoginMain.Name = "labelLoginMain";
            labelLoginMain.Size = new Size(97, 37);
            labelLoginMain.TabIndex = 10;
            labelLoginMain.Text = "Log In";
            // 
            // buttonEnter
            // 
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(40, 320);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(250, 40);
            buttonEnter.TabIndex = 11;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 368);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 12;
            label1.Text = "Don`t have an accaunt?";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSignUp.ForeColor = Color.White;
            labelSignUp.Location = new Point(129, 389);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(68, 21);
            labelSignUp.TabIndex = 14;
            labelSignUp.Text = "Sing Up";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 440);
            Controls.Add(labelSignUp);
            Controls.Add(label1);
            Controls.Add(buttonEnter);
            Controls.Add(labelLoginMain);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(labelLoginMain, 0);
            Controls.SetChildIndex(buttonEnter, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(labelSignUp, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelLoginMain;
        private Button buttonEnter;
        private Label label1;
        private Label labelSignUp;
    }
}