using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Iris", "Nathan", "Random Dude"};

            names.Add("Dad");
            names.Add("Mom");
            names.Remove("Random Dude");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
    }
}
