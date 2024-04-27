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
            get => _name;
            set => _name = value;
        }
        public int Price
        {
            get => _price;
            set => _price = value;
        }
        public string Description
        {
            get => _description; 
            set => _description = value;
        }
    }
}
