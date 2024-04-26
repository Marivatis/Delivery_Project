﻿namespace Delivery_Project.Forms.Provider
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
            labelCardNumber = new Label();
            textBoxCardNumber = new TextBox();
            labelPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            buttonRegister = new Button();
            labelRegistration = new Label();
            SuspendLayout();
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCardNumber.ForeColor = Color.White;
            labelCardNumber.Location = new Point(38, 197);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(136, 30);
            labelCardNumber.TabIndex = 49;
            labelCardNumber.Text = "Secret word:";
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.BackColor = Color.FromArgb(61, 61, 61);
            textBoxCardNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxCardNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxCardNumber.ForeColor = Color.White;
            textBoxCardNumber.Location = new Point(38, 231);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new Size(250, 33);
            textBoxCardNumber.TabIndex = 48;
            textBoxCardNumber.Text = "Enter your secret word";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.White;
            labelPhoneNumber.Location = new Point(38, 127);
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
            textBoxPhoneNumber.Location = new Point(38, 161);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(250, 33);
            textBoxPhoneNumber.TabIndex = 46;
            textBoxPhoneNumber.Text = "Enter your phone number";
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
            // FormProviderRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 440);
            Controls.Add(labelCardNumber);
            Controls.Add(textBoxCardNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(buttonRegister);
            Controls.Add(labelRegistration);
            Name = "FormProviderRegistration";
            Text = "FormProviderRegistration";
            Controls.SetChildIndex(labelRegistration, 0);
            Controls.SetChildIndex(buttonRegister, 0);
            Controls.SetChildIndex(textBoxPhoneNumber, 0);
            Controls.SetChildIndex(labelPhoneNumber, 0);
            Controls.SetChildIndex(textBoxCardNumber, 0);
            Controls.SetChildIndex(labelCardNumber, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCardNumber;
        private TextBox textBoxCardNumber;
        private Label labelPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Button buttonRegister;
        private Label labelRegistration;
    }
}