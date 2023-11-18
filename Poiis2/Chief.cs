using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class Chief : Person
    {

        string Specialization { get; set; }

        public Chief(string name, string specialization) : base(name)
        {
            Specialization = specialization;
        }

        public string GetInformation() => Name + " " + Specialization;

        public void CookRecipe(Recipe recipe, Technology technology) => Console.WriteLine($"Повар {Name} готовит блюдо {recipe.Meal} используя технологию {technology}");


    }

}
