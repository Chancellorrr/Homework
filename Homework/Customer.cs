using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Customer
    {
        public Customer(string name, string password)
        {
            Accounts = new List<BankAccount>();
            Password = password;
            Name = name;
        }

        public string Name { get; private set; }
        public List<BankAccount> Accounts { get; private set; }
        public string Password { get; private set; }

        public void AddAccount(BankAccount account)
        { 
            Accounts.Add(account);
        }

        public void DeleteAccount(BankAccount account)
        {
            Accounts.Remove(account);
        }
    }
}
