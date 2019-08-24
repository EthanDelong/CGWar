using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarNET;

namespace WarNET.Game.Frame
{
    public class HomeFrame : IFrame
    {
        public GameEngine Game { get; set; }

        public Panel Panel { get; set; }

        public void HandleControl(string controlName)
        {
            switch (controlName)
            {
                case "HomeButtonSettings":
                    Game.SetFrame("Rules");
                    break;
            }
        }
    }
}