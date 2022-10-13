using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Space
    {
        public Space(Location location)
        {
            Location = location;
            IsOccupied = false;
        }

        public Location Location { get; set; }

        public bool IsOccupied { get; set; }
    }
}
