using MonopolyCLI.Game;

namespace MonopolyCLI.Game
{
    public class Board
    {
        public Field[] Fields { get; private set; }
        public Board()
        {
            Fields = new Field[]
            {
                new Field(FieldType.Go, MonopolyType.None,"Go", 0, 0, new int[] { 0 }), //0
                new Field(FieldType.Property, MonopolyType.Perfume, "Chanel", 600, 500, new int[] { 20, 100, 300, 900, 1600, 2500 }),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Perfume, "Hugo Boss", 600, 500, new int[] { 40, 200, 600, 1800, 3200, 4500}),
                new Field(FieldType.Tax, MonopolyType.None, "Income Tax", 0, 0, new int[] { 2000 }),
                new Field(FieldType.Property, MonopolyType.Cars, "Mercedes", 2000, 0, new int[] { 250, 500, 1000, 2000 }),
                new Field(FieldType.Property, MonopolyType.Clothes, "Abibas", 1000, 500, new int[] { 60, 300, 900, 2700, 4000, 5500 }),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Clothes, "Puma", 1000, 500, new int[] { 60, 300, 900, 2700, 4000, 5500 }),
                new Field(FieldType.Property, MonopolyType.Clothes, "Lacoste", 1200, 500, new int[] { 80, 400, 1000, 3000, 4500, 6000 }),
                new Field(FieldType.Jail, MonopolyType.None, "Jail", 0, 0, new int[] { 0 }), //10
                new Field(FieldType.Property, MonopolyType.SocialMedia, "Viber", 1400, 750, new int[] { 100, 500, 1500, 4500, 6250, 7500 }),
                new Field(FieldType.Property, MonopolyType.VideoGames, "World of Tanks", 1500, 750, new int[] { 100, 250 }),
                new Field(FieldType.Property, MonopolyType.SocialMedia, "WhatsApp", 1400, 750, new int[] { 100, 500, 1500, 4500, 6250, 7500 }),
                new Field(FieldType.Property, MonopolyType.SocialMedia, "Telegram", 1600, 750, new int[] { 120, 600, 1800, 5000, 7000, 9000 }),
                new Field(FieldType.Property, MonopolyType.Cars, "Car Service", 2000, 0, new int[] { 250, 500, 1000, 2000 }),
                new Field(FieldType.Property, MonopolyType.Drinks, "Coca-Cola", 1800, 1000, new int[] { 140, 700, 2000, 5500, 7500, 9500}),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Drinks, "Pepsi", 1800, 1000, new int[] { 140, 700, 2000, 5500, 7500, 9500 }),
                new Field(FieldType.Property, MonopolyType.Drinks, "Fanta", 2000, 1000, new int[] { 160, 800, 2200, 6000, 8000, 10000 }),
                new Field(FieldType.Casino, MonopolyType.None, "Casino", 0, 0, new int[] { 0 }), //20
                new Field(FieldType.Property, MonopolyType.Airlines, "American Airlines", 2200, 1250, new int[] { 180, 900, 2500, 7000, 8750, 10500 }),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Airlines, "Luftwaffe", 2200, 1250, new int[] { 180, 900, 2500, 7000, 8750, 10500 }),
                new Field(FieldType.Property, MonopolyType.Airlines, "British Airlines", 2400, 1250, new int[] { 200, 1000, 3000, 7500, 9250, 11000 }),
                new Field(FieldType.Property, MonopolyType.Cars, "Ford", 2000, 0, new int[] { 250, 500, 1000, 2000 }),
                new Field(FieldType.Property, MonopolyType.Food, "Max Burgers", 2600, 1500, new int[] { 220, 1100, 3300, 8000, 9750, 11500 }),
                new Field(FieldType.Property, MonopolyType.Food, "Burger King", 2600, 1500, new int[] { 220, 1100, 3300, 8000, 9750, 11500 }),
                new Field(FieldType.Property, MonopolyType.VideoGames, "Genshin Impact", 1500, 0, new int[] {100, 250 }),
                new Field(FieldType.Property, MonopolyType.Food, "KFC", 2800, 1500, new int[] { 240, 1200, 3600, 8500, 10250, 12000 }),
                new Field(FieldType.GoToJail, MonopolyType.None, "Police", 0, 0, new int[] { 0 }), //30
                new Field(FieldType.Property, MonopolyType.Hotels, "Holiday Inn", 3000, 1750, new int[] { 260, 1300, 3900, 9000, 11000, 12750 }),
                new Field(FieldType.Property, MonopolyType.Hotels, "Radisson Blu", 3000, 1750, new int[] { 260, 1300, 3900, 9000, 11000, 12750 }),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Hotels, "Hilton", 3200, 1750, new int[] { 280, 1500, 4500, 10000, 12000, 14000 }),
                new Field(FieldType.Property, MonopolyType.Cars, "Land Rover", 2000, 0, new int[] { 250, 500, 1000, 2000 }),
                new Field(FieldType.Tax, MonopolyType.None, "Fanum Tax", 0, 0, new int[] { 2000 }),
                new Field(FieldType.Property, MonopolyType.Phones, "Apple", 3500, 2000, new int[] { 350, 1750, 5000, 11000, 13000, 15000 }),
                new Field(FieldType.Chance, MonopolyType.None, "Chance", 0, 0, new int[] { 0 }),
                new Field(FieldType.Property, MonopolyType.Phones, "Samsung", 4000, 2000, new int[] { 500, 2000, 6000, 14000, 17000, 20000 }),
            };
        }
        public Player CheckOwner(int position)
        {
            if (Fields[position].IsOwned)
            {
                return Fields[position].Owner;
            }
            return null;
        }
    }
}
