using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery_Project.DataControl.UserManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.Workplaces.Management;

namespace TestProject1.Tests.Delivery_Project.DataControl
{
    [TestClass]
    public class UserManagerTests
    {
        private UserManager _userManager;
        private PlacesManager _placesManager;

        [TestInitialize]
        public void Tests_Initialize()
        {
            DataManager dataManager = new();

            _placesManager = new PlacesManager();
             _userManager = new UserManager();
        }

        [TestCleanup]
        public void Tests_Cleanup()
        {
            _userManager.Clear();
            _placesManager.Clear();
        }

        [TestMethod]
        public void RegisterCustomer_CorrectData()
        {
            // Arrange
            string message = "No message";

            // Act
            bool isRegistered = _userManager.RegisterCustomer("Login", "Password", ref message);

            // Assert
            Assert.IsTrue(isRegistered);
            Assert.IsTrue(_userManager._deliveryCustomers[0].Password == "Password");
            Assert.IsTrue(_userManager._deliveryCustomers[0].Login == "Login");
        }
        [TestMethod]
        public void RegisterCustomer_InvalidLogin()
        {
            // Arrange
            string message = "No message";

            // Act
            bool isRegistered = _userManager.RegisterCustomer("L", "Password", ref message);

            // Assert
            Assert.IsFalse(isRegistered);
        }
        [TestMethod]
        public void RegisterCustomer_InvalidPassword()
        {
            // Arrange
            string message = "No message";

            // Act
            bool isRegistered = _userManager.RegisterCustomer("Login", "P", ref message);

            // Assert
            Assert.IsFalse(isRegistered);
        }
        [TestMethod]
        public void RegisterCustomer_TakenLogin() 
        {
            // Arrange
            string message = "No message";

            // Act
            _userManager.RegisterCustomer("Login", "Password1", ref message);

            bool isRegistered = _userManager.RegisterCustomer("Login", "Password2", ref message);

            // Assert
            Assert.IsFalse(isRegistered);
        }
        [TestMethod]
        public void RegisterCustomer_TakenPassword()
        {
            // Arrange
            string message = "No message";

            // Act
            _userManager.RegisterCustomer("Login1", "Password", ref message);

            bool isRegistered = _userManager.RegisterCustomer("Login2", "Password", ref message);

            // Assert
            Assert.IsTrue(isRegistered);
        }

        [TestMethod]
        public void RegisterProvider_CorrectData()
        {
            // Arrange
            DeliveryCustomer customer = new("Login", "Password");
            string message = "No message";

            // Act
            _userManager._deliveryCustomers.Add(customer);
            bool isRegistered = _userManager.RegisterProvider(customer, "Please", ref message);

            // Assert
            Assert.IsTrue(isRegistered);
            Assert.IsTrue(_userManager._deliveryProviders[0].Login == customer.Login);
            Assert.IsTrue(_userManager._deliveryProviders[0].Password == customer.Password);
            Assert.IsTrue(_userManager._deliveryCustomers.Count == 0);
        }
        [TestMethod]
        public void RegisterProvider_InvalidSecretWord()
        {
            // Arrange
            DeliveryCustomer customer = new("Login", "Password");
            string message = "No message";

            // Act
            _userManager._deliveryCustomers.Add(customer);
            bool isRegistered = _userManager.RegisterProvider(customer, "Wrong", ref message);

            // Assert
            Assert.IsFalse(isRegistered);
            Assert.IsTrue(_userManager._deliveryProviders.Count == 0);
            Assert.IsTrue(_userManager._deliveryCustomers.Count == 1);
        }

        [TestMethod]
        public void RegisterCourier_CorrectData()
        {
            // Arrange
            DeliveryCustomer customer = new("Login", "Password");
            string message = "No message";

            // Act
            _userManager._deliveryCustomers.Add(customer);
            bool isRegistered = _userManager.RegisterCourier(customer, "0000 0000 0000 0000", ref message);

            // Assert
            Assert.IsTrue(isRegistered);
            Assert.IsTrue(_userManager._deliveryCouriers[0].Login == customer.Login);
            Assert.IsTrue(_userManager._deliveryCouriers[0].Password == customer.Password);
            Assert.IsTrue(_userManager._deliveryCustomers.Count == 0);
        }
        [TestMethod]
        public void RegisterCourier_InvalidPhoneNumber()
        {
            // Arrange
            DeliveryCustomer customer = new("Login", "Password");
            string message = "No message";

            // Act
            _userManager._deliveryCustomers.Add(customer);
            bool isRegistered = _userManager.RegisterCourier(customer, "Wrong", ref message);

            // Assert
            Assert.IsFalse(isRegistered);
            Assert.IsTrue(_userManager._deliveryProviders.Count == 0);
            Assert.IsTrue(_userManager._deliveryCustomers.Count == 1);
        }

        [TestMethod]
        public void LoginUser_CorrectData()
        {
            // Arrange
            string message = "No message";

            // Act
            _userManager.RegisterCustomer("Login", "Password", ref message);
            _userManager.LoginUser("Login", "Password", out DeliveryUser customer);

            // Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(customer.Login, "Login");
            Assert.AreEqual(customer.Password, "Password");
        }
        [TestMethod]
        public void LoginUser_InvalidLogin()
        {
            // Arrange
            string message = "No message";

            // Act
            _userManager.RegisterCustomer("Login", "Password", ref message);
            _userManager.LoginUser("L", "Password", out DeliveryUser customer);

            // Assert
            Assert.IsNull(customer);
        }
        [TestMethod]
        public void LoginUser_InvalidPassword()
        {
            // Arrange
            string message = "No message";

            // Act
            _userManager.RegisterCustomer("Login", "Password", ref message);
            _userManager.LoginUser("Login", "P", out DeliveryUser customer);

            // Assert
            Assert.IsNull(customer);
        }
    }
}
