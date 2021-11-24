using System;

namespace student_database
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
            string[] name = new string[] { "Tae", "Allie", "Anthony", "Claire" };
            string[] homeTown = new string[] { "Seoul", "Royal Oak", "Troy", "Grosse Pointe" };
            string[] favoriteFood = new string[] { "Jerk Chicken", "Spam and Egg", "Pizza", "Burger" };

            do
            {
                string entry = "";
                int index = 0;
                bool validEntry = false;

                do
                {
                    Console.Write("Greetings! Which student would you like to learn more about? Enter a number 1-4: ");
                    entry = Console.ReadLine();
                    index = int.Parse(entry);

                    if (index >= 1 && index <= name.Length)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between 1 and {name.Length}");
                    }
                } while (validEntry == false);

                index--;
                Console.Write($"Student {index + 1} is {name[index]}. ");
                validEntry = false;

                do
                {
                    Console.Write("What would you like to know? Enter 'hometown' or 'favortie food': ");
                    entry = Console.ReadLine().ToLower();

                    if (entry == "hometown")
                    {
                        Console.WriteLine($"{name[index]} is from {homeTown[index]}");
                        validEntry = true;
                    }
                    else if (entry == "favorite food")
                    {
                        Console.WriteLine($"{name[index]}'s favorite food is {favoriteFood[index]}");
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter hometown or favorite food");
                    }
                } while (validEntry == false);
            } while (GoAgain("Would you like to learn about another student? (y/n)"));
        }
    }
}
