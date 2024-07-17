namespace GameProj;

public class Game
{
    public string Name { get; set; }
    public string Company { get; set; }
    public float Price { get; set; }
    public bool Available { get; set; }
    public string EasyDesc => $"The Game {Name} belongs to {Company}";

    public void ShowDesc()
    {
        Console.WriteLine($"Game: {Name}");
        Console.WriteLine($"Company: {Company}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine(Available ? "The Game is available for purchase" : "The Game is not available for purchase");
    }
    
}