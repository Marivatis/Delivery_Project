using Delivery_Project.DataControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Management
{
    public delegate bool OrderHandler(DeliveryOrder order, ref string message);

    public delegate bool DeclineOrder(string customerLogin, ref string message);
}
