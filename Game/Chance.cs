using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MonopolyCLI.Game
{
    public class Chance
    {
        public enum ChanceCardType
        {
            RandomTravel,
            MoveBackward,
            PayMoney,
            ReceiveMoney,
            GoToJail,
            SkipTurn
        }

        public void DrawCard(Player player)
        {
            ChanceCardType chanceCardType = (ChanceCardType)Random.Shared.Next(0, Enum.GetValues(typeof(ChanceCardType)).Length);
            if(chanceCardType == ChanceCardType.RandomTravel)
            {
                int randomPosition = Random.Shared.Next(0, 40);
                Console.WriteLine($"You drew a Chance card: Random Travel! Move to position {randomPosition}.");
                player.Position = randomPosition;
            }
            else if (chanceCardType == ChanceCardType.MoveBackward)
            {
                int spaces = Random.Shared.Next(1, 6);
                Console.WriteLine($"You drew a Chance card: Move Backward! Move back {spaces} spaces.");
                player.Position = (player.Position - spaces + 40) % 40;
            }
            else if (chanceCardType == ChanceCardType.PayMoney)
            {
                int amount = Random.Shared.Next(50, 201);
                Console.WriteLine($"You drew a Chance card: Pay Money! Pay {amount} money.");
                player.Money -= amount;
            }
            else if (chanceCardType == ChanceCardType.ReceiveMoney)
            {
                int amount = Random.Shared.Next(50, 201);
                Console.WriteLine($"You drew a Chance card: Receive Money! Receive {amount} money.");
                player.Money += amount;
            }
            else if (chanceCardType == ChanceCardType.GoToJail)
            {
                Console.WriteLine("You drew a Chance card: Go to Jail! You are now in jail.");
                player.Position = 10; 
                player.JailTurns = 2;
            }
            else if (chanceCardType == ChanceCardType.SkipTurn)
            {
                Console.WriteLine("You drew a Chance card: Skip Turn! You will skip your next turn.");
                player.JailTurns = 1;
            }
        }
    };
}
