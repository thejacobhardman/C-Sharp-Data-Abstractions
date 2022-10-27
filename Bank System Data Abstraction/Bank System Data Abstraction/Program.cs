namespace Bank_System_Data_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new("UNC Bank");
            Member john = new("John");
            bank.AddMember(john);
            john.AddAccount(new CheckingAccount("John's Checking Account", 10.00));
            john.AddAccount(new SavingsAccount("John's Savings Account", 120.00));
            bank.UpdateBankBalance();
            john.PrintMemberInfo();

            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadKey();
        }
    }
}