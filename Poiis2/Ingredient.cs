using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        //Category Category { get; set; }

        public Ingredient(Category cate, string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

    }

}
