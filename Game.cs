using BlackjackGame;
namespace BlackJack;

public class Game
{
    public static string ScoreBlackjack = "Blackjack";
    public static string ScoreBusted = "Busted";
    public static string ScoreFiveCardCharlie = "Five Card Charlie";
    public static string ScoreTwentyOne = "Twenty-One";
    public int Score(Card card)
    {
        // If the value can be parsed into an int, the points are that int
        // If not, it's either 11 points for Ace or 10 points for other pictures
        if (!int.TryParse(card.Value, out int points))
        {
            points = (card.Value == "aas") ? 11 : 10;
        }

        return points;
    }
    public string GetScore(int score, int aces, int cardCount)
    {
        // As long as the player has aces and the score is above 21, we count the ace as
        // 1 instead of 11
        while (aces != 0 && score > 21)
        {
            score -= 10;
            aces--;
        }
        // If the player has 21, he wins with Blackjack if he has 2 cards, and wity Twenty-One otherwise
        if (score == 21)
        {
            if (cardCount == 2)
            {
                return ScoreBlackjack;
            }
            else
            {
                return ScoreTwentyOne;
            }
        }
        // Above 21 is always busted
        else if (score > 21)
        {
            return ScoreBusted;
        }
        else
        {
            // Under 21 is five card charlie if the player has 5 cards, otherwise it's just the score
            if (cardCount == 5)
            {
                return ScoreFiveCardCharlie;
            }
            else
            {
                return score.ToString();
            }
        }
    }
}