using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Player : Employee
    {
        public Player(string name, int playerNumber, Location location) : base(name, playerNumber, location)
        {
            Name = name;
            Number = playerNumber;
            Team = null;
            Location = location;
        }

        public Team? Team { get; set; }

        public void AssignToTeam(Team team)
        {
            Team = team;
            Team.AddPlayer(this);
        }

        public void LeaveTeam()
        {
            if (Team != null)
            {
                Team.RemovePlayer(this);
                Team = null;
            }
            else
            {
                Console.WriteLine("Player is not currently part of a team.");
            }
        }
    }
}
