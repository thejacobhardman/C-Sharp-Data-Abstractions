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

        public double Balance { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
