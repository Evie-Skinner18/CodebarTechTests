namespace Supermarket
{
    public class BoxOfTea : Product
    {
        public override double Price { get; set; }

        public BoxOfTea(double price)
        {
            Price = price;
        }
    }
    }
}
