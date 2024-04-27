using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Entry
{
    public partial class FormRegistration : CustomBorderForm
    {
        public event EventHandler RegistrationComplete;

        public static EntryUser RegisterCustomer;

        public FormRegistration() : base()
        {
            InitializeComponent();
        }

        // On load form functions
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBoxLogin.Focus();
        }

        // Registration button click event hendler
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                labelMessage.Text = "Passwords don`t match.";
                labelMessage.Visible = true;
                return;
            }

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            
            if (login == "Enter your login" || password == "Enter your password")
            {
                labelMessage.Text = "Login or password fields are empty.";
                labelMessage.Visible = true;
                return;
            }

            string message = "Something went wrong.";
            bool isRegistred = RegisterCustomer.Invoke(login, password, ref message);

            if (isRegistred)
            {
                RegistrationComplete.Invoke(this, EventArgs.Empty);
                Close();
            }
            else
            {
                labelMessage.Text = message;
                labelMessage.Visible = true;
            }
        }

        // Field login usefull design
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Enter your login")
            {
                textBoxLogin.Clear();
            }
        }
        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Enter your login";
            }
        }

        // Field password usefull design
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter your password")
            {
                textBoxPassword.Clear();
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Enter your password";
            }
        }

        // Field repeat password usefull design
        private void textBoxRepeatPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxRepeatPassword.Text == "Repeat your password")
            {
                textBoxRepeatPassword.Clear();
            }
        }
        private void textBoxRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRepeatPassword.Text))
            {
                textBoxRepeatPassword.Text = "Repeat your password";
            }
        }

    }
}
