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
        private string _address = "No_Address";

        public DeliveryCustomer() : base() { }
        public DeliveryCustomer(string login, string password) : base(login, password) { }
        public DeliveryCustomer(string login, string password, string phoneNumber) : base(login, password, phoneNumber) { }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
