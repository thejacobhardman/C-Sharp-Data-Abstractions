using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class Account
    {
        public Account(string accountName, double accountBalance)
        {
            AccountName = accountName;
            AccountBalance = accountBalance;
            TransactionCount = 0;
        }

        public string AccountName { get; set; }

        private double AccountBalance;

        private int TransactionCount;

        public double CheckBalance()
        {
            return AccountBalance;
        }

        public void PrintBalance()
        {
            Console.WriteLine(AccountName + " Balance: $" + AccountBalance);
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
