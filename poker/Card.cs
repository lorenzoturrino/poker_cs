using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        private int cardValue;
        private int cardSuit;

        public Card(int value, int suit)
        {
            cardValue = value;
            cardSuit = suit;
        }

        public int value
        {
            get { return cardValue; }
        }
        public int suit
        {
            get { return cardSuit;  }
        }

        public override string ToString()
        {
            return cardValue + " of " + getSuitString();
        }

        private string getSuitString()
        {
            if(cardSuit == 0)
            {
                return "Spades";
            }
            else if(cardSuit == 1)
            {
                return "Hearts";
            }
            else if(cardSuit == 2)
            {
                return "Diamonds";
            }
            else if(cardSuit == 3)
            {
                return "Clubs";
            }
            else
            {
                return "INVALID CARD SUIT";
            }
        }
    }
}
