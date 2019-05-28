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
                return _shoppingtrolley.Where(i => i.Name.Contains("tea")).Count()
            }
        }

       
    }
}
