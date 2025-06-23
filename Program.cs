using MonopolyCLI.Game;

Player player = new Player("Player 1");
while(true)
{
    player.ViewStats();
    Console.WriteLine("Press 'm' to move or 'q' to quit:");
    string input = Console.ReadLine();
    if (input.ToLower() == "m")
    {
        //int spaces = Random.Shared.Next(1, 13);
        //player.Move(spaces);
        player.Move(10);
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
