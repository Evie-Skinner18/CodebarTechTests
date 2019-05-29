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

        public void ScanItem(Product item)
        {
            _shoppingTrolley.Add(item);
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

        public void ApplySpecialOffer()
        {
            // if tea rule has been invoked at the checkout, they get BOGOF on tea
            if (_specialOffers.Contains("TEA") && _shoppingTrolley.Where(i => i.Name.Contains("tea")).Count() > 1)
            {
                // for every two boxes of tea, they get one of those free
                var boxesOfTea = new List<Product>();
                boxesOfTea.AddRange(_shoppingTrolley.Where(i => i.Name.Contains("tea")));
                var numberOfFreeBoxes = Convert.ToInt32((boxesOfTea.Count()) % 2 == 0
                    ? (boxesOfTea.Count()) / 2
                    : (boxesOfTea.Count() / 2) - 0.5);

                /*
                 * 2, 4 , 6, 8, it will be half price
                 * 3 = one will be free  3 -2
                 * 5 = two will be free 5 - 3
                 * 7 = 3 will be free  7/ 2 = 3.5. -0.5 = 3
                 * 9 = four will be free 9 / 2 = 4.5. -0.5 = 4
                 */

                var freeBoxes = boxesOfTea.Skip((boxesOfTea.Count()) - numberOfFreeBoxes);
                foreach (var freeBox in freeBoxes)
                {
                    freeBox.Price = 0.0;
                }

            }
        }

       
    }
}
