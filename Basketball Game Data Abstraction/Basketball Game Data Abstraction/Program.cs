namespace Basketball_Game_Data_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basketball Methods
            Ball ball = new(new Location(2, 1));
            Court basketBallCourt = new(ball);

            Basket northBasket = new Basket("North Basket", new Location(0, 4));
            Basket southBasket = new Basket("South Basket", new Location(8, 4));

            basketBallCourt.AddBasket(northBasket);
            basketBallCourt.AddBasket(southBasket);

            // Soccer Teams
            Team soccerTeam1 = new("Patriots");
            Team soccerTeam2 = new("Broncos");

            Player soccerPlayerJimmy = new("Jimmy", 0, new Location(0, 0));
            Player soccerPlayerTommy = new("Tommy", 1, new Location(3, 5));
            Player soccerPlayerBobby = new("Bobby", 2, new Location(4, 4));

            soccerTeam1.AddPlayer(soccerPlayerJimmy);
            soccerTeam1.AddPlayer(soccerPlayerTommy);
            soccerTeam1.AddPlayer(soccerPlayerBobby);

            Player soccerPlayerLarry = new("Larry", 0, new Location(2, 4));
            Player soccerPlayerHarry = new("Harry", 1, new Location(7, 5));
            Player soccerPlayerBarry = new("Barry", 2, new Location(7, 3));

            soccerTeam2.AddPlayer(soccerPlayerLarry);
            soccerTeam2.AddPlayer(soccerPlayerHarry);
            soccerTeam2.AddPlayer(soccerPlayerBarry);

            // Football Teams
            Team footballTeam1 = new("Patriots");
            Team footballTeam2 = new("Broncos");

            Player footballPlayerJimmy = new("Jimmy", 0, new Location(0, 0));
            Player footballPlayerTommy = new("Tommy", 1, new Location(3, 5));
            Player footballPlayerBobby = new("Bobby", 2, new Location(4, 4));

            footballTeam1.AddPlayer(footballPlayerJimmy);
            footballTeam1.AddPlayer(footballPlayerTommy);
            footballTeam1.AddPlayer(footballPlayerBobby);

            Player footballPlayerLarry = new("Larry", 0, new Location(2, 4));
            Player footballPlayerHarry = new("Harry", 1, new Location(7, 5));
            Player footballPlayerBarry = new("Barry", 2, new Location(7, 3));

            footballTeam2.AddPlayer(footballPlayerLarry);
            footballTeam2.AddPlayer(footballPlayerHarry);
            footballTeam2.AddPlayer(footballPlayerBarry);

            // Basketball Teams
            Team basketballTeam1 = new("Panthers");
            Team basketballTeam2 = new("Celtics");

            Player basketballPlayerJimmy = new("Jimmy", 0, new Location(0, 0));
            Player basketballPlayerTommy = new("Tommy", 1, new Location(3, 5));
            Player basketballPlayerBobby = new("Bobby", 2, new Location(4, 4));

            basketballTeam1.AddPlayer(basketballPlayerJimmy);
            basketballTeam1.AddPlayer(basketballPlayerTommy);
            basketballTeam1.AddPlayer(basketballPlayerBobby);

            Player basketballPlayerLarry = new("Larry", 0, new Location(2, 4));
            Player basketballPlayerHarry = new("Harry", 1, new Location(7, 5));
            Player basketballPlayerBarry = new("Barry", 2, new Location(7, 3));

            basketballTeam2.AddPlayer(basketballPlayerLarry);
            basketballTeam2.AddPlayer(basketballPlayerHarry);
            basketballTeam2.AddPlayer(basketballPlayerBarry);

            // Basketball Methods
            basketBallCourt.AddTeam(basketballTeam1);
            basketBallCourt.AddTeam(basketballTeam2);

            basketBallCourt.UpdateCourt();
            basketBallCourt.PrintPlayers();
            Player closestPlayer = basketBallCourt.CalculateClosestToBall();
            basketBallCourt.PrintCourt();
            basketBallCourt.PrintBall();

            Console.WriteLine("\nThe closest player to the ball is " + closestPlayer.Name + ".");

            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadKey();
        }
    }
}