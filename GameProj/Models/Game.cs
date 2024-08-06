internal class Game
{
    public Game(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Id { get; set; }
        
    public void DisplayDetails() => Console.WriteLine($"Name: {Name}");
    

    public override string ToString()
    {
        return @$"Id: {Id}
        Name: {Name}";
    }
}