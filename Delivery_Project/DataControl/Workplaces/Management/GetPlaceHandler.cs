using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Management
{
    public delegate void GetPlaceHandler(int placeCode, out DeliveryPlace? place);
}
