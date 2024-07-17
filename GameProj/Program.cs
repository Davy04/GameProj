using GameProj;

Game game1 = new Game();
game1.Name = "Fifa 24";
game1.Company = "EA Games";
game1.Price = 300f;
game1.Available = true;
game1.ShowDesc();

Console.WriteLine(game1.EasyDesc);