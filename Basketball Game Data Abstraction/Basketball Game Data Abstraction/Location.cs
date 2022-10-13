using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Location
    {
        public Location(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    }
}
