using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Users.Lists
{
    public abstract class ListDeliveryUser<T> : IEnumerable<T>, ICollection<T> 
        where T : DeliveryUser
    {
        protected List<T> _listUsers;

        public event Action<DeliveryUser>? AddedUser;

        public ListDeliveryUser() : this(new List<T>()) { }
        public ListDeliveryUser(List<T> listCustomers)
        {
            _listUsers = listCustomers;
        }

        public List<T> List => _listUsers;

        public T this[int index]
        {
            get => _listUsers[index];
            set => _listUsers[index] = value;
        }

        public int Count => _listUsers.Count;
        public bool IsReadOnly => false;

        public virtual void Add(T customer)
        {
            _listUsers.Add(customer);
            AddedUser?.Invoke(customer);
        }
        public void Clear()
        {
            _listUsers?.Clear();
        }
        public virtual bool Contains(T customer)
        {
            return _listUsers.Contains(customer);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            _listUsers.CopyTo(array, arrayIndex);
        }
        public virtual bool Remove(T customer)
        {
            return _listUsers.Remove(customer);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_listUsers).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_listUsers).GetEnumerator();
        }

    }
}
