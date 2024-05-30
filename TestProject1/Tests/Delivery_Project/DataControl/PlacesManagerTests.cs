using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.UserManagement;
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
    public class PlacesManagerTests
    {
        private PlacesManager _placesManager;

        [TestInitialize]
        public void Tests_Initialize()
        {
            DataManager dataManager = new();

            _placesManager = new PlacesManager();
        }

        [TestCleanup]
        public void Tests_Cleanup()
        {
            _placesManager.Clear();
        }

        [TestMethod]
        public void GetDeliveryPlace_ZeroPlaceCode()
        {
            // Arrange
            _placesManager.GetDeliveryPlace(0, out DeliveryPlace place);

            // Assert
            Assert.IsNotNull(place);
            Assert.AreEqual(place.PlaceCode, 1000);
        }
        [TestMethod]
        public void GetDeliveryPlace_TakenPlaceCode()
        {
            // Arrange
            _placesManager.GetDeliveryPlace(0, out DeliveryPlace place);
            _placesManager.GetDeliveryPlace(1000, out DeliveryPlace newPlace);

            // Assert
            Assert.IsNotNull(newPlace);
            Assert.AreEqual(place, newPlace);
        }
        [TestMethod]
        public void GetDeliveryPlace_UntakenPlaceCode()
        {
            // Arrange
            _placesManager.GetDeliveryPlace(1000, out DeliveryPlace place);

            // Assert
            Assert.IsNull(place);
        }
    }
}
