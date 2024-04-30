using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.DataValidation;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Users.Lists;
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.DataControl.Workplaces.Lists;
using Delivery_Project.DataControl.Workplaces.Management;
using Delivery_Project.Forms.Courier;
using Delivery_Project.Forms.Customer;
using Delivery_Project.Forms.Entry;
using Delivery_Project.Forms.Provider;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delivery_Project.DataControl.UserManagement
{
    public class UserManager
    {
        private ListDeliveryCustomers? deliveryCustomers;
        private ListDeliveryCouriers? deliveryCouriers;
        private ListDeliveryProvider? deliveryProviders;

        public static GetPlaceHandler? QuerryGetDeliveryPlace;
        
        public UserManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            DeliveryUser.ValidateLogin += UserDataValidator.ValidateLogin;
            DeliveryUser.ValidatePassword += UserDataValidator.ValidatePassword;
            DeliveryUser.ValidatePhoneNumber += UserDataValidator.ValidatePhoneNumber;
            DeliveryCustomer.ValidateAddress += UserDataValidator.ValidateAddress;
            DeliveryCourier.ValidateCardNumber += UserDataValidator.ValidateCardNumber;

            Read_DeliveryCustomers();
            Read_DeliveryCouriers();
            Read_DeliveryProviders();
            
            FormManager.QuerryRegistrerCustomer += RegisterCustomer;
            FormManager.QuerryRegistrerCourier += RegisterCourier;
            FormManager.QuerryRegistrerProvider += RegisterProvider;
            FormManager.QuerryLoginCustomer += LoginUser;
            FormManager.QuerryDeleteAccount += DeleteAcount;

            DeliveryUser.UserChanged += Write_UserList;            

            deliveryCustomers.AddedUser += Write_UserList;
            deliveryCouriers.AddedUser += Write_UserList;
            deliveryProviders.AddedUser += Write_UserList;
            
        }

        // User properties validation unit
       

        // User registration functions
        private bool RegisterCustomer(string login, string password, ref string message)
        {
            bool isValid = UserDataValidator.ValidateLogin(login, ref message) &&
                           UserDataValidator.ValidatePassword(password, ref message);

            if (!isValid)
                return false;
            
            var customerExists = deliveryCustomers.Any(c => c.Login == login) ||
                                 deliveryCouriers.Any(c => c.Login == login) ||
                                 deliveryProviders.Any(p => p.Login == login);    

            if (customerExists)
            {
                message = "This login is already used.";
                return false;
            }

            deliveryCustomers?.Add(new DeliveryCustomer(login, password));
            return true;
        }
        private bool RegisterCourier(DeliveryUser user, string cardNumber, ref string message)
        {
            bool isValid = UserDataValidator.ValidateCardNumber(cardNumber, ref message);

            if (!isValid)
                return false;

            deliveryCouriers?.Add(new DeliveryCourier(user.Login, user.Password, user.PhoneNumber, cardNumber));

            return DeleteAcount(user); 
        }
        private bool RegisterProvider(DeliveryUser user, string secretWord, ref string message)
        {
            if (secretWord != "Please")
            {
                message = "Incorrect secret word.";
                return false;
            }

            DeliveryProvider provider = new DeliveryProvider(user.Login, user.Password, user.PhoneNumber);

            DeliveryPlace? place = null;

            QuerryGetDeliveryPlace?.Invoke(0, out place);

            bool isConnected = provider.ConnectPlace(place, ref message);

            if (!isConnected)
                return false;
            
            deliveryProviders?.Add(provider);

            return DeleteAcount(user);
        }

        private string LoginUser(string login, string password, out DeliveryUser? user)
        {
            string message = "Something went wrong";

            user = deliveryCustomers.FirstOrDefault(c => c.Login == login);
            user = deliveryCouriers.FirstOrDefault(c => c.Login == login) ?? user;
            user = deliveryProviders.FirstOrDefault(p => p.Login == login) ?? user;

            if (user is null)
            {
                message = "No registered user with this login.";
            }
            else if (user.Password != password)
            {
                user = null;
                message = "Incorrect password.";
            }
            else
            {
                message = "Login successfull.";
            }

            return message;
        }

        private bool DeleteAcount(DeliveryUser user)
        {
            bool isDeleted = false;

            if (user is DeliveryCustomer customer)
            {
                isDeleted = deliveryCustomers?.Remove(customer) ?? false;
            }
            else if (user is DeliveryCourier courier)
            {
                isDeleted = deliveryCouriers?.Remove(courier) ?? false;
            }
            else if (user is DeliveryProvider provider)
            {
                isDeleted = deliveryProviders?.Remove(provider) ?? false;
            }

            if (isDeleted)
            {
                Write_UserList(user);
            }

            return isDeleted;
        }

        private void Write_UserList(DeliveryUser user)
        {
            if (user is DeliveryCustomer customer)
            {
                Write_List(deliveryCustomers?.List, "Customers");
            }
            else if (user is DeliveryCourier courier)
            {
                Write_List(deliveryCouriers?.List, "Couriers");
            }
            else if (user is DeliveryProvider provider)
            {
                Write_List(deliveryProviders?.List, "Providers");
            }
        }
        private void Write_List<T>(List<T> list, string fileName)
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(list, fileName);

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        private void Read_DeliveryCustomers()
        {
            bool isRead = false;
            List<DeliveryCustomer> customers = new List<DeliveryCustomer>();

            isRead = DataManager.ReadListFromJson("Customers", ref customers);

            if (!isRead)
            {
                MessageBox.Show("Reading list from json file \"Customers\" went wrong!");
                return;
            }

            deliveryCustomers = new ListDeliveryCustomers(customers);
        }
        private void Read_DeliveryCouriers()
        {
            bool isRead = false;
            List<DeliveryCourier> couriers = new List<DeliveryCourier>();

            isRead = DataManager.ReadListFromJson("Couriers", ref couriers);

            if (!isRead)
            {
                MessageBox.Show($"Reading list from json file \"Couriers\" went wrong!");
                return;
            }

            deliveryCouriers = new ListDeliveryCouriers(couriers);
        }
        private void Read_DeliveryProviders()
        {
            bool isRead = false;
            List<DeliveryProvider> providers = new List<DeliveryProvider>();

            isRead = DataManager.ReadListFromJson("Providers", ref providers);

            if (!isRead)
            {
                MessageBox.Show($"Reading list from json file \"Providers\" went wrong!");
                return;
            }

            deliveryProviders = new ListDeliveryProvider(providers);
        }
    }
}
