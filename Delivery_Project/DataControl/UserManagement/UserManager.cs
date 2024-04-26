using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.Forms.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.UserManagement
{
    public class UserManager
    {
        private static Type _loggedUser;

        public UserManager() 
        {
            FormManager.Querry_LoginAttempt += LoginUser;
        }

        public static Type LoggedUser
        {
            get
            {
                return _loggedUser;
            }
        }

        private bool LoginUser(string login, string password)
        {
            //MessageBox.Show($"Login: {login}, password: {password}");
            if (login == "cust" &&  password == "cust")
            {
                _loggedUser = typeof(DeliveryCustomer);
                return true;
            }
            else if (login == "cour" && password == "cour")
            {
                _loggedUser = typeof(DeliveryCourier);
                return true;
            }
            else if (login == "prov" && password == "prov")
            {
                _loggedUser = typeof(DeliveryProvider);
                return true;
            }

            return false;
        }
    }
}
