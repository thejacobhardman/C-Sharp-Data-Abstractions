using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Employee
    {
        public Employee (string name, int number, Team? team, Location location)
        {
            Name = name;
            Number = number;
            Location = location;
        }

        public string Name { get; set; }

        public int Number { get; set; }

        public Team? Team { get; set; }

        public Location Location { get; set; }
    }
}
