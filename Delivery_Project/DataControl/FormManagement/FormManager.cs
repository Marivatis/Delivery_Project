using Delivery_Project.DataControl.Interfaces;
using Delivery_Project.Forms.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.FormManagement
{
    public class FormManager
    {
        public static event Func<string, string, bool> Querry_LoginAttempt;

        public FormManager() 
        {
            RunFormLogin();
        }

        private void RunFormLogin()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.LoginAtempt += Querry_LoginAttempt.Invoke;

            Application.Run(formLogin);
        }

    }
}
