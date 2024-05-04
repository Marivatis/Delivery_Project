using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.DataValidation
{
    public class MainDataValidator
    {
        public static bool ValidatePhoneNumber(string phoneNumber, ref string message)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                message = "Phone number can`t be empty.";
                return false;
            }

            if (phoneNumber == "No_Phone_Number")
            {
                return true;
            }

            string pattern = @"^\+?(\d{2})?[-. ]?(\d{3})[-. ]?(\d{3})[-. ]?(\d{4})$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                message = "Invalid phone number";
                return false;
            }

            return true;
        }
        public static bool ValidateAddress(string address, ref string message)
        {
            if (string.IsNullOrEmpty(address))
            {
                message = "Address can`t be empty.";
                return false;
            }

            if (address == "No_Address")
            {
                return true;
            }

            //message = "Invalid address";
            return true;
        }
        public static bool ValidateCardNumber(string cardNumber, ref string message)
        {
            if (string.IsNullOrEmpty(cardNumber))
            {
                message = "Card number can`t be empty.";
                return false;
            }

            if (cardNumber == "No_Card_Number")
            {
                return true;
            }

            string pattern = @"^\d{4} \d{4} \d{4} \d{4}$";

            if (!Regex.IsMatch(cardNumber, pattern))
            {
                message = "Invalid card number.";
                return false;
            }

            return true;
        }
    }
}
