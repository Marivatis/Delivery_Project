using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Users.Lists;
using Delivery_Project.Forms.Entry;
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
            Reading_DeliveryCustomers();
            Reading_DeliveryCouriers();
            Reading_DeliveryProviders();

            FormManager.QuerryRegistrerCustomer += RegisterCustomer;
            FormManager.QuerryLoginCustomer += LoginUser;

            deliveryCustomers.AddedCustomer += Writting_DeliveryCustomers;            
        }


        public static Type LoggedUserType => loggedUser;

        private bool RegisterCustomer(string login, string password)
        {
            string message = string.Empty;
            return RegisterCustomer(login, password, ref message);
        }
        private bool RegisterCustomer(string login, string password, ref string message)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                message = "Login or password can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9]";

            if (!Regex.IsMatch(login, pattern))
            {
                message = "Incorrect login format.";
                return false;
            }
            else if (!Regex.IsMatch(password, pattern))
            {
                message = "Incorrect password format.";
                return false;
            }

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
            Reading_DeliveryCustomers();
            Reading_DeliveryCouriers();
            Reading_DeliveryProviders();

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

        private void Writting_DeliveryCustomers(object? sender, EventArgs e)
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
