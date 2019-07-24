using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BankProgram
    {


        public void Start()
        {
            List<Customer> Customers = new List<Customer>();

            //seed data

            var customer = new Customer("Customer1", "Password");
            Customers.Add(customer);

            var account1 = new BankAccount(Guid.NewGuid(), 3000);
            var account2 = new BankAccount(Guid.NewGuid(), 3000);

            customer.AddAccount(account1);
            customer.AddAccount(account2);

            var transaction1 = new Transaction("Withdrawal", "Description about transaction", 1000, account1, TransactionType.Withdrawal);
            var transaction2 = new Transaction("Deposit", "Description about transaction", 1000, account2, TransactionType.Deposit);

            account1.Withdrawal(transaction1);
            account2.Deposit(transaction2);

            Console.WriteLine("CustomerName\tAccount Number\t\t\tAmount ");
            foreach(Customer c in Customers)
            {
                foreach(BankAccount b in c.Accounts)
                {
                    Console.WriteLine($"{c.Name} - {b.Name} - {b.AmountLeft}");

                }
            }
            Console.ReadLine();
    
        }      
    }
}
