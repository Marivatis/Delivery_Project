using System;
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
    public partial class FormLogin : CustomBorderForm
    {
        public Action? ShowRegistrationForm;

        public EntryUser LoginUser;
        //public  Func<string, string, bool>? LoginUser;

        public event EventHandler? LoginComplete;

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
                labelMessage.Text = "Login or password fields are empty.";
                labelMessage.Visible = true;
                return;
            }

            bool isLogged = false;
            string message = "Something went wrong.";

            isLogged = LoginUser.Invoke(login, password, ref message);

            if (!isLogged)
            {
                labelMessage.Text = message;
                labelMessage.Visible = true;
            }
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            ShowRegistrationForm?.Invoke();
            Close();
        }
    }
}
