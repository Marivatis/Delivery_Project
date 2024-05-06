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
        private DeliveryOrderStatus orderStatus;
        private string courierLogin;
        private string courierPhone;
        private string customerLogin;
        private string customerPhone;
        private string customerAddress;
        private string providerPlaceName;
        private string providerPlaceAddress;
        private int customerPayment;
        private int courierEarning;
        private ProductCart cart;

        public static event EventHandler<OrderStatusEventArgs>? OrderStatusChanged;

        public DeliveryOrder() { }
        public DeliveryOrder(DeliveryCustomer customer, DeliveryPlace place, ProductCart cart) 
        {
            customerLogin = customer.Login;
            customerPhone = customer.PhoneNumber;
            customerAddress = customer.Address;
            providerPlaceName = place.Name;
            providerPlaceAddress = place.Address;
            customerPayment = cart.ProductPrice + place.DeliveryPrice;
            courierEarning = CalculateCourierEarning();
            this.cart = cart;
        }

        public DeliveryOrderStatus OrderStatus
        {
            get { return orderStatus; }
            set 
            { 
                orderStatus = value;
                OrderStatusChanged?.Invoke(this, new OrderStatusEventArgs(orderStatus, customerLogin));
            }
        }
        public string CourierLogin
        {
            get { return courierLogin; }
            set { courierLogin = value; }
        }
        public string CourierPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        public string CustomerLogin
        {
            get { return customerLogin; }
            set { customerLogin = value; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        public string ProviderPlaceName
        {
            get { return providerPlaceName; }
            set { providerPlaceName = value; }
        }
        public string ProviderPlaceAddress
        {
            get { return providerPlaceAddress; }
            set { providerPlaceAddress = value; }
        }
        public int CustomerPayment
        {
            get { return customerPayment; }
            set { customerPayment = value; }
        }
        public int CourierEarning
        {
            get { return courierEarning; }
            set { courierEarning = value; }
        }
        public ProductCart OrderCart
        {
            get { return cart; }
            set { cart = value; }
        }

        private int CalculateCourierEarning()
        {
            int courierEarning = 100;

            courierEarning += (int)(customerPayment * 0.2);

            if (courierEarning > 400)
                courierEarning = 400;

            return courierEarning;
        }
    }
}
