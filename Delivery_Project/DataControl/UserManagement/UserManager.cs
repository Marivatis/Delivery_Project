using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Users.Lists;
using Delivery_Project.Forms.Courier;
using Delivery_Project.Forms.Customer;
using Delivery_Project.Forms.Entry;
using Delivery_Project.Forms.Provider;
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
        private ListDeliveryCustomers deliveryCustomers;
        private ListDeliveryCouriers deliveryCouriers;
        private ListDeliveryProvider deliveryProviders;

        private static Type loggedUser;

        public UserManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            DeliveryUser.ValidateLogin += ValidateLogin;
            DeliveryUser.ValidatePassword += ValidatePassword;
            DeliveryUser.ValidatePhoneNumber += ValidatePhoneNumber;
            DeliveryCustomer.ValidateAddress += ValidateAddress;

            Reading_DeliveryCustomers();
            Reading_DeliveryCouriers();
            Reading_DeliveryProviders();

            FormManager.QuerryRegistrerCustomer += RegisterCustomer;
            FormManager.QuerryLoginCustomer += LoginUser;
            FormManager.QuerryDeleteAccount += DeleteAcount;

            DeliveryUser.UserChanged += Write_UserList;            

            deliveryCustomers.AddedCustomer += Write_DeliveryCustomers;            
        }


        public static Type LoggedUserType => loggedUser;

        private bool ValidateLogin(string login, ref string message)
        {
            if (string.IsNullOrEmpty(login))
            {
                message = "Login can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9]";

            if (!Regex.IsMatch(login, pattern))
            {
                message = "Incorrect login format.";
                return false;
            }

            if (3 > login.Length || login.Length > 12)
            {
                message = "Login must be from 3 to 12 characters.";
                return false;
            }

            return true;
        }
        private bool ValidatePassword(string password, ref string message)
        {
            if (string.IsNullOrEmpty(password))
            {
                message = "Password can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9]";

            if (!Regex.IsMatch(password, pattern))
            {
                message = "Incorrect password format.";
                return false;
            }

            if (4 > password.Length || password.Length > 14)
            {
                message = "Password must be from 4 to 12 characters.";
                return false;
            }

            return true;
        }
        private bool ValidatePhoneNumber(string phoneNumber, ref string message)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                message = "Phone number can`t be empty.";
                return false;
            }

            if (phoneNumber == "No_Phone_Number")
            {
                return true;
            }

            message = "Invalid phone number";
            return false;
        }
        private bool ValidateAddress(string address, ref string message)
        {
            if (string.IsNullOrEmpty(address))
            {
                message = "Address can`t be empty.";
                return false;
            }

            if (address == "No_Address")
            {
                return true;
            }

            message = "Invalid address";
            return false;
        }

        private bool RegisterCustomer(string login, string password, ref string message)
        {
            bool isCorrectFormat = false;

            isCorrectFormat = ValidateLogin(login, ref message);
            if (!isCorrectFormat)
                return false;

            isCorrectFormat = ValidatePassword(login, ref message);
            if (!isCorrectFormat)
                return false;

            var customerExists = deliveryCustomers.Any(c => c.Login == login) ||
                                 deliveryCouriers.Any(c => c.Login == login) ||
                                 deliveryProviders.Any(p => p.Login == login);    

            if (customerExists)
            {
                message = "This login is already used.";
                return false;
            }

            deliveryCustomers.Add(new DeliveryCustomer(login, password));
            return true;
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
                isDeleted = deliveryCustomers.Remove(customer);
            }
            else if (user is DeliveryCourier courier)
            {
            }
            else if (user is DeliveryProvider provider)
            {
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
                Write_DeliveryCustomers();
            }
            else if (user is DeliveryCourier courier)
            {
            }
            else if (user is DeliveryProvider provider)
            {
            }
        }
        private void Write_DeliveryCustomers()
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(deliveryCustomers.ListUsers, "Customers");

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        private void Reading_DeliveryCustomers()
        {
            bool isRead = false;
            List<DeliveryCustomer> customers = new List<DeliveryCustomer>();

            isRead = DataManager.ReadListFromJson("Customers", ref customers);

            if (!isRead)
            {
                MessageBox.Show("Writting list to json file \"Customers\" went wrong!");
                return;
            }

            deliveryCustomers = new ListDeliveryCustomers(customers);
        }
        private void Reading_DeliveryCouriers()
        {
            bool isRead = false;
            List<DeliveryCourier> couriers = new List<DeliveryCourier>();

            isRead = DataManager.ReadListFromJson("Couriers", ref couriers);

            if (!isRead)
            {
                MessageBox.Show($"Writting list to json file \"Couriers\" went wrong!");
                return;
            }

            deliveryCouriers = new ListDeliveryCouriers(couriers);
        }
        private void Reading_DeliveryProviders()
        {
            bool isRead = false;
            List<DeliveryProvider> providers = new List<DeliveryProvider>();

            isRead = DataManager.ReadListFromJson("Providers", ref providers);

            if (!isRead)
            {
                MessageBox.Show($"Writting list to json file \"Couriers\" went wrong!");
                return;
            }

            deliveryProviders = new ListDeliveryProvider(providers);
        }
    }
}
