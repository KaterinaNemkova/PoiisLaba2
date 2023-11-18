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
    public class RecipeTests
    {



        [TestMethod()]
        public void AddIngredientsTest()
        {
            //arrange
            var recipe1 = new Recipe("Омлет");
            var egg = new Ingredient(Category.Eggs, "Яйца", 2);

            //act
            recipe1.AddIngredients(egg);

            //assert
            Assert.IsTrue(recipe1.ingredients.Contains(egg));
        }

        [TestMethod()]
        public void ShowIngredientsTest()
        {
            //arrange
            var recipe1 = new Recipe("Омлет");
            recipe1.AddIngredients(new Ingredient(Category.Eggs, "Яйца", 2));
            recipe1.AddIngredients(new Ingredient(Category.Milk, "Молоко", 2));
            recipe1.AddIngredients(new Ingredient(Category.Vegetables, "Помидор", 1));
            string[] expected =
            {
                "Яйца",
                "Молоко",
                "Помидор"
            };
           
            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            recipe1.ShowIngredients();

            //assert
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveIngredientTest()
        {
            //arrange
            var recipe1 = new Recipe("Омлет");
            var eggs = new Ingredient(Category.Eggs, "Яйца", 2);
            var milk = new Ingredient(Category.Milk, "Молоко", 2);
            recipe1.AddIngredients(eggs);
            recipe1.AddIngredients(milk);

            //act
            recipe1.RemoveIngredient(milk);

            //assert
            Assert.IsFalse(recipe1.ingredients.Contains(milk));
        }

        [TestMethod()]
        public void AddInstructionsTest()
        {
            //arrange
            var recipe2 = new Recipe("Омлет");
            var вилка = new KitchenInventory ( "вилка",  "Кухонный инвентарь", 1);
           var inst1 = new Instruction("Взбить яйца", вилка);

            //act
            recipe2.AddInstructions(inst1);

            //assert
            Assert.IsTrue(recipe2.instructions.Contains(inst1));    

        }

        [TestMethod()]
        public void ShowInstructionsTest()
        {
            //arrange
            var recipe2 = new Recipe("Омлет");
            var вилка = new KitchenInventory("вилка", "Кухонный инвентарь", 1);
            var стакан = new KitchenInventory ("стакан","Кухонный инвентарь", 2 );

            var inst1 = new Instruction("Взбить яйца", вилка);
            var inst2 = new Instruction("Добавить молоко", стакан);
            recipe2.AddInstructions(inst1);
            recipe2.AddInstructions(inst2);

            string[] expected =
            {
                "Взбить яйца",
                "Добавить молоко",
                
            };
            //act
            var sw = new StringWriter();
            Console.SetOut(sw);

            recipe2.ShowInstructions();

            //assert
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void AddInventoryTest()
        {
            //arrange
            var recipe3 = new Recipe("Омлет");
            var сковорода= new KitchenInventory("сковорода", "Кухонный инвентарь", 1);
            

            //act
            recipe3.AddInventory(сковорода);

            //assert
            Assert.IsTrue(recipe3.inventories.Contains(сковорода));

        }

        [TestMethod()]

        public void ShowInventoryTest() {

            var recipe4 = new Recipe("Торт");
            var тарелка = new KitchenInventory("тарелка", "для готовки", 3);
            var сковорода = new KitchenInventory("сковорода", "Кухонный инвентарь", 1);

            recipe4.AddInventory(тарелка);
            recipe4.AddInventory(сковорода);

            string[] expected =
            {
                "тарелка",
                "сковорода",

            };
            var sw = new StringWriter();
            Console.SetOut(sw);

            recipe4.ShowInventory();

            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
    

}