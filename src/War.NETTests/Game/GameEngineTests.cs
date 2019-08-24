using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarNET.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Game.Tests
{
    [TestClass()]
    public class GameEngineTests
    {
        /// <summary>
        /// We want to make sure that the home frame is the only control in the form when starting a game.
        /// </summary>
        [TestMethod()]
        public void StartTest()
        {
            var form = new GameForm();
            var game = new GameEngine(form);
            game.Start();
            Assert.IsTrue(form.Controls.Count == 1);
            Assert.IsTrue(form.Controls[0].Name == "HomeFrame");
        }
    }
}