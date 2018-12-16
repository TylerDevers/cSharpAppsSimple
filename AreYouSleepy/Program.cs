using System;

namespace AreYouSleepy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int.TryParse(Console.ReadLine(), out int hours);

            if (hours >= 8)
            {
                Console.WriteLine("You have slept well");
            }
            else
            {
                Console.WriteLine("You must be sleepy...");
            }
        }
    }
}
