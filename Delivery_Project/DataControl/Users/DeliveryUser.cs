using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users
{
    public abstract class DeliveryUser
    {
        protected string _login;
        protected string _password;
        protected string _phoneNumber;

        public DeliveryUser() : this("No_login", "No_Password", "No_Phone_Number") { }
        public DeliveryUser(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryUser(string login, string password, string phoneNumber)
        {
            _login = login;
            _password = password;
            _phoneNumber = phoneNumber;
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
    }
}
