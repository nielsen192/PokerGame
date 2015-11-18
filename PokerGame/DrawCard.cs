﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class DrawCard
    {
        public static void DrawCardOutline(int xCoor, int yCoor)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int x = xCoor * 12;
            int y = yCoor;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(" __________\n");

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                {
                    Console.WriteLine("|          |");
                }
                else
                {
                    Console.WriteLine("|__________|");
                }
            }
        }

        public static void DrawCardSuitValue(Card card, int xCoor, int yCoor)
        {
            char cardSuit = ' ';
            int x = xCoor * 12;
            int y = yCoor;

            switch (card.MySuit)
            {
                case Card.SUIT.Hearts:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.Spades:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.SUIT.Clubs:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.SUIT.Diamonds:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(x + 5, y + 5);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.MyValue);
        }
    }
}
