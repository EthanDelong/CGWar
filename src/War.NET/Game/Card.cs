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
        /// The image of the back of the card.
        /// </summary>
        public Image ImageBack;

        /// <summary>
        /// Returns the default image of the back of a card.
        /// </summary>
        public static Image Back
        {
            get
            {
                return imageBack ?? CreateImageBack();
            }
        }

        /// <summary>
        /// Stores the static image of the back of the card. Only created once.
        /// </summary>
        private static Image imageBack;

        /// <summary>
        /// The image width of the cards.
        /// </summary>
        private const int CARD_WIDTH = 180;

        /// <summary>
        /// The image width of the cards.
        /// </summary>
        private const int CARD_WIDTH_SPACING = 24;

        /// <summary>
        /// The image height of the cards.
        /// </summary>
        private const int CARD_HEIGHT = 250;

        /// <summary>
        /// The image height of the cards.
        /// </summary>
        private const int CARD_HEIGHT_SPACING= 17;

        /// <summary>
        /// Dictionary containing all source map images for each suit.
        /// </summary>
        private static Dictionary<string, Bitmap> sourceMaps = new Dictionary<string, Bitmap>();

        /// <summary>
        /// Dictionary containing all card faces.
        /// </summary>
        private static Dictionary<string, Bitmap> cardFaces = new Dictionary<string, Bitmap>();

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
            ImageBack = CreateImageBack();
        }

        /// <summary>
        /// Creates the card's front image.
        /// </summary>
        /// <returns></returns>
        public Image CreateImageFront()
        {
            if (!sourceMaps.TryGetValue(Suit.ToString(), out Bitmap sourceMap))
            {
                sourceMap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream($"{GameEngine.RESOURCE_IMAGE_PATH}.{Suit}.png"));
                sourceMaps.Add(Suit.ToString(), sourceMap);
            }
            if(!cardFaces.TryGetValue(GetHashCode().ToString(), out Bitmap cardFace))
            {
                int i = Rank == Rank.Ace ? 0 : (int)Rank + 1;
                int offsetX = i % 5 * (CARD_WIDTH + CARD_WIDTH_SPACING);
                offsetX = offsetX > sourceMap.Width - CARD_WIDTH ? (sourceMap.Width - CARD_WIDTH) : offsetX;
                int offsetY = (int)Math.Floor(i / 5.0) * (CARD_HEIGHT + CARD_HEIGHT_SPACING);
                offsetY = offsetY > sourceMap.Height - CARD_HEIGHT ? (sourceMap.Height - CARD_HEIGHT) : offsetY;

                cardFace = sourceMap.Clone(new Rectangle(offsetX, offsetY, CARD_WIDTH, CARD_HEIGHT), sourceMap.PixelFormat);
                cardFaces.Add(GetHashCode().ToString(), cardFace);
            }
            return cardFace;
        }

        /// <summary>
        /// Get the back image of the card. Only need to create once since the back won't change.
        /// </summary>
        private static Image CreateImageBack()
        {
            if (imageBack == null)
            {
                imageBack = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream($"{GameEngine.RESOURCE_IMAGE_PATH}.Back.png"));
            }
            return imageBack;
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
