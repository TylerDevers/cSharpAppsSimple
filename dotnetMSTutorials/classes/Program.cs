using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tyler", 1000);
            Console.WriteLine($"Account {account.Number} created for {account.Owner} with a balance of {account.Balance}.");
        }
    }
}
