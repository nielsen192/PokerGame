//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PokerGame
//    {

//        class HandEvaluator : Card
//        {
//            private int heartsSum;
//            private int diamondSum;
//            private int clubSum;
//            private int spadeSum;
//            private List<Card> cards;

//            private HandValue handvalue;

//            public HandEvaluator(List<Card> sortedHand)
//            {
//                heartsSum = 0;
//                diamondSum = 0;
//                clubSum = 0;
//                spadeSum = 0;
//                cards = sortedHand;
//                handvalue = new HandValue();
//            }

//            public HandValue HandValues { get; set; }

//            public List<Card> Cards
//            {
//                get { return cards; }
//                set
//                {
//                    cards.Add(value[0]);
//                    cards.Add(value[1]);
//                    cards.Add(value[2]);
//                    cards.Add(value[3]);
//                    cards.Add(value[4]);
//                }
//            }

//            public Hand EvaluateHand()
//            {
//                GetNumberOfSuits();
//                if (FourOfKind())
//                    return Hand.FourKind;
//                else if (FullHouse())
//                    return Hand.FullHouse;
//                else if (Flush())
//                    return Hand.Flush;
//                else if (Straight())
//                    return Hand.Straight;
//                else if (ThreeOfKind())
//                    return Hand.ThreeKind;
//                else if (TwoPairs())
//                    return Hand.TwoPairs;
//                else if (OnePair())
//                    return Hand.OnePair;

//                handvalue.HighCard = (int)cards[4].MyValue;
//                return Hand.Nothing;
//            }
//            private void GetNumberOfSuits()
//            {
//                foreach (var item in cards)
//                {
//                    if (item.MySuit == Card.SUIT.Hearts)
//                        heartsSum++;
//                    else if (item.MySuit == Card.SUIT.Diamonds)
//                        diamondSum++;
//                    else if (item.MySuit == Card.SUIT.Clubs)
//                        clubSum++;
//                    else if (item.MySuit == Card.SUIT.Spades)
//                        spadeSum++;
//                }
//            }
//        }
//    }

//}
//}
