internal class MenuShowGames : Menu
{
    public override void Execute(Dictionary<string, Company> registeredCompanies)
    {
        base.Execute(registeredCompanies);
        DisplayOptionTitle("Show Company Details");
        Console.Write("Enter the name of the company you want to know more about: ");
        string companyName = Console.ReadLine()!;
        if (registeredCompanies.ContainsKey(companyName))
        {
            Company company = registeredCompanies[companyName];
            Console.WriteLine("\nGame Catalog:");
            company.DisplayCatalog();
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
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