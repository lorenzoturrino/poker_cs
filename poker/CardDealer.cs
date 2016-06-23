using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class CardDealer
    {
        private List<Card> cardDeck;
        private int rSeed;

        public CardDealer(List<Card> deck, int randSeed=42)
        {
            cardDeck = deck;
            rSeed = randSeed;
        }

        public void ScrambleDeck()
        {
            cardDeck = ScrambleList(cardDeck);
        }

        public Card GetCard()
        {
            Card dealtCard = cardDeck.First();
            cardDeck.Remove(dealtCard);
            return dealtCard;
        }

        private List<Card> ScrambleList(List<Card> oldList)
        {
            List<Card> newList = new List<Card>();
            Random rand = new Random(rSeed);
            while (oldList.Count > 0)
            {
                int randIndex = rand.Next(0, oldList.Count);
                Card moveCard = oldList[randIndex];
                oldList.RemoveAt(randIndex);
                newList.Add(moveCard);
            }
            return newList;
        }
    }
}
