using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users
{
    public class DeliveryCourier : DeliveryUser
    {
        private string _cardNumber;

        public static ValidateProperty<string>? ValidateCardNumber;

        public DeliveryCourier() : this("No_Login", "No_Password") { }
        public DeliveryCourier(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryCourier(string login, string password, string phoneNumber) 
            : this(login, password, phoneNumber, "No_Card_Number") { }
        public DeliveryCourier(string login, string password, string phoneNumber, string cardNumber) : base(login, password, phoneNumber)
        {
            _cardNumber = cardNumber;
        }

        public string CardNumber
        {
            get 
            {
                return _cardNumber; 
            }
            set 
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateCardNumber?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _cardNumber = value;
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
