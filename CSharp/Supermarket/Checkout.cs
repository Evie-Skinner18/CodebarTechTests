using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    public class Checkout
    {
        private List<Product> _shoppingTrolley;

        // multiple offer codes can be applied
        private List<string> _specialOffers;

        public Checkout(List<Product> shoppingItems, List<string> offerCodes)
        {
            _specialOffers = offerCodes;
            _shoppingTrolley = shoppingItems;
        }
    
        public int CountAllItemsInTrolley()
        {
            return (_shoppingTrolley.Count);
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

        public List<Product> ApplyStrawberriesSpecialOffer()
        {
            var punnetsOfStrawberries = new List<Product>();
        }
    }
}
