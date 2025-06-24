using MonopolyCLI.Game;
using MonopolyCLI.Game;
Board board = new Board();
Player[] players = new Player[]
    {
        new Player("Sasha", board),
        new Player("Artem", board),
        new Player("Yura", board)
    };

while (true)
{
    foreach (Player player in players)
    {
        player.ViewStats();
        Console.WriteLine("Press 'm' to move or 'q' to quit:");
        string input = Console.ReadLine();
        if (input.ToLower() == "m")
        {
            //int spaces = Random.Shared.Next(1, 13);
            //player.Move(spaces);
            player.Move(6);
        }
        else if (input.ToLower() == "q")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}

//Player player = new Player("Player 1", board);
//while (true)
//{
//player.ViewStats();
//Console.WriteLine("Press 'm' to move or 'q' to quit:");
//string input = Console.ReadLine();
//if (input.ToLower() == "m")
//{
//    int spaces = Random.Shared.Next(1, 13);
//    player.Move(spaces);
//    //player.Move(10);
//}
//else if (input.ToLower() == "q")
//{
//    break;
//}
//else
//{
//    Console.WriteLine("Invalid input. Please try again.");
//}
//}
