using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public abstract class Product
    {
        private double _price;
        private string _name;

        public Product(string name, double price)
        {
            _price = price;
            _name = name;
        }
    }
}
