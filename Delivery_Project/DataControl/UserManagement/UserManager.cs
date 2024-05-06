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
        private ListDeliveryCustomers _deliveryCustomers;
        private ListDeliveryCouriers _deliveryCouriers;
        private ListDeliveryProvider _deliveryProviders;

        public static GetPlaceHandler? QuerryGetDeliveryPlace;

        public UserManager()
        {
            _deliveryCustomers = new ListDeliveryCustomers();
            _deliveryCouriers = new ListDeliveryCouriers();
            _deliveryProviders = new ListDeliveryProvider();

            Initialize();
        }

        private void Initialize()
        {
            DeliveryUser.ValidateLogin += ValidateLogin;
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

            _deliveryCustomers.AddedUser += Write_UserList;
            _deliveryCouriers.AddedUser += Write_UserList;
            _deliveryProviders.AddedUser += Write_UserList;            
        }

        // Validates new user login
        private bool ValidateLogin(string login, ref string message)
        {
            if (!UserDataValidator.ValidateLogin(login, ref message))
                return false;

            if (IsLoginExist(login))
            {
                message = "This login is already used.";
                return false;
            }

            return true;
        }

        // User registration functions
        private bool RegisterCustomer(string login, string password, ref string message)
        {
            bool isValid = UserDataValidator.ValidateLogin(login, ref message) &&
                           UserDataValidator.ValidatePassword(password, ref message);

            if (!isValid)
                return false;
            
            if (IsLoginExist(login))
            {
                message = "This login is already used.";
                return false;
            }

            _deliveryCustomers.Add(new DeliveryCustomer(login, password));
            return true;
        }
        private bool RegisterCourier(DeliveryUser user, string cardNumber, ref string message)
        {
            bool isValid = UserDataValidator.ValidateCardNumber(cardNumber, ref message);

            if (!isValid)
                return false;

            _deliveryCouriers.Add(new DeliveryCourier(user.Login, user.Password, user.PhoneNumber, cardNumber));

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
            
            _deliveryProviders.Add(provider);

            return DeleteAcount(user);
        }

        // Returns true if given login already exists
        public bool IsLoginExist(string login)
        {
            return  _deliveryCustomers.Any(c => c.Login == login) ||
                    _deliveryCouriers.Any(c => c.Login == login) ||
                    _deliveryProviders.Any(p => p.Login == login);
        }

        // Tries to log in account using given login and password
        private string LoginUser(string login, string password, out DeliveryUser? user)
        {
            string message = "Something went wrong";

            user = _deliveryCustomers.FirstOrDefault(c => c.Login == login);
            user = _deliveryCouriers.FirstOrDefault(c => c.Login == login) ?? user;
            user = _deliveryProviders.FirstOrDefault(p => p.Login == login) ?? user;

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
        // Deletes given account
        private bool DeleteAcount(DeliveryUser user)
        {
            bool isDeleted = false;

            if (user is DeliveryCustomer customer)
            {
                isDeleted = _deliveryCustomers?.Remove(customer) ?? false;
            }
            else if (user is DeliveryCourier courier)
            {
                isDeleted = _deliveryCouriers?.Remove(courier) ?? false;
            }
            else if (user is DeliveryProvider provider)
            {
                isDeleted = _deliveryProviders?.Remove(provider) ?? false;
            }

            if (isDeleted)
            {
                Write_UserList(user);
            }

            return isDeleted;
        }

        // Writes specified user list to json depending on given user type
        private void Write_UserList(DeliveryUser user)
        {
            if (user is DeliveryCustomer customer)
            {
                Write_List(_deliveryCustomers.List, "Customers");
            }
            else if (user is DeliveryCourier courier)
            {
                Write_List(_deliveryCouriers.List, "Couriers");
            }
            else if (user is DeliveryProvider provider)
            {
                Write_List(_deliveryProviders.List, "Providers");
            }
        }
        // Writes given user list to json
        private void Write_List<T>(List<T> list, string fileName)
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(list, fileName);

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        // Read users lists unit
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

            _deliveryCustomers = new ListDeliveryCustomers(customers);
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

            _deliveryCouriers = new ListDeliveryCouriers(couriers);
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

            _deliveryProviders = new ListDeliveryProvider(providers);
        }
    }
}
