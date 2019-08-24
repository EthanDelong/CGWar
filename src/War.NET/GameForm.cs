using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarNET.Game;

namespace WarNET
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// The currently loaded game engine.
        /// </summary>
        private readonly GameEngine game;

        /// <summary>
        /// Set up the game form.
        /// Instead of using the default layout, we manually set our controls.
        /// To do this while still allowing us to design each frame easily in 
        /// the background, we just create tabcontrols. Inside each tab control,
        /// we add a panel labeled for our "frame". Then, we can switch between 
        /// each frame easily while making it look clean for the end user.
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            game = new GameEngine(this);
        }

        /// <summary>
        /// Initialize the game engine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            game.Init();
        }
    }
}
