using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class Dish
    {
        private string name;
        public Recipe Recipe { get; set; }

        public string GetName() => name;
        public string SetName(string name) => this.name = name;
        public void SetRecipe(Recipe recipe) => Recipe = recipe;

    }
}
