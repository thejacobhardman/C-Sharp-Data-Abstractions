﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Player
    {
        public Player(string name, int playerNumber, Location location)
        {
            Name = name;
            Number = playerNumber;
            Location = location;
        }

        public string Name { get; set; }

        public int Number { get; set; }

        public Team? Team { get; set; }

        public Location Location { get; set; }

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
            } else
            {
                Console.WriteLine("Player is not currently part of a team.");
            }
        }
    }
}