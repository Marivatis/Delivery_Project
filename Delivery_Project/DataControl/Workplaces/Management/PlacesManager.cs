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
        private ListDeliveryPlaces _deliveryPlaces;

        public PlacesManager()
        {
            _deliveryPlaces = new ListDeliveryPlaces();
            
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
            FormManager.QuerryGetDeliveryPlaceList += GetDeliveryPlaceList;

            DeliveryPlace.PlaceChanged += Write_Places;

            _deliveryPlaces.AddedPlace += Write_Places;
        }

        // Returns null if failed to find valid places
        private List<DeliveryPlace> GetDeliveryPlaceList()
        {
            List<DeliveryPlace> list = _deliveryPlaces.Where(p => p.Address != "No_Address").ToList();

            return list;
        }
        // Returns null if failed to find place and returns place if place was found 
        private void GetDeliveryPlace(int placeCode, out DeliveryPlace? place)
        {
            if (placeCode == 0)
            {
                place = new DeliveryPlace();
                place.PlaceCode = GetPlaceCode();

                _deliveryPlaces.Add(place);
                return;
            }

            place = _deliveryPlaces.FirstOrDefault(p => p.PlaceCode == placeCode);
        }
        // Return new valid place code
        private int GetPlaceCode()
        {
            if (_deliveryPlaces.Count == 0)
                return 1000;

            int maxCode = _deliveryPlaces.Max(p =>  p.PlaceCode) + 1;

            return maxCode;
        }

        // Writes field _deliveryPlaces to json
        private void Write_Places()
        {
            Write_List(_deliveryPlaces.List, "Places");
        }
        // Writes given list to json
        private void Write_List<T>(List<T> list, string fileName)
        {
            bool isWritten = false;

            isWritten = DataManager.WriteListToJson(list, fileName);

            if (!isWritten)
            {
                MessageBox.Show("Writting list to json file went wrong!");
            }
        }

        // Reads field _deliveryPlaces from json
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

            _deliveryPlaces = new ListDeliveryPlaces(places);

            //if (_deliveryPlaces.Count == 0)
            //{
            //    MessageBox.Show("Failed to load any delivery places.");
            //    return;
            //}
        }
    }
}
