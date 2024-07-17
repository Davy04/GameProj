using GameProj;

GameCollection eaGameCollection = new GameCollection();
eaGameCollection.Name = "Fifa Soccer";

Game game1 = new Game();
game1.Name = "Fifa 16";
    
Game game2 = new Game();
game2.Name = "Fifa 17";

Game game3 = new Game();
game3.Name = "Fifa 24";

eaGameCollection.AddGame(game1);
eaGameCollection.AddGame(game2);
eaGameCollection.AddGame(game3);

Company ea = new Company();
ea.Name = "EA";
ea.AddCollection(eaGameCollection);
ea.ShowCollection();