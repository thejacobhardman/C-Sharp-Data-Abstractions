using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class SavingsAccount: Account
    {
        public SavingsAccount(string accountName, double accountBalance): base(accountName, accountBalance, "Savings Account")
        {
            AccountName = accountName;
            AccountBalance = accountBalance;
            TransactionCount = 0;
        }
    }
}
