using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    public class HomeFrame : FrameBase
    {
        public HomeFrame(GameEngine game, Panel panel) : base(game, panel) { }

        /// <summary>
        /// Switch between Frames
        /// </summary>
        /// <param name="control"></param>
        public override void HandleControl_Click(Control control)
        {
            switch (control.Name)
            {
                case "HomeButtonNewGame":
                    Game.SetFrame("NewGame");
                    break;

                case "HomeButtonContinue":
                    // Game.Start(true);
                    break;

                case "HomeButtonSettings":
                    Game.SetFrame("Rules");
                    break;
            }
        }
    }
}