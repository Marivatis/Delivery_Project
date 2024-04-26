using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl
{
    public class AppManager
    {
        private FormManager formManager;
        private UserManager userManager;

        public AppManager() 
        {
            Initialize();
        }

        private void Initialize()
        {
            userManager = new UserManager();
            formManager = new FormManager();
        }

        public void Run()
        {
            formManager.Run();
        }
    }
}
