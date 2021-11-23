using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Michigan"] = "Lansing";
            capitals["Michigan"] = "Lansing";
            capitals["Ohio"] = "Columbus";
            capitals["California"] = "Sacramento";
            capitals["Georgia"] = "Atalnta";

            Console.WriteLine("Let's print out a couple of these");
            Console.WriteLine(capitals["Ohio"]);
            Console.WriteLine(capitals["Georgia"]);

            Console.WriteLine("\nLets use a foreach loop");
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            Console.WriteLine("\nLets change MI captial to Detroit");
            capitals["Michigan"] = "Detroit";
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            Console.WriteLine("\nLets add another");
            capitals["Indiana"] = "Indianapolis";
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
