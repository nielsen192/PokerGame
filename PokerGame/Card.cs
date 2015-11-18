using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Card
    {
        public enum SUIT
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public enum VALUE
        {
            Two = 2, Three, Four, Five, Six, Seven,
            Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        // properties
        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}
