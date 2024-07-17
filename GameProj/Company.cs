namespace GameProj;

public class Company
{
    private List<GameCollection> _collections = new List<GameCollection>();
    public string Name { get; set; }

    public void AddCollection(GameCollection gameCollection)
    {
        _collections.Add(gameCollection);
    }

    public void ShowCollection()
    {
        Console.WriteLine($"Games From {Name}");
        foreach (GameCollection gameCollection in _collections)
        {
            Console.WriteLine($"Collection: {gameCollection.Name}");
            
        }
    }
}