using Delivery_Project.DataControl.DataManagement;
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
        private DataManager dataManager;

        public AppManager() 
        {
            Initialize();
        }

        private void Initialize()
        {
            dataManager = new DataManager();
            userManager = new UserManager();
            formManager = new FormManager();
        }

        public void Run()
        {
            formManager.Run();
        }
    }
}
