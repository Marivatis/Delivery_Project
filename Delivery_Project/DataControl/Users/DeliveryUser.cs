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
        protected string _password ;
        protected string _phoneNumber;

        public delegate bool ValidateProperty<T>(T property, ref string message);

        public static event Action<DeliveryUser>? UserChanged;
        public static ValidateProperty<string>? ValidateLogin;
        public static ValidateProperty<string>? ValidatePassword;
        public static ValidateProperty<string>? ValidatePhoneNumber;

        public DeliveryUser() : this("No_Login", "No_Password", "No_Phone_Number") { }
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
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateLogin?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _login = value;
                    UserChanged?.Invoke(this);
                }
                else
                {
                    throw new InvalidDataException(message);
                }
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
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidatePassword?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _password = value;
                    UserChanged?.Invoke(this);
                }
                else
                {
                    throw new InvalidDataException(message);
                }
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
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidatePhoneNumber?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _phoneNumber = value;
                    UserChanged?.Invoke(this);
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }

        protected void RaiseEvent_UserChanged(DeliveryUser user)
        {
            UserChanged?.Invoke(user);
        }
    }
}
