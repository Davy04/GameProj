internal class MenuRegisterCompany : Menu
{
    public override void Execute(Dictionary<string, Company> registeredCompanies)
    {
        base.Execute(registeredCompanies);
        DisplayOptionTitle("Company Registration");
        Console.Write("Enter the name of the company you want to register: ");
        string companyName = Console.ReadLine()!;
        Console.Write("Enter the bio of the company you want to register: ");
        string companyBio = Console.ReadLine()!;
        Company company = new Company(companyName, companyBio);
        registeredCompanies.Add(companyName, company);
        Console.WriteLine($"The company {companyName} was successfully registered!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}