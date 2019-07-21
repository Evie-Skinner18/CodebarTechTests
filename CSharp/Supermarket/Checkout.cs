using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    public class Checkout
    {
        private List<Product> _shoppingTrolley;
        private Dictionary<string, object> _allItems = new Dictionary<string, object>();


        public Checkout(List<Product> shoppingItems)
        {
            _shoppingTrolley = shoppingItems;
        }

        public int CountAllItemsInTrolley()
        {
            return (_shoppingTrolley.Count);
        }

        public Dictionary<string, object> CountItemsOfEachTypeInTrolley()
        {
            var itemsGrouped = _shoppingTrolley.GroupBy(p => p.Name);

            foreach (var itemGroup in itemsGrouped)
            {
                _allItems.Add($"Number of items of type {itemGroup.Key}", itemGroup.Count());
            }

            return _allItems;
        }

        public double GetTotal()
        {
            var total = 0.0;

            foreach (var item in _shoppingTrolley)
            {
                total += item.Price;
            }

            return total;
        }

        // this method will only be invoked if the shopper actually has a trolley able to redeem offers
        // if they have > 1 of a product in the trolley
        public void PickSpecialOffer(string userOfferCode)
        {
            switch (userOfferCode)
            {
                case "tea":
                    ApplyTeaSpecialOffer();
                    break;
                case "strawberries":
                    ApplyStrawberriesSpecialOffer();
                    break;
                case "coffee":
                    ApplyCoffeeSpecialOffer();
                    break;
                // combination offers
                case "tea and strawberries":
                case "strawberries and tea":
                    ApplyTeaSpecialOffer(); ApplyStrawberriesSpecialOffer();
                    break;
                case "coffee and strawberries":
                case "strawberries and coffee":
                    ApplyCoffeeSpecialOffer(); ApplyStrawberriesSpecialOffer();
                    break;
                case "tea and coffee":
                case "coffee and tea":
                    ApplyTeaSpecialOffer(); ApplyCoffeeSpecialOffer();
                    break;
                // if the user has no item to redeem an offer on
                default:
                    Console.WriteLine("Invalid offer code!");
                    break;
            }
        }

        // BOGOF on tea
        public List<Product> ApplyTeaSpecialOffer()
        {
            var boxesOfTea = new List<Product>();
            boxesOfTea.AddRange(_shoppingTrolley.Where(p => p.Name.Contains("tea")));
            _shoppingTrolley.RemoveAll(p => p.Name.Contains("tea"));

            var numberOfFreeBoxes = Convert.ToInt32((boxesOfTea.Count()) % 2 == 0
                ? (boxesOfTea.Count()) / 2
                : (boxesOfTea.Count() / 2) - 0.5);

            var freeBoxes = boxesOfTea.GetRange(0, numberOfFreeBoxes);

            foreach (var freeBox in freeBoxes)
            {
                freeBox.Price = 0.0;
            }

            _shoppingTrolley.AddRange(boxesOfTea);
            return _shoppingTrolley;
        }

        // price reduction for more than 2 punnets
        public List<Product> ApplyStrawberriesSpecialOffer()
        {
            var punnetsOfStrawberries = new List<Product>();
            punnetsOfStrawberries.AddRange(_shoppingTrolley.Where(p => p.Name.Contains("strawberries")));
            _shoppingTrolley.RemoveAll(p => p.Name.Contains("strawberries"));

            var priceOfEachPunnet = punnetsOfStrawberries.Count() > 2 ? 4.50 : 5.00;

            if (priceOfEachPunnet < 5.00)
            {
                foreach (var punnet in punnetsOfStrawberries)
                {
                    punnet.Price = priceOfEachPunnet;
                }
            }

            _shoppingTrolley.AddRange(punnetsOfStrawberries);
            return _shoppingTrolley;
        }

        //price reduction for more than three boxes of coffee
        public List<Product> ApplyCoffeeSpecialOffer()
        {
            var boxesOfCoffee = new List<Product>();
            boxesOfCoffee.AddRange(_shoppingTrolley.Where(p => p.Name.Contains("coffee")));
            _shoppingTrolley.RemoveAll(p => p.Name.Contains("coffee"));

            // if they have more than 3 boxes, they get each box for 8£
            var priceOfEachBox = boxesOfCoffee.Count() > 3 ? 8.00 : 11.23;

            if (priceOfEachBox < 11.23)
            {
                foreach (var box in boxesOfCoffee)
                {
                    box.Price = priceOfEachBox;
                }
            }

            _shoppingTrolley.AddRange(boxesOfCoffee);
            return _shoppingTrolley;
        }
    }
}