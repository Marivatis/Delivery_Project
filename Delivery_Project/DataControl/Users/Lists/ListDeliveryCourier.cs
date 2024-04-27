using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public class ListDeliveryCouriers : ListDeliveryUser<DeliveryCourier>
    {
        public ListDeliveryCouriers() : this(new List<DeliveryCourier>()) { }
        public ListDeliveryCouriers(List<DeliveryCourier> customers) : base(customers) { }
    }
}
