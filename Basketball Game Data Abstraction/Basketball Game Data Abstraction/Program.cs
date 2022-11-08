namespace Basketball_Game_Data_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(new Location(2, 1));
            Court basketBallCourt = new(ball);

            Basket northBasket = new Basket("North Basket", new Location(0, 4));
            Basket southBasket = new Basket("South Basket", new Location(8, 4));

            basketBallCourt.AddBasket(northBasket);
            basketBallCourt.AddBasket(southBasket);

            Team team1 = new("Panthers");
            Team team2 = new("Celtics");

            Player jimmy = new("Jimmy", 0, team1, new Location(0, 0));
            Player tommy = new("Tommy", 1, team1, new Location(3, 5));
            Player bobby = new("Bobby", 2, team1, new Location(4, 4));

            team1.AddPlayer(jimmy);
            team1.AddPlayer(tommy);
            team1.AddPlayer(bobby);

            Player larry = new("Larry", 0, team2, new Location(2, 4));
            Player harry = new("Harry", 1, team2, new Location(7, 5));
            Player barry = new("Barry", 2, team2, new Location(7, 3));

            team2.AddPlayer(larry);
            team2.AddPlayer(harry);
            team2.AddPlayer(barry);

            basketBallCourt.AddTeam(team1);
            basketBallCourt.AddTeam(team2);

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