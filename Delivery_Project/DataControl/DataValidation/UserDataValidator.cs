using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.DataValidation
{
    public class UserDataValidator : MainDataValidator
    {
        public static bool ValidateLogin(string login, ref string message)
        {
            if (string.IsNullOrEmpty(login))
            {
                message = "Login can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9]";

            if (!Regex.IsMatch(login, pattern))
            {
                message = "Incorrect login format.";
                return false;
            }

            if (3 > login.Length || login.Length > 12)
            {
                message = "Login must be from 3 to 12 characters.";
                return false;
            }

            return true;
        }
        public static bool ValidatePassword(string password, ref string message)
        {
            if (string.IsNullOrEmpty(password))
            {
                message = "Password can`t be empty.";
                return false;
            }

            string pattern = "^[a-zA-Z0-9]";

            if (!Regex.IsMatch(password, pattern))
            {
                message = "Incorrect password format.";
                return false;
            }

            if (4 > password.Length || password.Length > 14)
            {
                message = "Password must be from 4 to 12 characters.";
                return false;
            }

            return true;
        }
    }
}
