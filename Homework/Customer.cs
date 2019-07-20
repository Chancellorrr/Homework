using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Customer 
    {
        public Customer(Guid name, string password)
        {
            Accounts = new List<BankAccount>();
            Password = password;
            Name = name;
        }

        public Guid Name { get; set; }
        public List<BankAccount> Accounts { get; set; }
        public string Password { get; private set; }



    }
}
