using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.DataControl.DataManagement.JsonDataManagement
{
    public static class JsonDataManager
    {
        public static bool WriteToFile<T>(List<T> items, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(path, json);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool ReadFromFile<T>(string path, ref List<T> items)
        {
            try
            {
                string jsonFromFile = File.ReadAllText(path);

                items = JsonConvert.DeserializeObject<List<T>>(jsonFromFile);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
