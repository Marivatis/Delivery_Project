using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces
{
    public class ProductCart
    {
        private Dictionary<string, int> _cart;
        private int _productPrice;

        public static event Action? CartChanged;

        public ProductCart() 
        {
            _cart = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Cart => _cart;

        public int ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public int Count => ProductCount();
        
        public void Add(Product item)
        {
            if (_cart.ContainsKey(item.Name))
                _cart[item.Name]++;
            else
                _cart.Add(item.Name, 1);

            _productPrice += item.Price;
            CartChanged?.Invoke();
        }
        public bool Remove(Product item)
        {
            if (!_cart.ContainsKey(item.Name))
                return false;

            if (_cart[item.Name] > 1)
                _cart[item.Name]--;
            else
                _cart.Remove(item.Name);

            _productPrice -= item.Price;
            CartChanged?.Invoke();
            return true;
        }
        public void Clear()
        {
            _cart.Clear();

            _productPrice = 0;
            CartChanged?.Invoke();
        }
        public int ProductCount()
        {
            int count = 0;

            foreach (var key in _cart)
            {
                count += key.Value;
            }

            return count;
        }

        public override string ToString()
        {
            string info = string.Empty;

            foreach (var key in  _cart)
            {
                info += KeyToString(key) + "\n";   
            }

            return info;
        }
        public string KeyToString(KeyValuePair<string, int> key)
        {
            return $"{key.Value}x {key.Key};";
        }
    }
}
