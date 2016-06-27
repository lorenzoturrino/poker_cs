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
        private int handScore;

        public Player()
        {
            playerHand = new List<Card>();
            handScore = calculateScore();
        }

        public List<Card> hand
        {
            get { return playerHand; }
        }

        public int score
        {
            get { return handScore; }
        }

        public void DealCard(Card newCard)
        {
            playerHand.Add(newCard);
        }

        public void SwitchCard(Card newCard, int cardPosition)
        {
            playerHand[cardPosition] = newCard;
        }

        private int calculateScore()
        {
            if ( playerHand.Count < 5 )
            {
                return -1;
            }

            foreach ( Card card in playerHand)
            {
             
            }
            return 0;
        }
    }
}
