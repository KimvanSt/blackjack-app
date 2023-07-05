using BlackjackGame;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
namespace BlackJack;

public class Player
{

    private List<Card> _hand;
    public List<Card> Hand
    {
        get { return _hand; }
        set { _hand = value; }
    }

    public string Score { get; set; }

    // Game status: 1 for playing, 0 for passed, -1 for a win, -2 for busted.
    public int Status { get; set; }
    public string Name { get; init; }
    public double Chips { get; set; }
    public int Bet { get; set; }
    public List<PictureBox> CardImages { get; set; }
    public PictureBox CardImage1 { get; init; }
    public PictureBox CardImage2 { get; init; }
    public Label NameBox { get; init; }
    public Label ChipCountBox { get; init; }
    public Color playerColor { get; init; }

    public Player(string name, Label nameBox, PictureBox cardImage1, PictureBox cardImage2, Label chipCountBox, Color Color)
    {
        Name = name;
        NameBox = nameBox;
        NameBox.Text = name;
        _hand = new List<Card>() { };
        CardImage1 = cardImage1;
        CardImage2 = cardImage2;
        CardImages = new List<PictureBox>() { };
        Score = String.Empty;
        Status = 1;
        ChipCountBox = chipCountBox;
        ChipCountBox.Text = Chips.ToString();
        playerColor = Color;
    }

    public void AddCard(Card card)
    {
        Hand.Add(card);
    }

    public bool ShowHand(bool dealer = false)
    {
        string playerCards = $"{Name} has ";
        bool newHand = false;
        if (CardImages.Count == 0)
        {
            // If the length of CardImages is 0, this is the first round and the first two card images have to be added.
            newHand = true;
        }
        int cardNum = 1;
        foreach (Card playerCard in Hand)
        {
            List<string> cardNames = Card.Show(playerCard);
            string cardName = cardNames.First();
            string cardSymbol = cardNames.Last();
            playerCards += $"{cardSymbol} ";
            if (newHand)
            {
                if (cardNum == 1)
                {
                    CardImage1.Image = BlackjackGame.Properties.Resources.ResourceManager.GetObject(cardName.Replace(" ", "_")) as Bitmap;
                    CardImages.Add(CardImage1);
                }
                else if (cardNum == 2)
                {
                    if (!dealer)
                    {
                        CardImage2.Image = BlackjackGame.Properties.Resources.ResourceManager.GetObject(cardName.Replace(" ", "_")) as Bitmap;
                        CardImages.Add(CardImage2);
                    }
                    else
                    {
                        CardImage2.Image = BlackjackGame.Properties.Resources.ResourceManager.GetObject("cardback") as Bitmap;
                        CardImages.Add(CardImage2);
                    }
                }
            }
            // If there are 2 cards in the CardImages and the player is the dealer, the second card is changed from cardback to the actual card
            else if (cardNum == 2 && CardImages.Count == 2 && dealer)
            {
                CardImage2.Image = BlackjackGame.Properties.Resources.ResourceManager.GetObject(cardName.Replace(" ", "_")) as Bitmap;
            }
            // Otherwise, a new picturebox has to be added for the new card
            else if (cardNum == Hand.Count)
            {
                int newX = CardImages.Last().Location.X + 60;
                int newY = CardImages.Last().Location.Y;
                PictureBox newCard = new PictureBox
                {
                    Name = $"{Name}Card{Hand.Count}",
                    Size = CardImages.First().Size,
                    Location = new Point(newX, newY),
                    Image = BlackjackGame.Properties.Resources.ResourceManager.GetObject(cardName.Replace(" ", "_")) as Bitmap
            };
                newCard.SizeMode = PictureBoxSizeMode.StretchImage;
                CardImages.Add(newCard);
            }
            cardNum++;
        }
        Debug.WriteLine(playerCards);
        return newHand;
    }
}