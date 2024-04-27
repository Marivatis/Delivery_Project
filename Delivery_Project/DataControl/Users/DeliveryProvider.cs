using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users
{
    public class DeliveryProvider : DeliveryUser
    {        
        public DeliveryProvider() : this("No_Login", "No_Password") { }
        public DeliveryProvider(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryProvider(string login, string password, string phoneNumber) : base(login, password, phoneNumber) { }
    }
}
