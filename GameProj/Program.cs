using GameProj.Menus;
using GameProj.Menus;
using GameProj.DB;

try
{
    var CompanyDAL = new CompanyDAL();
    CompanyDAL.Adicionar(new Company("Twoca", "2K é uma empresa que faz jogos de esportes desde 1900 e blau"));
    var listaCompany = CompanyDAL.Listar();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
return;

Company nintendo = new Company("Nintendo", "Nintendo Game Company");
Company sony = new("Sony", "Sony Game Company");

Dictionary<string, Company> registeredCompanies = new();
registeredCompanies.Add(nintendo.Name, nintendo);
    
registeredCompanies.Add(sony.Name, sony);

Dictionary<int, Menu> options = new();
options.Add(1, new MenuRegisterCompany());
options.Add(2, new MenuRegisterGame());
options.Add(3, new MenuShowCompanies());
options.Add(4, new MenuShowGames());
options.Add(0, new MenuExit());

void DisplayLogo()
{
    Console.WriteLine(@"

░██████╗░░█████╗░███╗░░░███╗███████╗░██████╗ 
██╔════╝░██╔══██╗████╗░████║██╔════╝██╔════╝ 
██║░░██╗░███████║██╔████╔██║█████╗░░╚█████╗░ 
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░░╚═══██╗ 
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██████╔╝ 
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░

");
    Console.WriteLine("Welcome to Screen Games 3.0!");
}

void DisplayMenuOptions()
{
    DisplayLogo();
    Console.WriteLine("\nType 1 to register a company");
    Console.WriteLine("Type 2 to register a game from a company");
    Console.WriteLine("Type 3 to show all companies");
    Console.WriteLine("Type 4 to display all games from a company");
    Console.WriteLine("Type 0 to exit");

    Console.Write("\nType your option: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionNumeric = int.Parse(chosenOption);

    if (options.ContainsKey(chosenOptionNumeric))
    {
        Menu menuToDisplay = options[chosenOptionNumeric];
        menuToDisplay.Execute(registeredCompanies);
        if (chosenOptionNumeric > 0) DisplayMenuOptions();
    } 
    else
    {
        Console.WriteLine("Invalid option");
    }
}

DisplayMenuOptions();
