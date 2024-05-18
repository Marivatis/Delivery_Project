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
        private int _productsPrice;

        public static event Action? CartChanged;

        public ProductCart() 
        {
            _cart = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Cart => _cart;

        public int ProductPrice
        {
            get { return _productsPrice; }
            set { _productsPrice = value; }
        }
        public int Count => СountProducts();
        
        public void Add(Product product)
        {
            if (_cart.ContainsKey(product.Name))
                _cart[product.Name]++;
            else
                _cart.Add(product.Name, 1);

            _productsPrice += product.Price;
            CartChanged?.Invoke();
        }
        public bool Remove(Product product)
        {
            if (!_cart.ContainsKey(product.Name))
                return false;

            if (_cart[product.Name] > 1)
                _cart[product.Name]--;
            else
                _cart.Remove(product.Name);

            _productsPrice -= product.Price;
            CartChanged?.Invoke();
            return true;
        }
        public void Clear()
        {
            _cart.Clear();

            _productsPrice = 0;
            CartChanged?.Invoke();
        }
        public int СountProducts()
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
