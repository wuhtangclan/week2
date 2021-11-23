using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static bool GoAgain(string message)
        {
            while (true)
            {
                Console.Write(message);
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("Im sorry please enter a valid entry");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WuTang Market!");
            string entry = "";
            Dictionary<string, decimal> price = new Dictionary<string, decimal>();
            price["cheese"] = 4.00m;
            price["bread"] = 2.00m;
            price["mayo"] = 3.00m;
            price["deli meat"] = 5.00m;
            price["lettuce"] = 1.50m;
            price["bacon"] = 6.00m;
            price["tomato"] = 1.00m;
            price["coke"] = 1.25m;

            List<string> items = new List<string>();
            


            foreach (var pair in price)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            bool keepAdding = true;
            while (keepAdding)
            {
                Console.WriteLine("What item would you like to order?");
                entry = Console.ReadLine().ToLower();
                if (price.ContainsKey(entry))
                {
                    Console.WriteLine($"Adding {entry} to cart at ${price[entry]}");
                    items.Add(entry);
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again.");
                }
                Console.WriteLine("Do you want to add more? (y/n)");
                entry = Console.ReadLine().ToLower();
                if (entry == "n")
                {
                    keepAdding = false;
                }
            }
            Console.WriteLine("Thank you for your order!");
            Console.WriteLine("Here's what you got in the bag: ");
            decimal sum = 0m;
            foreach (string item in items)
            {
                Console.WriteLine($"{item} {price[item]}");
                //sum = sum + price[item];
                sum += price[item];
            }
            Console.WriteLine($"Total purchase price is {sum}.");
        }
    }
}
