namespace Supermarket
{
    public class PunnetOfStrawberries : Product
    {
        public override double Price { get; set; }

        public PunnetOfStrawberries(double price)
        {
            Price = price;
        }
    }
}
