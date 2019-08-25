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
        /// Create a random object to use for random layout adjustments during play (card placement).
        /// </summary>
        private Random random = new Random();

        public override void Frame_Opened()
        {
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
            }
        }

        public override void HandleControl_Click(Control control)
        {
            switch(control.Name)
            {
                case "PlayFrameButtonPlay":
                    var result = Game.PlayRound();
                    Update(result);
                    break;
            }
        }

        private void Update(Round.Result result = Round.Result.NOT_PLAYED)
        {
            CurrentRound.Text = $"{Game.Round.Count}";

            PlayerHandSize.Text = $"{Game.Player.CardsLeft}";
            OpponentHandSize.Text = $"{Game.Opponent.CardsLeft}";

            UpdateDeckPanels();

            if (result == Round.Result.NOT_PLAYED)
                return;
            
            if(result == Round.Result.WAR)
            {
                // add a new panel
            }
            else
            {
                PlayerCard.BackgroundImage = Game.Round.PlayerCards.Last().ImageFront;
                OpponentCard.BackgroundImage = Game.Round.OpponentCards.Last().ImageFront;

                PlayerCard.Location = new Point(PlayerCardBase.X + random.Next(5) * (random.Next(2) > 0 ? 1 : -1), PlayerCardBase.Y + random.Next(5) * (random.Next(2) > 0 ? 1 : -1));
                OpponentCard.Location = new Point(OpponentCardBase.X + random.Next(5) * (random.Next(2) > 0 ? 1 : -1), OpponentCardBase.Y + random.Next(5) * (random.Next(2) > 0 ? 1 : -1));
            }

            Debug.WriteLine($"Player: {Game.Round.PlayerCards.Last()} | Opponent: {Game.Round.OpponentCards.Last()}");
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
    }
}
