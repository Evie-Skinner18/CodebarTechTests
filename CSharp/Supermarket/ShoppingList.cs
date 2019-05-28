using System.Collections.Generic;

namespace Supermarket
{
    public class ShoppingList
    {
        private List<PunnetOfStrawberries> _strawberryPunnets;
        private List<BagOfCoffee> _coffeeBags;
        private List<BoxOfTea> _teaBoxes;

        public ShoppingList(List<PunnetOfStrawberries> strawberries, List<BagOfCoffee> coffee, List<BoxOfTea> tea)
        {
            _strawberryPunnets = strawberries;
            _coffeeBags = coffee;
            _teaBoxes = tea;
        }

        
    }
}
