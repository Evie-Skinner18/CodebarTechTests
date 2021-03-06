﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket;


namespace CodebarTestsTests
{
    [TestClass]
    public class CSharpSuperMarket
    {
        // not eligible
        private List<Product> _oneOfEachItemShoppingTrolley = new List<Product>
        {
            new Product("Fruit tea", 3.11),
            new Product("Box of coffee", 11.23),
            new Product("Punnet of strawberries", 5.00)
        };

        // eligible for strawberries offer
        private List<Product> _strawbsTrolley = new List<Product>
        {
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00)
        };

        // eligible for tea offer
        private List<Product> _twoOfEachItemShoppingTrolley = new List<Product>
        {
            new Product("Fruit tea", 3.11),
            new Product("Fruit tea", 3.11),
            new Product("Box of coffee", 11.23),
            new Product("Box of coffee", 11.23),
            new Product("Punnet of strawberries", 5.00),
            new Product("Punnet of strawberries", 5.00)
        };

        // eligible for coffee offer
        private List<Product> _coffeeTrolley = new List<Product>
        {
            new Product("Box of coffee", 11.23),
            new Product("Box of coffee", 11.23),
            new Product("Box of coffee", 11.23),
            new Product("Box of coffee", 11.23)
        };

        [TestMethod]
        public void CanCountAllItemsInTrolley_ShouldReturnThree_Five_Six_Four()
        {
            var checkout1 = new Checkout(_oneOfEachItemShoppingTrolley);
            var checkout2 = new Checkout(_strawbsTrolley);
            var checkout3 = new Checkout(_twoOfEachItemShoppingTrolley);
            var checkout4 = new Checkout(_coffeeTrolley);

            Assert.AreEqual(checkout1.CountAllItemsInTrolley(), 3);
            Assert.AreEqual(checkout2.CountAllItemsInTrolley(), 5);
            Assert.AreEqual(checkout3.CountAllItemsInTrolley(), 6);
            Assert.AreEqual(checkout4.CountAllItemsInTrolley(), 4);
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

        [TestMethod]
        public void CanApplyStrawberriesSpecialOfferToStrawbsTrolley_ShouldReturn22_50()
        {
            // arrange
            var checkout = new Checkout(_strawbsTrolley);

            //act
            var discountedTrolley = checkout.ApplyStrawberriesSpecialOffer();
            var discountedTotal = checkout.GetTotal();

            //assert
            Assert.AreNotEqual(discountedTrolley, null);
            Assert.AreEqual(discountedTrolley.Count(), 5);
            Assert.AreEqual(discountedTotal, 22.50);
        }

        [TestMethod]
        public void CanApplyTeaSpecialOfferToTwoOfEachItemShoppingTrolley_ShouldReturn35_57()
        {
            var checkout = new Checkout(_twoOfEachItemShoppingTrolley);

            var discountedTrolley = checkout.ApplyTeaSpecialOffer();
            var discountedTotal = checkout.GetTotal();

            Assert.AreNotEqual(discountedTrolley, null);
            Assert.AreEqual(discountedTrolley.Count(), 6);
            Assert.AreEqual(discountedTotal, 35.57);
        }

        [TestMethod]
        public void CanApplyCoffeeSpecialOfferToCoffeeTrolley_ShouldReturn32_00()
        {
            var checkout = new Checkout(_coffeeTrolley);

            var discountedTrolley = checkout.ApplyCoffeeSpecialOffer();
            var discountedTotal = checkout.GetTotal();

            Assert.AreNotEqual(discountedTrolley, null);
            Assert.AreEqual(discountedTrolley.Count(), 4);
            Assert.AreEqual(discountedTotal, 32.00);
        }
    }
}
