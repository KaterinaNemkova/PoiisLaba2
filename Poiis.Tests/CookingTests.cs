using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poiis2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0.Tests
{
    [TestClass()]
    public class CookingTests
    {
        
        [TestMethod()]
        public void AddRecipeTest()
        {
            var recipe1 = new Recipe("Омлет");
            recipe1.AddIngredients(new Ingredient(Category.Eggs, "Яйца", 2));
            recipe1.AddIngredients(new Ingredient(Category.Milk, "Молоко", 2));
            var recipe2 = new Recipe("Салат Цезарь");
            Ingredient tomato = new Ingredient(Category.Vegetables, "Помидоры", 2);
            recipe2.AddIngredients(tomato);
            var recipes = new Cooking();
            recipes.AddRecipe(recipe1);
            recipes.AddRecipe(recipe2);

            Assert.IsTrue(recipes.Recipes.Contains(recipe1));
            Assert.IsTrue(recipes.Recipes.Contains(recipe2));
        }

        [TestMethod()]
        public void ShowRecipesTest()
        {
            var recipe1 = new Recipe("Омлет");
            var recipe2 = new Recipe("Цезарь");
            var recipes = new Cooking();
            recipes.AddRecipe(recipe1);
            recipes.AddRecipe(recipe2);
            string[] expected =
            {
                
                "Омлет",
                "Цезарь"
            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            recipes.ShowRecipes();

            //assert
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void RemoveRecipeTest()
        {
            var recipe1 = new Recipe("Омлет");
            var recipe2 = new Recipe("Цезарь");
            var recipes = new Cooking();
            recipes.AddRecipe(recipe1);
            recipes.AddRecipe(recipe2);
            recipes.RemoveRecipe(recipe1);
            string[] expected =
            {
                "Цезарь"
            };

            Assert.IsFalse(recipes.Recipes.Contains(recipe1));

        }
    }
}