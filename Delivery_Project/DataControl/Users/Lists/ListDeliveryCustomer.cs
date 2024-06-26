﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public class ListDeliveryCustomers : ListDeliveryUser<DeliveryCustomer>
    {
        public ListDeliveryCustomers() : this(new List<DeliveryCustomer>()) { }
        public ListDeliveryCustomers(List<DeliveryCustomer> customers) : base(customers) { }
    }
}
