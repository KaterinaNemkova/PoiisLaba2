using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class KitchenInventory
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }

        public KitchenInventory(string name, string type, int quantity) {
            this.Name = name;
            this.Type = type;
            this.Quantity = quantity;

        }
        

    }
}
