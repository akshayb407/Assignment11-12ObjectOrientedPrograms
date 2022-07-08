using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class DeckOfCards
    {
        private Card[] deck;
        private int currentCard;
        readonly private int numberOfCards = 52;
        private Random randomNumber;


        public DeckOfCards()
        {


            string[] face =
            {
                "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Jack", "Queen", "King"
            };

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            this.deck = new Card[this.numberOfCards];
            this.currentCard = 0;
            this.randomNumber = new Random();

            for (int i = 0; i < this.numberOfCards; i++)
            {
                this.deck[i] = new Card(face[i % 13], suits[i % 3]);
            }
        }

        public void Shuffle()
        {
            this.currentCard = 0;
            for (int i = 0; i < this.deck.Length; i++)
            {
                int sec = this.randomNumber.Next(this.numberOfCards);

                Card temp = this.deck[i];
                this.deck[i] = this.deck[sec];
                this.deck[sec] = temp;
            }
        }
        internal Card TakeCard()
        {
            if (this.currentCard < this.deck.Length)
            {
                return this.deck[this.currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
