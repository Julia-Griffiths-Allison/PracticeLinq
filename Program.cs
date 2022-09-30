using System.Linq;

var videoGames = new List<string>()
{ "Pokemon", "Skyrim", "Overwatch", "Fire Emblem", "Zelda", "Apex"};

var games = videoGames.OrderBy(game => game.Length).ToList();

//foreach (var videoGame in games)
//{
//    Console.WriteLine(videoGame);
//}

games.ForEach(Console.WriteLine);