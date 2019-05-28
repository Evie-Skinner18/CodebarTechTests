using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    public class Checkout
    {
        private List<Product> _shoppingtrolley;

        // multiple offer codes can be applied
        private List<string> _specialOffers;

        public Checkout(List<string> offerCodes)
        {
            _specialOffers = offerCodes;
        }

        public void ScanItem(Product item)
        {
            _shoppingtrolley.Add(item);
        }

        public int CountAllItemsInTrolley()
        {
            return (_shoppingtrolley.Count);
        }

        public double GetTotal()
        {
            var total = 0.0;

            foreach (var item in _shoppingtrolley)
            {
                total += item.Price;
            }

            return total;
        }

        public void ApplySpecialOffer()
        {
            // if tea rule has been invoked at the checkout, they get BOGOF on tea
            if (_specialOffers.Contains("TEA") && _shoppingtrolley.Where(i => i.Name.Contains("tea")).Count() > 1)
            {
                // for every two boxes of tea, they get one of those free
                var boxesOfTea = new List<Product>();
                boxesOfTea.AddRange(_shoppingtrolley.Where(i => i.Name.Contains("tea")));
                var numberOfFreeBoxes = (boxesOfTea.Count()) % 2 == 0
                    ? (boxesOfTea.Count()) / 2
                    : (boxesOfTea.Count() / 2) - 0.5;

                /*
                 * 2, 4 , 6, 8, it will be half price
                 * 3 = one will be free  3 -2
                 * 5 = two will be free 5 - 3
                 * 7 = 3 will be free  7/ 2 = 3.5. -0.5 = 3
                 * 9 = four will be free 9 / 2 = 4.5. -0.5 = 4
                 */

            }
        }

       
    }
}
