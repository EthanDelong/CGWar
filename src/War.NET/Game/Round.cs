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
            GAMEOVER_TIE,
            GAMEOVER_TIE_MAXROUNDS
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
        /// Pool of all cards.
        /// </summary>
        public List<Card> Pool
        {
            get
            {
                return (PlayerCards ?? new List<Card>()).Concat((OpponentCards ?? new List<Card>())).ToList();
            }
        }

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
        /// The current war bet count.
        /// </summary>
        public int CurrentWarBet = 0;

        /// <summary>
        /// Plays the round and returns the result.
        /// </summary>
        /// <returns>The result of the round.</returns>
        public Result Next()
        {
            if (LastResult == Result.GAMEOVER_TIE_MAXROUNDS)
                return LastResult;

            var playerCard = Game.Player.PlayNext();
            var opponentCard = Game.Opponent.PlayNext();
            PlayerCards.Add(playerCard);
            OpponentCards.Add(opponentCard);

            if(LastResult == Result.WAR)
            {
                // increment the war bet, and if the new bet meets the game's war bet setting, return not_played so that next round can kick off regular play
                if(++CurrentWarBet >= Game.WarBet)
                    LastResult = Result.NOT_PLAYED;
            }
            else
            {
                if(playerCard.Rank == opponentCard.Rank)
                {
                    LastResult = Result.WAR;
                    CurrentWarBet = 0;
                }
                else LastResult = playerCard.Rank > opponentCard.Rank ? Result.PLAYER_WIN : Result.OPPONENT_WIN;
            }
            if (Game.Player.CardsLeft == 0 && Game.Opponent.CardsLeft == 0)
            {
                LastResult = (LastResult == Result.WAR || LastResult == Result.NOT_PLAYED) ? Result.GAMEOVER_TIE : (LastResult == Result.PLAYER_WIN ? Result.GAMEOVER_PLAYER_WIN : Result.GAMEOVER_OPPONENT_WIN);
            }
            else if (Game.Player.CardsLeft == 0)
            {
                if (LastResult != Result.PLAYER_WIN)
                    LastResult = Result.GAMEOVER_OPPONENT_WIN;
            }
            else if (Game.Opponent.CardsLeft == 0)
            {
                if (LastResult != Result.OPPONENT_WIN)
                    LastResult = Result.GAMEOVER_PLAYER_WIN;
            }
            return LastResult;
        }

        /// <summary>
        /// Finishes the round by distributing the cards to the winner.
        /// </summary>
        public void Finish()
        {
            switch (LastResult)
            {
                case Result.OPPONENT_WIN:
                case Result.PLAYER_WIN:
                    var roundDeck = new Deck(Pool);
                    roundDeck.Shuffle();
                    (LastResult == Result.PLAYER_WIN ? Game.Player : Game.Opponent).GiveCardsAtEnd(roundDeck.Cards.ToArray());
                    PlayerCards = new List<Card>();
                    OpponentCards = new List<Card>();
                    Count++;
                    break;

                case Result.GAMEOVER_OPPONENT_WIN:
                case Result.GAMEOVER_PLAYER_WIN:
                case Result.GAMEOVER_TIE:
                case Result.GAMEOVER_TIE_MAXROUNDS:
                    var cards = Game.Player.Hand.Concat(Game.Opponent.Hand).Concat(Pool);
                    Game.Deck.Cards.AddRange(cards);
                    Game.Deck.Shuffle(1);

                    Game.Player.Hand.Clear();
                    Game.Opponent.Hand.Clear();
                    PlayerCards.Clear();
                    OpponentCards.Clear();
                    break;
            }

            if (Game.MaxRounds < GameEngine.MAXROUNDS_UPPER && Count > Game.MaxRounds)
            {
                LastResult = Result.GAMEOVER_TIE_MAXROUNDS;
                Count = Game.MaxRounds;
            }
        }
    }
}
