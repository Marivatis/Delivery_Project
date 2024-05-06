using Delivery_Project.DataControl.DataValidation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces
{
    public class PlaceMenu : IEnumerable<Product>, ICollection<Product>
    {
        private List<Product> _products;

        public static event Action? MenuChanged;

        public PlaceMenu() : this(new List<Product>()) { }
        public PlaceMenu(List<Product> products)
        {
            _products = products;
            
            Product.ValidateName += ValidateProductName;
            Product.ValidatePrice += ProductDataValidator.ValidatePrice;
            Product.ValidateDescription += ProductDataValidator.ValidateDescription;

            Product.ProductChanged += ProductChanged;
        }

        public Product this[int index]
        {
            get => _products[index];
            set => _products[index] = value;
        }

        public List<Product> List => _products;

        public int Count => _products.Count;
        public bool IsReadOnly => false;

        public void Add(Product item)
        {
            string message = "Something went wrong.";

            if (!ValidateProduct(item, ref message))
                throw new InvalidDataException(message);

            _products.Add(item);           

            MenuChanged?.Invoke();
        }
        public void Clear()
        {
            _products.Clear();
            MenuChanged?.Invoke();
        }
        public bool Contains(Product item)
        {
            return _products.Contains(item);
        }
        public void CopyTo(Product[] array, int arrayIndex)
        {
            _products.CopyTo(array, arrayIndex);
        }
        public bool Remove(Product item)
        {
            bool isRemoved = _products.Remove(item);

            if (isRemoved)
                MenuChanged?.Invoke();

            return isRemoved;
        }
        public bool Remove(Func<Product, bool> predicate)
        {
            Product? product = _products.FirstOrDefault(predicate);

            if (product == null)
                return false;

            return _products.Remove(product);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return ((IEnumerable<Product>)_products).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_products).GetEnumerator();
        }

        public bool ValidateProduct(Product product)
        {
            string message = string.Empty;

            return ValidateProduct(product, ref message);
        }
        public bool ValidateProduct(Product product, ref string message)
        {
            bool isValid = false;

            isValid = ValidateProductName(product.Name, ref message) &&
                      ProductDataValidator.ValidatePrice(product.Price, ref message) &&
                      ProductDataValidator.ValidateDescription(product.Description, ref message);

            if (!isValid)
                return false;

            return true;
        }
        public bool ValidateProductName(string productName, ref string message)
        {
            bool isValid = ProductDataValidator.ValidateName(productName, ref message);

            if (!isValid)
                return false;

            isValid = _products.Any(p => p.Name == productName);

            if (isValid)
            {
                message = "This product name`s already taken.";
                return false;
            }

            return true;
        }

        private void ProductChanged()
        {
            MenuChanged?.Invoke();
        }
    }
}
