using BlackjackGame;
namespace BlackJack;

public class Deck
{
    private List<Card> _cards = new();
    private static Random _random = new Random();

    public Deck()
    {
        _cards = FillDeck();
    }

    // A new card is drawn from the top of the deck and removed from the list
    public Card DrawCard()
    {
        if (_cards.Count == 0)
        {
            throw new ArgumentException("No cards left in deck!");
        }
        Card pick = _cards.ElementAt(0);
        _cards.RemoveAt(0);
        return pick;
    }

    // A deck is created, a Card object is created, from each suit with each value, and added to the deck.
    private List<Card> FillDeck()
    {
        List<Card> deck = new();
        List<Card> shuffled = new();
        foreach (string suit in Card.suits)
        {
            foreach (string value in Card.values)
            {
                deck.Add(new Card(suit, value));
            }
        }
        // Then, a random card is picked from the deck and added to the "Shuffled" list, so the order in the deck is
        // randomized.
        while (deck.Count > 0)
        {
            Card pick = deck.ElementAt(_random.Next(deck.Count));
            shuffled.Add(pick);
            deck.Remove(pick);
        }
        // The shuffled deck is returned.
        return shuffled;
    }
}