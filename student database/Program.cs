using System;

namespace student_database
{
    class Program
    {
        //static int FindName (string [] studentNames, string search)
        //{
        //    for (int i = 0; i < studentNames.Length; i++)
        //    {
        //        if (studentNames[i] == search)
        //            return i;
        //    }
        //    return -1;
        //}


        static void Main(string[] args)
        {
            string[] name = new string[] { "Tae", "Allie", "Anthony", "Claire" };
            string[] homeTown = new string[] { "Seoul", "Royal Oak", "Troy", "Grosse Pointe" };
            string[] favoriteFood = new string[] { "Jerk Chicken", "Spam and Egg", "Pizza", "Burger" };

            Console.Write("Greetings! Which student would you like to learn more about? Enter a number 1-4: ");
            string entry = Console.ReadLine();
            int index = int.Parse(entry);
            //string result = name[num];
            //Console.WriteLine(result);
            //  The above uses two lines to accomplish
            //  what the line below does in one line.
            if(index > -1 && index < 4)
            {
                Console.WriteLine($"Student {index} is {name[index]}.");
                Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food': ");
                entry = Console.ReadLine();
                if (entry.ToLower() == "hometown")
                {
                    Console.WriteLine($"{name[index]} is from {homeTown[index]}");
                }
                else if (entry.ToLower() == "favorite food")
                {
                    Console.WriteLine($"{name[index]} loves {favoriteFood[index]}");
                }
                else
                {
                    Console.WriteLine("That category does not exist.");
                }

            }
            else
            {
                Console.WriteLine("Please provide a valid entry");
            }

            //Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food': ");
            //entry = Console.ReadLine();
            //if (entry.ToLower() == "hometown")
            //{
            //    Console.WriteLine($"{name[index]} is from {homeTown[index]}");
            //}
            //else if (entry.ToLower() =="favorite food")
            //{
            //    Console.WriteLine($"{name[index]} loves {favoriteFood[index]}");
            //}
            //else
            //{
            //    Console.WriteLine("That category does not exist.");
            //}
            


            Console.WriteLine(homeTown[index]);
            Console.WriteLine(favoriteFood[index]);
           
        }
    }
}
