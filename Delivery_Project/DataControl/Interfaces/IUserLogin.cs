using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.Interfaces
{
    public interface IUserLogin
    {
        public static event Action<string, string> Querry_UserLogin;
        public static void Invoke(string login, string password) => Querry_UserLogin?.Invoke(login, password);
    }
}
