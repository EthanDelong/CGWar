using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarNET.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        /// <summary>
        /// Test that GiveCard is only giving one card at a time.
        /// </summary>
        [TestMethod()]
        public void GiveCardTest()
        {
            var player = new Player();
            player.GiveCard(new Card(Rank.Ace, Suit.Clubs));
            Assert.IsTrue(player.CardsLeft == 1);
        }
        
        /// <summary>
        /// Test that the next card being played is always top-first, and once run out returns null.
        /// </summary>
        [TestMethod()]
        public void PlayNextTest()
        {
            var player = new Player();
            var firstCard = new Card(Rank.Ace, Suit.Clubs);
            player.GiveCard(firstCard);

            var deck = new Deck();
            deck.Deal(player);

            while (player.CardsLeft > 1)
                Assert.IsInstanceOfType(player.PlayNext(), typeof(Card));

            Assert.AreEqual(firstCard, player.PlayNext());
            Assert.IsNull(player.PlayNext());
        }
    }
}