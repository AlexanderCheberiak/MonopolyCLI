using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyCLI.Game;

namespace MonopolyCLI.Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Position { get; set; }
        public int JailTurns { get; set; }
        private Board board;

        public Player(string name, Board gameBoard) // Updated constructor to accept a Board instance  
        {
            Name = name;
            Money = 15000;
            Position = 0;
            JailTurns = 0;
            board = gameBoard; // Initialize the Board instance  
        }

        public void ViewStats()
        {
            Console.WriteLine($"Player: {Name}");
            Console.WriteLine($"Money: {Money}");
            Console.WriteLine($"Position: {Position}");
            if (JailTurns >= 1)
            {
                Console.WriteLine($"Turns remaining in Jail: {JailTurns}");
            }
        }

        public void Move(int spaces)
        {
            if (JailTurns >= 1)
            {
                Console.WriteLine($"{Name} is in jail and cannot move for {JailTurns} more turns.");
                Console.WriteLine("Would you like to throw dice('t') or pay 500('p') to leave Jail?");
                string input = Console.ReadLine();
                if (input.ToLower() == "t")
                {
                    int dice1 = Random.Shared.Next(1, 7);
                    int dice2 = Random.Shared.Next(1, 7);
                    if (dice1 == dice2)
                    {
                        Console.WriteLine($"You scored {dice1} and {dice2} so you get out of prison!");
                        this.JailTurns = 0;
                        this.Move(Random.Shared.Next(1, 13));
                    }
                    else
                    {
                        Console.WriteLine($"Dices are {dice1} and {dice2}, so you stay in prison!");
                    }
                    return;
                }
                else if (input.ToLower() == "p")
                {
                    if (Money >= 500)
                    {
                        Money -= 500;
                        JailTurns = 0;
                        Console.WriteLine($"{Name} has paid 500 to leave jail.");
                        this.Move(Random.Shared.Next(1, 13));
                    }
                    else
                    {
                        Console.WriteLine($"{Name} does not have enough money to pay the fine.");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    return;
                }
            }
            if (Position + spaces >= 40)
            {
                Money += 2000;
            }
            Position = (Position + spaces) % 40;
            if (Position == 30)
            {
                Position = 10;
                JailTurns = 2;
                Console.WriteLine($"{Name} has landed on Go to Jail and is now in jail for {JailTurns} turns.");
                return;
            }
            if (new[] { 2, 7, 17, 22, 33, 38 }.Contains(Position))
            {
                Console.WriteLine($"{Name} landed on a Chance space and will draw a Chance card.");
                Chance chance = new Chance();
                chance.DrawCard(this);
                return;
            }
            Console.WriteLine($"{Name} moved to position {Position}.");
            if (new[] { 4, 36 }.Contains(Position))
            {
                Console.WriteLine($"{Name} landed on a tax space and must pay 2000.");
                this.Money -= 2000;
                return;
            }
            if (Position == 10)
            {
                Console.WriteLine($"{Name} came to Jail as a visitor.");
                return;
            }
            if (board.CheckOwner(Position) == null)
            {
                Console.WriteLine($"{Name}, would you like to buy {board.Fields[Position].Name}?(y/n)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    if (this.Money >= board.Fields[Position].Price)
                    {
                        this.Money -= board.Fields[Position].Price;
                        board.Fields[Position].Owner = this;
                        Console.WriteLine($"{Name} has successfully bought {board.Fields[Position].Name}!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} doesn't have enough money to buy " +
                            $"{board.Fields[Position].Name}!");
                        return;
                    }
                }
                if (input.ToLower() == "n")
                {
                    Console.WriteLine($"{Name} refused to buy {board.Fields[Position].Name}.");
                }
            }
            else
            {
                Player owner = board.CheckOwner(Position);
                if (owner != this)
                {
                    int rent = board.Fields[Position].Rent[0];
                    Console.WriteLine($"{Name} landed on {board.Fields[Position].Name} owned by {owner.Name}. " +
                        $"Paying rent of {rent}.");
                    this.Money -= rent;
                    owner.Money += rent;
                }
                else
                {
                    Console.WriteLine($"{Name} landed on their own property: {board.Fields[Position].Name}.");
                }
            }
        }
    }
}
