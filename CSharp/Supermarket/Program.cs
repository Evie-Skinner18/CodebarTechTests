using System;
using System.Collections.Generic;

namespace Supermarket

/*
 * Product code | Name         | Price
-----------------------------------------
FR1          | Fruit tea    |  £3.11
SR1          | Strawberries |  £5.00
CF1          | Coffee       | £11.23
Requirements
Our CEO is a big fan of buy-one-get-one-free offers and of fruit tea. He wants us to add a rule to do this.

The COO, though, likes low prices and wants people buying strawberries to get a price discount for bulk purchases. If you buy 3 or more strawberries, the price should drop to £4.50

Our check-out can scan items in any order, and because the CEO and COO change their minds often, it needs to be flexible regarding our pricing rules.

The interface to our checkout looks like this (shown in ruby):

co = Checkout.new(pricing_rules)
co.scan(item)
co.scan(item)
price = co.total
 */
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
                new Product("Punnet of strawberries", 5.00),
                new Product("Punnet of strawberries", 5.00),
                new Product("Box of coffee", 11.23)
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

            Console.WriteLine("Please enter the name of the item that qualified you for an offer" );
            var userInput = Console.ReadLine();

            Console.WriteLine("Thank you. Calculating your total now...");
            checkout.PickSpecialOffer(userInput);

            Console.WriteLine($"Your total is {checkout.GetTotal()}. Enjoy your delicious food!");

            Console.ReadKey();
        }
    }
}
