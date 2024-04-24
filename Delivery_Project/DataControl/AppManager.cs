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
        private FormManager _formManager;
        private UserManager _userManager;

        //public static event EventHandler ProgramStarted;

        public AppManager() 
        {
            Initialize();
        }

        private void Initialize()
        {
            _userManager = new UserManager();
            _formManager = new FormManager();
            
            //ProgramStarted.Invoke(this, EventArgs.Empty);
        }
    }
}
