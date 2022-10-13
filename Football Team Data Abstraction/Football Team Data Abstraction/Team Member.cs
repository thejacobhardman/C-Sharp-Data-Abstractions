using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Data_Abstraction
{
    internal class Team_Member
    {
        public Team_Member(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Role { get; set; }
    }
}
