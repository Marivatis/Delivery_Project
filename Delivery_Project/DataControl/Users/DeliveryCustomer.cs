using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users
{
    public class DeliveryCustomer : DeliveryUser
    {
        private string _address;

        public static ValidateProperty<string>? ValidateAddress;

        public DeliveryCustomer() : this("No_Login", "No_Password") { }
        public DeliveryCustomer(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryCustomer(string login, string password, string phoneNumber) : this(login, password, phoneNumber, "No_Address") { }
        public DeliveryCustomer(string login, string password, string phoneNumber, string address) : base(login, password, phoneNumber) 
        {
            _address = address;
        }

        public string Address
        {
            get 
            {
                return _address; 
            }
            set 
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateAddress?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _address = value;
                    RaiseEvent_UserChanged(this);
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }


    }
}
