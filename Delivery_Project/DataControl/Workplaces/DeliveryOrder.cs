using Delivery_Project.DataControl.Enums;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Workplaces.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces
{
    public class DeliveryOrder
    {
        private DeliveryOrderStatus _orderStatus;
        private string _courierLogin;
        private string _courierPhone;
        private string _customerLogin;
        private string _customerPhone;
        private string _customerAddress;
        private string _providerPlaceName;
        private string _providerPlaceAddress;
        private int _providerPlaceDeliveryPrice;
        private int _providerPlaceDeliveryPercent;
        private int _customerPayment;
        private int _courierEarning;
        private ProductCart _cart;

        public static event EventHandler<OrderStatusEventArgs>? OrderStatusChanged;

        public DeliveryOrder() { }
        public DeliveryOrder(DeliveryCustomer customer, DeliveryPlace place, ProductCart cart) 
        {
            _customerLogin = customer.Login;
            _customerPhone = customer.PhoneNumber;
            _customerAddress = customer.Address;
            _providerPlaceName = place.Name;
            _providerPlaceAddress = place.Address;
            _providerPlaceDeliveryPrice = place.DeliveryPrice;
            _providerPlaceDeliveryPercent = place.DeliveryPercent;
            _customerPayment = cart.ProductPrice + place.DeliveryPrice;
            _cart = cart;

            _courierEarning = CalculateCourierEarning();
        }

        public DeliveryOrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set 
            { 
                _orderStatus = value;
                OrderStatusChanged?.Invoke(this, new OrderStatusEventArgs(_orderStatus, _customerLogin));
            }
        }
        public string CourierLogin
        {
            get { return _courierLogin; }
            set { _courierLogin = value; }
        }
        public string CourierPhone
        {
            get { return _courierPhone; }
            set { _courierPhone = value; }
        }
        public string CustomerLogin
        {
            get { return _customerLogin; }
            set { _customerLogin = value; }
        }
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; }
        }
        public string CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        public string ProviderPlaceName
        {
            get { return _providerPlaceName; }
            set { _providerPlaceName = value; }
        }
        public string ProviderPlaceAddress
        {
            get { return _providerPlaceAddress; }
            set { _providerPlaceAddress = value; }
        }
        public int CustomerPayment
        {
            get { return _customerPayment; }
            set { _customerPayment = value; }
        }
        public int CourierEarning
        {
            get { return _courierEarning; }
            set { _courierEarning = value; }
        }
        public ProductCart OrderCart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        private int CalculateCourierEarning()
        {
            return (int)(_providerPlaceDeliveryPrice + _cart.ProductPrice * _providerPlaceDeliveryPercent / 100.0);
        }
    }
}
