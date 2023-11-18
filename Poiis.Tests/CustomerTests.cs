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
    public class CustomerTests
    {
    
        [TestMethod()]
        public void MakeOrderTest()
        {
            //arrange
            var recipe1 = new Recipe("Как приготовить Омлет");
            var recipe2 = new Recipe("Готовим Цезарь");
            var Kate = new Customer("Kate");
            var dish1 = new Dish();
            var dish2 = new Dish();
            dish1.SetName("Омлет");
            dish2.SetName("Цезарь");
            dish1.SetRecipe(recipe1);
            dish2.SetRecipe(recipe2);
            Kate.MakeOrder(dish1.GetName(), 1);
            Kate.MakeOrder(dish2.GetName(), 1);
            string[] expected =
            {
                "Омлет",
                "Цезарь",
                
            };

            //act
            var sw = new StringWriter();
            Console.SetOut(sw);
           
            Kate.ShowHistoryOrders();
            

            //assert
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShowHistoryOrdersTest()
        {
            var recipe1 = new Recipe("Как приготовить Омлет");
            var Kate = new Customer("Kate");
            var dish1 = new Dish();
            dish1.SetName("Омлет");
            Kate.MakeOrder(dish1.GetName(), 1);
            string[] expected =
            {
                "Омлет"
            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            Kate.ShowHistoryOrders();
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LeaveReviewTest()
        {
            //arrange
            var Kate = new Customer("Kate");
            var dish1 = new Dish();
            dish1.SetName("Омлет");
            var expected = "Покупатель Kate оставляет отзыв о блюде Омлет: очень вкусно\r\n";

            
            var sw= new StringWriter();
            Console.SetOut(sw);

            //act
            Kate.LeaveReview(dish1, "очень вкусно");

            //assert
            var actual = sw.ToString();
            Assert.AreEqual(expected, actual);

        }
    }
}