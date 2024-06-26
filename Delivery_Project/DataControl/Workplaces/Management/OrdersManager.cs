﻿using Delivery_Project.DataControl.DataManagement;
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
        public ListDeliveryOrders _deliveryOrders;

        public static event EventHandler<OrderStatusEventArgs>? OrderStatusChanged;

        public OrdersManager()
        {
            _deliveryOrders = new ListDeliveryOrders();

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

        // Sorts and writes orders list when it`s been changed
        private void ListDeliveryOrders_OrdersListChanged()
        {
            _deliveryOrders = new ListDeliveryOrders(_deliveryOrders.OrderBy(o => o.OrderStatus).ToList());

            Write_DeliveryOrders();
        }

        // Orders handler unit
        public bool MakeOrder(DeliveryOrder order, ref string message)
        {
            if (IsAnyActiveOrder(order.CustomerLogin)) 
            {
                message = "You already have an active order.";
                return false;
            }

            _deliveryOrders.Add(order);
            OrderStatusChanged?.Invoke(this, new OrderStatusEventArgs(order.OrderStatus, order.CustomerLogin));

            return true;
        }
        public bool DeclineOrder(string customerLogin, ref string message)
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

            DeliveryOrder order = _deliveryOrders.First(o => o.CustomerLogin == customerLogin);

            if (order is null)
            {
                message = "Finding order in roder list error.";
                return false;
            }

            order.OrderStatus = DeliveryOrderStatus.Declined;
            return true;
        }
        public bool TakeOrder(DeliveryOrder order, DeliveryCourier courier, ref string message)
        {
            if (order is null)
            {
                message = "Choose any order before take one.";
                return false;
            }

            if (!IsAnyActiveOrder(order.CustomerLogin))
            {
                message = "This customer have no active orders.";
                return false;
            }

            if (IsAnyTakenOrder(order.CustomerLogin))
            {
                message = "This ordes`s already been taken.";
                return false;
            }

            order.CourierLogin = courier.Login;
            order.CourierPhone = courier.PhoneNumber;
            order.OrderStatus = DeliveryOrderStatus.Accepted;

            return true;
        }
        public bool OrderOnTheWay(string courierLogin)
        {
            DeliveryOrder? order = _deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
                                                                      o.OrderStatus == DeliveryOrderStatus.Accepted);

            if (order is null)
                return false;

            order.OrderStatus = DeliveryOrderStatus.OnTheWay;
            return true;
        }
        public bool FinishOrder(string courierLogin, ref string message)
        {
            DeliveryOrder? order = _deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
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

        // Clears all orders manager data, even in files
        public void Clear()
        {
            _deliveryOrders.Clear();

            Write_DeliveryOrders();
        }

        // Returns active customer order with given login
        private DeliveryOrder? GetActiveOrder(string customerLogin)
        {
            if (!IsAnyActiveOrder(customerLogin))
                return null;

            return _deliveryOrders.FirstOrDefault(o => o.CustomerLogin == customerLogin);
        }
        // Return taken courier order with given login
        private DeliveryOrder? GetTakenOrder(string courierLogin)
        {
            return _deliveryOrders.FirstOrDefault(o => o.CourierLogin == courierLogin &&
                                                      o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                                      o.OrderStatus == DeliveryOrderStatus.OnTheWay);
        }

        // Returns list of orders with Waiting status
        private List<DeliveryOrder>? GetWaitingOrdersList()
        {
            return _deliveryOrders.Where(o => o.OrderStatus == DeliveryOrderStatus.Waiting).ToList();
        }

        // Returns true if customer with given login has any active order
        private bool IsAnyActiveOrder(string customerLogin)
        {
            return _deliveryOrders.Any(o => o.CustomerLogin == customerLogin &&
                                           (o.OrderStatus == DeliveryOrderStatus.Waiting ||
                                           o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                           o.OrderStatus == DeliveryOrderStatus.OnTheWay));
        }
        // Returns true if customer with given login has any taken order
        private bool IsAnyTakenOrder(string customerLogin)
        {
            return _deliveryOrders.Any(o => o.CustomerLogin == customerLogin &&
                                           o.OrderStatus == DeliveryOrderStatus.Accepted ||
                                           o.OrderStatus == DeliveryOrderStatus.OnTheWay);
        }

        // Writes field _deliveryOrders to json
        private void Write_DeliveryOrders()
        {
            Write_List(_deliveryOrders.List, "Orders");
        }
        // Writes given list to json
        private static void Write_List<T>(List<T> list, string fileName)
        {
            bool isWritten = DataManager.WriteListToJson(list, fileName);

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        // Reads field _deliveryOrders from json
        private void Read_DeliveryOrders()
        {
            List<DeliveryOrder> orders = new();

            bool isRead = DataManager.ReadListFromJson("Orders", ref orders);

            if (!isRead)
            {
                MessageBox.Show($"Reading list from json file \"Orders\" went wrong!");
                return;
            }

            _deliveryOrders = new ListDeliveryOrders(orders);
        }
    }
}
