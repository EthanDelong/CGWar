using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGWar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGWar.Tests
{
    [TestClass()]
    public class DeckTests
    {
        /// <summary>
        /// Ensure that new decks contain 52 cards.
        /// </summary>
        [TestMethod()]
        public void CreateDeckTest()
        {
            var deck = new Deck();
            Assert.IsTrue(deck.Cards.Count == 52);
        }

        /// <summary>
        /// Check that our shuffle method is actually changing the deck.
        /// </summary>
        [TestMethod()]
        public void ShuffleTest()
        {
            var deck = new Deck();
            var preShuffle = deck.Cards.ToArray();
            deck.Shuffle(1, 5);
            Assert.IsFalse(deck.Cards.SequenceEqual(preShuffle));
        }
    }
}