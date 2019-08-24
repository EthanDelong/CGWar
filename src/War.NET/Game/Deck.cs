using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarNET.Game
{
    /// <summary>
    /// A deck initially consists of every combination of rank and suit of cards.
    /// A deck's size will decrease as cards are distributed among players.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// The current cards in this deck, in order.
        /// </summary>
        public List<Card> Cards;

        /// <summary>
        /// The number of cards in the deck.
        /// </summary>
        public int Size
        {
            get
            {
                return Cards?.Count ?? 0;
            }
        }

        /// <summary>
        /// Initialize the deck by getting a new set of cards and shuffling them.
        /// </summary>
        public Deck(int shuffleCount = 8, int? cutIndex = null, int randomSeed = 0)
        {
            Cards = CreateDeck();
            Shuffle(shuffleCount, cutIndex, randomSeed);
        }
        
        /// <summary>
        /// Get a fresh deck with all combinations of ranks and suits.
        /// </summary>
        /// <returns>The new deck with all card combinations.</returns>
        public List<Card> CreateDeck()
        {
            var newDeck = new List<Card>();
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    var card = new Card(rank, suit);
                    newDeck.Add(card);
                }
            }
            return newDeck;
        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        /// <param name="shuffleCount">The number of times to shuffle</param>
        /// <param name="cutIndex">The index to cut the cards at after shuffling.</param>
        /// <param name="randomSeed">Used for unit testing to "de-randomize" the shuffle by predefining the starting random seed</param>
        public void Shuffle(int shuffleCount = 8, int? cutIndex = null, int randomSeed = 0)
        {
            // Don't bother if we're not going to shuffle.
            if (shuffleCount <= 0)
                return;

            Random rand = new Random();
            if (randomSeed > 0)
                rand = new Random(randomSeed);

            for (int i = 0; i < shuffleCount; i++)
            {
                // While it would be easier to just loop through and shift cards with others, I thought it
                // might be fun to try and make the program shuffle similar to how a human might
                // shuffle a deck using the "riffle" method.

                // Begin by splitting the deck into almost halves
                Card[] left = Cards.Take(rand.Next(Cards.Count / 2 - 5, Cards.Count / 2 + 5)).ToArray();
                Card[] right = Cards.Skip(left.Length).ToArray();

                // Next, shuffle these into each other, randomly deciding if they're going into
                // the left or right side.
                Cards = new List<Card>();
                int leftIndex = 0, rightIndex = 0;
                for(int j = 0; j < left.Length + right.Length; j++)
                {
                    // Left
                    if (rand.Next(0, 2) == 0 && leftIndex < left.Length)
                        Cards.Add(left[leftIndex++]);
                    // Right
                    else if (rightIndex < right.Length)
                        Cards.Add(right[rightIndex++]);
                    // If we ran out of right cards, go back to adding the left side
                    else
                        Cards.Add(left[leftIndex++]);
                }
                // Now, we can repeat the shuffle as many times as desired.
            }

            // Lastly, we can simulate a "cut" of the deck by swapping at a random index.
            CutDeck(cutIndex ?? rand.Next(0, Cards.Count));
        }

        /// <summary>
        /// Cuts the deck at the specified index.
        /// </summary>
        /// <param name="cutIndex">The position to cut the cards.</param>
        public void CutDeck(int cutIndex)
        {
            Cards = Cards.Skip(cutIndex).Concat(Cards.Take(cutIndex)).ToList();
        }

        /// <summary>
        /// Deals the top card off the deck to the player specified.
        /// </summary>
        /// <param name="player">The receiving player.</param>
        public void DealOne(Player player)
        {
            player.GiveCard(Cards.First());
            Cards = Cards.Skip(1).ToList();
        }

        /// <summary>
        /// Distributes all the cards to each player.
        /// </summary>
        /// <param name="p1">The first player to deal to.</param>
        /// <param name="p2">The second player to deal to.</param>
        public void Deal(params Player[] players)
        {
            int currentPlayer = 0;
            while(Cards.Count > 0)
            {
                DealOne(players[currentPlayer++]);
                if (currentPlayer >= players.Length)
                    currentPlayer = 0;
            }
        }
    }
}
