using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.DataValidation
{
    public class ProductDataValidator : MainDataValidator
    {
        public static bool ValidateName(string name, ref string message)
        {
            if (string.IsNullOrEmpty(name))
            {
                message = "Product name can`t be empty.";
                return false;
            }

            string pattern = "^[ a-zA-Z0-9]";

            if (!Regex.IsMatch(name, pattern))
            {
                message = "Incorrect product name format.";
                return false;
            }

            if (3 > name.Length || name.Length > 20)
            {
                message = "Product name must be from 3 to 20 characters.";
                return false;
            }

            return true;
        }
        public static bool ValidatePrice(int price, ref string message)
        {
            if (price < 0)
            {
                message = "Price can`t be lower than 0 UAH.";
                return false;
            }

            if (price > 10000)
            {
                message = "Price can`t be higher than 1000 UAH.";
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

            if (5 > description.Length || description.Length > 50)
            {
                message = "Place description must be from 5 to 50 characters.";
                return false;
            }

            return true;
        }
    }
}
