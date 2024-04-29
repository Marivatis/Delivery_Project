using Delivery_Project.DataControl.Interfaces;
using Delivery_Project.DataControl.Workplaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users
{
    public class DeliveryProvider : DeliveryUser, IDeliveryPlaceCode
    {
        private int _placeCode;

        public DeliveryProvider() : this("No_Login", "No_Password") { }
        public DeliveryProvider(string login, string password) : this(login, password, "No_Phone_Number") { }
        public DeliveryProvider(string login, string password, string phoneNumber) : base(login, password, phoneNumber) 
        {
        }

        public int PlaceCode
        {
            get { return _placeCode; }
            set { _placeCode = value; }
        }

        public bool ConnectPlace(DeliveryPlace place, ref string message)
        {
            if (place is null)
            {
                message = "Place can`t be null.";
                return false;
            }

            if (_placeCode != 0)
            {
                message = "This provider`s already connected to other place.";
                return false;
            }

            if (_placeCode == place.PlaceCode || _placeCode == 0)
            {
                _placeCode = place.PlaceCode;

                message = "Connect to place successfull.";
                return true;
            }
            else
            {
                message = "Different place code";
                return false;
            }
        }
    }
}
