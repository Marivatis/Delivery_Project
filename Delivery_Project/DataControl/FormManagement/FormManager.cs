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
using Microsoft.VisualBasic.ApplicationServices;
using System.CodeDom;

namespace Delivery_Project.DataControl.FormManagement
{
    public class FormManager
    {
        private FormLogin? formLogin;
        private FormRegistration? formRegistration;
        private FormCustomer? formCustomer;
        private FormCourier? formCourier;
        private FormProvider? formProvider;

        public static RegisterCustomer? QuerryRegistrerCustomer;
        public static LoginUser? QuerryLoginCustomer;
        public static Func<DeliveryUser, bool>? QuerryDeleteAccount;

        public FormManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            CustomBorderForm.CustomFormClosed += CustomBorderForm_FormClosed;

            FormLogin.LoginUser += LoginUser;
            FormLogin.ShowRegistrationForm += FormRegistrationShow;

            FormRegistration.RegisterCustomer += QuerryRegistrerCustomer;
            FormRegistration.RegistrationComplete += FormRegistration_RegistrationComplete;

            FormCustomerProfile.DeleteAccount += QuerryDeleteAccount;
            FormCustomerProfile.AccountDeleted += AccountDeleted;
        }

        // Runs application and shows login form
        public void Run()
        {
            formLogin = new FormLogin();
            formLogin.Show();

            Application.Run();
        }

        // Application close when forms count equals zero
        private void CustomBorderForm_FormClosed(object? sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        // Shows login form when user registration complete
        private void FormRegistration_RegistrationComplete(object? sender, EventArgs e)
        {
            formLogin = new FormLogin();
            formLogin.Show();
        }
        // Shows registration form
        private void FormRegistrationShow()
        {
            formRegistration = new FormRegistration();
            formRegistration.Show();
        }
                
        // Makes querry to login user
        private bool LoginUser(string login, string password, ref string message)
        {
            DeliveryUser? user = null;

            message = QuerryLoginCustomer?.Invoke(login, password, out user) ?? "Something went wrong";

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
        // Opens corresponding form after user logs in
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

        // Closes corresponding user form
        private void AccountDeleted(Type userType)
        {
            if (userType == typeof(DeliveryCustomer))
            {
                formCustomer?.Close();
            }
            else if (userType == typeof(DeliveryCourier))
            {
                formCourier?.Close();
            }
            else if (userType == typeof(DeliveryProvider))
            {
                formProvider?.Close();
            }

            formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
