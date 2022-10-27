using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class Member
    {
        public Member(string name)
        {
            Name = name;
            Balance = 0.00;
            Accounts = new List<Account>();
        }

        public string Name { get; set; }

        private double Balance;

        private readonly List<Account> Accounts;

        public void PrintMemberInfo()
        {
            Console.WriteLine("Member Info:");
            Console.WriteLine("---------------");
            Console.WriteLine("Name: " + Name);
            CalculateBalance();
            Console.WriteLine("Total Balance: $" + Balance);
            Console.WriteLine("Accounts:");
            foreach (Account account in Accounts)
            {
                Console.WriteLine("---");
                Console.WriteLine("Name: " + account.AccountName);
                Console.WriteLine("Type: " + account.GetAccountType());
                account.PrintBalance();
            }
        }

        public double CheckBalance()
        {
            return Balance;
        }

        public void CalculateBalance()
        {
            Balance = 0;

            foreach (Account account in Accounts)
            {
                Balance += account.CheckBalance();
            }
        }

        public void AddAccount(Account newAccount)
        {
            Accounts.Add(newAccount);
        }

        public List<Account> GetAccounts()
        {
            return Accounts;
        }
    }
}
