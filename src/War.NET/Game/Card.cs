using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarNET.Game
{
    /// <summary>
    /// All possible card ranks, ranging from 2-Ace.
    /// </summary>
    public enum Rank
    {
        D2, D3, D4, D5, D6, D7, D8, D9, D10, Jack, Queen, King, Ace
    }

    /// <summary>
    /// All possible card suits.
    /// </summary>
    public enum Suit
    {
        Clubs, Diamonds, Hearts, Spades
    }

    /// <summary>
    /// Define a card containing a rank and a suit.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The rank of the card.
        /// </summary>
        public readonly Rank Rank;

        /// <summary>
        /// The suit the card belongs to.
        /// </summary>
        public readonly Suit Suit;

        /// <summary>
        /// The image of the front of the card.
        /// </summary>
        public Image ImageFront;

        /// <summary>
        /// The image width of the cards.
        /// </summary>
        private int cardWidth = 180;

        /// <summary>
        /// The image width of the cards.
        /// </summary>
        private int cardWidthSpacing = 24;

        /// <summary>
        /// The image height of the cards.
        /// </summary>
        private int cardHeight = 250;

        /// <summary>
        /// The image height of the cards.
        /// </summary>
        private int cardHeightSpacing = 17;

        /// <summary>
        /// Create a new card with a pre-defined rank and suit.
        /// </summary>
        /// <param name="rank">The rank of this card.</param>
        /// <param name="suit">The suit this card belongs to.</param>
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
            ImageFront = CreateImageFront();
        }

        /// <summary>
        /// Creates the card's front image.
        /// </summary>
        /// <returns></returns>
        public Image CreateImageFront()
        {
            var sourceMap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream($"{GameEngine.RESOURCE_IMAGE_PATH}.{Suit}.png"));
            int i = Rank == Rank.Ace ? 0 : (int)Rank + 1;
            int offsetX = i % 5 * (cardWidth + cardWidthSpacing);
            offsetX = offsetX > sourceMap.Width - cardWidth ? (sourceMap.Width - cardWidth) : offsetX;
            int offsetY = (int)Math.Floor(i / 5.0) * (cardHeight + cardHeightSpacing);
            offsetY = offsetY > sourceMap.Height - cardHeight ? (sourceMap.Height - cardHeight) : offsetY;

            return sourceMap.Clone(new Rectangle(offsetX, offsetY, cardWidth, cardHeight), sourceMap.PixelFormat);
        }

        public override bool Equals(object obj)
        {
            return (obj is Card) && obj.GetHashCode() == GetHashCode();
        }

        /// <summary>
        /// Custom hash code for comparison between cards.
        /// </summary>
        /// <returns>The custom int hash code of this card.</returns>
        public override int GetHashCode()
        {
            return (int)Rank + (100 * ((int)Suit + 1)) + 1;
        }

        /// <summary>
        /// Show the card in text format {Rank} of {Suit}
        /// </summary>
        /// <returns>The string description of the card.</returns>
        public override string ToString()
        {
            return $"{Rank} of {Suit}".TrimStart('D');
        }
    }
}
