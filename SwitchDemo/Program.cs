using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter Pizza, Apple or Coffee:");
            string entry = Console.ReadLine();
            /*
            if (entry == "Pizza")
            {
                Console.WriteLine("Pizza is great.");
            }else if (entry == "Apple")
            {
                Console.WriteLine("An apple a day keeps the doctor away.");
            }else if (entry == "Coffee")
            {
                Console.WriteLine("Coffee gets you going");
            }
            else
            {
                Console.WriteLine("I have no idea what that is.");
            }
            */

            switch (entry)
            {
                case "Pizza":
                    Console.WriteLine("Pizza is great.");
                    break;
                case "Apple":
                    Console.WriteLine("An apple a day keeps the doctor away.");
                    break;
                case "Coffee":
                    Console.WriteLine("Coffee gets you going");
                    break;
                default:
                    Console.WriteLine("I have no idea what that is.");
                    break;


            }
        }
    }
}
