using System;

namespace ArrayDemo2
{
    class Program
    {
        static void PrintMenu(string[] theItems, decimal[] thePrices)
        {
            Console.WriteLine("Here is our menu:");
            for (int i = 0; i < theItems.Length; i++)
            {
                Console.WriteLine($"{theItems[i],-12}\t{thePrices[i],-6}");  //,-12 and ,-6 makes the alignments better
            }
        }

        static int FindItem(string[] theItems, string search)
        {
            for (int i = 0; i< theItems.Length; i++)
            {
                if (theItems[i].ToLower() == search.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        static bool GoAgain()
        {
            while (true)
            {
                Console.Write("Would you liuke to go again? (y/n)");
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
            /*
             *    create a menus used at a coffee house
             *          item        price
             *          ----        -----
             *          coffee      2.00
             *          espresso    2.50
             *          muffin      3.50
             *          croissant    4.00
             */

            //For now we're creating two separate arrays
            string[] items = new string[] { "coffee", "espresso", "muffin", "croissant" };
            decimal[] prices = new decimal[] { 2.00m, 2.50m, 3.50m, 4.00m };


            do
            {
                PrintMenu(items, prices);


                Console.WriteLine("Please make a selection:");
                string entry = Console.ReadLine();
                int index = FindItem(items, entry);


                if (index > -1)
                {
                    Console.WriteLine($"The price of {items[index]} is {prices[index]}");
                }
                else
                {
                    Console.WriteLine($"Sorry, we do not have {entry}.");
                }

            }
            while (GoAgain());
        }
    }
}
