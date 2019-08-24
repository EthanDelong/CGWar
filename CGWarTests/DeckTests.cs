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
            deck.Shuffle(1, 0, 5);
            Assert.IsFalse(deck.Cards.SequenceEqual(preShuffle));
        }

        /// <summary>
        /// Make sure one card is dealt at a time.
        /// </summary>
        [TestMethod()]
        public void DealOneTest()
        {
            var deck = new Deck();
            var player = new Player();
            deck.DealOne(player);
            Assert.IsTrue(player.CardsLeft == 1);
        }

        /// <summary>
        /// Make sure cards are distributed equally to all players.
        /// </summary>
        [TestMethod()]
        public void DealTest()
        {
            var deck = new Deck();
            var p1 = new Player();
            var p2 = new Player();
            deck.Deal(p1, p2);
            Assert.IsTrue(p1.CardsLeft == p2.CardsLeft);
            Assert.IsTrue(deck.Cards.Count == 0);
        }

        /// <summary>
        /// Check to make sure deck is split where designated.
        /// </summary>
        [TestMethod()]
        public void CutDeckTest()
        {
            var deck = new Deck();
            var preCut = deck.Cards.ToArray();
            var cutIndex = preCut.Length / 2;
            deck.CutDeck(cutIndex);
            Assert.IsTrue(preCut.Take(cutIndex).SequenceEqual(deck.Cards.Skip(cutIndex)));
            Assert.IsTrue(preCut.Skip(cutIndex).SequenceEqual(deck.Cards.Take(cutIndex)));
        }
    }
}