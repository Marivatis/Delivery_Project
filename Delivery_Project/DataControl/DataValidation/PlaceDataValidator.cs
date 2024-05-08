using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delivery_Project.DataControl.DataValidation
{
    public class PlaceDataValidator : MainDataValidator
    {
        public static bool ValidateDeliveryPercent(int deliveryPercent, ref string message)
        {
            if (deliveryPercent < 0)
            {
                message = "Delivery percent can`t be lover than 0%";
                return false;
            }

            if (deliveryPercent > 75)
            {
                message = "Delivery percent can`t be higher than 75%";
                return false;
            }

            return true;
        }
        public static bool ValidateDeliveryPrice(int deliveryPrice, ref string message)
        {
            if (deliveryPrice < 0)
            {
                message = "Delivery price can`t be lower than 0 UAH.";
                return false;
            }

            if (deliveryPrice > 500)
            {
                message = "Delivery price can`t be higher than 500 UAH.";
                return false;
            }

            return true;
        }
        public static bool ValidateName(string name, ref string message)
        {
            if (string.IsNullOrEmpty(name))
            {
                message = "Place name can`t be empty.";
                return false;
            }

            string pattern = "^[ a-zA-Z0-9]";

            if (!Regex.IsMatch(name, pattern))
            {
                message = "Incorrect place name format.";
                return false;
            }

            if (3 > name.Length || name.Length > 20)
            {
                message = "Place name must be from 3 to 20 characters.";
                return false;
            }

            return true;
        }
        public static bool ValidateDescription(string description, ref string message)
        {
            if (string.IsNullOrEmpty(description))
            {
                message = "Place description can`t be empty.";
                return false;
            }

            string pattern = "^[ a-zA-Z0-9]";

            if (!Regex.IsMatch(description, pattern))
            {
                message = "Incorrect description name format.";
                return false;
            }

            if (10 > description.Length || description.Length > 200)
            {
                message = "Place description must be from 10 to 200 characters.";
                return false;
            }

            return true;
        }
    }
}
