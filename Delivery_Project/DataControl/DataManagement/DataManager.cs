using Delivery_Project.DataControl.DataManagement.JsonDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.DataManagement
{
    public class DataManager
    {
        private static string mainProjectPath;

        public DataManager() 
        {
            GetMainProjectPath();
        }

        public static string MianProjectPath => mainProjectPath;

        public static bool WriteListToJson<T>(List<T> items, string fileName)
        {
            return JsonDataManager.WriteToFile(items, $"{mainProjectPath}\\Data\\{fileName}.json");
        }
        public static bool ReadListFromJson<T>(string fileName, ref List<T> items)
        {
            return JsonDataManager.ReadFromFile($"{mainProjectPath}\\Data\\{fileName}.json", ref items);
        }

        private void GetMainProjectPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            mainProjectPath = GoUpDirectories(basePath, 4);
        }

        private string GoUpDirectories(string path, int levels)
        {
            string absolutePath = Path.GetFullPath(path);

            for (int i = 0; i < levels; i++)
            {
                absolutePath = Directory.GetParent(absolutePath)?.FullName ?? absolutePath;
            }

            return absolutePath;
        }


    }
}
