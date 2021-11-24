﻿using System;
using System.Collections.Generic;

namespace DemoShoppingList
{
    class Program
    {

        static void PrintMenu(Dictionary<string, decimal> menu)
        {
            Console.WriteLine("Welcome to the store");
            foreach (var pair in menu)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }

        static void Main(string[] args)
        {
            /*
             * Our Data model:
             * 
             * 1. A dictionary mapping an item name (string) to a price (decimal)
             *2. a list containing items (string) the shopper is going to purchase, i.e. the cart or basket
             */

            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            List<string> cart = new List<string>();

            // Add some items to the menu
            menu["Milk"] = 2.00m;
            menu["Bread"] = 3.00m;
            menu["Coffee"] = 7.00m;
            menu["Banana"] = 0.50m;
            menu["Apple"] = 0.75m;

            PrintMenu(menu);
        }
    }
}
