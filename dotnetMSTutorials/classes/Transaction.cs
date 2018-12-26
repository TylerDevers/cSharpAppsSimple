using System;

namespace classes
{
    public class Transaction
    {
        //delcare properties
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // Constructor needs to modify properties
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }

    }
}