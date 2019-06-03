using System.Collections.Generic;
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
        public void CanCountAllItemsInTrolley_ShouldReturnFive()
        {

        }
    }
}
