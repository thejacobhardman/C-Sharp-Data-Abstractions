using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Ball
    {
        public Ball(Location location)
        {
            Location = location;
        } 

        public Location Location { get; set; }
        public Team? PossessedBy { get; set; }
    }
}
