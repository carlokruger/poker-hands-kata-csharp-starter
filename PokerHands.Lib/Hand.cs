namespace PokerHands.Lib;

public class Hand
{
    public List<Card> Cards { get; }

    public Hand(List<Card> cards)
    {
        if (cards.Count != 5)
            throw new ArgumentException("A poker hand must contain exactly 5 cards");

        Cards = cards;
    }

    public static Hand Parse(string handString)
    {
        var cardStrings = handString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var cards = cardStrings.Select(cardString =>
            new Card(cardString[..^1], cardString[^1..])
        ).ToList();

        return new Hand(cards);
    }
}
