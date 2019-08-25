using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using WarNET.Game.Frame;
using WarNET.Extensions;
using WarNET.Properties;

namespace WarNET.Game
{
    public class GameEngine
    {
        /// <summary>
        /// The deck is created when the game engine is created. For new games, we 
        /// will re-shuffle the same deck instead of creating a new one each time.
        /// </summary>
        public readonly Deck Deck;

        /// <summary>
        /// This is the main UI that we control through the game engine and its frames.
        /// </summary>
        private GameForm gameForm;

        /// <summary>
        /// Collection of available frames within the game. These are populated from
        /// panels ending with "Frame" inside the "frameCollection" form. This allows 
        /// us to easily update each frame in the Visual Studio designer while making 
        /// them look clean for the user.
        /// </summary>
        private Dictionary<string, FrameBase> frames;

        /// <summary>
        /// Gets or sets the round through the property settings.
        /// </summary>
        public int Round
        {
            get
            {
                return int.TryParse(Settings.Default.GameRound, out int round) ? round : 0;
            }
            set
            {
                Settings.Default.GameRound = value.ToString();
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// The current player.
        /// </summary>
        private Player player;

        /// <summary>
        /// The opponent.
        /// </summary>
        private Player opponent;

        /// <summary>
        /// Create a new game.
        /// </summary>
        /// <param name="gameForm">Reference the main form for our game's ui.</param>
        public GameEngine(GameForm gameForm)
        {
            this.gameForm = gameForm;
            Deck = new Deck(0);
        }

        /// <summary>
        /// Load up all of our frames and set the home page.
        /// </summary>
        public void Init()
        {
            // We use reflection to create frames from the panels inside of the tabs we created.
            // As long as we follow the standard of creating a panel with {FrameName}Frame, and 
            // make sure we have a matching IFrame extended class, it should load to our collection.
            frames = new Dictionary<string, FrameBase>();
            foreach(Control control in gameForm.GetChildren<Panel>())
            {
                if(control.Name.EndsWith("Frame"))
                {
                    var test = Assembly.GetExecutingAssembly().CreateInstance($"{typeof(FrameBase).Namespace}.{control.Name}", false, BindingFlags.CreateInstance, null, new object[] { this, control }, null, null);
                    if(test != null && test is FrameBase)
                    {
                        FrameBase frame = (FrameBase)test;
                        frames.Add(control.Name, frame);

                        // Set up event handling for all controls within this frame.
                        control.GetChildren().ToList().ForEach(child =>
                        {
                            child.Click += new EventHandler(HandleControl_Click);
                            if (child is TrackBar)
                                ((TrackBar)child).ValueChanged += new EventHandler(HandleControl_ValueChanged);
                            frame.HandleControl_Load(child);
                        });
                    }
                }
            }

            // Once we've loaded up all the frames, we can set the current frame to the home page.
            SetFrame("Home");
        }

        /// <summary>
        /// Start a new game or continue from a recently played one.
        /// </summary>
        /// <param name="loadRecent">Whether or not to continue from a recently exited game.</param>
        public void Start(bool loadRecent = false)
        {
            if(loadRecent)
            {
                // TODO: Save game state as it's being played and allow it to be read in here.
            }
            else
            {
                SetFrame("NewGame");
                Round = 0;
                player = new Player();
                opponent = new Player();
            }
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
            if (TryGetFrame(control, out FrameBase frame))
            {
                frame.HandleControl_Click(control);
            }
        }

        /// <summary>
        /// Handle control clicks through the parent frame.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleControl_ValueChanged(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;
            if (TryGetFrame(trackBar, out FrameBase frame))
            {
                frame.HandleControl_ValueChanged(trackBar);
            }
        }

        /// <summary>
        /// Attempts to load existing game settings.
        /// </summary>
        /// <returns>true if the game was able to load existing settings</returns>
        public bool Load()
        {
            // TODO: Try and load the game settings. If cards deserialize, success.
            return false;
        }

        /// <summary>
        /// Saves the current game settings.
        /// </summary>
        public void Save()
        {
            // The below properties are managed automatically outside of here.

            // Settings.Default.GamePlayerName
            // Settings.Default.GameOpponentName
            // Settings.Default.GameRound
            
            // TODO: Serialize cards in the game to a custom format
            // Settings.Default.GameCards = "";

            Settings.Default.GamePlayerHandSize = (player?.CardsLeft ?? 0).ToString();
            Settings.Default.GameOpponentHandSize = (opponent?.CardsLeft ?? 0).ToString();

            Settings.Default.Save();
        }

        /// <summary>
        /// Gets the base frame from the specified control.
        /// </summary>
        /// <param name="control">The control to get the frame for.</param>
        /// <returns>The parent frame that this control belongs to.</returns>
        private bool TryGetFrame(Control control, out FrameBase frame)
        {
            var parent = control.Parent;
            while (parent != null && !parent.Name.EndsWith("Frame"))
                parent = parent.Parent;
            return frames.TryGetValue(parent.Name, out frame);
        }
    }
}
