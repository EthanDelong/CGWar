﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGWar
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
        readonly Rank Rank;

        /// <summary>
        /// The suit the card belongs to.
        /// </summary>
        readonly Suit Suit;

        /// <summary>
        /// Create a new card with a pre-defined rank and suit.
        /// </summary>
        /// <param name="rank">The rank of this card.</param>
        /// <param name="suit">The suit this card belongs to.</param>
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}".TrimStart('D');
        }
    }
}