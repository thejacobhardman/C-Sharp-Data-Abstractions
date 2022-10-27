using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class Account
    {
        public Account(string accountName, double accountBalance, string accountType)
        {
            AccountName = accountName;
            AccountBalance = accountBalance;
            AccountType = accountType;
            TransactionCount = 0;
        }

        public string AccountName { get; set; }

        protected double AccountBalance { get; set; }

        protected string AccountType { get; set; }

        protected int TransactionCount { get; set; }

        public double CheckBalance()
        {
            return AccountBalance;
        }

        public void PrintBalance()
        {
            Console.WriteLine(AccountName + " Balance: $" + AccountBalance);
        }

        public string GetAccountType()
        {
            return AccountType;
        }

        public void AddFunds(double amount)
        {
            AccountBalance += amount;
            TransactionCount++;
        }

        public int GetTransactionCount()
        {
            return TransactionCount;
        }

        public double CloseAccount()
        {
            AccountName += "- DELETED";
            return AccountBalance;
        }
    }
}
