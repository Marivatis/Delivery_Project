using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.Enums;
using Delivery_Project.DataControl.UserManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.DataControl.Workplaces.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Tests.Delivery_Project.DataControl
{
    [TestClass]
    public class OrdersManagerTests
    {
        private OrdersManager _ordersManager;
        private PlacesManager _placesManager;
        private UserManager _userManager;

        [TestInitialize]
        public void Tests_Initialize()
        {
            DataManager dataManager = new();

            _ordersManager = new OrdersManager();
            _placesManager = new PlacesManager();
            _userManager = new UserManager();
        }

        [TestCleanup]
        public void Tests_Cleanup()
        {
            _ordersManager.Clear();
            _userManager.Clear();
            _placesManager.Clear();
        }

        [TestMethod]
        public void MakeOrder_NoActiveOrder()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");
            DeliveryPlace place = new DeliveryPlace(1000, "Place", "Place Address", "Description");
            ProductCart cart = new ProductCart();
            cart.Add(new Product("Product1", 100));
            cart.Add(new Product("Product2", 150));

            DeliveryOrder order = new DeliveryOrder(customer, place, cart);

            string message = "No message";

            // Act
            bool isMade = _ordersManager.MakeOrder(order, ref message);

            // Assert
            Assert.IsTrue(isMade);
            Assert.AreEqual(_ordersManager._deliveryOrders.Count, 1);
        }
        [TestMethod]
        public void MakeOrder_AnyActiveOrder()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");
            DeliveryPlace place = new DeliveryPlace(1000, "Place", "Place Address", "Description");
            ProductCart cart = new ProductCart();
            cart.Add(new Product("Product1", 100));
            cart.Add(new Product("Product2", 150));

            DeliveryOrder order = new DeliveryOrder(customer, place, cart);

            string message = "No message";

            // Act
            _ordersManager.MakeOrder(order, ref message);
            bool isMade = _ordersManager.MakeOrder(order, ref message);

            // Assert
            Assert.IsFalse(isMade);
            Assert.AreEqual(_ordersManager._deliveryOrders.Count, 1);
        }

        [TestMethod]
        public void DeclineOrder_CorrectDecline()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");
            DeliveryPlace place = new DeliveryPlace(1000, "Place", "Place Address", "Description");
            ProductCart cart = new ProductCart();
            cart.Add(new Product("Product1", 100));
            cart.Add(new Product("Product2", 150));

            DeliveryOrder order = new DeliveryOrder(customer, place, cart);

            string message = "No message";

            // Act
            _ordersManager.MakeOrder(order, ref message);
            bool isDeclined = _ordersManager.DeclineOrder(customer.Login, ref message);

            // Assert
            Assert.IsTrue(isDeclined);
            Assert.AreEqual(_ordersManager._deliveryOrders.List[0].OrderStatus, DeliveryOrderStatus.Declined);
        }
        [TestMethod]
        public void DeclineOrder_NothingToDecline()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");

            string message = "No message";

            // Act
            bool isDeclined = _ordersManager.DeclineOrder(customer.Login, ref message);

            // Assert
            Assert.IsFalse(isDeclined);
        }
        [TestMethod]
        public void DeclineOrder_NullCustomerLogin()
        {
            // Arrange
            string message = "No message";

            // Act
            bool isDeclined = _ordersManager.DeclineOrder(null, ref message);

            // Assert
            Assert.IsFalse(isDeclined);
        }

        [TestMethod]
        public void TakeOrder_CorrectData()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");
            DeliveryPlace place = new DeliveryPlace(1000, "Place", "Place Address", "Description");
            ProductCart cart = new ProductCart();
            cart.Add(new Product("Product1", 100));
            cart.Add(new Product("Product2", 150));

            DeliveryOrder order = new DeliveryOrder(customer, place, cart);
            DeliveryCourier courier = new DeliveryCourier("Courier", "Password", "0112223344", "1234 5678 9012 3456");

            string message = "No message";

            // Act
            _ordersManager.MakeOrder(order, ref message);
            bool isTaken = _ordersManager.TakeOrder(order, courier, ref message);

            // Assert
            Assert.IsTrue(isTaken);
            Assert.AreEqual(_ordersManager._deliveryOrders.List[0].OrderStatus, DeliveryOrderStatus.Accepted);
        }
        [TestMethod]
        public void TakeOrder_NoOrderAvailable()
        {
            // Arrange
            DeliveryCustomer customer = new DeliveryCustomer("Customer", "Password", "380998887766", "Customer Address");
            DeliveryPlace place = new DeliveryPlace(1000, "Place", "Place Address", "Description");
            ProductCart cart = new ProductCart();
            cart.Add(new Product("Product1", 100));
            cart.Add(new Product("Product2", 150));

            DeliveryOrder order = new DeliveryOrder(customer, place, cart);
            DeliveryCourier courier = new DeliveryCourier("Courier", "Password", "0112223344", "1234 5678 9012 3456");

            string message = "No message";

            // Act
            bool isTaken = _ordersManager.TakeOrder(order, courier, ref message);

            // Assert
            Assert.IsFalse(isTaken);
            Assert.AreEqual(_ordersManager._deliveryOrders.Count, 0);
        }
        [TestMethod]
        public void TakeOrder_NullOrder()
        {
            // Arrange
            DeliveryCourier courier = new DeliveryCourier("Courier", "Password", "0112223344", "1234 5678 9012 3456");

            string message = "No message";

            // Act
            bool isTaken = _ordersManager.TakeOrder(null, courier, ref message);

            // Assert
            Assert.IsFalse(isTaken);
            Assert.AreEqual(_ordersManager._deliveryOrders.Count, 0);
        }

    }
}
