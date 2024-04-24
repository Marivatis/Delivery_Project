using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Interfaces;
using Delivery_Project.Forms.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.UserManagement
{
    public class UserManager
    {
        public UserManager() 
        {
            FormManager.Querry_LoginAttempt += LoginUser;
        }

        private bool LoginUser(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
