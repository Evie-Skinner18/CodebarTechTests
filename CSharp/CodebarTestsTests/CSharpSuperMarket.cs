using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket;


namespace CodebarTestsTests
{
    [TestClass]
    public class CSharpSuperMarket
    {
        private List<Product> _oneOfEachItemShoppingTrolley = new List<Product>
        {
            new Product("Fruit tea", 3.11),
            new Product("Box of coffee", 11.23),
            new Product("Punnet of strawberries", 5.00)
        };

        private List<Product> _strawbsTrolley = new List<Product>
        {
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00)
        };

        private List<Product> _twoOfEachItemShoppingTrolley = new List<Product>
        {
            new Product("Fruit tea", 3.11),
            new Product("Fruit tea", 3.11),
            new Product("Box of coffee", 11.23),
            new Product("Box of coffee", 11.23),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00)
        };

        [TestMethod]
        public void CanCountAllItemsInTrolley_ShouldReturnThree_Five_Six()
        {
            var checkout1 = new Checkout(_oneOfEachItemShoppingTrolley);
            var checkout2 = new Checkout(_strawbsTrolley);
            var checkout3 = new Checkout(_twoOfEachItemShoppingTrolley);

            Assert.AreEqual(checkout1.CountAllItemsInTrolley(), 3);
            Assert.AreEqual(checkout2.CountAllItemsInTrolley(), 5);
            Assert.AreEqual(checkout3.CountAllItemsInTrolley(), 6);
        }

        [TestMethod]
        public void CanCountItemsOfEachTypeInTrolley_ShouldReturnTrue()
        {
            var checkout1 = new Checkout(_oneOfEachItemShoppingTrolley);
            // turn it into a list of key value pairs
            var allItemsInTrolley = checkout1.CountItemsOfEachTypeInTrolley().ToList();

            Assert.AreNotEqual(allItemsInTrolley, null);
            Assert.AreEqual(allItemsInTrolley.Count, 3);

            Assert.AreEqual(allItemsInTrolley[0].Key, "Number of items of type Fruit tea");
            Assert.AreEqual(allItemsInTrolley[0].Value, 1);
            Assert.AreEqual(allItemsInTrolley[1].Key, "Number of items of type Box of coffee");
            Assert.AreEqual(allItemsInTrolley[1].Value, 1);
            Assert.AreEqual(allItemsInTrolley[2].Key, "Number of items of type Punnet of strawberries");
            Assert.AreEqual(allItemsInTrolley[2].Value, 1);
        }
    }
}
