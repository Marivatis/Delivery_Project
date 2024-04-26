using Delivery_Project.DataControl.Interfaces;
using Delivery_Project.DataControl.UserManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.Forms.Courier;
using Delivery_Project.Forms.Customer;
using Delivery_Project.Forms.Entry;
using Delivery_Project.Forms.CustomBorderCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.FormManagement
{
    public class FormManager
    {
        private FormLogin formLogin;
        private FormRegistration formRegistration;
        private FormCustomer formCustomer;
        private FormCourier formCourier;

        public static event Func<string, string, bool> Querry_LoginAttempt;

        public FormManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            formLogin = new FormLogin();
            formRegistration = new FormRegistration();
            formCustomer = new FormCustomer();
            formCourier = new FormCourier();

            CustomBorderForm.FormClosed += CustomBorderForm_FormClosed;

            formLogin.LoginComplete += LoginComplete;
            formLogin.LoginAtempt += Querry_LoginAttempt.Invoke;
            formLogin.GotoRegistrationForm += FormLogin_GotoRegistrationForm;

            formRegistration.LoginComplete += LoginComplete;
        }

        public void Run()
        {
            formLogin.Show();
            Application.Run();
        }

        private void CustomBorderForm_FormClosed(object? sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
                
        private void LoginComplete(object? sender, EventArgs e)
        {
            if (UserManager.LoggdUser == typeof(DeliveryCustomer))
            {
                formCustomer.Show();
            }
            else if (UserManager.LoggdUser == typeof(DeliveryCourier))
            {
                formCourier.Show();
            }
        }

        private void FormLogin_GotoRegistrationForm(object? sender, EventArgs e)
        {
            formRegistration.Show();
        }

    }
}
