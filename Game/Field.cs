namespace Monopoly.Game
{
    public class Field
    {
        public FieldType Type { get; set; }
        public MonopolyType MonopolyType { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int[] Rent { get; set; }
        public bool IsOwned { get; set; }
        public int Houses { get; set; } = 0;
        public int HouseCost { get; set; }
        public int MortgageSum { get; set; }
        public int CancelMortgageCost { get; set; }
        public Field(FieldType type, MonopolyType monoType, string name, int price, int houseCost, int[] rent)
        {
            Type = type;
            MonopolyType = monoType;
            Name = name;
            Price = price;
            HouseCost = houseCost;
            Rent = rent;
            IsOwned = false;
            MortgageSum = price / 2;
            CancelMortgageCost = (int)(price * 0.6);
        }
        public void Upgrade()
        {
            Houses++;
        }

    }
    public enum FieldType
    {
        Go,
        Property,
        Chance,
        Tax,
        Jail,
        Casino,
        GoToJail
    }
    public enum MonopolyType
    {
        Perfume,
        Cars,
        Clothes,
        SocialMedia,
        VideoGames,
        Drinks,
        Airlines,
        Food,
        Hotels,
        Phones,
        None
    }
}