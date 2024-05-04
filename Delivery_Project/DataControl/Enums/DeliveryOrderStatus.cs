using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Enums
{
    public enum DeliveryOrderStatus
    {
        Waiting = 0,
        Accepted,
        OnTheWay,
        Delivered,
        Declined
    }
}
