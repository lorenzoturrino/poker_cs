using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Player
    {
        private List<Card> playerHand;

        public Player()
        {
            playerHand = new List<Card>();
        }

        public List<Card> hand
        {
            get { return playerHand; }
        }

        public void dealCard(Card newCard)
        {
            playerHand.Add(newCard);
        }
    }
}
