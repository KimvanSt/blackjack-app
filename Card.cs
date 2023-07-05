using System.Drawing;
using System.Linq;
using BlackjackGame;
namespace BlackJack;

public class Card
{
    private string _suit = string.Empty;
    public string Suit
    {
        get
        {
            return _suit;
        }
    }

    private string _value = string.Empty;

    public string Value
    {
        get
        {
            return _value;
        }
    }

    public static string[] suits = new string[] { "klaveren", "schoppen", "ruiten", "harten" };
    public static string[] values = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "boer", "vrouw", "heer", "aas" };

    public Card(string suit, string value)
    {
        _suit = suit;
        _value = value;
    }

    public static List<string> Show(Card card)
    {
        string cardShown = string.Empty;
        // Suits are translated into symbols
        switch (card.Suit)
        {
            case "schoppen":
                cardShown = "♠";
                break;
            case "klaveren":
                cardShown = "♣";
                break;
            case "harten":
                cardShown = "♥";
                break;
            case "ruiten":
                cardShown = "♦";
                break;
        }
        // Values are translated into letters, if not numeric
        switch (card.Value)
        {
            case "boer":
                cardShown += "B";
                break;
            case "vrouw":
                cardShown += "V";
                break;
            case "heer":
                cardShown += "H";
                break;
            case "aas":
                cardShown += "A";
                break;
            default:
                cardShown += card.Value;
                break;
        }

        // String is returned for logging
        return new List<string> { $"{card.Suit} {card.Value}", cardShown};
    }
}
