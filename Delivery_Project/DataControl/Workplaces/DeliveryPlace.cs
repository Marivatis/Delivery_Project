using Delivery_Project.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces
{
    public class DeliveryPlace : IDeliveryPlaceCode
    {
        private int _placeCode;
        private int _deliveryPrice;
        private string _name;
        private string _address;
        private string _description;
        private PlaceMenu _menu;

        public delegate bool ValidateProperty<T>(T property, ref string message);

        public static event Action? PlaceChanged;

        public static ValidateProperty<int>? ValidateDeliveryPrice;
        public static ValidateProperty<string>? ValidateName;
        public static ValidateProperty<string>? ValidateAddress;
        public static ValidateProperty<string>? ValidateDescription;
        public static ValidateProperty<PlaceMenu>? ValidateMenu;

        public DeliveryPlace() : this(404) { }
        public DeliveryPlace(int placeCode) : this(placeCode, "No_Name", "No_Address", "No_Description") { }
        public DeliveryPlace(int placeCode, string name, string address, string description)
        {
            _placeCode = placeCode;

            _name = name;
            _address = address;
            _description = description;

            _menu = new PlaceMenu();

            PlaceMenu.MenuChanged += MenuChanged;
        }
        
        public int PlaceCode
        {
            get { return _placeCode; }
            set { _placeCode =  value; }
        }

        public int DeliveryPrice
        {
            get
            {
                return _deliveryPrice;
            }
            set
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateDeliveryPrice?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _deliveryPrice = value;
                    PlaceChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateName?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _name = value;
                    PlaceChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateAddress?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _address = value;
                    PlaceChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidateDescription?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _description = value;
                    PlaceChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }
        public PlaceMenu Menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;

                PlaceChanged?.Invoke();
            }
        }

        private void MenuChanged()
        {
            PlaceChanged?.Invoke();
        }
    }
}
