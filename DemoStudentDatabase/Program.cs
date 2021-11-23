using System;

namespace DemoStudentDatabase
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
            string[] names = new string[] { "Jeff", "Antonio", "Hanna", "Tommy" };
            string[] hometowns = new string[] { "Grand Rapids", "Detroit", "Seattle", "Raleigh" };
            string[] food = new string[] { "Pizza", "Focaccia Barese", "Shrimp", "Tacos" };


            do
            {
                string entry = "";
                int num = 0;
                bool validEntry = false;
                do
                {
                    Console.WriteLine("Which student would you like info on?");
                    entry = Console.ReadLine();
                    num = int.Parse(entry);

                    if(num >=1 && num <= names.Length)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter number between 1 and {names.Length}.");
                    }

                } while (validEntry == false);

                /*
                 * We'll lets the user state with 1 as the first, rather than the actual index 0 as the first
                 * 
                 * name     index       what user enters
                 * Jeff         0               1
                 * Ant          1               2
                 * Hanna        2               3
                 * Tommy        2               4
                 * 
                 */


                ///num = num - 1;
                num--;

                Console.WriteLine(names[num]);

                validEntry = false;

                do
                {
                    Console.WriteLine("Which categrory? Please enter hometown or favorite food: ");
                    entry = Console.ReadLine().ToLower();
                    if (entry == "hometown")
                    {
                        Console.WriteLine($"{names[num]} is from {hometowns[num]}");
                        validEntry = true;
                    }
                    else if (entry == "favorite food")
                    {
                        Console.WriteLine($"{names[num]}'s favorite food is {food[num]}");
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter hometown or favorite food.");
                    }
                } while (validEntry == false);
            }
            while (GoAgain("Would you like to learn about another student? (y/n)"));
        }
    }
}
