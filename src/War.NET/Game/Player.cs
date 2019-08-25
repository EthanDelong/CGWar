using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarNET.Properties;

namespace WarNET.Game
{
    /// <summary>
    /// A player has a hand of cards, given to them by the game (distributed from the deck).
    /// Their only option is to PlayNext card from their hand.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The set of cards that this player is holding.
        /// </summary>
        public List<Card> Hand;

        /// <summary>
        /// Returns the size of the player's hand.
        /// </summary>
        public int CardsLeft
        {
            get
            {
                return Hand.Count;
            }
        }

        /// <summary>
        /// Create a new player with an empty hand.
        /// </summary>
        public Player()
        {
            Hand = new List<Card>();
        }

        /// <summary>
        /// Gives the specified card to this player, adding it to the top of their hand.
        /// </summary>
        /// <param name="card">The card to add to this player's hand.</param>
        /// <param name="insertTop">Whether to add this card to the top of the hand or not.</param>
        public void GiveCard(Card card, bool insertTop = true)
        {
            if (insertTop)
                Hand.Insert(0, card);
            else
                Hand.Add(card);
        }

        /// <summary>
        /// Gives the specified cards to this player, adding it to the end of their hand.
        /// </summary>
        /// <param name="card">The cards to add to this player's hand.</param>
        public void GiveCardsAtEnd(params Card[] cards)
        {
            cards.ToList().ForEach(c => GiveCard(c, false));
        }

        /// <summary>
        /// Gets the top card in the player's hand and then removes it from the hand before returning it.
        /// </summary>
        /// <returns>The top card on the player's hand.</returns>
        public Card PlayNext()
        {
            if (Hand?.Count < 1)
                return null;

            var nextCard = Hand.First();
            Hand = Hand.Skip(1).ToList();
            return nextCard;
        }
    }
}
