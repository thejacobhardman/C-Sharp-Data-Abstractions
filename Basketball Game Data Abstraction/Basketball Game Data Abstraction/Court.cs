using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Game_Data_Abstraction
{
    internal class Court
    {
        public Court(Ball ball)
        {
            Spaces = new Space[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Spaces[i, j] = new Space(new Location(i, j));
                }
            }
            Teams = new List<Team>();
            Ball = ball;
            Baskets = new List<Basket>();
        }

        public Space[,] Spaces { get; set; }

        public Ball Ball { get; set; }

        public List<Team> Teams { get; set; }

        public List<Basket> Baskets { get; set; }

        public void AddBasket(Basket basket)
        {
            Baskets.Add(basket);
        }

        public void PrintCourt()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    if (Spaces[i,j].IsOccupied)
                    {
                        Console.Write("| X |");
                    } else
                    {
                        Console.Write("| - |");
                    }
                }
            }
        }

        public void PrintBall()
        {
            Console.WriteLine("\n\nThe ball is at " + Ball.Location.XCoordinate + ", " + Ball.Location.YCoordinate);
        }

        public void PrintPlayers()
        {
            Console.WriteLine("\nPlayers:");
            foreach (Team team in Teams)
            {
                foreach (Player player in team.Players)
                {
                    Console.WriteLine(player.Name + " - Location: " + player.Location.XCoordinate + ", " + player.Location.YCoordinate);
                }
            }
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void UpdateCourt()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Spaces[j, i].IsOccupied = false;
                }
            }

            foreach (Team team in Teams)
            {
                foreach (Player player in team.Players)
                {
                    Spaces[player.Location.YCoordinate, player.Location.XCoordinate].IsOccupied = true;
                }
            }

            foreach (Basket basket in Baskets)
            {
                foreach (Location location in basket.Location)
                {
                    Spaces[location.XCoordinate, location.YCoordinate].IsOccupied = true;
                }
            }

            Spaces[Ball.Location.YCoordinate, Ball.Location.XCoordinate].IsOccupied = true;
        }

        public Player CalculateClosestToBall()
        {
            int maxDistance = (int)Math.Sqrt((9 - 0) ^ 2 + (9 - 0) ^ 2);
            int closestDistance = maxDistance;
            Player closestPlayer = new("placeholder", 0, new Location(0, 0));
            foreach (Team team in Teams)
            {
                foreach (Player player in team.Players)
                {
                    int playerDistance = (int)Math.Sqrt((player.Location.YCoordinate - Ball.Location.YCoordinate)^2 + (player.Location.XCoordinate - Ball.Location.XCoordinate)^2);
                    if (playerDistance < closestDistance) {
                        closestDistance = playerDistance;
                        closestPlayer = player;
                    }
                }
            }

            return closestPlayer;
        }

        public void CalculateIfScored()
        {
            foreach (Basket basket in Baskets)
            {
                foreach (Location location in basket.Location)
                {
                    if (Ball.Location == location)
                    {
                        Console.WriteLine("Score!");
                    }
                }
            }
        }
    }
}
