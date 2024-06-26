﻿using Delivery_Project.DataControl.UserManagement;
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
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.DataControl.Workplaces.Management;

namespace Delivery_Project.DataControl.FormManagement
{
    public class FormManager
    {
        private FormLogin? formLogin;
        private FormRegistration? formRegistration;
        private FormCustomer? formCustomer;
        private FormCourier? formCourier;
        private FormProvider? formProvider;

        public static EntryCustomer? QuerryRegistrerCustomer;
        public static RegisterCourier? QuerryRegistrerCourier;
        public static RegisterProvider? QuerryRegistrerProvider;
        public static LoginUser? QuerryLoginCustomer;
        public static Func<DeliveryUser, bool>? QuerryDeleteAccount;

        public static GetPlaceHandler? QuerryGetDeliveryPlace;
        public static Func<List<DeliveryPlace>?>? QuerryGetDeliveryPlaceList;

        public static OrderHandler? QuerryMakeOrder;
        public static DeclineOrder? QuerryDeclineOrder;
        public static Func<string, DeliveryOrder?>? QuerryGetActiveOrder;

        public static Func<List<DeliveryOrder>?>? QuerryGetOrdersList;
        public static Func<string, DeliveryOrder?>? QuerryGetTakenOrder;
        public static Func<string, bool>? QuerryOrderOnTheWay;
        public static TakeOrder? QuerryTakeOrder;
        public static FinishOrder? QuerryFinishOrder;

        public FormManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            TemplateCustomBorderForm.CustomFormClosed += CustomBorderForm_FormClosed;

            FormLogin.LoginUser += LoginUser;
            FormLogin.ShowRegistrationForm += FormRegistration_Show;

            FormRegistration.RegisterCustomer += QuerryRegistrerCustomer;
            FormRegistration.RegistrationComplete += RegistrationComplete;

            FormCustomer.GetDeliveryPlacesList += QuerryGetDeliveryPlaceList;
            FormCustomer.DeclineOrder += QuerryDeclineOrder;
            FormCustomer.GetActiveOrder += QuerryGetActiveOrder;
            FormCustomerProfile.DeleteAccount += QuerryDeleteAccount;
            FormCustomerProfile.AccountDeleted += AccountDeleted;
            FormOrderConfirmation.MakeOrder += QuerryMakeOrder;

            FormCourier.GetWaitingOrdersList += QuerryGetOrdersList;
            FormCourier.GetTakenOrder += QuerryGetTakenOrder;
            FormCourier.OrderOnTheWay += QuerryOrderOnTheWay;
            FormCourier.TakeOrder += QuerryTakeOrder;
            FormCourier.FinishOrder += QuerryFinishOrder;
            FormCourierProfile.DeleteAccount += QuerryDeleteAccount;
            FormCourierProfile.AccountDeleted += AccountDeleted;
            FormCourierRegistration.RegisterCourier += QuerryRegistrerCourier;
            FormCourierRegistration.RegistrationComplete += RegistrationComplete;

            FormProvider.GetDeliveryPlace += QuerryGetDeliveryPlace;
            FormProviderProfile.DeleteAccount += QuerryDeleteAccount;
            FormProviderProfile.AccountDeleted += AccountDeleted;
            FormProviderRegistration.RegisterProvider += QuerryRegistrerProvider;
            FormProviderRegistration.RegistrationComplete += RegistrationComplete;
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
        private void RegistrationComplete(Type user)
        {
            formCustomer?.Close();
            formCourier?.Close();
            formProvider?.Close();

            FormLogin_Show();
        }

        // Shows registration form
        private void FormRegistration_Show()
        {
            if (!Application.OpenForms.OfType<FormRegistration>().Any())
            {
                formRegistration = new FormRegistration();
                formRegistration.Show();
            }            
        }
        // Show login form
        private void FormLogin_Show()
        {
            if (!Application.OpenForms.OfType<FormLogin>().Any())
            {
                formLogin = new FormLogin();
                formLogin.Show();
            }
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

            FormLogin_Show();
        }
    }
}
