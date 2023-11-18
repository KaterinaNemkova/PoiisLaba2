using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public class Cooking
    {
        public List<Recipe> Recipes;

        public Cooking()
        {
            Recipes = new List<Recipe>();
        }
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void ShowRecipes()
        {
            
            foreach (Recipe recipe in Recipes)
            {
                Console.WriteLine(recipe.Meal);
            }
        }

        public void RemoveRecipe(Recipe recipe)
        {
            Recipes.Remove(recipe);
        }


    }
}
