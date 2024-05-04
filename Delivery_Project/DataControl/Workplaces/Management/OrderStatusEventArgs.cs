using Delivery_Project.DataControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Management
{
    public class OrderStatusEventArgs : EventArgs
    {
        public DeliveryOrderStatus Status { get; }
        public string CustomerLogin { get; }

        public OrderStatusEventArgs(DeliveryOrderStatus status, string customerLogin)
        {
            Status = status;
            CustomerLogin = customerLogin;
        }
    }
}
