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
using System.Net.Http.Headers;

namespace Delivery_Project.DataControl.FormManagement
{
    public class FormManager
    {
        private FormLogin formLogin;
        private FormRegistration formRegistration;
        private FormCustomer formCustomer;
        private FormCourier formCourier;
        private FormProvider formProvider;

        public static EntryUser QuerryRegistrerCustomer;
        //public static Func<string, string, bool> QuerryRegistration;
        public static LoginCustomer QuerryLoginCustomer;
        //public static Func<string, string, bool> QuerryLogin;

        public FormManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            formRegistration = new FormRegistration();
            formLogin = new FormLogin();

            formLogin.LoginUser += LoginUser;
            formLogin.ShowRegistrationForm += formRegistration.Show;

            CustomBorderForm.CustomFormClosed += CustomBorderForm_FormClosed;
            
            FormRegistration.RegisterCustomer += QuerryRegistrerCustomer;
            formRegistration.RegistrationComplete += FormRegistration_RegistrationComplete;
        }

        private void FormRegistration_RegistrationComplete(object? sender, EventArgs e)
        {
            Initialize();
            formLogin.Show();
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
                
        private bool LoginUser(string login, string password, ref string message)
        {
            DeliveryUser user;

            message = QuerryLoginCustomer.Invoke(login, password, out user);

            if (user != null)
            {
                LoginComplete(user);
                return true;
            }
            else
            {

                return false;
            }
        }
        private void LoginComplete(DeliveryUser user)
        {
            if (user is DeliveryCustomer customer)
            {
                formCustomer = new FormCustomer(ref customer);
                formCustomer.Show();
            }
            else if (user is DeliveryCourier courier)
            {
                formCourier = new FormCourier(ref courier);
                formCourier.Show();
            }
            else if (user is DeliveryProvider provider)
            {
                formProvider = new FormProvider(ref provider);
                formProvider.Show();
            }

            formLogin?.Close();
        }

    }
}
