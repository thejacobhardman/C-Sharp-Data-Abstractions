using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Basket
    {
        public Basket(string name, Location origin)
        {
            Name = name;
            Location = new List<Location>
            {
                origin
            };
            Location.Add(new Location(origin.XCoordinate, origin.YCoordinate + 1));
            Location.Add(new Location(origin.XCoordinate + 1, origin.YCoordinate));
            Location.Add(new Location(origin.XCoordinate + 1, origin.YCoordinate + 1));
        }

        public string Name { get; set; }
        public List<Location> Location { get; set; }
    }
}
