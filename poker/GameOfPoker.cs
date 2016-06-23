using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class GameOfPoker
    {
        public static void Main()
        {
            List<Card> cardList = new List<Card>();
            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card newCard = new Card(i, j);
                    cardList.Add(newCard);
                }
            }
            int rSeed = Environment.TickCount;
            CardDealer deck = new CardDealer(cardList, rSeed);
            deck.ScrambleDeck();

            Console.WriteLine("Your current hand is");
            for (int i = 0; i < 5; i++)
            {
                Card currentCard = deck.GetCard();
                Console.WriteLine(currentCard);
            }
        }
        
    }
}
