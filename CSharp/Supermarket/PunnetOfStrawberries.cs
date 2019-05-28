namespace Supermarket
{
    public class PunnetOfStrawberries : Product
    {
        public override double Price { get; set; }
        public new string Name = "Punnet of strawberries";

        public PunnetOfStrawberries(double price)
        {
            Price = price;
        }
    }
}
