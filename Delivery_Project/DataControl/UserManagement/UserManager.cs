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
        private ListDeliveryCustomer deliveryCustomers;

        private static Type loggedUser;

        public UserManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            Reading_DeliveryCustomers();

            FormManager.QuerryRegistration += RegisterCustomer;
            FormManager.QuerryLogin += LoginUser;

            deliveryCustomers.CustomerAdded += Writting_DeliveryCustomers;
            
        }


        public static Type LoggedUser => loggedUser;

        public bool RegisterCustomer(string login, string password)
        {
            string message = string.Empty;
            return RegisterCustomer(login, password, ref message);
        }
        public bool RegisterCustomer(string login, string password, ref string message)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                message = "Login or password can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9 ]+$";

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

            deliveryCustomers.Add(new DeliveryCustomer(login, password));
            return true;
        }

        public bool LoginUser(string login, string password)
        {
            foreach (var customer in deliveryCustomers)
            {
                if (customer.Login == login && customer.Password == password)
                {
                    loggedUser = typeof(DeliveryCustomer);
                    return true;
                }
            }

            return false;
        }

        private void Writting_DeliveryCustomers(object? sender, EventArgs e)
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(deliveryCustomers.ListCustomers, "Customers");

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
                MessageBox.Show("Writting list to json file went wrong!");
                return;
            }

            deliveryCustomers = new ListDeliveryCustomer(customers);
        }
    }
}
