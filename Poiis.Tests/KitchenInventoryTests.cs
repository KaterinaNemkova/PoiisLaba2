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
    public class KitchenInventoryTests
    {
        [TestMethod()]
        public void KitchenInventoryTest()
        {
            var кастрюля = new KitchenInventory("Кастрюля", "Посуда для приготовления", 1);
        }
    }
}