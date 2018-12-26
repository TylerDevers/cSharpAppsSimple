using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        // exercises from docs.microsoft.com list collections
        static void Main(string[] args)
        {
            //WorkingWithStrings();
            //store the last two elements of the list in variables
            FibonacciSequence(18);
        }

        private static void FibonacciSequence(int number)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            // increase the fibonacci sequence by the given number
            for (int i = 0; i < number; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.Write(item + " ");
            }
        }

        private static void WorkingWithStrings()
        {
            var names = new List<string> { "Iris", "Nathan", "Random Dude" };

            names.Add("Dad");
            names.Add("Mom");
            names.Remove("Random Dude");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added the names {names[2]} and {names[3]} to the list.");

            Console.WriteLine("What name would you like to search for?");
            var check = Console.ReadLine();

            var index = names.IndexOf(check);
            if (index == -1)
            {
                Console.WriteLine($"This name is not in the list. When a name is not found. IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {check} was found at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
