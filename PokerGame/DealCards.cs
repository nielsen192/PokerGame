﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class DealCards : DeckOfCards
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedPlayerHand = new Card[5];
            computerHand = new Card[5];
            sortedComputerHand = new Card[5];

        }

        public void Deal()
        {
            setUpDeck(); // create the deck of cards and shuffle them
            getHand();
            sortCards();
            displayCards();
            evaluateHands();
        }

        public void getHand()
        {
            for (int i = 0; i < 5; i++)
            {
                playerHand[i] = getDeck[i];
            }

            for (int i = 5; i < 10; i++)
            {
                computerHand[i - 5] = getDeck[i];
            }


        }

        public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyValue
                              select hand;

            var queryComputer = from hand in computerHand
                                orderby hand.MyValue
                                select hand;

            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedPlayerHand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                sortedComputerHand[index] = element;
                index++;
            }

        }

        public void displayCards()
        {
            Console.Clear();
            int x = 0; // x position of the cursor. We move it left and right
            int y = 1; // y position of the cursor. We move it up and down

            // display player hand
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("PLAYER'S HAND");
            for (int i = 0; i < 5; i++)
            {
                DrawCard.DrawCardOutline(x, y);
                DrawCard.DrawCardSuitValue(sortedPlayerHand[i], x, y);
                x++; // move to the right
            }
            y = 15; // move the row of computer cards below the player's cards
            x = 0;
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("COMPUTER'S HAND");
            for (int i = 5; i < 10; i++)
            {
                DrawCard.DrawCardOutline(x, y);
                DrawCard.DrawCardSuitValue(sortedComputerHand[i - 5], x, y);
                x++; // move to the right
            }
        }

        public void evaluateHands()
        {

        }
    }
}
