using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public class ListDeliveryCustomers : ListDeliveryUser<DeliveryCustomer>
    {
        public event EventHandler AddedCustomer;

        public ListDeliveryCustomers() : this(new List<DeliveryCustomer>()) { }
        public ListDeliveryCustomers(List<DeliveryCustomer> customers) : base(customers) { }

        public override void Add(DeliveryCustomer customer)
        {
            base.Add(customer);
            AddedCustomer?.Invoke(this, EventArgs.Empty);
        }
    }
}
