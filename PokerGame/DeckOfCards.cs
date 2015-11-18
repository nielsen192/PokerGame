using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class DeckOfCards : Card
    {
        const int Num_Of_Cards = 52; // number of all cards
        private Card[] deck; // array of all playing cards

        public DeckOfCards()
        {
            deck = new Card[Num_Of_Cards];
        }

        public Card[] getDeck { get { return deck; } } // get current deck

        // create deck of 52 cards: 13 values, each with 4 suits
        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }
        // shuffle the deck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            // run the shuffle 500 times
            for (int shuffleTimes = 0; shuffleTimes < 500; shuffleTimes++)
            {
                for (int i = 0; i < Num_Of_Cards; i++)
                {
                    // swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}