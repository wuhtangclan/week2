using System;
using System.Collections.Generic;

namespace CollectionDemoPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();   //creates an empty list and saved it in variable names
            names.Add("Fred");
            names.Add("Sally");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            names.Add("Julia");
            Console.WriteLine(names[2]);

            Console.WriteLine(names.Contains("Fred"));
            Console.WriteLine(names.Contains("Pizza"));

            Console.WriteLine("Now lets remove Fred");
            names.Remove("Fred");
            Console.WriteLine(names[0]);

            Console.WriteLine("Lets remove by index rather than name");
            names.RemoveAt(1); //Index 1 means the second on
            Console.WriteLine(names[0]);
            //Console.WriteLine(names.Count[1]);  //Cant do this one because it's gone

            //Lets add a couple more things back in
            names.Add("Jack");
            names.Add("Allison");
            names.Add("Dylan");
            names.Add("Erica");

            Console.WriteLine("\nLets loop through these using a for loop");
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"We are inside the loop and our index is {1}.");
                Console.WriteLine($"{i} : {names[i]}");
            }

            Console.WriteLine("\nNow let's use a foreach loop");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            }
        }
    }
}
