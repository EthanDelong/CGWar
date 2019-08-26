using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    public class AboutFrame : FrameBase
    {
        public AboutFrame(GameEngine game, Panel panel) : base(game, panel) { }

        public override void HandleControl_Click(Control control)
        {
            switch (control.Name)
            {
                case "AboutButtonHome":
                    Game.SetFrame("Home");
                    break;
            }
        }

        public override void HandleControl_Load(Control control)
        {
            switch(control.Name)
            {
                case "AboutFrameBrowser":
                    var about = (WebBrowser)control;
                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{GameEngine.RESOURCE_PATH}.AboutPage.html"))
                    using (var reader = new StreamReader(stream))
                    {
                        about.DocumentText = reader.ReadToEnd();
                    }
                    break;
            }
        }
    }
}
