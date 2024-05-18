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
using Delivery_Project.DataControl.Users;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Entry
{
    public partial class FormRegistration : TemplateCustomBorderForm
    {
        public static EntryCustomer? RegisterCustomer;

        public static event Action<Type>? RegistrationComplete;

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
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string repeatPassword = textBoxRepeatPassword.Text;

            if (login == "Enter your login" || password == "Enter your password" || repeatPassword == "Repeat your password")
            {
                LabelMessage_Show("Login or password fields are empty.");
                return;
            }

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                LabelMessage_Show("Passwords don`t match.");
                return;
            }

            string message = "Something went wrong.";
            bool isRegistred = RegisterCustomer?.Invoke(login, password, ref message) ?? false;

            if (isRegistred)
            {
                RegistrationComplete?.Invoke(typeof(DeliveryCustomer));
                Close();
            }
            else
            {
                LabelMessage_Show(message);
            }
        }

        // Show message labes with given text
        private void LabelMessage_Show(string message)
        {
            labelInformingMessage.Text = message;
            labelInformingMessage.Visible = true;
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
