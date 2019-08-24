using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarNET.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarNET.Game.Tests
{
    [TestClass()]
    public class CardTests
    {
        /// <summary>
        /// Card comparison testing since we wrote a custom equal function that will be critical to war plays.
        /// </summary>
        [TestMethod()]
        public void EqualsTest()
        {
            Assert.AreEqual(new Card(Rank.D2, Suit.Clubs), new Card(Rank.D2, Suit.Clubs));
            Assert.AreEqual(new Card(Rank.Ace, Suit.Spades), new Card(Rank.Ace, Suit.Spades));
            Assert.AreNotEqual(new Card(Rank.D3, Suit.Diamonds), new Card(Rank.D2, Suit.Clubs));
            Assert.AreNotEqual(101, new Card(Rank.D2, Suit.Clubs));
        }
    }
}