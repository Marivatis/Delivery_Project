using Delivery_Project.Forms.Entry;
using Delivery_Project.Forms.Customer;
using Delivery_Project.Forms.Courier;
using Microsoft.VisualBasic.ApplicationServices;
using Delivery_Project.DataControl;

namespace Delivery_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppManager appManager = new AppManager();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Application.Run(new FormLogin());
            //Application.Run(new FormRegistration());
            //Application.Run(new FormCustomer());
            //Application.Run(new FormCustomerProfile());
            //Application.Run(new FormOrderConfirmation());
            //Application.Run(new FormCourierRegisteration());
            //Application.Run(new FormCourierProfile());
            //Application.Run(new FormCourier());
        }
    }
}