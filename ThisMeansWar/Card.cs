namespace ThisMeansWar
{
    public class Card
    {
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }
    }

    public enum FaceValue
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
