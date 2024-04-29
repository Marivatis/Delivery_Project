using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Lists
{
    public class ListDeliveryPlaces : IEnumerable<DeliveryPlace>, ICollection<DeliveryPlace>
    {
        private List<DeliveryPlace> _listPlaces;

        public event Action? AddedPlace;

        public ListDeliveryPlaces() : this(new List<DeliveryPlace>()) { }
        public ListDeliveryPlaces(List<DeliveryPlace> listPlaces)
        {
            _listPlaces = listPlaces;
        }

        public List<DeliveryPlace> List => _listPlaces;

        public int Count => _listPlaces.Count;
        public bool IsReadOnly => false;

        public void Add(DeliveryPlace item)
        {
            _listPlaces.Add(item);
            AddedPlace?.Invoke();
        }
        public void Clear()
        {
            _listPlaces.Clear();
        }
        public bool Contains(DeliveryPlace item)
        {
            return _listPlaces.Contains(item);
        }
        public void CopyTo(DeliveryPlace[] array, int arrayIndex)
        {
            _listPlaces.CopyTo(array, arrayIndex);
        }
        public bool Remove(DeliveryPlace item)
        {
            return _listPlaces.Remove(item);
        }

        public IEnumerator<DeliveryPlace> GetEnumerator()
        {
            return ((IEnumerable<DeliveryPlace>)_listPlaces).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_listPlaces).GetEnumerator();
        }
    }
}
