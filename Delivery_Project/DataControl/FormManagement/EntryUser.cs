using Delivery_Project.DataControl.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.FormManagement
{
    public delegate bool EntryUser(string login, string password, ref string message);

    public delegate string LoginCustomer(string login, string password, out DeliveryUser user);
}
