using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.Forms.CustomBorderCode;
using Delivery_Project.DataControl.UserManagement;
using System.Runtime.InteropServices;
using Delivery_Project.DataControl.Interfaces;
using Delivery_Project.DataControl.FormManagement;

namespace Delivery_Project.Forms.Entry
{
    public partial class FormLogin : CustomBorderForm
    {
        public event Func<string, string, bool>? LoginAtempt;
        public event EventHandler? LoginComplete;
        public event EventHandler? GotoRegistrationForm;

        public FormLogin() : base()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBoxLogin.Focus();
        }

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

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (login == "Enter your login" || password == "Enter your password")
            {
                labelMessage.Text = "Login or password is incorrect";
                labelMessage.Visible = true;
                return;
            }

            bool isLogined = LoginAtempt?.Invoke(login, password) ?? false;

            if (isLogined)
            {
                labelMessage.Text = "Logged in!";
                labelMessage.Visible = true;
                LoginComplete?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                labelMessage.Text = "Login or password is incorrect";
                labelMessage.Visible = true;
            }
        }

        private void FormLogin_LoginComplete(object sender, EventArgs e)
        {
            Close();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            GotoRegistrationForm?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
