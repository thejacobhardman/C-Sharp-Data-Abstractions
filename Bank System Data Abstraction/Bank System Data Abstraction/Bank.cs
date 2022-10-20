using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Abstraction
{
    internal class Bank
    {
        public Bank(string bankName)
        {
            BankName = bankName;
            BankMembers = new List<Member>();
            BankBalance = 0.00;
            BankTransactionCount = 0;
        }

        public string BankName { get; set; }

        private List<Member> BankMembers;

        private double BankBalance;

        private int BankTransactionCount;


        public void AddMember(Member newMember)
        {
            BankMembers.Add(newMember);
            UpdateBankBalance();
        }

        public void UpdateBankBalance()
        {
            BankBalance = 0.00;
            foreach (Member member in BankMembers)
            {
                foreach (Account account in member.GetAccounts())
                {
                    BankBalance += account.CheckBalance();
                }
            }
        }

        public List<Member> GetMembers()
        {
            return BankMembers;
        }

        public double CheckBalance()
        {
            return BankBalance;
        }

        public int GetTransactionCount()
        {
            return BankTransactionCount;
        }
    }
}
