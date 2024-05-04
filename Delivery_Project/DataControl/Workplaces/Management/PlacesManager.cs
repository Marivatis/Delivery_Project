using Delivery_Project.DataControl.DataManagement;
using Delivery_Project.DataControl.DataValidation;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.UserManagement;
using Delivery_Project.DataControl.Workplaces.Lists;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Workplaces.Management
{
    public class PlacesManager
    {
        private ListDeliveryPlaces? deliveryPlaces;

        public PlacesManager() 
        {
            Initialize();
        }

        private void Initialize()
        {
            DeliveryPlace.ValidateDeliveryPrice += PlaceDataValidator.ValidateDeliveryPrice;
            DeliveryPlace.ValidateName += PlaceDataValidator.ValidateName;
            DeliveryPlace.ValidateDescription += PlaceDataValidator.ValidateDescription;
            DeliveryPlace.ValidateAddress += PlaceDataValidator.ValidateAddress;

            Read_DeliveryPlaces();

            UserManager.QuerryGetDeliveryPlace += GetDeliveryPlace;
            FormManager.QuerryGetDeliveryPlace += GetDeliveryPlace;
            FormManager.QuerryGetDeliveryPlaceList += () => deliveryPlaces?.List;

            DeliveryPlace.PlaceChanged += Write_Places;

            deliveryPlaces.AddedPlace += Write_Places;
        }

        private bool GetDeliveryPlace(int placeCode, out DeliveryPlace? place)
        {
            if (placeCode == 0)
            {
                place = new DeliveryPlace();
                place.PlaceCode = GetPlaceCode();

                deliveryPlaces.Add(place);
                return true;
            }

            place = deliveryPlaces?.FirstOrDefault(p => p.PlaceCode == placeCode);

            if (place != null)
            {
                return true;
            }

            return false;
        }

        private int GetPlaceCode()
        {
            if (deliveryPlaces.Count == 0)
                return 1000;

            int maxCode = deliveryPlaces.Max(p =>  p.PlaceCode) + 1;

            return maxCode;
        }

        private void Write_Places()
        {
            Write_List(deliveryPlaces.List, "Places");
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

        private void Read_DeliveryPlaces()
        {
            bool isRead = false;
            List<DeliveryPlace> places = new List<DeliveryPlace>();

            isRead = DataManager.ReadListFromJson("Places", ref places);

            if (!isRead)
            {
                MessageBox.Show($"Reading list from json file \"Places\" went wrong!");
                return;
            }

            deliveryPlaces = new ListDeliveryPlaces(places);
        }

    }
}
