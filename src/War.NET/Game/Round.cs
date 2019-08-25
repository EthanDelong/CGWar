using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarNET.Game
{
    public class Round
    {
        /// <summary>
        /// Used to determine the result of the round.
        /// </summary>
        public enum Result
        {
            NOT_PLAYED,
            PLAYER_WIN,
            OPPONENT_WIN,
            WAR,
            GAMEOVER_PLAYER_WIN,
            GAMEOVER_OPPONENT_WIN
        }

        /// <summary>
        /// The cards the player has on the field.
        /// </summary>
        public List<Card> PlayerCards;

        /// <summary>
        /// The cards the opponent has on the field.
        /// </summary>
        public List<Card> OpponentCards;

        /// <summary>
        /// The current game engine.
        /// </summary>
        public GameEngine Game;

        /// <summary>
        /// Create a new round and setup a new list of cards.
        /// </summary>
        /// <param name="game"></param>
        public Round(GameEngine game)
        {
            Game = game;
            PlayerCards = new List<Card>();
            OpponentCards = new List<Card>();
            Count = 0;
        }

        /// <summary>
        /// The result of the last play.
        /// </summary>
        public Result LastResult;

        /// <summary>
        /// What round we are currently on.
        /// </summary>
        public int Count;

        /// <summary>
        /// Plays the round and returns the result.
        /// </summary>
        /// <returns>The result of the round.</returns>
        public Result Play()
        {
            var playerCard = Game.Player.PlayNext();
            if (playerCard == null)
                return Result.GAMEOVER_OPPONENT_WIN;
            PlayerCards.Add(playerCard);

            var opponentCard = Game.Opponent.PlayNext();
            if (opponentCard == null)
                return Result.GAMEOVER_PLAYER_WIN;
            OpponentCards.Add(opponentCard);

            return playerCard.Rank == opponentCard.Rank ? Result.WAR : (playerCard.Rank > opponentCard.Rank ? Result.PLAYER_WIN : Result.OPPONENT_WIN);
        }

        /// <summary>
        /// Finishes the round by distributing the cards to the winner.
        /// </summary>
        public void Finish()
        {
            if (LastResult == Result.PLAYER_WIN || LastResult == Result.OPPONENT_WIN)
            {
                var roundDeck = new Deck(PlayerCards.Concat(OpponentCards).ToList());
                roundDeck.Shuffle();
                (LastResult == Result.PLAYER_WIN ? Game.Player : Game.Opponent).GiveCardsAtEnd(roundDeck.Cards.ToArray());
                PlayerCards = new List<Card>();
                OpponentCards = new List<Card>();
            }

            if(LastResult == Result.GAMEOVER_PLAYER_WIN || LastResult == Result.GAMEOVER_OPPONENT_WIN)
            {
                var cards = Game.Player.Hand.Concat(Game.Opponent.Hand).Concat(PlayerCards).Concat(OpponentCards).ToList();
                Game.Deck.Cards = cards;
                Game.Deck.Shuffle(1);

                Game.Player.Hand = new List<Card>();
                Game.Opponent.Hand = new List<Card>();
                PlayerCards = new List<Card>();
                OpponentCards = new List<Card>();
            }
        }
    }
}
