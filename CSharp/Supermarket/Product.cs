using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public abstract class Product
    {
        public virtual double Price { get; set; }
        public virtual string Name { get; set; }
    }
}
