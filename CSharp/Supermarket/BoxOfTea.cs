namespace Supermarket
{
    public class BoxOfTea : Product
    {
        public override double Price { get; set; }
        public string Name = "Box of tea";

        public BoxOfTea(double price)
        {
            Price = price;
        }
    }
    }
}
