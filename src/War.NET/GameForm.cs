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
            Controls.Clear();
            Controls.Add(HomeFrame);
        }

        /// <summary>
        /// Initialize the game engine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            GameEngine game = new GameEngine();

        }

        private void RulesSelectButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButtonNewGame_Click(object sender, EventArgs e)
        {

        }

        private void HomeButtonContinue_Click(object sender, EventArgs e)
        {

        }

        private void HomeButtonSelectRules_Click(object sender, EventArgs e)
        {

        }
    }
}
