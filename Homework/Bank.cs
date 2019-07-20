using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Bank
    {

        public List<Customer> Customers { get; private set; }

        public void Start()
        {
            Console.Write(">");
            while (true)
            {
                Console.WriteLine("Press 1 to add a new account, 2 to view an existing account");
                string customerAction = Console.ReadLine();
                ProcessAccountAction(customerAction);
            }
        }

        private void ProcessAccountAction(string customerAction)
        {
            switch (customerAction)
            {
                case "1":
                    CreateNewAccount();
                    break;
                case "2":
                    OpenAccount();
                    break;
                default:
                    Console.WriteLine("Invalid Input. Press 1 to add a new account, 2 to view an existing account");
                    break;
            }
        }

        private void OpenAccount()
        {
            Console.WriteLine("Enter the account name you want to open");
            Guid accountName = Guid.Parse(Console.ReadLine());

            Customer customer = Customers.Find(a => a.Name == accountName);
            if (customer == null)
            {
                Console.WriteLine("Does not exist");
                return;
            }

            Console.Write("Account found. Enter password: ");
            string password = Console.ReadLine();

            if (customer.Password != password) return;

            Console.WriteLine("Successful Login");

            if (customer.Accounts.Count == 0) Console.WriteLine("No accounts in this account ");

            foreach(BankAccount account in customer.Accounts)
            {
                Console.WriteLine($"{account.Name} - {account.Amount}");
            }
        }

        private void CreateNewAccount()
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            Guid accountName = Guid.NewGuid();

            Customers.Add(new Customer(accountName, password));

            Console.WriteLine($"Your account has been created. Details below: \n" +
                $"Name: {accountName}\n Password: {accountName}" +
                $"\n\nNOTE: Remember your details for future logins");
        }
    }
}
