using Delivery_Project.DataControl.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.FormManagement
{
    public delegate bool EntryCustomer(string login, string password, ref string message);
    public delegate bool RegisterCourier(DeliveryUser user, string cardNumber, ref string message);
    public delegate bool RegisterProvider(DeliveryUser user, string secretWord,  ref string message);

    public delegate string LoginUser(string login, string password, out DeliveryUser? user);
}
