internal class Menu
{
    public void DisplayOptionTitle(string title)
    {
        int letterCount = title.Length;
        string asterisks = string.Empty.PadLeft(letterCount, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }
    public virtual void Execute(Dictionary<string, Company> registeredCompanies)
    {
        Console.Clear();
    }
}