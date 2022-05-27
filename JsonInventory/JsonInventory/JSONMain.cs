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

        public void ConvertMethod(string JFilePath)
        {
            FactoryModel model = new FactoryModel();
            List<JsonModel> Rice;
            List<JsonModel> Wheat;
            List<JsonModel> Pulses;

            using (StreamReader file = new StreamReader(JFilePath))
            {
                var json = file.ReadToEnd();
                FactoryModel item = JsonConvert.DeserializeObject<FactoryModel>(json);
                Rice = item.Rice;
                Wheat = item.Wheat;
                Pulses = item.Pulses;
                Console.WriteLine("Which Item you want check:\n1.Rice\n2.Wheat\n3.Pulses");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item \t Price \t weight");
                switch (choice)
                {
                    case 1:
                        foreach (var contact in Rice)
                            Console.WriteLine(contact.name + " \t " + contact.price + " \t " + contact.weight);
                        break;
                    case 2:
                        foreach (var contact in Wheat)
                            Console.WriteLine(contact.name + " \t " + contact.price + " \t " + contact.weight);
                        break;
                    case 3:
                        foreach (var contact in Pulses)
                            Console.WriteLine(contact.name + " \t " + contact.price + " \t " + contact.weight);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
