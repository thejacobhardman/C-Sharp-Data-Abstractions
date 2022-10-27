using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class CheckingAccount: Account
    {
        public CheckingAccount(string accountName, double accountBalance): base(accountName, accountBalance, "Checking Account")
        {
            AccountName = accountName;
            AccountBalance = accountBalance;
            TransactionCount = 0;
        }
    }
}
