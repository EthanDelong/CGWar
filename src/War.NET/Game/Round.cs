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
            DEFAULT_NULL = 0,
            NOT_PLAYED,
            PLAYER_WIN,
            OPPONENT_WIN,
            WAR,
            GAMEOVER_PLAYER_WIN,
            GAMEOVER_OPPONENT_WIN,
            GAMEOVER_TIE
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
            Count = 1;
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
        public Result Next()
        {
            var playerCard = Game.Player.PlayNext();
            var opponentCard = Game.Opponent.PlayNext();
            PlayerCards.Add(playerCard);
            OpponentCards.Add(opponentCard);

            if (Game.Player.CardsLeft == 0 && Game.Opponent.CardsLeft == 0)
            {
                LastResult = Result.GAMEOVER_TIE;
            }
            else if(Game.Player.CardsLeft == 0)
            {
                LastResult = Result.GAMEOVER_OPPONENT_WIN;
            }
            else if(Game.Opponent.CardsLeft == 0)
            {
                LastResult = Result.GAMEOVER_PLAYER_WIN;
            }
            else if(LastResult == Result.WAR)
            {
                LastResult = Result.NOT_PLAYED;
            }
            else
            {
                LastResult = playerCard.Rank == opponentCard.Rank ? Result.WAR : (playerCard.Rank > opponentCard.Rank ? Result.PLAYER_WIN : Result.OPPONENT_WIN);
            }
            return LastResult;
        }

        /// <summary>
        /// Finishes the round by distributing the cards to the winner.
        /// </summary>
        public void Finish()
        {
            switch(LastResult)
            {
                case Result.OPPONENT_WIN:
                case Result.PLAYER_WIN:
                    var roundDeck = new Deck(PlayerCards.Concat(OpponentCards).ToList());
                    roundDeck.Shuffle();
                    (LastResult == Result.PLAYER_WIN ? Game.Player : Game.Opponent).GiveCardsAtEnd(roundDeck.Cards.ToArray());
                    PlayerCards = new List<Card>();
                    OpponentCards = new List<Card>();
                    Count++;
                    break;

                case Result.GAMEOVER_OPPONENT_WIN:
                case Result.GAMEOVER_PLAYER_WIN:
                case Result.GAMEOVER_TIE:
                    var cards = Game.Player.Hand.Concat(Game.Opponent.Hand).Concat(PlayerCards).Concat(OpponentCards);
                    Game.Deck.Cards.AddRange(cards);
                    Game.Deck.Shuffle(1);

                    Game.Player.Hand.Clear();
                    Game.Opponent.Hand.Clear();
                    PlayerCards.Clear();
                    OpponentCards.Clear();
                    break;
            }
        }
    }
}
