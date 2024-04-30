using Delivery_Project.DataControl.DataValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces
{
    public class Product
    {
        private string _name;
        private int _price;
        private string _description;

        public delegate bool ValidateProperty<T>(T property, ref string message);

        public static event Action? ProductChanged;

        public static ValidateProperty<string>? ValidateName;
        public static ValidateProperty<int>? ValidatePrice;
        public static ValidateProperty<string>? ValidateDescription;

        public Product() : this("No_Product_Name") { }
        public Product(string name) : this(name, 100) { }
        public Product(string name, int price) : this(name, price, "No_Description") { }
        public Product(string name, int price, string description) 
        {
            _name = name;
            _price = price;
            _description = description;
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
                    ProductChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                bool isValid = false;
                string message = "Something went wrong.";

                isValid = ValidatePrice?.Invoke(value, ref message) ?? false;

                if (isValid)
                {
                    _price = value;
                    ProductChanged?.Invoke();
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
                    ProductChanged?.Invoke();
                }
                else
                {
                    throw new InvalidDataException(message);
                }
            }
        }


    }
}
