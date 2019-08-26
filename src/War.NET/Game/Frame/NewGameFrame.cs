using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    class NewGameFrame : FrameBase
    {
        /// <summary>
        /// Lower bounds for deck shuffle trackbar.
        /// </summary>
        private const int DECK_SHUFFLE_LOWER = 0;

        /// <summary>
        /// Upper bounds for deck shuffle trackbar.
        /// </summary>
        private const int DECK_SHUFFLE_UPPER = 100;

        /// <summary>
        /// Default value for deck shuffle trackbar.
        /// </summary>
        private const int DECK_SHUFFLE_DEFAULT = 8;

        /// <summary>
        /// The amount of times to shuffle the game deck.
        /// </summary>
        private int shuffleCount = DECK_SHUFFLE_DEFAULT;

        /// <summary>
        /// The index to cut the deck at.
        /// </summary>
        private int cutIndex = 0;

        public NewGameFrame(GameEngine game, Panel panel) : base(game, panel)
        {
            Title = "New Game";
        }
        
        public override void HandleControl_Load(Control control)
        {
            switch(control.Name)
            {
                case "NewGameDeckShuffleSlider":
                    ((TrackBar)control).SetRange(DECK_SHUFFLE_LOWER, DECK_SHUFFLE_UPPER);
                    ((TrackBar)control).Value = DECK_SHUFFLE_DEFAULT;
                    break;

                case "NewGameDeckCutSlider":
                    ((TrackBar)control).SetRange(0, Game.Deck.Size);
                    ((TrackBar)control).Value = Game.Deck.Size / 2;
                    break;

                case "NewGameMaxRoundsSlider":
                    ((TrackBar)control).SetRange(10, 1000);
                    ((TrackBar)control).Value = Game.MaxRounds;
                    break;

                case "NewGameWarBetSlider":
                    ((TrackBar)control).SetRange(1, 5);
                    ((TrackBar)control).Value = Game.WarBet;
                    break;
            }
        }

        /// <summary>
        /// If the user presses start, shuffle the game deck and cut at the specified index. Then move to play frame.
        /// </summary>
        /// <param name="control"></param>
        public override void HandleControl_Click(Control control)
        {
            switch(control.Name)
            {
                case "NewGameButtonStart":
                    Game.Deck.Shuffle(shuffleCount, cutIndex);
                    Game.Start();
                    break;

                case "NewGameButtonCancel":
                    Game.SetFrame("Home");
                    break;
            }
        }

        public override void HandleControl_ValueChanged(TrackBar control)
        {
            UpdateScrollText(control);
        }

        private void UpdateScrollText(TrackBar trackBar)
        {
            string customText = null;
            switch (trackBar.Name)
            {
                case "NewGameDeckShuffleSlider":
                    shuffleCount = trackBar.Value;
                    break;

                case "NewGameDeckCutSlider":
                    cutIndex = trackBar.Value;
                    break;

                case "NewGameMaxRoundsSlider":
                    Game.MaxRounds = trackBar.Value;
                    if(trackBar.Value >= GameEngine.MAXROUNDS_UPPER)
                        customText = "Infinite";
                    break;

                case "NewGameWarBetSlider":
                    Game.WarBet = trackBar.Value;
                    break;
            }

            Label label = new Label();
            trackBar.Parent.Text = $"{trackBar.Parent.Text.Split(':')[0]}: {customText ?? trackBar.Value.ToString()}";
        }
    }
}
