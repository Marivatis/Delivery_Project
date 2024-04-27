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

        public DeliveryCourier() : this("No_Login", "No_Password") { }
        public DeliveryCourier(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryCourier(string login, string password, string phoneNumber) : this(login, password, phoneNumber, "No_Card_Number") { }
        public DeliveryCourier(string login, string password, string phoneNumber, string cardNumber) : base(login, password, phoneNumber)
        {
            _cardNumber = cardNumber;
        }

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
    }
}
