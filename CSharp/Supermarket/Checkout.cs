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

        public void PickSpecialOffer(string userOfferCode)
        {
            if(userOfferCode.Contains("tea") && userOfferCode.Contains("strawberries"))
            {
                ApplyTeaSpecialOffer();
                ApplyStrawberriesSpecialOffer();
            }

            else if(userOfferCode.Contains("tea"))
            {
                ApplyTeaSpecialOffer();
            }

            ApplyStrawberriesSpecialOffer();
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

            if(priceOfEachPunnet < 5.00)
            {
                foreach (var punnet in punnetsOfStrawberries)
                {
                    punnet.Price = priceOfEachPunnet;
                }
            }

            _shoppingTrolley.AddRange(punnetsOfStrawberries);
            return _shoppingTrolley;
        }
    }
}
