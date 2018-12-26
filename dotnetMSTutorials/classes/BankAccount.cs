using System;

namespace classes
{
    public class BankAccount
    {
        // Declares Properties - properties are data elements
        public string Number {get;}
        public string Owner { get; set; }   
        public decimal Balance { get; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }

}