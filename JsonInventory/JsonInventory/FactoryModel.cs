using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInventory
{
    internal class FactoryModel
    {
        public List<JsonModel> Rice { get; set; }
        public List<JsonModel> Wheat { get; set; }
        public List<JsonModel> Pulses { get; set; }
    }
}
