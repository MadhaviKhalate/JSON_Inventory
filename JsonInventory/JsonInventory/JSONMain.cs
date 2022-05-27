using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonInventory
{
    internal class JSONMain
    {
        JsonModel JsonModel = new JsonModel();
        List<JsonModel> InventoryList = new List<JsonModel>();

        public void Convert(string JFilePath)
        {
            using (StreamReader reader = new StreamReader(JFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<JsonModel>>(json);
                Console.WriteLine("Item     Price     Weight   Total Value");

                foreach (var objects in items)
                {
                    double value = objects.price * objects.weight;
                    Console.WriteLine(objects.name + " \t " + objects.price + " \t " + objects.weight 
                        +" \t " + value);
                }
            }
        }
    }
}
