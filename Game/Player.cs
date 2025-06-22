using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCLI.Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Position { get; set; }
        public bool IsInJail { get; set; }
        public int JailTurns { get; set; }
        public Player(string name)
        {
            Name = name;
            Money = 15000;
            Position = 0;
            IsInJail = false;
            JailTurns = 0;
        }
        public void Move(int spaces)
        {
            if (IsInJail)
            {
                Console.WriteLine($"{Name} is in jail and cannot move for {JailTurns} more turns.");
                JailTurns--;
                return;
            }
            if (Position + spaces >= 40)
            {
                Money += 2000;
            }
            Position = (Position + spaces) % 40;
            if (Position == 30)
            {
                Position = 10;
                IsInJail = true;
                JailTurns = 2;
                Console.WriteLine($"{Name} has landed on Go to Jail and is now in jail for {JailTurns} turns.");
            }
            if (new[] { 2, 7, 17, 22, 33, 38 }.Contains(Position))
            {
                Console.WriteLine($"{Name} landed on a Chance space and will draw a Chance card.");
                Chance chance = new Chance();
                chance.DrawCard(this);
            }
            Console.WriteLine($"{Name} moved to position {Position}.");
            
        }
    }
}
