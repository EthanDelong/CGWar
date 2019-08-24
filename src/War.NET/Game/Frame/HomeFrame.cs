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

        public override void HandleControl_Click(Control control)
        {
            switch (control.Name)
            {
                case "HomeButtonSettings":
                    Game.SetFrame("Rules");
                    break;

                case "HomeButtonNewGame":
                    Game.SetFrame("NewGame");
                    break;
            }
        }
    }
}