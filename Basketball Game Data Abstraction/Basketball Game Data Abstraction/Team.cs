using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Team
    {
        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
            Score = 0;
        }

        public string Name { get; set; }

        public List<Player> Players { get; set; }

        public int Score { get; set; }

        public void AssignPlayer(Player player)
        {
            Players.Add(player);
            player.Team = this;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }
    }
}
