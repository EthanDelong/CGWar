using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarNET.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;

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

        /// <summary>
        /// Test that the card image matches the one we saved in our resource.
        /// </summary>
        [TestMethod()]
        public void CreateImageFrontTest()
        {
            var card = new Card(Rank.D7, Suit.Hearts);
            var testImageName = $"Test{card.Rank.ToString().TrimStart('D')}{card.Suit}.png";
            var testImagePath = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(res => res.Contains(testImageName))?.First();
            Assert.IsNotNull(testImagePath);
            var testImage = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(testImagePath));
            Assert.IsNotNull(testImage);
            Assert.AreEqual(testImage.Size, card.ImageFront.Size);
            for (int x = 0; x < testImage.Width; x++)
                for (int y = 0; y < testImage.Height; y++)
                    Assert.AreEqual(testImage.GetPixel(x, y), card.ImageFront.GetPixel(x, y));
        }
    }
}