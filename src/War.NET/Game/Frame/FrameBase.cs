using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Frame
{
    public abstract class FrameBase
    {
        /// <summary>
        /// The main game engine, set when the frame is created.
        /// </summary>
        public GameEngine Game { get; private set; }

        /// <summary>
        /// The panel associated with this frame when it's loaded.
        /// </summary>
        public Panel Panel { get; private set; }

        /// <summary>
        /// Create a new frame within the specified game and associated panel.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="panel"></param>
        public FrameBase(GameEngine game, Panel panel)
        {
            Game = game;
            Panel = panel;
        }

        /// <summary>
        /// Triggered whenever this frame is displayed on the screen.
        /// </summary>
        public virtual void Frame_Opened() { }

        /// <summary>
        /// Event to handle controls being loaded.
        /// </summary>
        /// <param name="control">The control that has loaded.</param>
        public virtual void HandleControl_Load(Control control) { }

        /// <summary>
        /// Event to handle controls being clicked.
        /// </summary>
        /// <param name="control">The control that was clicked.</param>
        public virtual void HandleControl_Click(Control control) { }

        /// <summary>
        /// Event to handle what happens when trackbars are scrolled.
        /// </summary>
        /// <param name="control">The trackbar scrolling.</param>
        public virtual void HandleControl_ValueChanged(TrackBar control) { }
    }
}
