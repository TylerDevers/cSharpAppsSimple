using System;

namespace myConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int x = 6;

            a = a + x++;
            Console.WriteLine(a);
            Console.WriteLine(x);
            
        }
    }
}
