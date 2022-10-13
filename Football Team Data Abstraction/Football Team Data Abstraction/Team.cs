using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Data_Abstraction
{
    internal class Team
    {
        public Team(string teamName, string cityName)
        {
            TeamName = teamName;
            CityName = cityName;
            TeamMembers = new List<Team_Member>();
        }

        public string TeamName { get; set; }

        public string CityName { get; set; }

        public List<Team_Member> TeamMembers { get; set; }

        public void PrintRoster()
        {
            Console.WriteLine(CityName + " " + TeamName + " Team Roster:\n");
            Console.WriteLine("Name - Age - Role");
            foreach (Team_Member player in TeamMembers)
            {
                Console.WriteLine(player.Name + " - " + player.Age + " - " + player.Role);
            }
        }

        public void AddMember(string name, int age, string role)
        {
            TeamMembers.Add(new Team_Member(name, age, role));
        }
    }
}
