using System;

namespace classes
{
    public class BankAccount
    {
        // Declares Properties - properties are data elements
        public string Number {get;}
        public string Owner { get; set; }   
        public decimal Balance { get; }
        // Note the accountNUmber var is static, meaning it is shared across all 
        // instances of this class.
        private static int accountNumberSeed = 1234567890;

        // Set the properties using a constructor.
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }

}