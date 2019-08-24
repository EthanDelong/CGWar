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
        private const int DECK_SHUFFLE_LOWER = 0;
        private const int DECK_SHUFFLE_UPPER = 100;
        private const int DECK_SHUFFLE_DEFAULT = 8;

        public NewGameFrame(GameEngine game, Panel panel) : base(game, panel) { }

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
            }
        }

        public override void HandleControl_ValueChanged(TrackBar control)
        {
            UpdateScrollText(control);
        }

        private void UpdateScrollText(TrackBar trackBar)
        {
            Label label = new Label();
            trackBar.Parent.Text = $"{trackBar.Parent.Text.Split(':')[0]}: {trackBar.Value}";
        }
    }
}
