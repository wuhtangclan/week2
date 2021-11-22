using System;

namespace ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 10, 15, 20, 25 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Now let's make a string array");
            string[] names = new string[] { "Fred", "Sally", "Julia", "Sam" };
            Console.WriteLine(names[0]); //print out the first one
            Console.WriteLine(names[2]); //print out the third one

            Console.WriteLine("change one and print them all out");
            //Let's suppose we need to change one
            //Let's change Same to Samantha
            names[3] = "Samantha";
            for (int i=0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Let's create an array but not initialize it. We do, however,
            //have to state the size when we create it.
            //We'll create an aray with four slots, but initially they 
            //are empty

            Console.WriteLine("create an array without initialzing it");
            string[] words = new string[4];
            words[0] = "apple";
            words[1] = "banana";
            words[2] = "Orange";
            words[3] = "watermelon";

            for (int i =0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }



        }
    }
}
