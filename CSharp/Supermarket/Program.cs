using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Super DUPER Market!");

            var shoppingTrolley = new List<Product>
            {
                new Product("Fruit tea", 3.11),
                new Product("Fruit tea", 3.11),
                //new Product("Punnet of strawberries", 5.00),
                //new Product("Punnet of strawberries", 5.00),
                //new Product("Box of coffee", 11.23)
            };

            // each  time you go to the checkout, you can bring a trolley full of different items
            var checkout = new Checkout(shoppingTrolley);
            Console.WriteLine($"You have {checkout.CountAllItemsInTrolley()} items in your trolley.");

            // tell them how many of each item is in the trolley and if they can have an offer
            foreach(var itemPair in checkout.CountItemsOfEachTypeInTrolley())
            {

                Console.WriteLine(itemPair);

                var message = Convert.ToInt32(itemPair.Value) > 1 ? 
                $"You have {itemPair.Value} {itemPair.Key.Substring(23)}s. You can apply an offer for this item!" 
                    : 
                $"Add some more of the {itemPair.Key.Substring(23)} item to get a special offer";

                Console.WriteLine(message);
            }

            Console.WriteLine("Please enter the name of the item(s) that qualified you for an offer" );
            var userInput = Console.ReadLine();

            Console.WriteLine("Thank you. Calculating your total now...");
            checkout.PickSpecialOffer(userInput);

            Console.WriteLine($"Your total is {checkout.GetTotal()}. Enjoy your delicious {userInput}!");

            Console.ReadKey();
        }
    }
}
