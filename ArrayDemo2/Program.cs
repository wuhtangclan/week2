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

            PrintMenu(items, prices);

            //Console.WriteLine("Here is our menu:");
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine($"{items[i],-12}\t{prices[i],-6}");  //,-12 and ,-6 makes the alignments better
            //}

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

            //for (int i = 0; i < items.Length; i++)
            //{
            //    if (items[i].ToLower() == entry.ToLower())
            //    {
            //        Console.WriteLine($"The price of {items[i]} is {prices[i]}"); //can swap out {entry} for {itmes[i]}. it is the same
            //        break;
               
           
        }
    }
}
