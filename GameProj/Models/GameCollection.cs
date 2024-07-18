namespace GameProj;

public class GameCollection
{
    private List<Game> _games = new List<Game>();

    public GameCollection(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public int TotalGames => _games.Count;

    public void AddGame(Game game)
    {
        _games.Add(game);
    }

    public void ShowGames()
    {
        Console.WriteLine($"Game List from {Name}:\n");
        foreach (var game in _games)
        {
            Console.WriteLine($"Game: {game.Name}");
        }

        Console.WriteLine($"This collection has {TotalGames} games");
    }
}