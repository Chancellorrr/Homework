using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BankAccount
    {
        public BankAccount(Guid name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public Guid Name { get; private set; }
        public decimal Amount { get; private set; }
        public List<Transaction> TransactionHistory { get; set; }
    }
}
