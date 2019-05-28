using System.Collections.Generic;

namespace Supermarket
{
    public class Checkout
    {
        private List<Product> _shoppingtrolley;

        private string _offer;
        //private double Total;

        public Checkout(string offer)
        {
            _offer = offer;
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

       
    }
}
