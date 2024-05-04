using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Lists
{
    public class ListDeliveryOrders : IEnumerable<DeliveryOrder>, ICollection<DeliveryOrder>
    {
        private List<DeliveryOrder> _orders;

        public static event Action? OrdersListChanged;

        public ListDeliveryOrders() : this(new List<DeliveryOrder>()) { }
        public ListDeliveryOrders(List<DeliveryOrder> deliveryOrders)
        {
            _orders = deliveryOrders;

            DeliveryOrder.OrderStatusChanged += DeliveryOrder_OrderStatusChanged;
        }        

        public List<DeliveryOrder> List => _orders;

        public int Count => _orders.Count;
        public bool IsReadOnly => false;

        public void Add(DeliveryOrder item)
        {
            _orders.Add(item);
            OrdersListChanged?.Invoke();
        }
        public void Clear()
        {
            _orders.Clear();
            OrdersListChanged?.Invoke();
        }
        public bool Contains(DeliveryOrder item)
        {
            return _orders.Contains(item);
        }
        public void CopyTo(DeliveryOrder[] array, int arrayIndex)
        {
            _orders.CopyTo(array, arrayIndex);
        }
        public bool Remove(DeliveryOrder item)
        {
            bool isRemoved = _orders.Remove(item);

            if (isRemoved)
                OrdersListChanged?.Invoke();

            return isRemoved;
        }

        public IEnumerator<DeliveryOrder> GetEnumerator()
        {
            return ((IEnumerable<DeliveryOrder>)_orders).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_orders).GetEnumerator();
        }

        private void DeliveryOrder_OrderStatusChanged(object? sender, Management.OrderStatusEventArgs e)
        {
            OrdersListChanged?.Invoke();
        }
    }
}
