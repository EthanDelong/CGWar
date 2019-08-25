using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// The panel with the player's deck.
        /// </summary>
        private Panel PlayerDeck;

        /// <summary>
        /// The panel for the image of the opponent's played card.
        /// </summary>
        private Panel OpponentCard;

        /// <summary>
        /// The panel for the image of the opponent's deck.
        /// </summary>
        private Panel OpponentDeck;

        public override void HandleControl_Load(Control control)
        {
            switch(control.Name)
            {
                case "PlayFramePlayerCard":
                    PlayerCard = (Panel)control;
                    break;

                case "PlayFramePlayerDeck":
                    PlayerDeck = (Panel)control;
                    PlayerDeck.BackgroundImage = Card.Back;
                    break;

                case "PlayFrameOpponentCard":
                    OpponentCard = (Panel)control;
                    break;

                case "PlayFrameOpponentDeck":
                    OpponentDeck = (Panel)control;
                    OpponentDeck.BackgroundImage = Card.Back;
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

        private void Update(Round.Result result)
        {
            PlayerCard.BackgroundImage = Game.Round.PlayerCards.Last().ImageFront;
            OpponentCard.BackgroundImage = Game.Round.OpponentCards.Last().ImageFront;
            Debug.WriteLine($"Player: {Game.Round.PlayerCards.Last()} | Opponent: {Game.Round.OpponentCards.Last()}");
        }
    }
}
