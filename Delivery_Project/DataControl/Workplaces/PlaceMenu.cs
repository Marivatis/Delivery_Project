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

        public PlaceMenu() : this(new List<Product>()) { }
        public PlaceMenu(List<Product> products) 
        {
            _products = products;
        }

        public Product this[int index]
        {
            get => _products[index];
            set => _products[index] = value;
        }

        public int Count => _products.Count;
        public bool IsReadOnly => false;

        public void Add(Product item)
        {
            _products.Add(item);
        }
        public void Clear()
        {
            _products.Clear();
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
            return _products.Remove(item);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return ((IEnumerable<Product>)_products).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_products).GetEnumerator();
        }
    }
}
