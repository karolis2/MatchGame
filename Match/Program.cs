// See https://aka.ms/new-console-template for more information

//TODO: Write introduction of the gamer rules when the game starts.
//TODO: Instead of declaring MATCH!, I would declare DUEL and then players compete, the winner would be the one with the higher card.
//TODO: User would choose which match to use.

using CardDealingService;

Console.WriteLine("Hello, Player!");
Console.WriteLine("PLease enter the number of card packs you would like in your game!");

var input = Console.ReadLine();

var successfullyParsed = int.TryParse(input, out var packsCount);

if (successfullyParsed)
{
    GameEngine.PlayGame(packsCount);
}
else
{
    Console.WriteLine("Please enter valid number!");
}
