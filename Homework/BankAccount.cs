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
            TransactionHistory = new List<Transaction>();
            Name = name;
            AmountLeft = amount;
        }

        public Guid Name { get; private set; }
        public decimal AmountLeft { get; private set; }
        public List<Transaction> TransactionHistory { get; private set; }

        public void Deposit(Transaction transaction)
        {
            AmountLeft += transaction.Amount;
            TransactionHistory.Add(transaction);
        }

        public void Withdrawal(Transaction transaction)
        {
            if (transaction.Amount < AmountLeft)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            AmountLeft -= transaction.Amount;
            TransactionHistory.Add(transaction);

        }
    }
}
