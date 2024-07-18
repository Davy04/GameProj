internal class MenuShowCompanies : Menu
{
    public override void Execute(Dictionary<string, Company> registeredCompanies)
    {
        base.Execute(registeredCompanies);
        DisplayOptionTitle("Showing all registered companies in our application");

        foreach (string company in registeredCompanies.Keys)
        {
            Console.WriteLine($"Company: {company}");
        }

        Console.WriteLine("\nPress any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}