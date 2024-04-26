using Delivery_Project.DataControl.UserManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.Forms.Courier;
using Delivery_Project.Forms.Customer;
using Delivery_Project.Forms.Entry;
using Delivery_Project.Forms.Templates;
using Delivery_Project.Forms.Provider;
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
        private FormProvider formProvider;

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
            formProvider = new FormProvider();

            CustomBorderForm.CustomFormClosed += CustomBorderForm_FormClosed;

            formLogin.LoginComplete += LoginComplete;
            formLogin.LoginAtempt += Querry_LoginAttempt.Invoke;
            formLogin.ShowRegistrationForm += formRegistration.Show;

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
            if (UserManager.LoggedUser == typeof(DeliveryCustomer))
            {
                formCustomer.Show();
            }
            else if (UserManager.LoggedUser == typeof(DeliveryCourier))
            {
                formCourier.Show();
            }
            else if (UserManager.LoggedUser == typeof(DeliveryProvider))
            {
                formProvider.Show();
            }
        }

    }
}
