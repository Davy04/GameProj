internal class Company
{

    private List<Game> _games = new List<Game>();
    public Company(string name, string bio)
    {
        Name = name;
        Bio = bio;
        FotoPerfil = "https://www.si.com/.image/ar_1.91%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cg_faces:center%2Cq_auto:good%2Cw_1200/MTk5MjY5Mjk2NDkxMjEwMTQy/ea-sports-fc-24-cover-image.jpg";
        // Games = new List<Game>();
    }

    public string Name { get; set; }
    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    
    public int Id { get; set; }

    public void AddGame(Game game)
    {
        _games.Add(game);
    }

    public void DisplayCatalog()
    {
        foreach (var game in _games)
        {
            Console.WriteLine(game);
        }
    }

    public override string ToString()
    {
        return @$"Name: {Name}
        Bio: {Bio}";
    }
}