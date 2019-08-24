using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    interface IFrame
    {
        GameEngine Game { get; set; }

        Panel Panel { get; set; }

        void HandleControl(string controlName);
    }
}
