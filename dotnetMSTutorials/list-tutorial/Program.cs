using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithStrings();
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
