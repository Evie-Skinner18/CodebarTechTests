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

            var specialOffers = new List<string>
            {
                "TEA"
            };

            var shoppingTrolley = new List<Product>
            {
                new Product("Fruit tea", 3.11),
                new Product("Fruit tea", 3.11),
                new Product("Punnet of strawberries", 5.00),
                new Product("Box of coffee", 11.23)
            };

            // each  time you go to the checkout, you can bring a trolley full of different items
            // and pay for them using a different combination of offers
            var checkout = new Checkout(shoppingTrolley, specialOffers);
            Console.WriteLine(checkout.CountAllItemsInTrolley());

            // scan items one at a time doesn't work because of void return type...?
            checkout.ApplySpecialOffer();
            Console.WriteLine(checkout.GetTotal());

            Console.ReadKey();
        }
    }
}
