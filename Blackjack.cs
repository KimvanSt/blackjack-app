using BlackJack;
using System;
using System.Diagnostics;
using System.Numerics;

namespace BlackjackGame
{
    public partial class Blackjack : Form
    {
        private List<Player> _players;
        private List<Player> _playersOut;
        private Deck _deck;
        private Game _game;
        private Player _dealer;
        private Player? playerPlaying;
        private int playerAmount;
        private int StartingChips;
        private int BetPerRound;

        public Blackjack()
        {
            InitializeComponent();
            GameTextBox.Text = "Welcome. Let's play.";
            _game = new Game();
            _dealer = new Player("Dealer", DealerNameBox, DealerCard1, DealerCard2, DealerChips, Color.Black);
            _players = new List<Player> { };
            _playersOut = new List<Player> { };
            playerPlaying = null;
            BetPerRound = 10;
            StartingChips = 30;

            // Comment / uncomment to debug game only, without startup box. Add chips to players.
            //StartUpBox.Visible = false;
            //playerAmount = 3;
            //PlayerBetInput.Minimum = BetPerRound;
            //InitializeGame(false);
        }

        /* Configuration of the game, before starting
         */
        private void OnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            playerAmount = 1;
            Player1InputBox.Visible = true;
            Player2InputBox.Visible = false;
            Player3InputBox.Visible = false;
            SetUpComplete.Visible = true;
        }

        private void TwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            playerAmount = 2;
            Player1InputBox.Visible = true;
            Player2InputBox.Visible = true;
            Player3InputBox.Visible = false;
            SetUpComplete.Visible = true;
        }

        private void ThreePlayers_CheckedChanged(object sender, EventArgs e)
        {
            playerAmount = 3;
            Player1InputBox.Visible = true;
            Player2InputBox.Visible = true;
            Player3InputBox.Visible = true;
            SetUpComplete.Visible = true;
        }

        private void StartingChipsInput_TextChanged(object sender, EventArgs e)
        {
            StartingChipsLabel.Text = $" starting chips";
            if (StartingChipsInput.Text != "30")
            {
                StartingChipsInput.Modified = true;
            }
            else
            {
                StartingChipsInput.Modified = false;
            }
        }

        private void BetPerRoundInput_TextChanged(object sender, EventArgs e)
        {
            BetPerRoundLabel.Text = $" bet per round";
            if (BetPerRoundInput.Text != "10")
            {
                BetPerRoundInput.Modified = true;
            }
            else
            {
                BetPerRoundInput.Modified = false;
            }
        }

        private void SetUpComplete_Click(object sender, EventArgs e)
        {
            // If best / starting chips were modified, they are checked for validity and (if so) stored
            if (BetPerRoundInput.Modified && !int.TryParse(BetPerRoundInput.Text, out BetPerRound))
            {
                BetPerRoundLabel.Text = "Invalid number!";
                BetPerRoundLabel.ForeColor = System.Drawing.Color.Red;
            }
            else if (StartingChipsInput.Modified && !int.TryParse(StartingChipsInput.Text, out StartingChips))
            {
                StartingChipsLabel.Text = "Invalid number!";
                StartingChipsLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Debug.WriteLine("Starting game...");
                PlayerBetInput.Minimum = BetPerRound;
                StartUpBox.Visible = false;
                InitializeGame(false);
            }
        }


        /* Starting a round (adding players, placing bets)
         */
        private void InitializeGame(bool reset = true)
        {
            // If this is a new game, simply add the players
            if (!reset)
            {
                // List with the chip images to make the current players visible
                List<PictureBox> ChipImages = new List<PictureBox> { Player1ChipImage, Player2ChipImage, Player3ChipImage };

                //The players are added
                for (int p = 0; p < playerAmount; p++)
                {
                    ChipImages[p].Visible = true;
                    switch (p)
                    {
                        case 0:
                            _players.Add(new Player(Player1Name.Text, Player1NameBox, Player1Card1, Player1Card2, Player1Chips, label1.BackColor));
                            break;
                        case 1:
                            _players.Add(new Player(Player2Name.Text, Player2NameBox, Player2Card1, Player2Card2, Player2Chips, label2.BackColor));
                            break;
                        case 2:
                            _players.Add(new Player(Player3Name.Text, Player3NameBox, Player3Card1, Player3Card2, Player3Chips, label3.BackColor));
                            break;
                    }
                }
                foreach (Player player in _players)
                {
                    player.Chips = StartingChips;
                    player.ChipCountBox.Text = player.Chips.ToString();
                }
            }
            // If not, the game has to be reset, bankrupt players have to be taken out
            else
            {
                // First, remove all players that have less coins than the minimum bet and add them to the playersOut list
                List<Player> lostPlayers = new List<Player>(_players.FindAll(p => p.Chips < BetPerRound));
                foreach (Player player in lostPlayers)
                {
                    // Remove the cards and card images
                    for (int b = 2; b < player.CardImages.Count; b++)
                    {
                        Controls.Remove(player.CardImages[b]);
                    }
                    player.CardImages = new List<PictureBox>() { };
                    player.CardImage1.Image = null;
                    player.CardImage2.Image = null;
                    player.NameBox.Text = $"{player.Name} is out.";
                }
                _playersOut.AddRange(lostPlayers);
                _players.RemoveAll(p => p.Chips < BetPerRound);

                // If there are no players left, the game will restart with the starting amount of chips for all players
                if (_players.Count == 0)
                {
                    GameTextBox.Text = "Starting a new game.";
                    _players.AddRange(_playersOut);
                    _playersOut.Clear();
                    foreach (Player player in _players)
                    {
                        player.Chips = StartingChips;
                    }
                }

                // Clear player and dealer hands, nameboxes, scores, CardImages. Set status to playing.
                for (int p = 0; p <= _players.Count; p++)
                {
                    // player is the dealer unless the current value of p is an index in players
                    Player player = _dealer;
                    if (p != _players.Count)
                    {
                        player = _players[p];
                        player.ChipCountBox.Text = player.Chips.ToString();
                    }
                    player.Hand = new List<Card>() { };
                    player.Score = String.Empty;
                    player.NameBox.Text = player.Name;
                    // Removing the PictureBoxes we added for extra cards
                    for (int b = 2; b < player.CardImages.Count; b++)
                    {
                        this.Controls.Remove(player.CardImages[b]);
                    }
                    player.CardImages = new List<PictureBox>() { };
                    player.CardImage1.Image = null;
                    player.CardImage2.Image = null;
                    player.Status = 1;
                }
            }

            // Create a new deck
            _deck = new Deck();

            // The players place their bets
            PlayerPlacesBet(0);

            // Players get 2 cards
            foreach (Player player in _players)
            {
                for (int c = 0; c < 2; c++)
                {
                    player.AddCard(_deck.DrawCard());
                }
            }

            // Dealer gets 2 cards
            for (int c = 0; c < 2; c++)
            {
                _dealer.AddCard(_deck.DrawCard());
            }
        }

        private void PlayerPlacesBet(int index)
        {
            if (index == 0)
            {
                btnBox.Visible = true;
                PlayerBetButton.Visible = true;
                PlayerBetInput.Visible = true;
                HitButton.Visible = false;
                PassButton.Visible = false;
                GameTextBox.Text = $"Place your bets...";
            }

            Player player = _players[index];
            player.NameBox.BackColor = player.playerColor;
            PlayerChoice.Text = $"{player.Name}: place your bet";
            PlayerChoice.BackColor = player.playerColor;
            PlayerBetButton.Tag = index;
            PlayerBetInput.Value = BetPerRound;
            PlayerBetInput.Maximum = (decimal)player.Chips;
        }

        private void PlayerBetButton_Click(object sender, EventArgs e)
        {
            // When this button is clicked the Tag contains the index of the player setting the bet.
            // The bet is processed.
            int index = (int)PlayerBetButton.Tag;
            Player player = _players[index];
            player.Bet = Convert.ToInt32(PlayerBetInput.Value);
            player.NameBox.Text += $": Betting {player.Bet.ToString()} chips.";
            player.Chips -= player.Bet;
            player.ChipCountBox.Text = player.Chips.ToString();

            // Next, we have to check if there is a next player - if the current index is equal to playercount -1,
            // this was the last player.
            if (index == (_players.Count - 1))
            {
                player.NameBox.BackColor = Color.Green;
                // Hide the bet items from the button box and prepare the hit/pass buttons
                btnBox.Visible = false;
                PlayerChoice.BackColor = Color.Green;
                PlayerBetInput.Visible = false;
                PlayerBetButton.Visible = false;
                HitButton.Visible = true;
                PassButton.Visible = true;
                // Show the button so the players can start the round
                StartButton.Visible = true;
            }
            else
            {
                player.NameBox.BackColor = Color.Green;
                PlayerPlacesBet(index + 1);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            StartRound();
        }

        // This function is called when players hit the 'start' button. The cards are shown and any special
        // results are checked. Finally, the players get to play their rounds.
        private void StartRound()
        {
            // First the cards of the players still in the game are shown.
            foreach (Player player in _players)
            {
                player.ShowHand();
            }
            _dealer.ShowHand(true);

            // Then a check runs for special results. A busted or winning player is taken out of the game.
            foreach (Player player in _players)
            {
                GetScore(player);
            }

            // The dealer is checked for BlackJack
            GetScore(_dealer);
            if (_dealer.Score == "Blackjack")
            {
                _dealer.ShowHand(true);
                DetermineWinner();
            }
            else
            {
                // Finally, the players get to play their rounds. The first player in the list that has a status of 'playing' has to be found.
                int firstPlayer = 0;
                int playerStatus = _players[firstPlayer].Status;
                while (playerStatus != 1)
                {
                    firstPlayer++;
                    playerStatus = _players[(firstPlayer)].Status;
                }

                PlayerRound(firstPlayer);
            }

        }

        /* Playing the round (hit, pass, dealer plays, determining score)
 */
        private void PlayerRound(int index)
        {
            // This function is activated for the first time after all the bets have been placed, and after that, every time a player has finished drawing cards.
            // If a player is not currently playing, either it's the dealer's turn, or the new player is assigned the buttons
            if (playerPlaying is null)
            {
                // If the current index is the Count of players (and thus is out of range of the list of players), it's the dealer's turn
                if (index == (_players.Count))
                {
                    DealerRound();
                }
                else
                {
                    // If not, the next player can play if he is still 'playing', otherwise this function is called again for the next player.
                    playerPlaying = _players[index];
                    if (playerPlaying.Status == 1)
                    {
                        playerPlaying.NameBox.BackColor = playerPlaying.playerColor;
                        PlayerChoice.BackColor = playerPlaying.playerColor;
                        GameTextBox.Text = $"{playerPlaying.Name} is playing...";
                        PlayerChoice.Text = $"{playerPlaying.Name}: {playerPlaying.Score} points";
                        HitButton.Tag = playerPlaying;
                        PassButton.Tag = playerPlaying;
                        HitButton.Visible = true;
                        PassButton.Visible = true;
                        btnBox.Visible = true;
                    }
                    else
                    {
                        playerPlaying = null;
                        PlayerRound(index + 1);
                    }
                }
            }
            // Otherwise, the current player can pick again
            else
            {
                btnBox.Visible = true;
            }
        }

        private void GetScore(Player player)
        {
            string roundResult = ScoreHand(player.Hand);
            player.Score = roundResult;
            // If a player has a positive result or is busted, he is out of the game.
            if (new string[] { "Blackjack", "Twenty-One", "Five Card Charlie" }.Contains(roundResult))
            {
                player.NameBox.Text = $"{player.Name} has {roundResult}!";
                player.Status = -1;
            }
            // If a player is Busted, he's removed from the player list
            else if (roundResult == "Busted")
            {
                player.NameBox.Text = $"{player.Name} was busted and lost {player.Bet}.";
                player.Status = -2;
            }
            else
            {
                if (player != _dealer || (player == _dealer && player.Hand.Count > 2))
                {
                    PlayerChoice.Text = $"{player.Name}: {player.Score} points";
                }
            }
        }

        private string ScoreHand(List<Card> hand)
        {
            // If the player has aces the score will be flexible, so the amount of aces is calculated.
            int aces = 0;
            int playerScore = 0;
            foreach (Card card in hand)
            {
                if (card.Value == "aas")
                {
                    aces++;
                }
                playerScore += _game.Score(card);
            }
            return _game.GetScore(playerScore, aces, hand.Count);
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            // Hide the button box until new choice is offered
            btnBox.Visible = false;

            // The button's tag holds the player name
            Player p = HitButton.Tag as Player;

            // Draw a new card and display it
            p.AddCard(_deck.DrawCard());
            p.ShowHand();
            Controls.Add(p.CardImages.Last());
            p.CardImages.Last().BringToFront();

            // Evaluate the score of the player
            GetScore(p);

            // If the status of the player is not 1, the playerPlaying variable has to be set to null
            if (p.Status != 1)
            {
                playerPlaying = null;
                p.NameBox.BackColor = Color.Green;
                PlayerChoice.BackColor = Color.Green;
            }

            // Start the new playerround
            PlayerRound(_players.IndexOf(p) + 1);
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            // Hide the button box until new choice is offered
            btnBox.Visible = false;

            // The button's tag holds the player name
            Player p = PassButton.Tag as Player;

            // Player final score is displayed and status is updated
            p.NameBox.Text += $" {p.Name} passed with {p.Score} points.";
            p.NameBox.BackColor = Color.Green;
            PlayerChoice.BackColor= Color.Green;
            p.Status = 0;

            // playerPlaying variable is set to null
            playerPlaying = null;

            // Start the new playerround for the next player in line who has the status of playing, or for the dealer.
            PlayerRound(_players.IndexOf(p) + 1);
        }

        private void DealerRound()
        {
            while (_dealer.Status == 1)
            {
                // The dealer flips his second card or displays his new card
                _dealer.ShowHand(true);
                if (_dealer.Hand.Count > 2)
                {
                    Controls.Add(_dealer.CardImages.Last());
                    _dealer.CardImages.Last().BringToFront();
                }

                // Then, the score is calculated. If his score is 17 or higher, he passes.
                string roundResult = ScoreHand(_dealer.Hand);
                _dealer.Score = roundResult;
                if (new string[] { "Blackjack", "Twenty-One", "Five Card Charlie", "Busted" }.Contains(roundResult))
                {
                    _dealer.NameBox.Text = $"{_dealer.Name} has {roundResult}!";
                    _dealer.Status = -1;
                }
                else if (int.Parse(roundResult) > 17)
                {
                    _dealer.NameBox.Text = $"Dealer passes with {roundResult}.";
                    _dealer.Status = 0;
                }
                else
                {
                    _dealer.NameBox.Text = $"{_dealer.Name}: {roundResult}";
                    _dealer.AddCard(_deck.DrawCard());
                }
            }
            DetermineWinner();
        }

        /* End of the game (determining winner, play again / quit)
*/
        private void DetermineWinner()
        {
            GameTextBox.Text = "Round Over!";

            // If the dealer has BlackJack, all players who do not have BlackJack loose
            if (_dealer.Score == "Blackjack")
            {
                foreach (Player player in _players)
                {
                    if (player.Score != "Blackjack" && player.Status != -2)
                    {
                        player.NameBox.Text += $" {player.Name} lost {player.Bet} chips.";
                    }
                    else
                    {
                        player.NameBox.Text += $" {player.Name} pushed. {player.Bet} chips returned.";
                        player.Chips += player.Bet;
                    }
                }
            }
            // If the dealer Busted, all players that did not Bust, win
            else if (_dealer.Score == "Busted")
            {
                foreach (Player player in _players)
                {
                    if (player.Status != -2)
                    {
                        player.NameBox.Text += $" {player.Name} won ";
                        if (player.Score == "Blackjack")
                        {
                            double wonChips = Math.Ceiling(player.Bet * 2.5);
                            player.NameBox.Text += $"{wonChips} chips!";
                            player.Chips += (wonChips);
                        }
                        else
                        {
                            player.NameBox.Text += $"{player.Bet * 2} chips!";
                            player.Chips += (player.Bet * 2);
                        }
                    }
                }
            }
            // If the dealer has Twenty-One or Five Card Charlie, all players that do not have the same or blackjack loose.
            // A twenty-one beats a Five Card Charlie.
            else if (_dealer.Score == "Twenty-One" || _dealer.Score == "Five Card Charlie")
            {
                foreach (Player player in _players)
                {
                    if (new string[] { "Blackjack", "Twenty-One", "Five Card Charlie" }.Contains(player.Score))
                    {
                        if (player.Score == "Blackjack")
                        {
                            player.NameBox.Text += $" {player.Name} won {player.Bet * 2} chips!";
                            player.Chips += (player.Bet * 2);
                        }
                        else if (player.Score == _dealer.Score)
                        {
                            player.NameBox.Text += $" {player.Name} pushed. {player.Bet} chips returned.";
                            player.Chips += player.Bet;
                        }
                        else if (player.Score == "Twenty-One")
                        {
                            player.NameBox.Text += $" {player.Name} won {player.Bet * 2} chips!";
                            player.Chips += (player.Bet * 2);
                        }
                        else
                        {
                            player.NameBox.Text += $" {player.Name} lost {player.Bet} chips.";
                        }
                    }
                    else if (player.Status != -2)
                    {
                        player.NameBox.Text += $" {player.Name} lost {player.Bet} chips.";
                    }
                }
            }
            else
            {
                // If the dealer does not have a special score, he measures against all players who passed (status 0).
                int.TryParse(_dealer.Score, out int dealerScore);
                foreach (Player player in _players)
                {
                    if (player.Status == 0)
                    {
                        if (int.TryParse(player.Score, out int playerScore))
                        {
                            // If the score is higher than the dealer, this player wins
                            if (playerScore > dealerScore)
                            {
                                player.NameBox.Text += $" {player.Name} won {player.Bet * 2} chips!";
                                player.Chips += (player.Bet * 2);
                            }
                            // If the player score equal to the max, he's added to the list of winners
                            else if (playerScore == dealerScore)
                            {
                                player.NameBox.Text += $" {player.Name} pushed. {player.Bet} chips returned.";
                                player.Chips += player.Bet;
                            }
                            else
                            {
                                player.NameBox.Text += $" {player.Name} lost {player.Bet} chips.";
                            }
                        }
                    }
                    // The players who have status -1 have a special hand and will win
                    else if (player.Status == -1)
                    {
                        if (player.Score == "Blackjack")
                        {
                            player.NameBox.Text += $" {player.Name} won {player.Bet * 2.5} chips!";
                            player.Chips += (player.Bet * 2.5);
                        }
                        else
                        {
                            player.NameBox.Text += $" {player.Name} won {player.Bet * 2} chips!";
                            player.Chips += (player.Bet * 2);
                        }
                    }
                }
            }

            EndGame();
        }

        private void EndGame()
        {
            foreach (Player player in _players)
            {
                player.ChipCountBox.Text = player.Chips.ToString();
                if (player.Chips < BetPerRound)
                {
                    player.NameBox.Text += $" {player.Name} is out of chips!";
                }
            }
            StartAgainButton.Visible = true;
            StopButton.Visible = true;
        }

        private void StartAgainButton_Click(object sender, EventArgs e)
        {
            StartAgainButton.Visible = false;
            StopButton.Visible = false;
            GameTextBox.Text = "Shuffling the deck...";
            InitializeGame(true);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}