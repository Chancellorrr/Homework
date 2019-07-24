using System;

namespace Homework
{
    public class Transaction
    {
        public Transaction(string name, string description, decimal amount, BankAccount sourceAccount)
        {
            Name = name;
            Description = description;
            Amount = amount;
            SourceAccount = sourceAccount;
            TransactionTime = DateTime.UtcNow;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public BankAccount SourceAccount { get; private set; }
        public DateTime TransactionTime { get; set; }

       
    }
}