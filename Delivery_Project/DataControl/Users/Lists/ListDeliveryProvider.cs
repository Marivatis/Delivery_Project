using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public class ListDeliveryProvider : ListDeliveryUser<DeliveryProvider>
    {
        public ListDeliveryProvider() : this(new List<DeliveryProvider>()) { }
        public ListDeliveryProvider(List<DeliveryProvider> providers) : base(providers) { }
    }
}
