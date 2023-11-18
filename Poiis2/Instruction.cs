using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
   public class Instruction
    {

        public string Name { get; set; }

        KitchenInventory KitchenAppliance { get; set; }
        public Instruction(string name, KitchenInventory appliance)

        {
            Name = name;
            KitchenAppliance = appliance;
        }
    }
}
