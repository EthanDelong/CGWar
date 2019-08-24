using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    public class RulesFrame : FrameBase
    {
        public RulesFrame(GameEngine game, Panel panel) : base(game, panel) { }
       
        public override void HandleControl_Click(Control control)
        {
            switch (control.Name)
            {
                case "RulesButtonSave":
                    Game.SetFrame("Home");
                    break;
            }
        }
    }
}