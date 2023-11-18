using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0.Tests
{
    [TestClass()]
    public class ChiefTests
    {
        [TestMethod()]
        public void GetInformationTest()
        {
            //arrange
            Chief Natalia = new Chief("Наталия", "Морская пехота");
            var expected = "Наталия Морская пехота";

            //act
            var actual = Natalia.GetInformation();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CookRecipeTest()
        {
            //arrange
            Recipe recipe1 = new Recipe("Омлет");
            Chief Natalia = new Chief("Наталия", "Морская пехота");

            var expected = "Повар Наталия готовит блюдо Омлет используя технологию жарка\r\n";

            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            Natalia.CookRecipe(recipe1, Technology.жарка);

            //assert
            var actual = sw.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}