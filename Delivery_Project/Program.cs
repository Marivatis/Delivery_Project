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
            appManager.Run();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
        }
    }
}