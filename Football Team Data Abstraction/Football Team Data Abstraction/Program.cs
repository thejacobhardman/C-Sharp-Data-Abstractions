namespace Football_Team_Data_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team Broncos = new("Broncos", "Denver");

            Broncos.AddMember("Johnny", 32, "Head Coach");
            Broncos.AddMember("Tim", 25, "Quarterback");
            Broncos.AddMember("Flash", 21, "Running Back");
            Broncos.AddMember("Gordon", 18, "Running Back");
            Broncos.AddMember("Flex", 29, "Wide Receiver");
            Broncos.AddMember("Armstrong", 25, "Wide Receiver");
            Broncos.AddMember("Tighten", 24, "Tight End");
            Broncos.AddMember("Joe", 22, "Corner Back");
            Broncos.AddMember("Larry", 23, "Corner Back");
            Broncos.AddMember("Athena", 3000, "Safety");
            Broncos.AddMember("Saul", 39, "Safety");
            Broncos.AddMember("Keith", 26, "Defensive Tackle");
            Broncos.AddMember("Devin", 25, "Defensive End");
            Broncos.AddMember("Jacob", 25, "Line Backer");
            Broncos.AddMember("Bidome", 30, "Kicker");

            Broncos.PrintRoster();

            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadKey();
        }
    }
}