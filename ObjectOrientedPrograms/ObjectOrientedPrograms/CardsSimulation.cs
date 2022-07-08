using System.Collections.Generic;
using System;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class CardsSimulation
    {
        public void DriverMethod()
        {

            DeckOfCards deckOfCards = new();

            deckOfCards.Shuffle();

            Player[] players = new Player[4];

            for (int i = 0; i < 4; i++)
            {
                players[i] = new Player();
                players[i].cards = new List<Card>();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    players[i].cards.Add(deckOfCards.TakeCard());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(players[i]);
            }
        }
    }
    public class Player
    {
        internal List<Card> cards;
        public override string ToString()
        {
            return cards.ToString();
        }
    }

}