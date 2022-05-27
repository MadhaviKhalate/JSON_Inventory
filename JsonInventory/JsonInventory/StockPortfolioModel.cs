using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonInventory
{
    internal class StockPortfolioModel
    {
        StockModel stock = new StockModel();
        List<StockModel> list = new List<StockModel>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var read = reader.ReadToEnd();
                var share = JsonConvert.DeserializeObject<List<StockModel>>(read);
                Console.WriteLine("Company         Qty         Share Price         Total Value");
                double totalValue = 0;
                foreach (var objects in share)
                {
                    double value = objects.noOfShares * objects.sharePrice;
                    totalValue += value;
                    Console.WriteLine(objects.sName + "\t\t" + objects.noOfShares +
                        "\t\t" + objects.sharePrice + "\t\t" + value);
                }
                Console.WriteLine("\nTotal Value of all Stocks is: " + totalValue);
            }
        }

    }
}
