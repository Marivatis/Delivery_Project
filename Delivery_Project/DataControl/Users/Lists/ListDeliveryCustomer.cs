using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public class ListDeliveryCustomer : IEnumerable<DeliveryCustomer>, ICollection<DeliveryCustomer>
    {
        private List<DeliveryCustomer> _listCustomers;

        public event EventHandler CustomerAdded;

        public ListDeliveryCustomer() : this(new List<DeliveryCustomer>()) { }
        public ListDeliveryCustomer(List<DeliveryCustomer> listCustomers)
        {
            _listCustomers = listCustomers;
        }

        public List<DeliveryCustomer> ListCustomers
        {
            get
            {
                return _listCustomers;
            }
        }

        public int Count => _listCustomers.Count;
        public bool IsReadOnly => false;

        public void Add(DeliveryCustomer customer)
        {
            _listCustomers.Add(customer);
            CustomerAdded?.Invoke(this, EventArgs.Empty);
        }
        public void Clear()
        {
            _listCustomers?.Clear();
        }
        public bool Contains(DeliveryCustomer customer)
        {
            return _listCustomers.Contains(customer);
        }
        public void CopyTo(DeliveryCustomer[] array, int arrayIndex)
        {
            _listCustomers.CopyTo(array, arrayIndex);
        }
        public bool Remove(DeliveryCustomer customer)
        {
            return _listCustomers.Remove(customer);
        }

        public IEnumerator<DeliveryCustomer> GetEnumerator()
        {
            return ((IEnumerable<DeliveryCustomer>)_listCustomers).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_listCustomers).GetEnumerator();
        }
    }
}
