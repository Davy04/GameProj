namespace GameProj.Menus;

internal class MenuExit : Menu
{
    public override void Execute(Dictionary<string, Company> registeredCompanies)
    {
        Console.WriteLine("Goodbye :)");
    }
}