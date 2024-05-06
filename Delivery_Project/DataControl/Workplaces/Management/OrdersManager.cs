using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Workplaces.Lists;
using Delivery_Project.DataControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery_Project.DataControl.Users;

namespace Delivery_Project.DataControl.Workplaces.Management
{
    public class OrdersManager
    {
        private ListDeliveryOrders deliveryOrders;

        public static event EventHandler<OrderStatusEventArgs>? OrderStatusChanged;

        public OrdersManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            Read_DeliveryOrders();

            ListDeliveryOrders.OrdersListChanged += ListDeliveryOrders_OrdersListChanged;

            FormManager.QuerryMakeOrder += MakeOrder;
            FormManager.QuerryDeclineOrder += DeclineOrder;
            FormManager.QuerryGetActiveOrder += GetActiveOrder;
            FormManager.QuerryGetOrdersList += GetWaitingOrdersList;
            FormManager.QuerryGetTakenOrder += GetTakenOrder;
            FormManager.QuerryOrderOnTheWay += OrderOnTheWay;
            FormManager.QuerryFinishOrder += FinishOrder;
            
            FormManager.QuerryTakeOrder += TakeOrder;
        }

        private void ListDeliveryOrders_OrdersListChanged()
        {
            deliveryOrders = new ListDeliveryOrders(deliveryOrders.OrderBy(o => o.OrderStatus).ToList());

            Write_DeliveryOrders();
        }

        private bool MakeOrder(DeliveryOrder order, ref string message)
        {
            if (IsAnyActiveOrder(order.CustomerLogin)) 
            {
                message = "You already have an active order.";
                return false;
            }

            deliveryOrders.Add(order);
            OrderStatusChanged?.Invoke(this, new OrderStatusEventArgs(order.OrderStatus, order.CustomerLogin));

            return true;
        }
        private bool DeclineOrder(string customerLogin, ref string message)
        {
            if (string.IsNullOrEmpty(customerLogin))
            {
                message = "Customer login can`t be null.";
                return false;
            }

            if (!IsAnyActiveOrder(customerLogin))
            {
                message = "You don`t have any active orders to decline.";
                return false;
            }

            DeliveryOrder order = deliveryOrders.First(o => o.CustomerLogin == customerLogin);

            if (order is null)
            {
                message = "Finding order in roder list error.";
                return false;
            }

            order.OrderStatus = DeliveryOrderStatus.Declined;
            return true;
        }
        private bool TakeOrder(DeliveryOrder? order, DeliveryCourier courier, ref string message)
        {
            if (order is null)
            {
                message = "Choose any order before take one.";
                return false;
            }

            if (IsAnyTakenOrder(order.CustomerLogin))
            {
                message = "This ordes`s already been taken.";
                return false;
            }

            order.OrderStatus = DeliveryOrderStatus.Accepted;
            order.CourierLogin = courier.Login;
            order.CourierPhone = courier.PhoneNumber;

            return true;
        }
        private bool OrderOnTheWay(string courierLogin)
        {
            DeliveryOrder? order = deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
                                                                      o.OrderStatus == DeliveryOrderStatus.Accepted);

            if (order is null)
                return false;

            order.OrderStatus = DeliveryOrderStatus.OnTheWay;
            return true;
        }
        private bool FinishOrder(string courierLogin, ref string message)
        {
            DeliveryOrder? order = deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
                                                                      o.OrderStatus == DeliveryOrderStatus.OnTheWay);

            if (order is null)
            {
                message = "Can`t find your order.";
                return false;
            }

            message = "Order successfully delivered.";
            order.OrderStatus = DeliveryOrderStatus.Delivered;
            return true;
        }

        private DeliveryOrder? GetActiveOrder(string customerLogin)
        {
            if (!IsAnyActiveOrder(customerLogin))
                return null;

            return deliveryOrders.First(o => o.CustomerLogin == customerLogin);
        }
        private DeliveryOrder? GetTakenOrder(string courierLogin)
        {
            return deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
                                                      o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                                      o.OrderStatus == DeliveryOrderStatus.OnTheWay);
        }

        private List<DeliveryOrder>? GetWaitingOrdersList()
        {
            return deliveryOrders.Where(o => o.OrderStatus == DeliveryOrderStatus.Waiting).ToList();
        }

        private bool IsAnyActiveOrder(string customerLogin)
        {
            return deliveryOrders.Any(o => o.CustomerLogin == customerLogin &&
                                           o.OrderStatus == DeliveryOrderStatus.Waiting ||
                                           o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                           o.OrderStatus == DeliveryOrderStatus.OnTheWay);
        }
        private bool IsAnyTakenOrder(string customerLogin)
        {
            return deliveryOrders.Any(o => o.CustomerLogin == customerLogin &&
                                           o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                           o.OrderStatus == DeliveryOrderStatus.OnTheWay);
        }

        private void Write_DeliveryOrders()
        {
            Write_List(deliveryOrders.List, "Orders");
        }
        private void Write_List<T>(List<T> list, string fileName)
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(list, fileName);

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        private void Read_DeliveryOrders()
        {
            bool isRead = false;
            List<DeliveryOrder> orders = new List<DeliveryOrder>();

            isRead = DataManager.ReadListFromJson("Orders", ref orders);

            if (!isRead)
            {
                MessageBox.Show($"Reading list from json file \"Orders\" went wrong!");
                return;
            }

            deliveryOrders = new ListDeliveryOrders(orders);
        }
    }
}
