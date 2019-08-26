using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    public class PlayFrame : FrameBase
    {
        public PlayFrame(GameEngine game, Panel panel) : base(game, panel) { }
        
        /// <summary>
        /// The base location of the player card panel.
        /// </summary>
        private Point PlayerCardBase;

        /// <summary>
        /// The label corresponding to the player's hand.
        /// </summary>
        private Label PlayerHandSize;

        /// <summary>
        /// The panel with the player's deck.
        /// </summary>
        private Panel PlayerDeck;

        /// <summary>
        /// The base location of the opponent card panel.
        /// </summary>
        private Point OpponentCardBase;

        /// <summary>
        /// The panel for the image of the opponent's deck.
        /// </summary>
        private Panel OpponentDeck;

        /// <summary>
        /// The label corresponding to the opponent's hand.
        /// </summary>
        private Label OpponentHandSize;

        /// <summary>
        /// Label for the current round number.
        /// </summary>
        private Label CurrentRound;

        /// <summary>
        /// The play button, so we can modify text.
        /// </summary>
        private Button ButtonPlay;

        /// <summary>
        /// The restart button, displayed at the end of game.
        /// </summary>
        private Button ButtonRestart;

        /// <summary>
        /// Status label at top of frame.
        /// </summary>
        private Label Status;

        /// <summary>
        /// Create a random object to use for random layout adjustments during play (card placement).
        /// </summary>
        private Random random = new Random();

        public override void Frame_Opened()
        {
            Status.Text = "";
            Update();
        }

        public override void HandleControl_Load(Control control)
        {
            switch(control.Name)
            {
                case "PlayFramePlayerCard":
                    var playerCard = (Panel)control;
                    PlayerCardBase = new Point(playerCard.Location.X, playerCard.Location.Y);
                    break;

                case "PlayFramePlayerDeck":
                    PlayerDeck = (Panel)control;
                    break;

                case "PlayFrameOpponentCard":
                    var oppCard = (Panel)control;
                    OpponentCardBase = new Point(oppCard.Location.X, oppCard.Location.Y);
                    break;

                case "PlayFrameOpponentDeck":
                    OpponentDeck = (Panel)control;
                    break;

                case "PlayFrameLabelPlayerHandSize":
                    PlayerHandSize = (Label)control;
                    break;

                case "PlayFrameLabelOpponentHandSize":
                    OpponentHandSize = (Label)control;
                    break;

                case "PlayFrameLabelRoundCount":
                    CurrentRound = (Label)control;
                    break;

                case "PlayFrameButtonPlay":
                    ButtonPlay = (Button)control;
                    break;

                case "PlayFrameButtonRestart":
                    ButtonRestart = (Button)control;
                    break;

                case "PlayFrameStatus":
                    Status = (Label)control;
                    break;
            }
        }

        private bool gameover = false;
        private bool in_round = false;

        public override void HandleControl_Click(Control control)
        {
            switch(control.Name)
            {
                case "PlayFrameButtonPlay":
                    if (gameover)
                    {
                        Finish("Home");
                    }
                    else if(in_round && Game.Round.LastResult != Round.Result.WAR && Game.Round.LastResult != Round.Result.NOT_PLAYED)
                    {
                        Game.Round.Finish();
                        in_round = false;
                        if(Game.Round.LastResult == Round.Result.GAMEOVER_TIE_MAXROUNDS)
                        {
                            GameOver($"Max rounds reached, game ends in a tie!");
                        }
                        else
                        {
                            ButtonPlay.Text = "Play Card";
                            Status.Text = "";
                        }
                    }
                    else
                    {
                        var result = Game.Round.Next();
                        in_round = true;
                        switch (result)
                        {
                            // GAMEOVER
                            case Round.Result.GAMEOVER_OPPONENT_WIN:
                                GameOver($"{Properties.Settings.Default.GameOpponentName} wins game!");
                                break;

                            case Round.Result.GAMEOVER_PLAYER_WIN:
                                GameOver($"{Properties.Settings.Default.GamePlayerName} wins game!");
                                break;

                            case Round.Result.GAMEOVER_TIE:
                                GameOver($"The game is a tie!");
                                break;

                            case Round.Result.GAMEOVER_TIE_MAXROUNDS:
                                GameOver($"Max rounds reached, game ends in a tie!");
                                break;

                            // WAR
                            case Round.Result.WAR:
                                ButtonPlay.Text = "Place Bet";
                                Status.Text = $"Get ready! Bet {Game.WarBet} card{(Game.WarBet > 1 ? "s" : "")}! - {Game.Round.CurrentWarBet}/{Game.WarBet}";
                                break;

                            case Round.Result.NOT_PLAYED:
                                ButtonPlay.Text = "Play Card";
                                Status.Text = "WAR!!!";
                                break;
                                
                            // ROUND WINNINGS
                            case Round.Result.PLAYER_WIN:
                                Status.Text = $"{Properties.Settings.Default.GamePlayerName} wins {Game.Round.Pool.Count} cards!";
                                ButtonPlay.Text = "Next Round";
                                break;

                            case Round.Result.OPPONENT_WIN:
                                Status.Text = $"{Properties.Settings.Default.GameOpponentName} wins {Game.Round.Pool.Count} cards!";
                                ButtonPlay.Text = "Next Round";
                                break;
                        }
                    }
                    Update();
                    break;

                case "PlayFrameButtonRestart":
                    Finish("NewGame");
                    break;
            }
        }

        private void GameOver(string statusMessage)
        {
            Status.Text = statusMessage;
            ButtonRestart.Enabled = true;
            ButtonRestart.Visible = true;
            ButtonPlay.Text = "End Game";
            gameover = true;
        }

        private void Finish(string nextFrame)
        {
            Game.SetFrame(nextFrame);
            Game.Round.Finish();
            gameover = false;
            in_round = false;
            ButtonPlay.Text = "Play Card";
            ButtonRestart.Enabled = false;
            ButtonRestart.Visible = false;
        }

        private void Update()
        {
            var lastResult = Game.Round.LastResult;

            CurrentRound.Text = $"{Game.Round.Count}";

            PlayerHandSize.Text = $"{Game.Player.CardsLeft}";
            OpponentHandSize.Text = $"{Game.Opponent.CardsLeft}";

            UpdateDeckPanels();

            UpdateFieldPanels();
        }

        private List<Panel> PlayerDeckTopPanels = new List<Panel>();
        private List<Panel> OpponentDeckTopPanels = new List<Panel>();

        /// <summary>
        /// Updates the deck appearance in the frame. One card is added on top for every 5 cards in the hand.
        /// </summary>
        private void UpdateDeckPanels()
        {
            UpdateDeckCards(Game.Player, PlayerDeck, PlayerDeckTopPanels);
            UpdateDeckCards(Game.Opponent, OpponentDeck, OpponentDeckTopPanels);
        }

        private void UpdateDeckCards(Player player, Panel baseDeck, List<Panel> deckPanels)
        {
            var cardsPerPanel = 5F;
            int balance = (int)Math.Floor(player.CardsLeft / cardsPerPanel);
            balance += player.CardsLeft > 1 ? 1 : 0;
            balance += player.CardsLeft > 0 ? 1 : 0;
            balance -= deckPanels.Count;

            // increase deck size
            if (balance > 0)
            {
                do
                {
                    int offset = deckPanels.Count * 2;
                    var newTopCard = new Panel
                    {
                        Location = new Point(baseDeck.Location.X - offset, baseDeck.Location.Y - offset),
                        Size = baseDeck.Size,
                        BackgroundImage = Card.Back,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    Panel.Controls.Add(newTopCard);
                    deckPanels.Add(newTopCard);
                }
                while (--balance > 0);
            }
            // shrink deck size
            if (balance < 0)
            {
                do
                {
                    var topCard = deckPanels.Last();
                    topCard.Parent.Controls.Remove(topCard);
                    deckPanels.Remove(topCard);
                }
                while (++balance < 0);
            }
            deckPanels.ForEach(panel => panel.BringToFront());
        }

        private List<Panel> PlayerCardsTopPanels = new List<Panel>();
        private List<Panel> OpponentCardsTopPanels = new List<Panel>();

        /// <summary>
        /// Lays out the cards on the field based on the round status.
        /// </summary>
        private void UpdateFieldPanels()
        {
            UpdateFieldCards(PlayerCardBase, Game.Round.PlayerCards, ref PlayerCardsTopPanels, true);
            UpdateFieldCards(OpponentCardBase, Game.Round.OpponentCards, ref OpponentCardsTopPanels, false);

            // Bring them all to front
            PlayerCardsTopPanels.Concat(OpponentCardsTopPanels).ToList().ForEach(panel => panel.BringToFront());
        }

        /// <summary>
        /// Updates cards on the playing field
        /// </summary>
        /// <param name="baseLocation">The base location for the bottom card panel.</param>
        /// <param name="fieldCards">The current cards in the round.</param>
        /// <param name="currentPanels">The current list of card panels on the field.</param>
        private void UpdateFieldCards(Point baseLocation, List<Card> fieldCards, ref List<Panel> currentPanels, bool offsetNegative = false)
        {
            if (fieldCards.Any() && fieldCards.Count != currentPanels.Count)
            {
                int addPanels = fieldCards.Count - currentPanels.Count;
                do
                {
                    int offsetX = (random.Next(2, 10));
                    offsetX *= random.Next(2) == 0 ? -1 : 1;

                    int offsetY = (random.Next(2, 10));
                    offsetY *= offsetNegative ? -1 : 1;

                    var card = fieldCards.Skip(currentPanels.Count).First();
                    var cardTop = new Panel
                    {
                        Location = new Point(baseLocation.X - offsetX, baseLocation.Y - offsetY),
                        Size = PlayerDeck.Size,
                        BackgroundImage = fieldCards.IndexOf(card) % (Game.WarBet + 1) == 0 ? card.ImageFront : card.ImageBack,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    Panel.Controls.Add(cardTop);
                    currentPanels.Add(cardTop);
                }
                while (--addPanels > 0);
            }
            else
            {
                currentPanels.ForEach(panel => panel.Parent.Controls.Remove(panel));
                currentPanels = new List<Panel>();
            }
        }
    }
}
