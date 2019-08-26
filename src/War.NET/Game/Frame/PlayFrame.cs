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
        /// The panel with the player's played card.
        /// </summary>
        private Panel PlayerCard;

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
        /// The panel for the image of the opponent's played card.
        /// </summary>
        private Panel OpponentCard;

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
                    PlayerCard = (Panel)control;
                    PlayerCardBase = new Point(PlayerCard.Location.X, PlayerCard.Location.Y);
                    break;

                case "PlayFramePlayerDeck":
                    PlayerDeck = (Panel)control;
                    PlayerDeck.BackgroundImage = Card.Back;
                    break;

                case "PlayFrameOpponentCard":
                    OpponentCard = (Panel)control;
                    OpponentCardBase = new Point(OpponentCard.Location.X, OpponentCard.Location.Y);
                    break;

                case "PlayFrameOpponentDeck":
                    OpponentDeck = (Panel)control;
                    OpponentDeck.BackgroundImage = Card.Back;
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
                        ButtonPlay.Text = "Play Card";
                        Status.Text = "";
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

        private List<Panel> PlayerDeckTopPanels;
        private List<Panel> OpponentDeckTopPanels;

        /// <summary>
        /// Updates the deck appearance in the frame. One card is added on top for every 5 cards in the hand.
        /// </summary>
        private void UpdateDeckPanels()
        {
            if (PlayerDeckTopPanels == null || OpponentDeckTopPanels == null)
            {
                PlayerDeckTopPanels = new List<Panel>();
                OpponentDeckTopPanels = new List<Panel>();
                for (int i = 0; i < Game.Player.CardsLeft + Game.Opponent.CardsLeft; i++)
                {
                    if (i % 5 != 0)
                        continue;

                    var playerDeckTop = new Panel
                    {
                        Location = new Point(PlayerDeck.Location.X - (i / 5) * 2, PlayerDeck.Location.Y - (i / 5) * 2),
                        Size = PlayerDeck.Size,
                        BackgroundImage = PlayerDeck.BackgroundImage,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Visible = false
                    };
                    Panel.Controls.Add(playerDeckTop);
                    PlayerDeckTopPanels.Add(playerDeckTop);

                    var opponentDeckTop = new Panel
                    {
                        Location = new Point(OpponentDeck.Location.X - (i / 5) * 2, OpponentDeck.Location.Y - (i / 5) * 2),
                        Size = OpponentDeck.Size,
                        BackgroundImage = OpponentDeck.BackgroundImage,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Visible = false
                    };
                    Panel.Controls.Add(opponentDeckTop);
                    OpponentDeckTopPanels.Add(opponentDeckTop);
                }
            }
            PlayerDeckTopPanels.ForEach(panel => panel.Visible = Game.Player.CardsLeft > PlayerDeckTopPanels.IndexOf(panel) * 5);
            OpponentDeckTopPanels.ForEach(panel => panel.Visible = Game.Opponent.CardsLeft > OpponentDeckTopPanels.IndexOf(panel) * 5);

            PlayerDeckTopPanels.Concat(OpponentDeckTopPanels).ToList().ForEach(panel => panel.BringToFront());

            PlayerDeck.BackgroundImage = Game.Player.CardsLeft > 0 ? Card.Back : Deck.Empty;
            OpponentDeck.BackgroundImage = Game.Player.CardsLeft > 0 ? Card.Back : Deck.Empty;
        }

        private List<Panel> PlayerCardsTopPanels = new List<Panel>();
        private List<Panel> OpponentCardsTopPanels = new List<Panel>();

        /// <summary>
        /// Lays out the cards on the field based on the round status.
        /// </summary>
        private void UpdateFieldPanels()
        {
            UpdateFieldCards(PlayerCard, PlayerCardBase, Game.Round.PlayerCards, ref PlayerCardsTopPanels, true);
            UpdateFieldCards(OpponentCard, OpponentCardBase, Game.Round.OpponentCards, ref OpponentCardsTopPanels, false);

            // Bring them all to front
            PlayerCardsTopPanels.Concat(OpponentCardsTopPanels).ToList().ForEach(panel => panel.BringToFront());
        }

        /// <summary>
        /// Updates cards on the playing field
        /// </summary>
        /// <param name="baseLocation">The base location for the bottom card panel.</param>
        /// <param name="bottomCard">The bottom card panel.</param>
        /// <param name="fieldCards">The current cards in the round.</param>
        /// <param name="currentPanels">The current list of card panels on the field.</param>
        private void UpdateFieldCards(Panel bottomCard, Point baseLocation, List<Card> fieldCards, ref List<Panel> currentPanels, bool offsetNegative = false)
        {
            if (fieldCards.Count == 1)
            {
                bottomCard.BackgroundImage = fieldCards.Last().ImageFront;
                bottomCard.Location = new Point(baseLocation.X + random.Next(5) * (random.Next(2) > 0 ? 1 : -1), baseLocation.Y + random.Next(5) * (random.Next(2) > 0 ? 1 : -1));
            }
            else if (fieldCards.Count > 1 && (fieldCards.Count - 1) != currentPanels.Count)
            {
                int addPanels = (fieldCards.Count - 1) - currentPanels.Count;
                do
                {
                    int offsetX = (random.Next(2, 10));
                    offsetX *= random.Next(2) == 0 ? -1 : 1;

                    int offsetY = (random.Next(2, 10));
                    offsetY *= offsetNegative ? -1 : 1;

                    var card = fieldCards.Skip(currentPanels.Count + 1).First();
                    var cardTop = new Panel
                    {
                        Location = new Point(bottomCard.Location.X - offsetX, bottomCard.Location.Y - offsetY),
                        Size = bottomCard.Size,
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
                bottomCard.BackgroundImage = null;
                currentPanels.ForEach(panel => panel.Parent.Controls.Remove(panel));
                currentPanels = new List<Panel>();
            }
        }
    }
}
