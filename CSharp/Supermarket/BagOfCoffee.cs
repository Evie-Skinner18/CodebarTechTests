namespace Supermarket
{
    public class BagOfCoffee : Product
    {
        public override double Price { get; set; }

        public BagOfCoffee(double price)
        {
            Price = price;
        }
    }
}
