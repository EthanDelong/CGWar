using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarNET.Game.Frame;
using WarNET.Extensions;
using System.Reflection;

namespace WarNET.Game
{
    public class GameEngine
    {
        /// <summary>
        /// This is the main UI that we control through the game engine and its frames.
        /// </summary>
        private GameForm gameForm;

        /// <summary>
        /// The deck is created when the game engine is created. For new games, we 
        /// will re-shuffle the same deck instead of creating a new one each time.
        /// </summary>
        private readonly Deck deck;

        /// <summary>
        /// Collection of available frames within the game. These are populated from
        /// panels ending with "Frame" inside the "frameCollection" form. This allows 
        /// us to easily update each frame in the Visual Studio designer while making 
        /// them look clean for the user.
        /// </summary>
        private Dictionary<string, IFrame> frames;

        /// <summary>
        /// Create a new game.
        /// </summary>
        /// <param name="gameForm">Reference the main form for our game's ui.</param>
        public GameEngine(GameForm gameForm)
        {
            this.gameForm = gameForm;
            deck = new Deck();
        }

        /// <summary>
        /// Load up all of our frames and set the home page.
        /// </summary>
        public void Start()
        {
            // We use reflection to create frames from the panels inside of the tabs we created.
            // As long as we follow the standard of creating a panel with {FrameName}Frame, and 
            // make sure we have a matching IFrame extended class, it should load to our collection.
            frames = new Dictionary<string, IFrame>();
            foreach(Control control in gameForm.GetChildren<Panel>())
            {
                if(control.Name.EndsWith("Frame"))
                {
                    var test = Assembly.GetExecutingAssembly().CreateInstance($"{typeof(IFrame).Namespace}.{control.Name}");
                    if(test != null && test is IFrame)
                    {
                        IFrame frame = (IFrame)test;
                        frame.Game = this;
                        frame.Panel = (Panel) control;
                        // for each child control, handle any clicking event through our custom handler, which redirects it to the parent frame
                        control.GetChildren().ToList().ForEach(c => c.Click += new EventHandler(HandleControl_Click));
                        frames.Add(control.Name, frame);
                    }
                }
            }

            // Once we've loaded up all the frames, we can set the current frame to the home page.
            SetFrame("Home");
        }

        /// <summary>
        /// Sets the form to the specified frame/panel.
        /// </summary>
        /// <param name="name">The name of the frame to switch to.</param>
        public void SetFrame(string name)
        {
            // Allow shortening of the input frame name.
            name = name.EndsWith("Frame") ? name : $"{name}Frame";

            // If the frame doesn't exist, do nothing.
            if (!frames.ContainsKey(name))
                return;
            
            // Clear the current form controls and add the panel for the specified frame.
            gameForm.Controls.Clear();
            gameForm.Controls.Add(frames[name].Panel);
        }

        /// <summary>
        /// Handle control clicks through the parent frame.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleControl_Click(object sender, EventArgs e)
        {
            var control = (Control)sender;
            frames[control.Parent.Name].HandleControl(control.Name);
        }
    }
}
