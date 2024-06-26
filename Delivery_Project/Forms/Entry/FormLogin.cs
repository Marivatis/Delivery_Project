﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.Forms.Templates;
using Delivery_Project.DataControl.UserManagement;
using System.Runtime.InteropServices;
using Delivery_Project.DataControl.FormManagement;

namespace Delivery_Project.Forms.Entry
{
    public partial class FormLogin : TemplateCustomBorderForm
    {
        public static Action? ShowRegistrationForm;
        public static EntryCustomer? LoginUser;

        public static event EventHandler? LoginComplete;

        public FormLogin() : base()
        {
            InitializeComponent();
        }

        // On load form functions
        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBoxLogin.Focus();
        }

        // Login user function
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (login == "Enter your login" || password == "Enter your password")
            {
                labelMessage.Text = "Login or password fields are empty.";
                labelMessage.Visible = true;
                return;
            }

            bool isLogged = false;
            string message = "Something went wrong.";

            isLogged = LoginUser?.Invoke(login, password, ref message) ?? false;

            if (!isLogged)
            {
                labelMessage.Text = message;
                labelMessage.Visible = true;
            }
        }

        // Transotion to registration form
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            ShowRegistrationForm?.Invoke();
            Close();
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
    }
}
