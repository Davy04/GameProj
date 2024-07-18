internal class MenuRegisterGame : Menu
{
    public override void Execute(Dictionary<string, Company> registeredCompanies)
    {
        base.Execute(registeredCompanies);
        DisplayOptionTitle("Game Registration");
        Console.Write("Enter the company whose game you want to register: ");
        string companyName = Console.ReadLine()!;
        if (registeredCompanies.ContainsKey(companyName))
        {
            Console.Write("Now enter the game title: ");
            string gameTitle = Console.ReadLine()!;
            Company company = registeredCompanies[companyName];
            company.AddGame(new Game(gameTitle));
            Console.WriteLine($"The game {gameTitle} from company {companyName} was successfully registered!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe company {companyName} was not found!");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}