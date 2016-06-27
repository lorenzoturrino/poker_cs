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
            updateScore();
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
            updateScore();
        }

        public void SwitchCard(Card newCard, int cardPosition)
        {
            playerHand[cardPosition] = newCard;
            updateScore();
        }

        private void updateScore()
        {
            if ( playerHand.Count < 5 )
            {
                handScore = -1;
            }
            else
            {
                handScore = 914;
            }

            foreach ( Card card in playerHand)
            {
             
            }
           
        }
    }
}
