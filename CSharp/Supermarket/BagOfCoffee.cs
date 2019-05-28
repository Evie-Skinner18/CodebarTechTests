namespace Supermarket
{
    public class BagOfCoffee : Product
    {
        public override double Price { get; set; }
        public new string Name = "Bag of coffee";

        public BagOfCoffee(double price)
        {
            Price = price;
        }
    }
}
