using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public abstract class Product
    {
        public double Price;
        public string Name;

        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }
    }
}
