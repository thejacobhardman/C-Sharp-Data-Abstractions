using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class Account
    {
        public Account(string accountName, string accountType, double accountBalance)
        {
            AccountName = accountName;
            AccountType = accountType;
            AccountBalance = accountBalance;
            TransactionCount = 0;
        }

        public string AccountName { get; set; }

        public string AccountType { get; set; }

        public double AccountBalance { get; set; }

        public int TransactionCount { get; set; }

        public double CheckBalance()
        {
            return AccountBalance;
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
            AccountType += "- DELETED";
            return AccountBalance;
        }
    }
}
