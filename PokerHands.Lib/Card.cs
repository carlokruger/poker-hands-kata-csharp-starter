namespace PokerHands.Lib;

public class Card
{
    public string Value { get; }
    public string Suit { get; }

    public Card(string value, string suit)
    {
        Value = value;
        Suit = suit;
    }

    public override string ToString() => $"{Value}{Suit}";
}
